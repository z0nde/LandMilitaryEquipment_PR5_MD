using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus.DeleteSubMenu;

public class AllDelete : IExpansion
{
    private ListDataLandMilitaryEquipment _ListData;

    public AllDelete(ListDataLandMilitaryEquipment listData) =>
        _ListData = listData;

    public void Perform()
    {
        foreach (var lme in _ListData.LandMilitaryEquipments.ToList())
        {
            _ListData.Delete(lme);
        }
    }
}