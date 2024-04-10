using PdfClassLibrary;

namespace PdfClassLibrary
{
    public class Class1
    {

    }
}


//using DinkToPdf;
//using PdfClassLibrary;

//namespace ConsoleApp1
//{

//    internal class Class1
//    {


//        PdfSettings settings = new PdfSettings { HeaderSettings = { }, OwnGlobalSettings = { }, WebSettings = { }, FooterSettings = { } };
//        private readonly IConverterPdf _pdfGenerator;
//        public Class1(IConverterPdf pdfGenerator)
//        {
//            _pdfGenerator = pdfGenerator;
//        }

//        static void Main()
//        {
//            //var converter = new SynchronizedConverter(new PdfTools());
//            IConverterPdf pdfGenerator = new PdfGenerator();
//            Class1 class1 = new Class1(pdfGenerator);

//            // Call the method to generate PDF
//            class1.GeneratePdf();

//            //var converter = new SynchronizedConverter(new PdfTools());



//            //IConverterPdf pdfGenerator = new PdfGenerator();
//            //Class1 class1 = new Class1(pdfGenerator);

//            //// Call the method to generate PDF
//            //class1.GeneratePdf();



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
