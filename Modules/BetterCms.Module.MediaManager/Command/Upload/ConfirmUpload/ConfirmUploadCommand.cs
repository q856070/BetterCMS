﻿using System;
using System.Collections.Generic;
using System.Linq;

using BetterCms.Core.Exceptions;
using BetterCms.Core.Mvc.Commands;
using BetterCms.Module.MediaManager.Models;
using BetterCms.Module.MediaManager.Models.Extensions;
using BetterCms.Module.MediaManager.ViewModels.MediaManager;
using BetterCms.Module.MediaManager.ViewModels.Upload;
using BetterCms.Module.Root.Models;
using BetterCms.Module.Root.Mvc;

namespace BetterCms.Module.MediaManager.Command.Upload.ConfirmUpload
{
    public class ConfirmUploadCommand : CommandBase, ICommand<MultiFileUploadViewModel, ConfirmUploadResponse>
    {
        private readonly ICmsConfiguration cmsConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmUploadCommand"/> class.
        /// </summary>
        /// <param name="cmsConfiguration">The CMS configuration.</param>
        public ConfirmUploadCommand(ICmsConfiguration cmsConfiguration)
        {
            this.cmsConfiguration = cmsConfiguration;
        }

        /// <summary>
        /// Executes this command.
        /// </summary>
        public ConfirmUploadResponse Execute(MultiFileUploadViewModel request)
        {
            ConfirmUploadResponse response = new ConfirmUploadResponse { SelectedFolderId = request.SelectedFolderId ?? Guid.Empty, ReuploadMediaId = request.ReuploadMediaId };

            if (request.UploadedFiles != null && request.UploadedFiles.Count > 0)
            {
                MediaFolder folder = null;

                if (request.SelectedFolderId != null && request.SelectedFolderId.Value != Guid.Empty)
                {
                    folder = Repository.AsProxy<MediaFolder>(request.SelectedFolderId.Value);
                    if (folder.IsDeleted)
                    {
                        response.FolderIsDeleted = true;
                        return response;
                    }
                }

                UnitOfWork.BeginTransaction();

                List<MediaFile> files = new List<MediaFile>();
                if (request.ReuploadMediaId.HasDefaultValue())
                {
                    foreach (var fileId in request.UploadedFiles)
                    {
                        if (!fileId.HasDefaultValue())
                        {
                            var file = Repository.FirstOrDefault<MediaFile>(fileId);
                            if (folder != null && (file.Folder == null || file.Folder.Id != folder.Id))
                            {
                                file.Folder = folder;
                            }
                            file.IsTemporary = false;
                            file.PublishedOn = DateTime.Now;
                            Repository.Save(file);
                            files.Add(file);
                        }
                    }
                }
                else
                {
                    // Re-upload performed.
                    var fileId = request.UploadedFiles.FirstOrDefault();
                    if (!fileId.HasDefaultValue())
                    {
                        var originalMedia = Repository.First<MediaFile>(request.ReuploadMediaId);
                        var historyItem = originalMedia.CreateHistoryItem();
                        Repository.Save(historyItem);

                        var file = Repository.FirstOrDefault<MediaFile>(fileId);
                        file.CopyDataTo(originalMedia);

                        originalMedia.Description = historyItem.Description;
                        originalMedia.IsArchived = historyItem.IsArchived;
                        originalMedia.Folder = historyItem.Folder;
                        originalMedia.Image = historyItem.Image;
                        if (file is MediaImage && originalMedia is MediaImage)
                        {
                            ((MediaImage)originalMedia).Caption = ((MediaImage)historyItem).Caption;
                            ((MediaImage)originalMedia).ImageAlign = ((MediaImage)historyItem).ImageAlign;
                        }

                        originalMedia.IsTemporary = false;
                        originalMedia.PublishedOn = DateTime.Now;
                        files.Add(originalMedia);
                    }
                }

                if (cmsConfiguration.AccessControlEnabled)
                {
                    foreach (var userAccess in files.SelectMany(x => request.UserAccessList.Select(model => new UserAccess
                    {
                        ObjectId = x.Id,
                        AccessLevel = model.AccessLevel,
                        RoleOrUser = model.RoleOrUser
                    })))
                    {
                        Repository.Save(userAccess);
                    }
                }

                UnitOfWork.Commit();

                response.Medias = files.Select(Convert).ToList();

                // Notify.
                foreach (var mediaFile in files)
                {
                    Events.MediaManagerEvents.Instance.OnMediaFileUpdated(mediaFile);
                }
            }

            return response;
        }

        private MediaFileViewModel Convert(MediaFile file)
        {
            MediaFileViewModel model;
            bool isProcessing = !file.IsUploaded.HasValue;
            bool isFailed = file.IsUploaded.HasValue && !file.IsUploaded.Value;

            if (file.Type == MediaType.File)
            {
                model = new MediaFileViewModel();
            }
            else if (file.Type == MediaType.Audio)
            {
                model = new MediaAudioViewModel();
            }
            else if (file.Type == MediaType.Video)
            {
                model = new MediaVideoViewModel();
            }
            else if (file.Type == MediaType.Image)
            {
                var imageFile = (MediaImage)file;
                model = new MediaImageViewModel
                {
                    ThumbnailUrl = imageFile.PublicThumbnailUrl,
                    Tooltip = imageFile.Title
                };
                isProcessing = isProcessing || !imageFile.IsOriginalUploaded.HasValue || !imageFile.IsThumbnailUploaded.HasValue;
                isFailed = isFailed
                    || (imageFile.IsOriginalUploaded.HasValue && !imageFile.IsOriginalUploaded.Value)
                    || (imageFile.IsThumbnailUploaded.HasValue && !imageFile.IsThumbnailUploaded.Value);
            }
            else
            {
                throw new CmsException(string.Format("A file type {0} is not supported.", file.Type));
            }

            model.Id = file.Id;
            model.Name = file.Title;
            model.Type = file.Type;
            model.Version = file.Version;
            model.ContentType = MediaContentType.File;
            model.PublicUrl = file.PublicUrl;
            model.FileExtension = file.OriginalFileExtension;
            model.IsProcessing = isProcessing;
            model.IsFailed = isFailed;

            return model;
        }
    }
}
