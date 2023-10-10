using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.LME
{
    public class Searching : IDataFind<LandMilitaryEquipment>
    {
        public LandMilitaryEquipment? Find(LandMilitaryEquipment obj)
        {
            ListDataLandMilitaryEquipment ldLME = new();
            LandMilitaryEquipment? newEquip = ldLME.FoundObj(obj);
            if (newEquip != null)
            {
                return newEquip;
            }
            else
            {
                Console.WriteLine("По вашему запросу ничего не найдено.");
                return null;
            }
        }
    }
}