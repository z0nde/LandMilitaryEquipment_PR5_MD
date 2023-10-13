using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuSort : IExpansion
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public MenuSort(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Сортировка");
            operation.Action(new Sort(_ListData));
        }
    }
}