using System;
using System.ComponentModel.DataAnnotations;/// para usar lalibreria de data annotations se usa para validar desde backend

namespace ProyectoCiclo3.App.Dominio{
    public class Estaciones{

        public int id {get;set;} 
        [Required]//===> Esto es validar desde backend
        public string nombre {get;set;}            
        public string direccion {get;set;}            
        public string coord_x {get;set;}            
        public string coord_y {get;set;}            
        public string tipo {get;set;}            
           
    }
}