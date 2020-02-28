using System;
using Model;
using System.Data;
namespace Bll.Repair
{
    public interface IRepairAccessory
    {
       int AddAccessoryOfRepair(AccessoryOfRep obj);
        void AddAccessoryOfRepair(AccessoryOfRep obj, string dh, decimal amount, int wareid, string outtype);
        //DataTable GetAccessorysOfRepair(string dh);
        DataTable GetAccessorysOfRepairAsTake(string dh);
        AccessoryOfRep GetAccessoryOfRep(string xh, string dh);
        void UpdateAccessoryOfRepair(AccessoryOfRep obj);
        DataTable GetAccessorysOfRepairAsDemand(string dh);
        void DelAccessoryDemand(string dh, string xh);
        DataTable GetAccessorysOfRepairAsRep(string dh);
        string GetQueryStrOfDemmand(string dh);
        DataTable GetAccessorysOfTakePrint(string dh, string batchid);
        DataTable AccNegativeOut(string acccode, decimal amount);
        int UpdateBatchID(string dh);
        decimal IsCanRecede(string dh, int xh, string acccode, double amount);
        void AddAccNavInfo(string acccode, double inprice, string housename);
        DataTable GetZHOutDemandsAndTakes(int index, string strBegin, string strEnd, int type);
    }
}
