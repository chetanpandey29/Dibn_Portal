#pragma checksum "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1bbcbaa038bcd7fd81c2e3d6f7c2c06a4c0401584e218d21718a4c23900264e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AccountManagement_GetAccountHistory), @"mvc.1.0.view", @"/Areas/Admin/Views/AccountManagement/GetAccountHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1bbcbaa038bcd7fd81c2e3d6f7c2c06a4c0401584e218d21718a4c23900264e4", @"/Areas/Admin/Views/AccountManagement/GetAccountHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"605a41b4408e5d1ff247f7264e35f4305eb9eeecf14a77cb4f30041778bbf31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AccountManagement_GetAccountHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DIBN.Areas.Admin.Models.GetAccountHistory>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-responsive/js/dataTables.responsive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-responsive-bs4/js/responsive.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
  
    ViewData["Title"] = "GetAccountHistory";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"<div class=""row"" id=""View"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title text-center"">Account History</h4>
                <hr style=""height:1px;"" class=""text-theme""/>
                <div class=""table-rep-plugin"">
                    <div class=""table-responsive mb-0"" data-pattern=""priority-columns"">
                        <table id=""datatable"" class=""table table-bordered table-striped dt-responsive nowrap"" style=""border-collapse: collapse; border-spacing: 0; width: 100%;"">
                            <thead>
                                <tr>
                                    <th>
                                        #
                                    </th>
                                    <th>
                                        Transaction Id
                                    </th>
                                    <th>
                                        Company
                  ");
            WriteLiteral(@"                  </th>
                                    <th>
                                        Description
                                    </th>
                                    <th>
                                        Amount
                                    </th>
                                    <th>
                                        Quantity
                                    </th>
                                    <th>
                                        Vat
                                    </th>
                                    <th>
                                        Vat Amount
                                    </th>
                                    <th>
                                        Total Amount
                                    </th>
                                    <th>
                                        Transaction Date
                                    </th>
                                    <th>
  ");
            WriteLiteral(@"                                      Transaction Created By
                                    </th>
                                    <th>
                                        Created On
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 56 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                  
                                    var j = 0;
                                

#line default
#line hidden
#nullable disable

#nullable restore
#line 59 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                    <tr>\r\n                                        <td>");
            Write(
#nullable restore
#line 62 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                              j+1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            Write(
#nullable restore
#line 64 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             item.TransactionId

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"text-wrap\">\r\n                                            ");
            Write(
#nullable restore
#line 67 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             item.CompanyName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"text-wrap\">\r\n                                            ");
            Write(
#nullable restore
#line 70 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            Write(
#nullable restore
#line 73 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             item.Amount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            Write(
#nullable restore
#line 76 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             item.Quantity

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            Write(
#nullable restore
#line 79 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             item.Vat

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            Write(
#nullable restore
#line 82 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             item.VatAmount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
#nullable restore
#line 85 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             if (item.ExpenseType == "Credit")
                                            {
                                                

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 87 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                                 item.TotalAmount

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 87 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                                                 
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 91 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                                 item.GrandTotal

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 91 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                                                
                                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            ");
            Write(
#nullable restore
#line 95 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             item.TransactionDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            Write(
#nullable restore
#line 98 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             item.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            Write(
#nullable restore
#line 101 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                             item.CreatedOn

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 104 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                                    j++;
                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!-- Responsive examples -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bbcbaa038bcd7fd81c2e3d6f7c2c06a4c0401584e218d21718a4c23900264e416289", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bbcbaa038bcd7fd81c2e3d6f7c2c06a4c0401584e218d21718a4c23900264e417353", async() => {
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
            WriteLiteral("\r\n\r\n<!-- Sweet Alerts-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bbcbaa038bcd7fd81c2e3d6f7c2c06a4c0401584e218d21718a4c23900264e418445", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bbcbaa038bcd7fd81c2e3d6f7c2c06a4c0401584e218d21718a4c23900264e419509", async() => {
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
            WriteLiteral(@"

<script>
    $('#datatable').DataTable({
        paging: true,
        ordering: true,
        searching: true
    });
</script>

<script>
    $(function () {
        $(""#Insert"").hide();
        $(""#View"").hide();
        $("".Update"").hide();
        $("".Delete"").hide();
        $("".Details"").hide();
    });

    $(function () {
        $.ajax({
            url: """);
            Write(
#nullable restore
#line 143 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                   Url.Action("GetRolePermissionsName", "Permission")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\",\r\n            method: \"GET\",\r\n            data: { \"Module\": \"AccountManagement\" },\r\n            success: function (RoleResponse) {\r\n                $.ajax({\r\n                    url: \"");
            Write(
#nullable restore
#line 148 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\AccountManagement\GetAccountHistory.cshtml"
                           Url.Action("GetUserPermissionsName", "Permission")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
                    method: ""GET"",
                    data: { ""Module"": ""AccountManagement"" },
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
                            for (let i = 0");
            WriteLiteral(@"; i < RoleResponse.length; i++) {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DIBN.Areas.Admin.Models.GetAccountHistory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
