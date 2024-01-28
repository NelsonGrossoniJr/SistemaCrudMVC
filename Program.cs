using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using New_ATCSharp.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<New_ATCSharpContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("New_ATCSharpContext") ?? throw new InvalidOperationException("Connection string 'New_ATCSharpContext' not found.")));

// Add services to the container.
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

app.MapControllerRoute(
    name: "Carros",
    pattern: "/Carros",
    defaults: new { controller = "CarroViewModels", action = "Index" });

app.MapControllerRoute(
    name: "CriarCarros",
    pattern: "/Carros/Criar",
    defaults: new { controller = "CarroViewModels", action = "Create" });

app.MapControllerRoute(
    name: "EditarCarros",
    pattern: "/Carros/Editar/{id}",
    defaults: new { controller = "CarroViewModels", action = "Edit" });

app.MapControllerRoute(
    name: "DeletarCarros",
    pattern: "/Carros/Deletar/{id}",
    defaults: new { controller = "CarroViewModels", action = "Delete" });

app.MapControllerRoute(
    name: "DetalhesCarros",
    pattern: "/Carros/Detalhes/{id}",
    defaults: new { controller = "CarroViewModels", action = "Details" });

app.Run();
