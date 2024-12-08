using DIGESETTApp.Models;
using Microsoft.EntityFrameworkCore;


namespace DIGESETTApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Multa> Multas { get; set; }
        public DbSet<ConceptoMulta> ConceptosMultas { get; set; }
        public DbSet<Agente> Agentes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
