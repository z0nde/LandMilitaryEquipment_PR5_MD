using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;
using LandMilitaryEquipment_PR5_MD.MenuController.MenuItems;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.SortExpansion
{
    public class ValidateSortMenu : IMenu
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public ValidateSortMenu(ListDataLandMilitaryEquipment listData) =>
            _ListData = listData;
        
        public Menu ValidateMenu()
        {
            Menu menu = new();

            menu.Create(new ContentMenu(1, "Сортировка по возрастанию:", new MenuSort(_ListData)));
            menu.Create(new ContentMenu(2, "Сортировка по убыванию:", new MenuSortDesc(_ListData)));
            menu.Create(new ContentMenu(0, "Выход", new MenuExit()));

            return menu;
        }
    }
}