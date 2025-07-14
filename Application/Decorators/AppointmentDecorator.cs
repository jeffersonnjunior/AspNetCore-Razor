using Application.Dtos.AppointmentDtos;
using Application.Interfaces.IDecorators;
using Infrastructure.Exceptions;

namespace Application.Decorators;

public class AppointmentDecorator : IAppointmentDecorator
{
    private readonly NotificationContext _notificationContext;

    public AppointmentDecorator(NotificationContext notificationContext)
    {
        _notificationContext = notificationContext;
    }

    public void Add(AppointmentCreateDto dto)
    {
        if (!ValidateAppointmentCreateFields(dto)) return;
    }

    private bool ValidateAppointmentCreateFields(AppointmentCreateDto dto)
    {
        bool isValid = true;

        //if (dto.PatientId == Guid.Empty)
        //{
        //    _notificationContext.AddNotification("O campo 'Paciente' é obrigatório.");
        //    isValid = false;
        //}

        //if (dto.DoctorId == Guid.Empty)
        //{
        //    _notificationContext.AddNotification("O campo 'Médico' é obrigatório.");
        //    isValid = false;
        //}

        if (dto.AppointmentDateTime == default(DateTime) || dto.AppointmentDateTime < DateTime.Now)
        {
            _notificationContext.AddNotification("O campo 'Data e Hora da Consulta' deve ser uma data futura válida.");
            isValid = false;
        }

        if (!string.IsNullOrWhiteSpace(dto.Notes) && dto.Notes.Length > 500)
        {
            _notificationContext.AddNotification("O campo 'Observações' não pode exceder 500 caracteres.");
            isValid = false;
        }

        return isValid;
    }
}