using LandMilitaryEquipment_PR5_MD.Interfaces;

namespace LandMilitaryEquipment_PR5_MD.Classes.SortExpansion
{
    public class SortLME : ITransaction
    {
        public void Transaction()
        {
            var obj = Data.ListLME
                .OrderBy(s => s.Title)
                .Select(s => s).ToList();

            foreach (var item in obj)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
