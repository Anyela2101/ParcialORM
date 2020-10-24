﻿using System;
using Entity;
using Datos;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class PersonaService
    {
        private readonly AyudaEconomicaContext _context;
        public PersonaService (AyudaEconomicaContext context){
            _context = context;
        }
        public GuardarPersonaResponse Guardar (Persona persona){
            try{
                var personaBuscada = _context.Personas.Find(persona.Identificacion);
                if(personaBuscada!=null){
                    return new GuardarPersonaResponse("Error la persona ya se encuentra registrada");
                }
                _context.Personas.Add(persona);
                _context.SaveChanges();
                return new GuardarPersonaResponse(persona);
            }
            catch(Exception e){
                return new GuardarPersonaResponse($"Error de la aplicacion: {e.Message}");
            }
        }

        public List<Persona> ConsultarTodos(){
            List<Persona> personas = _context.Personas.ToList();
            return personas;
        }
         public Persona BuscarxIdentificacion(string identificacion){
            return _context.Personas.Find(identificacion);
        }

         public class GuardarPersonaResponse 
    {
        public GuardarPersonaResponse(Persona persona)
        {
            Error = false;
            Persona = persona;
        }
        public GuardarPersonaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Persona Persona { get; set; }
    }
       
    }
}
