using Application.Dtos.MedicalSpecialtyDtos;

namespace Application.Interfaces.IDecorators;

public interface IMedicalSpecialtyDecorator
{
    void Add(MedicalSpecialtyCreateDto dto);
}
