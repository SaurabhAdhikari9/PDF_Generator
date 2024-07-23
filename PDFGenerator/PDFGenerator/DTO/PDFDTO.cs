using QuestPDF.Infrastructure;
using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;

namespace PDFGenerator.DTO
{
    public class PDFDTO
    {
        public PageHeader Header { get; set; }
        public FooterDTO Footer { get; set; }
    }

    public class PageHeader
    {
        public required string Text { get; set; }
        public required string ColorHex { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="FontSize must be greater than 0")]
        public int FontSize { get; set; }
        public int Boldness { get; set; }
        public string? Image { get; set; }
        public float Height { get; set; }
    }

    public class FooterDTO:PageHeader
    {
    }
    public class Font
    {
        public required string FontFamily { get; set;}
    }
}
