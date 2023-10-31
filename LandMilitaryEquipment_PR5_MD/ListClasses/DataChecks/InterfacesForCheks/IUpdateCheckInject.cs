namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;

public interface IUpdateCheckInject<T>
{
    public T Check(T obj);
}