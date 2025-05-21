namespace Application.Dtos.AppointmentDtos;

public class AppointmentCreateDto
{
    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }
    public DateTime AppointmentDateTime { get; set; }
    public string Notes { get; set; }
}
