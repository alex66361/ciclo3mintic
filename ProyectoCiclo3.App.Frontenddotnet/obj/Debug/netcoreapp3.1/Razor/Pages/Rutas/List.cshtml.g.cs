#pragma checksum "C:\Users\aleja\OneDrive\Escritorio\ciclo3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontenddotnet\Pages\Rutas\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b30fe27fb567568a736c29bac69c9a3e78680757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontenddotnet.Pages.Rutas.Pages_Rutas_List), @"mvc.1.0.razor-page", @"/Pages/Rutas/List.cshtml")]
namespace ProyectoCiclo3.App.Frontenddotnet.Pages.Rutas
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
#line 1 "C:\Users\aleja\OneDrive\Escritorio\ciclo3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontenddotnet\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontenddotnet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b30fe27fb567568a736c29bac69c9a3e78680757", @"/Pages/Rutas/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd33e60d95d7a28a5de43cc751417a1a7bc90e4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rutas_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" 
<table class=""table table-hover"">
  <thead>
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">id</th>
      <th scope=""col"">Marca</th>
      <th scope=""col"">Modelo</th>
      <th scope=""col"">Kilometraje</th>
      <th scope=""col"">Numero de asientos</th>
      <th scope=""col"">Placa</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope=""row"">1</th>
      <td>adsf1561</td>
      <td>BMW</td>
      <td>2020</td>
      <td>70.145</td>
      <td>24</td>
      <td>23248SD4</td>
    </tr>
    <tr>
      <th scope=""row"">2</th>
      <td>ZXCZ1561</td>
      <td>BMW</td>
      <td>2010</td>
      <td>70</td>
      <td>12</td>
      <td>23AS4</td>
    </tr>
    <tr>
      <th scope=""row"">3</th>
      <td>adSA617</td>
      <td>BMW</td>
      <td>2008</td>
      <td>7145</td>
      <td>4</td>
      <td>232ZX4</td>
    </tr>
  </tbody>
</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Rutas_List> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Rutas_List> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Rutas_List>)PageContext?.ViewData;
        public Pages_Rutas_List Model => ViewData.Model;
    }
}
#pragma warning restore 1591