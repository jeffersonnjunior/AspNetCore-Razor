using Application.Dtos.PatientDtos;
using Application.Interfaces.IFactories;
using Domain.Entities;

namespace Application.Factories;

public class PatientFactory : IPatientFactory
{
    public List<PatientReadDto> MapToPatientReadDtoList(List<Patient> patients)
    {
        return patients.Select(p => new PatientReadDto
        {
            Id = p.Id,
            Name = p.Name,
            Document = p.Document
        }).ToList();
    }
}