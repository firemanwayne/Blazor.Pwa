using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Pwa.Shared.Models.Concrete
{
    public class SizeSuffixes
    {
        public static IList<SizeSuffix> Suffixes = new List<SizeSuffix>()
        {
            new SizeSuffix("bytes"),
            new SizeSuffix("KB"),
            new SizeSuffix("MB"),
            new SizeSuffix("GB"),
            new SizeSuffix("TB"),
            new SizeSuffix("PB"),
            new SizeSuffix("EB"),
            new SizeSuffix("ZB"),
            new SizeSuffix("YB")
        };

        public static SizeSuffix FindSuffix(string Suffix)
        {
            return Suffixes.FirstOrDefault(s => s.Suffix.Equals(Suffix));
        }

        public static string GetSizeSuffix(decimal value, int decimalPlaces = 1)
        {
            if (value < 0) { return "-" + GetSizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }
            int mag = (int)Math.Log(Convert.ToDouble(value), 1024);
            decimal adjustedSize = value / (1L << (mag * 10));
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }
            return string.Format("{0:n" + decimalPlaces + "} {1}", adjustedSize, Suffixes[mag].Suffix);
        }
    }

    public class SizeSuffix
    {
        public SizeSuffix(string Suffix)
        {
            this.Suffix = Suffix;
        }

        public string Suffix { get; private set; }
    }
}
