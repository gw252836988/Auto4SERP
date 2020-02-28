﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtil;
using Comm;
using System.Data;
using Model;
using System.Data.SqlClient;
namespace Bll.Repair
{
   public class RepairBll : Bll.Repair.IRepair
    {
        private DBHelper mDB;

        public RepairBll()
        {
            mDB = DBHelperShare.getInstance();
        }

        public string GetDHOfAddRepair(RepairM obj)
        {
            string sql;
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("Mobile", obj.Mobile, true));
            lst.Add(new SqlElement("PlateNum", obj.PlateNum, true));
            lst.Add(new SqlElement("Status", "0", false));
            lst.Add(new SqlElement("RepType", obj.RepType, true));
            lst.Add(new SqlElement("RepChildType", obj.RepChildType, true));
            lst.Add(new SqlElement("ReceptMan", obj.ReceptMan, true));
            lst.Add(new SqlElement("CustName", obj.CustName, true));
            lst.Add(new SqlElement("Vin", obj.Vin, true));
            lst.Add(new SqlElement("CarModel", obj.CarModel, true));
            lst.Add(new SqlElement("DH", "dbo.GetRepairDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", false));
            lst.Add(new SqlElement("CardNo", obj.CardNo, true));
            lst.Add(new SqlElement("VipLevel", obj.VipLevel, true));
            lst.Add(new SqlElement("DecorateDH", obj.DecorateDH, true));
            lst.Add(new SqlElement("ReceptTime", "getdate()", false));
            lst.Add(new SqlElement("ComeType", obj.ComeType, true));

            sql = CreateSqlUtil.CreateInsertSql(lst, "repair");
            sql = sql + " SELECT @@IDENTITY AS Id ";
            DataTable dt = mDB.ExecuteDataTable(sql);
            string id = dt.Rows[0][0].ToString();
            sql = "select dh from repair where id =" + id;
            dt = mDB.ExecuteDataTable(sql);
            string dh = dt.Rows[0][0].ToString();
            return dh; 

        }


        public void UpdateRepair(RepairM obj)
        {
            string sql;
            List<SqlElement> lst = new List<SqlElement>();
            if(obj.Status!=-1)
               lst.Add(new SqlElement("Status", obj.Status.ToString(), false));
         
            lst.Add(new SqlElement("RepType", obj.RepType, true));
            lst.Add(new SqlElement("RepChildType", obj.RepChildType, true));
           // lst.Add(new SqlElement("CustName", obj.CustName, true));
            lst.Add(new SqlElement("Vin", obj.Vin, true));
            lst.Add(new SqlElement("Mobile", obj.Mobile, true));
            lst.Add(new SqlElement("PlateNum", obj.PlateNum, true));
            lst.Add(new SqlElement("CustName", obj.CustName, true));

         //   lst.Add(new SqlElement("InsuranceCompany", obj.InsuranceCompany, true));
            lst.Add(new SqlElement("SendRepMan", obj.SendRepMan, true));
            lst.Add(new SqlElement("SendRepTel", obj.SendRepTel, true));
 
            if(!string.IsNullOrEmpty(obj.ReceptMan))
               lst.Add(new SqlElement("ReceptMan", obj.ReceptMan, true));

            lst.Add(new SqlElement("IsNeedOld", obj.IsNeedOld==true?"1":"0", false));
            lst.Add(new SqlElement("IsWash", obj.IsWash == true ? "1" : "0", false));
            lst.Add(new SqlElement("IsWillVisit", obj.IsWillVisit == true ? "1" : "0", false));

            //if(!string.IsNullOrEmpty(obj.ReceptTime))
            //     lst.Add(new SqlElement("ReceptTime", obj.ReceptTime, false));
            if (!string.IsNullOrEmpty(obj.DecorateDH))
                lst.Add(new SqlElement("DecorateDH", obj.DecorateDH, true));

            lst.Add(new SqlElement("InMil", obj.InMil, true));
            lst.Add(new SqlElement("NextKeepMil", obj.NextKeepMil, true));
            lst.Add(new SqlElement("NextKeepDate", obj.NextKeepDate.ToShortDateString(), true));
            lst.Add(new SqlElement("EstimateComplete", obj.EstimateComplete.ToShortDateString(), true));
            lst.Add(new SqlElement("Remark", obj.Remark, true));
            lst.Add(new SqlElement("ComeType", obj.ComeType, true));
            lst.Add(new SqlElement("SystemDH", obj.SystemDH, true));
            sql = Comm.CreateSqlUtil.CreateUpdateSql(lst, "repair") + " where dh='" + obj.DH + "'"; 
            mDB.ExecuteNonQuery(sql);
        }

        public void SetRepStatus(RepairM obj)
        {
            string sql="";
            if(obj.Status==3)
                sql = string.Format("update repair set status={0},AccountTime=getDate() where dh='{1}'", obj.Status, obj.DH);
            else if (obj.Status == 2)
            {
                sql = string.Format("update repair set status={0},gamount={2} where dh='{1}'", obj.Status, obj.DH, obj.GAmount);

            }
            else
                sql = string.Format("update repair set status={0}   where dh='{1}'", obj.Status, obj.DH);
            mDB.ExecuteNonQuery(sql);

        }

