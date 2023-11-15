using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.OutputString;
using LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.SortExpansion
{
    public class MenuSortDesc : IExpansion
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public MenuSortDesc(ListDataLandMilitaryEquipment listData) =>
            _ListData = listData;
        
        public void Perform()
        {
            Console.WriteLine("Сортировка по убыванию:");
            CentralDataLandMilitaryEquipment centralData = new();
            centralData.Expansion(new ManagerDataSortInject(_ListData, new SortLMEDesc(), new ManagerDataReadInject<LandMilitaryEquipment>(new Output(), new OutLandMilitaryEquipment())));
        }
    }
}