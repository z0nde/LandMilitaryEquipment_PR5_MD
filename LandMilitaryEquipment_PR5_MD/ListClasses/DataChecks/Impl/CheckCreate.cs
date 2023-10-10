using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.Impl
{
    public class CheckCreate : IDataCheckOneTArg<Implementator>
    {
        public Implementator? Check(Implementator obj)
        {
            if (obj != null)
            {
                if (obj.Surname != null && obj.Name != null && obj.Patronymic != null)
                {
                    if (obj.Surname != "" && obj.Name != "" && obj.Patronymic != "")
                    {
                        return obj;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}