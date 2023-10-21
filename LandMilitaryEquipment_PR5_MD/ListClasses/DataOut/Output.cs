using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.InterfacesForOutput;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.DataOut
{
    public class Output : IDataOutputNullArgs
    {
        void IDataOutputNullArgs.Output(string lme)
        {
            Console.WriteLine(lme);
        }
    }
}