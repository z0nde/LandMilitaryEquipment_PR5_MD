using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.Classes.SortExpansion
{
    public class MenuSort : IExpansion
    {
        public void Perform()
        {
            Console.WriteLine("Сортировка по возрастанию:");
            ListDataLandMilitaryEquipment listLME = new();
            listLME.Sorting(new SortLME());
        }
    }
}