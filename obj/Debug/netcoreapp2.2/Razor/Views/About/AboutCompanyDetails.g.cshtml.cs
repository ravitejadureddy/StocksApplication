#pragma checksum "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3e143db8af5cf8f1348b2a8172c788cd2c958ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_AboutCompanyDetails), @"mvc.1.0.view", @"/Views/About/AboutCompanyDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/AboutCompanyDetails.cshtml", typeof(AspNetCore.Views_About_AboutCompanyDetails))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\_ViewImports.cshtml"
using StocksApplication;

#line default
#line hidden
#line 2 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\_ViewImports.cshtml"
using StocksApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e143db8af5cf8f1348b2a8172c788cd2c958ec", @"/Views/About/AboutCompanyDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ab59c5b997e1b869341b45c13ff186771288f54", @"/Views/_ViewImports.cshtml")]
    public class Views_About_AboutCompanyDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StocksApplication.Models.CompanyDetails>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml"
  
    ViewData["Title"] = "GetCompanyInfo";

#line default
#line hidden
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(134, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(163, 746, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3e143db8af5cf8f1348b2a8172c788cd2c958ec4103", async() => {
                BeginContext(169, 733, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Index</title>
    <style type=""text/css"">
        body {
            font-family: Arial;
            font-size: 10pt;
        }

        table {
            border: 1px solid #ccc;
            border-collapse: collapse;
            background-color: #fff;
        }

            table th {
                background-color: #66FF99;
                color: #333;
                font-weight: bold;
            }

            table th, table td {
                padding: 5px;
                border: 1px solid #ccc;
            }

            table, table table td {
                border: 0px solid #ccc;
            }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(909, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(911, 927, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3e143db8af5cf8f1348b2a8172c788cd2c958ec6022", async() => {
                BeginContext(917, 356, true);
                WriteLiteral(@"
    <div>
        <h4>Details of the Requested Company</h4>
        <hr />
        <table cellpadding=""0"" cellspacing=""0"">
            <tr>
                <th>CompanyName</th>
                <th>CompanySymbol</th>
                <th>CEO</th>
                <th>StockExchange</th>
                <th>OperatingSector</th>
            </tr>
");
                EndContext();
#line 57 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml"
             if (ViewBag.IsModelEmpty == true)
            {

#line default
#line hidden
                BeginContext(1336, 117, true);
                WriteLiteral("                <tr>\r\n                    <td colspan=\"5\">Company details are not found</td>\r\n                </tr>\r\n");
                EndContext();
#line 62 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(1501, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1548, 17, false);
#line 66 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml"
                   Write(Model.CompanyName);

#line default
#line hidden
                EndContext();
                BeginContext(1565, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1597, 12, false);
#line 67 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml"
                   Write(Model.Symbol);

#line default
#line hidden
                EndContext();
                BeginContext(1609, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1641, 9, false);
#line 68 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml"
                   Write(Model.CEO);

#line default
#line hidden
                EndContext();
                BeginContext(1650, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1682, 14, false);
#line 69 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml"
                   Write(Model.Exchange);

#line default
#line hidden
                EndContext();
                BeginContext(1696, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1728, 12, false);
#line 70 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml"
                   Write(Model.Sector);

#line default
#line hidden
                EndContext();
                BeginContext(1740, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 72 "C:\Users\dured\source\repos\StocksApplication\StocksApplication\Views\About\AboutCompanyDetails.cshtml"
            }

#line default
#line hidden
                BeginContext(1785, 46, true);
                WriteLiteral("        </table>\r\n        <br />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1838, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StocksApplication.Models.CompanyDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
