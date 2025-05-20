namespace Domain.Entities;

public class VaccineDocument
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public string VaccineName { get; set; }
    public string Manufacturer { get; set; }
    public DateTime AdministrationDate { get; set; }
    public string LotNumber { get; set; }
    public Patient Patient { get; set; }
}
