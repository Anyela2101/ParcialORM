using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primerparcial.Models
{
        public class PersonaInputModel{
            public string Identificacion {get;set;}
            public string Nombres {get;set;}
            public string Apellidos {get;set;}
            public string Sexo {get;set;}
            public int Edad {get;set;}
        }

        public class PersonaViewModel : PersonaInputModel{
            public PersonaViewModel(){

            }
            public PersonaViewModel(Persona persona){
                Identificacion = persona.Identificacion;
                Nombres = persona.Nombres;
                Apellidos = persona.Apellidos;
                Sexo = persona.Sexo;
                Edad = persona.Edad;
            }
        }
}