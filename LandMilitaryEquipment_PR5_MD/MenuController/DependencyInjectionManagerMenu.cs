namespace LandMilitaryEquipment_PR5_MD.MenuController
{
    public class DependencyInjectionManagerMenu
    {
        private readonly IMenu _Menu;
        private readonly ITypeOfLinearity? _TypeOfLinearity;

        public DependencyInjectionManagerMenu(IMenu menu, ITypeOfLinearity typeOfLinearity) =>
            (_Menu, _TypeOfLinearity) = (menu, typeOfLinearity);

        public void MenuAssembly()
        {
            _TypeOfLinearity!.Linearity(_Menu.ValidateMenu());
        }
    }
}