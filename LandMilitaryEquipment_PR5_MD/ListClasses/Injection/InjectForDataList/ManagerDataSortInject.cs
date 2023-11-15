using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.SortExpansion;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList
{
    public class ManagerDataSortInject : IDataListInject
    {
        private readonly ListDataLandMilitaryEquipment _ListData;
        private readonly IMakeSortingList _SortingList;
        private readonly ISoringOutput<LandMilitaryEquipment> _Output;

        public ManagerDataSortInject(ListDataLandMilitaryEquipment listData, IMakeSortingList sortingList, ISoringOutput<LandMilitaryEquipment> output) => 
            (_ListData, _SortingList, _Output) = 
            (listData, sortingList, output); 

        public void Expansion()
        {
            _Output.Output(_SortingList.MakeList(_ListData));
        }
    }
}