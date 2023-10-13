using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.Interfaces;
using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions
{
    public class ListDataImplementator :
        ICRUDList<Implementator>,
        IFound<Implementator, Implementator>,
        IDataExpansionCreate<Implementator>,
        IDataExpansionRead<Implementator>,
        IDataExpansionUpdate<Implementator>,
        IDataExpansionDelete<Implementator>,
        IDataExpansionFound<Implementator, Implementator>
    {
        public List<Implementator> Implementators { get; set; } = new();

        public ListDataImplementator()
        { }

        public override string ToString()
        {
            string str = "";
            foreach (var impl in Implementators)
            {
                str += impl.ToString();
            }
            return str;
        }

        public void Create(Implementator obj)
        {
            Implementators.Add(obj);
        }

        public void Read()
        {
            foreach (var imple in Implementators)
            {
                Console.WriteLine(imple.ToString());
            }
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
                .Where(s => s.Surname!.ToLower() == implementator.Surname!.ToLower() && s.Name!.ToLower() == implementator.Name!.ToLower())
                .Select(s => s).FirstOrDefault();
        }
    }
}