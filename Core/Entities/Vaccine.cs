namespace Core.Entities;

public class Vaccine
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateAdministered { get; set; }
    public string UserId { get; set; }
}