using Microsoft.EntityFrameworkCore;
using R.AccesoDatos;
using R.LogicaNegocio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RDbContext>(opitons =>
{
    var conexionString = builder.Configuration.GetConnectionString("Conn");
    opitons.UseMySql(conexionString, ServerVersion.AutoDetect(conexionString));
});

builder.Services.AddScoped<PersonaRDAL>();
builder.Services.AddScoped<PersonaRBL>();

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

app.Run();
