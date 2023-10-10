using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuSort : IExpansion
    {
        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Сортировка");
            operation.Action(new Sort());
        }
    }
}