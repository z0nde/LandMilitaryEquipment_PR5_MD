﻿using LandMilitaryEquipment_PR5_MD.Classes;
using LandMilitaryEquipment_PR5_MD.Interfaces;
using LandMilitaryEquipment_PR5_MD.ListClasses.InterfacesForDataList;

namespace LandMilitaryEquipment_PR5_MD.ListClasses.ListDataInteractions
{
    public class ListDataLandMilitaryEquipment :
        ICRUDList<LandMilitaryEquipment>,
        IFound<LandMilitaryEquipment, LandMilitaryEquipment>,
        IDataExpansionCreate<LandMilitaryEquipment>,
        IDataExpansionRead<LandMilitaryEquipment>,
        IDataExpansionUpdate<LandMilitaryEquipment>,
        IDataExpansionDelete<LandMilitaryEquipment>,
        IDataExpansionFound<LandMilitaryEquipment, LandMilitaryEquipment>,
        IDataExpansionSorting
    {
        private List<LandMilitaryEquipment> LandMilitaryEquipments { get; set; } = new ();

        public ListDataLandMilitaryEquipment()
        { }

        public override string ToString()
        {
            string str = "";
            foreach (var equip in LandMilitaryEquipments)
            {
                str += equip.ToString();
            }
            return str;
        }

        public void Create(LandMilitaryEquipment obj)
        {
            LandMilitaryEquipments.Add(obj);
        }

        public void Read()
        {
            foreach (var equip in LandMilitaryEquipments)
            {
                Console.WriteLine(equip.ToString());
            }
        }

        public void Update(LandMilitaryEquipment foundRemoveAndAddData, LandMilitaryEquipment newData)
        {
            LandMilitaryEquipments.Remove(foundRemoveAndAddData);
            foundRemoveAndAddData.Title = newData.Title;
            foundRemoveAndAddData.Model = newData.Model;
            foundRemoveAndAddData.Implementators = newData.Implementators;
            foundRemoveAndAddData.Company = newData.Company;
            foundRemoveAndAddData.Price = newData.Price;
            foundRemoveAndAddData.Type = newData.Type;
            LandMilitaryEquipments.Add(foundRemoveAndAddData);
        }

        public void Delete(LandMilitaryEquipment obj)
        {
            LandMilitaryEquipments.Remove(obj);
        }

        public LandMilitaryEquipment? FoundObj(LandMilitaryEquipment landMilitaryEquipment)
        {
            return LandMilitaryEquipments
                .Where(s => s.Title!.ToLower() == landMilitaryEquipment.Title!.ToLower())
                .Select(s => s).FirstOrDefault();
        }

        public void Sorting(ITransaction transaction)
        {
            transaction.Transaction();
        }
    }
}