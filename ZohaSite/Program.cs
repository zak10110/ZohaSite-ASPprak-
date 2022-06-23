using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ZohaSite.Data;
using System.Security.Cryptography;
using ZohaSite;

var builder = WebApplication.CreateBuilder(args);
EtoBasa.CreateDataBase();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//EtoBasa.AddProduct("50$", "https://i.pinimg.com/236x/24/03/c1/2403c16257bfc1ee026a61409f9722e1.jpg", "Mashrum","pcihodel");
//EtoBasa.AddProduct("100$", "https://www.p4headshop.com.ua/image/cache/catalog/1tovarbong/Diffuse%20Coil/1-700x700.jpg", "Bong","staff");
//EtoBasa.AddProduct("20$", "https://play-lh.googleusercontent.com/jkU2nz-D5vlKyS2Q_GPSW8bFMZ_6Q4HFkaOQnnQST2oH028tqmOBW8CyuszqU1zF5vhq", "Weed","lightdrugs");
//EtoBasa.InicializeLists();

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
