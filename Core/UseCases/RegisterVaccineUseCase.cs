using Core.Entities;
using Core.Interfaces;

namespace Core.UseCases;

public class RegisterVaccineUseCase
{
    private readonly IVaccineService _vaccineService;

    public RegisterVaccineUseCase(IVaccineService vaccineService)
    {
        _vaccineService = vaccineService;
    }

    public async Task ExecuteAsync(Vaccine vaccine)
    {
        await _vaccineService.RegisterVaccineAsync(vaccine);
    }
}