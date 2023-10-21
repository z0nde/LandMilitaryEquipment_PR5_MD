using LandMilitaryEquipment_PR5_MD.MenuController;
using LandMilitaryEquipment_PR5_MD.MenuController.MenuItems;

namespace LandMilitaryEquipment_PR5_MD.Classes.SortExpansion
{
    public class ValidateSortMenu : IMenu
    {
        public Menu ValidateMenu()
        {
            Menu menu = new();

            menu.Create(new ContentMenu(1, "Сортировка по возрастанию:", new Classes.SortExpansion.MenuSort()));
            menu.Create(new ContentMenu(2, "Сортировка по убыванию:", new MenuSortDesc()));
            menu.Create(new ContentMenu(0, "Выход", new MenuExit()));

            return menu;
        }
    }
}