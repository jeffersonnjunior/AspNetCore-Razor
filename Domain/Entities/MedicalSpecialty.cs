namespace Domain.Entities;

public class MedicalSpecialty
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public Guid MedicalSpecialtyId { get; set; }
    public MedicalSpecialty Specialty { get; set; }
}