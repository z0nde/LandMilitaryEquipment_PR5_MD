using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;
using LandMilitaryEquipment_PR5_MD.MenuController.MenuItems;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus.DeleteSubMenu;

public class SubDelete : IMenu
{
    private readonly ListDataLandMilitaryEquipment _ListData;

    public SubDelete(ListDataLandMilitaryEquipment listData) =>
        _ListData = listData;
    
    public Menu ValidateMenu()
    {
        Menu menu = new();

        menu.Create(new ContentMenu(1, "Удалить одну технику", new ItemDelete(_ListData)));
        menu.Create(new ContentMenu(2, "Удалить весь список", new AllDelete(_ListData)));
        menu.Create(new ContentMenu(0, "Выход", new MenuExit()));
        
        return menu;
    }
}