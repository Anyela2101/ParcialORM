using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primerparcial.Models
{
        public class ApoyoInputModel{
            public Persona Persona{get;set;}
            public string Departamento {get;set;}
            public string Ciudad {get;set;}
            public double ValorApoyo {get;set;}
            public string Modalidad {get;set;}
            public DateTime Fecha {get;set;}
        }

        public class ApoyoViewModel : ApoyoInputModel{
            public ApoyoViewModel(){

            }
            public ApoyoViewModel(Apoyo apoyo){
                Persona = apoyo.Persona;
                Departamento = apoyo.Departamento;
                Ciudad = apoyo.Ciudad;
                ValorApoyo = apoyo.ValorApoyo;
                Modalidad = apoyo.Modalidad;
                Fecha =  apoyo.Fecha;
            }
        }
}