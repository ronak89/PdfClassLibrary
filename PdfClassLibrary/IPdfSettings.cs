using PdfClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
