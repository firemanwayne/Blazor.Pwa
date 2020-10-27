using BlazorApp.Pwa.Shared.Models.Concrete;
using System;

namespace BlazorApp.Pwa.Shared.Extensions
{
    public static class SizeSuffixesExtensions
    {
        public static string GetSizeSuffix(this SizeSuffixes s, int value, int decimalPlaces = 1)
        {
            if (value < 0) return "-" + s.GetSizeSuffix(-value);

            if (value == 0) return "0.0 bytes";

            int mag = (int)Math.Log(value, 1024);

            decimal adjustedSize = value / (1L << (mag * 10));

            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }
            return string.Format("{0:n" + decimalPlaces + "} {1}", adjustedSize, SizeSuffixes.Suffixes[mag]);
        }
    }
}
