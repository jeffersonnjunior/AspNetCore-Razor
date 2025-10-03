using Infrastructure.Interfaces.IPdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding; 
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using WebUI.Pages.Pdfs;

namespace WebUI.Controllers
{
    public class VaccineController : Controller
    {
        private readonly IPdfGenerator _pdfGenerator;
        private readonly IRazorViewEngine _viewEngine;
        private readonly ITempDataProvider _tempDataProvider;
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<VaccineController> _logger;

        public VaccineController(
            IPdfGenerator pdfGenerator,
            IRazorViewEngine viewEngine,
            ITempDataProvider tempDataProvider,
            IServiceProvider serviceProvider,
            ILogger<VaccineController> logger)
        {
            _pdfGenerator = pdfGenerator;
            _viewEngine = viewEngine;
            _tempDataProvider = tempDataProvider;
            _serviceProvider = serviceProvider;
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
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> PrintVaccineReport()
        {
            var model = new CreateVaccinePdfModel
            {
            };

            string html = await RenderViewToStringAsync("/Pages/Pdfs/CreateVaccinePdf.cshtml", model);

            var pdfBytes = await _pdfGenerator.GeneratePdfAsync(html);

            return File(pdfBytes, "application/pdf", "RelatorioVacinas.pdf");
        }

        private async Task<string> RenderViewToStringAsync(string viewPath, object model)
        {
            var actionContext = new ActionContext(HttpContext, RouteData, ControllerContext.ActionDescriptor);

            using var sw = new StringWriter();
            var viewResult = _viewEngine.GetView(executingFilePath: null, viewPath, isMainPage: true);

            if (!viewResult.Success)
                throw new FileNotFoundException($"View {viewPath} not found.");

            var viewDictionary = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
            {
                Model = model
            };

            var tempData = new TempDataDictionary(HttpContext, _tempDataProvider);

            var viewContext = new ViewContext(
                actionContext,
                viewResult.View,
                viewDictionary,
                tempData,
                sw,
                new HtmlHelperOptions()
            );

            await viewResult.View.RenderAsync(viewContext);
            return sw.ToString();
        }
    }
}