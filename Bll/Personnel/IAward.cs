using System;
using Model;
namespace Bll.Personnel
{
    public interface IAward
    {
        System.Data.DataTable GetAwards();
        void AddRecOfOrdinaryPost(string staffid, int year, int month);
        System.Data.DataTable GetRecOfOrdinaryPost(string staffid, int year, int month);
        void UpdateOrdinaryPost(OrdinaryPost obj);
        void AddRecOfSaleCounselor(string staffid, int year, int month);
        System.Data.DataTable GetRecOfSaleCounselor(string staffid, int year, int month);
        void UpdateSaleCounselor(SaleCounselor obj);
        int  AddRecOfSalary(Salary obj, int year, int month);
        void UpdateSalary(Salary obj);
        Salary GetSalaryOfOneStaff(string staffid, int year, int month);
        int AddRecOfSaleSupervior(string staffid, int year, int month);
        void UpdateSaleSupervior(SaleSupervior obj);
        System.Data.DataTable GetRecOfSaleSupervior(string staffid, int year, int month);
        void AddCarTrialRecord(CarTrialRecord obj);
        void UpdateCarTrialRecord(CarTrialRecord obj);
        System.Data.DataTable GetCarTrialRecord(int year, int month, string staffid,string organ);
        void DeleteCarTrialRecord(int id);
        System.Data.DataTable GetSalaryList(int year, int month, string inputman);
        int AddRecOfSaleCartrial(string staffid, int year, int month);
        System.Data.DataTable GetRecOfSaleCartrial(string staffid, int year, int month);
        void UpdateRecOfSaleCartrial(SaleCarTrial obj);
        int GetCountOfCarTrial(string staffid, int year, int month);

        //上牌及客服
        int AddRecOfPlateService(string staffid, int year, int month);
        System.Data.DataTable GetRecOfPlateService(string staffid, int year, int month);
        void UpdatePlateService(SalePlateService obj);

        int AddRecOfSaleFinance(string staffid, int year, int month);
        System.Data.DataTable GetRecOfSaleFinance(string staffid, int year, int month);
        void UpdateRecOfSaleFinance(SaleFinance obj);

        void UpdateSalaryDate(int year, int month);
        System.Data.DataTable GetSalaryDate();
        
        void UpdateSalaryBase(string staffid, decimal basicSalary, decimal assginRate, decimal insurance, decimal fund, decimal laborunit, decimal positionAllowance);
        System.Data.DataTable GetSalaryBases();
        System.Data.DataTable GetSalaryBaseByStaffID(string staffID);
        void DeleteSalaryInfo(string staffid, int year, int month);
    }
}
