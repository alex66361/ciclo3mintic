using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListRutasModel : PageModel
    {
       
        private readonly RepositorioRutas repositorioRutas;
        public IEnumerable<Rutas> Rutas {get;set;}
        [Required]
        public Rutas Ruta {get; set;} 
 
    public ListRutasModel(RepositorioRutas repositorioRutas)
    {
        this.repositorioRutas=repositorioRutas;
     }
 
    public void OnGet()
    {
        Rutas=repositorioRutas.GetAll();
    }
    public IActionResult OnPost()
    {
        if(Ruta.id>0)
        {
        repositorioRutas.Delete(Ruta.id);
        }
        return RedirectToPage("./List");
    }
    }
}
