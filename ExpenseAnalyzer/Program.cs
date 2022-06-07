using Blazored.Modal;
using ExpenseAnalyzer;
using ExpenseAnalyzer.Expense;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();
builder.Services.AddSingleton<List<Transaction>>();
var categories = new Dictionary<string, Category>(System.StringComparer.InvariantCultureIgnoreCase);
categories.Add("UNDEFINED", new Category() { Name="UNDEFINED", Selected=true});
builder.Services.AddSingleton<Dictionary<string, Category>>(categories);
builder.Services.AddTransient<Transaction>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredModal();

await builder.Build().RunAsync();

