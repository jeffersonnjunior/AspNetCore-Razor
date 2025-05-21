using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection;

public static class AddRepositoryDependencyInjection
{
    public static void RepositorysDependencyInjection(this IServiceCollection repository)
    {
        repository.AddScoped<IAppointmentRepository, AppointmentRepository>();
        repository.AddScoped<IDoctorRepository, DoctorRepository>();
        repository.AddScoped<IExamDocumentRepository, ExamDocumentRepository>();
        repository.AddScoped<IMedicalSpecialtyRepository, MedicalSpecialtyRepository>();
        repository.AddScoped<IOtherDocumentRepository, OtherDocumentRepository>();
        repository.AddScoped<IPatientRepository, PatientRepository>();
        repository.AddScoped<IVaccineDocumentRepository, VaccineDocumentRepository>();
    }
}