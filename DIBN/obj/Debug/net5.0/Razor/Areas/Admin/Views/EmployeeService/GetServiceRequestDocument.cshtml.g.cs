#pragma checksum "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7bc3eda61e09a72f05231b84aa3f2a6cff5163f2f6f21545077f6b8eecead5e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EmployeeService_GetServiceRequestDocument), @"mvc.1.0.view", @"/Areas/Admin/Views/EmployeeService/GetServiceRequestDocument.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7bc3eda61e09a72f05231b84aa3f2a6cff5163f2f6f21545077f6b8eecead5e0", @"/Areas/Admin/Views/EmployeeService/GetServiceRequestDocument.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"605a41b4408e5d1ff247f7264e35f4305eb9eeecf14a77cb4f30041778bbf31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_EmployeeService_GetServiceRequestDocument : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DIBN.Areas.Admin.Models.EmployeeServiceRequestDocument>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/app.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#fff;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
  
    ViewData["Title"] = "GetServiceRequestDocument";
    Layout = null;

#line default
#line hidden
#nullable disable

            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bc3eda61e09a72f05231b84aa3f2a6cff5163f2f6f21545077f6b8eecead5e05945", async() => {
                WriteLiteral("\r\n    <!-- Bootstrap Css -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7bc3eda61e09a72f05231b84aa3f2a6cff5163f2f6f21545077f6b8eecead5e06261", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- App Css-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7bc3eda61e09a72f05231b84aa3f2a6cff5163f2f6f21545077f6b8eecead5e07490", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style>
        .internal {
            width: 100%;
            height: 830px;
        }

        .container {
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bc3eda61e09a72f05231b84aa3f2a6cff5163f2f6f21545077f6b8eecead5e09666", async() => {
                WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n");
#nullable restore
#line 32 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                  
                    string Type = ViewBag.type;
                

#line default
#line hidden
#nullable disable

#nullable restore
#line 35 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                 if (ViewBag.Base64String != null)
                {

                    

#line default
#line hidden
#nullable disable

#nullable restore
#line 38 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                     if (ViewBag.DocumentId != 0 || ViewBag.DocumentId != null)
                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                        <div class=\"col-md-12\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1102, "\"", 1186, 1);
                WriteAttributeValue("", 1109, 
#nullable restore
#line 41 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                                      Url.Action("DownloadDocument","EmployeeService",new{Id=@ViewBag.DocumentId})

#line default
#line hidden
#nullable disable
                , 1109, 77, false);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-theme float-end mb-2 ms-2 mt-1\">Download</a>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1279, "\"", 1383, 1);
                WriteAttributeValue("", 1286, 
#nullable restore
#line 42 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                                      Url.Action("GetRequestDetail","ServiceRequests",new{Id=@ViewBag.RequestId,name=@ViewBag.Module})

#line default
#line hidden
#nullable disable
                , 1286, 97, false);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-theme float-end mb-2 mt-1\">Back</a>\r\n                        </div>\r\n");
#nullable restore
#line 44 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 45 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                     if (Type.StartsWith("image/"))
                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                        <img");
                BeginWriteAttribute("src", " src=\"", 1596, "\"", 1623, 1);
                WriteAttributeValue("", 1602, 
#nullable restore
#line 47 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                                   ViewBag.Base64String

#line default
#line hidden
#nullable disable
                , 1602, 21, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 48 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                        <object");
                BeginWriteAttribute("data", " data=\"", 1732, "\"", 1760, 1);
                WriteAttributeValue("", 1739, 
#nullable restore
#line 51 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                                       ViewBag.Base64String

#line default
#line hidden
#nullable disable
                , 1739, 21, false);
                EndWriteAttribute();
                WriteLiteral(" frameBorder=\"0\" class=\"internal\"></object>\r\n");
#nullable restore
#line 52 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 52 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                     


                }

#line default
#line hidden
#nullable disable

                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1913, "\"", 1966, 1);
                WriteAttributeValue("", 1919, 
#nullable restore
#line 60 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                  Url.Content("~/lib/jquery/dist/jquery.min.js")

#line default
#line hidden
#nullable disable
                , 1919, 47, false);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1990, "\"", 2062, 1);
                WriteAttributeValue("", 1996, 
#nullable restore
#line 61 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                  Url.Content("~/assets/libs/bootstrap/js/bootstrap.bundle.min.js")

#line default
#line hidden
#nullable disable
                , 1996, 66, false);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2086, "\"", 2126, 1);
                WriteAttributeValue("", 2092, 
#nullable restore
#line 62 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\EmployeeService\GetServiceRequestDocument.cshtml"
                  Url.Content("~/assets/js/app.js")

#line default
#line hidden
#nullable disable
                , 2092, 34, false);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DIBN.Areas.Admin.Models.EmployeeServiceRequestDocument> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
