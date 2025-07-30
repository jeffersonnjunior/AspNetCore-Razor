using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Persistence.Repositories;

public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
{
    public AppointmentRepository(
        AppDbContext context,
        ILogger<BaseRepository<Appointment>> logger)
        : base(context, logger)
    {
    }
}