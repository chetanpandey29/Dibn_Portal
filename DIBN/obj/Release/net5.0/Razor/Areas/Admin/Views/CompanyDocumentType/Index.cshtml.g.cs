#pragma checksum "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ffbee00e5a614a3fc0012297f0b0eb0b4555092302f105087362daac75dc59cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CompanyDocumentType_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CompanyDocumentType/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN

#nullable disable
    ;
#nullable restore
#line 2 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.Models

#nullable disable
    ;
#nullable restore
#line 3 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.Data

#nullable disable
    ;
#nullable restore
#line 4 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.IRepository

#nullable disable
    ;
#nullable restore
#line 5 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.Repository

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ffbee00e5a614a3fc0012297f0b0eb0b4555092302f105087362daac75dc59cb", @"/Areas/Admin/Views/CompanyDocumentType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"605a41b4408e5d1ff247f7264e35f4305eb9eeecf14a77cb4f30041778bbf31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_CompanyDocumentType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DIBN.Areas.Admin.Models.MainCompanyDocumentTypeModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-responsive/js/dataTables.responsive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-responsive-bs4/js/responsive.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-bs4/js/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable

            WriteLiteral("<div id=\"loader\">\r\n    <div class=\"spinner-1\">\r\n        <div class=\"center-div-1\">\r\n            <div class=\"loader-circle-75\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 14 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
 if (Model.allowedModule.Contains("Insert"))
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <button type=\"button\" class=\"btn btn-theme pull-right\" style=\"float:right;margin-bottom:15px;\" onclick=\"AddNew();\" id=\"Insert\">Create</button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
}

#line default
#line hidden
#nullable disable

#nullable restore
#line 22 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
 if (Model.allowedModule.Contains("View"))
{

#line default
#line hidden
#nullable disable

            WriteLiteral(@"    <div class=""row"" id=""View"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title text-center"">Company Document Type(s)</h4>
                    <hr style=""height:1px;"" class=""text-theme"" />
                    <div class=""table-rep-plugin"">
                        <div class=""table-responsive mb-0"" data-pattern=""priority-columns"">
                            <table id=""datatable"" class=""table table-bordered table-striped dt-responsive nowrap"" style=""border-collapse: collapse; border-spacing: 0; width: 100%;"">
                                <thead>
                                    <tr>
                                        <th>
                                            #
                                        </th>
                                        <th>
                                            Name
                                        </th>
");
#nullable restore
#line 41 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                         if (Model.allowedModule.Contains("Delete") || Model.allowedModule.Contains("Update"))
                                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                            <th class=\"Update Delete\">\r\n\r\n                                            </th>\r\n");
#nullable restore
#line 46 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 50 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                      
                                        var i = 0;
                                    

#line default
#line hidden
#nullable disable

#nullable restore
#line 53 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                     foreach (var item in Model.documentTypes)
                                    {
                                        

#line default
#line hidden
#nullable disable

#nullable restore
#line 55 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                         if (item.DocumentName != null)
                                        {


#line default
#line hidden
#nullable disable

            WriteLiteral("                                            <tr>\r\n                                                <td>");
            Write(
#nullable restore
#line 59 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                      i + 1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    ");
            Write(
#nullable restore
#line 61 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                     item.DocumentName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                                </td>\r\n");
#nullable restore
#line 63 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                 if (Model.allowedModule.Contains("Delete") || Model.allowedModule.Contains("Update"))
                                                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                                    <td class=\"Delete Update\">\r\n");
#nullable restore
#line 66 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                         if (Model.allowedModule.Contains("Update"))
                                                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                                            <span class=\"btn btn-theme Update\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3265, "\"", 3291, 3);
            WriteAttributeValue("", 3275, "Update(", 3275, 7, true);
            WriteAttributeValue("", 3282, 
#nullable restore
#line 68 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                                                                                item.ID

#line default
#line hidden
#nullable disable
            , 3282, 8, false);
            WriteAttributeValue("", 3290, ")", 3290, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                <i class=\"fas fa-edit\"></i>\r\n                                                            </span>\r\n");
#nullable restore
#line 71 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable

#nullable restore
#line 72 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                         if (Model.allowedModule.Contains("Delete"))
                                                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                                            <span class=\"btn btn-theme Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3771, "\"", 3797, 3);
            WriteAttributeValue("", 3781, "Remove(", 3781, 7, true);
            WriteAttributeValue("", 3788, 
#nullable restore
#line 74 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                                                                                item.ID

#line default
#line hidden
#nullable disable
            , 3788, 8, false);
            WriteAttributeValue("", 3796, ")", 3796, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                <i class=\"fas fa-trash\"></i>\r\n                                                            </span>\r\n");
#nullable restore
#line 77 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                                                        \r\n                                                    </td>\r\n");
#nullable restore
#line 80 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                                                \r\n                                            </tr>\r\n");
#nullable restore
#line 83 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                                            <tr>
                                                <td></td>
                                                <td>
                                                    No data found.
                                                </td>
");
#nullable restore
#line 91 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                 if (Model.allowedModule.Contains("Delete") || Model.allowedModule.Contains("Update"))
                                                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                                    <td class=\"Delete Update\">\r\n                                                    </td>\r\n");
#nullable restore
#line 95 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                                            </tr>\r\n");
#nullable restore
#line 97 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable

#nullable restore
#line 97 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                         
                                        i++;
                                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 108 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<!--Create New Company Document Type-->

<div id=""CreateType"" class=""modal"" tabindex=""-1"" data-bs-keyboard=""false"" data-bs-backdrop=""static"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Add New Company Document Type</h5>
                <button type=""button"" class=""close btn btn-theme"" id=""CreateModalClose"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
            </div>
        </div>
    </div>
</div>

<!--Edit Company Document Type-->

<div id=""EditType"" class=""modal"" tabindex=""-1"" data-bs-keyboard=""false"" data-bs-backdrop=""static"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Edit</h5>
                <butto");
            WriteLiteral(@"n type=""button"" class=""close btn btn-theme"" id=""EditModalClose"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
            </div>
        </div>
    </div>
</div>
<input type=""hidden"" name=""Module"" id=""Module""");
            BeginWriteAttribute("value", " value=\"", 6838, "\"", 6859, 1);
            WriteAttributeValue("", 6846, 
#nullable restore
#line 143 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                                                       Model.Module

#line default
#line hidden
#nullable disable
            , 6846, 13, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbee00e5a614a3fc0012297f0b0eb0b4555092302f105087362daac75dc59cb20322", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbee00e5a614a3fc0012297f0b0eb0b4555092302f105087362daac75dc59cb21390", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Responsive examples -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbee00e5a614a3fc0012297f0b0eb0b4555092302f105087362daac75dc59cb22490", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbee00e5a614a3fc0012297f0b0eb0b4555092302f105087362daac75dc59cb23554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Required datatable js -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbee00e5a614a3fc0012297f0b0eb0b4555092302f105087362daac75dc59cb24652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbee00e5a614a3fc0012297f0b0eb0b4555092302f105087362daac75dc59cb25716", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Sweet Alerts-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbee00e5a614a3fc0012297f0b0eb0b4555092302f105087362daac75dc59cb26804", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ffbee00e5a614a3fc0012297f0b0eb0b4555092302f105087362daac75dc59cb27868", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    var table = $('#datatable').DataTable({
        responsive:true,
        paging: true,
        ordering: true,
        searching: true,
        ""aLengthMenu"": [20, 30, 50],
        dom: ""<'row'<'col-sm-3'l><'col-sm-3'f><'col-sm-6'p>>"" +
            ""<'row'<'col-sm-12'tr>>"" +
            ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
    });

    $(document).ready(function () {
        $(""#loader"").hide();
    });
</script>
<script>
    $(""#CreateModalClose"").on(""click"", function () {
        window.location.reload();
    });
    $(""#EditModalClose"").on(""click"", function () {
        window.location.reload();
    });
</script>
<script>
    function AddNew() {
        var module = $(""#Module"").val();
        $.ajax({
            url: """);
            Write(
#nullable restore
#line 185 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                   Url.Action("Create","CompanyDocumentType")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
            method: ""GET"",
            data: { ""name"": module },
            success: function (response) {
                $mymodal = $(""#CreateType"");
                $mymodal.find(""div.modal-body"").html(response);
                $mymodal.modal(""show"");
            }
        });
    }
