namespace Domain.Entities;

public class VaccineDocument
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
    public string VaccineName { get; set; }
    public string Manufacturer { get; set; }
    public DateTime AdministrationDate { get; set; }
    public string LotNumber { get; set; }
}
