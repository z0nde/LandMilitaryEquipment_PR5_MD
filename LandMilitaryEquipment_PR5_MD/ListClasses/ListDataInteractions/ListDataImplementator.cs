using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.Interfaces;
using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions
{
    public class ListDataImplementator :
        ICUDList<Implementator>,
        IFound<Implementator, Implementator>,
        IDataExpansionCreate<Implementator>,
        IDataExpansionUpdate<Implementator>,
        IDataExpansionDelete<Implementator>,
        IDataExpansionFound<Implementator, Implementator>
    {
        public List<Implementator> Implementators { get; private set; } = new();

        public ListDataImplementator()
        { }

        public void Create(Implementator obj)
        {
            Implementators.Add(obj);
        }

        public void Update(Implementator foundRemoveAndAddData, Implementator newData)
        {
            Implementators.Remove(foundRemoveAndAddData);
            Implementators.Add(newData);
        }

        public void Delete(Implementator obj)
        {
            Implementators.Remove(obj);
        }

        public Implementator? FoundObj(Implementator implementator)
        {
            return Implementators
                .Where(s => s.Surname!.ToLower().Equals(implementator.Surname.ToLower()) && 
                    s.Name!.ToLower().Equals(implementator.Name.ToLower()))
                .Select(s => s).FirstOrDefault();
        }
    }
}