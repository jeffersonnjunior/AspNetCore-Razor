using Domain.Entities;

namespace Application.Dtos.OtherDocumentDtos;

public class OtherDocumentUpdateDto
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public string DocumentType { get; set; }
    public string Description { get; set; }
    public DateTime IssueDate { get; set; }
}