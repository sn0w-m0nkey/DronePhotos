using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Web.Configuration;
using Web.Data;
using Web.Services;

namespace Web.Extensions;

public static class ServiceProviderExtensions
{
    public static IServiceCollection RegisterWebComponents(this IServiceCollection services, IConfiguration configuration)
    {
        AddControllers(services, configuration);
        ConfigureOptions(services, configuration);
        RegisterServices(services);

        return services;
    }

    public static IServiceCollection RegisterDataComponents(this IServiceCollection services, IConfiguration configuration)
    {
        // TODO: Update connection string
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
            
        return services;
    }

    private static IServiceCollection AddControllers(IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddControllers()
            .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

        return services;
    }

    private static void ConfigureOptions(IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<ApiConfig>(configuration.GetSection(nameof(ApiConfig)));
    }

    private static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IPhotoService, PhotoService>();
        services.AddSingleton<WeatherForecastService>();
    }
}
