using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.LME;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.OutputString;
using LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Find : IStrategyForController
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Find(ListDataLandMilitaryEquipment listData) => _ListData = listData;
        
        public void Perform()
        {
            Console.Write("Введите название: ");
            string str = Console.ReadLine();
            LandMilitaryEquipment lME = new(str);
            CentralDataLandMilitaryEquipment centralData = new();
            centralData.Expansion(new ManagerDataFindInject
                (new CheckDelete(), new OutLandMilitaryEquipment(), new Output(), _ListData, lME));
        }
    }
}