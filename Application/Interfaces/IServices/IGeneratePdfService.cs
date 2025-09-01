namespace Application.Interfaces.IServices;

public interface IGeneratePdfService
{
    Task<byte[]> GeneratePdfFromPageUrlAsync(string pageUrl);
}
