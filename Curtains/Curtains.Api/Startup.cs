using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseRouting();
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/swagger.json", "Api");
        });
    }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSwaggerGen();
    }
}