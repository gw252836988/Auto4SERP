using Comm;
using DBUtil;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bll.Personnel
{
  public  class DepartmentBll
    {
      private DBHelper mDB;


      public DepartmentBll()
        {
            mDB = DBHelperShare.getPInstance();
        }
      public DataTable GetDepartments()
      {
          DataTable dt;
          string sql = "select * from department";
          dt = mDB.ExecuteDataTable(sql);
          dt.TableName = "a";
          return dt;
      }

      public DataTable GetDepartmentByID(string id)
      {
          DataTable dt;
          string sql =String.Format( "select * from department where id='{0}'",id);
          dt = mDB.ExecuteDataTable(sql);
          dt.TableName = "a";
          return dt;
      }

      public bool AddDepartment(Department depart)
      {
          bool result = false;

         // string sql = CreateSqlUtil.CreateIsExistInsertStringSql("id", "department", depart.ID);
          string sql = "select * from department where id='" + depart.ID + "'";
           result = mDB.IsExists(sql);
           if (!result)
          {
              List<SqlElement> list = new List<SqlElement>();
              list.Add(new SqlElement("id", depart.ID.ToString(), true));

              list.Add(new SqlElement("DepartmentName", depart.DepartmentName, true));
              if (!String.IsNullOrEmpty(depart.ParentID))
              {
                  list.Add(new SqlElement("ParentID", depart.ParentID.ToString(), true));
              }
              sql = CreateSqlUtil.CreateInsertSql(list, "department");
              int k = mDB.ExecuteNonQuery(sql);
              if (k > 0)
              {
                  return true;
              }
          }
          return false;
      }


      public bool UpdateDepartment(Department depart,string id)
      {
          List<SqlElement> list = new List<SqlElement>();
          list.Add(new SqlElement("id", depart.ID, true));
          list.Add(new SqlElement("DepartmentName", depart.DepartmentName, true));
       //   list.Add(new SqlElement("ParentID", depart.ParentID, true));
          string sql = CreateSqlUtil.CreateUpdateSql(list, "department");
          sql = sql + string.Format(" where id ={0} ", id);
          int k = mDB.ExecuteNonQuery(sql);
          if (k > 0)
          {
              return true;
          }
          return false;
      }

      public bool ExistsId(Department depart)
      {
          bool result = false;

          string sql = "select * from department where id='" + depart.ID + "'";
          result = mDB.IsExists(sql);
          return result;
      }

      public bool DelDepartmentByID(string id)
      {
          bool result = false;

          string sql =String.Format( "delete from department where id like '{0}%'",id);
          int k = mDB.ExecuteNonQuery(sql);
          if (k > 0)
          {
              result = true;
          }
          return result;
      }

      public string AddIDString(string parentid)
      {
          string result = "";
          if (!String.IsNullOrEmpty(parentid))
          {
              string sql = string.Format("select top 1 id from department where parentid='{0}' order by id desc", parentid);
              DataTable dt = mDB.ExecuteDataTable(sql);
              if (dt.Rows.Count > 0)
              {
                  DataRow dr = dt.Rows[0];
                  string strid = dr["id"].ToString().Trim();
                  string strid1 = strid.Substring(parentid.Trim().Length , strid.Trim().Length - parentid.Trim().Length);
                  int stridnew = Convert.ToInt32(strid1) + 1;
                  if (stridnew < 999)
                  {
                      result =parentid+ stridnew.ToString("D3");
                  }
                  else
                  {
                      result = "";
                  }

              }
              else
              {
                  result = parentid+"001";
              }

          }
          else
          {
              string sql = "select top 1 id from department where parentid='' or parentid is null order by id desc";
              DataTable dt = mDB.ExecuteDataTable(sql);
              if (dt.Rows.Count > 0)
              {
                  DataRow dr = dt.Rows[0];
                  string strid = dr["id"].ToString();
                  int  stridnew = Convert.ToInt32(strid) + 1;
                  if (stridnew < 999)
                  {
                      result = stridnew.ToString("D3");
                  }
                  else
                  {
                      result = "";
                  }
              
              }
              else
              {
                  result = "001";
              }
          }

          return result;
      }

    }
}
