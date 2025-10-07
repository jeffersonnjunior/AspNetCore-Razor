using Core.Entities;
using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class VaccineRepository : IVaccineRepository
{
    private readonly ApplicationDbContext _context;

    public VaccineRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Vaccine> CreateAsync(Vaccine vaccine)
    {
        _context.Vaccines.Add(vaccine);
        await _context.SaveChangesAsync();
        return vaccine;
    }

    public async Task<Vaccine?> GetByNameAsync(string name)
    {
        return await _context.Vaccines
            .FirstOrDefaultAsync(v => v.Name.ToLower() == name.ToLower());
    }

    public async Task<bool> ExistsAsync(string name)
    {
        return await _context.Vaccines
            .AnyAsync(v => v.Name.ToLower() == name.ToLower());
    }
}