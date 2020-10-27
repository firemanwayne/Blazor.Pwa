using System.Collections.Generic;
using System.Net.Mime;

namespace BlazorApp.Pwa.Shared.Models.Concrete
{
    public class MediaType
    {
        private MediaType() { }

        public string Id { get; set; }
        public string Name { get; set; }        

        public static IDictionary<string, string> Types { get; set; } = new Dictionary<string, string>()
        {
            { "application/vnd.ms-excel", "application/vnd.ms-excel" },
            { MediaTypeNames.Application.Json, MediaTypeNames.Application.Json },
            { MediaTypeNames.Application.Octet, MediaTypeNames.Application.Octet },
            { MediaTypeNames.Application.Pdf, MediaTypeNames.Application.Pdf },
            { MediaTypeNames.Application.Rtf, MediaTypeNames.Application.Rtf },
            { MediaTypeNames.Application.Soap, MediaTypeNames.Application.Soap },
            { MediaTypeNames.Application.Zip, MediaTypeNames.Application.Zip },
            { MediaTypeNames.Image.Gif, MediaTypeNames.Image.Gif },
            { MediaTypeNames.Image.Jpeg, MediaTypeNames.Image.Jpeg },
            { MediaTypeNames.Image.Tiff, MediaTypeNames.Image.Tiff },
            { "image/png", "image/png" },
            { MediaTypeNames.Text.Html, MediaTypeNames.Text.Html },
            { MediaTypeNames.Text.Plain, MediaTypeNames.Text.Plain},
            { MediaTypeNames.Text.RichText, MediaTypeNames.Text.RichText },
            { MediaTypeNames.Text.Xml, MediaTypeNames.Text.Xml }
        };
    }
}
