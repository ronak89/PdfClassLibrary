using PdfClassLibrary.Models;

namespace PdfClassLibrary
{
    public class PdfSettings : IPdfSettings
    {
        
        public PdfSettings()
        {
            WebSettings = new OwnWebSettings();
            HeaderSettings = new OwnHeaderSettings();
            FooterSettings = new OwnFooterSettings();
            OwnGlobalSettings = new OwnGlobalSettings();

            
        }

        public OwnWebSettings WebSettings { get; }
        public OwnHeaderSettings HeaderSettings { get; }
        public OwnFooterSettings FooterSettings { get; }
        public OwnGlobalSettings OwnGlobalSettings { get; }

        
    }
}
