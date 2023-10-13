using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuDelete : IExpansion
    {
        private readonly ListDataLandMilitaryEquipment _ListData;
        
        public MenuDelete(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Удаление");
            operation.Action(new Delete(_ListData));
        }
    }
}