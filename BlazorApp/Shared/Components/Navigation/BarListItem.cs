namespace BlazorApp.Pwa.Shared.Components.Navigation
{
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
