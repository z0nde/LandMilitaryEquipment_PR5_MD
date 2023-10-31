using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.LME
{
    public class CheckCreate : 
        IDataCheckOneTArg<LandMilitaryEquipment>, 
        IUpdateCheckInject<LandMilitaryEquipment>
    {
        public LandMilitaryEquipment? Check(LandMilitaryEquipment obj)
        {
            if (obj != null)
            {
                if (obj.Title != null && obj.Model != null && obj.Implementators != null && 
                    obj.Company != null && obj.Type != null)
                {
                    if (obj.Title != "" && obj.Model != ""  && obj.Company != "" && 
                        obj.Price > 0 && obj.Type != "")
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