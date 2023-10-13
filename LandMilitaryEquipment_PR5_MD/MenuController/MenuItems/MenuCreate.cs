using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuCreate : IExpansion
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public MenuCreate(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Добавление");
            operation.Action(new Create(_ListData));
        }
    }
}