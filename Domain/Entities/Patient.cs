﻿namespace Domain.Entities;

public class Patient
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Document { get; set; }
}