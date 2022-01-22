using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Gestion_De_cinema.Data;
using Gestion_De_cinema.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Gestion_De_cinemaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Gestion_De_cinemaContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}


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
