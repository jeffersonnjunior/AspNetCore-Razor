using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories;

public class ExamDocumentRepository : BaseRepository<ExamDocument>, IExamDocumentRepository
{
    public ExamDocumentRepository(AppDbContext context) : base(context)
    {
    }
}