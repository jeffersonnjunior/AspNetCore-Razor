using Core.Interfaces;
using Core.Services;
using Core.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyInjection;

public static class AddCoreDependencyInjection
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        // Services
        services.AddScoped<IVaccineService, VaccineService>();
        services.AddScoped<IAppointmentService, AppointmentService>();
        services.AddScoped<IExamResultService, ExamResultService>();

        // UseCases
        services.AddScoped<RegisterVaccineUseCase>();
        services.AddScoped<ScheduleAppointmentUseCase>();
        services.AddScoped<AddExamResultUseCase>();

        return services;
    }
}