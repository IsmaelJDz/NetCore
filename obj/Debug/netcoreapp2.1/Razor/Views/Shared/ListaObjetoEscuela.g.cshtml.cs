#pragma checksum "/Users/ismaeljdz7/Documents/aspNet/Views/Shared/ListaObjetoEscuela.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ee49160a8f2229d06efcd7fff4324629aa6e20d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ListaObjetoEscuela), @"mvc.1.0.view", @"/Views/Shared/ListaObjetoEscuela.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ListaObjetoEscuela.cshtml", typeof(AspNetCore.Views_Shared_ListaObjetoEscuela))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ee49160a8f2229d06efcd7fff4324629aa6e20d", @"/Views/Shared/ListaObjetoEscuela.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620e5fdb0e933658f91e68370e0d9ac1f25dae0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ListaObjetoEscuela : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(244, 187, true);
            WriteLiteral("\n\n<table class=\"table table-dark table-hover\">\n    <thead>\n        <tr>\n            <th scope=\"col\">Nombre</th>\n            <th scope=\"col\">Id</th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 16 "/Users/ismaeljdz7/Documents/aspNet/Views/Shared/ListaObjetoEscuela.cshtml"
         foreach (var obj in Model)
        {

#line default
#line hidden
            BeginContext(477, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(515, 10, false);
#line 19 "/Users/ismaeljdz7/Documents/aspNet/Views/Shared/ListaObjetoEscuela.cshtml"
               Write(obj.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(525, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(552, 6, false);
#line 20 "/Users/ismaeljdz7/Documents/aspNet/Views/Shared/ListaObjetoEscuela.cshtml"
               Write(obj.Id);

#line default
#line hidden
            EndContext();
            BeginContext(558, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 22 "/Users/ismaeljdz7/Documents/aspNet/Views/Shared/ListaObjetoEscuela.cshtml"
        }

#line default
#line hidden
            BeginContext(592, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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