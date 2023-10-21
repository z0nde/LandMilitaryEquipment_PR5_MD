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
    }
}