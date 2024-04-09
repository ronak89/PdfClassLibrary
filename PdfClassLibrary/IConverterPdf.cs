using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfClassLibrary
{
    public interface IConverterPdf
    {
        byte[] GeneratePdf(PdfSettings settings, string htmlContent);
    }
}
