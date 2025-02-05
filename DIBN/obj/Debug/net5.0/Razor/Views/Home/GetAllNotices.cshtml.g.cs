#pragma checksum "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9c35004b85427fbcc561af91331ecf6e0116b5a41a27604145b4ff6c63ab6799"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetAllNotices), @"mvc.1.0.view", @"/Views/Home/GetAllNotices.cshtml")]
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
#line 1 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\_ViewImports.cshtml"
using DIBN

#nullable disable
    ;
#nullable restore
#line 2 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\_ViewImports.cshtml"
using DIBN.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9c35004b85427fbcc561af91331ecf6e0116b5a41a27604145b4ff6c63ab6799", @"/Views/Home/GetAllNotices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7d5ddeb28e6b11bd8a350250841d25befde6ee969eb2ffe12afe4b0408fac805", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_GetAllNotices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DIBN.Models.ImportantReminderViewModel>>
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
#nullable restore
#line 2 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
  
    ViewData["Title"] = "GetAllNotices";

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
                <h4 class=""card-title text-center"">Important Reminders</h4>
                <hr style=""height:1px;color:black;"" />
                <div class=""table-rep-plugin"">
                    <div class=""table-responsive mb-0"" data-pattern=""priority-columns"">
                        <table id=""datatable"" class=""table table-bordered table-striped dt-responsive nowrap"" style=""border-collapse: collapse; border-spacing: 0; width: 100%;"">
                            <thead>
                                <tr>
                                    <th class=""align-middle text-center"">
                                        #
                                    </th>
                                 ");
            WriteLiteral(@"   <th class=""align-middle text-center"">
                                        Notification
                                    </th>
                                    <th>

                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 37 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                  
                                    var i = 0;
                                

#line default
#line hidden
#nullable disable

#nullable restore
#line 40 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                 foreach (var item in Model)
                                {
                                    

#line default
#line hidden
#nullable disable

#nullable restore
#line 42 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                     if (@item.Service != null && @item.Service != "")
                                    {


#line default
#line hidden
#nullable disable

            WriteLiteral("                                        <tr>\r\n                                            <td class=\"align-middle text-center\">\r\n                                                ");
            Write(
#nullable restore
#line 47 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                                  i+1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n");
#nullable restore
#line 50 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                                 if(@item.Username==""|| @item.Username==null)
                                                {
                                                    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 52 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                                     Html.Raw("<strong>" + @item.Service + "</strong> of <strong>" + item.CompanyName + "</strong> is going to Expire on " +
                                                    item.ExpiryDate + ". Only " + item.LeftDayToExpire
                                                    + " Days Left.")

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 54 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                                                    
                                                }
                                                else
                                                {
                                                    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 58 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                                     Html.Raw("<strong>" + @item.Service + "</strong> of <strong>" + item.Username + "</strong> is going to Expire on " +
                                                    item.ExpiryDate + ". Only " + item.LeftDayToExpire
                                                    + " Days Left.")

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 60 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                                                    
                                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                                            </td>\r\n                                            <td>\r\n");
#nullable restore
#line 64 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                                 if (@item.MarkAsRead == false)
                                                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                                    <a class=\"btn btn-theme\" role=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3474, "\"", 3520, 5);
            WriteAttributeValue("", 3484, "MarkAsRead(", 3484, 11, true);
            WriteAttributeValue("", 3495, 
#nullable restore
#line 66 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                                                                                                item.CompanyId

#line default
#line hidden
#nullable disable
            , 3495, 15, false);
            WriteAttributeValue("", 3510, ",", 3510, 1, true);
            WriteAttributeValue("", 3511, 
#nullable restore
#line 66 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                                                                                                                item.ID

#line default
#line hidden
#nullable disable
            , 3511, 8, false);
            WriteAttributeValue("", 3519, ")", 3519, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        Mark As Read\r\n                                                    </a>\r\n");
#nullable restore
#line 69 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 72 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"

                                        i++;
                                    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 74 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c35004b85427fbcc561af91331ecf6e0116b5a41a27604145b4ff6c63ab679913214", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c35004b85427fbcc561af91331ecf6e0116b5a41a27604145b4ff6c63ab679914312", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c35004b85427fbcc561af91331ecf6e0116b5a41a27604145b4ff6c63ab679915376", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c35004b85427fbcc561af91331ecf6e0116b5a41a27604145b4ff6c63ab679916464", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c35004b85427fbcc561af91331ecf6e0116b5a41a27604145b4ff6c63ab679917528", async() => {
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
    $('#datatable').dataTable({
        paging: true,
        ordering: true,
        searching: true,
        ""aLengthMenu"": [20, 30, 50],
    });
    $(document).ready(function () {
        $(""#loader"").hide();
    });
</script>
<script>
    function MarkAsRead(CompanyId,Id){
        $.ajax({
            url: """);
            Write(
#nullable restore
#line 108 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\GetAllNotices.cshtml"
                   Url.Action("MarkAsReadNotification","Home")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\",\r\n            method: \"GET\",\r\n            data:{\"CompanyId\":CompanyId,\"Id\":Id},\r\n            success: function (response) {\r\n                window.location.reload();\r\n            }\r\n        });\r\n    };\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DIBN.Models.ImportantReminderViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
