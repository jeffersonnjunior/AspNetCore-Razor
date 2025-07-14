namespace Application.Dtos.AppointmentDtos;

public class AppointmentCreateDto
{
    public string PatientName { get; set; }
    public string DoctorName { get; set; }
    public DateTime AppointmentDateTime { get; set; }
    public string Notes { get; set; }
    public string Status { get; set; }
}