using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PetMatch.Models;


var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços de sessão
builder.Services.AddDistributedMemoryCache(); // Para armazenar dados da sessão em memória
builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".pet.Session";
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Tempo de expiração da sessão
    options.Cookie.HttpOnly = true; // Aumenta a segurança contra ataques XSS
    options.Cookie.IsEssential = true; // Necessário para funcionar sem o consentimento de cookies
});

// Add services to the container.
builder.Services.AddControllersWithViews();

//Configurando para sempre que ocorrer uma mudan�a, mudar sincronizadamente.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();


//Configura��o do framework AspnNetCore Identify
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDBContext>()
    .AddDefaultTokenProviders();



// Configura��o do DbContext
builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Adiciona o middleware de sessão
app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
