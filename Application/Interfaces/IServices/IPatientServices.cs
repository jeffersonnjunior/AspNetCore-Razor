using Domain.Entities;

namespace Application.Interfaces.IServices;

public interface IPatientServices
{
    Task<List<Patient>> GetPatients();
}
