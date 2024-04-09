using DinkToPdf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfClassLibrary.Models
{
    public class PageMarginSettings
    {
        public Unit Unit { get; set; }

        public double? Top { get; set; }

        public double? Bottom { get; set; }

        public double? Left { get; set; }

        public double? Right { get; set; }

        public PageMarginSettings()
        {
            Unit = Unit.Millimeters;
        }

        public PageMarginSettings(double top, double right, double bottom, double left)
            : this()
        {
            Top = top;
            Bottom = bottom;
            Left = left;
            Right = right;
        }

        public string GetMarginValue(double? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            string text = "in";
            return string.Concat(str1: Unit switch
            {
                Unit.Inches => "in",
                Unit.Millimeters => "mm",
                Unit.Centimeters => "cm",
                _ => "in",
            }, str0: value.Value.ToString("0.##", CultureInfo.InvariantCulture));
        }
    }
}
