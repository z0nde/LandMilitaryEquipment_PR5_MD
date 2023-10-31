using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.Impl
{
    public class Searching : IDataFind<Implementator>
    {
        public Implementator? Find(Implementator obj)
        {
            ListDataImplementator ldImpl = new();
            Implementator? newImpl = ldImpl.FoundObj(obj);
            if (newImpl != null)
            {
                return newImpl;
            }
            return null;
        }
    }
}