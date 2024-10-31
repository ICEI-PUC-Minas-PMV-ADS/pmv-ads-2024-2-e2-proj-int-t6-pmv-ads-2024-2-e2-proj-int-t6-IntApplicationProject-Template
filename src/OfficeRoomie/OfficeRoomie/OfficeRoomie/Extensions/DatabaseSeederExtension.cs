using OfficeRoomie.Database.Seeders;
using OfficeRoomie.Database;

namespace OfficeRoomie.Extensions;

static class DatabaseSeederExtension
{
    public static void SeedDatabase(this IHost app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<AppDbContext>();

            var seeder = new AdministradorSeeder(context);

            seeder.Seed();
        }
    }
}
