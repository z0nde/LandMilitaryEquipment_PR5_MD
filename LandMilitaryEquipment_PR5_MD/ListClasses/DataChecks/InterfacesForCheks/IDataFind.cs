namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks
{
    public interface IDataFind<T>
    {
        public T? Find(T obj);
    }
}