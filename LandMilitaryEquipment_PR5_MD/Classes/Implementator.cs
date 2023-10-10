namespace LandMilitaryEquipment_PR5_MD.Classes
{
    public class Implementator
    {
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }

        public Implementator()
        { }

        public override string ToString()
        {
            return $"Фамилия: {Surname}, Имя: {Name}, Отчество: {Patronymic}.";
        }
    }
}