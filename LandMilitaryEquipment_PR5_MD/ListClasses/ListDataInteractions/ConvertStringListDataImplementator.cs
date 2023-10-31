using System.Text;
using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.Classes.OutputString;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions;

public class ConvertStringListDataImplementator
{
    public string ToString(List<Implementator> implementators)
    {
        OutImplementator outImplementator = new();
        StringBuilder stringBuilder = new StringBuilder();
        int i = 0;
        foreach (var impl in implementators)
        {
            i++;
            stringBuilder.Append($"{i}: ");
            stringBuilder.Append(outImplementator.Read(impl));
            stringBuilder.Append(' ');
        }
        return stringBuilder.ToString();
    }
}