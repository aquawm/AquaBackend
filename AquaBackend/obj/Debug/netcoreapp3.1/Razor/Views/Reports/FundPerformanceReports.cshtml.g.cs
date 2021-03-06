#pragma checksum "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Reports\FundPerformanceReports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e94699181ae48cf1497e10b6fa8e55d8a8e5c8e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_FundPerformanceReports), @"mvc.1.0.view", @"/Views/Reports/FundPerformanceReports.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94699181ae48cf1497e10b6fa8e55d8a8e5c8e2", @"/Views/Reports/FundPerformanceReports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2b7e48450a41575ee98771a8f3f45bee3258895", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_FundPerformanceReports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AquaBackend.Models.Reports>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Reports\FundPerformanceReports.cshtml"
  
    ViewData["Title"] = "Performance Review";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <h3>Reportes Performance Review</h3>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Asset Class
            </th>
            <th>
                Sub Asset Class
            </th>
            <th>
                Fondo
            </th>
            <th>
                Fecha
            </th>
            <th>
                Ultima Actualización
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Reports\FundPerformanceReports.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Reports\FundPerformanceReports.cshtml"
           Write(item.Custom1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Reports\FundPerformanceReports.cshtml"
           Write(item.Custom2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Reports\FundPerformanceReports.cshtml"
           Write(item.Report);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Reports\FundPerformanceReports.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Reports\FundPerformanceReports.cshtml"
           Write(item.LastUpdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("                <a class=\"btn btn-primary float-left\" target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 1123, "\"", 1291, 1);
#nullable restore
#line 50 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Reports\FundPerformanceReports.cshtml"
WriteAttributeValue("", 1130, Url.Action("ViewFundPerformanceReport", "Reports", new { description = item.Description, report = item.Report, custom1 = item.Custom1, custom2 = item.Custom2 }), 1130, 161, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    Ver Reporte\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\lmachado\source\Aquawm\AquaBackend\AquaBackend\Views\Reports\FundPerformanceReports.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AquaBackend.Models.Reports>> Html { get; private set; }
    }
}
#pragma warning restore 1591
