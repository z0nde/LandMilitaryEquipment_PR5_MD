using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.Impl
{
    public class CheckUpdate : IDataCheckTwoTArgs<Implementator>
    {
        public Implementator? Check(Implementator foundRemoveAndAddData, Implementator newData)
        {
            if (foundRemoveAndAddData != null && newData != null)
            {
                if (foundRemoveAndAddData.Surname != null && foundRemoveAndAddData.Name != null &&
                    newData.Surname != null && newData.Name != null && newData.Patronymic != null)
                {
                    if (foundRemoveAndAddData.Surname != "" && foundRemoveAndAddData.Name != "" &&
                        newData.Surname != "" && newData.Name != "")
                    {
                        return foundRemoveAndAddData;
                    }
                    else
                    {
                        Console.WriteLine("Введите корректное имя и/или фамилию");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("Введите корректное имя и/или фамилию");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Объект оказался путсым.");
                return null;
            }
        }
    }
}