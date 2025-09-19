using Core.Entities;
using Core.Interfaces;

namespace Core.Services;

public class ExamResultService : IExamResultService
{
    public Task AddExamResultAsync(ExamResult examResult)
    {
        // Business logic for adding an exam result
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ExamResult>> GetExamResultsByUserAsync(string userId)
    {
        // Business logic for retrieving exam results by user
        throw new NotImplementedException();
    }
}