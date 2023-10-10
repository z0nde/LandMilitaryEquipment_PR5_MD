using LandMilitaryEquipment_PR5_MD.Classes;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Create : IStrategyForController
    {
        public void StrategyCRUDForController()
        {
            /*string? switchControl;
            LandMilitaryEquipment landMilitaryEquipment = new();
            Console.Write("Введите назване: ");
            landMilitaryEquipment.Title = Console.ReadLine();
            Console.Write("Введите модель: ");
            landMilitaryEquipment.Model = Console.ReadLine();

            do
            {
                Console.WriteLine("Введите цифру для действия над Разработчиками. 1 - добавить, " +
                    "0 - закончить добавление ");
                switchControl = Console.ReadLine();

                switch (switchControl)
                {
                    case "1":
                        Console.WriteLine("Добавление");
                        Implementator implementator = new();
                        Console.Write("введите фамилию: ");
                        implementator.Surname = Console.ReadLine();
                        Console.Write("введите имя: ");
                        implementator.Name = Console.ReadLine();
                        Console.Write("введите отчество: ");
                        implementator.Patronymic = Console.ReadLine();
                        landMilitaryEquipment.Implementators.Create(implementator);
                        break;

                    case "0":
                        Console.WriteLine();
                        break;
                }
            } while (switchControl == "0");

            Console.Write("Введите компанию: ");
            landMilitaryEquipment.Company = Console.ReadLine();
            Console.Write("Введите цену: ");
            landMilitaryEquipment.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите тип: ");
            landMilitaryEquipment.Type = Console.ReadLine();

            Data.ListLME.Create(landMilitaryEquipment);*/
        }
    }
}