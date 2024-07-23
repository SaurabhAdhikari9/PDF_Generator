using PDFGenerator.DTO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using PDFGenerator.Helper.FontHelper;

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
                page.PageFooter(custom.Footer);
            });
        }
        private static void PageHeader(this PageDescriptor page, PageHeader customHeader)
        {
            page.Header()
                .Background(Color.FromHex(customHeader.ColorHex))
                .Height(customHeader.Height)
                .Text(customHeader.Text).FontSize(customHeader.FontSize).Style(FontHandler.Boldness(customHeader.Boldness));


        }

        public static void PageFooter(this PageDescriptor page, FooterDTO footer)
        {
            page.Footer()
                .Background(Color.FromHex(footer.ColorHex))
                .Text(footer.Text).Style(
                    FontHandler.Boldness(footer.Boldness)
                );
        }
    }
}
