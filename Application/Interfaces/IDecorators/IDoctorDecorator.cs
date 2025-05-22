using Application.Dtos.DoctorDtos;

namespace Application.Interfaces.IDecorators;

public interface IDoctorDecorator
{
    void Add(DoctorCreateDto dto);
}
