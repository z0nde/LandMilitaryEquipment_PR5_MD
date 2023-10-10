namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks
{
    public interface IDataCheckTwoTArgs<T>
    {
        public T? Check(T obj, T obj1);
    }
}