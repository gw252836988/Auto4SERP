using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comm;
using DBUtil;
using Model;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace Bll
{
   public  class VipBll : Bll.IVip
   {
       private DBHelper mDB;
       public VipBll()
       {
            mDB = DBHelperShare.getVipInstance();
       }


       public  VipInfo GetVipInfoByCardID(string cardID)
       {

           if (!MainWindowState.getInstance().IsVipConnected)
               return null;
           string sql =string.Format( "select memlevel,balance,integral,inOrgan from member where cardid='{0}'",cardID);
           DataTable dt = mDB.ExecuteDataTable(sql);
           VipInfo obj = null;
           if (dt.Rows.Count > 0)
           {
               obj = new VipInfo();
               obj.MemberLevel = dt.Rows[0][0].ToString();
               obj.Balance = float.Parse(dt.Rows[0][1].ToString());
               obj.Integral = float.Parse(dt.Rows[0][2].ToString());
               obj.InOrgan = dt.Rows[0][3].ToString();

           }
           return obj;
       }


       public bool  VipAccept(string cardid, double  je, string category, string remark, string Operater, string Organ, string DH)
       {
           bool flag = false;
           double Integral = 0;
           Integral = GetIntegral(cardid, je);
           string IsUndo = "否";
           StringBuilder strSql = new StringBuilder();
           strSql.Append("insert into ConsumeRecord(");
           strSql.Append("DH,CardID,YFJE,SSJE,Remark,CommitDate,ConsumeDate,Operater,Organ,IsUndo,category");
           strSql.Append(",DepositPay");
           strSql.Append(",IntegralGot");
           strSql.Append(" ) ");
           strSql.Append(" values (");
           strSql.Append("@DH,@CardID1,@YFJE,@SSJE,@Remark,getdate(),getdate(),@Operater,@Organ,@IsUndo,@category");
           strSql.Append(",@DepositPay");
           strSql.Append(",@Integral");
           strSql.Append(" ) ");
           string sql2 = strSql.ToString();
           List<SqlParameter> list = new List<SqlParameter>();
           list.Add(new SqlParameter("@DH", DH));
           list.Add(new SqlParameter("@CardID1", cardid));
           list.Add(new SqlParameter("@YFJE", je));
           list.Add(new SqlParameter("@SSJE", je));
           list.Add(new SqlParameter("@Remark", remark));

           list.Add(new SqlParameter("@Operater", Operater));
           list.Add(new SqlParameter("@Organ", Organ));
           list.Add(new SqlParameter("@IsUndo", IsUndo));
           list.Add(new SqlParameter("@DepositPay", je));
           list.Add(new SqlParameter("@Integral", Integral));
           list.Add(new SqlParameter("@category", category));

           string sql = "update member set Balance=Balance-@yfje1,Consumed=Consumed+@yfje1,Integral=Integral+@Integral1,countconsume=isnull(countconsume,0)+1,lastconsumetime=getdate() where cardid=@cardid2";
           List<SqlParameter> list2 = new List<SqlParameter>();
           list2.Add(new SqlParameter("@yfje1", je));
           list2.Add(new SqlParameter("@Integral1", Integral));
           list2.Add(new SqlParameter("@cardid2", cardid));

           StringBuilder strSql3 = new StringBuilder();
           strSql3.Append("insert into IntegralRecord (");
           strSql3.Append("DH,CardID,IntegralGot,Operater,Remark,IntegralTime,IsUndo,Organ,category) ");
           strSql3.Append(" values (");
           strSql3.Append("@DH3,@CardIDs3,@IntegralGot3,@Operater3,@Remark3,getdate(),@IsUndo3,@Organ3,@category)");

           string sql3 = strSql3.ToString();
           List<SqlParameter> list3 = new List<SqlParameter>();
           list3.Add(new SqlParameter("@DH3", DH));
           list3.Add(new SqlParameter("@CardIDs3", cardid));
           list3.Add(new SqlParameter("@IntegralGot3", Integral));
           list3.Add(new SqlParameter("@Operater3", Operater));
           list3.Add(new SqlParameter("@Remark3", remark));
           list3.Add(new SqlParameter("@IsUndo3", IsUndo));
           list3.Add(new SqlParameter("@Organ3", Organ));
           list3.Add(new SqlParameter("@category", category));

           Hashtable table = new Hashtable();
           table.Add(sql2, list.ToArray());
           table.Add(sql, list2.ToArray());
           table.Add(sql3, list3.ToArray());

           int result = mDB.ExecuteSqlTran(table);
           if (result <= 0)
           {
               return false;
           }
           else
           {
               flag = true;
           }

           return flag;

       }


       public bool IsBalanceEnough(double vipJE,string cardNo)
       {
         //  bool flag = false;
           string sql = string.Format("select * from member where cardid='{0}'",cardNo);
           DataTable dt = mDB.ExecuteDataTable(sql);
           if (dt.Rows.Count > 0)
           {
               double balance = Convert.ToDouble(dt.Rows[0]["Balance"]);
               if (vipJE > balance)
               {
                   return false;
               }
           }
           else
           {
               return false;
           }
           return true;
       }



       private double GetIntegral(string cardid, double YFJE)
       {
           string sqllevel = "select * from memlevel where status=1";
           DataTable dts = mDB.ExecuteDataTable(sqllevel);
           string sql = "select * from member where cardid='" +cardid +  "'";
           //SqlParameter[] pas = new SqlParameter[]{
           //             new SqlParameter("@cardid",cardid)
           //         };
           DataTable dt2 = mDB.ExecuteDataTable(sql);
           if (dt2.Rows.Count > 0)
           {
               DataRow dr = dt2.Rows[0];
               foreach (DataRow dr1 in dts.Rows)
               {
                   if (dr1["name"].ToString() == dr["MemLevel"].ToString())
                   {
                       return YFJE * Convert.ToDouble(dr1["discount"]);
                   }
               }
           }

           return 0;

       }


       public bool IsValidateByPwd(string cardid,string pwd)
       {
           string sql = string.Format("select * from member where cardid='{0}' and password='{1}'",cardid,pwd);
           if (mDB.IsExists(sql))
               return true;
           else
               return false;


       }


       public DataTable GetDepositRecord(string cardno)
       {

           string sql = "";

           sql = "select * from DepositRecord where cardid='" +  cardno + "'";
           return mDB.ExecuteDataTable(sql);
       }

      
   }
}
