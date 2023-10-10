using LandMilitaryEquipment_PR5_MD.MenuController.MenuItems;

namespace LandMilitaryEquipment_PR5_MD.MenuController
{
    public class ValidationMenu : IMenu
    {
        public Menu ValidateMenu()
        {
            Menu menu = new();

            menu.Create(new ContentMenu(1, "Добавление", new MenuCreate()));
            menu.Create(new ContentMenu(2, "Просмотр", new MenuRead()));
            menu.Create(new ContentMenu(3, "Изменение", new MenuUpdate()));
            menu.Create(new ContentMenu(4, "Удаление", new MenuDelete()));
            menu.Create(new ContentMenu(5, "Сортировка", new MenuSort()));
            menu.Create(new ContentMenu(6, "Поиск", new MenuFind()));
            menu.Create(new ContentMenu(0, "Выход", new MenuExit()));

            return menu;
        }
    }
}