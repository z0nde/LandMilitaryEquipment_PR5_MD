namespace LandMilitaryEquipment_PR5_MD.Interfaces
{
    public interface ICRUDList<T> where T : class
    {
        public void Create(T obj);
        public void Read();
        public void Update(T objRecording, T objClear);
        public void Delete(T objClear);
    }
}