using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PetMatch.Models
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        // Tabela para usuários cadastrados (personalizados)
        public DbSet<Usuario> Usuarios { get; set; }

        // Tabela para pets cadastrados
        public DbSet<Pet> Pets { get; set; }

        // Configuração do modelo com Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Chame o base para configurar o Identity

            // Configuração da tabela de Usuários personalizados
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuarios"); // Nome da tabela
                entity.HasKey(u => u.Id); // Define a chave primária

                entity.Property(u => u.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(u => u.Senha)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            // Configuração da tabela de Pets
            modelBuilder.Entity<Pet>(entity =>
            {
                entity.ToTable("Pets"); // Nome da tabela
                entity.HasKey(p => p.Id); // Define a chave primária

                entity.Property(p => p.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(p => p.Idade)
                    .IsRequired();

                entity.Property(p => p.Raca)
                    .HasMaxLength(50);

                entity.Property(p => p.TipoPet)
                    .IsRequired();

                entity.Property(p => p.Sexo)
                    .IsRequired();

                entity.Property(p => p.Porte)
                    .IsRequired();
            });
        }
    }
}
