using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuRead : IExpansion
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public MenuRead(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Вывод");
            operation.Action(new Read(_ListData));
        }
    }
}