using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.Interfaces;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.SortExpansion
{
    public class SortLME : IMakeSortingList
    {
        public List<LandMilitaryEquipment> MakeList(ListDataLandMilitaryEquipment listData)
        {
            List<LandMilitaryEquipment> obj = listData.LandMilitaryEquipments
                .OrderBy(s => s.Title)
                .Select(s => s).ToList();
            return obj;
        }
    }
}
