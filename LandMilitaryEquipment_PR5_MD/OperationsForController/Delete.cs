using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses;
using System.Threading.Tasks.Dataflow;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Delete : IStrategyForController
    {
        public void StrategyCRUDForController()
        {
            /*LandMilitaryEquipment landMilitaryEquipment = new();
            Implementator implementator = new();

            Console.WriteLine("Введите цифру, для удаления. 1 - Удалить всё, " +
                "2 - удалить разработчика у военной техники, 0 - выход из удаления");
            string? control = Console.ReadLine();
            switch (control)
            {
                case "1":
                    Console.Write("Введите название военной техники: ");
                    landMilitaryEquipment.Title = Console.ReadLine();
                    Data.ListLME.Delete(landMilitaryEquipment);
                    break;

                case "2":
                    Console.Write("Введите название военной техники: ");
                    landMilitaryEquipment.Title = Console.ReadLine();
                    var obj = Data.ListLME.FoundObj(landMilitaryEquipment);
                    if (obj != null)
                    {
                        Data.ListLME.Delete(landMilitaryEquipment);
                        Console.Write("введите фамилию: ");
                        implementator.Surname = Console.ReadLine();
                        Console.Write("введите имя: ");
                        implementator.Name = Console.ReadLine();
                        obj.Implementators.Delete(implementator);
                        Data.ListLME.Create(obj);

                    }
                    else
                        Console.WriteLine("Техника не найдена.");
                    break;
                case "0":
                    Console.WriteLine("Выход из удаления.");
                    break;
            }*/
        }
    }
}