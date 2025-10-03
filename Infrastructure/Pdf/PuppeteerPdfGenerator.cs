using Infrastructure.Interfaces.IPdf;
using PuppeteerSharp;

namespace Infrastructure.Pdf;

public class PuppeteerPdfGenerator : IPdfGenerator
{
    public async Task<byte[]> GeneratePdfAsync(string html)
    {
        await new BrowserFetcher().DownloadAsync();

        var launchOptions = new LaunchOptions 
        { 
            Headless = true,
            Args = new[]
            {
                "--no-sandbox",
                "--disable-setuid-sandbox",
                "--disable-dev-shm-usage",
                "--disable-accelerated-2d-canvas",
                "--no-first-run",
                "--no-zygote",
                "--disable-gpu"
            }
        };

        using var browser = await Puppeteer.LaunchAsync(launchOptions);
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