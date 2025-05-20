﻿using Domain.Enums;

namespace Domain.Entities;

public class Appointment
{

    public int Id { get; set; }
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }
    public DateTime AppointmentDateTime { get; set; }
    public string Notes { get; set; }
    public AppointmentStatus Status { get; set; }
}