#pragma checksum "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\PageNotFound.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "784b8f96683514296abc02bac091cd2447f8fb7895e348b4eae079321fde7bc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PageNotFound), @"mvc.1.0.view", @"/Views/Home/PageNotFound.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"784b8f96683514296abc02bac091cd2447f8fb7895e348b4eae079321fde7bc4", @"/Views/Home/PageNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7d5ddeb28e6b11bd8a350250841d25befde6ee969eb2ffe12afe4b0408fac805", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PageNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-white m-0 p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 44 "D:\DIBN PORTAL\DIBN PORTAL - LIVE\DIBN\Views\Home\PageNotFound.cshtml"
  
    ViewBag.Title = "404 Error";
    Layout = "~/Views/Shared/Theme/_BlankLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<html class=\"bg-white\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "784b8f96683514296abc02bac091cd2447f8fb7895e348b4eae079321fde7bc43880", async() => {
                WriteLiteral(@"
    <div class=""container"">
      <div class=""row"">
        <div class=""col-md-12 mt-5"">
          <div class=""animation d-flex justify-content-center"">
            <div class=""one spin-one""></div>
            <div class=""two spin-two""></div>
            <div class=""three spin-one""></div>
          </div>
        </div>
        <div class=""col-md-12"">
          <h1 class=""text-center display-4 fw-bolder"">Under maintenance</h1>
          <p class=""text-center mt-3 fs-4 fw-bolder"">Please wait for a while. Our developers are working on it, We are sorry for the inconvenience.</p>
        </div>
      </div>  
    </div>
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<style>
  body {
  font-family: 'Noto Sans', sans-serif;
  color:#616161 /*#757575*/;
  background-color:#eeeeee;
 }


.box {
  width: auto ;
  height: 500px;
  background: #fff;
  margin-top:50px;
  margin-left: 100px;
  margin-right: 100px;
  border-radius:5px;
  box-shadow: 6px 18px 18px rgba(0, 0, 0, 0.08), -6px 18px 18px rgba(0, 0, 0, 0.08);
}

.animation{
  margin-top:20%;
  display:inline-block;
  margin-bottom:5%;
}

h1{
  font-size:32px;
  font-weight:400;
  text-transform:uppercase;
  margin:0;
}
p{
  font-size:16px;
  font-weight:700;
  margin:0;
}

a{
  color: #243c7c;
  font-weight: bold;
  text-decoration: none;
  margin-left:5px;
}

.one, .two, .three {
  display:block;
  float:left;
}

.one {
  background: url('/maintanance/download.png');
  width:100px;
  height:100px;
  background-size:100% 100%;
  background-repeat:no-repeat;
  margin-top:-10px;
  margin-right:8px;
}

.two {
  background: url('/maintanance/icons8-setti");
            WriteLiteral(@"ngs.svg');
  width:120px;
  height:120px;
  background-size:100% 100%;
  background-repeat:no-repeat;
}

.three {
  background: url('/maintanance/download.png');
  width:100px;
  height:100px;
  background-size:100% 100%;
  background-repeat:no-repeat;
  margin-top:-50px;
  margin-left:-10px;
}

");
            WriteLiteral(@"@keyframes spin-one {
  0% {
    -webkit-transform: rotate(0deg);
    transform: rotate(0deg);
  }
  100% {
    -webkit-transform: rotate(-359deg) ;
    transform: rotate(-359deg) ;
  }
}

.spin-one {
  -webkit-animation: spin-one 1.5s infinite linear;
  animation: spin-one 1.5s infinite linear;
}

");
            WriteLiteral(@"@keyframes spin-two {
  0% {
    -webkit-transform: rotate(0deg);
    transform: rotate(0deg);
  }
  100% {
    -webkit-transform: rotate(-359deg);
    transform: rotate(359deg);
  }
}

.spin-two {
  -webkit-animation: spin-two 2s infinite linear;
  animation: spin-two 2s infinite linear;
}
</style>");
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
