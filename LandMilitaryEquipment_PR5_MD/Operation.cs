using LandMilitaryEquipment_PR5_MD.OperationsForController;

namespace LandMilitaryEquipment_PR5_MD
{
    public class Operation
    {
        public void Action(IStrategyForController strategy)
        {
            if (strategy != null!)
            {
                strategy.Perform();
            }
        }
    }
}