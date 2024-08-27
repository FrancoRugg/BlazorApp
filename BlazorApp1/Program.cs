using BlazorServices.Models;
using BlazorServices.Repositories;
using BlazorServices.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton<UserService>(); //Se agrega el servicio creado
builder.Services.AddSingleton<TodoService>(); //Se agrega el servicio creado
builder.Services.AddSingleton<PhotoService>(); //Se agrega el servicio creado
builder.Services.AddSingleton<PostService>(); //Se agrega el servicio creado
builder.Services.AddSingleton<CommentService>(); //Se agrega el servicio creado
builder.Services.AddSingleton<PostsService>(); //Se agrega el servicio creado
builder.Services.AddHttpClient(); //Se agrega Http client para poder llamar a la api

//Agrego concexiòn a entity framework
builder.Services.AddScoped<UserEntityRepository, UserEntityService>();

//Cadena de configuraciòn a la bdd

builder.Services.AddDbContext<AppDbContext>(opciones =>
{
    opciones.UseSqlite(builder.Configuration.GetConnectionString("defaultConnection"));
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
