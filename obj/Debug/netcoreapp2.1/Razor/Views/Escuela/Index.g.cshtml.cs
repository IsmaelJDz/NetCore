#pragma checksum "/Users/ismaeljdz7/Documents/aspNet/Views/Escuela/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5bf04e761680782ba935b8d266df2271ec24a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
#line 1 "/Users/ismaeljdz7/Documents/aspNet/Views/_ViewImports.cshtml"
using aspNet;

#line default
#line hidden
#line 2 "/Users/ismaeljdz7/Documents/aspNet/Views/_ViewImports.cshtml"
using aspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5bf04e761680782ba935b8d266df2271ec24a2e", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620e5fdb0e933658f91e68370e0d9ac1f25dae0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/ismaeljdz7/Documents/aspNet/Views/Escuela/Index.cshtml"
  
    ViewData["Title"] = "Info Escuela";

#line default
#line hidden
            BeginContext(48, 15, true);
            WriteLiteral("\r\n<h1>Escuela: ");
            EndContext();
            BeginContext(64, 12, false);
#line 5 "/Users/ismaeljdz7/Documents/aspNet/Views/Escuela/Index.cshtml"
        Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(76, 67, true);
            WriteLiteral("</h1>\r\n<h2>Nombre: </h2>\r\n<p><strong>Año fundación: </strong></p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591