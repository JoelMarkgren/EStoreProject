using EStoreBlazorWASM;
using EStoreBlazorWASM.Services;
using EStoreBlazorWASM.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<ICellphoneService, CellphoneService>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7048/") });


await builder.Build().RunAsync();
