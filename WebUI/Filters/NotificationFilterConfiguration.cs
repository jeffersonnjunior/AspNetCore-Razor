using Microsoft.Extensions.DependencyInjection;

namespace WebUI.Filters;

public static class NotificationFilterConfiguration
{
    public static IServiceCollection AddNotificationActionFilter(this IServiceCollection services)
    {
        services.AddMvc(options =>
        {
            options.Filters.Add<NotificationActionFilter>();
        });

        return services;
    }
}