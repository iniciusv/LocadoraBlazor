using LocadoraBlazorInterface.Web;
using LocadoraBlazorInterface.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
var baseUrl = "http://localhost:5270";

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseUrl) });

builder.Services.AddScoped<IVeiculoService, VeiculoService>();
builder.Services.AddSingleton<VeiculoStateService>();
builder.Services.AddSingleton<BookingService>();

await builder.Build().RunAsync();
