using Application.Dtos.OtherDocumentDtos;

namespace Application.Interfaces.IDecorators;

public interface IOtherDocumentDecorator
{
    void Add(OtherDocumentCreateDto dto);
}