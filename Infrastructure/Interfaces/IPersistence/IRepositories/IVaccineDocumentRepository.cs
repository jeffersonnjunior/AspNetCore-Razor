using Domain.Entities;

namespace Infrastructure.Interfaces.IPersistence.IRepositories;

public interface IVaccineDocumentRepository : IBaseRepository<VaccineDocument>
{
    Task<IEnumerable<VaccineDocument>> GetAllVaccineDocumentsAsync();
}
