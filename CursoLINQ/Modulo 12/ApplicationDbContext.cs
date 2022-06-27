using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_12
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 1. Empezamos configurando la bbdd SQLite
            //optionsBuilder.UseSqlite($"Data source=cursoLINQ.db");

            // 2. ConextionString del SQLServer
            // Server=. ese punto significa que el nombre de mi máquina y de mi instancia sqlserver coinciden
            optionsBuilder.UseSqlServer("Server=.;Database=CursoLINQ;Trusted_Connection=True");
        }

        // 2. Creamos una tabla a partir de la entidad (clase) Persona
        public DbSet<Persona> Personas { get; set; }
    }
}
