#pragma checksum "C:\Users\toshiba\Documents\Net\Ejercicio1\Ejercicio1\Pages\Materiales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c6600b7293cb138add8740234fc63e78a84c67f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ejercicio1.Pages.Pages_Materiales), @"mvc.1.0.razor-page", @"/Pages/Materiales.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Materiales.cshtml", typeof(Ejercicio1.Pages.Pages_Materiales), null)]
namespace Ejercicio1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\toshiba\Documents\Net\Ejercicio1\Ejercicio1\Pages\_ViewImports.cshtml"
using Ejercicio1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c6600b7293cb138add8740234fc63e78a84c67f", @"/Pages/Materiales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e12d0a4c248ae46b80215e3e72eeac5b3602f108", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Materiales : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\toshiba\Documents\Net\Ejercicio1\Ejercicio1\Pages\Materiales.cshtml"
  
    ViewData["Title"] = "Materiales";

#line default
#line hidden
            BeginContext(94, 178, true);
            WriteLiteral("\r\n<h2>Materiales</h2>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>\r\n            ID\r\n        </th>\r\n        <th>\r\n            Nombre\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 18 "C:\Users\toshiba\Documents\Net\Ejercicio1\Ejercicio1\Pages\Materiales.cshtml"
     foreach (var item in Model.materiales)
    {

#line default
#line hidden
            BeginContext(324, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(373, 15, false);
#line 22 "C:\Users\toshiba\Documents\Net\Ejercicio1\Ejercicio1\Pages\Materiales.cshtml"
           Write(item.MaterialId);

#line default
#line hidden
            EndContext();
            BeginContext(388, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(444, 11, false);
#line 25 "C:\Users\toshiba\Documents\Net\Ejercicio1\Ejercicio1\Pages\Materiales.cshtml"
           Write(item.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(455, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\toshiba\Documents\Net\Ejercicio1\Ejercicio1\Pages\Materiales.cshtml"
    }

#line default
#line hidden
            BeginContext(498, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ejercicio1.Pages.MaterialesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ejercicio1.Pages.MaterialesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ejercicio1.Pages.MaterialesModel>)PageContext?.ViewData;
        public Ejercicio1.Pages.MaterialesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
