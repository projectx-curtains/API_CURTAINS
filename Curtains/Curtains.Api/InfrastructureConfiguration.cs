using Curtains.Domain.Search;
using Curtains.Infrastructure.Database;
using Curtains.Infrastructure.SearchEngine;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
                .AddSingleton<ICurtainsSearchRepository, CurtainsSearchRepository>();

            return services;
        }
    }    
}