</script>
<script>
    function Update(Id) {
        var module = $(""#Module"").val();
        $.ajax({
            url: """);
            Write(
#nullable restore
#line 200 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                   Url.Action("Edit","CompanyDocumentType")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
            method: ""GET"",
            data: { ""name"": module, ""Id"": Id },
            success: function (response) {
                $mymodal = $(""#EditType"");
                $mymodal.find(""div.modal-body"").html(response);
                $mymodal.modal(""show"");
            }
        });
    }
</script>
<script>
    function Remove(Id) {
        event.preventDefault();
        const swalWithBootstrapButtons = Swal.mixin({
            customClass: {
                confirmButton: 'ms-3 btn btn-success',
                cancelButton: 'btn btn-danger'
            },
            buttonsStyling: false
        })

        swalWithBootstrapButtons.fire({
            title: 'Are you sure?',
            text: ""You won't be able to revert this!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonText: 'Yes, delete it!',
            cancelButtonText: 'No, cancel!',
            reverseButtons: true,
            showConfirmButton: true,
        })");
            WriteLiteral(".then((result) => {\r\n            if (result.isConfirmed) {\r\n                $(\"#loader\").show();\r\n                $.ajax({\r\n                    url: \"");
            Write(
#nullable restore
#line 235 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\CompanyDocumentType\Index.cshtml"
                           Url.Action("Remove", "CompanyDocumentType")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
                    method: ""GET"",
                    data: { ""Id"": Id },
                    success: function (response) {
                        $(""#loader"").hide();
                        swalWithBootstrapButtons.fire({
                            title: 'Deleted.',
                            text: ""Document Type Deleted Successfully..!!"",
                            icon: 'success'
                        }).then((result) => {
                            window.location.reload();
                        });
                    }
                });
            }
            else if (
                result.dismiss === Swal.DismissReason.cancel
            ) {
                $(""#loader"").hide();
                swalWithBootstrapButtons.fire(
                    'Cancelled',
                    'Cancled by User..!! :)',
                    'error'
                )
            }
        });
    }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DIBN.Areas.Admin.Models.MainCompanyDocumentTypeModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
