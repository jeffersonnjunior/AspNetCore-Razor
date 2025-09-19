using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class VaccineRepository : IVaccineRepository
{
    private readonly AppDbContext _context;

    public VaccineRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Vaccine vaccine)
    {
        _context.Set<Vaccine>().Add(vaccine);
        await _context.SaveChangesAsync();
    }

    public async Task<Vaccine?> GetByIdAsync(int id)
    {
        return await _context.Set<Vaccine>().FindAsync(id);
    }

    public async Task<IEnumerable<Vaccine>> GetByUserIdAsync(string userId)
    {
        return await _context.Set<Vaccine>()
            .Where(v => v.UserId == userId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Vaccine>> GetAllAsync()
    {
        return await _context.Set<Vaccine>().ToListAsync();
    }
}