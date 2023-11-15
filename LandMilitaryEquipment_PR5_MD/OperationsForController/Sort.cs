using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.SortExpansion;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Sort : IStrategyForController
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Sort(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void Perform()
        {
            DependencyInjectionManagerMenu dIManagerMenu = new(new ValidateSortMenu(_ListData), new Linear());
            dIManagerMenu.MenuAssembly();
        }
    }
}