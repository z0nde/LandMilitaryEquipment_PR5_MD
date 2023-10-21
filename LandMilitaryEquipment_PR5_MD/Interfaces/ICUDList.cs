namespace LandMilitaryEquipment_PR5_MD.Interfaces
{
    public interface ICUDList<T> where T : class
    {
        public void Create(T obj);
        public void Update(T objRecording, T objClear);
        public void Delete(T objClear);
    }
}