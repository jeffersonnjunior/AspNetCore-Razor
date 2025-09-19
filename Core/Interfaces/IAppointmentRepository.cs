using Core.Entities;

namespace Core.Interfaces;

public interface IAppointmentRepository
{
    Task AddAsync(Appointment appointment);
    Task<Appointment?> GetByIdAsync(int id);
    Task<IEnumerable<Appointment>> GetByUserIdAsync(string userId);
    Task<IEnumerable<Appointment>> GetAllAsync();
}