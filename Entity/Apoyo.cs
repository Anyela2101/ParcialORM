using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Apoyo
    {
        public Persona persona {get;set;}
        public string Departamento {get;set;}
        public string Ciudad {get;set;}
        public double ValorApoyo {get;set;}
        public string Modalidad {get;set;}
        public DateTime Fecha {get;set;}
    }
}