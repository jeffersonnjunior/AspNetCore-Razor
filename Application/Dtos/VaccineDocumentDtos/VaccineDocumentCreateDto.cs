namespace Application.Dtos.VaccineDocumentDtos;

public class VaccineDocumentCreateDto
{
    public Guid PatientId { get; set; }
    public string VaccineName { get; set; }
    public string Manufacturer { get; set; }
    public DateTime AdministrationDate { get; set; }
    public string LotNumber { get; set; }
}