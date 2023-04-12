using System;
using System.ComponentModel;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

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

app.UseAuthorization();

app.MapRazorPages();


//app.Run(async (context) =>
//{
//    HttpClient httpClient = new HttpClient();

//    var response = await httpClient.GetAsync("https://swapi.dev/api/planets/1/");

//    // если запрос завершился успешно, получаем объект Person
//    Planet person = await response.Content.ReadFromJsonAsync<Planet>();
//    context.Response.WriteAsync($"Name: {person.name}   Age: {person.gravity}");

//});
app.Run();

