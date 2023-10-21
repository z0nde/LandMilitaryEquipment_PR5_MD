using LandMilitaryEquipment_PR5_MD.Classes;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList
{
    public interface IDataExpansionRead<T>
    {
        public string Read(T o);
    }
}