using Core.Entities;

namespace Core.Interfaces;

public interface IAppointmentService
{
    Task ScheduleAppointmentAsync(Appointment appointment);
    Task<IEnumerable<Appointment>> GetAppointmentsByUserAsync(string userId);
}