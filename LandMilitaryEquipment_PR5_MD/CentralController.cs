using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD
{
    public static class CentralController
    {
        public static void MenuCentralController(ListDataLandMilitaryEquipment listData)
        {
            DependencyInjectionManagerMenu dIManagerMenu = new (new ValidationMenu(listData), new Cycle());
            dIManagerMenu.MenuAssembly();
        }
    }
}