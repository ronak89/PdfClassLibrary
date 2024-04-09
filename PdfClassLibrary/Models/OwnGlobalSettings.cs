using DinkToPdf;
using PdfClassLibrary.Models;
using System.Globalization;


public class OwnGlobalSettings
{
    private PageMarginSettings margins = new PageMarginSettings();

    //
    // Summary:
    //     The orientation of the output document, must be either "Landscape" or "Portrait".
    //     Default = "portrait"
    public Orientation? Orientation { get; set; }

    //
    // Summary:
    //     Should the output be printed in color or gray scale, must be either "Color" or
    //     "Grayscale". Default = "color"
    public ColorMode? ColorMode { get; set; }

    //
    // Summary:
    //     Should we use loss less compression when creating the pdf file. Default = true
    public bool? UseCompression { get; set; }

    //
    // Summary:
    //     What dpi should we use when printing. Default = 96
    public int? DPI { get; set; }

    //
    // Summary:
    //     A number that is added to all page numbers when printing headers, footers and
    //     table of content. Default = 0
    public int? PageOffset { get; set; }

    //
    // Summary:
    //     How many copies should we print. Default = 1
    public int? Copies { get; set; }

    //
    // Summary:
    //     Should the copies be collated. Default = true
    public bool? Collate { get; set; }

    //
    // Summary:
    //     Should a outline (table of content in the sidebar) be generated and put into
    //     the PDF. Default = true
    public bool? Outline { get; set; }

    //
    // Summary:
    //     The maximal depth of the outline. Default = 4
    public int? OutlineDepth { get; set; }

    //
    // Summary:
    //     If not set to the empty string a XML representation of the outline is dumped
    //     to this file. Default = ""
    public string DumpOutline { get; set; }

    //
    // Summary:
    //     The path of the output file, if "-" output is sent to stdout, if empty the output
    //     is stored in a buffer. Default = ""
    public string Out { get; set; }

    //
    // Summary:
    //     The title of the PDF document. Default = ""
    public string DocumentTitle { get; set; }

    //
    // Summary:
    //     The maximal DPI to use for images in the pdf document. Default = 600
    public int? ImageDPI { get; set; }

    //
    // Summary:
    //     The jpeg compression factor to use when producing the pdf document. Default =
    //     94
    public int? ImageQuality { get; set; }

    //
    // Summary:
    //     Path of file used to load and store cookies. Default = ""
    public string CookieJar { get; set; }

    //
    // Summary:
    //     Size of output paper
    public PechkinPaperSize PaperSize { get; set; }

    //
    // Summary:
    //     The height of the output document
    private string PaperHeight => (PaperSize == null) ? null : PaperSize.Height;

    //
    // Summary:
    //     The width of the output document
    private string PaperWidth => (PaperSize == null) ? null : PaperSize.Width;

    public PageMarginSettings Margins
    {
        get
        {
            return margins;
        }
        set
        {
            margins = value;
        }
    }

    //
    // Summary:
    //     Size of the left margin
    private string MarginLeft => margins.GetMarginValue(margins.Left);

    //
    // Summary:
    //     Size of the right margin
    private string MarginRight => margins.GetMarginValue(margins.Right);

    //
    // Summary:
    //     Size of the top margin
    private string MarginTop => margins.GetMarginValue(margins.Top);

    //
    // Summary:
    //     Size of the bottom margin
    private string MarginBottom => margins.GetMarginValue(margins.Bottom);

    //
    // Summary:
    //     Set viewport size. Not supported in wkhtmltopdf API since v0.12.2.4
    public string ViewportSize { get; set; }
}