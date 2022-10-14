using Curtains.Domain.Search;
using Curtains.Infrastructure.Correlation;
using Curtains.Infrastructure.Database;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;
using Curtains.Infrastructure.SearchEngine;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Curtains.Api
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
                .AddSingleton<ICurtainsSearchRepository, CurtainsSearchRepository>()
                .AddSingleton<CorrelationMiddleware>();

            services
                .AddScoped<IReviewRepository, ReviewRepository>()
                .AddScoped<IColorRepository, ColorRepository>()
                .AddScoped<IConsistencyRepository, ConsistencyRepository>()
                .AddScoped<ICurtainsKindRepository, CurtainsKindRepository>()
                .AddScoped<ICurtainsTypeRepository, CurtainsTypeRepository>()
                .AddScoped<IDecorationsRepository, DecorationsRepository>()
                .AddScoped<IManufacturerRepository, ManufacturerRepository>()
                .AddScoped<IMaterialRepository, MaterialRepository>()
                .AddScoped<IAccessoriesRepository, AccessoriesRepository>()
                .AddScoped<IFabricRepository, FabricRepository>()
                .AddScoped<IBedspreadsRepository, BedspreadsRepository>()
                .AddScoped<ICurtainsRepository, CurtainsRepository>()
                .AddScoped<IPillowsRepository, PillowsRepository>()
                .AddScoped<IProductSetRepository, ProductSetRepository>()
                .AddScoped<IProductImageRepository, ProductImageRepository>()
                .AddScoped<IMarketingInfoRepository, MarketingInfoRepository>();

            var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetService<ILogger<CurtainsDbContext>>();
            services.AddSingleton(typeof(ILogger), logger);

            return services;
        }
    }    
}
