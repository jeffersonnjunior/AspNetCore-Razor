namespace Application.Dtos.OtherDocumentDtos;

public class OtherDocumentCreateDto
{
    public Guid PatientId { get; set; }
    public string DocumentType { get; set; }
    public string Description { get; set; }
    public DateTime IssueDate { get; set; }
}
