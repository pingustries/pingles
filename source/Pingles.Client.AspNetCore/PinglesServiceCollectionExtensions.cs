using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Pingles.Client.AspNetCore
{
    public static class PinglesServiceCollectionExtensions
    {
        public static IServiceCollection AddPingles(this IServiceCollection services, PinglesClientConfiguration clientConfiguration)
        {
            services.AddSingleton<PinglesClientConfiguration>(clientConfiguration);
            services.AddSingleton<IHostedService, PinglesBackgroundService>();
            return services;
        }
    }
}
