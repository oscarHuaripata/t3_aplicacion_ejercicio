#pragma checksum "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Rutina\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe5b7116b6f0fd29c7dd87d535b08d2c61bceba3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rutina_Index), @"mvc.1.0.view", @"/Views/Rutina/Index.cshtml")]
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
#line 1 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\_ViewImports.cshtml"
using FinancistoCloneWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\_ViewImports.cshtml"
using FinancistoCloneWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe5b7116b6f0fd29c7dd87d535b08d2c61bceba3", @"/Views/Rutina/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2165647d4e8d2c706050012f04156e5484cda6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Rutina_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Rutina\Index.cshtml"
  
    List<Rutina> accounts = ((List<Rutina>)Model); // forma B

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Rutinas</h1>\r\n\r\n<a href=\"/rutina/create\">Crear Rutina</a>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Tipo</th>\r\n            <th>Nombre</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Rutina\Index.cshtml"
         foreach (var item in accounts)
        {            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Rutina\Index.cshtml"
               Write(item.TipoRutina.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Rutina\Index.cshtml"
               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 525, "\"", 572, 2);
            WriteAttributeValue("", 532, "/ejercicio/Index?rutinaId=", 532, 26, true);
#nullable restore
#line 25 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Rutina\Index.cshtml"
WriteAttributeValue("", 558, item.RutinaId, 558, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ejercicios</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Rutina\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
