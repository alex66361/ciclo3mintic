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
        public Estaciones Create(Estaciones newEstacion)
        {
           if(estaciones.Count > 0){        //Count dice cuantos elementos hay en estaciones 
           newEstacion.id=estaciones.Max(e => e.id) +1; 
            }else{
               newEstacion.id = 1; 
            }
            estaciones.Add(newEstacion);
            return newEstacion;
        }
        
        public Estaciones Update(Estaciones newEstacion){
            var estacion= estaciones.SingleOrDefault(b => b.id == newEstacion.id);
            if(estacion != null){
                estacion.nombre = newEstacion.nombre;
                estacion.direccion = newEstacion.direccion;
                estacion.coord_x = newEstacion.coord_x;
                estacion.coord_y = newEstacion.coord_y;
                estacion.tipo = newEstacion.tipo;
            }
        return estacion;
        }
        public Estaciones Delete(int id)
        {
        var estacion= estaciones.SingleOrDefault(e => e.id == id);
        estaciones.Remove(estacion);
        return estacion;
        }

    }
}
