using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD
{
    public static class CentralController
    {
        public static void MenuCentralController()
        {
            DependencyInjectionManagerMenu dIManagerMenu = new (new ValidationMenu(), new Cycle());
            dIManagerMenu.MenuAssembly();
        }
    }
}