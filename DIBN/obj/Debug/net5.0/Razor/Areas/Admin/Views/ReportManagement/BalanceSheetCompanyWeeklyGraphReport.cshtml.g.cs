#pragma checksum "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f037beaa62046cd56e07b02884bb6ca6dbfe203edc97a895eedb388f99dc31a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ReportManagement_BalanceSheetCompanyWeeklyGraphReport), @"mvc.1.0.view", @"/Areas/Admin/Views/ReportManagement/BalanceSheetCompanyWeeklyGraphReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f037beaa62046cd56e07b02884bb6ca6dbfe203edc97a895eedb388f99dc31a5", @"/Areas/Admin/Views/ReportManagement/BalanceSheetCompanyWeeklyGraphReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"605a41b4408e5d1ff247f7264e35f4305eb9eeecf14a77cb4f30041778bbf31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ReportManagement_BalanceSheetCompanyWeeklyGraphReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DIBN.Areas.Admin.Models.BalanceSheetWeeklyReportByCompanyIdModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/charts/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/charts/Chart.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/charts/chart-2.8.0.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/charts/hammerjs-2.8.0.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/charts/chartjs-plugin-zoom-0.7.3.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
  
    ViewData["Title"] = "Balance Sheet Weekly Graph Report";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<style>
    .canvasHeight {
        height: 680px !important;
    }
</style>
<div id=""loader"">
    <div class=""spinner-1"">
        <div class=""center-div-1"">
            <div class=""loader-circle-75"">
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <a");
            BeginWriteAttribute("href", " href=\"", 470, "\"", 567, 1);
            WriteAttributeValue("", 477, 
#nullable restore
#line 22 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                  Url.Action("CompanyBalanceSheetReport","ReportManagement",new{companyId=Model.CompanyId})

#line default
#line hidden
#nullable disable
            , 477, 90, false);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-theme float-end me-2 mb-2"">Back</a>
    </div>
