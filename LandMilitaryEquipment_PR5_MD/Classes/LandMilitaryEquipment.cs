using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.Classes
{
    public class LandMilitaryEquipment
    {
        public string? Title { get; set; }
        public string? Model { get; set; }
        public ListDataImplementator Implementators { get; set; }
        public string? Company { get; set; }
        public double Price { get; set; }
        public string? Type { get; set; }

        public LandMilitaryEquipment()
        {
            Implementators = new ();
        }

        public override string ToString()
        {
            return $"Название: {Title}, Модель: {Model}, Разработчик: {Implementators}, Компания: {Company}, Цена: {Price}, Тип: {Type}.";
        }
    }
}