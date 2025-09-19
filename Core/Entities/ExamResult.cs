namespace Core.Entities;

public class ExamResult
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string ExamType { get; set; }
    public DateTime ExamDate { get; set; }
    public string Result { get; set; }
}