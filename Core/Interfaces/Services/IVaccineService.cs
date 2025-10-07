using Core.Entities;

namespace Core.Interfaces.Services;

public interface IVaccineService
{
    Task ValidateVaccineAsync(Vaccine vaccine, bool nameAlreadyExists = false);
}