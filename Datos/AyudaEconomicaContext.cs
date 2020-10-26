using Entity;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class AyudaEconomicaContext: DbContext
    {
        public AyudaEconomicaContext(DbContextOptions options) : base(options){
        } 
        public DbSet <Persona> Personas {get;set;}
        public DbSet <Apoyo> Apoyos {get;set;}
    }
}