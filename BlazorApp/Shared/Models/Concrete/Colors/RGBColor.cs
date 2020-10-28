using System.Drawing;

namespace Shared.Models.Concrete
{
    public class RGBColor
    {
        private RGBColor(Color c)
        {
            Value = $"RGB({c.R},{c.G},{c.B})";
            R = c.R;
            G = c.G;
            B = c.B;
        }

        public string Value { get; }
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }

        public static implicit operator RGBColor(Color c) => new RGBColor(c);
    }
}
