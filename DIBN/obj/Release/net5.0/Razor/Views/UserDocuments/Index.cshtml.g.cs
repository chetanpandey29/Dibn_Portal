#pragma checksum "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserDocuments_Index), @"mvc.1.0.view", @"/Views/UserDocuments/Index.cshtml")]
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
#line 1 "D:\Devotion Business\DIBN\DIBN\Views\_ViewImports.cshtml"
using DIBN

#nullable disable
    ;
#nullable restore
#line 2 "D:\Devotion Business\DIBN\DIBN\Views\_ViewImports.cshtml"
using DIBN.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e", @"/Views/UserDocuments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7d5ddeb28e6b11bd8a350250841d25befde6ee969eb2ffe12afe4b0408fac805", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UserDocuments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DIBN.Models.UserDocumentsViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadSelectedDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserDocuments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-bs4/js/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-responsive/js/dataTables.responsive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-responsive-bs4/js/responsive.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"<div id=""loader"">
    <div class=""spinner-1"">
        <div class=""center-div-1"">
            <div class=""loader-circle-75"">
            </div>
        </div>
    </div>
</div>
<div class=""row"" id=""View"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title text-center"">Documents(s)</h4>
                <hr class=""text-theme"" style=""height:1px !important;""/>
                <div class=""table-rep-plugin"">
                    <div class=""table-responsive mb-0"" data-pattern=""priority-columns"">
                        <table id=""datatable"" class=""table table-bordered table-striped dt-responsive nowrap"" style=""border-collapse: collapse; border-spacing: 0; width: 100%;"">
                            <thead>
                                <tr>
                                    <th>
                                        #
                                    </th>
                                    <th>
                ");
            WriteLiteral(@"                        Documents
                                    </th>
                                    <th>
                                        Authority Name
                                    </th>
                                    <th>
                                        Issue Date
                                    </th>
                                    <th>
                                        Expiry Date
                                    </th>

                                    <th>

                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 47 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                  
                                    var i = 0;
                                

#line default
#line hidden
#nullable disable

#nullable restore
#line 50 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    

#line default
#line hidden
#nullable disable

#nullable restore
#line 52 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                     if (item.IssueDate != null)
                                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                        <tr>\r\n                                            <td>");
            Write(
#nullable restore
#line 55 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                                  i + 1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                            <td>");
            Write(
#nullable restore
#line 56 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                                 item.DocumentTypeName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                            <td>");
            Write(
#nullable restore
#line 57 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                                 item.AuthorityName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                            <td>");
            Write(
#nullable restore
#line 58 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                                 item.IssueDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                            <td>");
            Write(
#nullable restore
#line 59 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                                 item.ExpiryDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e12604", async() => {
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e12939", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => 
#nullable restore
#line 62 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                                                                   item.Id

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    <input type=\"submit\" value=\"Download\" name=\"Download\" class=\"btn btn-theme\" />\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 67 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                        i++;
                                    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 68 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 78 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
 foreach (var data in Model)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <input type=\"hidden\" name=\"Module\"");
            BeginWriteAttribute("value", " value=\"", 3539, "\"", 3559, 1);
            WriteAttributeValue("", 3547, 
#nullable restore
#line 80 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                               data.Module

#line default
#line hidden
#nullable disable
            , 3547, 12, false);
            EndWriteAttribute();
            WriteLiteral(" id=\"Module\" />\r\n");
#nullable restore
#line 81 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
    break;
}

#line default
#line hidden
#nullable disable

            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e18377", async() => {
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
            WriteLiteral("\r\n<!-- Required datatable js -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e19475", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e20539", async() => {
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
            WriteLiteral("\r\n\r\n<!-- Responsive examples -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e21639", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e22703", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Sweet Alerts-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e23791", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8dcedab18de4cf6cc4b76bca09e86d61d405f9e6b4f106a4e0e25c12f54a405e24856", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $('#datatable').dataTable({
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
    $(function () {

        const swalWithBootstrapButtons = Swal.mixin({
            customClass: {
                confirmButton: 'ms-3 btn btn-success',
                cancelButton: 'btn btn-danger'
            },
            buttonsStyling: false
        })
        var message = '");
            Write(
#nullable restore
#line 120 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                        ViewData["Message"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"';
        if (message != """") {
            if (message.startsWith(""Document"")) {
                swalWithBootstrapButtons.fire({
                    title: 'Success.',
                    text: message,
                    icon: 'success'
                }).then((result) => {
                    message = """";
                    window.location.href = """);
            Write(
#nullable restore
#line 129 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                             Url.Action("Index","UserDocuments")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""";
                });
            } else {
                swalWithBootstrapButtons.fire({
                    title: 'Failed.',
                    text: message,
                    icon: 'error'
                }).then((result) => {
                    message = """";
                    window.location.href = """);
            Write(
#nullable restore
#line 138 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                             Url.Action("Index","UserDocuments")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\";\r\n                });\r\n            }\r\n        }\r\n\r\n    });\r\n</script>\r\n\r\n<script>\r\n    function DownloadDocument(Id) {\r\n        var url = \"");
            Write(
#nullable restore
#line 148 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                    Url.Action("DownloadSelectedDocument","UserDocuments")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""";
        window.location.href = url + ""?Id="" + Id;
    }
</script>
<script>
    $(function () {
        $(""#Insert"").hide();
        $(""#View"").hide();
        $(""#View1"").hide();
        $("".Update"").hide();
        $("".Delete"").hide();
        $("".Details"").hide();
    });
</script>
<script>
    $(function () {
        $(""#loader"").show();
        var module = $(""#Module"").val();
        $.ajax({
            url: """);
            Write(
#nullable restore
#line 167 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                   Url.Action("GetRolePermissionsName", "UserPermission")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
            method: ""GET"",
            data: { ""Module"": module },
            async: false,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (RoleResponse) {
                $.ajax({
                    url: """);
            Write(
#nullable restore
#line 175 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                           Url.Action("GetUserPermissionsName", "UserPermission")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
                    method: ""GET"",
                    data: { ""Module"": module },
                    async: false,
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    success: function (UserResponse) {

                        if (UserResponse.length > 0) {
                            for (let i = 0; i < UserResponse.length; i++) {
                                if (UserResponse[i] == ""PermissionCount"") {
                                    alert(""You don't have any permission for this module."");
                                    var url = """);
            Write(
#nullable restore
#line 187 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                                Url.Action("Index","Home")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""";
                                    url = url + ""?name=HomePage"";
                                    window.location.href = url;
                                } else {
                                    $(""#"" + UserResponse[i]).show();
                                    if (UserResponse[i] == ""View"") {
                                        $("".Details"").show();
                                        $(""#View1"").show();
                                    }
                                    if (UserResponse[i] == ""Update"") {
                                        $(""."" + UserResponse[i]).show();
                                    }
                                    if (UserResponse[i] == ""Delete"") {
                                        $(""."" + UserResponse[i]).show();
                                    }
                                }

                            }
                            $(""#loader"").hide();
                        }
                        else");
            WriteLiteral(@" if (RoleResponse.length > 0) {
                            for (let i = 0; i < RoleResponse.length; i++) {
                                if (RoleResponse[i] == ""PermissionCount"") {
                                    alert(""You don't have any permission for this module."");
                                    var url = """);
            Write(
#nullable restore
#line 211 "D:\Devotion Business\DIBN\DIBN\Views\UserDocuments\Index.cshtml"
                                                Url.Action("Index","Home")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""";
                                    url = url + ""?name=HomePage"";
                                    window.location.href = url;
                                }
                                else {
                                    $(""#"" + RoleResponse[i]).show();
                                    if (RoleResponse[i] == ""View"") {
                                        $("".Details"").show();
                                        $(""#View1"").show();
                                    }
                                    if (RoleResponse[i] == ""Update"") {
                                        $(""."" + RoleResponse[i]).show();
                                    }
                                    if (RoleResponse[i] == ""Delete"") {
                                        $(""."" + RoleResponse[i]).show();
                                    }
                                }

                            }
                            $(""#loader"").hide();
                      ");
            WriteLiteral(@"  } else {
                            alert(""You don't have any permission for this module."");
                            $(""#loader"").hide();
                        }
                    }
                })
            }
        });
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DIBN.Models.UserDocumentsViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
