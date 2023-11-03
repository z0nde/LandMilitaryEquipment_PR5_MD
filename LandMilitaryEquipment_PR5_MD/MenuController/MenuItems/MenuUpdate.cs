using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus.DeleteSubMenu;
using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuUpdate : IExpansion
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public MenuUpdate(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Изменение");
            operation.Action(new Update(new ItemDelete(_ListData), new Create(_ListData)));
        }
    }
}