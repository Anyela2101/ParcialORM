using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Apoyo
    {
        public Apoyo(){
            Persona = new Persona();
        }
        [Key]
        [Column(TypeName = "int")]
        public int CodigoAyuda {get;set;}

        [Column(TypeName = "varchar(11)")]
        public string Departamento {get;set;}

        [Column(TypeName = "varchar(20)")]
        public string Ciudad {get;set;}

        [Column(TypeName = "float")]
        public double ValorApoyo {get;set;}

        [Column(TypeName = "varchar(20)")]
        public string Modalidad {get;set;}

        [Column(TypeName = "date")]
        public DateTime Fecha {get;set;}

        public Persona Persona {get;set;}
    }
}