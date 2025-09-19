using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly AppDbContext _context;

    public AppointmentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Appointment appointment)
    {
        _context.Set<Appointment>().Add(appointment);
        await _context.SaveChangesAsync();
    }

    public async Task<Appointment?> GetByIdAsync(int id)
    {
        return await _context.Set<Appointment>().FindAsync(id);
    }

    public async Task<IEnumerable<Appointment>> GetByUserIdAsync(string userId)
    {
        return await _context.Set<Appointment>()
            .Where(a => a.UserId == userId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Appointment>> GetAllAsync()
    {
        return await _context.Set<Appointment>().ToListAsync();
    }
}