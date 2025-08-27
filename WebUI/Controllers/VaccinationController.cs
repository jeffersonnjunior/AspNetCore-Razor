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

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        var dto = new VaccineDocumentCreateDto();
        return View(dto);
    }

    [HttpPost]
    public IActionResult Create(VaccineDocumentCreateDto dto)
    {
        _vaccineDocumentDecorator.Add(dto);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> SearchPatients()
    {
        var result = await _vaccineDocumentDecorator.SearchPatientsAsync();
        return Json(result);
    }
}