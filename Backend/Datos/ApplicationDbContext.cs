using Microsoft.EntityFrameworkCore;
using Modelos.Usuario;
using System.Reflection;

namespace Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=PCET;Initial Catalog=SoccerAppBd;Integrated Security=true; TrustServerCertificate=True;");
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
