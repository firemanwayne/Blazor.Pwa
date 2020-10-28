using System.Drawing;

namespace Shared.Models.Concrete
{
    public class RGBAColor
    {
        private Color color;

        private RGBAColor(OpaqueColor c)
        {
            color = c.Color;

            Value = $"{c.Opacity}, {c.Color.R}, {c.Color.G}, {c.Color.B}";
            R = c.Color.R;
            G = c.Color.G;
            B = c.Color.B;
            Alpha = c.Color.A;
        }

        private RGBAColor(Color c, int o)
        {
            color = c;

            ///If o is greater than 255 make it 255,
            ///if o is less than 1 make it 1,
            ///otherwise use the original value
            o = o > 255 ? 255 : o < 1 ? 1 : o;

            Value = $"{o}, {c.R}, {c.G}, {c.B}";
            R = c.R;
            G = c.G;
            B = c.B;
            Alpha = c.A;
        }

        public string Value { get; private set; }
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }
        public byte Alpha { get; private set; }

        public void ChangeOpacity(int Opacity)
        {
            ///If Opacity is greater than 255 make it 255,
            ///if Opacity is less than 1 make it 1,
            ///otherwise use the original value
            Opacity = Opacity > 255 ? 255 : Opacity < 1 ? 1 : Opacity;

            color = Color.FromArgb(Opacity, color);

            Value = $"{Opacity}, {color.R}, {color.G}, {color.B}";
            R = color.R;
            G = color.G;
            B = color.B;
            Alpha = color.A;
        }

        public static implicit operator RGBAColor(OpaqueColor c) => new RGBAColor(c);

        public static implicit operator RGBAColor((Color c, int o) v) => new RGBAColor(v.c, v.o);
    }
}
