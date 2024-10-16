#pragma checksum "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0995c2787de444a8f3138bfd7cf438c40a3eeb43868c14ff26a9bdfc60593d84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ReportManagement_ProfitLossCompanyMonthlyReport), @"mvc.1.0.view", @"/Areas/Admin/Views/ReportManagement/ProfitLossCompanyMonthlyReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0995c2787de444a8f3138bfd7cf438c40a3eeb43868c14ff26a9bdfc60593d84", @"/Areas/Admin/Views/ReportManagement/ProfitLossCompanyMonthlyReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"605a41b4408e5d1ff247f7264e35f4305eb9eeecf14a77cb4f30041778bbf31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ReportManagement_ProfitLossCompanyMonthlyReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DIBN.Areas.Admin.Models.ProfitLossCompanyMonthlyReportModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
  
    ViewData["Title"] = "Profit & Loss Monthly Report of Company";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .wrapper {
        display: flex;
        justify-content: center;
        align-items: center;
    }

    button {
        display: flex;
        justify-content: center;
        align-items: center;
        position: relative;
        color: #333333;
        border: none;
        background: transparent;
        font-size: 1rem;
        line-height: 1.5rem;
        padding: 1rem 2rem;
    }

        button > svg {
            position: absolute;
            width: 100%;
            height: 100%;
        }

            button > svg > rect {
                fill: none;
                stroke: #333333;
                stroke-width: 2px;
                stroke-dasharray: 240 160 240 160;
                stroke-dashoffset: 0;
                animation: pathRect 2s linear infinite;
                width: calc(100% - 2px);
                height: calc(100% - 2px);
            }

    ");
            WriteLiteral(@"@keyframes pathRect {
        25% {
            stroke-dashoffset: 100;
        }

        50% {
            stroke-dashoffset: 200;
        }

        75% {
            stroke-dashoffset: 300;
        }

        100% {
            stroke-dashoffset: 400;
        }
    }
</style>

<div class=""row"">
    <div class=""col-lg-12"">
        <a");
            BeginWriteAttribute("href", " href=\"", 1445, "\"", 1540, 1);
#nullable restore
#line 64 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
WriteAttributeValue("", 1452, Url.Action("CompanyProfitLossReport","ReportManagement",new{companyId=Model.companyId}), 1452, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-blue float-end me-2 mb-2\">Back</a>\r\n        <a role=\"button\" class=\"btn btn-blue float-end me-2 mb-2 Details\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1666, "\"", 1749, 7);
            WriteAttributeValue("", 1676, "ExportAsExcel(\'", 1676, 15, true);
#nullable restore
#line 65 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
WriteAttributeValue("", 1691, Model.MonthNumber, 1691, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1709, "\',\'", 1709, 3, true);
#nullable restore
#line 65 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
WriteAttributeValue("", 1712, Model.YearNumber, 1712, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1729, "\',", 1729, 2, true);
#nullable restore
#line 65 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
WriteAttributeValue("", 1731, Model.companyId, 1731, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1747, ");", 1747, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Export Excel</a>\r\n        <a role=\"button\" class=\"btn btn-blue float-end me-2 mb-2 Details\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1842, "\"", 1923, 7);
            WriteAttributeValue("", 1852, "ExportAsPdf(\'", 1852, 13, true);
#nullable restore
#line 66 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
WriteAttributeValue("", 1865, Model.MonthNumber, 1865, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1883, "\',\'", 1883, 3, true);
#nullable restore
#line 66 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
WriteAttributeValue("", 1886, Model.YearNumber, 1886, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1903, "\',", 1903, 2, true);
#nullable restore
#line 66 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
WriteAttributeValue("", 1905, Model.companyId, 1905, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1921, ");", 1921, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Export PDF</a>\r\n    </div>\r\n</div>\r\n<div class=\"row Details\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <h4 class=\"text-center front-text-blue fw-bold\">Profit & Loss Monthly Report of ");
#nullable restore
#line 73 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                                                                                           Write(Model.MonthText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ");
#nullable restore
#line 73 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                                                                                                              Write(Model.YearNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 73 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                                                                                                                                   Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <input type=\"hidden\" name=\"MonthNumber\" id=\"MonthNumber\"");
            BeginWriteAttribute("value", " value=\"", 2314, "\"", 2340, 1);
