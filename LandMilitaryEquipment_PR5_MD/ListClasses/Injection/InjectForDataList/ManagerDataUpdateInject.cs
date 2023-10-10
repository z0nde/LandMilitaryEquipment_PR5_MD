using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;
using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList
{
    public class ManagerDataUpdateInject<T> : IDataListInject
    {
        private readonly IDataCheckTwoTArgs<T> _DataCheckTwoTArgs;
        private readonly IDataFind<T> _DataFind;
        private readonly IDataExpansionUpdate<T> _DataExpansionUpdate;

        private readonly T _Obj;
        private readonly T _Obj1;

        public ManagerDataUpdateInject(IDataCheckTwoTArgs<T> dataCheckTwoTArgs, IDataFind<T> dataFind,
            IDataExpansionUpdate<T> dataExpansionUpdate, T obj, T obj1) =>
        (_DataCheckTwoTArgs, _DataFind, _DataExpansionUpdate, _Obj, _Obj1) = 
            (dataCheckTwoTArgs, dataFind, dataExpansionUpdate, obj, obj1);

        public void Expansion()
        {
            if (_DataCheckTwoTArgs.Check(_Obj, _Obj1) != null)
                if (_DataFind.Find(_Obj) != null)
                    _DataExpansionUpdate.Update(_DataFind.Find(_Obj)!, _Obj1);
        }
    }
}