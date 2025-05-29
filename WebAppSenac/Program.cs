using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebAppSenac.Models;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Configurar a conexaõ com o banco de dados 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//Registrar o contexto do banco de dados
IServiceCollection serviceCollection =builder.Services.AddDbContext<ContextoEscola>(options =>options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
