namespace Application.Dtos.MedicalSpecialtyDtos;

public class MedicalSpecialtyUpdateDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public Guid MedicalSpecialtyId { get; set; }
}
