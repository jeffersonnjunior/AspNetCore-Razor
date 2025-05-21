using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories;

public class MedicalSpecialtyRepository : BaseRepository<MedicalSpecialty>, IMedicalSpecialtyRepository
{
    public MedicalSpecialtyRepository(AppDbContext context) : base(context)
    {
    }
}