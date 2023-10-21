using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.Classes.OutputString
{
    public class OutImplementator : IDataExpansionRead<Implementator>
    {
        public string Read(Implementator impl)
        {
            return $"Фамилия: {impl.Surname}, " +
                $"Имя: {impl.Name}, " +
                $"Отчество: {impl.Patronymic}.";
        }
    }
}