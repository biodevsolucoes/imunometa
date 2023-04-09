using BFBlog.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BFBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario, Roles, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            foreach (var property in modelBuilder.Model.GetEntityTypes()
                                                     .SelectMany(t => t.GetProperties())
                                                     .Where(p => p.ClrType == typeof(string))
                 )
            {
                property.SetColumnType("varchar(100)");
            }

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(x => x.Name.Equals("Removido")))
            {
                property.SetColumnType("bit");
                property.SetDefaultValueSql("0");
            }

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                                                        .SelectMany(t => t.GetProperties())
                                                        .Where(p => p.ClrType == typeof(DateTime) || p.ClrType == typeof(DateTime?))
                   )
            {
                property.SetColumnType("datetime2");

                if (property.Name == "DataCadastro")
                    property.SetDefaultValueSql("getdate()");
                else if (property.Name == "DataCadastroUTC")
                    property.SetDefaultValueSql("getutcdate()");
            }

            Seed(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        private void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(new Categoria("Segurança"), new Categoria("Desenvolvimento"), new Categoria("DevOps"), new Categoria("OFF"));
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}