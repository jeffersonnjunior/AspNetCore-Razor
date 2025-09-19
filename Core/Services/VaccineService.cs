using Core.Entities;
using Core.Interfaces;

namespace Core.Services;

public class VaccineService : IVaccineService
{
    public Task RegisterVaccineAsync(Vaccine vaccine)
    {
        // Business logic for registering a vaccine
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Vaccine>> GetVaccinesByUserAsync(string userId)
    {
        // Business logic for retrieving vaccines by user
        throw new NotImplementedException();
    }
}