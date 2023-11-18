using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.Impl;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuFind : IExpansion
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public MenuFind(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Поиск"); 
            
            operation.Action(new Find(_ListData));
        }
    }
}