using Core.Entities;

namespace Core.Interfaces;

public interface IExamResultService
{
    Task AddExamResultAsync(ExamResult examResult);
    Task<IEnumerable<ExamResult>> GetExamResultsByUserAsync(string userId);
}