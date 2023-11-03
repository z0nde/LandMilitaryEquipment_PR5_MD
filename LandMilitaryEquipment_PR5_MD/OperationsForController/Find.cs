using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Find : IStrategyForController
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Find(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void Perform()
        {
            
        }
    }
}