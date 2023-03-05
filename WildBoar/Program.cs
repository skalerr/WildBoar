using DAL;
using Autofac;
using Autofac.Core;
using System.ComponentModel;
using Autofac;
using Autofac.Core.Registration;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using WildBoar.Controllers;

var builder = WebApplication.CreateBuilder(args);
var containerBuilder = new ContainerBuilder();

// Add services to the container.
builder.Services.AddControllersWithViews();

containerBuilder.RegisterModule<DALModule>();

var container = containerBuilder.Build();
foreach (var registration in container.ComponentRegistry.Registrations)
{
    Console.WriteLine(registration.ToString());
}


builder.Services.AddSingleton(container);
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    var list = serviceProvider.GetServices<ComponentRegistration>();
    foreach (var registration in list)
    {
        Console.WriteLine(registration.ToString());
    }
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();