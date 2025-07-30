using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Persistence.Repositories;

public class VaccineDocumentRepository : BaseRepository<VaccineDocument>, IVaccineDocumentRepository
{
    public VaccineDocumentRepository(
        AppDbContext context,
        ILogger<BaseRepository<VaccineDocument>> logger)
        : base(context, logger)
    {
    }

    public async Task<IEnumerable<VaccineDocument>> GetAllVaccineDocumentsAsync()
    {
        return await GetAllAsync();
    }
}