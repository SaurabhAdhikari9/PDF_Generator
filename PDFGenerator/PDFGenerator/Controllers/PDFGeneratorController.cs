using Microsoft.AspNetCore.Mvc;
using PDFGenerator.DTO;
using PDFGenerator.Quest;
using QuestPDF.Fluent;

namespace PDFGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDFGeneratorController : ControllerBase
    {
        [HttpGet]
        public IResult GetPdf(PDFDTO custom)
        {
            var document = QuestPDFGenerator.CreatePDF(custom);
            var pdf = document.GeneratePdf();
            return Results.File(pdf, "application/pdf", "hello-world.pdf");
        }
    }
}
