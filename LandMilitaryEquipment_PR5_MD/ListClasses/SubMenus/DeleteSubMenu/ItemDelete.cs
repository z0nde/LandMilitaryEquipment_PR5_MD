using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.LME;
using LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;
using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus.DeleteSubMenu;

public class ItemDelete : IExpansion, IUpdateInject
{
    private ListDataLandMilitaryEquipment _ListData;

    public ItemDelete(ListDataLandMilitaryEquipment listData) => 
        _ListData = listData;

    public void Perform()
    {
        Console.Write("Введите название техники: ");
        string title = Console.ReadLine();
        LandMilitaryEquipment lme = new(title);
        CentralDataLandMilitaryEquipment centralData = new();
        centralData.Expansion(new ManagerDataDeleteInject<LandMilitaryEquipment>(new CheckDelete(), _ListData, _ListData, lme));
    }
}