using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;
using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList
{
    public class ManagerDataDeleteInject<T> : IDataListInject
    {
        private readonly IDataCheckOneTArg<T> _DataCheckOneTArg;
        private readonly IDataExpansionFound<T, T> _DataFind;
        private readonly IDataExpansionDelete<T> _DataExpansionDelete;

        private readonly T _Obj;

        public ManagerDataDeleteInject(IDataCheckOneTArg<T> dataCheckOneTArg, IDataExpansionFound<T, T> dataFind,
            IDataExpansionDelete<T> dataExpansionDelete, T obj) =>
        (_DataCheckOneTArg, _DataFind, _DataExpansionDelete, _Obj) =
            (dataCheckOneTArg, dataFind, dataExpansionDelete, obj);

        public void Expansion()
        {
            if (_DataCheckOneTArg.Check(_Obj) != null)
                if (_DataFind.FoundObj(_Obj) != null)
                    _DataExpansionDelete.Delete(_DataFind.FoundObj(_Obj)!);
        }
    }
}