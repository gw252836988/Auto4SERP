using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data ;
using Model;
using DBUtil;
using Comm;
namespace Bll.Repair
{
    public class ClaimBll : Bll.Repair.IClaim 
    {
         private DBHelper mDB;

         public ClaimBll()
        {
            mDB = DBHelperShare.getInstance();
        }

        public void CreateClaimH(List<SqlElement> lstm)
        {
            string sql;
            sql = CreateSqlUtil.CreateInsertSql(lstm, "claimh");
            mDB.ExecuteNonQuery(sql);

        }


        public DataTable  GetSumAccessAmountOfClaims(List<SqlElement> list, string status, int datetype,string strBegin, string strEnd, bool isSelect)
        {
             //decimal sum=0;
             string sql = "select isnull(sum(AccessAmount),0),isnull(sum(accAmount),0),isnull(sum(itemAmount),0) from claimh where ";
             string Condition="";
             if (list != null && list.Count > 0)
                 Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
             else
                 Condition = Condition + "1=1";



             if (isSelect)
                 Condition = Condition + " and billdh is  NULL";

             if (status == "已通过")
                 Condition = Condition + " and status=1";
             else if (status == "未通过")
                 Condition = Condition + " and status=0";

             if (datetype == 1)
                 Condition = Condition + string.Format(" and AccountDate>='{0}' and AccountDate<='{1}'", strBegin, strEnd);
             else if (datetype == 2)
                 Condition = Condition + string.Format(" and AccessDate>='{0}' and AccessDate<='{1}'", strBegin, strEnd);
            
             sql = sql + Condition;
             DataTable dt = mDB.ExecuteDataTable(sql);

             //if (dt.Rows.Count > 0)
             //{
             //    sum = decimal.Parse(dt.Rows[0][0].ToString());
             //}
             return dt;
        }




        public DataTable GetOutClaimsOfQuery(List<SqlElement> list, string status, int datetype,string strBegin, string strEnd, bool isSelect)
        {

            string sql,Condition="";
            sql = "select case when status=0 then '未通过' when status=1 then '已确认'  else '已通过' end  as cstatus,RepDH,ClaimDH,CreateDate,AccountDate,AccessDate,CustName,PlateNum,Vin,AccAmount,ItemAmount,ElseAmount,ClaimAmount,AccessAmount,PostMan,ReceptMan,BillDH from claimh where ";
            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";



            if (isSelect)
                Condition = Condition + " and billdh is  NULL";

            if (status == "已通过")
                Condition = Condition + " and status=1";
            else if (status == "未通过")
                Condition = Condition + " and status=0";


            if(datetype==1)
                Condition = Condition + string.Format(" and AccountDate>='{0}' and AccountDate<='{1}'", strBegin, strEnd);
            else if(datetype==2)
                Condition = Condition + string.Format(" and AccessDate>='{0}' and AccessDate<='{1}'", strBegin, strEnd);
            
            sql = sql + Condition;
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }

        public DataTable GetClaimsOfQuery(List<SqlElement> list, string status, int datetype, string strBegin, string strEnd, bool isSelect, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string IndexField = "ID";
            string AllFields = "ID,case when status=0 then '未通过' when status=1 then '已确认'  else '已通过' end  as cstatus,RepDH,ClaimDH,AccAmount,ItemAmount,ClaimAmount,CustName,PlateNum,Vin,AccessAmount,PostMan,CreateDate,AccessDate,ElseAmount,ReceptMan,AccountDate,BillDH";
            string Condition = "claimh where ";
            string OrderFields = "order by AccountDate desc";

            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

            

            if (isSelect)            
                Condition = Condition + " and billdh is  NULL";
          
            if (status == "已通过")
                Condition = Condition + " and status=1";
            else if(status == "未通过")
                Condition = Condition + " and status=0";


            if (datetype == 1)
                Condition = Condition + string.Format(" and AccountDate>='{0}' and AccountDate<='{1}'", strBegin, strEnd);
            else if (datetype == 2)
                Condition = Condition + string.Format(" and AccessDate>='{0}' and AccessDate<='{1}'", strBegin, strEnd);

            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;
        }

        public DataTable GetClaim(string dh)
        {
            string sql = "select * from claimh where repDH='" + dh + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return dt;

            }
            return null;
        }

        public void UpdateClaim(string dh,string claimdh,double itemamount,double accamount ,double elseamount,double claimamount)
        {
            string sql = "";
            sql = string.Format("update claimh set claimdh='{0}',elseamount={1},ClaimAmount={2},itemamount={4},accamount={5} where repdh='{3}'", claimdh, elseamount, claimamount, dh,itemamount,accamount);
            mDB.ExecuteNonQuery(sql);

        }

        public void SetRepToClaim(string dh)
        {

            string sql = "update repair set isclaim=1 where dh='"+ dh+ "'";
            mDB.ExecuteNonQuery(sql);
        }

