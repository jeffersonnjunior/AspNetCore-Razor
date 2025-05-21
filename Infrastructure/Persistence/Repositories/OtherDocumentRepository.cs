using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories;

public class OtherDocumentRepository : BaseRepository<OtherDocument>, IOtherDocumentRepository
{
    public OtherDocumentRepository(AppDbContext context) : base(context)
    {
    }
}
