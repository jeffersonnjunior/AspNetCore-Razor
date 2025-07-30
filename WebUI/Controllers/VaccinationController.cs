using Application.Dtos.VaccineDocumentDtos;
using Application.Interfaces.IDecorators;
using Application.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

public class VaccinationController : Controller
{
    private readonly IVaccineDocumentDecorator _vaccineDocumentDecorator;
    private readonly IVaccineDocumentServices _vaccineDocumentServices;
    private readonly ILogger<VaccinationController> _logger;

    public VaccinationController(
        IVaccineDocumentDecorator vaccineDocumentDecorator,
        IVaccineDocumentServices vaccineDocumentServices,
        ILogger<VaccinationController> logger)
    {
        _vaccineDocumentDecorator = vaccineDocumentDecorator;
        _vaccineDocumentServices = vaccineDocumentServices;
        _logger = logger;
    }

    public IActionResult Create()
    {
        var dto = new VaccineDocumentCreateDto();
        return View(dto);
    }

    [HttpPost]
    public IActionResult Create(VaccineDocumentCreateDto dto)
    {
        if (!ModelState.IsValid)
        {
            _logger.LogWarning("ModelState inválido ao criar vacinação.");
            return View(dto);
        }

        try
        {
            _vaccineDocumentDecorator.Add(dto);
            _logger.LogInformation("Vacinação criada com sucesso para paciente {PatientId}", dto.PatientId);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar vacinação.");
            ModelState.AddModelError("", "Erro ao salvar: " + ex.Message);
            return View(dto);
        }
    }

    [HttpGet]
    public async Task<IActionResult> SearchPatients()
    {
        var result = await _vaccineDocumentDecorator.SearchPatientsAsync();
        return Json(result);
    }

    [HttpGet]
    [Route("DevTools")]
    public async Task<IActionResult> DevTools()
    {
        var documents = await _vaccineDocumentServices.GetVaccineDocumentsList();
        return Json(documents);
    }
}