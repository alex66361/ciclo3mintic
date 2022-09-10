using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        //Esta lista debe tener todas las propiedades del archivo de rutas.cs
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            //nueva estrictira lista llamada rutas
            rutas= new List<Rutas>()
            {/*
                new Rutas{id=1,origen="Centro",destino= "Cra 5 mz12",tiempo_estimado= 14.815},
                new Rutas{id=2,origen="Salado",destino= "calle 90",tiempo_estimado= 15882},
                new Rutas{id=3,origen="Las ferias",destino="Cra 54",tiempo_estimado= 1518931}
 */
            };
        }

        public IEnumerable<Rutas> GetAll()         //DEVUELVE TODAS LAS Rutas
        {
            return rutas;
        }
 
        public Rutas GetWithId(int id){            //Devuelve una Estacion en particualas
            return rutas.SingleOrDefault(b => b.id == id);
        }
    }
}
