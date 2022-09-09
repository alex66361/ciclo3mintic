using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        //Esta lista debe tener todas las propiedades del archivo de estaciones.cs
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            //nueva estrictira lista llamada estaciones
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="Centro",direccion= "Cra 5 mz12",coord_x= "14.815",coord_y= "14.815",tipo= "Principal"},
                new Estaciones{id=2,nombre="Salado",direccion= "calle 90",coord_x= "15882",coord_y= "198.2",tipo= "secundaria"},
                new Estaciones{id=3,nombre="Las ferias",direccion="Cra 54",coord_x= "1518931",coord_y= "17.815",tipo= "Principal"}
 
            };
        }

        public IEnumerable<Estaciones> GetAll()         //DEVUELVE TODAS LAS Estaciones
        {
            return estaciones;
        }
 
        public Estaciones GetWithId(int id){            //Devuelve una Estacion en particualas
            return estaciones.SingleOrDefault(b => b.id == id);
        }
    }
}
