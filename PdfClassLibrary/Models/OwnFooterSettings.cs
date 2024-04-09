using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfClassLibrary.Models
{
    public class OwnFooterSettings
    {
        //
        // Summary:
        //     The font size to use for the footer. Default = 12
        public int? FontSize { get; set; }

        //
        // Summary:
        //     The name of the font to use for the footer. Default = "Ariel"
        public string FontName { get; set; }

        //
        // Summary:
        //     The string to print in the left part of the footer, note that some sequences
        //     are replaced in this string, see the wkhtmltopdf manual. Default = ""
        public string Left { get; set; }

        //
        // Summary:
        //     The text to print in the right part of the footer, note that some sequences are
        //     replaced in this string, see the wkhtmltopdf manual. Default = ""
        public string Center { get; set; }

        //
        // Summary:
        //     The text to print in the right part of the footer, note that some sequences are
        //     replaced in this string, see the wkhtmltopdf manual. Default = ""
        public string Right { get; set; }

        //
        // Summary:
        //     Whether a line should be printed above the footer. Default = false
        public bool? Line { get; set; }

        //
        // Summary:
        //     The amount of space to put between the footer and the content, e.g. "1.8". Be
        //     aware that if this is too large the footer will be printed outside the pdf document.
        //     This can be corrected with the margin.bottom setting. Default = 0.00
        public double? Spacing { get; set; }

        //
        // Summary:
        //     Url for a HTML document to use for the footer. Default = ""
        public string HtmUrl { get; set; }
    }
}
