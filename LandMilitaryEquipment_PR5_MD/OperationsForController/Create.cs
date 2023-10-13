using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Create : IStrategyForController
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Create(ListDataLandMilitaryEquipment listData) => _ListData = listData;
        
        public void StrategyCRUDForController()
        {

        }
    }
}