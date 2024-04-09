using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace PdfClassLibrary
{
    internal class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // Register your services here
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            services.AddSingleton<IPdfSettings, PdfSettings>();
            services.AddSingleton<IConverterPdf, PdfGenerator>();
        }
    }
}
