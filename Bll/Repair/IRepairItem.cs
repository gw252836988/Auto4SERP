using System;
using System.Data;
using Model;
namespace Bll.Repair
{
    public interface IRepairItem
    {
        System.Data.DataTable GetRepairTypes();
        DataTable GetRepairTypeByCode(string code);
        bool AddRootType(string typecode, string typename);
        void AddChildType(string ptypecode, string typename);
        void UpdateRepairType(string code, string typename);
        void DelType(string typecode);
        DataTable GetRepairItemsByCode(string typecode);
        void AddRepariItem(RepairItem obj);
        void UpdateRepairItem(RepairItem obj);
        void DeleteRepairItem(string itemcode);
        DataTable GetRepariItemBySpell(string spell);
        DataTable GetRepairItemsByQuery(string itemcode, string itemname);
        DataTable GetRepairItemAndPrice(string id);
        DataTable GetRepairItemByCode(string itemcode);
        DataTable GetRepairPriceByID(string id);
       

    }
}
