using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Persistence.Repositories;

public class MedicalSpecialtyRepository : BaseRepository<MedicalSpecialty>, IMedicalSpecialtyRepository
{
    public MedicalSpecialtyRepository(
        AppDbContext context,
        ILogger<BaseRepository<MedicalSpecialty>> logger)
        : base(context, logger)
    {
    }
}