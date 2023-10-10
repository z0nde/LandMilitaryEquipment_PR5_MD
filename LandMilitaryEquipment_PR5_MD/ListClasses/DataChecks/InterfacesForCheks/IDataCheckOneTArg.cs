namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks
{
    public interface IDataCheckOneTArg<T>
    {
        public T? Check(T obj);
    }
}