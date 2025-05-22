using Application.Dtos.AppointmentDtos;

namespace Application.Interfaces.IDecorators;

public interface IAppointmentDecorator
{
    void Add(AppointmentCreateDto dto);
}
