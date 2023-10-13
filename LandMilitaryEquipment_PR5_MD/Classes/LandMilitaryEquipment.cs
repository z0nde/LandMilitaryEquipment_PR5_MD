using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using System.Xml.Linq;

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

        public LandMilitaryEquipment(string title, string model, ListDataImplementator implementators, string company, double price, string type)
        {
            Title = title;
            Model = model;
            Implementators = implementators;
            Company = company;
            Price = price;
            Type = type;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as LandMilitaryEquipment);
        }

        public bool Equals(LandMilitaryEquipment obj)
        {
            return obj != null &&
                   Title == obj.Title &&
                   Model == obj.Model &&
                   Implementators == obj.Implementators &&
                   Company == obj.Company &&
                   Price == obj.Price &&
                   Type == obj.Type;
        }

        public override string ToString()
        {
            return $"Название: {Title}, Модель: {Model}, Разработчик: {Implementators}, Компания: {Company}, Цена: {Price}, Тип: {Type}.";
        }
    }
}