﻿namespace Infrastructure.Exceptions;

public class NotificationModel
{
    public string Message { get; }

    public NotificationModel(string message)
    {
        Message = message;
    }
}
