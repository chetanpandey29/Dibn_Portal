#pragma checksum "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "414a931beafcbadeb29c431417dc06a6b086ac1bf8b864a88bd63d78ebf92013"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Notifications_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Notifications/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\_ViewImports.cshtml"
using DIBN.Areas.Admin.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"414a931beafcbadeb29c431417dc06a6b086ac1bf8b864a88bd63d78ebf92013", @"/Areas/Admin/Views/Notifications/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"605a41b4408e5d1ff247f7264e35f4305eb9eeecf14a77cb4f30041778bbf31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Notifications_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DIBN.Areas.Admin.Models.ImportReminderNotification>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-responsive/js/dataTables.responsive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-responsive-bs4/js/responsive.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-bs4/js/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"loader\">\r\n    <div class=\"spinner-1\">\r\n        <div class=\"center-div-1\">\r\n");
            WriteLiteral(@"            <div class=""loader-circle-75"">
            </div>
        </div>
    </div>
</div>
<div class=""row"" id=""View"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title text-center"">Notification(s)</h4>
                <hr style=""height:1px;"" class=""text-blue"" />
                <div class=""table-rep-plugin"">
                    <div class=""table-responsive mb-0"" data-pattern=""priority-columns"">
                        <table id=""datatable"" class=""table table-bordered table-striped dt-responsive nowrap"" style=""border-collapse: collapse; border-spacing: 0; width: 100%;"">
                            <thead>
                                <tr>
                                    <th>
                                        #
                                    </th>
                                    <th>
                                        Company
                                    </th>
                ");
            WriteLiteral(@"                    <th>
                                        Notification For
                                    </th>
                                    <th>
                                        Service
                                    </th>
                                    <th>
                                        Expiry Date
                                    </th>
                                    <th>
                                        Left Days
                                    </th>
                                    <th>
                                        Send Notification(Before Days)
                                    </th>
                                    <th>

                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 54 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                  
                                    var i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 61 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                        Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 64 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                       Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
#nullable restore
#line 67 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                             if (item.Username == null || item.Username == "")
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                           Write(item.CompanyName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                                              Write(Html.Raw("(ItSelf)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                                                                        
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                           Write(item.Username);

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                                              
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 77 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                       Write(item.Service);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 80 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                       Write(item.ExpiryDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
#nullable restore
#line 83 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                             if (item.LeftDayToExpire < 0)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                           Write(item.ExpiredNotification);

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                                                         
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                           Write(item.LeftDayToExpire);

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                                                     
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 93 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                                       Write(item.SendNotificationAfter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <span class=\"btn btn-blue Update\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4592, "\"", 4646, 5);
            WriteAttributeValue("", 4602, "Update(", 4602, 7, true);
#nullable restore
#line 96 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
WriteAttributeValue("", 4609, item.ID, 4609, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4617, ",", 4617, 1, true);
#nullable restore
#line 96 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
WriteAttributeValue("", 4618, item.SendNotificationAfter, 4618, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4645, ")", 4645, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fas fa-edit\"></i>\r\n                                            </span>\r\n                                            <span class=\"btn btn-blue Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4857, "\"", 4895, 3);
            WriteAttributeValue("", 4867, "RemoveNotification(", 4867, 19, true);
#nullable restore
#line 99 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
WriteAttributeValue("", 4886, item.ID, 4886, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4894, ")", 4894, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fas fa-trash\"></i>\r\n                                            </span>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 104 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"

                                    i++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
<div id=""Edit"" class=""modal"" tabindex=""-1"" data-bs-keyboard=""false"" data-bs-backdrop=""static"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Update</h5>
                <button type=""button"" class=""close btn btn-blue"" id=""EditClose"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
            </div>
        </div>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414a931beafcbadeb29c431417dc06a6b086ac1bf8b864a88bd63d78ebf9201318408", async() => {
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
            WriteLiteral("\r\n\r\n<!-- Responsive examples -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414a931beafcbadeb29c431417dc06a6b086ac1bf8b864a88bd63d78ebf9201319508", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414a931beafcbadeb29c431417dc06a6b086ac1bf8b864a88bd63d78ebf9201320572", async() => {
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
            WriteLiteral("\r\n<!-- Required datatable js -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414a931beafcbadeb29c431417dc06a6b086ac1bf8b864a88bd63d78ebf9201321670", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414a931beafcbadeb29c431417dc06a6b086ac1bf8b864a88bd63d78ebf9201322734", async() => {
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
            WriteLiteral("\r\n\r\n\r\n<!-- Sweet Alerts-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414a931beafcbadeb29c431417dc06a6b086ac1bf8b864a88bd63d78ebf9201323830", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "414a931beafcbadeb29c431417dc06a6b086ac1bf8b864a88bd63d78ebf9201324894", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414a931beafcbadeb29c431417dc06a6b086ac1bf8b864a88bd63d78ebf9201325950", async() => {
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
#nullable restore
#line 158 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
             Write(Url.Action("GetRolePermissionsName", "Permission"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            method: \"GET\",\r\n            data: { \"Module\": \"Notification\" },\r\n            success: function (RoleResponse) {\r\n                $.ajax({\r\n                    url: \"");
#nullable restore
#line 163 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                     Write(Url.Action("GetUserPermissionsName", "Permission"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                    method: ""GET"",
                    data: { ""Module"": ""Notification"" },
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
                            for (let i = 0; i <");
            WriteLiteral(@" RoleResponse.length; i++) {
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
<script>
    var flag=false;
    var table = $('#datatable').DataTable({
        paging: true,
        ordering: true,
        searching: true,
 ");
            WriteLiteral(@"       ""aLengthMenu"": [20,30,50],
        dom: ""<'row'<'col-sm-3'l><'col-sm-3'f><'col-sm-6'p>>"" +
            ""<'row'<'col-sm-12'tr>>"" +
            ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
    });

    $('#datatable tbody').on('click', 'td.dtr-control', function () {
        var tr = $(this).closest('tr');
        var row = table.row(tr);
        if (!tr.hasClass(""shown"")) {

            $(""#loader"").show();
            row.child.show();
            tr.addClass('shown');
            $("".Update"").hide();
            $("".Delete"").hide();
            $("".Details"").hide();

            var module = $(""#Module"").val();
            $.ajax({
                url: """);
#nullable restore
#line 230 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                 Write(Url.Action("GetRolePermissionsName", "Permission"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                method: \"GET\",\r\n                data: { \"Module\": \"Notification\" },\r\n                success: function (RoleResponse) {\r\n                    $(\"#loader\").show();\r\n                    $.ajax({\r\n                        url: \"");
#nullable restore
#line 236 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                         Write(Url.Action("GetUserPermissionsName", "Permission"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                        method: ""GET"",
                        data: { ""Module"": ""Notification"" },
                        success: function (UserResponse) {
                            $(""#loader"").show();
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
                                        $("".Delete"").show();
                                    }
                                }
                               ");
            WriteLiteral(@" $(""#loader"").hide();
                            }
                            else if (RoleResponse.length > 0) {
                                for (let i = 0; i < RoleResponse.length; i++) {
                                    $(""#"" + RoleResponse[i]).show();
                                    if (RoleResponse[i] == ""View"") {
                                        $("".Details"").show();
                                    }
                                    if (RoleResponse[i] == ""Update"") {
                                        $(""."" + RoleResponse[i]).show();
                                    }
                                    if (RoleResponse[i] == ""Delete"") {
                                        $("".Delete"").show();
                                    }
                                }
                                $(""#loader"").hide();
                            }
                        }
                    })
                }
            });
            $(""#l");
            WriteLiteral(@"oader"").hide();
        }
        else {
            row.child.hide();
            tr.removeClass('shown');
        }
    });

    setInterval(function () {
            
            if (flag == false) {
                rezieFunction1();
            }
        }, 800);

        function rezieFunction1() {
            
            table.columns.adjust().draw();
            flag = true;
        }

    $(document).ready(function () {
        $(""#loader"").hide();
    });
</script>

<script>
    $(""#EditClose"").on(""click"", function () {
        window.location.reload();
    });
</script>
<script>
    function Update(Id, Days) {
        $(""#loader"").show();
        $.ajax({
            url: """);
#nullable restore
#line 311 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
             Write(Url.Action("UpdateNotificationDay","Notifications"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            method: ""GET"",
            data: { ""Days"": Days, ""Id"": Id },
            success: function (response) {
                $(""#loader"").hide();
                $mymodal = $(""#Edit"");
                $mymodal.find(""div.modal-body"").html(response);
                $mymodal.modal(""show"");
            }
        });
    }
</script>
<script>
    function RemoveNotification(Id) {
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
    ");
            WriteLiteral("        showConfirmButton: true,\r\n        }).then((result) => {\r\n            if (result.isConfirmed) {\r\n                $(\"#loader\").show();\r\n                $.ajax({\r\n                    url: \"");
#nullable restore
#line 347 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\Notifications\Index.cshtml"
                     Write(Url.Action("RemoveNotifications", "Notifications"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                    method: ""GET"",
                    data: { ""Id"": Id },
                    success: function (response) {
                        $(""#loader"").hide();
                        swalWithBootstrapButtons.fire({
                            title: 'Deleted.',
                            text: ""Notification Deleted Successfully..!!"",
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
</script>
<script>
    $(window).resize(function () {
        var allRows ");
            WriteLiteral(@"= $('#datatable tbody tr');
        allRows.each(function () {
            var tr = $(this).closest('tr');
            var row = $($.fn.dataTable.tables(true)).DataTable().row(tr);
            if (tr.hasClass(""shown"")) {
                row.child.hide();
                tr.removeClass('shown');
                tr.removeClass('parent');
            }
        });
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DIBN.Areas.Admin.Models.ImportReminderNotification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
