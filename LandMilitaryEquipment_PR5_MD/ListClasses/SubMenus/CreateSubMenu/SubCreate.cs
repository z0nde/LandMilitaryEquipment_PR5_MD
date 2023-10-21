using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus.CreateSubMenu;
using LandMilitaryEquipment_PR5_MD.MenuController;
using LandMilitaryEquipment_PR5_MD.MenuController.MenuItems;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus
{
    public class SubCreate : IMenu
    {
        private readonly ListDataImplementator _ListDataImplementator;

        public SubCreate(ListDataImplementator impls) => _ListDataImplementator = impls;

        public Menu ValidateMenu()
        {
            Menu menu = new();

            menu.Create(new ContentMenu(1, "Добавление", new ItemCreate(_ListDataImplementator)));
            menu.Create(new ContentMenu(0, "Выход", new MenuExit()));

            return menu;
        }
    }
}