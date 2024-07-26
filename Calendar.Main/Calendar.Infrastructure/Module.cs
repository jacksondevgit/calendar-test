using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Calendar.Infrastructure;

public static class Module
{
    public static IServiceCollection InitializeInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}