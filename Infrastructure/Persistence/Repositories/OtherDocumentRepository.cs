using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Persistence.Repositories;

public class OtherDocumentRepository : BaseRepository<OtherDocument>, IOtherDocumentRepository
{
    public OtherDocumentRepository(
        AppDbContext context,
        ILogger<BaseRepository<OtherDocument>> logger)
        : base(context, logger)
    {
    }
}