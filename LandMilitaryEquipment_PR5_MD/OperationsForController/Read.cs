using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Read : IStrategyForController
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Read(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void StrategyCRUDForController()
        {
            
        }
    }
}