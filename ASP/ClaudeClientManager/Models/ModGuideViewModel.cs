namespace ClaudeClientManager.Models
{
    public class ModGuideViewModel
    {
        public string Title { get; set; }
        public string[] CoreMods { get; set; }
        public ModLayer[] Layers { get; set; }
    }

    public class ModLayer
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Items { get; set; }
    }
}
