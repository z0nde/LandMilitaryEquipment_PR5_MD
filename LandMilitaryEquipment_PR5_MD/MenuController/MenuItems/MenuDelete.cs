using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuDelete : IExpansion
    {
        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Удаление");
            operation.Action(new Delete());
        }
    }
}