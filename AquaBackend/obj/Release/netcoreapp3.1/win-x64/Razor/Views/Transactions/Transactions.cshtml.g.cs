#pragma checksum "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df40e179e4b751ebceb0e1d4f0562693d92ca266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_Transactions), @"mvc.1.0.view", @"/Views/Transactions/Transactions.cshtml")]
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
#nullable restore
#line 1 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\_ViewImports.cshtml"
using AquaBackend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\_ViewImports.cshtml"
using AquaBackend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df40e179e4b751ebceb0e1d4f0562693d92ca266", @"/Views/Transactions/Transactions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2b7e48450a41575ee98771a8f3f45bee3258895", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_Transactions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AquaBackend.Models.Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Transacciones</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df40e179e4b751ebceb0e1d4f0562693d92ca2664521", async() => {
                WriteLiteral("\r\n    <div class=\"container\"\r\n        <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <label>Portfolio</label>\r\n            ");
#nullable restore
#line 14 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
       Write(Html.DropDownList("portfolio", new SelectList(ViewBag.portfolios, "Value", "Text"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            <label>Fecha Desde</label>\r\n            <input class=\"form-control\" type=\"date\" name=\"dateFrom\"");
                BeginWriteAttribute("value", " value=\"", 612, "\"", 670, 1);
#nullable restore
#line 18 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
WriteAttributeValue("", 620, DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd"), 620, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n\r\n            <label>Fecha Hasta</label>\r\n            <input class=\"form-control\" type=\"date\" name=\"dateTo\"");
                BeginWriteAttribute("value", " value=\"", 782, "\"", 828, 1);
#nullable restore
#line 21 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
WriteAttributeValue("", 790, DateTime.Today.ToString("yyyy-MM-dd"), 790, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  />\r\n\r\n            <button class=\"btn btn-primary\" type=\"submit\" style=\"display: inline;\">Buscar</button>\r\n\r\n        </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.PortfolioCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.TranCodeLabel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.SecTypeCode1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.Symbol2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th style=\"width:150px\">\r\n                ");
#nullable restore
#line 55 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.TradeDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width:150px\">\r\n                ");
#nullable restore
#line 58 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.SettleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.TradeAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 76 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PortfolioCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TransactionCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 88 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                   Write(String.Format("{0}{1}", item.SecTypeCode1, item.PrincipalCurrencyCode1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <span class=\"d-inline-block\" data-toggle=\"tooltip\" data-html=\"true\"");
            BeginWriteAttribute("title", " title=\"", 3047, "\"", 3100, 1);
#nullable restore
#line 91 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
WriteAttributeValue("", 3055, Html.DisplayFor(modelItem => item.FullName1), 3055, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 92 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Symbol1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 97 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                   Write(String.Format("{0}{1}", item.SecTypeCode2, item.PrincipalCurrencyCode2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        <span class=\"d-inline-block\" data-toggle=\"tooltip\" data-html=\"true\"");
            BeginWriteAttribute("title", " title=\"", 3509, "\"", 3562, 1);
#nullable restore
#line 101 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
WriteAttributeValue("", 3517, Html.DisplayFor(modelItem => item.FullName2), 3517, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 102 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Symbol2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 106 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TradeDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 109 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SettleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 112 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                         if (item.Quantity != "-1")
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                                                                        
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 119 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                         if (item.TradeAmount != "-1")
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TradeAmount));

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                                                                           
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 129 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 132 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Transactions\Transactions.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AquaBackend.Models.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
