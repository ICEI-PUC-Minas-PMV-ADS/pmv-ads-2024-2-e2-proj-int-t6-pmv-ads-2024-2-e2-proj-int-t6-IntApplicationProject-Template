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

        // Tabela para adoções
        public DbSet<Adocao> Adocoes { get; set; }

        // Configuração do modelo com Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Chama o base para configurar o Identity

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

            // Configuração da tabela de Adoção
            modelBuilder.Entity<Adocao>(entity =>
            {
                entity.ToTable("Adocoes"); // Nome da tabela
                entity.HasKey(a => a.Id); // Define a chave primária

                entity.Property(a => a.StatusAdocao)
                    .IsRequired();

                entity.Property(a => a.DataInicio)
                    .IsRequired();

                entity.Property(a => a.DataFinalizacao)
                    .IsRequired(false); // Pode ser nulo, caso a adoção não tenha sido finalizada ainda

                                // Relacionamento com o usuário
                entity.HasOne(a => a.Usuario)  // Cada adoção pertence a um usuário
                    .WithMany(u => u.Adocoes)   // Um usuário pode ter muitas adoções
                    .HasForeignKey(a => a.UsuarioId) // A chave estrangeira que faz referência ao usuário
                    .OnDelete(DeleteBehavior.Cascade); // Se o usuário for excluído, as adoções também são excluídas

            });
        }
    }
}
