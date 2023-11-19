// LogIngestor/Startup.cs 
 
using Microsoft.AspNetCore.Builder; 
using Microsoft.AspNetCore.Hosting; 
using Microsoft.Extensions.DependencyInjection; 
using LogIngestor.Repositories; 
using LogIngestor.Services; 
 
public class Startup 
{ 
    public void ConfigureServices(IServiceCollection services) 
    { 
        services.AddControllers(); 
    } 
 
    public void Configure(IApplicationBuilder app, IHostingEnvironment env) 
    { 
        if (env.IsDevelopment()) 
        { 
            app.UseDeveloperExceptionPage(); 
        } 
 
        app.UseRouting(); 
 