#nullable restore
#line 74 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
WriteAttributeValue("", 2322, Model.MonthNumber, 2322, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"YearNumber\" id=\"YearNumber\"");
            BeginWriteAttribute("value", " value=\"", 2416, "\"", 2441, 1);
#nullable restore
#line 75 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
WriteAttributeValue("", 2424, Model.YearNumber, 2424, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"companyId\" id=\"companyId\"");
            BeginWriteAttribute("value", " value=\"", 2515, "\"", 2539, 1);
#nullable restore
#line 76 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
WriteAttributeValue("", 2523, Model.companyId, 2523, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div class=\"row col-md-12 mt-4 mb-3\">\r\n                    <div class=\"float-left text-center\">\r\n");
#nullable restore
#line 79 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                         if (Model.totalProfitLoss > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-center float-left front-text-blue h6 fw-bold\">Profit :</span>\r\n");
            WriteLiteral("                            <span class=\"text-center float-left text-success h6 fw-bold\"> ");
#nullable restore
#line 83 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                                                                                     Write(Model.totalProfitLoss.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" AED (");
#nullable restore
#line 83 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                                                                                                                                  Write(Model.profitLossPercentage.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" %) </span>\r\n");
#nullable restore
#line 84 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-center float-left front-text-blue h6 fw-bold\">Loss :</span>\r\n");
            WriteLiteral("                            <span class=\"text-center float-left text-danger h6 fw-bold\"> ");
#nullable restore
#line 89 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                                                                                    Write(Model.totalProfitLoss.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" AED (");
#nullable restore
#line 89 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                                                                                                                                 Write(Model.profitLossPercentage.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" %)</span>\r\n");
#nullable restore
#line 90 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                <div class=""row col-md-12 mt-4 mb-3"">
                    <div class=""float-left text-center"">
                        <span class=""text-center float-left front-text-blue h6 fw-bold"">Total Credit :</span><span class=""text-center float-left text-success h6 fw-bold""> ");
#nullable restore
#line 95 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                                                                                                                                                                      Write(Model.TotalCredit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" AED</span>
                        <span class=""text-center float-left front-text-blue h6 fw-bold"">||</span>
                        <span class=""text-center float-left front-text-blue h6 fw-bold"">Total Debit : </span><span class=""text-center float-left text-danger h6 fw-bold"">-");
