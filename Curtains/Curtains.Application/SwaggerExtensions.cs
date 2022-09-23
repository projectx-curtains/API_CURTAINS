using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Curtains.Application
{ 
    public static class SwaggerExtensions
    {
        public const string VersionV1 = "v1";

        public static string SwaggerJsonPath(string version = "v1") => "/swagger/" + version + "/swagger.json";

        public static IServiceCollection AddOpenApi(
            this IServiceCollection services,
            string applicationName,
            Action<OpenApiInfo> setupOpenApiInfo = null,
            Action<SwaggerGenOptions> setupSwagerGen = null,
            string version = "v1")
        {
            OpenApiInfo apiInfo = new OpenApiInfo()
            {
                Version = version,
                Title = applicationName
            };
            if (setupOpenApiInfo != null)
                setupOpenApiInfo(apiInfo);
            services.AddSwaggerGen((Action<SwaggerGenOptions>) (opt =>
            {
                opt.DescribeAllParametersInCamelCase();
                opt.SwaggerDoc(version, apiInfo);
                Action<SwaggerGenOptions> action = setupSwagerGen;
                if (action == null)
                    return;
                action(opt);
            }));
            return services;
        }

        public static IApplicationBuilder UseOpenApi(
            this IApplicationBuilder app,
            string applicationName,
            string version = "v1",
            Action<SwaggerUIOptions> setupAction = null)
        {
            app.UseSwagger();
            app.UseSwaggerUI((Action<SwaggerUIOptions>) (opt =>
            {
                opt.SwaggerEndpoint(SwaggerExtensions.SwaggerJsonPath(version), applicationName);
                opt.RoutePrefix = string.Empty;
                Action<SwaggerUIOptions> action = setupAction;
                if (action == null)
                    return;
                action(opt);
            }));
            return app;
        }
    }
}