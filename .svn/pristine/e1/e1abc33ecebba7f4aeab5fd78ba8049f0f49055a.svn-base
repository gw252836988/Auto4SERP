using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtil;
using Comm;
using System.Data;
using Model;
namespace Bll.Repair
{
    public class AccElseOutBll : Bll.Repair.IAccElseOut
    {
         private DBHelper mDB;

         public AccElseOutBll()
        {
            mDB = DBHelperShare.getInstance();
        }

         public string GetDHOfAddAccElseOut(List<SqlElement> lst)
        {
            string sql;
            //List<SqlElement> lst = new List<SqlElement>();
            //lst.Add(new SqlElement("Mobile", obj.Mobile, true));
            //lst.Add(new SqlElement("PlateNum", obj.PlateNum, true));
            //lst.Add(new SqlElement("Status", "0", false));
            //lst.Add(new SqlElement("DH", "dbo.GetRepairDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", false));

            sql = CreateSqlUtil.CreateInsertSql(lst, "ElseAccOut");
            sql = sql + " SELECT @@IDENTITY AS Id ";
            DataTable dt = mDB.ExecuteDataTable(sql);
            string id = dt.Rows[0][0].ToString();
            sql = "select dh from ElseAccOut where id =" + id;
            dt = mDB.ExecuteDataTable(sql);
            string dh = dt.Rows[0][0].ToString();
            return dh;

        }

         public void UpdateAccElseOut(List<SqlElement> lst,string dh)
         {
             string sql;
             sql = CreateSqlUtil.CreateUpdateSql(lst, "ElseAccOut");
             sql = sql + " where dh ='" + dh + "'";
             mDB.ExecuteNonQuery(sql);

         }

         public void SetCompleteOfStatus(string dh)
         {
             string sql = "update ElseAccOut set status=1 where dh ='" + dh + "'";
             mDB.ExecuteNonQuery(sql);
         }

         public void SetOperateOfStatus(string dh)
         {
             string sql = "update ElseAccOut set status=0 where dh ='" + dh + "'";
             mDB.ExecuteNonQuery(sql);
         }


         public DataTable GetElseOutBill(string dh)
         {
             string sql = "select * from ElseAccOut where dh='" + dh + "'";

             return mDB.ExecuteDataTable(sql);

         }



         public bool DelElseOutBill(string dh)
         {
             string sql = "";
             //bool b1 = mDB.IsExists(sql);
             sql = "select * from repair_a where dh='" + dh + "'";
             bool b2 = mDB.IsExists(sql);
             if (!b2)
             {
                 sql = string.Format("delete from ElseAccOut where dh='{0}'", dh);
                 mDB.ExecuteNonQuery(sql);
                 return true;
             }
             return false;



         }


         public DataTable GetElseOutBills(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
         {
             string IndexField = "DH";
             string AllFields = "case when status=0 then '操作中'  else '完成' end  as Status,DH,CreateDate,OutType,OutToUnit,Creator";
             string Condition = "ElseAccOut where ";
             string OrderFields = "order by CreateDate desc";

             if (list != null && list.Count > 0)
                 Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
             else
                 Condition = Condition + "1=1";

             if (strBegin != "")
                 Condition = Condition + string.Format(" and CreateDate>='{0}' and CreateDate<='{1}'", strBegin, strEnd);
             DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
             return dt;

         }

    }
}
