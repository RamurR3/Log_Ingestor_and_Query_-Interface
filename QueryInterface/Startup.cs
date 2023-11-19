// QueryInterface/Startup.cs

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using QueryInterface.Services;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IQueryService, QueryService>();
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
