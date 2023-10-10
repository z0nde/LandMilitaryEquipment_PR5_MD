using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;
using LandMilitaryEquipment_PR5_MD.ListClasses.Injection;
using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.InjectForDataList
{
    public class ManagerDataCreateInject<T> : IDataListInject
    {
        private readonly IDataCheckOneTArg<T> _DataCheckCreate;
        private readonly IDataExpansionCreate<T> _DataExpansionCreate;

        private readonly T _Obj;

        public ManagerDataCreateInject(IDataExpansionCreate<T> dataExpansionCreate, IDataCheckOneTArg<T> dataCheckCreate, T obj) =>
            (_DataExpansionCreate, _DataCheckCreate, _Obj) = (dataExpansionCreate, dataCheckCreate, obj);

        public void Expansion()
        {
            if (_DataCheckCreate.Check(_Obj) != null)
                _DataExpansionCreate.Create(_Obj);
        }
    }
}