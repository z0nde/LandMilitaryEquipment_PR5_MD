using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.Classes.OutputString
{
    public class OutLandMilitaryEquipment : IDataExpansionRead<LandMilitaryEquipment>
    {
        public string Read(LandMilitaryEquipment lme)
        {
            return $"Название: {lme!.Title}, " +
                $"Модель: {lme.Model}, " +
                $"Разработчик: {lme.Implementators}, " +
                $"Компания: {lme.Company}, " +
                $"Цена: {lme.Price}, " +
                $"Тип: {lme.Type}.";
        }
    }
}