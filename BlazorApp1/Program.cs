using BlazorApp1.Client.Pages;
using BlazorApp1.Components;
using BlazorApp1.Models;
using Blazored.LocalStorage;
using Microsoft.Extensions.FileProviders;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//addmudblazor stuff
builder.Services.AddMudServices();

//adding http routing for webapi
builder.Services.AddHttpClient();



var app = builder.Build();

app.UseStaticFiles();


//this allows us to use outside folders to store images, this time i am storing images on a different project
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider("D:/Desktop/PHPas/realstuff/public/images/transports"),
    RequestPath = new PathString("/transports"),
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Counter).Assembly);

app.Run();
