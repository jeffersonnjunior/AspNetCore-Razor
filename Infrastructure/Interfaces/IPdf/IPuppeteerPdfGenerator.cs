namespace Infrastructure.Interfaces.IPdf;

public interface IPdfGenerator
{
    Task<byte[]> GeneratePdfAsync(string html);
}
