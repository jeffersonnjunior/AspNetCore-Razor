using Core.DTOs;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Interfaces.UseCases;

namespace Core.UseCases;

public class CreateVaccineUseCase : ICreateVaccineUseCase
{
    private readonly IVaccineRepository _vaccineRepository;
    private readonly IVaccineService _vaccineService;

    public CreateVaccineUseCase(IVaccineRepository vaccineRepository, IVaccineService vaccineService)
    {
        _vaccineRepository = vaccineRepository;
        _vaccineService = vaccineService;
    }

    public async Task<Vaccine> ExecuteAsync(CreateVaccineDto createVaccineDto)
    {
        var vaccine = new Vaccine
        {
            Name = createVaccineDto.Name,
            Description = createVaccineDto.Description,
            Date = createVaccineDto.Date,
            Manufacturer = createVaccineDto.Manufacturer
        };

        // Use Case busca dados necessários
        var nameAlreadyExists = await _vaccineRepository.ExistsAsync(vaccine.Name);

        // Service valida com os dados fornecidos
        await _vaccineService.ValidateVaccineAsync(vaccine, nameAlreadyExists);

        return await _vaccineRepository.CreateAsync(vaccine);
    }
}