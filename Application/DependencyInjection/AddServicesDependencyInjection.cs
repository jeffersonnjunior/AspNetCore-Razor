using Application.Interfaces.IServices;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection;

public static class AddServicesDependencyInjection
{
    public static void ServicesDependencyInjection(this IServiceCollection service)
    {
        service.AddScoped<IGeneratePdfService, GeneratePdfService>();
        service.AddScoped<IPatientServices, PatientServices>();
        service.AddScoped<IVaccineDocumentServices, VaccineDocumentServices>();
    }
}
