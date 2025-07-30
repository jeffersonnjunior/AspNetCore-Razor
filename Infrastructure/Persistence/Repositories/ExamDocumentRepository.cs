using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Persistence.Repositories;

public class ExamDocumentRepository : BaseRepository<ExamDocument>, IExamDocumentRepository
{
    public ExamDocumentRepository(
        AppDbContext context,
        ILogger<BaseRepository<ExamDocument>> logger)
        : base(context, logger)
    {
    }
}