#pragma checksum "C:\Users\lmachado\source\repos\AquaBackend\AquaBackend\Views\ApxReports\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e15a6e92c9d9b7459c87ded661cebc95ab293001"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApxReports_Error), @"mvc.1.0.view", @"/Views/ApxReports/Error.cshtml")]
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
#line 1 "C:\Users\lmachado\source\repos\AquaBackend\AquaBackend\Views\_ViewImports.cshtml"
using AquaBackend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lmachado\source\repos\AquaBackend\AquaBackend\Views\_ViewImports.cshtml"
using AquaBackend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15a6e92c9d9b7459c87ded661cebc95ab293001", @"/Views/ApxReports/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2b7e48450a41575ee98771a8f3f45bee3258895", @"/Views/_ViewImports.cshtml")]
    public class Views_ApxReports_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\lmachado\source\repos\AquaBackend\AquaBackend\Views\ApxReports\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\lmachado\source\repos\AquaBackend\AquaBackend\Views\ApxReports\Error.cshtml"
 if (ViewBag.ErrorDescription != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 9 "C:\Users\lmachado\source\repos\AquaBackend\AquaBackend\Views\ApxReports\Error.cshtml"
   Write(ViewBag.ErrorDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>    \r\n");
#nullable restore
#line 11 "C:\Users\lmachado\source\repos\AquaBackend\AquaBackend\Views\ApxReports\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
