using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.Impl;
using LandMilitaryEquipment_PR5_MD.ListClasses.InjectForDataList;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.MenuController;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.SubMenus.CreateSubMenu
{
    public class ItemCreate : IExpansion
    {
        private readonly ListDataImplementator _ListDataImplementator;

        public ItemCreate(ListDataImplementator impls) => _ListDataImplementator = impls;

        public void Perform()
        {
            Console.Write("Введите фамилию: ");
            string? surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string? name = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string? patronymic = Console.ReadLine();

            Implementator impl = new(surname, name, patronymic);
            CentralDataImplementator centralData = new();
            centralData.Expansion(new ManagerDataCreateInject<Implementator>(new CheckCreate(), _ListDataImplementator, impl));
        }
    }
}