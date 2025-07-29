using Application.Dtos.PatientDtos;
using Domain.Entities;

namespace Application.Interfaces.IFactories;

public interface IPatientFactory
{
    List<PatientReadDto> MapToPatientReadDtoList(List<Patient> patients);
}
