using DinkToPdf;
using DinkToPdf.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfClassLibrary
{
    public class SynchronizedConverterFactory : IConverterFactory
    {
        private PdfTools pdfTools;

        public SynchronizedConverterFactory(PdfTools pdfTools)
        {
            this.pdfTools = pdfTools;
        }

        public IConverter CreateConverter()
        {
            return new SynchronizedConverter(new PdfTools());
        }
    }
}
