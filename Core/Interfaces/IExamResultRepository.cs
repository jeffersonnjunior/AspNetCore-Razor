using Core.Entities;

namespace Core.Interfaces;

public interface IExamResultRepository
{
    Task AddAsync(ExamResult examResult);
    Task<ExamResult?> GetByIdAsync(int id);
    Task<IEnumerable<ExamResult>> GetByUserIdAsync(string userId);
    Task<IEnumerable<ExamResult>> GetAllAsync();
}