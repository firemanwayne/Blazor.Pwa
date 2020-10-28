using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace Shared.Models.Concrete
{
    public class ColorEntity
    {
        const int DefaultOpacity = 1;
        protected ColorEntity(string Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            Color = FindByName(Name);
            HexValue = Color;
            RGBValue = Color;
            RGBAValue = (Color, DefaultOpacity);
        }

        [Display(Name = "Id")]
        public string Id { get; init; }

        [Display(Name = "Name")]
        public string Name { get; init; }

        [Display(Name = "Color")]
        public Color Color { get; set; }

        [Display(Name = "Hex Color")]
        public Hexidecimal HexValue { get; init; }

        [Display(Name = "RGB Color")]
        public RGBColor RGBValue { get; init; }

        [Display(Name = "RGBA Color")]
        public RGBAColor RGBAValue { get; init; }

        public static RGBColor ConvertToRGB(Color c) => c;
        public static IList<ColorEntity> Colors => GetColors();
        public static Hexidecimal ConvertToHexadecimal(Color c) => c;
        public static Dictionary<string, string> ColorDictionary { get => GetColorDictionary(); }
        public static RGBAColor ConvertToRGBA(Color c, decimal opacityValue) => new OpaqueColor(c, opacityValue);
        public static Color FindByName(string ColorName) => ColorCollection.FirstOrDefault(c => c.Name.ToUpper() == ColorName.ToUpper());
        public static ColorEntity FindById(string ColorId) => Colors.FirstOrDefault(c => c.Id.Equals(ColorId));

        static IList<ColorEntity> GetColors()
        {
            var colors = new List<ColorEntity>();

            foreach (var Color in GetColorDictionary())
                colors.Add(new ColorEntity(Color.Key, Color.Value));

            return colors;
        }
        static Dictionary<string, string> GetColorDictionary()
        {
            var colors = new Dictionary<string, string>();
            foreach (Color color in ColorCollection)
            {
                var c = new ColorEntity(ConvertToHexadecimal(color).Value, color.Name);
                colors.TryAdd(c.Id, c.Name);
            }
            return colors;
        }
        static ICollection<Color> ColorCollection
            => typeof(Color).GetProperties(
                BindingFlags.Static |
                BindingFlags.DeclaredOnly |
                BindingFlags.Public)
            .Select(c => (Color)c.GetValue(null, null))
            .ToList();
    }
}
