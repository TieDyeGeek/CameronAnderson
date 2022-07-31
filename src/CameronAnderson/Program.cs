using System;
using System.Net.Http;
using System.Threading.Tasks;
using CameronAnderson.Secure;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CameronAnderson;

public class Program
{
	public static async Task Main(string[] args)
	{
		var builder = WebAssemblyHostBuilder.CreateDefault(args);
		builder.RootComponents.Add<App>("#app");

		builder.Configuration.AddUserSecrets<Program>();

		builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
		builder.Services.AddScoped<IAuthorize, OtpAuthorize>();

		await builder.Build().RunAsync();
	}
}
