using PdfClassLibrary.Models;

namespace PdfClassLibrary
{
    internal interface IPdfSettings
    {
        OwnWebSettings WebSettings { get; }
        OwnHeaderSettings HeaderSettings { get; }
        OwnFooterSettings FooterSettings { get; }
        OwnGlobalSettings OwnGlobalSettings { get; }

        
    }
}
