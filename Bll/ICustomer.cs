using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
namespace Bll
{
    public interface ICustomer
    {

         bool AddCustomerOfCheckNone(string mobile);

         void UpdateBaseCustomerInfo(Customer o);

         Customer GetCustomerByMobile(string mobile);

         DataTable GetCustomersByQuery(List<SqlElement> lst,bool isVip, int PageIndex, int PageSize, out int RecordCount, out int PageCount);

       //  DataTable GetCustomersDefault();

         void DelCustomer(string mobile);

         void AddCarOfCustomer(Car o);

         DataTable GetCarOfCustomer(string mobile);

         Car GetCarByPlate(string plate);

         DataTable GetVipTypes();

         void UpdateVipType(string typeid, string cardno, string mobile);

         Customer GetCustomerByCardNo(string cardNo);

         void UpdateCarOfCustomer(Car o);

         void DelCarOfCustomer(string id);

         Car GetCarByID(string id);

         //DataTable GetCustomersOfCarByQuery(List<SqlElement> lst, int PageIndex, int PageSize, out int RecordCount, out int PageCount);

         bool IsCustomerExists(string mobile);

         DataTable GetCarsOfCustomerByQuery(List<SqlElement> lst);

         DataTable GetVipInfoOfLevel(string viplevel);
         DataTable GetAllVipTypes();

         string GetVinOfCustomer(string mobile);

         Customer GetCustomerByID(string id);
         void UpdateP2PMobile(string p2pmobile,string id);
         bool IsPlateNumExists(string platenum);
         DataTable GetCarByPalteNum(string platenum);
         bool IsPlateVinExists(string platenum);
         void ModifyPlateNumOfCar(string id, string platenum);
         void DelVinOfCar(string vin);
         DataTable GetVipInfoOfLevelByID(string viplevel);
         bool IsCarByPlateAndMobile(string plate, string mobile);
    }
}
