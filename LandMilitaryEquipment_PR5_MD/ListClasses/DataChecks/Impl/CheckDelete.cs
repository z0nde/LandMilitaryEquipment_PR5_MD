using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.Impl
{
    public class CheckDelete : IDataCheckOneTArg<Implementator>
    {
        public Implementator? Check(Implementator obj)
        {
            if (obj != null)
            {
                if (obj.Surname != null && obj.Name != null)
                {
                    obj.Surname = obj.Surname.Replace(" ", "");
                    obj.Name = obj.Name.Replace(" ", "");
                    obj.Patronymic = obj.Patronymic.Replace(" ", "");

                    if (obj.Surname != "" && obj.Name != "")
                    {
                        return obj;
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