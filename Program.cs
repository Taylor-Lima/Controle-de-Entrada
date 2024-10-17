using Controle_Entrada.Data;
using Controle_Entrada.Data.Repositorio;
using Controle_Entrada.Data.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionstring = builder.Configuration.GetConnectionString("StringConexao");
builder.Services.AddDbContext<BancoContexto>(options => options.UseSqlServer(connectionstring));

builder.Services.AddScoped<IVisitanteRepositorio, VisitanteRepositorio>();
builder.Services.AddScoped<IMoradorRepositorio, MoradorRepositorio>();
builder.Services.AddScoped<IRelatorioRepositorio, RelatorioRepositorio>();
builder.Services.AddScoped<ILoginRepositorio, LoginRepositorio>();
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
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
