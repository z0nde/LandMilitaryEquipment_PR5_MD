using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataChecks.InterfacesForCheks;
using LandMilitaryEquipment_PR5_MD.ListClasses.DataOut.InterfacesForOutput;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;
using LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.Injection.InjectForDataList;

public class ManagerDataFindInject : IDataListInject
{
    private readonly IUpdateCheckInject<LandMilitaryEquipment> _CheckFindElement;
    private readonly IDataExpansionRead<LandMilitaryEquipment> _ConvertStr;
    private readonly IDataOutputNullArgs _Output;
    private readonly ListDataLandMilitaryEquipment _ListData;
    private readonly LandMilitaryEquipment _Obj;

    public ManagerDataFindInject(IUpdateCheckInject<LandMilitaryEquipment> check, IDataExpansionRead<LandMilitaryEquipment> convertStr, 
        IDataOutputNullArgs output, ListDataLandMilitaryEquipment listData, LandMilitaryEquipment obj) => 
        (_CheckFindElement, _ConvertStr, _Output, _ListData, _Obj) = (check, convertStr, output, listData, obj);

    public void Expansion()
    {
        if (_CheckFindElement.Check(_Obj) != null)
            _Output.Output(_ConvertStr.Read(_ListData.FoundObj(_Obj))); 
    }
}