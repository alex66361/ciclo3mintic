#pragma checksum "C:\Users\aleja\OneDrive\Escritorio\ciclo3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontenddotnet\Pages\Estaciones\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5942d132e20b5102857c33cf246cc3c518ad174c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontenddotnet.Pages.Estaciones.Pages_Estaciones_Details), @"mvc.1.0.razor-page", @"/Pages/Estaciones/Details.cshtml")]
namespace ProyectoCiclo3.App.Frontenddotnet.Pages.Estaciones
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5942d132e20b5102857c33cf246cc3c518ad174c", @"/Pages/Estaciones/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd33e60d95d7a28a5de43cc751417a1a7bc90e4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Estaciones_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\aleja\OneDrive\Escritorio\ciclo3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontenddotnet\Pages\Estaciones\Details.cshtml"
  
    var estacion = Model.Estacion;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<ul class=\"list-group list-group-flush\">\r\n  <li class=\"list-group-item\"> <b>id: </b> ");
#nullable restore
#line 8 "C:\Users\aleja\OneDrive\Escritorio\ciclo3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontenddotnet\Pages\Estaciones\Details.cshtml"
                                      Write(estacion.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>nombre: </b> ");
#nullable restore
#line 9 "C:\Users\aleja\OneDrive\Escritorio\ciclo3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontenddotnet\Pages\Estaciones\Details.cshtml"
                                          Write(estacion.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>direccion: </b> ");
#nullable restore
#line 10 "C:\Users\aleja\OneDrive\Escritorio\ciclo3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontenddotnet\Pages\Estaciones\Details.cshtml"
                                             Write(estacion.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>coord_x: </b> ");
#nullable restore
#line 11 "C:\Users\aleja\OneDrive\Escritorio\ciclo3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontenddotnet\Pages\Estaciones\Details.cshtml"
                                          Write(estacion.coord_x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>coord_y: </b> ");
#nullable restore
#line 12 "C:\Users\aleja\OneDrive\Escritorio\ciclo3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontenddotnet\Pages\Estaciones\Details.cshtml"
                                          Write(estacion.coord_y);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>tipo: </b> ");
#nullable restore
#line 13 "C:\Users\aleja\OneDrive\Escritorio\ciclo3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontenddotnet\Pages\Estaciones\Details.cshtml"
                                       Write(estacion.tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\t\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.DetailsEstacionesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsEstacionesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsEstacionesModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.DetailsEstacionesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591