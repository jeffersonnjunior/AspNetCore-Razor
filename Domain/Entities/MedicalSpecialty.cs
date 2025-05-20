namespace Domain.Entities;

public class MedicalSpecialty
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int MedicalSpecialtyId { get; set; }
    public MedicalSpecialty Specialty { get; set; }
}