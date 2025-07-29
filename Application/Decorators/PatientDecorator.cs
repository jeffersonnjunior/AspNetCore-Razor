using Application.Dtos.PatientDtos;
using Application.Interfaces.IDecorators;
using Application.Interfaces.IFactories;
using Application.Interfaces.IServices;
using Domain.Entities;

namespace Application.Decorators;

public class PatientDecorator : IPatientDecorator
{
    private readonly IPatientServices _patientServices;
    private readonly IPatientFactory _patientFactory;

    public PatientDecorator(IPatientServices patientServices, IPatientFactory patientFactory)
    {
        _patientServices = patientServices;
        _patientFactory = patientFactory;
    }

    public void Add(PatientCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PatientReadDto>> GetPatientsList()
    {
        List<Patient> patients = await _patientServices.GetPatientsList();

        List<PatientReadDto> patientReadDto = _patientFactory.MapToPatientReadDtoList(patients);

        return patientReadDto;
    }
}
