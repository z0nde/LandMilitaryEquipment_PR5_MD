using LandMilitaryEquipment_PR5_MD.ListClasses;
using LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.Classes.SortExpansion
{
    public class MenuSort : IExpansion
    {
        public void Perform()
        {
            Console.WriteLine("Сортировка по возрастанию:");
            CentralDataLandMilitaryEquipment centralData = new();
            centralData.Expansion(new ManagerDataSortInject(new /*затычка*/ListDataLandMilitaryEquipment(), new SortLME()));
        }
    }
}