using Microsoft.EntityFrameworkCore;
using OfficeRoomie.Models;

namespace OfficeRoomie.Database;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var databaseProvider = _configuration.GetValue<string>("DatabaseProvider");

            if (databaseProvider == "Default")
            {
                optionsBuilder.UseMySQL(_configuration.GetConnectionString("DefaultConnection")!);
            }

            if (databaseProvider == "MySql")
            {
                optionsBuilder.UseMySQL(_configuration.GetConnectionString("MySqlConnection")!);
            }
            else if (databaseProvider == "SqlServer")
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlServerConnection")!);
            }
            else
            {
                throw new Exception("Provedor de banco de dados não suportado.");
            }
        }
    }

    public DbSet<Cliente> Clientes { get; set; }

    public DbSet<Administrador> Administradores { get; set; }
}
