using Core.Entities;

namespace Core.Interfaces.Repositories;

public interface IVaccineRepository
{
    Task<Vaccine> CreateAsync(Vaccine vaccine);
    Task<Vaccine?> GetByNameAsync(string name);
    Task<bool> ExistsAsync(string name);
}