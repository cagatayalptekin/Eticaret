using BlazorEticaret.Client;
using BlazorEticaret.Client.Service.Contracts;
using BlazorEticaret.Client.Service.Implements;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ICourseOrderInfoService, CourseOrderInfoService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
