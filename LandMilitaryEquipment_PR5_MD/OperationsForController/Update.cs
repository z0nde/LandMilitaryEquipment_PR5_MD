using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Update : IStrategyForController
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Update(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void StrategyCRUDForController()
        {
            
        }
    }
}