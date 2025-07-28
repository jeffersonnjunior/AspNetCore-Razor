using Domain.Entities;

namespace Infrastructure.Interfaces.IPersistence.IRepositories;

public interface IPatientRepository : IBaseRepository<Patient>
{
    Task<List<Patient>> GetPatients();
}
