using Infrastructure.Interfaces.IPdf;
using PuppeteerSharp;

namespace Infrastructure.Pdf;

public class PuppeteerPdfGenerator : IPdfGenerator
{
    public async Task<byte[]> GeneratePdfAsync(string html)
    {
        using var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });
        using var page = await browser.NewPageAsync();

        await page.SetContentAsync(html);

        var pdfStream = await page.PdfStreamAsync(new PdfOptions
        {
            Format = PuppeteerSharp.Media.PaperFormat.A4,
            PrintBackground = true
        });

        using var ms = new MemoryStream();
        await pdfStream.CopyToAsync(ms);
        return ms.ToArray();
    }
}