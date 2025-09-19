using Core.Entities;
using Core.Interfaces;

namespace Core.UseCases;

public class ScheduleAppointmentUseCase
{
    private readonly IAppointmentService _appointmentService;

    public ScheduleAppointmentUseCase(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    public async Task ExecuteAsync(Appointment appointment)
    {
        // Add business rules here if needed
        await _appointmentService.ScheduleAppointmentAsync(appointment);
    }
}