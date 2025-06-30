using MAUI2.Shared.Services;
using MAUI2.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace MAUI2.Web.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Add device-specific services used by the MAUI2.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            await builder.Build().RunAsync();
        }
    }
}
