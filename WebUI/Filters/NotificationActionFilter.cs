using Infrastructure.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json; 

namespace WebUI.Filters;

public class NotificationActionFilter : IActionFilter
{
    private readonly NotificationContext _notificationContext;

    public NotificationActionFilter(NotificationContext notificationContext)
    {
        _notificationContext = notificationContext;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        //if (!context.HttpContext.Request.Headers.ContainsKey("Authorization")) context.Result = new UnauthorizedObjectResult("Autorização Ausente");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        if (_notificationContext.HasNotifications())
        {
            var notifications = _notificationContext.GetNotifications();
            Console.WriteLine("Notificações retornadas: " + JsonSerializer.Serialize(notifications));
            context.Result = new BadRequestObjectResult(notifications);
        }
    }
}