        public void SetRepTakeAllFlag(string dh)
        {
            string sql = string.Format("update repair set IsTakeAll=1 where dh='{0}'",dh);
            mDB.ExecuteNonQuery(sql);

        }
        public RepairM GetRepairByDH(string dh)
        {
            string sql;
            sql = string.Format("select * from v_repair where dh ='{0}'",dh);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                RepairM obj = new RepairM();
                obj.DH = dt.Rows[0]["DH"].ToString();
                obj.Mobile = dt.Rows[0]["Mobile"].ToString();
                obj.CustName = dt.Rows[0]["CustName"].ToString();
                obj.CompleteTime = dt.Rows[0]["CompleteTime"].ToString();
                obj.PlateNum = dt.Rows[0]["PlateNum"].ToString();
             //   obj.PreAccessoryAmount= = dt.Rows[0]["PlateNum"].ToString();
                obj.PreItemAmount = dt.Rows[0]["PreItemAmount"].ToString();
                obj.PreAccessoryAmount = dt.Rows[0]["PreAccessoryAmount"].ToString();
                obj.ReceptMan = dt.Rows[0]["ReceptMan"].ToString();
                obj.RepType = dt.Rows[0]["RepType"].ToString();
                obj.RepChildType = dt.Rows[0]["RepChildType"].ToString();

                obj.Status = int.Parse(dt.Rows[0]["Status"].ToString());
                obj.ReceptTime = dt.Rows[0]["ReceptTime"].ToString();
                obj.InsuranceCompany = dt.Rows[0]["InsuranceCompany"].ToString();
                obj.SendRepMan = dt.Rows[0]["SendRepMan"].ToString();
                obj.SendRepTel = dt.Rows[0]["SendRepTel"].ToString();
                obj.IsNeedOld = dt.Rows[0]["IsNeedOld"].ToString() == "True" ? true : false;
                obj.IsWash = dt.Rows[0]["IsWash"].ToString() == "True" ? true : false;
                obj.IsWillVisit = dt.Rows[0]["IsWillVisit"].ToString() == "True" ? true : false;
                obj.AccountTime = dt.Rows[0]["AccountTime"].ToString();
                obj.DecorateDH = dt.Rows[0]["DecorateDH"].ToString();
                obj.Vin = dt.Rows[0]["Vin"].ToString();
                obj.CarModel = dt.Rows[0]["CarModel"].ToString();
                obj.GAmount = float.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["Gamount"].ToString()));
                if (dt.Rows[0]["Remark"] != null)
                    obj.Remark = dt.Rows[0]["Remark"].ToString();
                if (dt.Rows[0]["InMil"] != null)
                    obj.InMil = dt.Rows[0]["InMil"].ToString();
                if (dt.Rows[0]["NextKeepMil"] != null)
                    obj.NextKeepMil = dt.Rows[0]["NextKeepMil"].ToString();
                if (dt.Rows[0]["NextKeepDate"] != null && !string.IsNullOrEmpty(dt.Rows[0]["NextKeepDate"].ToString()))
                    obj.NextKeepDate = DateTime.Parse(dt.Rows[0]["NextKeepDate"].ToString());
                if (dt.Rows[0]["EstimateComplete"] != null && !string.IsNullOrEmpty(dt.Rows[0]["EstimateComplete"].ToString()))
                    obj.EstimateComplete = DateTime.Parse(dt.Rows[0]["EstimateComplete"].ToString());

                obj.ComeType = dt.Rows[0]["ComeType"].ToString();

                obj.AccessAmount = decimal.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["AccessAmount"].ToString()));
                return obj;
            }
            else 

              return null;
        }

     
        public DataTable GetItemsOfDHInTake(string dh)
        {
            string sql = string.Format("select repair_i.xh, 0 as sel,repair_i.itemcode ,repair_i.itemtotalprice,repairitem.itemname,repair_i.EmpWorkH,repair_i.ActWorkH from repair_i inner join  repairitem  on  repair_i.itemcode = repairitem.itemcode   where repair_i.dh='{0}'", dh);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }

     


       //temp



        public DataTable GetRepairsOfOut(string strBegin, string strEnd, string platenum, string outtype, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {

            string IndexField = "DH";
            string AllFields = "DH,RepChildType,CustName,PlateNum,AccountTime,CompleteTime";

            string Condition = "repair where reptype='维修'";
            string OrderFields = "order by AccountTime desc";

            Condition += string.Format(" and AccountTime>='{0}' and AccountTime<='{1}'", strBegin, strEnd);
            Condition += string.Format(" and PlateNum like '%{0}%'",platenum);
            if (outtype == "未放行")
            {
                Condition += " and CompleteTime is null";
            }
            else
            {
                Condition += " and CompleteTime is not null";
            }
            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;
        }

        public DataTable GetSaleDecorates(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string IndexField = "DH";
            string AllFields = "case when status=0 then '开单' when status=1 then '作业中'  when status=2 then '预结算' else '已结算' end  as Status,DH,CustName,RepType,RepChildType,ReceptMan,ReceptTime,PlateNum,Vin,CarModel,GAmount,SendRepMan,AccountTime,DecorateDH";
            string Condition = "repair where ";
            string OrderFields = "order by ReceptTime desc";

            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

            Condition += "and RepChildType in ('销售装潢','原厂装潢')";

            if (strBegin != "")
                Condition = Condition + string.Format(" and ReceptTime>='{0}' and ReceptTime<='{1}'", strBegin, strEnd);
            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;
        
        }
        
        public DataTable GetPlatesByMobile(string mobile)
        {
            string sql = string.Format("select PlateNum from carofcustomer where mobile ='{0}'",mobile);
            return mDB.ExecuteDataTable(sql);

        }

        public DataTable GetAccessorysOfRepair(string dh)
        {
            string sql = "select * from repair_a where dh='" + dh + "'";
            return mDB.ExecuteDataTable(sql);

        }

        public void AddAccessoryOfRepair(string dh,string acccode)
        {
    
            string sql = "insert repair_a(dh,accessorycode) values('{0}','{1}')";
            mDB.ExecuteNonQuery(sql);

        }


        public DataTable GetRepsOfTake(string plate,string dh,string vin,string custname,int type)
        {
            string sql = "";
            if(type==0)
                sql = string.Format("select top 30 DH,RepType,RepChildType,CustName,PlateNum,Vin,ReceptTime from repair where platenum like '%{0}%' and dh like '%{1}%' and vin like '%{2}%' and custname like '%{3}%' and status=1 and repchildtype not in ('销售装潢','原厂装潢') order by ReceptTime desc", plate, dh, vin, custname);
            else
                sql = string.Format("select top 30 DH,RepType,RepChildType,CustName,PlateNum,Vin,ReceptTime from repair where platenum like '%{0}%' and dh like '%{1}%' and vin like '%{2}%' and custname like '%{3}%' and status=3 and repchildtype in ('销售装潢','原厂装潢') order by ReceptTime desc", plate, dh, vin,custname);
            return mDB.ExecuteDataTable(sql);

        }


        public DataTable GetRepsOfClaim()
        {
            string sql = "";
            sql = string.Format("select top 100 DH,RepType,RepChildType,CustName,PlateNum,ReceptTime from repair  where status=3 and repchildtype in ('索赔','首保')  and isnull(IsClaim,0)!=1 and dh not in (select repdh from claimh) order by ReceptTime desc");
            return mDB.ExecuteDataTable(sql);

        }

        public void ExtractClaimFromRep(string dh,decimal accessamount)
        {

            string sql = "";
            sql = string.Format("select  *  from repair  where dh='{0}' and dh not in (select repdh from claimh)", dh);
            DataTable dt = mDB.ExecuteDataTable(sql);
            IClaim iclaim = Bll.BllFactory.GetClaimBll();
            if (dt.Rows.Count > 0)
            {
                List<SqlElement> lst = new List<SqlElement>();
                lst.Add(new SqlElement("RepDH", dh, true));
                //lst.Add(new SqlElement("Mobile", obj.Mobile, true));
                lst.Add(new SqlElement("CustName", dt.Rows[0]["CustName"].ToString(), true));
                lst.Add(new SqlElement("Vin", dt.Rows[0]["Vin"].ToString(), true));
                lst.Add(new SqlElement("PlateNum", dt.Rows[0]["PlateNum"].ToString(), true));
                float itemamount = GetForeItemAmountOfDH(dt.Rows[0]["DH"].ToString());
                float accamount = GetForeAccAmountOfDH(dt.Rows[0]["DH"].ToString());
                lst.Add(new SqlElement("ItemAmount", itemamount.ToString(), false));
                lst.Add(new SqlElement("AccAmount", accamount.ToString(), false));
                lst.Add(new SqlElement("AccessAmount", accessamount.ToString(), false));
                lst.Add(new SqlElement("AccessDate", "getdate()", false));

                lst.Add(new SqlElement("ClaimAmount", (itemamount + accamount).ToString(), false));
                //   lst.Add(new SqlElement("AccAmount", accamount.ToString(), false));
                lst.Add(new SqlElement("ReceptMan", dt.Rows[0]["ReceptMan"].ToString(), true));
                lst.Add(new SqlElement("AccountDate", dt.Rows[0]["AccountTime"].ToString(), true));

                lst.Add(new SqlElement("PostMan", Comm.LoginInfoShare.getInstance().UserName, true));
                iclaim.CreateClaimH(lst);
                iclaim.SetRepToClaim(dh);

            }
            else
            {
                sql = string.Format("update claimh set AccessAmount={0} , AccessDate=getdate() where repdh='{1}'", accessamount, dh);
                mDB.ExecuteNonQuery(sql);

            }


        }


        public void ExtractClaimsFromReps()
        {
            string sql = "";
            sql = string.Format("select  *  from repair  where status=3 and repchildtype in ('索赔','免费保养')  and isnull(IsClaim,0)!=1 and dh not in (select repdh from claimh) order by ReceptTime desc");
            DataTable dt = mDB.ExecuteDataTable(sql);
            IClaim iclaim = Bll.BllFactory.GetClaimBll();
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
              
                List<SqlElement> lst = new List<SqlElement>();
                lst.Add(new SqlElement("RepDH", dt.Rows[i]["DH"].ToString(), true));
                //lst.Add(new SqlElement("Mobile", obj.Mobile, true));
                lst.Add(new SqlElement("CustName", dt.Rows[i]["CustName"].ToString(), true));
                lst.Add(new SqlElement("Vin", dt.Rows[i]["Vin"].ToString(), true));
                lst.Add(new SqlElement("PlateNum", dt.Rows[i]["PlateNum"].ToString(), true));
                float itemamount = GetForeItemAmountOfDH(dt.Rows[i]["DH"].ToString());
                float accamount = GetForeAccAmountOfDH(dt.Rows[i]["DH"].ToString());
                lst.Add(new SqlElement("ItemAmount", itemamount.ToString(), false));
                lst.Add(new SqlElement("AccAmount", accamount.ToString(), false));
                lst.Add(new SqlElement("ClaimAmount", (itemamount + accamount).ToString(), false));
                //   lst.Add(new SqlElement("AccAmount", accamount.ToString(), false));
                lst.Add(new SqlElement("ReceptMan", dt.Rows[i]["ReceptMan"].ToString(), true));
                lst.Add(new SqlElement("AccountDate", dt.Rows[i]["AccountTime"].ToString(), true));
                lst.Add(new SqlElement("PostMan", Comm.LoginInfoShare.getInstance().UserName, true));
                iclaim.CreateClaimH(lst);
                iclaim.SetRepToClaim(dt.Rows[i]["DH"].ToString());


            }

        }

        public float GetItemAmountOfDH(string dh)
        {
            string sql = "";
            sql = "select IsNull(sum(finalprice),0) from repair_i where dh='" + dh + "'";
            float result=0;
            DataTable dt = mDB.ExecuteDataTable(sql);
            if(dt.Rows.Count>0)
               result = float.Parse(dt.Rows[0][0].ToString());
            return result;
        }


        public float GetForeAccAmountOfDH(string dh)
        {
            string sql;
            //sql = "select IsNull(sum(amount*saleprice),0) from repair_a where dh='" + dh + "' and acctype=1";
            //float result1 = 0,result2=0;
            //DataTable dt = mDB.ExecuteDataTable(sql);
            //result1 = float.Parse(dt.Rows[0][0].ToString());
            //sql = "select IsNull(sum(amount*saleprice),0) from repair_a where dh='" + dh + "' and acctype=2";
            //dt = mDB.ExecuteDataTable(sql);
            //result2 = float.Parse(dt.Rows[0][0].ToString());



            sql = "select IsNull(sum(amount*saleprice),0) from repair_a where dh='" + dh + "' and acctype in(1,2) and status in(0,2)";
            float result1=0;
            DataTable dt = mDB.ExecuteDataTable(sql);
            //string tmp;

            //  tmp = float.Parse(dt.Rows[0][0].ToString()).ToString("0.00");
            if (dt.Rows.Count > 0)
                 result1 = float.Parse(dt.Rows[0][0].ToString());
            return result1;
        }

        public float GetInPriceOfDH(string dh)
        {
            string sql;
            //sql = "select IsNull(sum(amount*saleprice),0) from repair_a where dh='" + dh + "' and acctype=1";
            //float result1 = 0,result2=0;
            //DataTable dt = mDB.ExecuteDataTable(sql);
            //result1 = float.Parse(dt.Rows[0][0].ToString());
            //sql = "select IsNull(sum(amount*saleprice),0) from repair_a where dh='" + dh + "' and acctype=2";
            //dt = mDB.ExecuteDataTable(sql);
            //result2 = float.Parse(dt.Rows[0][0].ToString());

            sql = "select IsNull(sum(amount*InPrice),0) from repair_a where dh='" + dh + "' and acctype=1 and status=0";
            float result1=0;
            DataTable dt = mDB.ExecuteDataTable(sql);
            //string tmp;

            //  tmp = float.Parse(dt.Rows[0][0].ToString()).ToString("0.00");
            if (dt.Rows.Count > 0)
               result1 = float.Parse(dt.Rows[0][0].ToString());
            return result1;
        }

        public float GetForeItemAmountOfDH(string dh)
        {
            string sql;
            //sql = "select IsNull(sum(amount*saleprice),0) from repair_a where dh='" + dh + "' and acctype=1";
            //float result1 = 0,result2=0;
            //DataTable dt = mDB.ExecuteDataTable(sql);
            //result1 = float.Parse(dt.Rows[0][0].ToString());
            //sql = "select IsNull(sum(amount*saleprice),0) from repair_a where dh='" + dh + "' and acctype=2";
            //dt = mDB.ExecuteDataTable(sql);
            //result2 = float.Parse(dt.Rows[0][0].ToString());

            sql = "select IsNull(ItemTotalPrice,0) from repair_i where dh='" + dh + "'";
            float result1=0;
            DataTable dt = mDB.ExecuteDataTable(sql);
            //string tmp;

            //  tmp = float.Parse(dt.Rows[0][0].ToString()).ToString("0.00");
            if (dt.Rows.Count > 0)
                result1 = float.Parse(dt.Rows[0][0].ToString());
            return result1;
        }

        public float  GetAccAmountOfDH(string dh)
        {
            string sql;
            sql = "select IsNull(sum(amount*finalprice),0)  from repair_a where dh='" + dh + "' and acctype in (1,2)";
            float result1 = 0;
            DataTable dt = mDB.ExecuteDataTable(sql);
            //string tmp;
 
          //  tmp = float.Parse(dt.Rows[0][0].ToString()).ToString("0.00");
            if (dt.Rows.Count > 0)
                result1 = float.Parse(dt.Rows[0][0].ToString());
            return result1 ;
        }


        public decimal GetAccInPriceOfDH(string dh)
        {
            string sql;
            sql = "select cast(IsNull(sum(amount*Inprice),0) as decimal(18,2)) from repair_a where dh='" + dh + "' and acctype in (1,2) ";
            decimal  result1 = 0;
            DataTable dt = mDB.ExecuteDataTable(sql);
            //string tmp;

            //  tmp = float.Parse(dt.Rows[0][0].ToString()).ToString("0.00");
            if (dt.Rows.Count > 0)
                result1 = decimal.Parse(dt.Rows[0][0].ToString());
            return result1;

        }
        public float GetAccDemandAmountOfDH(string dh)
        {
            string sql;
            sql = "select IsNull(sum(amount*finalprice),0) from repair_a where dh='" + dh + "' and acctype=0";
            float result1 = 0;
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
              result1 = float.Parse(dt.Rows[0][0].ToString());
            return result1;
        }

        public DataTable GetRepairsByPlate(string plate)
        {
        
            string sql = "select case when status=0 then '开单' when status=1 then '作业中'  when status=2 then '预结算' else '已结算' end  as Status,DH,CustName,viplevel ,cardno,RepType,RepChildType,ReceptMan,ReceptTime,PlateNum,Vin,CarModel,GAmount,SendRepMan,AccountTime from repair where ";
            sql += " PlateNum ='" + plate + "'";
            return mDB.ExecuteDataTable(sql);

        }

        //public DataTable GetRepairsOfVisit(string strbegin,string strend)
        //{

        //    string sql = "select  dh,platenum,Moible,custname,ReceptTime,AccountTime,complete where ";



        //}


        public DataTable GetRepairs(List<SqlElement> list, string saleman, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string IndexField = "DH";
            string AllFields = "case when status=0 then '开单' when status=1 then '作业中'  when status=2 then '预结算' else '已结算' end  as Status,DH,Mobile,CustName,viplevel ,cardno,RepType,RepChildType,ReceptMan,ReceptTime,PlateNum,Vin,CarModel,GAmount,SendRepMan,AccountTime";
            string Condition = "repair where ";
            string OrderFields = "order by ReceptTime desc";

          
            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";
            Condition = Condition + " and RepChildType!='销售装潢' and status!=3";
            if (!string.IsNullOrEmpty(saleman))
            {

                Condition = Condition + " and ReceptMan='" + saleman + "'";
            }
            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;

        }


        public DataTable GetSumRepairsOfQuery(List<SqlElement> mLstE, int datesel, string dtBegin, string dtEnd, List<string> lstStatus)
        {
           
            string sql = "select isnull(sum(Gamount),0) from repair where ";
            string Condition="";
            if (mLstE != null && mLstE.Count > 0)
                Condition += CreateSqlUtil.CreateQuerySqlOfCondition(mLstE, true);
            else
                Condition += "1=1";

            if (datesel == 1)
            {
                Condition += string.Format(" and ReceptTime>='{0}' and ReceptTime<='{1}'", dtBegin, dtEnd);
            }
            else if (datesel == 2)
            {
                Condition += string.Format(" and AccountTime>='{0}' and AccountTime<='{1}' and status=3  ", dtBegin, dtEnd);
            }

            if (lstStatus != null && lstStatus.Count > 0)
            {
                Condition += " and ";
                foreach (string str in lstStatus)
                {
                    Condition += " status=" + str + " or";
                }
                Condition = Condition.Remove(Condition.Length - 3);

            }
            sql = sql + Condition;
             

            DataTable dt = mDB.ExecuteDataTable(sql);

            return dt;
        }

        public DataTable GetOutRepairsOfQuery(List<SqlElement> mLstE, int datesel, string dtBegin, string dtEnd, List<string> lstStatus)
        {

            string sql = "select case when status=0 then '开单' when status=1 then '作业中'  when status=2 then '预结算' else '完成' end  as Status,DH,PlateNum,Vin,CustName,Mobile,ReceptTime,AccountTime,RepType,RepChildType,CarModel,GAmount,AccessAmount,AccessDate,ReceptMan,SendRepMan,cardno,viplevel from v_repair where ";

            string Condition = "";
            if (mLstE != null && mLstE.Count > 0)
                Condition += CreateSqlUtil.CreateQuerySqlOfCondition(mLstE, true);
            else
                Condition += "1=1";

            if (datesel == 1)
            {
                Condition += string.Format(" and ReceptTime>='{0}' and ReceptTime<='{1}'", dtBegin, dtEnd);
            }
            else if (datesel == 2)
            {
                Condition += string.Format(" and AccountTime>='{0}' and AccountTime<='{1}'", dtBegin, dtEnd);
            }

            if (lstStatus != null && lstStatus.Count > 0)
            {
                Condition += " and  status in (";
                foreach (string str in lstStatus)
                {
                    Condition += str + ",";
                }
                Condition = Condition.Remove(Condition.Length - 1);
                Condition += ")";
            }

            sql += Condition;
            return mDB.ExecuteDataTable(sql);


        }


        public DataTable GetRepairsOfQuery1(List<SqlElement> mLstE, int datesel, string dtBegin, string dtEnd, List<string> lstStatus, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string IndexField = "DH";
            string AllFields = " count,case when status=0 then '开单' when status=1 then '作业中'  when status=2 then '预结算' else '完成' end  as Status,DH,CustName,mobile,viplevel,cardno,RepType,RepChildType,ReceptMan,ReceptTime,PlateNum,Vin,CarModel,GAmount,SendRepMan,AccountTime  ";
            string Condition = "v_repair where ";
            string OrderFields = "order by ReceptTime desc";

            if (mLstE != null && mLstE.Count > 0)
                Condition += CreateSqlUtil.CreateQuerySqlOfCondition(mLstE, true);
            else
                Condition += "1=1";

            if (datesel == 1)
            {
                Condition += string.Format(" and ReceptTime>='{0}' and ReceptTime<='{1}'", dtBegin, dtEnd);
            }
            else if (datesel == 2)
            {
                Condition += string.Format(" and AccountTime>='{0}' and AccountTime<='{1}'", dtBegin, dtEnd);
            }

            if (lstStatus != null && lstStatus.Count > 0)
            {
                Condition += " and ";
                foreach (string str in lstStatus)
                {
                    Condition += " status=" + str + " or";
                }
                Condition = Condition.Remove(Condition.Length - 3);

            }


            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;



        }

        public DataTable GetRepairsOfQuery(List<SqlElement> mLstE,int datesel,string dtBegin,string dtEnd,List<string > lstStatus, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string IndexField = "DH";
            string AllFields = " case when status=0 then '开单' when status=1 then '作业中'  when status=2 then '预结算' else '完成' end  as Status,DH,CustName,Mobile,viplevel,cardno,RepType,RepChildType,ReceptMan,ReceptTime,PlateNum,Vin,CarModel,GAmount,SendRepMan,AccountTime,AccessDate,AccessAmount ";
            string Condition = "v_repair where ";
            string OrderFields = "order by ReceptTime desc";

            if (mLstE != null && mLstE.Count > 0)
                Condition += CreateSqlUtil.CreateQuerySqlOfCondition(mLstE, true);
            else
                Condition += "1=1";

            if (datesel == 1)
            {
                Condition += string.Format(" and ReceptTime>='{0}' and ReceptTime<='{1}'", dtBegin, dtEnd);
            }
            else if (datesel == 2)
            {
                Condition += string.Format(" and AccountTime>='{0}' and AccountTime<='{1}'", dtBegin, dtEnd);
            }

            if (lstStatus != null && lstStatus.Count >0)
            {
                Condition += " and  status in (";
                foreach (string str in lstStatus)
                {
                    Condition += str + ",";
                }
                Condition = Condition.Remove(Condition.Length -1);
                Condition += ")";
            }


            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;

        }

       //维修项目相关
        public DataTable GetItemsOfDH(string dh)
        {
            string sql = string.Format("select repair_i.xh,repair_i.itemcode ,repair_i.itemtotalprice,repairitem.itemname,EmpWorkH,ActWorkH,case when repair_i.CarLevel=100 then '高档' when repair_i.CarLevel=200 then '中高档'  when repair_i.CarLevel=300 then '中档' else '低档' end  as CarLevel,WorkMan,repair_i.TypeOfWork,repair_i.FaultDescribe,repair_i.FaultReason,repair_i.priceid,repair_i.PriceType,(100-repair_i.Discount*100) as Discount,repair_i.FinalPrice from repair_i inner join  repairitem  on  repair_i.itemcode = repairitem.itemcode   where repair_i.dh='{0}'  order by repair_i.xh asc", dh);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }

        public void AddItemOfRepair(string dh, string itemcode, string priceid)
        {
            // string sql = string.Format("insert into repair_i(dh,xh,itemcode) values('{0}',dbo.GetRepairIXH('{0}'),'{1}') select max(xh) from repair_i where dh='{0}'", dh, itemcode);
            //string sql = string.Format("insert into repair_i(dh,xh,itemcode,priceid) values('{0}',dbo.GetRepairIXH('{0}'),'{1}',{2}) select max(xh) from repair_i where dh='{0}' ", dh, itemcode, priceid);
            //DataTable dt = mDB.ExecuteDataTable(sql);

            //string xh = dt.Rows[0][0].ToString();
            //sql = string.Format("update repair_i set itemtotalprice =(select actworkh*workhprice from repitemprice where id={0}) where dh='{1}' and  xh ={2}",priceid,dh,xh);
            //mDB.ExecuteNonQuery(sql);
            //sql = string.Format("update repair set preItemAmount =(select sum(itemtotalprice) from repair_i where dh ='{0}' group by dh) where dh='{0}'", dh);
            //mDB.ExecuteNonQuery(sql);

            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15),
				
                    new SqlParameter("@vItemCode", SqlDbType.VarChar,20),
                     new SqlParameter("@vPriceId", SqlDbType.Int)
					};
            parameters[0].Value = dh;

            parameters[1].Value = itemcode;
            parameters[2].Value = priceid;
            mDB.ExecuteNonQueryByPro("[AddItemOfRepair]", parameters);
        }

        public void AddItemOfRepairEx(repair_iM obj)
        {
            // string sql = string.Format("insert into repair_i(dh,xh,itemcode) values('{0}',dbo.GetRepairIXH('{0}'),'{1}') select max(xh) from repair_i where dh='{0}'", dh, itemcode);
            //string sql = string.Format("insert into repair_i(dh,xh,itemcode,priceid) values('{0}',dbo.GetRepairIXH('{0}'),'{1}',{2}) select max(xh) from repair_i where dh='{0}' ", dh, itemcode, priceid);
            //DataTable dt = mDB.ExecuteDataTable(sql);

            //string xh = dt.Rows[0][0].ToString();
            //sql = string.Format("update repair_i set itemtotalprice =(select actworkh*workhprice from repitemprice where id={0}) where dh='{1}' and  xh ={2}",priceid,dh,xh);
            //mDB.ExecuteNonQuery(sql);
            //sql = string.Format("update repair set preItemAmount =(select sum(itemtotalprice) from repair_i where dh ='{0}' group by dh) where dh='{0}'", dh);
            //mDB.ExecuteNonQuery(sql);

            //SqlParameter[] parameters = {
            //        new SqlParameter("@vDH", SqlDbType.Char,15),
				
            //        new SqlParameter("@vItemCode", SqlDbType.VarChar,20),
            //        new SqlParameter("@vPriceId", SqlDbType.Int),
            //        new SqlParameter("@vWorkMan", SqlDbType.VarChar,20),
            //        new SqlParameter("@vFaultDescribe", SqlDbType.VarChar,50),
            //        new SqlParameter("@vFaultReason", SqlDbType.VarChar,50),
            //        new SqlParameter("@vTypeOfWork", SqlDbType.VarChar,10),
            //        new SqlParameter("@vDiscount", SqlDbType.Float)
            //        };
            //parameters[0].Value = obj.DH;

            //parameters[1].Value = obj.ItemCode;
            //parameters[2].Value = obj.PriceId;
            //parameters[3].Value = obj.WorkMan;
            //parameters[4].Value = obj.FaultDescribe;
            //parameters[5].Value = obj.FaultReason; 
            //parameters[6].Value = obj.TypeOfWork;
            //parameters[7].Value = obj.Discount;
            //mDB.ExecuteNonQueryByPro("[AddItemOfRepair]", parameters);

            string sql;
            List<SqlElement> lst = new List<SqlElement>();
        
            lst.Add(new SqlElement("DH", obj.DH, true));
            lst.Add(new SqlElement("xh","dbo.GetRepairIXH('"+ obj.DH + "')", false));
            lst.Add(new SqlElement("itemcode", obj.ItemCode, true));
            lst.Add(new SqlElement("WorkMan", obj.WorkMan, true));
            lst.Add(new SqlElement("FaultDescribe", obj.FaultDescribe, true));
            lst.Add(new SqlElement("FaultReason", obj.FaultReason, true));
            //lst.Add(new SqlElement("FaultDescribe", obj.FaultDescribe, true));
            lst.Add(new SqlElement("TypeOfWork", obj.TypeOfWork, true));
            lst.Add(new SqlElement("PriceType", "正常", true));
            lst.Add(new SqlElement("CarLevel", obj.CarLevel.ToString(), false));
           
            lst.Add(new SqlElement("Discount", obj.Discount.ToString(), false));
            lst.Add(new SqlElement("ItemTotalPrice", obj.WorkHPrice.ToString(), false));
            lst.Add(new SqlElement("EmpWorkH", obj.EmpWorkH.ToString(), false));
            lst.Add(new SqlElement("ActWorkH", obj.ActWorkH.ToString(), false));
            lst.Add(new SqlElement("FinalPrice", obj.FinalPrice.ToString(), false));

            sql = Comm.CreateSqlUtil.CreateInsertSql(lst, "repair_i");
            mDB.ExecuteNonQuery(sql);
        
        }


           
        public void UpdateRepairItemPrice(string dh, string xh, string itemcode, string carlevel)
        {
            int icarlvel = 0;
            switch (carlevel)
            {
                case "高档":
                    icarlvel = 0;
                    break;
                case "中档":
                    icarlvel = 1;
                    break;
                case "低档":
                    icarlvel = 2;
                    break;
                default:
                    icarlvel = 3;
                    break;

            }
            string sql = string.Format("select ID from repitemprice where carlevel={0} and itemcode ='{1}'", icarlvel, itemcode);
            DataTable dt = mDB.ExecuteDataTable(sql);
            int priceid = 0;
            if (dt.Rows.Count > 0)
            {
                priceid = int.Parse(dt.Rows[0][0].ToString());
                //sql = string.Format("update repair_i set itemcode='{0}' where dh='{1}' and xh={2}", itemcode, dh, xh);

            }
            if (priceid != 0)
                UpdateItemOfRepair(dh, xh, itemcode, priceid);
        }

        public void UpdateItemOfRepair(string dh, string xh, string itemcode, int priceid)
        {
            //重写存储过程
            //string sql = string.Format("update repair_i set itemcode='{0}',priceid={3} where dh='{1}' and xh={2}" ,itemcode,dh,xh,priceid);
            //mDB.ExecuteNonQuery(sql);
            //sql = string.Format("update repair_i set itemtotalprice =(select actworkh*workhprice from repitemprice where id={0}) where dh='{1}' and  xh ={2}",priceid,dh,xh);
            //mDB.ExecuteNonQuery(sql);
            //sql = string.Format("update repair set preItemAmount =(select sum(itemtotalprice) from repair_i where dh ='{0}' group by dh) where dh='{0}'", dh);
            //mDB.ExecuteNonQuery(sql);

            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15),
				    new SqlParameter("@vXH", SqlDbType.Int),
                    new SqlParameter("@vItemCode", SqlDbType.VarChar,20),
                     new SqlParameter("@vPriceId", SqlDbType.Int)
					};
            parameters[0].Value = dh;
            parameters[1].Value = xh;
            parameters[2].Value = itemcode;
            parameters[3].Value = priceid;
            mDB.ExecuteNonQueryByPro("[UpdatePriceOfRepItem]", parameters);

        }

        public void DeleteItemOfRepair(string dh, string xh)
        {
            string sql = string.Format("delete from repair_i  where dh='{0}' and xh={1}", dh, xh);
            mDB.ExecuteNonQuery(sql);
            sql = string.Format("update repair set preItemAmount =(select sum(itemtotalprice) from repair_i where dh ='{0}' group by dh) where dh='{0}'", dh);
            mDB.ExecuteNonQuery(sql);

        }


        public  void UpdateRepairItemOfModel(repair_iM obj)
        {
            string sql;
            List<SqlElement> lst = new List<SqlElement>();

             lst.Add(new SqlElement("ItemCode", obj.ItemCode, true));

           // lst.Add(new SqlElement("FaultReason", obj.FaultReason, true));

            lst.Add(new SqlElement("FaultDescribe", obj.FaultDescribe, true));
         
            lst.Add(new SqlElement("FaultReason", obj.FaultReason, true));
           
            lst.Add(new SqlElement("WorkMan", obj.WorkMan, true));
       
            lst.Add(new SqlElement("TypeOfWork", obj.TypeOfWork, true));

            lst.Add(new SqlElement("EmpWorkH", obj.EmpWorkH.ToString(), false));

            lst.Add(new SqlElement("ActWorkH", obj.ActWorkH.ToString(), false));

            lst.Add(new SqlElement("ItemTotalPrice", obj.WorkHPrice.ToString(), false));

            lst.Add(new SqlElement("CarLevel", obj.CarLevel.ToString(), false));

            lst.Add(new SqlElement("FinalPrice", obj.FinalPrice.ToString(), false));

            if (lst.Count > 0)
            {
                sql = Comm.CreateSqlUtil.CreateUpdateSql(lst, "repair_i");
                sql = sql + " where dh ='" + obj.DH + "' and xh=" + obj.XH.ToString();
                mDB.ExecuteNonQuery(sql);

            }
        }

        public void UpdatePriceOfRepairItem(repair_iM obj)
        {
            string sql;
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("FinalPrice", obj.FinalPrice.ToString(), false));
            lst.Add(new SqlElement("PriceType", obj.PriceType, true));

            lst.Add(new SqlElement("Discount", obj.Discount.ToString(), false));
            if (lst.Count > 0)
            {
                sql = Comm.CreateSqlUtil.CreateUpdateSql(lst, "repair_i");
                sql = sql + " where dh ='" + obj.DH + "' and xh=" + obj.XH.ToString();
                mDB.ExecuteNonQuery(sql);

            }
        }

        public bool DelRepair(string dh)
        {
            string sql = "select * from repair where status<=0 and dh='" + dh + "'";
            bool b1 = mDB.IsExists(sql);
            sql = "select * from repair_a where dh='" + dh + "'";
            bool b2 = mDB.IsExists(sql);
            if (b1 && !b2)
            {
                sql = string.Format("delete from repair where dh='{0}';delete from repair_i where dh='{0}'",dh);              
                mDB.ExecuteNonQuery(sql);
                return true;
            }
            return false;

        }

        public bool IsTakeAll(string dh)
        {
            string sql = string.Format("select *  from  repair where dh='{0}' and IsTakeAll=1",dh);
            if (mDB.IsExists(sql))
                return true;
            else
                return false;

        }

        public DataTable STEmpWorkHour(string dtBegin,string dtEnd,string workman,string itemname)
        {
            string sql;
            sql = "select workman,a.dh,c.SystemDH,c.custname,c.platenum,itemname,a.empworkh,itemtotalprice from repair_i as a left join repairitem as b on a.itemcode =b.itemcode left join repair  as c on a.dh =c.dh";
            sql += string.Format(" where  c.AccountTime>='{0}' and c.AccountTime<='{1}' and a.workman like '%{2}%' and b.itemname like '%{3}%'", dtBegin, dtEnd, workman, itemname);
            return mDB.ExecuteDataTable(sql);


        }

        public DataTable GetSumWHofQuery(string dtBegin, string dtEnd, string workman, string itemname)
        {
            string sql;
            sql = "select isNull(sum(empworkh),0),IsNull(sum(itemtotalprice),0) from repair_i  as a inner join repairitem as b on a.itemcode =b.itemcode  left join repair  as c on a.dh =c.dh";
            sql += string.Format(" where  c.AccountTime>='{0}' and c.AccountTime<='{1}' and workman like '%{2}%'and b.itemname like '%{3}%'", dtBegin, dtEnd, workman, itemname);
            return mDB.ExecuteDataTable(sql);


        }


        public bool IsDiscountOfDH(string dh)
        {
            bool isDiscount=false;
            string sql="select isnull(sum(discount),0) from repair_a where dh='" + dh + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            string tmpstr = dt.Rows[0][0].ToString();
            double tmpdouble = double.Parse(tmpstr);
            if (tmpdouble > 0)
            {
                return true;
            }
            sql = "select isnull(sum(discount),0) from repair_i where dh='" + dh + "'";
            dt = mDB.ExecuteDataTable(sql);
            tmpstr = dt.Rows[0][0].ToString();
            tmpdouble = double.Parse(tmpstr);
            if (tmpdouble > 0)
            {
                return true;
            }
            return isDiscount;
        }

    
        public string GetPVOfRepair(int year,int month,bool isrepair,bool isclaim,bool iszh)
        {
            string begindate;
            string enddate;
            decimal result = 0;
            begindate = year + "-" + month + "-1";
            if (month == 12)
            {
                month = 1;
                year += 1;

            }
            else
                month += 1;
            enddate = year + "-" + month + "-1";

            string sql = string.Format("select isnull(sum(gamount),0) from repair where  status=3 and reptype='维修' and accounttime>='{0}' and accounttime<'{1}'",begindate,enddate);
            DataTable dt ;
            if (isrepair)
            {
                dt = mDB.ExecuteDataTable(sql);
                if (dt.Rows.Count > 0)
                    result += decimal.Parse(dt.Rows[0][0].ToString());
            }

            //if (isclaim)
            //{
            //    sql = string.Format("select isnull(sum(amount),0) from financeaccounts  where AcceptDate >='{0}'  and AcceptDate<'{1}' and status=1 and describes='索赔收款'", begindate, enddate);
            //    dt = mDB.ExecuteDataTable(sql);
            //    if (dt.Rows.Count > 0)
            //        result += decimal.Parse(dt.Rows[0][0].ToString());
            //}


            //if (isclaim)
            //{
            //    sql = string.Format("select isnull(sum(accessamount),0) from claimh  where AccessDate >='{0}'  and AccessDate<'{1}' ", begindate, enddate);
            //    dt = mDB.ExecuteDataTable(sql);
            //    if (dt.Rows.Count > 0)
            //        result += decimal.Parse(dt.Rows[0][0].ToString());
            //}


            if (isclaim)
            {
                sql = string.Format("select isnull(sum(allamount),0) from claimbillh  where CreateDate >='{0}'  and CreateDate<'{1}'  and status=1", begindate, enddate);
                dt = mDB.ExecuteDataTable(sql);
                if (dt.Rows.Count > 0)
                    result += decimal.Parse(dt.Rows[0][0].ToString());
            }


            if (iszh)
            {
                sql = string.Format("select isnull(sum(gamount),0) from repair where  status=3 and repchildtype='原厂装潢' and accounttime>='{0}' and accounttime<'{1}'", begindate, enddate);
                dt = mDB.ExecuteDataTable(sql);
                if (dt.Rows.Count > 0)
                    result += decimal.Parse(dt.Rows[0][0].ToString());
            }

            return result.ToString() ;

        }


        public DataTable GetLostCustomers(int months)
        {

            DateTime dtEnd = DateTime.Now;
            DateTime dtBegin = dtEnd.AddMonths(-months);
            string sql = "select mobile,custname,platenum,vin,accounttime from v_customer1 where mobile not in ";
            sql += string.Format("(select mobile from repair where accounttime>'{0}' and accounttime<'{1}' and reptype='维修')",dtBegin,dtEnd);

            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }

        public DataTable GetLoyalCustomers(string strbegin,string strend,int count)
        {
            string sql = "";
         
           


            if (strbegin != "")
            {
                sql = string.Format("select count(*) as count ,max(mobile) as mobile,max(custname) as custname,max(platenum) as platenum,max(vin) as vin,max(AccountDate) as AccountDate from v_repandsale  where accounttime>'{0}' and accounttime<'{1}' and len(platenum)>2 and RepType='维修' group by platenum having count(*)>={2} order by count(*) desc", strbegin, strend, count);

            }
            else
            {
                DateTime dtEnd = DateTime.Now;
                DateTime dtBegin = dtEnd.AddMonths(-12);
                sql = string.Format("select count(*) as count ,max(mobile) as mobile,max(custname) as custname,max(platenum) as platenum,max(vin) as vin,max(AccountDate) as AccountDate from v_repandsale  where accounttime>'{0}' and accounttime<'{1}' and len(platenum)>2 and RepType='维修' group by platenum having count(*)>=3 order by count(*) desc", dtBegin, dtEnd);
            }
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }


        public DataTable GetSumOfRepProfits(string strBegin, string strEnd, int year, int month)
        {
            string sql = "select  sum(PreItemAmount) as ItemProfit,sum(PreAccessoryAmount) as AccProfit, sum(Ginprice) as Ginprice,cast(sum(PreItemAmount+PreAccessoryAmount-GInprice) as decimal(18,2))  as GProfit,sum(Gamount) as Gamount from repair where reptype='维修' and  gamount>0 ";
            string begindate = string.Format("{0}-{1}-1", year, month);

            if (month == 12)
            {
                month = 1;
                year = year + 1;
            }
            else
                month = month + 1;
            string enddate = string.Format("{0}-{1}-1", year, month);

            if (strBegin != "")
                sql = sql + string.Format(" and accounttime>='{0}' and accounttime<='{1}'  and status=3", strBegin, strEnd);
            else
                sql = sql + string.Format(" and  accounttime>='{0}' and accounttime<'{1}' and status=3", begindate, enddate);

            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;


        }


        public decimal GetYQCost1(string strBegin, string strEnd, string staffname, int year, int month, bool issg, string RepChildType, string receptor)
        {

            string sql = "";
            decimal result = 0;
            string sqlcondition;
            string begindate = string.Format("{0}-{1}-1", year, month);
            int fee;
            string organid;
            organid = Comm.LoginInfoShare.getInstance().OrganId;


            if (organid == "301")
                fee = 180;
            else
                fee = 130;
            if (month == 12)
            {
                month = 1;
                year = year + 1;
            }
            else
                month = month + 1;
            string enddate = string.Format("{0}-{1}-1", year, month);


            sql = string.Format("select isnull(sum(empworkH),0)*{0}  from repair_i where dh in", fee);
            sqlcondition = "(select dh from repair where gamount>0 and accounttime<'2017-9-26' ";

            // sqlcondition = sqlcondition + "";
            if (strBegin != "")
                sqlcondition = sqlcondition + string.Format(" and accounttime>='{0}' and accounttime<='{1}'  and status=3 ", strBegin, strEnd);
            else
                sqlcondition = sqlcondition + string.Format(" and  accounttime>='{0}' and accounttime<'{1}' and status=3 ", begindate, enddate);


           sqlcondition += "and RepChildType  not like '%索赔%' and RepChildType  not like '%免费%' ";

            sqlcondition += string.Format(" and RepChildType like '%{0}%' and ReceptMan like '%{1}%'", RepChildType, receptor);


            if (issg)
            {
                sqlcondition += " and RepChildType not like '%事故%'";
            }
            sqlcondition += ")";

            sql += sqlcondition;

            if (!string.IsNullOrEmpty(staffname))
                sql += " and workman in " + staffname;
            else
                sql += " and workman in ('x')";


            // + string.Format("  accounttime>='{0}' and accounttime<='{1}'  and status=3", strBegin, strEnd) + " and RepChildType like ('%事故%')" + " and  IsNull(InsuranceCompany,'') like '%" + inname + "%' ";
            //if (!string.IsNullOrEmpty(comtype))
            //    sqlcondition += "and IsNull(ComeType,'自然进店') like'%" + comtype + "%'";
            //sqlcondition += ")";
            //sql += sqlcondition;
            //if (!string.IsNullOrEmpty(staffname))
            //    sql += " and workman in " + staffname;


            // sql += " and typeofwork like '%油漆%'" ;
            DataTable dt;

            //if (organid == "258")
            //{
            //    sql = " select isnull(sum(amount),0) from repair_a where dh in ";
            //    sql += sqlcondition;
            //    sql += " and accessorycode ='Z99702007777'";
            //    //result = 0;
            //    dt = mDB.ExecuteDataTable(sql);
            //    result = decimal.Parse(dt.Rows[0][0].ToString());
            //    return result;
            //}

            dt = mDB.ExecuteDataTable(sql);
            result = decimal.Parse(dt.Rows[0][0].ToString());
            return result;
        }
        public decimal GetYQCost(string strBegin, string strEnd,string staffname,string inname,string comtype)
        {

            string sql = "";
            decimal result = 0;
            string sqlcondition;
            string organid;
            int  fee;
            organid = Comm.LoginInfoShare.getInstance().OrganId;


            if (organid == "301")
                fee = 180;
            else
                fee = 130;

            sql =string.Format( "select isnull(sum(empworkH),0)*{0}  from repair_i where dh in",fee);
            sqlcondition = "(select dh from repair where " + string.Format("  accounttime>='{0}' and accounttime<='{1}'  and status=3", strBegin, strEnd) + " and RepChildType like ('%事故%')" + " and  IsNull(InsuranceCompany,'') like '%" + inname + "%' and accounttime<'2017-9-26' ";
            if(!string.IsNullOrEmpty(comtype))
                sqlcondition += "and IsNull(ComeType,'自然进店') like'%" + comtype + "%'";
            sqlcondition+=")";
            sql += sqlcondition;
            if(!string.IsNullOrEmpty(staffname))
            sql += " and workman in " + staffname    ;
           // sql += " and typeofwork like '%油漆%'" ;
            DataTable dt = mDB.ExecuteDataTable(sql);
            result = decimal.Parse(dt.Rows[0][0].ToString());

         
            //if (organid == "258")
            //{
            //    sql = " select isnull(sum(amount),0) from repair_a where dh in ";
            //    sql += sqlcondition;
            //    sql += " and accessorycode ='Z99702007777'" ;
            //   //result = 0;
            //    dt = mDB.ExecuteDataTable(sql);
            //    result =  decimal.Parse(dt.Rows[0][0].ToString());
            //}

            return result;
        }


        public DataTable GetAccidentProfits(string strBegin, string strEnd,int min,int max,string inname,string cometype)
        {
            string sql = "select RepChildType,DH,ComeType as cometype,accounttime,a.PlateNum,a.CustName,Gamount,Cast(PreItemAmount as decimal(18,2)) as ItemProfit,Cast(PreAccessoryAmount as decimal(18,2)) as AccProfit, Ginprice,Cast((PreItemAmount+PreAccessoryAmount-GInprice) as decimal(18,2)) as GProfit ,case Gamount when 0  then 0  else   Cast((PreItemAmount+PreAccessoryAmount-GInprice)/Gamount as decimal(18,2))  end as PRate,b.InsuranceCompany,c.cash,c.vip,c.bank,c.cs,c.SelfAmount from repair as a left join  carofcustomer as b on a.PlateNum=b.PlateNum left join financeaccounts as c on a.dh =c.dhfrom  where RepChildType like ('%事故%')  and   c.Describes='售后'";
            if (strBegin != "")
                sql = sql + string.Format(" and accounttime>='{0}' and accounttime<='{1}'  and a.status=3", strBegin, strEnd);
            if (min > 0)
                sql = sql + string.Format(" and Gamount>{0}",min);
            if (max> 0)
                sql = sql + string.Format(" and Gamount<{0}", max);

            sql = sql + " and  IsNull(b.InsuranceCompany,'') like '%" + inname + "%'";
            if(!string.IsNullOrEmpty(cometype))

                sql = sql + " and ComeType like '%" + cometype + "%'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }


        public DataTable GetRepType(string strBegin, string strEnd)
        {
            string sql = "select count(*) as Count,max(RepChildType) as RepChildType,sum(PreItemAmount) as PreItemAmount,sum(PreAccessoryAmount) as PreAccessoryAmount ,sum(Gamount) as GAmount  from repair where status=3 ";
            sql = sql + string.Format(" and accounttime>='{0}' and accounttime<='{1}'  and status=3", strBegin, strEnd);

            sql = sql + string.Format(" and  accounttime>='{0}' and accounttime<'{1}' and status=3", strBegin, strEnd);

            sql += " group by RepChildType";


            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }

        public DataTable GetRepInCompany(string strBegin, string strEnd)
        {
            string sql = "select count(*) as Count,max(InsuranceCompany) as InsuranceCompany,sum(PreItemAmount) as PreItemAmount,sum(PreAccessoryAmount) as PreAccessoryAmount ,sum(Gamount) as GAmount  from v_repair where status=3  and RepChildType='事故维修' "; 
            sql = sql + string.Format(" and accounttime>='{0}' and accounttime<='{1}'  and status=3", strBegin, strEnd);

            sql = sql + string.Format(" and  accounttime>='{0}' and accounttime<'{1}' and status=3", strBegin, strEnd);

            sql += " group by InsuranceCompany";


            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }




        public DataTable GetRepProfits(string strBegin, string strEnd, int year, int month, bool issg, string RepChildType, string receptor, bool iszh, string PlateNum)
        {
            string sql = "select DH,RepChildType,accounttime,PlateNum,CustName,ReceptMan,cast(Gamount  as decimal(18,2)) as Gamount,Cast(PreItemAmount as decimal(18,2)) as ItemProfit,Cast(PreAccessoryAmount as decimal(18,2)) as AccProfit, Ginprice,Cast((PreItemAmount+PreAccessoryAmount+isnull(AccessAmount,0)-GInprice) as decimal(18,2)) as GProfit,case (Gamount+isnull(AccessAmount,0)) when 0  then 0  else   Cast((Gamount+isnull(AccessAmount,0)-GInprice)/(Gamount+isnull(AccessAmount,0))  as decimal(18,2))  end as PRate,isnull(AccessAmount,0) as AccessAmount  from v_repair where ";


            if(!iszh)
                sql+= "reptype='维修'";
            else
                sql += "reptype='装潢'";


            //sql += "and RepChildType  not like '%索赔%' and RepChildType  not like '%免费%' ";
            sql += string.Format(" and RepChildType like '%{0}%' and ReceptMan like '%{1}%' and PlateNum like '%{2}%'", RepChildType, receptor,PlateNum);
            if (issg)
            {
                sql +=" and RepChildType not like '%事故%'";
            }
            string begindate = string.Format("{0}-{1}-1", year, month);

            if (month == 12)
            {
                month = 1;
                year = year + 1;
            }
            else
                month = month + 1;
            string enddate = string.Format("{0}-{1}-1", year, month);

            if (strBegin != "")
                sql = sql + string.Format(" and accounttime>='{0}' and accounttime<='{1}'  and status=3", strBegin, strEnd);
            else
                sql = sql + string.Format(" and  accounttime>='{0}' and accounttime<'{1}' and status=3", begindate, enddate);

            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }


        public void ModifyCustNameOfRepair(string dh, string newname)
        {
            string sql;
            sql = string.Format("update Repair set CustName='{0}' where dh='{1}' ", newname, dh);
            mDB.ExecuteNonQuery(sql);
            sql = string.Format("update financeaccounts set CustName='{0}' where dhfrom='{1}'", newname, dh);
            mDB.ExecuteNonQuery(sql);
        }

        public void UpdateSumDataOfRepair(string dh,float accamount,float itemamount,decimal ginprice)
        {
            string sql;
            sql = string.Format("update Repair set PreItemAmount={0}, PreAccessoryAmount={1},GInprice={2} where dh='{3}' ", itemamount, accamount,ginprice,dh);
            mDB.ExecuteNonQuery(sql);

        }

        public string GetLastInMil(string palte,string indate)
        {
            string mil="";
            string sql = string.Format("select top 1 Inmil from repair where  platenum='{0}' and accounttime<'{1}' order by accounttime desc", palte, indate);
            DataTable dt=mDB.ExecuteDataTable(sql);
            if(dt.Rows.Count>0)
            {
                mil = dt.Rows[0][0].ToString();

            }
            return mil;
        }

        public void SetRepOut(string dh)
        {
            string sql = string.Format("update repair set CompleteTime=getdate() where dh='{0}'",dh);
            mDB.ExecuteNonQuery(sql);

        }


        public string GetCustType(string plate)
        {
            int count=0;
            string cutType="";
            DateTime endDate = DateTime.Now;
            DateTime beginDate = endDate.AddYears(-1);
            string sql = string.Format("select isnull(count(*),0) from  repair where accounttime>'{0}' and accounttime<'{1}' and platenum='{2}'",beginDate.ToShortDateString(),endDate.ToShortDateString(),plate);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                count = int.Parse(dt.Rows[0][0].ToString());
            }
            if (count == 1)
                cutType = "D类";
            else if(count ==2)
                cutType = "C类";
            else if (count == 3)
                cutType = "B类";
            else if (count >4)
                cutType = "A类";
            return cutType;
                    
        }


        public DataTable GetReceptReport(string strbegin,string strend)
        {
            string sql = string.Format("select max(receptman) as receptman,count(*) as count,cast(sum(Gamount) as decimal(18,2)) as Gamount,cast(sum(AccessAmount) as decimal(18,2)) as GClaim ,cast(Sum(PreItemAmount) as decimal(18,2)) as ItemAmount ,Cast(Sum(PreAccessoryAmount) as decimal(18,2)) as AccessoryAmount,Sum(Ginprice) as Ginprice,cast((IsNull(sum(Gamount),0)+IsNull(sum(AccessAmount),0)-IsNull(Sum(Ginprice),0)) as decimal(18,2)) as profit from v_repandclaim where accounttime>='{0}' and accounttime<='{1}' and reptype ='维修' group by receptman", strbegin, strend);

            return mDB.ExecuteDataTable(sql);

        }

        public decimal GetKeepAccValue(string strbegin, string strend,string receptman)
        {
            decimal result = 0;
            string sql = string.Format("select IsNUll(sum(finalprice),0) as keepprice from  v_keepacc where accounttime>='{0}' and accounttime<='{1}' and receptman='{2}'",strbegin,strend ,receptman);
            DataTable dt=mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                result = decimal.Parse(dt.Rows[0][0].ToString());

            }
            return result;
        }


        public decimal GetProfitOfZh(string saledh)
        {

            //string sql = string.Format("select Isnull(sum(inprice),0) from repair_a where dh in (select dh from repair where decoratedh='{0}') and finalprice>0 and acctype=1", saledh);
            //decimal je = 0;
            //DataTable dt = mDB.ExecuteDataTable(sql);
            //if (dt.Rows.Count > 0)
            //{
            //    je = decimal.Parse(dt.Rows[0][0].ToString());

            //}
            string sql =string.Format( "select accessorycode from repair_a where dh in (select dh from repair where decoratedh='{0}' and status=3 and gamount>0) and  acctype=0",saledh);
            decimal je = 0;
            DataTable dt = mDB.ExecuteDataTable(sql);
            string accessoryCode="";
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                accessoryCode = accessoryCode + "'" + dt.Rows[i][0].ToString() +"'"+ ",";

            }
            if (!string.IsNullOrEmpty(accessoryCode))
            {
               accessoryCode= accessoryCode.Remove(accessoryCode.Length-1);

                sql = "select sum(inprice) as inprice from v_accinprice where AccessoryCode in (" + accessoryCode + ")";

                dt = mDB.ExecuteDataTable(sql);
                if (dt.Rows.Count > 0)
                {

                    je = decimal.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0][0].ToString()));

                }
            }
           
            return je;
        }
       
        public decimal GetJeOfYQ(string dh)
        {
            decimal result=0;
            string sql = string.Format("select isnull(sum(finalprice),0) from repair_i as a inner join repairitem as b on a.itemcode = b.itemcode where b.itemcode like 'YQ%' and a.dh='{0}'",dh.Trim());
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                result = decimal.Parse(dt.Rows[0][0].ToString());

            }
            return result;
        }


        public decimal GetJeOfGS(string dh)
        {
            decimal result = 0;
            string sql = string.Format("select isnull(sum(finalprice),0) from repair_i as a inner join repairitem as b on a.itemcode = b.itemcode where b.itemcode not like 'YQ%' and a.dh='{0}'", dh.Trim());
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                result = decimal.Parse(dt.Rows[0][0].ToString());

            }
            return result;
        }


        public void ReAccount(double account,string dh)
        {
            string sql = string.Format("update repair set gamount={0},status=2 where dh='{1}';update financeaccounts set status=0,amount={0},recamount=0 where dhfrom='{1}'", account, dh);

            mDB.ExecuteNonQuery(sql);

        }

        public bool IsAllfWorkerAdded(string dh)
        {
            string sql = string.Format("select * from repair_i where len(WorkMan)<1 and dh='{0}'",dh);
            if (mDB.IsExists(sql))
                return false;
            else
                return true;
        }

        public void CalculateDecorateCost(string saleDH, string vin, decimal PresentDecorPrice)
        {
            string sql = "";

            decimal gaward= 0;
            decimal gamount = 0;
           // decimal award = 0;
            decimal ginprice=0;

            decimal aomunt=0;
            decimal inprice = 0;
            string dh;

            //if (saleDH == "102CS1903180003")
            //    inprice = 0;
            sql = "select dh,gamount from repair where  status=3  and decorateDH='" + saleDH + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dh = dt.Rows[i]["dh"].ToString();
                aomunt = decimal.Parse(dt.Rows[i]["gamount"].ToString());
                inprice = this.GetAccInPriceOfDH(dh);

                if (aomunt>0 && inprice > 0)
                {
                    gamount = gamount + aomunt;
                    ginprice = ginprice + inprice;
                   // award = aomunt - inprice;
                   // gaward = gaward + award;
                }
            }

            gaward = (gamount - ginprice - PresentDecorPrice) * 0.1m;
          //  if (gaward < 0) gaward = 0;
            sql = string.Format("update carsale set DecorateAward={0},DecorateCost={2} where dh='{1}'", gaward, saleDH, ginprice + PresentDecorPrice);
            mDB.ExecuteNonQuery(sql);

        }





        public decimal GetCostOfDecorate(string dh)
        {
            string sql = string.Format("select accessorycode from repair_a where dh='{0}'  and acctype=0",dh);
            decimal gcost = 0m;
            DataTable dt = mDB.ExecuteDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gcost=gcost+GetRecentCostOfAcc(dt.Rows[0][0].ToString());

            }

            return gcost;
        }

        private decimal GetRecentCostOfAcc(string acccode)
        {
             decimal cost = 0;

             string sql = "select top 1 inprice from accware where AccessoryCode='" + acccode +"' order by ID desc";
             DataTable dt = mDB.ExecuteDataTable(sql);

             if (dt.Rows.Count > 0)
             {
                 cost =decimal.Parse( dt.Rows[0][0].ToString());

             }
             return cost;
        }


    }




}
