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
                    opt.UseSqlServer(connectionString, opt =>
                    {
                        opt.MigrationsAssembly(typeof(CurtainsDbContext).Assembly.FullName);
                    });
                });

            services
                .AddSingleton(provider => ElasticSearchClientFactory.Create(elasticSearchOptions))
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
                            && (type.Namespace == typeof(ICurtainsRepository).Namespace || type.Namespace == typeof(IBedspreadsRepository).Namespace) || 
                            type.Namespace == typeof(IAccessoriesRepository).Namespace || type.Namespace == typeof(IColorRepository).Namespace ||
                            type.Namespace == typeof(IConsistencyRepository).Namespace || type.Namespace == typeof(ICurtainsKindRepository).Namespace ||
                            type.Namespace == typeof(ICurtainsTypeRepository).Namespace || type.Namespace == typeof(IDecorationsRepository).Namespace ||
                            type.Namespace == typeof(IDeliveryTypeRepository).Namespace || type.Namespace == typeof(IFabricRepository).Namespace ||
                            type.Namespace == typeof(ILambrequinsRepository).Namespace || type.Namespace == typeof(IManufacturerRepository).Namespace ||
                            type.Namespace == typeof(IMarketingInfoRepository).Namespace || type.Namespace == typeof(IMaterialRepository).Namespace ||
                            type.Namespace == typeof(IOrderRepository).Namespace || type.Namespace == typeof(IOurWorksRepository).Namespace ||
                            type.Namespace == typeof(IPaymentTypeRepository).Namespace || type.Namespace == typeof(IPillowsRepository).Namespace ||
                            type.Namespace == typeof(IProductImageRepository).Namespace || type.Namespace == typeof(IProductSetRepository).Namespace ||
                            type.Namespace == typeof(IReviewRepository).Namespace || type.Namespace == typeof(IUserOrderRepository).Namespace ||
                            type.Namespace == typeof(IUserRepository).Namespace || type.Namespace == typeof(IElasticCurtainsIndexRepository).Namespace)
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
