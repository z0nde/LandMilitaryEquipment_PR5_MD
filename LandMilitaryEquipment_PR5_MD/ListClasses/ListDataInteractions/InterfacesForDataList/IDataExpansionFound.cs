﻿namespace LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList
{
    public interface IDataExpansionFound<out T, in T1>
    {
        public T? FoundObj(T1 obj);
    }
}