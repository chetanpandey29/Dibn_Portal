#pragma checksum "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02b31585ab3f524a00ff9eb57c1107f479be655edc2acd7f1993f89deb6c3cbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Theme__sidebar), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Theme/_sidebar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"02b31585ab3f524a00ff9eb57c1107f479be655edc2acd7f1993f89deb6c3cbb", @"/Areas/Admin/Views/Shared/Theme/_sidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"605a41b4408e5d1ff247f7264e35f4305eb9eeecf14a77cb4f30041778bbf31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Theme__sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/DIBN_Logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- ========== Left Sidebar Start ========== -->
<div class=""vertical-menu"">
    <!-- LOGO -->
    <div class=""navbar-brand-box"" style=""padding:5px;"">
        <a class=""logo logo-dark text-center mt-2"">
            <span class=""logo-sm"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02b31585ab3f524a00ff9eb57c1107f479be655edc2acd7f1993f89deb6c3cbb6511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </span>\r\n            <span class=\"logo-lg\" style=\"margin-right:25px;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02b31585ab3f524a00ff9eb57c1107f479be655edc2acd7f1993f89deb6c3cbb7923", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </span>\r\n        </a>\r\n\r\n        <a class=\"logo logo-light text-center mt-2\">\r\n            <span class=\"logo-sm\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02b31585ab3f524a00ff9eb57c1107f479be655edc2acd7f1993f89deb6c3cbb9384", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </span>\r\n            <span class=\"logo-lg\" style=\"margin-right:25px;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02b31585ab3f524a00ff9eb57c1107f479be655edc2acd7f1993f89deb6c3cbb10796", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </span>
        </a>
    </div>

    <button type=""button"" class=""btn btn-sm px-3 font-size-16 header-item waves-effect vertical-menu-btn"">
        <i class=""fas fa-fw fa-bars""></i>
    </button>

    <div data-simplebar class=""sidebar-menu-scroll"">

        <!--- Sidemenu -->
        <div id=""sidebar-menu"">
            <!-- Left Menu Start -->
            <ul class=""metismenu p-0 list-unstyled"" id=""side-menu"">
                <li class=""menu-title mt-3"" style=""color:#243c7c;"">Menu</li>
            </ul>
        </div>
        <!-- Sidebar -->
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02b31585ab3f524a00ff9eb57c1107f479be655edc2acd7f1993f89deb6c3cbb12718", async() => {
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
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#main-loader\").show();\r\n        $.ajax({\r\n            url: \"");
            Write(
#nullable restore
#line 45 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                   Url.Action("GetAllowedModuleList", "Home")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\",\r\n            method: \"GET\",\r\n            success: function (response) {\r\n                if (response.length > 0) {\r\n                    if (response.includes(\"HomePage\")) {\r\n                        $(\"#side-menu\").append(\'<li id=\"HomePage\"><a href=\"");
            Write(
#nullable restore
#line 50 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                            Url.Action("Index", "Home", new { area = "admin", name = "HomePage" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""uil-home-alt""></i><span class=""text-wrap"">Dashboard</span></a></li>');
                    }

                    if (response.includes(""RoleManagement"") || response.includes(""RolePermission"")) {
                        if (response.includes(""RoleManagement"") && response.includes(""RolePermission"")) {
                            $(""#side-menu"").append('<li id=""ACM"" onclick=""showAcm()""><a href=""javascript:void(0);"" class=""has-arrow waves-effect""><i class=""uil-window-section""></i><span class=""text-wrap"">ACM</span></a><ul class=""sub-menu mm-collapse"" id=""acmSubMenu""  aria-expanded=""true""><li id=""RoleManagement""><a href=");
            Write(
#nullable restore
#line 55 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                                                                                                                                                                                                                                                                  Url.Action("Index", "Role", new { area = "admin", name = "RoleManagement" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("><i class=\"far fa-dot-circle\"></i><span class=\"text-wrap\">Role Management</span></a></li><li id=\"RolePermission\"><a href=\"");
            Write(
#nullable restore
#line 55 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Url.Action("RolePermission", "Permission", new { area = "admin", name = "RolePermission" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Role Permission</span></a></li></ul></li>');
                        }
                        else if (response.includes(""RoleManagement"")) {
                            $(""#side-menu"").append('<li id=""ACM"" onclick=""showAcm()""><a href=""javascript:void(0);"" class=""has-arrow waves-effect""><i class=""uil-window-section""></i><span class=""text-wrap"">ACM</span></a><ul class=""sub-menu mm-collapse"" id=""acmSubMenu"" aria-expanded=""true""><li id=""RoleManagement""><a href=");
            Write(
#nullable restore
#line 58 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                                                                                                                                                                                                                                                                 Url.Action("Index", "Role", new { area = "admin", name = "RoleManagement" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Role Management</span></a></li></ul></li>');
                        }
                        else if (response.includes(""RolePermission"")) {
                            $(""#side-menu"").append('<li id=""ACM"" onclick=""showAcm()""><a href=""javascript:void(0);"" class=""has-arrow waves-effect""><i class=""uil-window-section""></i><span class=""text-wrap"">ACM</span></a><ul class=""sub-menu mm-collapse"" id=""acmSubMenu"" aria-expanded=""true""><li id=""RolePermission""><a href=""");
            Write(
#nullable restore
#line 61 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                                                                                                                                                                                                                                                                  Url.Action("RolePermission", "Permission", new { area = "admin", name = "RolePermission" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Role Permission</span></a></li></ul></li>');
                        }
                    }

                    if (response.includes(""Company"") || response.includes(""CompanyDocumentType"") || response.includes(""CompanySubType"")) {
                        var appendStr = '<li id=""Company"" onclick=""showCompanySubMenu()""><a href=""javascript: void(0);"" class=""has-arrow waves-effect""><i class=""fas fa-city""></i><span class=""text-wrap"">Company(s)</span></a><ul class=""sub-menu mm-collapse"" id=""companySubMenu"" aria-expanded=""true"">';
                        if (response.includes(""Company"")) {
                            appendStr = appendStr + '<li><a href=""");
            Write(
#nullable restore
#line 68 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                   Url.Action("Index", "Company", new { area = "admin", name = "Company" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Company(s)</span></a></li>';
                        }
                        if (response.includes(""CompanyDocumentType"")) {
                            appendStr = appendStr + '<li id=""CompanyDocumentType""><a href=""");
            Write(
#nullable restore
#line 71 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                            Url.Action("Index", "CompanyDocumentType", new { area = "admin", name = "CompanyDocumentType" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Company Document Type(s)</span></a></li>';
                        }
                        if (response.includes(""CompanySubType"")) {
                            appendStr = appendStr + '<li id=""CompanySubType""><a href=""");
            Write(
#nullable restore
#line 74 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                       Url.Action("Index", "CompanySubType", new { area = "admin", name = "CompanySubType" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Company Type(s)</span></a></li>';
                        }
                        appendStr = appendStr + '</ul></li>';
                        $(""#side-menu"").append(appendStr);
                    }

                    if (response.includes(""Shareholders"") || response.includes(""OtherCompanyEmployee"") || response.includes(""OtherCompanyOwner"")) {
                        var appendStr = '<li id=""ShareholdersBlock"" onclick=""showShareholderSubmenu()""><a href=""javascript: void(0);"" class=""has-arrow waves-effect""><i class=""fas fa-user-tie""></i><span class=""font-size-14 text-wrap"">Shareholders/Director</span></a><ul class=""sub-menu mm-collapse"" id=""shareholderSubmenu"" aria-expanded=""true"">';
                        if (response.includes(""Shareholders"")) {
                            appendStr = appendStr + '<li id=""Shareholders""><a href=""");
            Write(
#nullable restore
#line 83 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                     Url.Action("Index", "Shareholders", new { name = "Shareholders" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Shareholders/Director</span></a></li>';
                        }
                        if (response.includes(""OtherCompanyEmployee"")) {
                            appendStr = appendStr + '<li id=""OtherCompanyEmployee""><a href=""");
            Write(
#nullable restore
#line 86 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                             Url.Action("Index", "User", new { area = "admin", name = "OtherCompanyEmployee" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Other Company(s) Employees</span></a></li>';
                        }
                        if (response.includes(""OtherCompanyOwner"")) {
                            appendStr = appendStr + '<li id=""OtherCompanyOwner""><a href=");
            Write(
#nullable restore
#line 89 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                         Url.Action("OtherCompanyOwner", "User", new { area = "admin", name = "OtherCompanyOwner" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Other Company(s) Owner</span></a></li>';
                        }
                        appendStr = appendStr + '</ul></li>';
                        $(""#side-menu"").append(appendStr);
                    }

                    if (response.includes(""DIBNEmployee"") || response.includes(""SalesPerson"") || response.includes(""RMTeam"")) {
                        var appendStr = '<li id=""DibnTeam"" onclick=""showDDIBNSubMenu()""><a href=""javascript: void(0);"" class=""has-arrow waves-effect""><i class=""fas fa-users""></i><span class=""text-wrap"">DIBN Team</span></a><ul class=""sub-menu mm-collapse"" id=""showDDIBNSubMenu"" aria-expanded=""true"">';
                        if (response.includes(""DIBNEmployee"")) {
                            appendStr = appendStr + '<li id=""DIBNEmployee""><a href=");
            Write(
#nullable restore
#line 98 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                    Url.Action("GetMainCompanyEmployees", "User", new { area = "admin", name = "DIBNEmployee" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Operational Team</span></a></li>';
                        }
                        if (response.includes(""SalesPerson"")) {
                            appendStr = appendStr + '<li id=""SalesPerson""><a href=");
            Write(
#nullable restore
#line 101 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                   Url.Action("Index", "SalesPerson", new { area = "admin", name = "SalesPerson" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("><i class=\"far fa-dot-circle\"></i><span class=\"text-wrap\">Sales Team</span></a></li>\';\r\n                        }\r\n                        if (response.includes(\"RMTeam\")) {\r\n                            appendStr = appendStr + \'<li id=\"RMTeam\"><a href=");
            Write(
#nullable restore
#line 104 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                              Url.Action("Index", "RMTeam", new { area = "admin", name = "RMTeam" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"><i class=""far fa-dot-circle""></i><span class=""text-wrap"">RM Team</span></a></li>';
                        }
                        appendStr = appendStr + '</ul></li>';
                        $(""#side-menu"").append(appendStr);
                    }

                    if (response.includes(""CompanyServices"") || response.includes(""EmployeeServices"") || response.includes(""MyRequests"") || response.includes(""ServiceRequestStatus"")) {
                        var appendStr = '<li id=""Services"" onclick=""showServiceSubMenu()""><a href=""javascript: void(0);"" class=""has-arrow waves-effect""><i class=""fas fa-cogs""></i><span class=""text-wrap"">Services</span></a><ul class=""sub-menu mm-collapse"" id=""showServiceSubMenu"" aria-expanded=""true"">';
                        if (response.includes(""CompanyServices"")) {
                            appendStr = appendStr + '<li id=""CompanyServices""><a href=""");
            Write(
#nullable restore
#line 113 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                        Url.Action("Index", "CompanyServices", new { area = "admin", name = "CompanyServices" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Company Services</span></a></li>';
                        }
                        if (response.includes(""EmployeeServices"")) {
                            appendStr = appendStr + '<li id=""EmployeeServices""><a href=""");
            Write(
#nullable restore
#line 116 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                         Url.Action("Index", "EmployeeService", new { area = "admin", name = "EmployeeServices" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Employee Services</span></a></li>';
                        }
                        if (response.includes(""MyRequests"")) {
                            appendStr = appendStr + '<li id=""MyRequests1""><a href=""");
            Write(
#nullable restore
#line 119 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                    Url.Action("ServiceRequest", "ServiceRequests", new { area = "admin", name = "MyRequests" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Service Request(s)</span></a></li>';
                        }
                        if (response.includes(""ServiceRequestStatus"")) {
                            appendStr = appendStr + '<li id=""ServiceRequestStatus""><a href=""");
            Write(
#nullable restore
#line 122 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                             Url.Action("Index", "ServiceRequestStatus", new { area = "admin", name = "ServiceRequestStatus" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""far fa-dot-circle""></i><span class=""text-wrap"">Service Request Status</span></a></li>';
                        }
                        appendStr = appendStr + '</ul></li>';
                        $(""#side-menu"").append(appendStr);
                    }

                    if (response.includes(""Invoice"")) {
                        $(""#side-menu"").append('<li id=""Invoice""><a href=""");
            Write(
#nullable restore
#line 129 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                           Url.Action("Index", "CompanyInvoice", new { area = "admin", name = "Invoice" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""fas fa-file-alt""></i><span class=""text-wrap"">Invoices</span></a></li>');
                    }

                    if (response.includes(""DocumentChecklist"")) {
                        $(""#side-menu"").append('<li id=""DocumentChecklist""><a href=""");
            Write(
#nullable restore
#line 133 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                     Url.Action("Index", "Document", new { area = "admin", name = "DocumentChecklist" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""fas fa-check-square""></i><span class=""text-wrap"">Document Checklist</span></a></li>');
                    }
                    
                    if (response.includes(""Notification"")) {
                        $(""#side-menu"").append('<li id=""Notification""><a href=""");
            Write(
#nullable restore
#line 137 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                                                                                Url.Action("Index", "Notifications", new { area = "admin", name = "Notification" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""><i class=""fas fa-bell""></i><span class=""text-wrap"">Notifications</span></a></li>');
                    }
                }
                $(""#main-loader"").hide();
            }
        });
    })
    
    function showAcm() {
        if ($(""#acmSubMenu"").hasClass(""mm-collapse"")) {
            $(""#acmSubMenu"").removeClass(""mm-collapse"");
        }
        else { $(""#acmSubMenu"").addClass(""mm-collapse""); }
    }

    function showCompanySubMenu() {
        if ($(""#companySubMenu"").hasClass(""mm-collapse"")) {
            $(""#companySubMenu"").removeClass(""mm-collapse"");
        }
        else { $(""#companySubMenu"").addClass(""mm-collapse""); }
    }

    function showShareholderSubmenu() {
        if ($(""#shareholderSubmenu"").hasClass(""mm-collapse"")) {
            $(""#shareholderSubmenu"").removeClass(""mm-collapse"");
        }
        else { $(""#shareholderSubmenu"").addClass(""mm-collapse""); }
    }

    function showDDIBNSubMenu() {
        if ($(""#showDDIBNSubMenu"").hasClass(""mm-co");
            WriteLiteral(@"llapse"")) {
            $(""#showDDIBNSubMenu"").removeClass(""mm-collapse"");
        }
        else { $(""#showDDIBNSubMenu"").addClass(""mm-collapse""); }
    }

    function showServiceSubMenu() {
        if ($(""#showServiceSubMenu"").hasClass(""mm-collapse"")) {
            $(""#showServiceSubMenu"").removeClass(""mm-collapse"");
        }
        else { $(""#showServiceSubMenu"").addClass(""mm-collapse""); }
    }

</script>
<script>
    document.onkeypress = function (event) {
        event = (event || window.event);
        if (event.keyCode == 123) {
            return false;
        }
    }
    document.onmousedown = function (event) {
        event = (event || window.event);
        if (event.keyCode == 123) {
            return false;
        }
    }
    document.onkeydown = function (event) {
        event = (event || window.event);
        if (event.keyCode == 123) {
            return false;
        }
    }
</script>
<script>
    document.addEventListener('contextmenu', event =>");
            WriteLiteral(" event.preventDefault());  // To disable right click\r\n\r\n    $(function () {\r\n        $(\"#showNavBar1\").hide();\r\n        $(\"#hideNavBar1\").show();\r\n    });\r\n    $(document).ready(function () {\r\n        $.ajax({\r\n            url: \"");
            Write(
#nullable restore
#line 210 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                   Url.Action("GetLoggedInUser","Home")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
            method: ""GET"",
            success: function (response) {
                $(""#hideNavBar1"").hide();
                $(""#showNavBar1"").show();
            }
        });
    });


    //// Check whether logged in user has permission to login or has is active allowed and not deleted                  -- Yashasvi (22-05-2023)
    $(function () {
        $.ajax({
            url: """);
            Write(
#nullable restore
#line 223 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                   Url.Action("GetLoggedInUserStatus", "Home")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\",\r\n            method: \"POST\",\r\n            async: false,\r\n            success: function (response) {\r\n                var url = \"");
            Write(
#nullable restore
#line 227 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_sidebar.cshtml"
                            Url.Action("Logout","Account")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""";
                if (parseInt(response.isDelete) == 1) {
                    window.location.href = url;
                }
                else if (parseInt(response.isActive) == 1) {
                    window.location.href = url;
                }
                else if (parseInt(response.isLoggedIn) == 1) {
                    window.location.href = url;
                }
            }
        })
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
