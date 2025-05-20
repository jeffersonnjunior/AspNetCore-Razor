namespace Domain.Entities;

public class ExamDocument
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
    public string ExamName { get; set; }
    public string ExamType { get; set; } 
    public DateTime ExamDate { get; set; }
    public string FilePath { get; set; }
}