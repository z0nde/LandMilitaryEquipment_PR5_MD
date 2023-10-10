using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Read : IStrategyForController
    {
        public void StrategyCRUDForController()
        {
            ListDataLandMilitaryEquipment listLME = new();
            listLME.Read();
        }
    }
}