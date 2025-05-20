namespace Domain.Entities;

public class OtherDocument
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
    public string DocumentType { get; set; } 
    public string Description { get; set; }
    public DateTime IssueDate { get; set; }
    public string FilePath { get; set; }
}
