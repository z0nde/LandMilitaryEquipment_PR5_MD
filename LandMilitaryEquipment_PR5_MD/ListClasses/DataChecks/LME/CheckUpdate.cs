using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.LME
{
    public class CheckUpdate : IDataCheckTwoTArgs<LandMilitaryEquipment>
    {
        public LandMilitaryEquipment? Check(LandMilitaryEquipment foundRemoveAndAddData, LandMilitaryEquipment newData)
        {
            if (foundRemoveAndAddData != null && newData != null)
            {
                if (foundRemoveAndAddData.Title != null && newData.Title != null)
                {
                    if (foundRemoveAndAddData.Title != "" && newData.Title != "")
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