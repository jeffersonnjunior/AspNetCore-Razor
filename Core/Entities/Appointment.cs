namespace Core.Entities;

public class Appointment
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public DateTime ScheduledDate { get; set; }
    public string DoctorName { get; set; }
    public string Description { get; set; }
}