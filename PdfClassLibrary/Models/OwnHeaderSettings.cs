using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfClassLibrary.Models
{
    public class OwnHeaderSettings
    {
        //
        // Summary:
        //     The font size to use for the header. Default = 12
        public int? FontSize { get; set; }

        //
        // Summary:
        //     The name of the font to use for the header. Default = "Ariel"
        public string FontName { get; set; }

        //
        // Summary:
        //     The string to print in the left part of the header, note that some sequences
        //     are replaced in this string, see the wkhtmltopdf manual. Default = ""
        public string Left { get; set; }

        //
        // Summary:
        //     The text to print in the right part of the header, note that some sequences are
        //     replaced in this string, see the wkhtmltopdf manual. Default = ""
        public string Center { get; set; }

        //
        // Summary:
        //     The text to print in the right part of the header, note that some sequences are
        //     replaced in this string, see the wkhtmltopdf manual. Default = ""
        public string Right { get; set; }

        //
        // Summary:
        //     Whether a line should be printed under the header. Default = false
        public bool? Line { get; set; }

        //
        // Summary:
        //     The amount of space to put between the header and the content, e.g. "1.8". Be
        //     aware that if this is too large the header will be printed outside the pdf document.
        //     This can be corrected with the margin.top setting. Default = 0.00
        public double? Spacing { get; set; }

        //
        // Summary:
        //     Url for a HTML document to use for the header. Default = ""
        public string HtmUrl { get; set; }
    }
}
