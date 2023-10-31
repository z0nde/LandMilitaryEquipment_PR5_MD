using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.LME;
using LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus.DeleteSubMenu;

public class ItemDelete : IExpansion
{
    private IDataExpansionDelete<LandMilitaryEquipment> _ListData;

    public ItemDelete(IDataExpansionDelete<LandMilitaryEquipment> listData) => 
        _ListData = listData;

    public void Perform()
    {
        Console.Write("Введите название техники: ");
        string title = Console.ReadLine();
        LandMilitaryEquipment lme = new(title);
        CentralDataLandMilitaryEquipment centralData = new();
        centralData.Expansion(new ManagerDataDeleteInject<LandMilitaryEquipment>(new CheckDelete(), new Searching(), _ListData, lme));
    }
}