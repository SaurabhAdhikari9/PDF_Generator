using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PDFGenerator.Helper.FontHelper
{
    public static class FontHandler
    {
        public static TextStyle Boldness(int boldness = 0)
        {
            
            if (boldness == 0)
            {
                boldness = 400; // equivalent to css 400 bold
            }
            else if (boldness <= 100)
            {
                boldness = 100;
            }
            else if (boldness <= 200)
            {
                boldness = 200;
            }
            else if (boldness <= 300)
            {
                boldness = 300;
            }
            else if(boldness <= 400)
            {
                boldness = 400;
            }
            else if( boldness <= 500)
            {
                boldness = 500;
            }
            else if(boldness <= 600)
            {
                boldness = 600;  
            }
            else if (boldness <= 700)
            {
                boldness = 700;
            }
            else if(boldness <= 800)
            {
                boldness = 800;
            }
            else if(boldness <= 900)
            {
                boldness = 900;
            }
            else if(boldness <= 1000)
            {
                boldness = 1000;
            }
            return TextStyle.Default.Weight((FontWeight)boldness);
        }
    }
}
