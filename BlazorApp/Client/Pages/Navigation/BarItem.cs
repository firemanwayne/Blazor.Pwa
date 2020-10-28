using System.Collections.Generic;

namespace BlazorApp.Pwa.Client.Pages.Navigation
{
    public class BarItem
    {
        public string Name { get; set; }
        public string LogoName { get; set; }
        public string HrefLink { get; set; }
        public bool IsLocked { get; set; }
        public string ModuleColor { get; set; }

        public IList<BarListItem> NavItems { get; set; } = new List<BarListItem>();
    }

    public class BarListItem
    {
        public string Name { get; set; }
        public string Href { get; set; }
        public bool IsLocked { get; set; } = false;

        public BarListItem(string Name, string Href)
        {
            this.Name = Name;
            this.Href = Href;
        }
    }
}
