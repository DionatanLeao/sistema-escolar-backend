using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SistemaEscolar.Models
{
    public class ControleContext : DbContext
    {
        public ControleContext() : base("DefaultConnection")
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        
        public System.Data.Entity.DbSet<SistemaEscolar.Models.Usuario> Usuarios { get; set; }

        public System.Data.Entity.DbSet<SistemaEscolar.Models.Grupos> Grupos { get; set; }

        public System.Data.Entity.DbSet<SistemaEscolar.Models.GruposDetalhes> GruposDetalhes { get; set; }

        public System.Data.Entity.DbSet<SistemaEscolar.Models.Notas> Notas { get; set; }
    }
}