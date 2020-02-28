﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Comm;
using DBUtil;
using System.Data;
using System.Data.SqlClient;
using Bll.Sale;
namespace Bll
{
    public class FinanceBll:IFinance
    {

        private DBHelper mDB;
        public FinanceBll()
        {
            mDB = DBHelperShare.getInstance();
        }

        //public bool AddAmount(double amount,string dh,string describes)
        //{
        //    string sql = string.Format("insert into financeaccounts(Amount,dhFrom,Describes,CreateDate) values({0},'{1}','{2}',getdate())", amount, dh, describes);
        //    int k = mDB.ExecuteNonQuery(sql);
        //    if (k > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public bool AddAccountOfRec(Account obj)
        {
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("Amount", obj.Amount.ToString(), false));
            list.Add(new SqlElement("DHFrom", obj.DHFrom, true));
            list.Add(new SqlElement("Describes", obj.Describes, true));
           // list.Add(new SqlElement("AccountDate", "getdate()", false));
            list.Add(new SqlElement("AcceptDate", obj.AcceptDate, true));
            list.Add(new SqlElement("CustName", obj.CustName, true));
            list.Add(new SqlElement("Mobile", obj.Mobile, true));
            list.Add(new SqlElement("PlateNum", obj.PlateNum, true));
            list.Add(new SqlElement("RecAmount", obj.Amount.ToString(), true));
            list.Add(new SqlElement("Status", "1", true));
            list.Add(new SqlElement("Cash", obj.Cash.ToString(), true));
            list.Add(new SqlElement("Bank", obj.Bank.ToString(), true));
            list.Add(new SqlElement("ReceiveMan", obj.ReceiveMan, true));

            string sql = CreateSqlUtil.CreateInsertSql(list, "financeaccounts");
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;


        }
        public bool AddAmount(Account obj)
        {
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("Amount", obj.Amount.ToString(), false));
            list.Add(new SqlElement("DHFrom", obj.DHFrom, true));
            list.Add(new SqlElement("Describes", obj.Describes, true));
            list.Add(new SqlElement("AccountDate", "getdate()", false));
            list.Add(new SqlElement("CustName",obj.CustName, true ));
            list.Add(new SqlElement("Mobile", obj.Mobile, true ));
            list.Add(new SqlElement("PlateNum", obj.PlateNum, true));

            string sql = CreateSqlUtil.CreateInsertSql(list, "financeaccounts");
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetDetailsOfAmount(string dh)
        {
            string sql = "select [ID],amount as AmountPost,case when status =0 then '未收款' else '已收款'  end as Status from financeaccounts where DHFrom='" + dh + "'";

            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }

        public void DelAccount(string dh,int accountid,double amount,string type)
        {
            //数据库判断是否已收款
            string sql = string.Format("select * from financeaccounts  where id={0} and status=0",accountid);
            if (mDB.IsExists(sql))
            {
                sql = string.Format("delete from financeaccounts where id={0}", accountid);
                mDB.ExecuteNonQuery(sql);
                if(type=="整车销售")
                    sql = string.Format("update carsale set amountpost=amountpost-{1} where dh='{0}' ", dh, amount);
                else if (type == "销售订金")
                    sql = string.Format("update carorder set amountsum=amountsum-{1} where dh='{0}' ", dh, amount);
                mDB.ExecuteNonQuery(sql);
            }

        }

        public void DelAccountOfRep(string dh)
        {
            string sql;
             sql="select * from financeaccounts where dhfrom='"+ dh + "' and status=0";
             if (mDB.IsExists(sql))
             {
                 sql = "delete from financeaccounts where dhfrom='" + dh + "'";
                 mDB.ExecuteNonQuery(sql);
             }
           

        }



        public DataTable GetP2PAccounts(string strBegin, string strEnd ,string mobile)
        {

            string sql = "select * from p2precv ";
            sql = sql + string.Format(" where  RecDate>='{0}' and RecDate<='{1}' and mobile like '%{2}%'", strBegin, strEnd,mobile);
            return mDB.ExecuteDataTable(sql);
        }


        //public DataTable GetAccountsNoPage(string strBegin, string strEnd, List<SqlElement> list, int dateType)
        //{

        //    string sql = "select ID,CustName,Mobile,Describes,Amount,RecAmount ,DHFrom,AccountDate,AcceptDate,ReceiveMan, case when status =0 then '未收款'  when status =1 then '已收款' else '退款'  end as Status,Cash,Bank,Vip,CheckAmount,P2P,CS,Other,PreRecv,InvoiceNum,InvoiceAmount";


