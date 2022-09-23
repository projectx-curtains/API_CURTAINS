using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;

namespace Curtains.Infrastructure.Correlation
{
    public static class CorrelationExtensions
    {
        public static IServiceCollection AddCorrelationId(
            this IServiceCollection services)
        {
            services.AddTransient<CorrelationMiddleware>();
            return services;
        }

        public static string GetCorrelationId(this HttpContext httpContext)
        {
            StringValues source = new StringValues();
            httpContext?.Request?.Headers?.TryGetValue("correlation-id", out source);
            return source.FirstOrDefault<string>() ?? httpContext?.TraceIdentifier ?? Guid.NewGuid().ToString();
        }

        public static IApplicationBuilder UseCorrelationId(
            this IApplicationBuilder app)
        {
            app.UseMiddleware<CorrelationMiddleware>();
            return app;
        }
    }
}
