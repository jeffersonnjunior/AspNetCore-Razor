using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Persistence.Repositories;

public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
{
    public DoctorRepository(
        AppDbContext context,
        ILogger<BaseRepository<Doctor>> logger)
        : base(context, logger)
    {
    }
}