using LandMilitaryEquipment_PR5_MD.Classes.SortExpansion;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Sort : IStrategyForController
    {
        public void StrategyCRUDForController()
        {
            DependencyInjectionManagerMenu dIManagerMenu = new(new ValidateSortMenu(), new Linear());
            dIManagerMenu.MenuAssembly();
        }
    }
}