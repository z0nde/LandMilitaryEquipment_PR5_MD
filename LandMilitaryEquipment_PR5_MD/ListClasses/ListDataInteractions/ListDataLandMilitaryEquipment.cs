using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.Interfaces;
using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions
{
    public class ListDataLandMilitaryEquipment :
        ICUDList<LandMilitaryEquipment>,
        IFound<LandMilitaryEquipment, LandMilitaryEquipment>,
        IDataExpansionCreate<LandMilitaryEquipment>,
        IDataExpansionUpdate<LandMilitaryEquipment>,
        IDataExpansionDelete<LandMilitaryEquipment>,
        IDataExpansionFound<LandMilitaryEquipment, LandMilitaryEquipment>
    {
        public List<LandMilitaryEquipment> LandMilitaryEquipments { get; private set; } = new ();

        public ListDataLandMilitaryEquipment()
        { }

        public void Create(LandMilitaryEquipment obj)
        {
            LandMilitaryEquipments.Add(obj);
        }

        public void Update(LandMilitaryEquipment foundRemoveAndAddData, LandMilitaryEquipment newData)
        {
            LandMilitaryEquipments.Remove(foundRemoveAndAddData);
            LandMilitaryEquipments.Add(newData);
        }

        public void Delete(LandMilitaryEquipment obj)
        {
            LandMilitaryEquipments.Remove(obj);
        }

        public LandMilitaryEquipment? FoundObj(LandMilitaryEquipment landMilitaryEquipment)
        {
            return LandMilitaryEquipments
                .Where(s => s.Title!.ToLower().Equals(landMilitaryEquipment.Title.ToLower()))
                //.Where(s => s.Title.ToLower() == landMilitaryEquipment.Title.ToLower())
                .Select(s => s)
                .FirstOrDefault();
        }
    }
}