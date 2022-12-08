using System.Reflection;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Curtains.Application.Interfaces;
using Curtains.Application.CurtainsServices.Interfaces;

namespace Curtains.Application
{
    public static class ApplicationConfigExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services
                .AddMediatR(Assembly.GetExecutingAssembly())
                .AddAutoMapper()
                .AddServices();
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

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            var types = Assembly

                .GetExecutingAssembly()
                .GetTypes();

            var interfaceTypes = types
                .Where(type => type.IsInterface
                            && type.Namespace == typeof(IOurWorksService).Namespace || type.Namespace == typeof(IProductImageService).Namespace)
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
