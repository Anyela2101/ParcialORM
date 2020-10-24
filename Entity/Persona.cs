using System;
using System.ComponentModel.DataAnnotations;
namespace Entity
{
    public class Persona
    {
        [Key]
        public string Identificacion {get;set;}
        public string Nombres {get;set;} 
        public string Apellidos {get;set;} 
        public string Sexo {get;set;}
        public int Edad {get;set;}
    }
}
