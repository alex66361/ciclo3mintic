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
    public class FormBusesModel : PageModel
    {
        private readonly RepositorioBuses repositorioBuses;
        [BindProperty]          //Cuadno guarde una informacion lo guarde en esta variable
        public Buses Bus {get;set;}

        public FormBusModel(RepositorioBuses repositorioBuses)
       {
            this.repositorioBuses=repositorioBuses;
       }
        public void OnGet()
        { 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            repositorioBuses.Create(Bus);
            return RedirectToPage("./List");
        }

    }
}