using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.MenuController.MenuItems
{
    public class MenuRead : IExpansion
    {
        public void Perform()
        {
            Operation operation = new();
            Console.WriteLine("Вывод");
            operation.Action(new Read());
        }
    }
}