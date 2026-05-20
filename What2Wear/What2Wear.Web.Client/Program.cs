using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using What2Wear.Shared.Services;
using What2Wear.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the What2Wear.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
