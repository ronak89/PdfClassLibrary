using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace PdfClassLibrary
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // Register your services here
            //services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            services.AddSingleton<IConverter>(provider => new SynchronizedConverter(new PdfTools()));
            //services.AddSingleton<IPdfSettings, PdfSettings>();
            //services.AddSingleton<IConverterPdf, PdfGenerator>();

            services.AddSingleton<IConverterFactory, SynchronizedConverterFactory>();
            services.AddSingleton<IConverter>(provider =>
            {
                var factory = provider.GetRequiredService<IConverterFactory>();
                return factory.CreateConverter();
            });

            services.AddSingleton<IPdfSettings, PdfSettings>();
            services.AddSingleton<IConverterPdf, PdfGenerator>();
        }
    }
}
