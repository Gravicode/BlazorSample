using Blazor.Extensions;
using Blazor.Extensions.Logging;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BlazorSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IServiceWeather, ServiceWeather>();
            //services.AddSingleton<IServiceWeather>(new ServiceWeather(new System.Net.Http.HttpClient()));
            services.AddNotifications();
            services.AddLogging(builder => builder
           .AddBrowserConsole() // Add Blazor.Extensions.Logging.BrowserConsoleLogger
           .SetMinimumLevel(LogLevel.Information)
            );
           
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
