
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using IloggerManager = CompanyEmployees.Contracts.IloggerManager;
using LoggerManager = CompanyEmployees.LoggerService.LoggerManager;

namespace CompanyEmployees.Extensions;

public static class ServiceExtensions
{
    //TODO Make this restrictive. 
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });

    //Host app on IIS
    public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {

        });

    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<IloggerManager, LoggerManager>();
}