using System;
using System.Net.Http;
using System.Threading.Tasks;
using CameronAnderson.Secure;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Radzen;

namespace CameronAnderson;

public class Program
{
	public static async Task Main(string[] args)
	{
		var builder = WebAssemblyHostBuilder.CreateDefault(args);
		builder.RootComponents.Add<App>("#app");

		builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
		builder.Services.AddScoped<IAuthorize, OtpAuthorize>();

		builder.Services.AddScoped<DialogService>();
		builder.Services.AddScoped<NotificationService>();
		builder.Services.AddScoped<TooltipService>();
		builder.Services.AddScoped<ContextMenuService>();


		await builder.Build().RunAsync();
	}
}
