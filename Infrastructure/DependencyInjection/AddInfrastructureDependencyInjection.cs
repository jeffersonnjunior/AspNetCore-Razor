using Infrastructure.Interfaces.IPdf;
using Infrastructure.Pdf;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection;

public static class AddInfrastructureDependencyInjection
{
    public static IServiceCollection DependencyInjectionInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IPdfGenerator, PuppeteerPdfGenerator>();

        return services;
    }
}