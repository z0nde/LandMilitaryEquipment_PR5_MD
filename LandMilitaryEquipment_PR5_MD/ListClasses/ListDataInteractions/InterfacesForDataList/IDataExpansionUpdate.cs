namespace LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList
{
    public interface IDataExpansionUpdate<T>
    {
        public void Update(T objRecording, T objClear);
    }
}