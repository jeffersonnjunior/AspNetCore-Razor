using Application.Interfaces.IServices;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebUI.Pages.Pdfs;

public class VaccineCardModel : PageModel
{
    private readonly IGeneratePdfService _pdfService;

    public VaccineCardModel(IGeneratePdfService pdfService)
    {
        _pdfService = pdfService;
    }

    // Adicione outras propriedades necessárias para o modelo

    [BindProperty]
    public string HtmlContent { get; set; } = string.Empty;

    public void OnGet()
    {
        // Carregue os dados do modelo normalmente
    }

    public async Task<IActionResult> OnGetGeneratePdfAsync()
    {
        var pdfBytes = await _pdfService.GeneratePdfFromPageUrlAsync("https://localhost:5000/Pdfs/VaccineCard");
        return File(pdfBytes, "application/pdf", "VaccineCard.pdf");
    }
}