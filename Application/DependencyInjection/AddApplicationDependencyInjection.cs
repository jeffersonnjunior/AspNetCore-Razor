using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection;

public static class AddApplicationDependencyInjection
{
    public static void DependencyInjectionApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.ServicesDependencyInjection();
        services.FactoryDependencyInjection();
        services.DecoratorDependencyInjection();
    }
}