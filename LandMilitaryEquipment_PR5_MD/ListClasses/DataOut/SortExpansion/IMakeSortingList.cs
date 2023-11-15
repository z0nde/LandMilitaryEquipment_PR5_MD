using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.SortExpansion
{
    public interface IMakeSortingList
    {
        public List<LandMilitaryEquipment> MakeList(ListDataLandMilitaryEquipment listData);
    }
}