namespace LandMilitaryEquipment_PR5_MD.Interfaces
{
    public interface IFound<out T, in T1>
    {
        public T? FoundObj(T1 obj);
    }
}