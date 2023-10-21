namespace LandMilitaryEquipment_PR5_MD.ListClasses
{
    public class CentralDataImplementator
    {
        public void Expansion(Injection.IDataListInject dataListInject)
        {
            if (dataListInject != null)
                dataListInject.Expansion();
        }
    }
}