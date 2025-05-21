using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories;

public class VaccineDocumentRepository : BaseRepository<VaccineDocument>, IVaccineDocumentRepository
{
    public VaccineDocumentRepository(AppDbContext context) : base(context)
    {
    }
}