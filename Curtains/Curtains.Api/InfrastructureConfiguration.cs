using Curtains.Domain.Search;
using Curtains.Infrastructure.Correlation;
using Curtains.Infrastructure.Database;
using Curtains.Infrastructure.SearchEngine;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Curtains.Application.CurtainsService;
using Curtains.Application.Interfaces;
using Curtains.Infrastructure.Repositories;
using Curtains.Infrastructure.Interfaces;
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
               // .AddSingleton<ICurtainsSearchRepository, CurtainsSearchRepository>()
                .AddSingleton<CorrelationMiddleware>();

            services
                .AddScoped<IReviewRepository, ReviewRepository>()
                .AddScoped<IReviewService, ReviewService>();

            var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetService<ILogger<CurtainsDbContext>>();
            services.AddSingleton(typeof(ILogger), logger);
                
            return services;
        }
    }    
}
