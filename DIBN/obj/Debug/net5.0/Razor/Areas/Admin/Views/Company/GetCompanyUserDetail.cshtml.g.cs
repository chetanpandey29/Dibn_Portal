#pragma checksum "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0e49aa0e654c29b2ad9933898a7f61bb5b0e32f6154524d6222ce30ccc5ba6fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Company_GetCompanyUserDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/Company/GetCompanyUserDetail.cshtml")]
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
#line 1 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN

#nullable disable
    ;
#nullable restore
#line 2 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.Models

#nullable disable
    ;
#nullable restore
#line 3 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.Data

#nullable disable
    ;
#nullable restore
#line 4 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.IRepository

#nullable disable
    ;
#nullable restore
#line 5 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.Repository

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0e49aa0e654c29b2ad9933898a7f61bb5b0e32f6154524d6222ce30ccc5ba6fc", @"/Areas/Admin/Views/Company/GetCompanyUserDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"605a41b4408e5d1ff247f7264e35f4305eb9eeecf14a77cb4f30041778bbf31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Company_GetCompanyUserDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DIBN.Areas.Admin.Models.UserViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-bs4/js/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
  
    ViewData["Title"] = "UserDetail";

#line default
#line hidden
#nullable disable

            WriteLiteral("<input type=\"hidden\" name=\"Module\" id=\"Module\"");
            BeginWriteAttribute("value", " value=\"", 140, "\"", 161, 1);
            WriteAttributeValue("", 148, 
#nullable restore
#line 6 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                       Model.Module

#line default
#line hidden
#nullable disable
            , 148, 13, false);
            EndWriteAttribute();
            WriteLiteral(@" />
<div id=""loader"">
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
                <div class=""row"">
                    <div class=""card-title"">
                        <h5 class=""text-dark float-start"">");
            Write(
#nullable restore
#line 22 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                           Html.DisplayFor(model => model.FirstName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" ");
            Write(
#nullable restore
#line 22 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                                                                      Html.Raw(" ")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" ");
            Write(
#nullable restore
#line 22 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                                                                                     Html.DisplayFor(model => model.LastName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\'s Detail</h5>\r\n");
#nullable restore
#line 23 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         if (Model.IsActive && Model.IsLogin)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <span class=\"float-end fas fa-check text-success\" style=\"font-size:26px;\"></span>\r\n");
#nullable restore
#line 26 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <span class=\"float-end fas fa-times text-danger\" style=\"font-size:26px;\"></span>\r\n");
#nullable restore
#line 30 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                    </div>\r\n                <hr/>\r\n                </div>\r\n                <dl class=\"row\">\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
            Write(
#nullable restore
#line 36 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayNameFor(model => model.AccountNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
            Write(
#nullable restore
#line 39 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayFor(model => model.AccountNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        Employee Name\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
            Write(
#nullable restore
#line 45 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayFor(model => model.FirstName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" ");
            Write(
#nullable restore
#line 45 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                                    Html.Raw(" ")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" ");
            Write(
#nullable restore
#line 45 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                                                   Html.DisplayFor(model => model.LastName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
            Write(
#nullable restore
#line 48 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayNameFor(model => model.Nationality)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
            Write(
#nullable restore
#line 51 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayFor(model => model.Nationality)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
            Write(
#nullable restore
#line 54 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayNameFor(model => model.PassportNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
            Write(
#nullable restore
#line 57 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayFor(model => model.PassportNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
            Write(
#nullable restore
#line 60 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayNameFor(model => model.Designation)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n");
            WriteLiteral("                            ");
            Write(
#nullable restore
#line 69 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                             Html.DisplayFor(model => model.Designation)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n");
            WriteLiteral("                        \r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
            Write(
#nullable restore
#line 74 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayNameFor(model => model.VisaExpiryDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
            Write(
#nullable restore
#line 77 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayFor(model => model.VisaExpiryDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
            Write(
#nullable restore
#line 80 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayNameFor(model => model.InsuranceCompany)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
            Write(
#nullable restore
#line 83 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayFor(model => model.InsuranceCompany)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
            Write(
#nullable restore
#line 86 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayNameFor(model => model.InsuranceExpiryDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
            Write(
#nullable restore
#line 89 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayFor(model => model.InsuranceExpiryDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
            Write(
#nullable restore
#line 92 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayNameFor(model => model.EmailID)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
            Write(
#nullable restore
#line 95 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayFor(model => model.EmailID)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
            Write(
#nullable restore
#line 98 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayNameFor(model => model.PhoneNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
            Write(
#nullable restore
#line 101 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.DisplayFor(model => model.PhoneNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
            Write(
#nullable restore
#line 104 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         Html.Raw("Is User Active?")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n");
#nullable restore
#line 107 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                         if (Model.IsActive)
                        {
                            

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 109 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                             Html.Raw("Yes")

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 109 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                            
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 113 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                             Html.Raw("No")

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 113 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                           
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                    </dd>\r\n");
            WriteLiteral("                </dl>\r\n\r\n                <div>\r\n                    <input type=\"hidden\" name=\"CompanyId\" id=\"CompanyId\"");
            BeginWriteAttribute("value", " value=\"", 5339, "\"", 5363, 1);
            WriteAttributeValue("", 5347, 
#nullable restore
#line 125 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                                                 Model.CompanyId

#line default
#line hidden
#nullable disable
            , 5347, 16, false);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                    <input type=\"hidden\" name=\"Action\" id=\"returnAction\"");
            BeginWriteAttribute("value", " value=\"", 5440, "\"", 5461, 1);
            WriteAttributeValue("", 5448, 
#nullable restore
#line 126 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                                                 Model.Action

#line default
#line hidden
#nullable disable
            , 5448, 13, false);
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 129 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                     if (@Model.Action == "Employees")
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <a class=\"text-white btn btn-theme\"");
            BeginWriteAttribute("href", " href=\"", 5834, "\"", 5929, 1);
            WriteAttributeValue("", 5841, 
#nullable restore
#line 131 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                                   Url.Action("GetCompanyEmployees","Company",new{Id=@Model.CompanyId,name=@Model.Module})

#line default
#line hidden
#nullable disable
            , 5841, 88, false);
            EndWriteAttribute();
            WriteLiteral(">Back to List</a>\r\n");
#nullable restore
#line 132 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <a class=\"text-white btn btn-theme\"");
            BeginWriteAttribute("href", " href=\"", 6080, "\"", 6171, 1);
            WriteAttributeValue("", 6087, 
#nullable restore
#line 135 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                                   Url.Action("GetCompanyUsers","Company",new{Id=@Model.CompanyId,name=@Model.Module})

#line default
#line hidden
#nullable disable
            , 6087, 84, false);
            EndWriteAttribute();
            WriteLiteral(">Back to List</a>\r\n");
#nullable restore
#line 136 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                    \r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e49aa0e654c29b2ad9933898a7f61bb5b0e32f6154524d6222ce30ccc5ba6fc23550", async() => {
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
            WriteLiteral("\r\n<!-- Required datatable js -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e49aa0e654c29b2ad9933898a7f61bb5b0e32f6154524d6222ce30ccc5ba6fc24648", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e49aa0e654c29b2ad9933898a7f61bb5b0e32f6154524d6222ce30ccc5ba6fc25712", async() => {
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
            WriteLiteral("\r\n<!-- Sweet Alerts-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e49aa0e654c29b2ad9933898a7f61bb5b0e32f6154524d6222ce30ccc5ba6fc26800", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e49aa0e654c29b2ad9933898a7f61bb5b0e32f6154524d6222ce30ccc5ba6fc27864", async() => {
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
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $(""#loader"").hide();
    });
</script>
<script>
    function RemoveUser(Id){
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
        }).then((result) => {
            if (result.isConfirmed) {
                $(""#loader"").show();
                $.ajax({
                    url: """);
            Write(
#nullable restore
#line 182 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                           Url.Action("DeleteCompanyEmployee", "Company")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
                    method: ""GET"",
                    data:{""Id"":Id},
                    success: function (response) {
                        if(response < 0){
                            $(""#loader"").hide();
                            swalWithBootstrapButtons.fire({
                                title: 'Error.',
                                text: ""Currently You can not delete this User as this user is already associate with Company."",
                                icon: 'error'
                            }).then((result) => {
                                window.location.reload();
                            });
                        }
                        else{
                            $(""#loader"").show();
                            swalWithBootstrapButtons.fire({
                                title: 'Deleted.',
                                text: ""User Deleted Successfully..!!"",
                                icon: 'success'
                            })");
            WriteLiteral(@".then((result) => {
                                var module = $(""#Module"").val();
                                var action = $(""#returnAction"").val();
                                var companyId = $(""#CompanyId"").val();
                                $(""#loader"").hide();
                                if (action == ""Employees"") {
                                    var url = """);
            Write(
#nullable restore
#line 208 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                Url.Action("GetCompanyEmployees","Company")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\";\r\n                                    window.location.href = url + \"?Id=\" + companyId + \"&name=\" + module;\r\n                                }\r\n                                else {\r\n                                    var url = \"");
            Write(
#nullable restore
#line 212 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                                                Url.Action("GetCompanyUsers","Company")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""";
                                    window.location.href = url + ""?Id="" + companyId + ""&name="" + module;
                                }
                            });
                        }
                    }
                });
            }
        });
    }
</script>
<script>
    function UpdateUser(Id){
            var module = $(""#Module"").val();
            var url = """);
            Write(
#nullable restore
#line 226 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                        Url.Action("EditCompanyEmployee","Company")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""";
            window.location.href=url+""?Id=""+Id+""&name=""+module;
        }
</script>

<script>
    $(function () {
        $(""#Insert"").hide();
        $(""#View"").hide();
        $("".Update"").hide();
        $("".Delete"").hide();
        $("".Details"").hide();
    });
</script>
<script>
    $(function () {
        var module = $(""#Module"").val();
        $.ajax({
            url: """);
            Write(
#nullable restore
#line 244 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                   Url.Action("GetRolePermissionsName", "Permission")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\",\r\n            method: \"GET\",\r\n            data: { \"Module\": \"OtherCompanyEmployee\" },\r\n            success: function (RoleResponse) {\r\n                $.ajax({\r\n                    url: \"");
            Write(
#nullable restore
#line 249 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\Company\GetCompanyUserDetail.cshtml"
                           Url.Action("GetUserPermissionsName", "Permission")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
                    method: ""GET"",
                    data: { ""Module"": ""OtherCompanyEmployee"" },
                    success: function (UserResponse) {
                        if (UserResponse.length > 0) {
                            for (let i = 0; i < UserResponse.length; i++) {
                                $(""#"" + UserResponse[i]).show();
                                if (UserResponse[i] == ""View"") {
                                    $("".Details"").show();
                                }
                                if (UserResponse[i] == ""Update"") {
                                    $(""."" + UserResponse[i]).show();
                                }
                                if (UserResponse[i] == ""Delete"") {
                                    $(""."" + UserResponse[i]).show();
                                }
                            }
                        }
                        else if (RoleResponse.length > 0) {
                            for (let i ");
            WriteLiteral(@"= 0; i < RoleResponse.length; i++) {
                                $(""#"" + RoleResponse[i]).show();
                                if (RoleResponse[i] == ""View"") {
                                    $("".Details"").show();
                                }
                                if (RoleResponse[i] == ""Update"") {
                                    $(""."" + RoleResponse[i]).show();
                                }
                                if (RoleResponse[i] == ""Delete"") {
                                    $(""."" + RoleResponse[i]).show();
                                }
                            }

                        } else {
                            alert(""You don't have any permission for this module."");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DIBN.Areas.Admin.Models.UserViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
