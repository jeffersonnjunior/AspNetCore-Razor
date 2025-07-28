using Application.Dtos.VaccineDocumentDtos;
using Application.Interfaces.IDecorators;
using Microsoft.AspNetCore.Mvc;

public class VaccinationController : Controller
{
    private readonly IVaccineDocumentDecorator _vaccineDocumentDecorator;

    public VaccinationController(IVaccineDocumentDecorator vaccineDocumentDecorator)
    {
        _vaccineDocumentDecorator = vaccineDocumentDecorator;
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