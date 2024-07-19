using QuestPDF.Infrastructure;

namespace PDFGenerator.DTO
{
    public class PDFDTO
    {
        public PageHeader Header { get; set; }  
    }

    public class PageHeader
    {
        public required string Text { get; set;}
        public required string ColorHex { get; set; }
        public int FontSize { get; set;}
        public bool Bold { get; set;}   
    }
}
