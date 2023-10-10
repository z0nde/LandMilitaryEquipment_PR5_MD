using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuCreate : IExpansion
    {
        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Добавление");
            operation.Action(new Create());
        }
    }
}