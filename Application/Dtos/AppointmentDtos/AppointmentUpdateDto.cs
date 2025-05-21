using Domain.Enums;

namespace Application.Dtos.AppointmentDtos;

public class AppointmentUpdateDto
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }
    public DateTime AppointmentDateTime { get; set; }
    public string Notes { get; set; }
    public AppointmentStatus Status { get; set; }
}
