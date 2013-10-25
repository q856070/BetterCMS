﻿using BetterCms.Core.DataAccess.DataContext.Migrations;

using FluentMigrator;

namespace BetterCms.Module.Root.Models.Migrations
{
    [Migration(201310241500)]
    public class Migration201310241500 : DefaultMigration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Migration201310241500"/> class.
        /// </summary>
        public Migration201310241500()
            : base(RootModuleDescriptor.ModuleName)
        {
        }

        public override void Up()
        {
            // Set layout id as nullable
            Alter
                .Column("LayoutId")
                .OnTable("Pages").InSchema(SchemaName)
                .AsGuid().Nullable();

            // Create nullable master page id
            Create
                .Column("MasterPageId")
                .OnTable("Pages").InSchema(SchemaName)
                .AsGuid().Nullable();

            Create
                .ForeignKey("FK_Cms_Pages_Cms_Pages")
                .FromTable("Pages").InSchema(SchemaName).ForeignColumn("MasterPageId")
                .ToTable("Pages").InSchema(SchemaName).PrimaryColumn("Id");

            // Create content regions table
            Create
                .Table("ContentRegions").InSchema(SchemaName)
                .WithCmsBaseColumns()
                .WithColumn("RegionId").AsGuid().NotNullable()
                .WithColumn("ContentId").AsGuid().NotNullable();

            Create
                .ForeignKey("FK_Cms_ContentRegions_Cms_Contents")
                .FromTable("ContentRegions").InSchema(SchemaName).ForeignColumn("ContentId")
                .ToTable("Contents").InSchema(SchemaName).PrimaryColumn("Id");

            Create
                .ForeignKey("FK_Cms_ContentRegions_Cms_Regions")
                .FromTable("ContentRegions").InSchema(SchemaName).ForeignColumn("RegionId")
                .ToTable("Regions").InSchema(SchemaName).PrimaryColumn("Id");

            // Create flag, indicating, that page is master page
            Create
                .Column("IsMasterPage")
                .OnTable("Pages").InSchema(SchemaName)
                .AsBoolean().NotNullable().WithDefaultValue(false);
        }       
    }
}