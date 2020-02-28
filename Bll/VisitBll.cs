using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBUtil;
using Comm;
using System.Data;
using Model;

namespace Bll
{
    public  class VisitBll:IVisit
    {
       private DBHelper mDB;

       public VisitBll()
       {
            mDB = DBHelperShare.getInstance();
       }

       public void AddReturnVisit(List<SqlElement> lst)
       {
           string sql = "";
           sql = CreateSqlUtil.CreateInsertSql(lst, "revisit");
           mDB.ExecuteNonQuery(sql);
       }

       public void UpdateReturnVisit(List<SqlElement> lst,string id)
       {
           string sql = "";
           sql = CreateSqlUtil.CreateUpdateSql(lst, "revisit");
           sql = sql + " where id=" + id ;
           mDB.ExecuteNonQuery(sql);
       }


       public DataTable GetVisitsOfDH(string dh)
       {
           string sql = "";
           sql = "select * from revisit where dh='" + dh + "'";
            return  mDB.ExecuteDataTable(sql);

       }

       public void DelVisit(string id)
       {
           string sql = "";
           sql = "delete from revisit where id=" + id;
           mDB.ExecuteNonQuery(sql);

       }

       public DataTable GetVisit(string id)
       {
           string sql = "";
           sql = "select * from revisit where id=" + id;
           return mDB.ExecuteDataTable(sql);
       }
    }
}
