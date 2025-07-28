using Application.Dtos.PatientDtos;
using Application.Interfaces.IDecorators;
using Application.Interfaces.IServices;

namespace Application.Decorators;

public class PatientDecorator : IPatientDecorator
{
    private readonly IPatientServices _patientServices;

    public PatientDecorator(IPatientServices patientServices)
    {
        _patientServices = patientServices;
    }

    public void Add(PatientCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public async Task<List<string>> GetPatientsNamesAsync()
    {
        var patients = await _patientServices.GetPatients();
        return patients.Select(p => p.Name).ToList();
    }
}
