namespace LandMilitaryEquipment_PR5_MD.MenuController
{
    public class ContentMenu
    {
        public int Item { get; set; }
        public string? Content { get; set; }
        public IExpansion? Expansion { get; set; }

        public ContentMenu(int item, string? content, IExpansion? expansion)
        {
            Item = item;
            Content = content;
            Expansion = expansion;
        }

        public override string ToString()
        {
            return $"{Item} - {Content}";
        }
    }
}