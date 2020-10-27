using System.Collections.Generic;

namespace BlazorApp.Pwa.Shared.Models.Concrete
{
    public class FileFormat
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public static class FileFormats
    {
        public static IList<FileFormat> GetFormats()
        {
            return new List<FileFormat>()
            {
                new FileFormat{ Id = 1 , Name = "Pdf" },
                new FileFormat{ Id = 2, Name = "Excel" }
            };
        }
    }
}
