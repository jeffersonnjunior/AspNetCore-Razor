namespace Core.DTOs;

public class CreateVaccineDto
{
    public string Name { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public string Batch { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public int? AvailableDoses { get; set; }
    public decimal? StorageTemperature { get; set; }
    public string Description { get; set; } = string.Empty;
}