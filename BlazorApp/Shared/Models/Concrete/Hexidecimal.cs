using System.Drawing;

namespace Shared.Models.Concrete
{
    public class Hexidecimal
    {
        public Hexidecimal(string Value)
        {
            this.Value = Value;
        }

        public string Value { get; }

        public static implicit operator Hexidecimal(Color c) => new Hexidecimal(Value: $"#{c.R:X2}{c.G:X2}{c.B:X2}");
    }
}
