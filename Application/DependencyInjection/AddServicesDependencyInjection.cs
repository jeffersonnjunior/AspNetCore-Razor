using Application.Interfaces.IServices;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection;

public static class AddServicesDependencyInjection
{
    public static void ServicesDependencyInjection(this IServiceCollection service)
    {
        service.AddScoped<IAppointmentServices, AppointmentServices>();
        service.AddScoped<IDoctorServices, DoctorServices>();
        service.AddScoped<IExamDocumentServices, ExamDocumentServices>();
        service.AddScoped<IMedicalSpecialtyServices, MedicalSpecialtyServices>();
        service.AddScoped<IOtherDocumentServices, OtherDocumentServices>();
        service.AddScoped<IPatientServices, PatientServices>();
        service.AddScoped<IVaccineDocumentServices, VaccineDocumentServices>();
    }
}
