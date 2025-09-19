using Core.Entities;

namespace Core.Interfaces;

public interface IVaccineService
{
    Task RegisterVaccineAsync(Vaccine vaccine);
    Task<IEnumerable<Vaccine>> GetVaccinesByUserAsync(string userId);
}