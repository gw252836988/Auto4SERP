using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Comm;
using DBUtil;
using System.Data;
namespace Bll.Sale
{
    public interface ICarSale
    {

        string GetDHOfAddCarOrder(List<SqlElement> lst);
        bool PostOrderAmount(double amount, string dh);
        DataTable GetCarOrdersByQuery(string strBegin, string strEnd, bool IsSelect, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount, string saler);
        string GetDHOfAddCarSale(List<SqlElement> lst);
        double BindOrderFromSale(string mobile, string dh);
        void RelieveOrderFromSale(string dh);
        //DataTable GetCarSalesOfDefault();
        DataTable GetCarSaleByDH(string dh);
        double GetOrderAmountByDH(string dh);
        bool IsOrderBinded(string mobile);
        bool PostToCheck(CarSale obj);
        int GetCarSaleStatus(string dh);
        void UpdateCarSaleStatus(string dh, int status,string checkman);
        DataTable  GetCarSalesByQuery(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount,bool isSaler);
        void UpdateCarSaleAmountPost(string dh, double amount);
        void UpdateCarOrderReceive(double amount, string dh);
        void UpdateCarSaleReceive(double amount, string dh);
        bool IsExistAmountOfPost(string dh);
        void CarSaleToBackNomal(string dh, string vin);
        DataTable GetPrintInfo(string dh,string carInfo);
        bool IsOrderBindedByDH(string dh);
        DataTable GetCarSalesOfMonth(string strBegin, string strEnd, int year, int month, string saler, string carser);
        void AddCarSaleDecorateDH(string dh, string decoratedh);
        double GetCarOrderJEByMobile(string mobile);

        bool DelCarOrder(string dh);
        bool DelCarSale(string dh);
        DataTable GetCarAnalysis(string strBegin, string strEnd, int year, int month, string saler, string carmodel);

        bool UpdateSaleManageDate(CarSale obj);
        int GetCountOfCarOutInMonth(int year, int month);
        int GetCountOfCarStockInMonth(int year, int month);
        DataTable  GetAmountOfOrderRecv(string dh);
        DataTable CarOrderByDH(string dh);
        void BindCarSaleToOrder(string orderdh,string saledh);
        bool CarOrderSaveAgain(string dh, List<SqlElement> lst);
        void ModifyCustNameOfOrder(string dh, string newname, string mobile, bool ism);
        void ModifyCustNameOfSale(string dh, string newname,string mobile,bool ism);
        void UpdateCarPurePrice(string dh, double pureprice, double decorprice);
        string GetDHOfAddCarAllot(List<SqlElement> lst);
        DataTable GetCarAllotsByQuery(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount);
        DataTable  GetCarAllot(string dh);
        void SetCarAllotStatus(string dh, int status);
        bool DelCarAllot(string dh);
        void ModifySalerOfCarSale(string dh, string newsaler);
        string CheckBuyFormHere(string mobile);
        DataTable GetOutCarOrdersByQuery(string strBegin, string strEnd, bool IsSelect, List<SqlElement> list, string saler);
        bool IsExistCarSaleInOrder(string dh);
        void ChangeTypeOfCarsale(string dh, string type);
        void CarSaleToBack(string dh, string vin);
        DataTable GetCarsByCategory(int year, string items);
        DataTable GetCarAveragePrice(string strBegin, string strEnd, int year, int month);
        void updateInsuranceJE(double insurance,double btprice,string dh);
        void CarSaleRwardToggle(int status, string dh);
       
    }
}
