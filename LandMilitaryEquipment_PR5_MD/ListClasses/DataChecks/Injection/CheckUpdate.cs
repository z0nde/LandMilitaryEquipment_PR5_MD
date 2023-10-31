using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.Injection;

public class CheckUpdate<T> : IDataCheckTwoTArgs<T>
{
    private readonly IUpdateCheckInject<T> _CheckDeleteElement;
    private readonly IUpdateCheckInject<T> _CheckAddElement;

    public CheckUpdate(IUpdateCheckInject<T> cDE, IUpdateCheckInject<T> cAE) =>
        (_CheckDeleteElement, _CheckAddElement) = (cDE, cAE);

    public object Check(T? foundRemoveAndAddData, T? newData)
    {
        if (_CheckDeleteElement.Check(foundRemoveAndAddData) != null!)
            if (_CheckAddElement.Check(newData) != null!)
                return newData;
        return null;
    }
}