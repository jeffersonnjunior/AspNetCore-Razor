using Core.DTOs;
using Core.Entities;

namespace Core.Interfaces.UseCases;

public interface ICreateVaccineUseCase
{
    Task<Vaccine> ExecuteAsync(CreateVaccineDto createVaccineDto);
}