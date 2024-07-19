using PDFGenerator.DTO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PDFGenerator.Quest
{
    public static class QuestPDFGenerator
    {
        public static IDocument CreatePDF(PDFDTO custome)
        {
            return Document.Create(container =>
               {
                   container.PageConfiguration(custome);
               });

        }

        private static void PageConfiguration(this IDocumentContainer container, PDFDTO custom)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(2, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(p => p.FontSize(20));
                page.PageHeader(custom.Header);
            });
        }
        private static void PageHeader(this PageDescriptor page, PageHeader customHeader)
        {
            if (customHeader.Bold)
            {
                page.Header()
                .Text(customHeader.Text)
                .FontSize(customHeader.FontSize)
                .Bold()
                .FontColor(Color.FromHex(customHeader.ColorHex));
                return;
            }
            page.Header()
            .Text(customHeader.Text)
            .FontSize(customHeader.FontSize)
            .FontColor(Color.FromHex(customHeader.ColorHex));


        }
    }
}
