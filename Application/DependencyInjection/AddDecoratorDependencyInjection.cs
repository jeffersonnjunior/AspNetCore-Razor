using Application.Decorators;
using Application.Interfaces.IDecorators;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection;

public static class AddDecoratorDependencyInjection
{
    public static void DecoratorDependencyInjection(this IServiceCollection service)
    {
        service.AddScoped<IAppointmentDecorator, AppointmentDecorator>();
        service.AddScoped<IDoctorDecorator, DoctorDecorator>();
        service.AddScoped<IExamDocumentDecorator, ExamDocumentDecorator>();
        service.AddScoped<IMedicalSpecialtyDecorator, MedicalSpecialtyDecorator>();
        service.AddScoped<IOtherDocumentDecorator, OtherDocumentDecorator>();
        service.AddScoped<IPatientDecorator, PatientDecorator>();
        service.AddScoped<IVaccineDocumentDecorator, VaccineDocumentDecorator>();
    }
}
