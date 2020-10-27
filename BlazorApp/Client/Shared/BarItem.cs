using System.Collections.Generic;

namespace BlazorApp.Pwa.Client.Shared
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
}
