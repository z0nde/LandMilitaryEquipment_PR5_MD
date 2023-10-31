using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.LME
{
    public class CheckDelete : 
        IDataCheckOneTArg<LandMilitaryEquipment>,
        IUpdateCheckInject<LandMilitaryEquipment>
    {
        public LandMilitaryEquipment? Check(LandMilitaryEquipment obj)
        {
            if (obj != null)
            {
                if (obj.Title != null)
                {
                    if (obj.Title != "")
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