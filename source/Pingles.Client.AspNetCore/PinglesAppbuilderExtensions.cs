using Microsoft.AspNetCore.Builder;

namespace Pingles.Client.AspNetCore
{
    public static class PinglesAppbuilderExtensions
    {
        public static IApplicationBuilder UsePingles(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
