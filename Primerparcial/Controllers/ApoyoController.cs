using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Primerparcial.Models;
using Logica;
using Datos;

namespace Primerparcial.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
        public class ApoyoController : ControllerBase
        {
            private readonly ApoyoService _apoyoService;
            public ApoyoController(AyudaEconomicaContext context)
            {
                _apoyoService = new ApoyoService(context);
            }
             // GET: api/Persona
            [HttpGet]
            public IEnumerable<ApoyoViewModel> Gets()
            {
                var apoyos = _apoyoService.ConsultarTodos().Select(a=> new ApoyoViewModel(a));
                return apoyos;
            }


            // POST: api/Persona
        [HttpPost]
        public ActionResult<ApoyoViewModel> Post(ApoyoInputModel apoyoInput)
        {
            Apoyo Apoyo = MapearApoyo(apoyoInput);
            var response = _apoyoService.Guardar(Apoyo);
            if (response.Error) 
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Apoyo);
        }


        private Apoyo MapearApoyo(ApoyoInputModel apoyoInput)
        {
            var apoyo = new Apoyo();
            
                apoyo.Persona.Identificacion = apoyoInput.Persona.Identificacion;
                apoyo.Persona.Nombres = apoyoInput.Persona.Nombres;
                apoyo.Persona.Apellidos = apoyoInput.Persona.Apellidos;
                apoyo.Persona.Edad = apoyoInput.Persona.Edad;
                apoyo.Persona.Sexo = apoyoInput.Persona.Sexo;
                apoyo.Departamento =apoyoInput.Departamento;
                apoyo.Ciudad = apoyoInput.Ciudad;
                apoyo.ValorApoyo =apoyoInput.ValorApoyo;
                apoyo.Modalidad = apoyoInput.Modalidad;
                apoyo.Fecha = apoyoInput.Fecha;
            
            return apoyo;
        }
    }
}
