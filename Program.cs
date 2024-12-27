using gestion_commandes.Datas;
using gestion_commandes.Fixtures;
using gestion_commandes.Services;
using gestion_commandes.Services.Impl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("SqlServerConnexion")!;
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));



builder.Services.AddScoped<IProduitService, ProduitService>();
builder.Services.AddScoped<IPanierService, PanierService>();
builder.Services.AddScoped<IPanierProduitService, PanierProduitService>();
builder.Services.AddScoped<IUtilisateurService, UtilisateurService>();
builder.Services.AddScoped<ProduitFixtures>();
builder.Services.AddScoped<ClientFixtures>();

builder.Services.AddControllersWithViews();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    var produitSeeder = scope.ServiceProvider.GetRequiredService<ProduitFixtures>();
    var clientSeeder = scope.ServiceProvider.GetRequiredService<ClientFixtures>();

    produitSeeder.Load();
    clientSeeder.Load();
}

app.Run();
