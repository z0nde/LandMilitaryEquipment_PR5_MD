using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.LME;
using LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Delete : IStrategyForController
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Delete(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void StrategyCRUDForController()
        {
            //LandMilitaryEquipment landMilitaryEquipment = new();
            //CentralDataLandMilitaryEquipment centralData = new();
            //centralData.Expansion(new ManagerDataDeleteInject<LandMilitaryEquipment>(new CheckDelete(), new Searching(), _ListData, landMilitaryEquipment));
        }
    }
}