using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

namespace LandMilitaryEquipment_PR5_MD.OperationsForController
{
    public class Update : IStrategyForController
    {
        private readonly IUpdateInject _Delete;
        private readonly IUpdateInject _Add;

        public Update(IUpdateInject delete, IUpdateInject add) =>
            (_Delete, _Add) = (delete, add);

        public void Perform()
        {
            _Delete.Perform();
            _Add.Perform();
        }
    }
}