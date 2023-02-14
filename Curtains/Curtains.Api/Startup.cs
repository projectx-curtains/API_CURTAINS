using Curtains.Application;
using Curtains.Infrastructure;
using Curtains.Infrastructure.Correlation;
using Curtains.Infrastructure.Database;
using Curtains.Infrastructure.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Curtains.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = _configuration.GetConnectionString("CurtainsDataBase");

            services
                .AddApplication()
                .AddInfrastructure(connectionString, _configuration);

            services
                .AddOpenApi(_environment.ApplicationName)
                .AddControllers(opt =>
                {
                    opt.Filters.Add<HttpGlobalExceptionFilter>();
                })
                .AddJsonSerializer();
        }

        public void Configure(IApplicationBuilder app, CurtainsDbContext context)
        {
            if (_environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            context.Database.EnsureCreated();

            app
                .UseRouting()
                .UseSerilogRequestLogging()
                .UseCorrelationId()
                .UseOpenApi(_environment.ApplicationName)
                .UseEndpoints(endpoints => endpoints.MapControllers());
        }

    }
}