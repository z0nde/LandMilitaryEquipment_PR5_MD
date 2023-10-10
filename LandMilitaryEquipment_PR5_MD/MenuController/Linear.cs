namespace LandMilitaryEquipment_PR5_MD.MenuController
{
    public class Linear : ITypeOfLinearity
    {
        public void Linearity(Menu menu)
        {
            menu.Read();
            string? controller = Console.ReadLine();
            menu.CompleteItemMenu(Convert.ToInt32(controller));
        }
    }
}