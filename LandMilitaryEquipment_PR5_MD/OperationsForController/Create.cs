using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses;
using LandMilitaryEquipment_PR5_MD.ListClasses.InjectForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Create : IStrategyForController, IUpdateInject
    {
        private readonly ListDataLandMilitaryEquipment _ListData;

        public Create(ListDataLandMilitaryEquipment listData) => _ListData = listData;
        
        public void StrategyCRUDForController()
        {
            //LandMilitaryEquipment landMilitaryEquipment = new();
            Console.Write("Введите назавние: ");
            string? title = Console.ReadLine();
            Console.Write("Введите модель: ");
            string? model = Console.ReadLine();
            
            ListDataImplementator listDataImplementator = new();
            DependencyInjectionManagerMenu menu = new(new SubCreate(listDataImplementator), new Cycle());
            menu.MenuAssembly();

            Console.Write("Введите компанию: ");
            string? company = Console.ReadLine();
            Console.Write("Введите цену: ");
            string? price = Console.ReadLine();
            Console.Write("Введите тип: ");
            string? type = Console.ReadLine();
            LandMilitaryEquipment landMilitaryEquipment = 
                new(title, model, listDataImplementator, company, Convert.ToInt32(price), type);

            CentralDataLandMilitaryEquipment centralData = new();
            centralData.Expansion(new ManagerDataCreateInject<LandMilitaryEquipment>(new ListClasses.DataChecks.LME.CheckCreate(), _ListData, landMilitaryEquipment));
        }
    }
}