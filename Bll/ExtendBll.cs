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
  public  class ExtendBll:IExtend
    {
       private DBHelper mDB;
       public ExtendBll()
        {
            mDB = DBHelperShare.getInstance();
        }
       #region Extendtype
       public bool AddExtendtype(string extendname)
       {
           string sql = CreateSqlUtil.CreateIsExistInsertStringSql("extendname", "extendtype", extendname);
           bool b = mDB.IsExists(sql);
           if (!b)
           {
               List<SqlElement> list = new List<SqlElement>();
               list.Add(new SqlElement("extendname", extendname, true));
               sql = CreateSqlUtil.CreateInsertSql(list, "extendtype");
               int k = mDB.ExecuteNonQuery(sql);
               if (k > 0)
               {
                   return true;
               }
           }
           return false;
       }
       public bool UpdateExtendtype(string extendname, int id)
       {
           List<SqlElement> list = new List<SqlElement>();
           list.Add(new SqlElement("extendname", extendname, true));
           string sql = CreateSqlUtil.CreateUpdateSql(list, "extendtype");
           sql = sql + string.Format(" where id ={0} ", id);
           int k = mDB.ExecuteNonQuery(sql);
           if (k > 0)
           {
               return true;
           }
           return false;
       }
       public bool DelExtendtype(int id)
       {
           string sql = CreateSqlUtil.CreateDelSql("id", "extendtype", id);
           int k = mDB.ExecuteNonQuery(sql);
           if (k > 0)
           {
               return true;
           }
           return false;
       }
       public DataTable GetExtendtypes()
       {
           string sql = "select id,ExtendName from extendtype order by id asc";
           DataTable dt = mDB.ExecuteDataTable(sql);
           return dt;
       }
       public DataTable GetExtendtype(int id)
       {
           string sql = string.Format("select id,ExtendName from extendtype where id={0}", id);
           DataTable dt = mDB.ExecuteDataTable(sql);
           return dt;
       }
       #endregion 

        #region ExtendContent
       public bool AddExtendcontent(string content, int extendtype_id)
       {
           string sql = CreateSqlUtil.CreateIsExistInsertStringSql("content", "extendcontent", content);
           bool b = mDB.IsExists(sql);
           if (!b)
           {
               List<SqlElement> list = new List<SqlElement>();
               list.Add(new SqlElement("content", content, true));
               list.Add(new SqlElement("typeid", extendtype_id.ToString(), false));
               sql = CreateSqlUtil.CreateInsertSql(list, "extendcontent");
               int k = mDB.ExecuteNonQuery(sql);
               if (k > 0)
               {
                   return true;
               }
           }
           return false;
       }
       public bool UpdateExtendcontent(string content, int extendtype_id, int id)
       {
           List<SqlElement> list = new List<SqlElement>();
           if (content != "")
           {
               list.Add(new SqlElement("content", content, true));
           }
           if (extendtype_id > 0)
           {
               list.Add(new SqlElement("typeid", extendtype_id.ToString(), false));
           }
           string sql = CreateSqlUtil.CreateUpdateSql(list, "extendcontent");
           sql = sql + string.Format(" where id ={0} ", id);
           int k = mDB.ExecuteNonQuery(sql);
           if (k > 0)
           {
               return true;
           }
           return false;
       }
       public bool DelExtendcontent(int id)
       {
           string sql = CreateSqlUtil.CreateDelSql("id", "extendcontent", id);
           int k = mDB.ExecuteNonQuery(sql);
           if (k > 0)
           {
               return true;
           }
           return false;
       }
       public DataTable GetExtendcontents()
       {
           string sql = "select a.id,a.content,a.typeid,b.extendname  from extendcontent as a left join extendtype as b on a.typeid = b.id order by a.id asc";
           DataTable dt = mDB.ExecuteDataTable(sql);
           return dt;
       }
       public DataTable GetExtendcontent(int id)
       {
           string sql = string.Format("select a.id,a.content,a.typeid,b.extendname  from extendcontent as a left join extendtype as b on a.typeid = b.id  where a.id={0} order by a.id asc",id);
           DataTable dt = mDB.ExecuteDataTable(sql);
           return dt;
       }
       public DataTable GetExtendcontentByExtendtypeName(string extendtype_name)
       {
           string sql = string.Format("select a.id,a.content,a.typeid,b.extendname  from extendcontent as a left join extendtype as b on a.typeid = b.id  where b.extendname='{0}' order by a.id asc", extendtype_name);
           DataTable dt = mDB.ExecuteDataTable(sql);
           return dt;
       }

       public DataTable GetSupplyUnits(string unittype)
       {
           string sql = "select ID,UnitName from supplyunit where unittype='" + unittype + "'";
           DataTable dt = mDB.ExecuteDataTable(sql);
           return dt;

       }

       public DataTable GetSupplyUnitsByQuery(List<SqlElement> list)
       {
          string sql="select * from supplyunit where ";

          if (list != null && list.Count >0)
               sql = sql + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
          else
               sql = sql + "1=1";

          return mDB.ExecuteDataTable(sql);
       }


       public void AddSupplyUnit(SupplyUnit obj)
       {
           string sql;
           List<SqlElement> list = new List<SqlElement>();
           list.Add(new SqlElement("UnitType", obj.UnitType, true));
           list.Add(new SqlElement("UnitName", obj.UnitName.ToString(), true));
           list.Add(new SqlElement("UnitAddress", obj.UnitAddress, true));
           list.Add(new SqlElement("PayType", obj.PayType, true));
           sql = CreateSqlUtil.CreateInsertSql(list, "supplyunit");
           mDB.ExecuteNonQuery(sql);

       }

        public void UpdateSuppyUnit(SupplyUnit obj)
        {
            string sql;
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("UnitType", obj.UnitType, true));
            list.Add(new SqlElement("UnitName", obj.UnitName.ToString(), true));
            list.Add(new SqlElement("UnitAddress", obj.UnitAddress, true));
            list.Add(new SqlElement("PayType", obj.PayType, true));
            sql = CreateSqlUtil.CreateUpdateSql(list, "supplyunit");

            sql = sql + " where id=" + obj.ID;
            mDB.ExecuteNonQuery(sql);
       
        
        }


        public SupplyUnit  GetSuppyUnitByID(int id)
        {
            string sql = "select * from supplyunit where id=" + id;
           DataTable dt = mDB.ExecuteDataTable(sql);
           SupplyUnit obj = null ;
            if (dt.Rows.Count > 0)
            {
                obj = new SupplyUnit();
                obj.UnitAddress = dt.Rows[0]["UnitAddress"].ToString();
                obj.UnitName = dt.Rows[0]["UnitName"].ToString();
                obj.UnitType = dt.Rows[0]["UnitType"].ToString();
                obj.PayType = dt.Rows[0]["PayType"].ToString();
                

            }
            return obj;
        }

        public void DelSupplyUnit(int id)
        {
            string sql = "delete from supplyunit where id=" + id;
            mDB.ExecuteNonQuery(sql);

        }


        public void AddKeyLog(string op,string context)
        {
            string sql = "";
            sql = string.Format("insert into keylog(operator,Context) values('{0}','{1}')",op,context);
            mDB.ExecuteNonQuery(sql);

        }

        public string  ExecuteSql(string sql)
        {
            List<Organ> lst=ConnectionStringFactory.getInstance().GetAllOrgans();
            StringBuilder strB = new StringBuilder();
            foreach(Organ o in lst)
            {
                if (o.OrganId == "111") continue;
                try
                {
                     DBHelper db = new DBHelper(o.OrganId);
                     db.ExecuteNonQuery(sql);
                     strB.Append(o.OrganName + " ");
                }
                catch(Exception ex)
                {
                    strB.Append(ex.Message.ToString());
                }
             
            }
            return strB.ToString();

        }
        
        #endregion
    }
}
