using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuFind : IExpansion
    {
        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Поиск");
            operation.Action(new Find());
        }
    }
}