using DinkToPdf;
using DinkToPdf.Contracts;
using PdfClassLibrary.Models;

namespace PdfClassLibrary
{
    public class PdfGenerator : IConverterPdf
    {
        //private readonly IConverter _converter;

        //public PdfGenerator(IConverter converter)
        //{
        //    _converter = converter;
        //}

        public byte[] GeneratePdf(PdfSettings pdfSettings, string htmlContent)
        {
            //string outputPath = @"D:\PDFCreator\Employee_Report11.pdf";
            //string directory = Path.GetDirectoryName(outputPath);
            //if (!Directory.Exists(directory))
            //{
            //    Directory.CreateDirectory(directory);
            //}
            var globalSettings = new GlobalSettings
            {
                Orientation = pdfSettings.OwnGlobalSettings.Orientation ?? Orientation.Portrait,
                ColorMode = pdfSettings.OwnGlobalSettings.ColorMode ?? ColorMode.Color,
                UseCompression = pdfSettings.OwnGlobalSettings.UseCompression ?? true,
                DPI = pdfSettings.OwnGlobalSettings.DPI ?? 96,
                Out = @"D:\PDFCreator\Employee_Report.pdf"
                // Set other properties similarly...
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = htmlContent,
                WebSettings = new WebSettings
                {
                    EnableJavascript = pdfSettings.WebSettings.EnableJavascript ?? true,
                    LoadImages = pdfSettings.WebSettings.LoadImages ?? true,
                    PrintMediaType = pdfSettings.WebSettings.PrintMediaType ?? false
                }
            };

            var pdf = new HtmlToPdfDocument
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            var converter = new SynchronizedConverter(new PdfTools());
            HtmlToPdfConverter htmlToPdfConverter = new HtmlToPdfConverter(converter);

            byte[] bytes = htmlToPdfConverter.ConvertHtmlToPdf(globalSettings, objectSettings);
            return bytes;

            //return _converter.Convert(pdf);
        }
    }
    //using PdfClassLibrary;

    //namespace ConsoleApp1
    //{

    //    internal class Class1
    //    {
    //        //PdfSettings settings = new PdfSettings { HeaderSettings = { },OwnGlobalSettings = { },WebSettings = { }, FooterSettings = { } };
    //        private readonly IConverterPdf _pdfGenerator;
    //        public Class1(IConverterPdf pdfGenerator)
    //        {
    //            _pdfGenerator = pdfGenerator;
    //        }
    //        static void Main(string[] args)
    //        {


    //            // Create an instance of Class1 and pass pdfGenerator to its constructor
    //            Class1 class1 = new Class1();

    //            // Call the method to generate PDF
    //            class1.GeneratePdf();
    //        }

    //        public void GeneratePdf()
    //        {

    //            PdfSettings settings = new PdfSettings { HeaderSettings = { }, OwnGlobalSettings = { }, WebSettings = { }, FooterSettings = { } };
    //            string htmlContent = "<html><body><h1>Hello, PDF!</h1></body></html>";

    //            byte[] pdfBytes = _pdfGenerator.GeneratePdf(settings, htmlContent);

    //            // Now you can use the generated PDF bytes
    //            // For example, you can save them to a file
    //            File.WriteAllBytes("generated_pdf.pdf", pdfBytes);
    //        }
    //    }
    //}

}
