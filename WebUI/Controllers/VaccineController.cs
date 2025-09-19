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
            // Logic to save the vaccine will be implemented in the future
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> PrintVaccineReport()
        {
            // 1. Monte o modelo de dados (exemplo, ajuste conforme sua lógica)
            var model = new CreateVaccinePdfModel
            {
                // Preencha as propriedades do modelo conforme necessário
            };

            // 2. Renderize o Razor Page como HTML
            string html = await RenderViewToStringAsync("/Pages/Pdfs/CreateVaccinePdf.cshtml", model);

            // 3. Gere o PDF
            var pdfBytes = await _pdfGenerator.GeneratePdfAsync(html);

            // 4. Retorne o PDF como arquivo
            return File(pdfBytes, "application/pdf", "RelatorioVacinas.pdf");
        }

        // Método utilitário para renderizar Razor Page como string
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