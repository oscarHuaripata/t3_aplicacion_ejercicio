#pragma checksum "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3945e1637b3241d84c55cbd0c807bff23d003c1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Index), @"mvc.1.0.view", @"/Views/Transaction/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3945e1637b3241d84c55cbd0c807bff23d003c1a", @"/Views/Transaction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2165647d4e8d2c706050012f04156e5484cda6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
   
    var transactions = (List<Transaction>)Model;
    var account = (Account)ViewBag.Account;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h2>Transacciones - ");
#nullable restore
#line 6 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
                   Write(account.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h4>Monto: ");
#nullable restore
#line 7 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
          Write(string.Format("{0:N2}", account.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" S./</h4>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div class=\"clearfix\">\r\n                <a class=\"btn btn-link float-right\" href=\"/account\">Ir a cuentas</a>\r\n                <a class=\"btn btn-primary float-right\"");
            BeginWriteAttribute("href", " href=\"", 443, "\"", 491, 2);
            WriteAttributeValue("", 450, "/transaction/create?accountId=", 450, 30, true);
#nullable restore
#line 13 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
WriteAttributeValue("", 480, account.Id, 480, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Crear transacción</a>
            </div>
            <div class=""clearfix"">
                <br />
                <table class=""table mt-2"">
                    <tr>
                        <th>Tipo</th>
                        <th>Resumen</th>
                        <th>Fecha</th>
                        <th>Monto</th>
                        <th></th>  
                    </tr>
");
#nullable restore
#line 25 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
                     foreach (var item in transactions)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
                           Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
                           Write(item.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
                           Write(string.Format("{0:dd MMM yyyy hh:mm tt}", item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td");
            BeginWriteAttribute("class", " class=\"", 1225, "\"", 1289, 1);
#nullable restore
#line 31 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
WriteAttributeValue("", 1233, item.Type == "GASTO" ? "text-danger" : "text-success", 1233, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 32 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
                           Write(string.Format("{0:N2}", item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" S./\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1471, "\"", 1507, 2);
            WriteAttributeValue("", 1478, "/transaction/edit?id=", 1478, 21, true);
#nullable restore
#line 35 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
WriteAttributeValue("", 1499, item.Id, 1499, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                            </td>  \r\n                        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\OSCAR\Pictures\t3_diars_aplic.ejercicios\FinancistoCloneWeb\FinancistoCloneWeb\Views\Transaction\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n            </div>\r\n    </div>");
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