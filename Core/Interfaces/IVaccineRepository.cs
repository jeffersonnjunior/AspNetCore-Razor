using Core.Entities;

namespace Core.Interfaces;

public interface IVaccineRepository
{
    Task AddAsync(Vaccine vaccine);
    Task<Vaccine?> GetByIdAsync(int id);
    Task<IEnumerable<Vaccine>> GetByUserIdAsync(string userId);
    Task<IEnumerable<Vaccine>> GetAllAsync();
}