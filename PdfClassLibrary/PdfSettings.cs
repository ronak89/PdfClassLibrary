using DinkToPdf.Contracts;
using PdfClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