</div>
<div class=""row"" id=""View"">
    <div class=""col-md-12 col-xl-12 col-sm-12 col"" id=""PieChart"">
        <div class=""card"">
            <div class=""card-body"">
                <h3 class=""mb-4 text-center front-text-theme""><strong>Balance Sheet Weekly Report's Graph Representation - ( ");
            Write(
#nullable restore
#line 29 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                                                                                              Model.FromDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" - ");
            Write(
#nullable restore
#line 29 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                                                                                                                Model.ToDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" ) of ");
            Write(
#nullable restore
#line 29 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                                                                                                                                   Model.CompanyName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</strong></h3>\r\n                <input name=\"FromDates\" id=\"fromDate\"");
            BeginWriteAttribute("value", " value=\"", 1051, "\"", 1075, 1);
            WriteAttributeValue("", 1059, 
#nullable restore
#line 30 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                              Model.FromDates

#line default
#line hidden
#nullable disable
            , 1059, 16, false);
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\" />\r\n                <input name=\"ToDates\" id=\"toDate\"");
            BeginWriteAttribute("value", " value=\"", 1144, "\"", 1166, 1);
            WriteAttributeValue("", 1152, 
#nullable restore
#line 31 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                          Model.ToDates

#line default
#line hidden
#nullable disable
            , 1152, 14, false);
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\" />\r\n                <input name=\"CompanyId\" id=\"companyId\"");
            BeginWriteAttribute("value", " value=\"", 1240, "\"", 1264, 1);
            WriteAttributeValue("", 1248, 
#nullable restore
#line 32 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                               Model.CompanyId

#line default
#line hidden
#nullable disable
            , 1248, 16, false);
            EndWriteAttribute();
            WriteLiteral(@" type=""hidden"" />
                <div class=""col-md-12"">
                    <div class=""col-md-9 col-sm-12 float-start"">
                        <div class=""chart-container"" id=""PieFinanceChartInfo"">
                            <canvas class=""mb-3"" id=""PieFinanceChart"">
                            </canvas>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-12 float-start"">
                        <table class=""table table-bordered table-striped"" style=""border:1px solid #000;"">
                            <thead>
                                <tr>
                                    <th colspan=""2"" class=""text-center fw-bolder fs-5 bg-blue text-white"">
                                        Total(s)
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class=");
            WriteLiteral("\"fw-bolder fs-6\">Total Debit (AED)</td>\r\n                                    <td class=\"fw-bolder fs-6 text-danger\">");
            Write(
#nullable restore
#line 52 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                                            Html.Raw("-")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 52 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                                                          Model.TotalDebit

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@" AED</td>
                                </tr>
                                <tr>
                                    <td class=""fw-bolder fs-6"">Total Credit (AED)</td>
                                    <td class=""fw-bolder fs-6"" style=""color:#008000 !important;"">");
            Write(
#nullable restore
#line 56 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                                                                  Model.TotalCredit

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" AED</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td class=\"fw-bolder fs-6\">Total Balance (AED)</td>\r\n                                    <td class=\"fw-bolder fs-6\">\r\n");
#nullable restore
#line 61 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                         if (Model.TotalBalance.StartsWith("-"))
                                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                            <span class=\"text-danger\">");
            Write(
#nullable restore
#line 63 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                                       Model.TotalBalance

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" AED</span>\r\n");
#nullable restore
#line 64 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                            <span style=\"color:#008000 !important;\">");
            Write(
#nullable restore
#line 67 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                                                                     Model.TotalBalance

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" AED</span>\r\n");
#nullable restore
#line 68 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                                        }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                
            </div>
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f037beaa62046cd56e07b02884bb6ca6dbfe203edc97a895eedb388f99dc31a515827", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f037beaa62046cd56e07b02884bb6ca6dbfe203edc97a895eedb388f99dc31a516895", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f037beaa62046cd56e07b02884bb6ca6dbfe203edc97a895eedb388f99dc31a517959", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f037beaa62046cd56e07b02884bb6ca6dbfe203edc97a895eedb388f99dc31a519023", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f037beaa62046cd56e07b02884bb6ca6dbfe203edc97a895eedb388f99dc31a520087", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f037beaa62046cd56e07b02884bb6ca6dbfe203edc97a895eedb388f99dc31a521151", async() => {
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
            WriteLiteral(@"
<script>
    $(function () {
        $(""#loader"").show();
        LoadProfitLossPieChart();
    });

    function LoadProfitLossPieChart() {
        $(""#loader"").show();
        var fromDate = $(""#fromDate"").val();
        var toDate = $(""#toDate"").val();
        var companyId = $(""#companyId"").val();
        $.ajax({
            type: ""GET"",
            url: """);
            Write(
#nullable restore
#line 101 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                   Url.Action("BalanceSheetCompanyWeeklyReportPieGraphData","ReportManagement")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
            data: { ""fromDate"": fromDate, ""toDate"": toDate, ""companyId"": companyId },
            success: function (response) {
                var ctx = document.getElementById(""PieFinanceChart"").getContext(""2d"");
                var _values = eval(response);
                var _dataValues = new Array();
                var _background = new Array();
                var _lables = new Array();

                for (var i = 0; i < _values.length; i++) {
                    _dataValues.push(_values[i].value);
                    _background.push(_values[i].color);
                    _lables.push(_values[i].text);
                }
                var data = {
                    labels: _lables,
                    datasets: [{
                        data: _dataValues,
                        backgroundColor: _background
                    }]
                };

                var options = {
                    animation: {
                        easing: 'easeInOutQuart',
   ");
            WriteLiteral(@"                     duration: 1000
                    }
                };
                var myPieChart = new Chart(ctx, {
                    type: 'pie',
                    data: data,
                    options: options
                });

                $(""#loader"").hide();
            },
            failure: function (response) {
                alert('There was an error.');
                $(""#loader"").hide();
            }
        });
    };
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
        $(""#loader"").show();
        var module = $(""#Module"").val();
        $.ajax({
            url: """);
            Write(
#nullable restore
#line 159 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                   Url.Action("GetRolePermissionsName", "Permission")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
            method: ""GET"",
            data: { ""Module"": ""ReportManagement"" },
            async: false,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (RoleResponse) {
                $(""#loader"").show();
                $.ajax({
                    url: """);
            Write(
#nullable restore
#line 168 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Areas\Admin\Views\ReportManagement\BalanceSheetCompanyWeeklyGraphReport.cshtml"
                           Url.Action("GetUserPermissionsName", "Permission")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@""",
                    method: ""GET"",
                    data: { ""Module"": ""ReportManagement"" },
                    async: false,
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
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
                                    $(""."" + UserResponse[i]).show();
        ");
            WriteLiteral(@"                        }
                            }
                            $(""#loader"").hide();
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
                                    $(""."" + RoleResponse[i]).show();
                                }
                            }
                            $(""#loader"").hide();

                        } else {
                            alert(""You don't have any permissi");
            WriteLiteral("on for this module.\");\r\n                            $(\"#loader\").hide();\r\n                        }\r\n                    }\r\n                })\r\n            }\r\n        });\r\n        $(\"#loader\").hide();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DIBN.Areas.Admin.Models.BalanceSheetWeeklyReportByCompanyIdModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
