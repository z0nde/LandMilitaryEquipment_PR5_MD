using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.OutputString;
using LandMilitaryEquipment_PR5_MD.ListClasses;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut;
using LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Read : IStrategyForController
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Read(ListDataLandMilitaryEquipment listData) => _ListData = listData;

        public void Perform()
        {
            CentralDataLandMilitaryEquipment centralData = new();
            centralData.Expansion(new ManagerDataReadInject<LandMilitaryEquipment>(new Output(), new OutLandMilitaryEquipment(), _ListData.LandMilitaryEquipments));
        }
    }
}