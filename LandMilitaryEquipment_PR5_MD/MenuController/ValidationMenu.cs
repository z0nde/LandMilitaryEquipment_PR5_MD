using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController.MenuItems;

namespace LandMilitaryEquipment_PR5_MD.MenuController
{
    public class ValidationMenu : IMenu
    {
        private readonly ListDataLandMilitaryEquipment _ListData;
        public ValidationMenu(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public Menu ValidateMenu()
        {
            Menu menu = new();

            menu.Create(new ContentMenu(1, "Добавление", new MenuCreate(_ListData)));
            menu.Create(new ContentMenu(2, "Просмотр", new MenuRead(_ListData)));
            menu.Create(new ContentMenu(3, "Изменение", new MenuUpdate(_ListData)));
            menu.Create(new ContentMenu(4, "Удаление", new MenuDelete(_ListData)));
            menu.Create(new ContentMenu(5, "Сортировка", new MenuSort(_ListData)));
            menu.Create(new ContentMenu(6, "Поиск", new MenuFind(_ListData)));
            menu.Create(new ContentMenu(0, "Выход", new MenuExit()));

            return menu;
        }
    }
}