﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Pages.Views.Widgets
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Pages.ViewModels.Widgets;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/EditServerControlWidget.cshtml")]
    public partial class EditServerControlWidget : System.Web.Mvc.WebViewPage<EditServerControlWidgetViewModel>
    {
        public EditServerControlWidget()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 9 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
 if (Model == null)
{
    return;
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-tab-header\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" class=\"bcms-tab bcms-tab-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                           Write(PagesGlobalization.EditWidget_BasicPropertiesTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <a");

WriteLiteral(" class=\"bcms-tab\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                           Write(PagesGlobalization.EditWidget_OptionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n</div>\r\n<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 18 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
Write(Html.TabbedContentMessagesBox("bcms-edit-widget-messages"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 19 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
Write(Html.Partial("Partial/WarnMessageAboutDraft", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 20 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
     using (Html.BeginForm<WidgetsController>(c => c.EditServerControlWidget((string)null), FormMethod.Post, new { @id = "bcms-widget-form", @class = "bcms-ajax-form" }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 25 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.Tooltip(PagesGlobalization.Widget_Title_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                Write(PagesGlobalization.Widget_Title_Title);

            
            #line default
            #line hidden
WriteLiteral(":</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(" style=\"width: 523px;\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 28 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.TextBoxFor(model => model.Name, new { @class = "bcms-editor-field-box" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 29 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 34 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.Tooltip(PagesGlobalization.Widget_Category_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                Write(PagesGlobalization.Widget_Category_Title);

            
            #line default
            #line hidden
WriteLiteral(":</div>\r\n");

WriteLiteral("                    ");

            
            #line 36 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.DropDownListFor(model => model.CategoryId, Model.Categories.ToSelectList(Model.CategoryId), PagesGlobalization.Widget_Category_SelectCategory, new { @class = "bcms-global-select" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.Tooltip(PagesGlobalization.Widget_Url_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                Write(PagesGlobalization.Widget_Url_Title);

            
            #line default
            #line hidden
WriteLiteral(":</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(" style=\"width: 523px;\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 43 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.TextBoxFor(model => model.Url, new { @class = "bcms-editor-field-box" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 44 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.Url));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 49 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.Tooltip(PagesGlobalization.WidgetPreviewImageUrl_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 50 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                Write(PagesGlobalization.WidgetPreviewImageUrl_Title);

            
            #line default
            #line hidden
WriteLiteral(":</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(" style=\"width: 523px;\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 52 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.TextBoxFor(model => model.PreviewImageUrl, new { @class = "bcms-editor-field-box" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 53 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.PreviewImageUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 58 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
               Write(Html.Tooltip(PagesGlobalization.WidgetPreviewImage_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                Write(PagesGlobalization.WidgetPreviewImage_Title);

            
            #line default
            #line hidden
WriteLiteral(":</div>\r\n\r\n                    <div");

WriteLiteral(" class=\"bcms-preview-module-image\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" id=\"bcms-widget-preview-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 3605), Tuple.Create("\"", 3633)
            
            #line 63 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
, Tuple.Create(Tuple.Create("", 3611), Tuple.Create<System.Object, System.Int32>(Model.PreviewImageUrl
            
            #line default
            #line hidden
, 3611), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n\r\n              " +
"  </div>\r\n            </div>\r\n        </div>\r\n");

            
            #line 70 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 72 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
       Write(Html.Partial(PagesConstants.OptionsGridTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 74 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
        
        
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
   Write(Html.HiddenFor(model => model.Id, new { @id = "bcmsContentId" }));

            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                         
        
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
   Write(Html.HiddenFor(model => model.Version, new { @id = "bcmsContentVersion" }));

            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                                   
        
            
            #line default
            #line hidden
            
            #line 77 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
   Write(Html.HiddenFor(modal => modal.DesirableStatus, new { @class = "bcms-content-desirable-status" }));

            
            #line default
            #line hidden
            
            #line 77 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                                                         
        
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
   Write(Html.HiddenFor(modal => modal.PreviewOnPageContentId, new { @class = "bcms-preview-page-content-id" }));

            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                                                                                                               
        
            
            #line default
            #line hidden
            
            #line 79 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
   Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 79 "..\..\Views\Widgets\EditServerControlWidget.cshtml"
                            
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
