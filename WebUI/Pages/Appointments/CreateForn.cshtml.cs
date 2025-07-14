using Application.Dtos.AppointmentDtos;
using Application.Interfaces.IDecorators;
using Domain.Enums;
using Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Pages.Appointments;

public class CreateModel : PageModel
{
    private readonly IAppointmentDecorator _appointmentDecorator;
    private readonly AppDbContext _context;

    public CreateModel(IAppointmentDecorator appointmentDecorator, AppDbContext context)
    {
        _appointmentDecorator = appointmentDecorator;
        _context = context;
    }

    [BindProperty]
    public AppointmentCreateDto Dto { get; set; } = new();

    public List<string> StatusOptions { get; } = Enum.GetNames(typeof(AppointmentStatus)).ToList();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            _appointmentDecorator.Add(Dto);
            return RedirectToPage("/Success");
        }
        catch (ValidationException ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            return Page();
        }
    }

    public JsonResult OnGetPatientsNames()
    {
        var names = _context.Set<Domain.Entities.Patient>()
            .Select(p => p.Name)
            .ToList();
        return new JsonResult(names);
    }

    public JsonResult OnGetDoctorsNames()
    {
        var names = _context.Set<Domain.Entities.Doctor>()
            .Select(d => d.Name)
            .ToList();
        return new JsonResult(names);
    }
}