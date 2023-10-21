using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.Classes.SortExpansion
{
    public class MenuSortDesc : IExpansion
    {
        public void Perform()
        {
            Console.WriteLine("Сортировка по убыванию:");
            ListDataLandMilitaryEquipment listLME = new();
            listLME.Sorting(new SortLMEDesc());
        }
    }
}