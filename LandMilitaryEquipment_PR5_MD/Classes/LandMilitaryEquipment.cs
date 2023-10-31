using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.Classes
{
    public class LandMilitaryEquipment
    {
        public string Title { get; private set; }
        public string Model { get; private set; }
        public ListDataImplementator Implementators { get; private set; } = new();
        public string Company { get; private set; }
        public double Price { get; private set; }
        public string Type { get; private set; }

        public LandMilitaryEquipment(string title) => Title = title;
        
        public LandMilitaryEquipment(string title, string model, ListDataImplementator implementators, string company, double price, string type)
        {
            Title = title;
            Model = model;
            Implementators = implementators;
            Company = company;
            Price = price;
            Type = type;
        }
    }
}