using QSQLBDProjeto.Dominio;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace QSQLBDProjeto.RepositorioEF
{
    public class BD : DbContext
    {
        public BD() : base("conexaoBD")
        {
        }

        public DbSet<Usuarios> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Usuarios>().Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Usuarios>().Property(x => x.Cargo).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Usuarios>().Property(x => x.Data).IsRequired().HasColumnType("date");
        }
    }
}
