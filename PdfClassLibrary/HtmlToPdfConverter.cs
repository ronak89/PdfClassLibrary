using DinkToPdf;
using DinkToPdf.Contracts;
using System;

namespace PdfClassLibrary
{
    public class HtmlToPdfConverter
    {
        private readonly IConverter _converter;

        public HtmlToPdfConverter(IConverter converter)
        {
            _converter = converter ?? throw new ArgumentNullException(nameof(converter));
        }

        public byte[] ConvertHtmlToPdf(GlobalSettings globalSettings, ObjectSettings objectSettings)
        {
            var pdf = new HtmlToPdfDocument
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            return _converter.Convert(pdf);
        }
    }
}
