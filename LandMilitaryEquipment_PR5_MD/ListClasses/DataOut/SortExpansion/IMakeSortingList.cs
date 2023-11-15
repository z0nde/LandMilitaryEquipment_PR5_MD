using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.SortExpansion
{
    public interface IOutputSorting
    {
        public List<LandMilitaryEquipment> OutData(ListDataLandMilitaryEquipment listData);
    }
}