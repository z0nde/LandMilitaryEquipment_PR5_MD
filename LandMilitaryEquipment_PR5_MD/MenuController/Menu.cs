using LandMilitaryEquipment_PR5_MD.Interfaces;

namespace LandMilitaryEquipment_PR5_MD.MenuController
{
    public class Menu : IFound<IExpansion, int>
    {
        public List<ContentMenu> ListMenu { get; set; } = new();

        private static void Expansion(IExpansion expansion)
        {
            expansion.Perform();
        }

        public void Create(ContentMenu listContent)
        {
            ListMenu.Add(listContent);
        }

        public void Read()
        {
            foreach (var item in ListMenu)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public IExpansion FoundObj(int obj)
        {
            return ListMenu
                .Where(s => s.Item == obj)
                .Select(s => s.Expansion).FirstOrDefault()!;
        }

        public void CompleteItemMenu(int item)
        {
            Expansion(FoundObj(item));
        }
    }
}