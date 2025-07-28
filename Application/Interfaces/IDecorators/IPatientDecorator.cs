using Application.Dtos.PatientDtos;

namespace Application.Interfaces.IDecorators;

public interface IPatientDecorator
{
    void Add(PatientCreateDto dto);
    Task<List<string>> GetPatientsNamesAsync();
}
