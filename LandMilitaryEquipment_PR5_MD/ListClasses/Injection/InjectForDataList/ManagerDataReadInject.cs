using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.InterfacesForOutput;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList
{
    public class ManagerDataReadInject<T> : IDataListInject
    {
        private readonly IDataOutputNullArgs _OutputNullArgs;
        private readonly IDataExpansionRead<T> _DataExpansionRead;

        private readonly List<T> _Obj;

        public ManagerDataReadInject(IDataOutputNullArgs dataOutputNullArgs, IDataExpansionRead<T> dataExpansionRead, List<T> obj) => 
            (_OutputNullArgs, _DataExpansionRead, _Obj) = (dataOutputNullArgs, dataExpansionRead, obj);

        public void Expansion()
        {
            foreach (var o in _Obj)
            {
                _OutputNullArgs.Output(_DataExpansionRead.Read(o));
            }
        }
    }
}