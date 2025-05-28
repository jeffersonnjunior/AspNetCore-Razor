using Application.Dtos.AppointmentDtos;

namespace Application.Interfaces.IServices;

public interface IAppointmentServices
{
    void Add(AppointmentCreateDto dto);
}
