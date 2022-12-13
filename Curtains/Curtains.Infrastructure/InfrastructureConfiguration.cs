using Curtains.Domain.Search;
using Curtains.Infrastructure.Correlation;
using Curtains.Infrastructure.Database;
using Curtains.Infrastructure.SearchEngine;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Curtains.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace Curtains.Infrastructure
{
    public static class InfrastructureConfiguration
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            string connectionString,
            IConfiguration configuration)
        {
            var elasticSearchOptions = configuration.GetSection(ElasticSearchOptions.Name).Get<ElasticSearchOptions>();

            services
                .AddDbContext<CurtainsDbContext>(opt =>
                {
                    opt.UseSqlServer("Server=localhost,1433;Database=Curtains;User=sa;Password=<YourStrong@Passw0rd>", opt =>
                    {
                        opt.MigrationsAssembly(typeof(CurtainsDbContext).Assembly.FullName);
                    });
                });

            services
                .AddSingleton(provider => ElasticSearchClientFactory.Create(elasticSearchOptions))
                .AddSingleton<ICurtainsSearchRepository, CurtainsSearchRepository>()
                .AddSingleton<CorrelationMiddleware>();

            services
                .AddRepositories();

            var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetService<ILogger<CurtainsDbContext>>();
            services.AddSingleton(typeof(ILogger), logger);

            return services;
        }

         private static IServiceCollection AddRepositories(this IServiceCollection services)
         {
            var types = Assembly
                .GetExecutingAssembly()
                .GetTypes();

            var interfaceTypes = types
                .Where(type => type.IsInterface
                            && (type.Namespace == typeof(ICurtainsRepository).Namespace))
            .ToArray();

            foreach (var interfaceType in interfaceTypes)
            {
                var implementation = types
                    .FirstOrDefault(type => type.GetInterface(interfaceType.Name) == interfaceType);

                services
                    .AddScoped(interfaceType, implementation);
            }

            return services;
         }
    }
}
