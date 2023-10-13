using LandMilitaryEquipment_PR5_MD.Interfaces;
using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList
{
    public class ManagerDataSortInject : IDataListInject
    {
        private readonly IDataExpansionSorting _DataExpansionSorting;
        private readonly ITransaction _Transaction;

        public ManagerDataSortInject(IDataExpansionSorting dataExpansionSorting, ITransaction transaction) => 
            (_DataExpansionSorting, _Transaction) = 
            (dataExpansionSorting, transaction);

        public void Expansion()
        {
            _DataExpansionSorting.Sorting(_Transaction);
        }
    }
}