using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class VaccineController : Controller
    {
        private readonly ILogger<VaccineController> _logger;

        public VaccineController(ILogger<VaccineController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string name, string manufacturer, string batch, 
                                DateTime? manufacturingDate, DateTime? expirationDate, 
                                int? availableDoses, decimal? storageTemperature, string notes)
        {
            // Logic to save the vaccine will be implemented in the future
            return RedirectToAction("Index");
        }
    }
}