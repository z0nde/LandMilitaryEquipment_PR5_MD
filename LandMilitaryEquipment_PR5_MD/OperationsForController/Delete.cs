using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus.DeleteSubMenu;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Delete : IStrategyForController, IUpdateInject
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Delete(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void Perform()
        {
            DependencyInjectionManagerMenu menu = new(new SubDelete(_ListData), new Linear());
            menu.MenuAssembly();
        }
    }
}