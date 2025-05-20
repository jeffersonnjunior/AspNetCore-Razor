using Domain.Enums;

namespace Domain.Entities;

public class Appointment
{

    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }
    public DateTime AppointmentDateTime { get; set; }
    public string Notes { get; set; }
    public AppointmentStatus Status { get; set; }
    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
}