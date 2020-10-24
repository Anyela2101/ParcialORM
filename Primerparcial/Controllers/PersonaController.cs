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
        public class PersonaController : ControllerBase
        {
            private readonly PersonaService _personaService;
            public PersonaController(AyudaEconomicaContext context)
            {
                _personaService = new PersonaService(context);
            }
             // GET: api/Persona
            [HttpGet]
            public IEnumerable<PersonaViewModel> Gets()
            {
                var personas = _personaService.ConsultarTodos().Select(p=> new PersonaViewModel(p));
                return personas;
            }

          // GET: api/Persona/5
            [HttpGet("{identificacion}")]
            public ActionResult<PersonaViewModel> Get(string identificacion)
            {
                var persona = _personaService.BuscarxIdentificacion(identificacion);
                if (persona == null) return NotFound();
                var personaViewModel = new PersonaViewModel(persona);
                return personaViewModel;
            }

            // POST: api/Persona
        [HttpPost]
        public ActionResult<PersonaViewModel> Post(PersonaInputModel personaInput)
        {
            Persona persona = MapearPersona(personaInput);
            var response = _personaService.Guardar(persona);
            if (response.Error) 
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Persona);
        }


        private Persona MapearPersona(PersonaInputModel personaInput)
        {
            var persona = new Persona
            {
                Identificacion = personaInput.Identificacion,
                Nombres = personaInput.Nombres,
                Apellidos = personaInput.Apellidos,
                Edad = personaInput.Edad,
                Sexo = personaInput.Sexo
            };
            return persona;
        }
    }
}