        public void AccessClaim(string dh,double accessamount)
        {
            string sql = "";
            sql = string.Format("update claimh set AccessAmount={0},accessdate=getdate(),status=1  where repdh='{1}'", accessamount, dh);
            mDB.ExecuteNonQuery(sql);

        }

        public string  AddClaimBill(decimal allamount)
        {
            string sql;
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("DH", "dbo.GetClaimBillDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", false));
            lst.Add(new SqlElement("allamount", allamount.ToString(),false));
            sql = CreateSqlUtil.CreateInsertSql(lst, "claimbillh");

            sql = sql + " SELECT @@IDENTITY AS Id ";
            DataTable dt = mDB.ExecuteDataTable(sql);
            string id = dt.Rows[0][0].ToString();
            sql = "select dh from claimbillh where id =" + id;
            dt = mDB.ExecuteDataTable(sql);
            string dh = dt.Rows[0][0].ToString();
            return dh; 


        }


        public void SetBillDHOfRep(string dh,string billdh)
        {   
            string sql="";
            if(string.IsNullOrEmpty(billdh))
                sql = sql = string.Format("update claimh set billdh =NULL where repdh='{0}'", dh);
            else
                sql=string.Format("update claimh set billdh ='{0}' where repdh='{1}'",billdh ,dh);
            mDB.ExecuteNonQuery(sql);

        }
        public void AddClaimBllD(string dh,List<string> lst)
        {
            string sql="";
            foreach(string str in lst)
            {
                sql = string.Format("insert claimbilld(dh,repdh) values('{0}','{1}')",dh,str);
                mDB.ExecuteNonQuery(sql);
                SetBillDHOfRep(str,dh);
                
            }

            double amount = GetAllAmountOfBill(dh);

            sql = string.Format("update claimbillh set allamount={0} where dh='{1}'",amount ,dh);
            mDB.ExecuteNonQuery(sql);
        }

        public void DelClaimBllD(string dh,string repdh)
        {

            string sql;
            sql = string.Format("delete from claimbilld where dh='{0}' and repdh='{1}'",dh,repdh);
            mDB.ExecuteNonQuery(sql);
            double amount = GetAllAmountOfBill(dh);

            sql = string.Format("update claimbillh set allamount={0} where dh='{1}'", amount, dh);
            SetBillDHOfRep(repdh,"");
            mDB.ExecuteNonQuery(sql);
        }
        public DataTable GetClaimDOfBill(string billdh)
        {
            string sql;

            sql = string.Format("select ID,RepDH,ClaimDH,AccAmount,ItemAmount,ClaimAmount,CustName,PlateNum,Vin,AccessAmount,PostMan,CreateDate,AccessDate,ElseAmount,ReceptMan,AccountDate from claimh where repdh in (select repdh from claimbilld where dh='{0}')",billdh);
            return mDB.ExecuteDataTable(sql);
        }


        public void UpdateStatusClaimBillH(int status, string dh)
        {
            string sql;
            sql = string.Format("update claimbillh set status={0} where dh='{1}'",status ,dh); ;
            mDB.ExecuteNonQuery(sql);
        }

        public int GetStautsOfClaimBillH(string dh)
        {
            string sql;
            int i=0;
            sql = "select status from claimbillh where dh='" + dh + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
                i = int.Parse(dt.Rows[0][0].ToString());
            return i;
        }

        public double  GetAmountOfClaimBillH(string dh)
        {

            string sql;
            double i = 0;
            sql = "select Allamount from claimbillh where dh='" + dh + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
                i = double.Parse(dt.Rows[0][0].ToString());
            return i;


        }
       
        public double GetAllAmountOfBill(string billdh)
        {
            string sql;

            sql = string.Format("select isnull(sum(AccessAmount),0) as sum from claimh where repdh in (select repdh from claimbilld where dh='{0}')", billdh);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return double.Parse(dt.Rows[0][0].ToString());
        }


        public bool DelClaimBill(string dh)
        {
            string sql = "select * from claimbilld where dh='" + dh +"'";
            if (mDB.IsExists(sql))
                return false;
            else
            {
                sql = "delete from claimbillH where dh='" + dh + "'";
                mDB.ExecuteNonQuery(sql);
                return true;
            }

        }


        public DataTable GetClaimBills(string strBegin, string strEnd, List<SqlElement> list)
        {
            //order by createdate desc
            string sql = "select case when status=0 then '未提交'   when status=1 then '已提交'  else '已收款' end  as status,DH,AllAmount,CreateDate,AcceptDate from claimbillh  ";
            string Condition = " where ";

            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

            if (strBegin != "")
                Condition = Condition + string.Format(" and CreateDate>='{0}' and CreateDate<='{1}'", strBegin, strEnd);
           
            sql = sql + Condition;
            sql = sql + " order by createdate desc";
            return mDB.ExecuteDataTable(sql);

        }
    }
}