        //}


        public DataTable GetOutToAccounts(string strBegin, string strEnd, List<SqlElement> list, int dateType)
        {
           // string sql = "select  ID,CustName,Mobile,Describes,Amount,RecAmount ,DHFrom,AccountDate,AcceptDate,ReceiveMan, case when status =0 then '未收款'  when status =1 then '已收款' else '退款'  end as Status,Cash,Bank,Vip,CheckAmount,SelfAmount,P2P,CS,Other,PreRecv,InvoiceNum,InvoiceAmount ";
            string sql = "select ID, case when status =0 then '未收款'  when status =1 then '已收款' else '退款'  end as Status,CustName,Plate,Mobile,Describes,Amount,RecAmount,DHFrom,AccountDate,AcceptDate,ReceiveMan,Cash,Bank,CheckAmount,Vip,P2P,Quan,cs,SelfAmount,other,PreRecv,Integral,InvoiceNum,InvoiceAmount from ";
            string Condition = " v_financeaccounts where ";
            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

            if (dateType == 1)
            {
                Condition = Condition + string.Format(" and AccountDate>='{0}' and AccountDate<='{1}'", strBegin, strEnd);
            }
            else if (dateType == 2)
            {
                Condition = Condition + string.Format(" and AcceptDate>='{0}' and AcceptDate<='{1}'", strBegin, strEnd);

            }
            sql += Condition;
            sql +=  "order by AccountDate desc";
            return mDB.ExecuteDataTable(sql);

        }


        public DataTable GetAccountsOfDebt(string strBegin, string strEnd, List<SqlElement> list, int dateType)
        {
           
            string sql = "select ID,CustName,Plate,Mobile,Describes,Amount,RecAmount ,DHFrom,AccountDate,AcceptDate,ReceiveMan, case when status =0 then '未收款'  when status =1 then '已收款' else '退款'  end as Status,Cash,Bank,Vip,CheckAmount,SelfAmount,P2P,CS,Quan,Other,PreRecv,Integral,InvoiceNum,InvoiceAmount ";
            string Condition = " from v_financeaccounts where DHFrom like '%RP%' and   Describes='赊销回款' ";
          

            //if (list != null && list.Count > 0)
            //    Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            //else
            //    Condition = Condition + "1=1";

            if (dateType == 0)
            {
                Condition = Condition + string.Format(" and AccountDate>='{0}' and AccountDate<='{1}'", strBegin, strEnd);
            }
            else if (dateType == 1)
            {
                Condition = Condition + string.Format(" and AcceptDate>='{0}' and AcceptDate<='{1}'", strBegin, strEnd);

            }

            sql += Condition;
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }

        public DataTable GetAccounts(string strBegin, string strEnd, List<SqlElement> list, int dateType, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string IndexField = "ID";
            string AllFields = " ID,CustName,Plate,Mobile,Describes,Amount,RecAmount ,DHFrom,AccountDate,AcceptDate,ReceiveMan, case when status =0 then '未收款'  when status =1 then '已收款' else '退款'  end as Status,Cash,Bank,Vip,CheckAmount,SelfAmount,P2P,CS,Quan,Other,PreRecv,Integral,InvoiceNum,InvoiceAmount ";
            string Condition = "v_financeaccounts where ";
            string OrderFields = "order by AccountDate desc";

            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

            if (dateType == 1)
            {
                Condition = Condition + string.Format(" and AccountDate>='{0}' and AccountDate<='{1}'", strBegin, strEnd);
            }
            else if (dateType == 2)
            {
                Condition = Condition + string.Format(" and AcceptDate>='{0}' and AcceptDate<='{1}'", strBegin, strEnd);
             
            }
           

            //string sqlhead = "select";
            //string sqlhead1 = "select top 50 ";
            //string sql = " ID,CustName,Mobile,Describes,Amount,DHFrom,AccountDate,AcceptDate, case when status =0 then '未收款'  when status =1 then '已收款' else '退款'  end as Status from financeaccounts where 1=1 and ";
            //if (list != null)
            //    sql = sql + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            //else
            //    sql = sql + "1=1";
          

            //    if (dateType == 0)
            //    {
            //        sql = sqlhead1 + sql;
            //        sql = sql + " order by AccountDate desc";
            //    }
            //    else if (dateType == 1)
            //    {    
                    
            //        sql = sql + string.Format(" and AccountDate>='{0}' and AccountDate<='{1}'", strBegin, strEnd);
            //        sql = sql + " order by AccountDate desc";
            //        sql = sqlhead + sql;
                
            //    }
            //    else if (dateType == 2)
            //    {    
            //        sql = sql + string.Format(" and AcceptDate>='{0}' and AcceptDate<='{1}'", strBegin, strEnd);
            //        sql = sql + " order by AccountDate desc";
            //        sql = sqlhead + sql;
            //    }


            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;
        }


