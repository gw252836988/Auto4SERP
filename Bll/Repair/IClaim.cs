﻿using System;
using Model;
using System.Collections.Generic;
using System.Data;
namespace Bll.Repair
{
    public interface IClaim
    {
        void CreateClaimH(System.Collections.Generic.List<Model.SqlElement> lstm);
        DataTable GetClaimsOfQuery(List<SqlElement> list,string status,int index,string strBegin, string strEnd,bool isSelect, int PageIndex, int PageSize, out int RecordCount, out int PageCount);
        DataTable GetClaim(string id);
        void UpdateClaim(string dh, string claimdh, double itemamount, double accamount, double elseamount, double claimamount);
        void SetRepToClaim(string dh);
        void AccessClaim(string dh, double accessamount);
        string AddClaimBill(decimal allamount);
        void AddClaimBllD(string dh, List<string> lst);
        DataTable GetClaimDOfBill(string billdh);
        double GetAllAmountOfBill(string billdh);

        void DelClaimBllD(string dh, string repdh);
        void SetBillDHOfRep(string dh, string billdh);
        void UpdateStatusClaimBillH(int status,string dh);
        int GetStautsOfClaimBillH(string dh);
        DataTable GetClaimBills(string strBegin, string strEnd, List<SqlElement> list);
        bool DelClaimBill(string dh);
        DataTable  GetSumAccessAmountOfClaims(List<SqlElement> list, string status,int datetype, string strBegin, string strEnd, bool isSelect);
        double GetAmountOfClaimBillH(string dh);
        DataTable GetOutClaimsOfQuery(List<SqlElement> list, string status, int index,string strBegin, string strEnd, bool isSelect);
    }
}
