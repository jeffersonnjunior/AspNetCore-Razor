using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class PatientRepository : BaseRepository<Patient>, IPatientRepository
{
    public PatientRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<List<Patient>> GetPatientsList()
    {
        return await _context.Set<Patient>()
            .ToListAsync();
    }
}