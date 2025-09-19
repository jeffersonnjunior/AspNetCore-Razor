using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ExamResultRepository : IExamResultRepository
{
    private readonly AppDbContext _context;

    public ExamResultRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ExamResult examResult)
    {
        _context.Set<ExamResult>().Add(examResult);
        await _context.SaveChangesAsync();
    }

    public async Task<ExamResult?> GetByIdAsync(int id)
    {
        return await _context.Set<ExamResult>().FindAsync(id);
    }

    public async Task<IEnumerable<ExamResult>> GetByUserIdAsync(string userId)
    {
        return await _context.Set<ExamResult>()
            .Where(e => e.UserId == userId)
            .ToListAsync();
    }

    public async Task<IEnumerable<ExamResult>> GetAllAsync()
    {
        return await _context.Set<ExamResult>().ToListAsync();
    }
}