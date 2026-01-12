using CarbonCalculator;
using CarbonCalculator.Home;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<RoutesManager>();
builder.Services.AddScoped<TransportsManager>();
builder.Services.AddScoped<Calculator>();

await builder.Build().RunAsync();
