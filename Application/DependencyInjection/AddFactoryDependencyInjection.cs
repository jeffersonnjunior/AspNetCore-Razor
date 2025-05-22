using Application.Factories;
using Application.Interfaces.IFactories;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection;

public static class AddFactoryDependencyInjection
{
    public static void FactoryDependencyInjection(this IServiceCollection service)
    {
        service.AddScoped<IAppointmentFactory, AppointmentFactory>();
        service.AddScoped<IDoctorFactory, DoctorFactory>();
        service.AddScoped<IExamDocumentFactory, ExamDocumentFactory>();
        service.AddScoped<IMedicalSpecialtyFactory, MedicalSpecialtyFactory>();
        service.AddScoped<IOtherDocumentFactory, OtherDocumentFactory>();
        service.AddScoped<IPatientFactory, PatientFactory>();
        service.AddScoped<IVaccineDocumentFactory, VaccineDocumentFactory>();
    }
}
