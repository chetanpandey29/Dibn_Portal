#pragma checksum "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d2063506d714251e035f26cb32e5dab72f601ce20f6928d6b6848bd3638f51a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MessageTemplate_MailHistory), @"mvc.1.0.view", @"/Areas/Admin/Views/MessageTemplate/MailHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d2063506d714251e035f26cb32e5dab72f601ce20f6928d6b6848bd3638f51a5", @"/Areas/Admin/Views/MessageTemplate/MailHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"605a41b4408e5d1ff247f7264e35f4305eb9eeecf14a77cb4f30041778bbf31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_MessageTemplate_MailHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DIBN.Areas.Admin.Models.MailHistory>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-bs4/js/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-responsive/js/dataTables.responsive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/datatables.net-responsive-bs4/js/responsive.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12 float-end\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 174, "\"", 245, 1);
#nullable restore
#line 8 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
WriteAttributeValue("", 181, Url.Action("SendMail","MessageTemplate",new{name=@item.Module}), 181, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-blue mb-3 ms-3 float-end\">Send Email</a>\r\n        </div>\r\n        <input type=\"hidden\" name=\"Module\" id=\"Module\"");
            BeginWriteAttribute("value", " value=\"", 374, "\"", 394, 1);
#nullable restore
#line 10 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
WriteAttributeValue("", 382, item.Module, 382, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n");
#nullable restore
#line 12 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"

    break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""card-title"">
                    Email History
                    <hr class=""text-blue"" style=""height:1.5px;"" />
                </div>
                <div class=""table-rep-plugin"">
                    <div class=""table-responsive mb-0"" data-pattern=""priority-columns"">
                        <table id=""datatable"" class=""table table-bordered table-striped dt-responsive nowrap"" style=""border-collapse: collapse; border-spacing: 0; width: 100%;"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Email Send On</th>
                                    <th>Company</th>
                                    <th>Mail From</th>
                                    <th>Mail To</th>
                                    <th>Subject</th>
                          ");
            WriteLiteral("          <th>Email Send By</th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 40 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                  
                                    var i = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                 foreach (var item in Model)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                     if (item.Body != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 48 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                            Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 50 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                           Write(item.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 53 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                           Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 56 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                           Write(item.FromMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td");
            BeginWriteAttribute("title", " title=\"", 2615, "\"", 2635, 1);
#nullable restore
#line 58 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
WriteAttributeValue("", 2623, item.ToMail, 2623, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 59 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                                 if (item.ToMail.Contains(","))
                                                {
                                                    var _index = item.ToMail.IndexOf(",");
                                                    var emailId = item.ToMail.Substring(0, _index);
                                                    emailId = emailId + "...";
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                               Write(Html.Raw(emailId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                                                      
                                                }
                                                else
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                               Write(item.ToMail);

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                                                
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 72 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 75 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                           Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <span class=\"btn btn-blue Update\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3900, "\"", 3929, 3);
            WriteAttributeValue("", 3910, "ViewEmail(", 3910, 10, true);
#nullable restore
#line 78 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
WriteAttributeValue("", 3920, item.Id, 3920, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3928, ")", 3928, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    View\r\n                                                </span>\r\n                                                <span class=\"btn btn-blue Update\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4129, "\"", 4160, 3);
            WriteAttributeValue("", 4139, "ResendEmail(", 4139, 12, true);
#nullable restore
#line 81 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
WriteAttributeValue("", 4151, item.Id, 4151, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4159, ")", 4159, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    Re-send\r\n                                                </span>\r\n                                                <span class=\"btn btn-blue Update\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4363, "\"", 4394, 3);
            WriteAttributeValue("", 4373, "DeleteEmail(", 4373, 12, true);
#nullable restore
#line 84 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
WriteAttributeValue("", 4385, item.Id, 4385, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4393, ")", 4393, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    Delete\r\n                                                </span>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 89 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                        i++;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2063506d714251e035f26cb32e5dab72f601ce20f6928d6b6848bd3638f51a518172", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2063506d714251e035f26cb32e5dab72f601ce20f6928d6b6848bd3638f51a519270", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2063506d714251e035f26cb32e5dab72f601ce20f6928d6b6848bd3638f51a520334", async() => {
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
            WriteLiteral("\r\n<!-- Responsive examples -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2063506d714251e035f26cb32e5dab72f601ce20f6928d6b6848bd3638f51a521430", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2063506d714251e035f26cb32e5dab72f601ce20f6928d6b6848bd3638f51a522494", async() => {
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
            WriteLiteral("\r\n<!-- Sweet Alerts-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2063506d714251e035f26cb32e5dab72f601ce20f6928d6b6848bd3638f51a523582", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2063506d714251e035f26cb32e5dab72f601ce20f6928d6b6848bd3638f51a524646", async() => {
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
            WriteLiteral(@"

<script>
    $(function () {

        var module = $(""#Module"").val();
        const swalWithBootstrapButtons = Swal.mixin({
            customClass: {
                confirmButton: 'ms-3 btn btn-success',
                cancelButton: 'btn btn-danger'
            },
            buttonsStyling: false
        })
        var message = '");
#nullable restore
#line 124 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                  Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        if (message != """") {
            swalWithBootstrapButtons.fire({
                title: 'Success.',
                text: message,
                icon: 'success'
            }).then((result) => {
                message = """";
                var url = """);
#nullable restore
#line 132 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                      Write(Url.Action("MailHistory","MessageTemplate"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                url = url + ""?name="" + module;
                window.location.href = url;
            });
        }

    });
</script>
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
    $('#datatable-1').dataTable({
        paging: true,
        ordering: true,
        searching: true,
        ""aLengthMenu"": [20, 30, 50],
        dom: ""<'row'<'col-sm-3'l><'col-sm-3'f><'col-sm-6'p>>"" +
            ""<'row'<'col-sm-12'tr>>"" +
            ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
    });
    $('#datatable-2').dataTable({
        paging: true,
        ordering: true,
        searching: true,
        ""aLengthMenu"": [20, 30, 50],
        dom: ""<'row'<'col-sm-3'l><'col-sm-3'f><'col-sm-6'p>>"" +
            ""<'row'<'col-sm-12'tr>>");
            WriteLiteral(@""" +
            ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
    });
</script>
<script>
    function DeleteEmail(Id) {
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
                $.ajax({
                    url: """);
#nullable restore
#line 192 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                     Write(Url.Action("DeleteEmail", "MessageTemplate"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                    method: ""GET"",
                    data: { ""Id"": Id },
                    success: function (response) {
                        swalWithBootstrapButtons.fire({
                            title: 'Deleted.',
                            text: ""Selected Email Deleted Successfully..!!"",
                            icon: 'success'
                        }).then((result) => {
                            window.location.reload();
                        });
                    }
                });
            }
            else if (
                /* Read more about handling dismissals below */
                result.dismiss === Swal.DismissReason.cancel
            ) {
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
    function ViewEmail(Id) {
        var module = $(""#Module"").val();
 ");
            WriteLiteral("       var url = \"");
#nullable restore
#line 222 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
              Write(Url.Action("GetMailDetails","MessageTemplate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        window.location.href = url + \"?name=\" + module + \"&Id=\" + Id;\r\n    }\r\n\r\n    function ForwardEmail(Id) {\r\n        var module = $(\"#Module\").val();\r\n        var url = \"");
#nullable restore
#line 228 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
              Write(Url.Action("ForwardEmail","MessageTemplate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        window.location.href = url + \"?name=\" + module + \"&Id=\" + Id;\r\n    }\r\n\r\n    function ResendEmail(Id) {\r\n        var module = $(\"#Module\").val();\r\n        $.ajax({\r\n            url: \"");
#nullable restore
#line 235 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
             Write(Url.Action("ResendEmail", "MessageTemplate"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            method: ""GET"",
            data: { ""name"": module, ""Id"": Id },
            async: false,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (CompanyResponse) {
                const swalWithBootstrapButtons = Swal.mixin({
                    customClass: {
                        confirmButton: 'ms-3 btn btn-success',
                        cancelButton: 'btn btn-danger'
                    },
                    buttonsStyling: false
                })
                swalWithBootstrapButtons.fire({
                    title: 'Success.',
                    text: CompanyResponse,
                    icon: 'success'
                }).then((result) => {
                    message = """";
                    var url = """);
#nullable restore
#line 255 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
                          Write(Url.Action("MailHistory","MessageTemplate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                    url = url + \"?name=\" + module;\r\n                    window.location.href = url;\r\n                });\r\n            }\r\n        });\r\n    }\r\n</script>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n<script>\r\n    function GetDocumentsForActiveUser(Id) {\r\n\r\n        var Module = $(\"#Module\").val();\r\n        var url = \"");
#nullable restore
#line 356 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
              Write(Url.Action("GetMyDocuments","User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        window.location.href = url + \"?Id=\" + Id + \"&Type=Active&name=\" + Module;\r\n    }\r\n</script>\r\n<script>\r\n    function GetDocumentsForInActiveUser(Id) {\r\n\r\n        var Module = $(\"#Module\").val();\r\n        var url = \"");
#nullable restore
#line 364 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\MessageTemplate\MailHistory.cshtml"
              Write(Url.Action("GetMyDocuments","User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        window.location.href = url + \"?Id=\" + Id + \"&Type=InActive\" + \"&name=\" + Module;\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DIBN.Areas.Admin.Models.MailHistory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
