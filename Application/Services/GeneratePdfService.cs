using Application.Interfaces.IServices;
using PuppeteerSharp;

namespace Application.Services;

public class GeneratePdfService : IGeneratePdfService
{
    public async Task<byte[]> GeneratePdfFromPageUrlAsync(string pageUrl)
    {
        using var browser = await Puppeteer.LaunchAsync(new LaunchOptions
        {
            Headless = true,
            ExecutablePath = "/usr/bin/chromium",
            Args = new[] { "--no-sandbox", "--ignore-certificate-errors" }
        });
        using var page = await browser.NewPageAsync();
        await page.GoToAsync(pageUrl, WaitUntilNavigation.Networkidle0);
        var pdfBytes = await page.PdfDataAsync();
        return pdfBytes;
    }
}