#pragma checksum "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8f7306843cffa2648bbe831e719be35d8b636fdd9abdf4eb516e45d906ae6310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Theme__topbar), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Theme/_topbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8f7306843cffa2648bbe831e719be35d8b636fdd9abdf4eb516e45d906ae6310", @"/Areas/Admin/Views/Shared/Theme/_topbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"605a41b4408e5d1ff247f7264e35f4305eb9eeecf14a77cb4f30041778bbf31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Theme__topbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/DIBN_Logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<style>
    .bell-font{
        background: #243c7c26 !important;
        color: #243c7c !important;
        font-weight: bold;
        font-size: 11px !important;
    }
</style>
<header id=""page-topbar"">
    <div id=""hideNavBar"">
        <div class=""navbar-header"">
            <div class=""d-flex"">
                <!-- LOGO -->
                <div class=""navbar-brand-box"" style=""padding:0;"">
                    <a");
            BeginWriteAttribute("href", " href=", 432, "", 500, 1);
            WriteAttributeValue("", 438, 
#nullable restore
#line 15 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml"
                             Url.Action("Index", "Home",new{area="admin",name="HomePage"})

#line default
#line hidden
#nullable disable
            , 438, 62, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"logo logo-dark\">\r\n                        <span class=\"logo-sm\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f7306843cffa2648bbe831e719be35d8b636fdd9abdf4eb516e45d906ae63106194", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </span>\r\n                        <span class=\"logo-lg\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f7306843cffa2648bbe831e719be35d8b636fdd9abdf4eb516e45d906ae63107530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </span>\r\n                    </a>\r\n\r\n                    <a");
            BeginWriteAttribute("href", " href=", 890, "", 958, 1);
            WriteAttributeValue("", 896, 
#nullable restore
#line 24 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml"
                             Url.Action("Index", "Home",new{area="admin",name="HomePage"})

#line default
#line hidden
#nullable disable
            , 896, 62, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"logo logo-light\">\r\n                        <span class=\"logo-sm\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f7306843cffa2648bbe831e719be35d8b636fdd9abdf4eb516e45d906ae63109410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </span>\r\n                        <span class=\"logo-lg\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f7306843cffa2648bbe831e719be35d8b636fdd9abdf4eb516e45d906ae631010746", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                <div class=""dropdown d-inline-block ms-3"">
                    <button type=""button"" class=""btn header-item noti-icon waves-effect"" id=""page-header-notifications-dropdown"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""uil-bell front-text-theme""></i>
                        <span class=""badge rounded-pill bell-font"" id=""notificationCount""></span>
                    </button>
                    <div class=""dropdown-menu dropdown-menu-right"" id=""notificationMessage"">
                        
                    </div>
                </div>
            </div>

            <div class=""d-flex"">
                <div class=""dropdown d-none d-lg-i");
            WriteLiteral(@"nline-block"">
                    <span class=""btn header-item waves-effect align-middle mt-4 text-wrap overflow-hidden text-truncate ""><i class=""fas fa-question-circle""></i> &nbsp;<span class=""front-text-theme"">Help Center</span></span>
                </div>
                <div class=""dropdown d-none d-lg-inline-block"" id=""dibnlivesupport"">
                    <span class=""btn header-item waves-effect align-middle mt-4 text-wrap overflow-hidden text-truncate""><i class=""fas fa-comments""></i> &nbsp;<span class=""front-text-theme"">DIBN Live Support</span></span>
                </div>
                <div class=""dropdown d-none d-lg-inline-block"">
                    <span class=""btn header-item waves-effect align-middle mt-4 text-wrap overflow-hidden text-truncate ""><i class=""fas fa-phone-alt""></i>&nbsp; <span class=""front-text-theme"">+97143421947</span></span>
                </div>
                <div class=""dropdown d-inline-block"">
                    <button type=""button"" class=""btn header-ite");
            WriteLiteral(@"m waves-effect mt-2 text-truncate"" id=""page-header-user-dropdown""
                            data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <span class=""d-xl-inline-block d-none ms-1 fw-medium font-size-15 align-middle text-truncate"">
                            <i class=""fas fa-globe""></i>&nbsp; <span class=""front-text-theme"">DIBN BUSINESS SERVICES</span>
                        </span>
                        <i class=""uil-angle-down d-none d-xl-inline-block font-size-15 ""></i>
                    </button>
                    <div class=""dropdown-menu dropdown-menu-end"">
                        <!-- item-->
                        <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 4035, "\"", 4122, 1);
            WriteAttributeValue("", 4042, 
#nullable restore
#line 68 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml"
                                                        Url.Action("Index", "CompanyServices",new{area="admin",name="CompanyServices"})

#line default
#line hidden
#nullable disable
            , 4042, 80, false);
            EndWriteAttribute();
            WriteLiteral("><i class=\"uil uil-user-circle font-size-18 align-middle  me-1\" style=\"color:#243c7c;\"></i> <span class=\"align-middle front-text-theme\">Access Company Services</span></a>\r\n                        <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 4343, "\"", 4431, 1);
            WriteAttributeValue("", 4350, 
#nullable restore
#line 69 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml"
                                                        Url.Action("Index", "EmployeeService",new{area="admin",name="EmployeeServices"})

#line default
#line hidden
#nullable disable
            , 4350, 81, false);
            EndWriteAttribute();
            WriteLiteral("><i class=\"uil uil-wallet font-size-18 align-middle me-1\" style=\"color:#243c7c;\"></i> <span class=\"align-middle front-text-theme\">Access Employees Services</span></a>\r\n                        <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 4648, "\"", 4739, 1);
            WriteAttributeValue("", 4655, 
#nullable restore
#line 70 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml"
                                                        Url.Action("ServiceRequest", "ServiceRequests",new{area="admin",name="MyRequests"})

#line default
#line hidden
#nullable disable
            , 4655, 84, false);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""uil uil-wallet font-size-18 align-middle me-1"" style=""color:#243c7c;""></i> <span class=""align-middle front-text-theme"">Track Your Request</span></a>
                    </div>
                </div>
                <div class=""dropdown d-inline-block"">
                    <button type=""button"" class=""btn header-item waves-effect mt-2 text-truncate"" id=""page-header-user-dropdown""
                            data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <span class=""d-xl-inline-block ms-1 fw-medium font-size-15 align-middle text-truncate ""><i class=""fas fa-cog""></i>&nbsp;<span class=""front-text-theme"">Settings</span></span>
                        <i class=""uil-angle-down d-xl-inline-block font-size-15 ""></i>
                    </button>
                    <div class=""dropdown-menu dropdown-menu-end"">
                        <!-- item-->
                        <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 5708, "\"", 5765, 1);
            WriteAttributeValue("", 5715, 
#nullable restore
#line 81 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml"
                                                        Url.Action("ClearCache","Home",new{area="Admin"})

#line default
#line hidden
#nullable disable
            , 5715, 50, false);
            EndWriteAttribute();
            WriteLiteral(@" style=""color:#243c7c;"">
                        <i class=""fas fa-trash-alt font-size-18 align-middle overflow-hidden"" style=""color:#243c7c;""></i>
                            <span class=""align-middle overflow-hidden text-truncate front-text-theme"">Clear Cache</span>
                        </a>
                        <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 6115, "\"", 6166, 1);
            WriteAttributeValue("", 6122, 
#nullable restore
#line 85 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml"
                                                        Url.Action("Logout","Account",new{area=""})

#line default
#line hidden
#nullable disable
            , 6122, 44, false);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""uil uil-sign-out-alt font-size-18 align-middle overflow-hidden"" style=""color:#243c7c;""></i> <span class=""align-middle overflow-hidden text-truncate front-text-theme"">Sign out</span></a>
                    </div>
                </div>
                <input type=""hidden"" name=""support"" id=""supportid"" />
            </div>
        </div>
    </div>
</header>

<script");
            BeginWriteAttribute("src", " src=\"", 6556, "\"", 6609, 1);
            WriteAttributeValue("", 6562, 
#nullable restore
#line 94 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml"
              Url.Content("~/lib/jquery/dist/jquery.min.js")

#line default
#line hidden
#nullable disable
            , 6562, 47, false);
            EndWriteAttribute();
            WriteLiteral("></script>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $.ajax({\r\n            url: \"");
            Write(
#nullable restore
#line 99 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml"
                   Url.Action("GetCurrentNotificationCount","Home")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\",\r\n            method: \"POST\",\r\n            success: function (response) {\r\n                var _url = \"");
            Write(
#nullable restore
#line 102 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Shared\Theme\_topbar.cshtml"
                             Url.Action("GetRequestNotifications","Notifications")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""";
                _url = _url + ""?name=Notification"";
                if (response != null) {
                    var _count = parseInt($(""#notificationCount"").text());
                    if (isNaN(_count)) {
                        _count = 0;
                    }
                    _count = _count + parseInt(response);
                    if (_count > 0) {
                        var _message = ""<a class='dropdown-item' href="" + _url + "" style='color:#333D51;'>""
                            + ""<span class='align-middle'><strong> You have "" + _count + "" New Notification.</strong></span></a>"";


                        $(""#notificationCount"").text(_count);


                        $(""#notificationMessage"").html(_message);
                    }
                    else {
                        var _message = ""<a class='dropdown-item' href="" + _url + "" style='color:#333D51;'>""
                            + ""<span class='align-middle'><strong>No Notification Found.</strong></span></a>"";");
            WriteLiteral(@"
                        $(""#notificationCount"").text(parseInt(_count));
                        $(""#notificationMessage"").html(_message);
                    }
                }
                else {
                    var _message = ""<a class='dropdown-item' href="" + _url + "" style='color:#333D51;'>""
                        + ""<span class='align-middle'><strong>No Notification Found.</strong></span></a>"";
                    $(""#notificationCount"").text(parseInt(_count));
                    $(""#notificationMessage"").html(_message);
                }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
