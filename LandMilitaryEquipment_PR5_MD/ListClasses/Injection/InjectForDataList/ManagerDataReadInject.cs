using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.InterfacesForOutput;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.SortExpansion;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList
{
    public class ManagerDataReadInject<T> : IDataListInject, ISoringOutput<T>
    {
        private readonly IDataOutputNullArgs _OutputNullArgs;
        private readonly IDataExpansionRead<T> _DataExpansionRead;

        private readonly List<T> _Obj;

        public ManagerDataReadInject(IDataOutputNullArgs dataOutputNullArgs, IDataExpansionRead<T> dataExpansionRead, List<T> obj) => 
            (_OutputNullArgs, _DataExpansionRead, _Obj) = (dataOutputNullArgs, dataExpansionRead, obj);
        
        public ManagerDataReadInject(IDataOutputNullArgs dataOutputNullArgs, IDataExpansionRead<T> dataExpansionRead) => 
            (_OutputNullArgs, _DataExpansionRead) = (dataOutputNullArgs, dataExpansionRead);

        public void Expansion()
        {
            foreach (var o in _Obj)
            {
                _OutputNullArgs.Output(_DataExpansionRead.Read(o));
            }
        }

        public void Output(List<T> list)
        {
            foreach (var obj in list)
            {
                _OutputNullArgs.Output(_DataExpansionRead.Read(obj));
            }
        }
    }
}