        public Account  GetAmountByID(int id)
        {
            string sql = string.Format("select amount,DhFrom,Describes,Status,platenum,acceptdate,vip,IsNull(cash,0) as cash,IsNull(bank,0) as bank,IsNull(p2p,0) as p2p,IsNull(cs,0) as cs,IsNull(PreRecv,0) as PreRecv,IsNull(Other,0) as Other,IsNull(Integral,0) as Integral,IsNull(Quan,0) as Quan,Remark,IsNull(InvoiceType,'') as InvoiceType ,IsNull(InvoiceNum,'') as InvoiceNum, IsNull(InvoiceAmount,0) as InvoiceAmount ,IsNull(SelfAmount,0) as SelfAmount from financeaccounts where id={0}", id);
            DataTable dt=  mDB.ExecuteDataTable(sql);
            double amount = 0;
            Account obj = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                 obj = new Account();
                 amount = double.Parse(dt.Rows[0][0].ToString());
                 obj.Amount = amount;
                 obj.DHFrom = dt.Rows[0][1].ToString();
                 obj.Describes = dt.Rows[0][2].ToString();
                 obj.Status = int.Parse(dt.Rows[0]["Status"].ToString());
                 obj.PlateNum = dt.Rows[0]["PlateNum"].ToString();
                 obj.AcceptDate = dt.Rows[0]["AcceptDate"].ToString();
                 obj.Vip = double.Parse(dt.Rows[0]["Vip"].ToString());
                 obj.Cash = double.Parse(dt.Rows[0]["Cash"].ToString());
                 obj.Bank = double.Parse(dt.Rows[0]["Bank"].ToString());
                 obj.P2P = double.Parse(dt.Rows[0]["P2P"].ToString());
                 obj.Cs = double.Parse(dt.Rows[0]["Cs"].ToString());
                 obj.Quan = double.Parse(dt.Rows[0]["Quan"].ToString());
                 obj.PreRecv = double.Parse(dt.Rows[0]["PreRecv"].ToString());
                 obj.Other = double.Parse(dt.Rows[0]["Other"].ToString());
                 obj.InvoiceType = dt.Rows[0]["InvoiceType"].ToString();
                 obj.InvoiceNum = dt.Rows[0]["InvoiceNum"].ToString();
                 obj.Self = double.Parse(dt.Rows[0]["selfamount"].ToString());
                 obj.InvoiceAmount = double.Parse(dt.Rows[0]["InvoiceAmount"].ToString());
                 obj.Remark = dt.Rows[0]["Remark"].ToString();
                 obj.Integral = double.Parse(dt.Rows[0]["Integral"].ToString());
            }
            return obj;

          }

        public void RefundAmount(int id,string describes)
        {

            string sql = string.Format("insert into financeaccounts(amount,dhfrom,describes, custname,mobile,acceptdate,{1},status,recamount) select 0-amount,dhfrom,describes,custname,mobile,getdate(),0-amount,2,0-amount from financeaccounts where id={0}", id, describes);
            mDB.ExecuteNonQuery(sql);


        }

        public void AfterRefund(int id)
        {
            string sql = string.Format("select describes ,amount, dhfrom from financeaccounts where id={0}", id);
            DataTable dt=mDB.ExecuteDataTable(sql);
            SqlParameter[] parameters = {
					
                    new SqlParameter("@vDescribes", SqlDbType.VarChar,20),
                    new SqlParameter("@vAmount", SqlDbType.Decimal),
                    new SqlParameter("@vDHFrom", SqlDbType.VarChar,20),
                    new SqlParameter("@vID", SqlDbType.Int)
					};
            parameters[0].Value = dt.Rows[0][0];
            parameters[1].Value = dt.Rows[0][1];
            parameters[2].Value = dt.Rows[0][2];
            parameters[3].Value =id;
            mDB.ExecuteNonQueryByPro("RefundAmount", parameters);
        }

        public void AcceptAmount(Account obj)
        {

            SqlParameter[] parameters = {
					new SqlParameter("@vID", SqlDbType.Int),
				    new SqlParameter("@vCash", SqlDbType.Decimal),
                    new SqlParameter("@vBank", SqlDbType.Decimal),
                    new SqlParameter("@vVip", SqlDbType.Decimal),
                    new SqlParameter("@vInvoiceType", SqlDbType.VarChar,20),
                    new SqlParameter("@vInvoiceNum", SqlDbType.VarChar,20),
                    new SqlParameter("@vInvoiceAmount", SqlDbType.Decimal),
                    new SqlParameter("@vDescribes", SqlDbType.VarChar,20),
                    new SqlParameter("@vAmount", SqlDbType.Decimal),
                    new SqlParameter("@vDHFrom", SqlDbType.VarChar,20),
                    new SqlParameter("@vReceiveMan", SqlDbType.VarChar,15),
                    new SqlParameter("@vP2P", SqlDbType.Decimal),
                    new SqlParameter("@vRecAmount", SqlDbType.Decimal),
                    new SqlParameter("@vCS", SqlDbType.Decimal),
                    new SqlParameter("@vPreRecv", SqlDbType.Decimal),
                    new SqlParameter("@vOther", SqlDbType.Decimal),
                    new SqlParameter("@vRemark", SqlDbType.VarChar,50),
                    new SqlParameter("@vCheckAmount", SqlDbType.Decimal),
                    new SqlParameter("@vSelfAmount", SqlDbType.Decimal),
                     new SqlParameter("@vQuan", SqlDbType.Decimal),
                     new SqlParameter("@vIntegral", SqlDbType.Decimal)
			        };

            parameters[0].Value = obj.ID;
            parameters[1].Value = obj.Cash;
            parameters[2].Value = obj.Bank;
            parameters[3].Value = obj.Vip;
            parameters[4].Value = obj.InvoiceType;
            parameters[5].Value = obj.InvoiceNum;
            parameters[6].Value = obj.InvoiceAmount;
            parameters[7].Value = obj.Describes;
            parameters[8].Value = obj.Amount;
            parameters[9].Value = obj.DHFrom;
            parameters[10].Value = obj.ReceiveMan;
            parameters[11].Value = obj.P2P;
            parameters[12].Value = obj.RecAmount;
            parameters[13].Value = obj.Cs;
            parameters[14].Value = obj.PreRecv;
            parameters[15].Value = obj.Other;
            parameters[16].Value = obj.Remark;
            parameters[17].Value = obj.Check;
            parameters[18].Value = obj.Self;
            parameters[19].Value = obj.Quan;
            parameters[20].Value = obj.Integral;
            mDB.ExecuteNonQueryByPro("AcceptAmount", parameters);
        }

        public string IsCanRefund(string describes,string dh,int id)
        {
            string info = "";

            string sql = string.Format("select isRefund,status,cs,vip from financeaccounts where id={0}", id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows[0][0].ToString() == "True")
            {
                info = "已退过款，无法再退";
                return info;
            }
            if (dt.Rows[0][1].ToString()!="1")
            {
                info = "非收款状态无法退款";
                return info;
            }

            //if (dt.Rows[0][2].ToString() != "")
            //{
            //    decimal tmp = decimal.Parse(dt.Rows[0][2].ToString());
            //    if (tmp != 0)
            //    {
            //        info = "赊销无法退款";
            //        return info;
            //    }
            //}

            if (dt.Rows[0][3].ToString() != "")
            {
                decimal tmp = decimal.Parse(dt.Rows[0][3].ToString());
                if (tmp != 0)
                {
                    info = "会员收款无法退款";
                    return info;
                }
            }

            if (describes == "销售订金")
            {
                ICarSale icarsale = BllFactory.GetCarSaleBll();
                if (icarsale.IsOrderBindedByDH(dh.Trim()))
                {
                    info = "该订单已被销售单据绑定，无法退款";

                }

            }
        
            return info;
        }


        public  DataTable GetAccountStatistics(string items,List<SqlElement> lstE,string begindate, string enddate,int intype)
        {
            string sqlItem = "select isnull( sum(amount),0) as Amount,isnull( sum(recamount),0) as recamount ,isnull(sum(cash),0) as Cash,isnull(sum(bank),0) as Bank,isnull(sum(vip),0) as Vip ,isnull(sum(P2P),0) as P2P,isnull(sum(Integral),0) as Integral,isnull(sum(CS),0) as CS,isnull(sum(Other),0) as Other,isnull(sum(PreRecv),0) as PreRecv,isnull(sum(InvoiceAmount),0) as InvoiceAmount,isnull(sum(CheckAmount),0) as CheckAmount";
            string sqlGroup="";
            string sqlCondition = "";
            if (lstE != null && lstE.Count > 0)
                sqlCondition = Comm.CreateSqlUtil.CreateQuerySqlOfCondition(lstE, true);

            StringBuilder sql = new StringBuilder();
            string[] lstitems;
            sql.Append(sqlItem);

            if (items.Length > 0)
            {
                sqlGroup = " group by  ";
                lstitems = items.Split(',');
                foreach (string str in lstitems)
                {
                    sql.Append(",Max(" + str + ") as " + str);
                    sqlGroup = sqlGroup + str + ",";
                }
                sqlGroup = sqlGroup.Remove(sqlGroup.Length - 1);
            }
           

            sql.Append(" from financeaccounts where 1=1 and status!=0 ");
            if (lstE != null && lstE.Count > 0)
                sql.Append(" and " + sqlCondition);

            if (intype==1)
            {
                sql.Append("and cs=0 and len(InvoiceNum)>1");
            }
            else if (intype == 2)
            {
                sql.Append("and cs>0 and len(InvoiceNum)>1");
            }
            else if (intype == 3)
            {
                sql.Append("and cs=0 and len(InvoiceNum)<1");

            }
            else if (intype == 4)
            {
                sql.Append("and cs>0 and len(InvoiceNum)<1");

            }
            if (begindate != "")
            {
                sql.Append(string.Format("and Acceptdate>='{0}' and Acceptdate<='{1}'", begindate, enddate));
            }

            sql.Append(sqlGroup);

            return mDB.ExecuteDataTable(sql.ToString());
        }


        public void AddP2PInfo(P2PUserInfo obj)
        {
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("Mobile", obj.MobilePhone, true));
            list.Add(new SqlElement("RecUnit", obj.RecvUnit, true));
            list.Add(new SqlElement("DHFrom", obj.DHFrom, true));
            list.Add(new SqlElement("CustName", obj.REALNAME, true));
            list.Add(new SqlElement("Amount",obj.Amount.ToString(), false));
            list.Add(new SqlElement("PayType", obj.PayType, true));
            list.Add(new SqlElement("Balance", obj.Balance.ToString(), true));
            list.Add(new SqlElement("VirtualMoney", obj.VirtualMoney.ToString(), true));
            list.Add(new SqlElement("Append", obj.Append, true));
            string sql = CreateSqlUtil.CreateInsertSql(list, "p2precv");
            mDB.ExecuteNonQuery(sql);

        }
        public void AddPreRecv(string mobile, string custname, Double amout)
        {
            string sql = "";
            sql = string.Format("select * from prerecv where mobile='{0}' and custname='{1}'", mobile, custname);
            if (mDB.IsExists(sql))
            {
                sql = string.Format("update prerecv set amount=amount+{0} where mobile='{1}' and custname='{2}'", amout, mobile, custname);
                mDB.ExecuteNonQuery(sql);
            }
            else
            {
                sql = string.Format("insert into prerecv(mobile,custname,amount) values('{0}','{1}',{2})", mobile, custname, amout);
                mDB.ExecuteNonQuery(sql);
            }

        }

        public decimal GetPreRecv(string mobile, string custname)
        {
            string sql = "";
            decimal result = 0;
            sql = string.Format("select amount from prerecv where mobile='{0}' and custname='{1}'", mobile, custname);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                result = decimal.Parse(dt.Rows[0][0].ToString());

            }
            return result;
        }

        public bool DeductPreRecv(string mobile,string custname,double prerecv)
        {
            string sql =string.Format( "select ID,isnull(amount,0) from prerecv where mobile ='{0}' and custname='{1}' and amount>0",mobile,custname);

            DataTable dt = mDB.ExecuteDataTable(sql);
            bool result=false;
            if (dt.Rows.Count>0)
            {

                double balance = double.Parse(dt.Rows[0][1].ToString());
                if (balance >= prerecv)
                {
                    sql = string.Format("update prerecv set amount={0} where id={1}", balance - prerecv, dt.Rows[0][0].ToString());
                    mDB.ExecuteNonQuery(sql);
                    result = true;
                }

            }
            return result;

        }

        public void UpdateInvoice(int id, string type, string num,double amount)
        {
            string sql = "";

            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("InvoiceType", type, true));
            list.Add(new SqlElement("InvoiceNum", num, true));
            list.Add(new SqlElement("InvoiceAmount", amount.ToString() , false));

            sql = CreateSqlUtil.CreateUpdateSql(list, "financeaccounts");
            sql = sql + " where ID=" +id;
            mDB.ExecuteNonQuery(sql);

        }


    }
}
