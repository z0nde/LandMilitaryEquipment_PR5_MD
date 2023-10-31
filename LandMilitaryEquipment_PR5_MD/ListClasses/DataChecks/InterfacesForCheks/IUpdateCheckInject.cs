namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;

public interface IUpdateInject<T>
{
    public T Check(T obj);
}