#nullable restore
#line 97 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                                                                                                                                                                     Write(Model.TotalDebit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" AED</span>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""table-rep-plugin"">
                    <div class=""table-responsive mb-0"" data-pattern=""priority-columns"">
                        <table id=""datatable"" class=""table table-bordered table-striped dt-responsive nowrap"" style=""border-collapse:collapse; border-spacing:0; width:100%;"">
                            <thead>
                                <tr>
                                    <th>
                                        Transaction Id
                                    </th>
                                    <th data-sort='YYYYMMDD'>
                                        Transaction Date
                                    </th>
                                    <th>
                                        Company
                                    </th>
                                    <th>
                                 ");
            WriteLiteral(@"       Description
                                    </th>
                                    <th>
                                        Grand Total
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade bd-example-modal"" id=""multipleDownloadErrorModal"" role=""dialog"" data-bs-keyboard=""false"" data-bs-backdrop=""static"" style=""z-index:10000 !important;"">
    <div class=""modal-dialog modal-dialog-centered modal"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body pt-0"">
                <div class=""d-flex justify-content-center align-items-center"">
                    <div class=""mt-5"">
                        <div class='wrapper'>
                            <b");
            WriteLiteral(@"utton>
                                <span class=""fw-bolder fs-5"">Downloading...</span>
                                <svg>
                                    <rect x=""1"" y=""1""></rect>
                                </svg>
                            </button>
                        </div>
                    </div>
                </div>
                <div class=""col-md-12 mt-5"">
                    <p class=""text-center fw-bolder fs-5"">Please wait for while , your report (PDF/Excel) file is currently downloading..</p>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $.fn.dataTable.ext.errMode = 'none';

        var month = $(""#MonthNumber"").val();
        var year = $(""#YearNumber"").val();
        var companyId = $(""#companyId"").val();

        var url = """);
#nullable restore
#line 166 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
              Write(Url.Action("ProfitLossCompanyMonthlyPaginationReport","ReportManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
        url = url + ""?month="" + month + ""&year="" + year + ""&companyId="" + companyId;

        $(""#datatable"").DataTable({
            ""processing"": true,
            ""serverSide"": true,
            ""filter"": false,
            ""ajax"": {
                ""type"": ""post"",
                ""datatype"": ""json"",
                ""data"": function () {
                    var info = $('#datatable').DataTable().page.info();
                    $('#datatable').DataTable().ajax.url(
                        url
                    );
                }
            },
            ""columns"": [
                { ""data"": ""transactionId"", ""name"": ""Transaction Id"" },
                { ""data"": ""date"", ""name"": ""Transaction Date"" },
                { ""data"": ""companyName"", ""name"": ""Company"" },
                { ""data"": ""description"", ""name"": ""Description"" },
                {
                    ""data"": function (data, full, meta) {
                        if (data.type == ""Debit"") {
                       ");
            WriteLiteral(@"     return '<span class=""text-danger"">' + data.grandTotal + '</span>';
                        }
                        else if (data.type == ""Credit"" && data.expenseReceiptId != 0) {
                            return '<span class=""text-success"">' + data.grandTotal + '</span>';
                        }
                        else {
                            return '---';
                        }
                    },
                    ""name"": ""Grand Total""
                },
            ],
            ""language"": {
                'processing': '<div class=""spinner-2""><div class=""center-div-2""><div class=""loader-circle-1""></div></div></div>'
            },
            responsive: true,
            paging: true,
            pagingType: 'simple_numbers',
            ""bInfo"": true,
            ordering: true,
            ""aLengthMenu"": [20, 30, 50],
            searching: true,
            dom: ""<'row'<'col-sm-3'l><'col-sm-3'f><'col-sm-6'p>>"" +
                ""<'row'<'col-sm-12");
            WriteLiteral(@"'tr>>"" +
                ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
        });
    });
</script>

<script>
    function ExportAsExcel(month, year,companyId) {
        $mymodal = $(""#multipleDownloadErrorModal"");
        $mymodal.find(""div.modal-body"");
        $mymodal.modal(""show"");

        $.ajax({
            url: '");
#nullable restore
#line 227 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
             Write(Url.Action("ProfitLossCompanyMonthlyReportExcel", "ReportManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            data: { 'month': month, 'year': year, 'companyId': companyId },
            success: function (result) {
                $mymodal = $(""#multipleDownloadErrorModal"");
                $mymodal.find(""div.modal-body"");
                $mymodal.modal(""hide"");

                if (result == ""Success"") {
                    var url = """);
#nullable restore
#line 236 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                          Write(Url.Action("DownloadProfitLossCompanyMonthlyReportExcel","ReportManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                    url = url + ""?month="" + month + ""&year="" + year + ""&companyId="" + companyId;
                    window.location.href = url;

                    setTimeout(function () {
                        window.location.reload();
                    }, 2000);
                }
            },
            error: function () {
                alert(""Something went wrong please try again after sometimes."");
                setTimeout(function () {
                    window.location.reload();
                }, 2000);
            }
        });
    };

    function ExportAsPdf(month, year,companyId) {
        $mymodal = $(""#multipleDownloadErrorModal"");
        $mymodal.find(""div.modal-body"");
        $mymodal.modal(""show"");

        $.ajax({
            url: '");
#nullable restore
#line 260 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
             Write(Url.Action("ProfitLossCompanyMonthlyReportPdf", "ReportManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            data: { 'month': month, 'year': year, 'companyId': companyId },
            success: function (result) {
                $mymodal = $(""#multipleDownloadErrorModal"");
                $mymodal.find(""div.modal-body"");
                $mymodal.modal(""hide"");

                if (result == ""Success"") {
                    var url = """);
#nullable restore
#line 269 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                          Write(Url.Action("DownloadProfitLossCompanyMonthlyReportPdf","ReportManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                    url = url + ""?month="" + month + ""&year="" + year + ""&companyId="" + companyId;
                    window.location.href = url;

                    setTimeout(function () {
                        window.location.reload();
                    }, 2000);
                }
            },
            error: function () {
                alert(""Something went wrong please try again after sometimes."");
                setTimeout(function () {
                    window.location.reload();
                }, 2000);
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
#nullable restore
#line 301 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
             Write(Url.Action("GetRolePermissionsName", "Permission"));

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 310 "D:\Devotion Business\DIBN\DIBN\Areas\Admin\Views\ReportManagement\ProfitLossCompanyMonthlyReport.cshtml"
                     Write(Url.Action("GetUserPermissionsName", "Permission"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DIBN.Areas.Admin.Models.ProfitLossCompanyMonthlyReportModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
