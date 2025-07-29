using Application.Interfaces.IServices;
using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;

namespace Application.Services;

public class PatientServices : IPatientServices
{
    private readonly IPatientRepository _patientRepository;

    public PatientServices(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }
    public async Task<List<Patient>> GetPatientsList()
    {
        var patients = await _patientRepository.GetPatients();
        return patients;
    }
}