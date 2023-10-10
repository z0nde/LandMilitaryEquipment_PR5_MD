using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuUpdate : IExpansion
    {
        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Изменение");
            operation.Action(new Update());
        }
    }
}