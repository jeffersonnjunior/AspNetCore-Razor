using Application.Dtos.AppointmentDtos;
using Application.Interfaces.IDecorators;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Pages.Appointments;

public class CreateModel : PageModel
{
    private readonly IAppointmentDecorator _appointmentDecorator;

    public CreateModel(IAppointmentDecorator appointmentDecorator)
    {
        _appointmentDecorator = appointmentDecorator;
    }

    [BindProperty]
    public AppointmentCreateDto Dto { get; set; } = new();

    public List<string> StatusOptions { get; } = Enum.GetNames(typeof(AppointmentStatus)).ToList();

    public void OnGet()
    {
        // Página de carregamento inicial
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
}