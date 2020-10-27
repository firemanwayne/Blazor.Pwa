using System.Drawing;

namespace BlazorApp.Pwa.Shared.Models.Concrete
{
    public class OpaqueColor
    {
        public OpaqueColor(Color c, decimal o)
        {
            Color = c;
            Opacity = o;
        }
        public Color Color { get; }
        public decimal Opacity { get; }
    }
}
