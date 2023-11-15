using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.OutputString
{
    public class OutLandMilitaryEquipment : IDataExpansionRead<LandMilitaryEquipment>
    {
        public string Read(LandMilitaryEquipment lme)
        {
            ConvertStringListDataImplementator impl = new();
            
            return $"Название: {lme.Title}, " +
                $"Модель: {lme.Model}, " +
                $"Разработчик(и): {impl.ToString(lme.Implementators.Implementators)}, " +
                $"Компания: {lme.Company}, " +
                $"Цена: {lme.Price}, " +
                $"Тип: {lme.Type}.";
        }
    }
}