﻿using System;
using System.Data;
using Model;
using System.Collections.Generic;
namespace Bll.Repair
{
    public interface IRepair
    {
        string GetDHOfAddRepair(Model.RepairM obj);
        void AddItemOfRepair(string dh, string itemcode, string priceid);
        DataTable GetItemsOfDH(string dh);
        void UpdateItemOfRepair(string dh, string xh, string itemcode, int priceid);
        void UpdateRepair(RepairM obj);
        void DeleteItemOfRepair(string dh, string xh);
        DataTable GetRepairs(List<SqlElement> list, string saleman, int PageIndex, int PageSize, out int RecordCount, out int PageCount);
        RepairM GetRepairByDH(string dh);
        DataTable GetPlatesByMobile(string mobile);
        DataTable GetItemsOfDHInTake(string dh);
        DataTable GetRepsOfTake(string plate, string dh, string vin, string custname, int type);
        float GetItemAmountOfDH(string dh);
        float GetAccAmountOfDH(string dh);
        void SetRepStatus(RepairM obj);
        DataTable GetRepairsOfQuery(List<SqlElement> mLstE, int datesel, string dtBegin, string dtEnd, List<string> lstStatus, int PageIndex, int PageSize, out int RecordCount, out int PageCount);
        void UpdateRepairItemPrice(string dh, string xh, string itemcode, string carlevel);
        void UpdateRepairItemOfModel(repair_iM obj);
        void AddItemOfRepairEx(repair_iM obj);
        float GetAccDemandAmountOfDH(string dh);
        DataTable GetSaleDecorates(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount);
        bool DelRepair(string dh);
        bool IsTakeAll(string dh);
        void SetRepTakeAllFlag(string dh);
        void UpdatePriceOfRepairItem(repair_iM obj);
        DataTable STEmpWorkHour(string dtBegin, string dtEnd, string workman, string itemname);
        DataTable GetSumWHofQuery(string dtBegin, string dtEnd, string workman, string itemname);
        float GetForeAccAmountOfDH(string dh);
        bool IsDiscountOfDH(string dh);
        DataTable GetRepsOfClaim();
        float GetForeItemAmountOfDH(string dh);
        float GetInPriceOfDH(string dh);
        DataTable GetSumRepairsOfQuery(List<SqlElement> mLstE, int datesel, string dtBegin, string dtEnd, List<string> lstStatus);
        string GetPVOfRepair(int year, int month,bool isrepair,bool isclaim,bool iszh);
        DataTable GetRepairsByPlate(string plate);
        DataTable GetLoyalCustomers(string b,string e,int c);
      
        void ModifyCustNameOfRepair(string dh, string newname);
        decimal GetAccInPriceOfDH(string dh);
        void UpdateSumDataOfRepair(string dh, float accamount, float itemamount, decimal ginprice);
        DataTable GetSumOfRepProfits(string strBegin, string strEnd, int year, int month);
        DataTable GetAccidentProfits(string strBegin, string strEnd, int min, int max, string inname, string cometype);
        string GetLastInMil(string palte, string indate);
        DataTable GetRepairsOfOut(string strBegin, string strEnd, string platenum, string outtype, int PageIndex, int PageSize, out int RecordCount, out int PageCount);
        void SetRepOut(string dh);
        void ExtractClaimsFromReps();
        string GetCustType(string plate);
        DataTable GetReceptReport(string strbegin, string strend);
        decimal GetKeepAccValue(string strbegin, string strend, string receptman);
        decimal GetJeOfYQ(string dh);
        decimal GetJeOfGS(string dh);
        bool IsAllfWorkerAdded(string dh);
        DataTable GetOutRepairsOfQuery(List<SqlElement> mLstE, int datesel, string dtBegin, string dtEnd, List<string> lstStatus);
        DataTable GetRepairsOfQuery1(List<SqlElement> mLstE, int datesel, string dtBegin, string dtEnd, List<string> lstStatus, int PageIndex, int PageSize, out int RecordCount, out int PageCount);
        decimal GetYQCost(string strBegin, string strEnd, string staffname, string inname, string comtype);
        DataTable GetRepInCompany(string strBegin, string strEnd);
        DataTable GetRepType(string strBegin, string strEnd);
        DataTable GetLostCustomers(int months);
        decimal GetYQCost1(string strBegin, string strEnd, string staffname,int year, int month, bool issg, string RepChildType, string receptor);
        void ExtractClaimFromRep(string dh,decimal accessamount);
        DataTable GetRepProfits(string strBegin, string strEnd, int year, int month, bool issg, string RepChildType, string receptor, bool iszh,string plate);
        decimal GetProfitOfZh(string saledh);
        void ReAccount(double account, string dh);
        void CalculateDecorateCost(string saleDH, string vin, decimal PresentDecorPrice);
       
    }
}
