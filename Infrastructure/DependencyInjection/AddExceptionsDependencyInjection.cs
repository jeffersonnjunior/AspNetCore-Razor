using Infrastructure.Exceptions;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection;

public static class AddExceptionsDependencyInjection
{
    public static void ExceptionsDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<NotificationContext>();
    }
}