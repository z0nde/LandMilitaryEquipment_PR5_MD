using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList
{
    public class ManagerDataReadInject<T> : IDataListInject
    {
        private readonly IDataExpansionRead<T> _DataExpansionRead;

        public ManagerDataReadInject(IDataExpansionRead<T> dataExpansionRead) => 
            _DataExpansionRead = dataExpansionRead;

        public void Expansion()
        {
            _DataExpansionRead.Read();
        }
    }
}