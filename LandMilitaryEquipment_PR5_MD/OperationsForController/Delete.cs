using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.LME;
using LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus.DeleteSubMenu;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Delete : IStrategyForController, IUpdateInject
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Delete(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void StrategyCRUDForController()
        {
            DependencyInjectionManagerMenu menu = new(new SubDelete(_ListData), new Linear());
            menu.MenuAssembly();
        }
    }
}