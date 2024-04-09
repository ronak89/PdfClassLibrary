using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfClassLibrary.Models
{
    public class OwnWebSettings
    {
        //
        // Summary:
        //     Should we print the background. Default = true
        public bool? Background { get; set; }

        //
        // Summary:
        //     Should we load images. Default = true
        public bool? LoadImages { get; set; }

        //
        // Summary:
        //     Should we enable javascript. Default = true
        public bool? EnableJavascript { get; set; }

        //
        // Summary:
        //     Should we enable intelligent shrinkng to fit more content on one page. Has no
        //     effect for wkhtmltoimage. Default = true
        public bool? EnableIntelligentShrinking { get; set; }

        //
        // Summary:
        //     The minimum font size allowed. Default = -1
        public int? MinimumFontSize { get; set; }

        //
        // Summary:
        //     Should the content be printed using the print media type instead of the screen
        //     media type. Default = false
        public bool? PrintMediaType { get; set; }

        //
        // Summary:
        //     What encoding should we guess content is using if they do not specify it properly.
        //     Default = ""
        public string DefaultEncoding { get; set; }

        //
        // Summary:
        //     Url or path to a user specified style sheet. Default = ""
        public string UserStyleSheet { get; set; }

        //
        // Summary:
        //     Should we enable NS plugins. Enabling this will have limited success. Default
        //     = false
        public bool? enablePlugins { get; set; }
    }
}
