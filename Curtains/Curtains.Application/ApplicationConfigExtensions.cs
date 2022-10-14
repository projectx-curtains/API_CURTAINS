using System.Reflection;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Curtains.Application
{
    public static class ApplicationConfigExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services
                .AddMediatR(Assembly.GetExecutingAssembly())
                .AddAutoMapper();
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var types = AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(x => x.FullName.StartsWith("Curtains.Application"))
                .SelectMany(x => x.GetTypes()
                    .Where(type => type.IsClass
                                   && !type.IsAbstract
                                   && type.IsSubclassOf(typeof(Profile))))
                .ToArray();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(types);
                cfg.DisableConstructorMapping();
            });

            services.AddSingleton(mapperConfig.CreateMapper());

            return services;
        }
    }    
}
