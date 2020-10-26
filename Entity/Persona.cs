using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Persona
    {
        [Key]
        [Column(TypeName = "varchar(13)")]
        public string Identificacion {get;set;}

        [Column(TypeName = "varchar(20)")]
        public string Nombres {get;set;} 

        [Column(TypeName = "varchar(20)")]
        public string Apellidos {get;set;}

        [Column(TypeName = "varchar(11)")] 
        public string Sexo {get;set;}

        [Column(TypeName = "int")]
        public int Edad {get;set;}
    }
}
