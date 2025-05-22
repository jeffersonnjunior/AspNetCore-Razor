using Application.Dtos.ExamDocumentDtos;

namespace Application.Interfaces.IDecorators;

public interface IExamDocumentDecorator
{
    void Add(ExamDocumentCreateDto dto);
}
