using Core.Entities;
using Core.Interfaces;

namespace Core.Services;

public class AppointmentService : IAppointmentService
{
    public Task ScheduleAppointmentAsync(Appointment appointment)
    {
        // Business logic for scheduling an appointment
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Appointment>> GetAppointmentsByUserAsync(string userId)
    {
        // Business logic for retrieving appointments by user
        throw new NotImplementedException();
    }
}