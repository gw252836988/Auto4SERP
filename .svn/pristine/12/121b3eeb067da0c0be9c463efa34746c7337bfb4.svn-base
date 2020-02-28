using Comm;
using DBUtil;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public class PositionBll:IPosition
   {
       private DBHelper mDB;

       public PositionBll()
        {
            mDB = DBHelperShare.getPInstance();
        }
       public DataTable GetPositions()
       {
           DataTable dt = new DataTable();
           string sql = String.Format("select a.id,a.PositionName,a.DepartmentID,b.DepartmentName from position as a left join department as b on a.departmentid=b.id  order by a.id desc ");
           dt = mDB.ExecuteDataTable(sql);
           return dt;
       }

       public DataTable GetPositionsByDepartmentID(string did)
       {
           DataTable dt = new DataTable();
           string sql = String.Format("select a.id,a.PositionName,a.DepartmentID,b.DepartmentName from position as a left join department as b on a.departmentid=b.id  where a.DepartmentID='{0}' order by a.id desc ",did);
           dt = mDB.ExecuteDataTable(sql);
           return dt;

       }

       public DataTable GetPositionByID(string id)
       {
           DataTable dt = new DataTable();
           string sql = String.Format("select a.id,a.PositionName,a.DepartmentID,b.DepartmentName from position as a left join department as b on a.departmentid=b.id where a.id='{0}'", id);
           dt = mDB.ExecuteDataTable(sql);
           return dt;
       }

       public bool AddPosition(string departmentid, string positionname)
       {
           bool result = false;

           string sql = CreateSqlUtil.CreateIsExistInsertStringSql("positionname", "Position", positionname);
           result = mDB.IsExists(sql);
           if (!result)
           {
               List<SqlElement> list = new List<SqlElement>();
               list.Add(new SqlElement("positionname", positionname, true));

               list.Add(new SqlElement("departmentid", departmentid, true));

               sql = CreateSqlUtil.CreateInsertSql(list, "Position");
               int k = mDB.ExecuteNonQuery(sql);
               if (k > 0)
               {
                   return true;
               }
           }
           return false;
       }


       public bool UpdateDepartment(string departmentid, string positionname, string id)
       {
           List<SqlElement> list = new List<SqlElement>();

           list.Add(new SqlElement("positionname", positionname, true));
           list.Add(new SqlElement("departmentid", departmentid, true));
           string sql = CreateSqlUtil.CreateUpdateSql(list, "Position");
           sql = sql + string.Format(" where id ={0} ", id);
           int k = mDB.ExecuteNonQuery(sql);
           if (k > 0)
           {
               return true;
           }
           return false;
       }

       public bool ExistsId(string positionname)
       {
           bool result = false;

           string sql = CreateSqlUtil.CreateIsExistInsertStringSql("id", "Position", positionname);
           result = mDB.IsExists(sql);
           return result;
       }

       public bool DelDepartmentByID(string id)
       {
           bool result = false;

           string sql = String.Format("delete from Position where id='{0}'", id);
           int k = mDB.ExecuteNonQuery(sql);
           if (k > 0)
           {
               result = true;
           }
           return result;
       }

      
    }
}
