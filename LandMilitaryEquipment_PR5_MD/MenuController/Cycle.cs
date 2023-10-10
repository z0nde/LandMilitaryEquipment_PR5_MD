namespace LandMilitaryEquipment_PR5_MD.MenuController
{
    public class Cycle : ITypeOfLinearity
    {
        public void Linearity(Menu menu)
        {
            string? controller;

            do
            {
                Console.WriteLine("Ввыедите цифру для действия.");
                menu.Read();
                controller = Console.ReadLine();
                menu.CompleteItemMenu(Convert.ToInt32(controller));
            } while (controller != "0");
        }
    }
}