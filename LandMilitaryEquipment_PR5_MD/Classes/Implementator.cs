namespace LandMilitaryEquipment_PR5_MD.Classes
{
    public class Implementator
    {
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Patronymic { get; private set; }

        public Implementator(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Implementator);
        }

        public bool Equals(Implementator obj)
        {
            return obj != null &&
                   Surname == obj.Surname &&
                   Name == obj.Name &&
                   Patronymic == obj.Patronymic;
        }

        public override string ToString()
        {
            return $"Фамилия: {Surname}, Имя: {Name}, Отчество: {Patronymic}.";
        }
    }
}