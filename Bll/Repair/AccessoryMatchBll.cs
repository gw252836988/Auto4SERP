using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBUtil;
using Comm;
using Model;
using System.Data.SqlClient;
using Bll;
using System.Data;

namespace Bll.Repair
{
    public class AccessoryMatchBll :IAccessoryMatchBll
    {
        private DBHelper mDB;
        private string mOrganName="";

        public void SetDBByOrgan(string organid)
        {
            mDB = new DBHelper(organid);
            mOrganName=ConnectionStringFactory.getInstance().ReturnOrganById(organid).OrganName;
            
        }

        public DataTable GetAccsByList(List<string> lst,int days)
        {
            string sql,condition="(";
            sql = string.Format("select accessorycode ,accessoryname,amount,'{0}' as organname,DATEDIFF(DAY,indate,getdate()) as days from v_accware where amount>0 and DATEDIFF(DAY,indate,getdate())>{1} and accessorycode in ", mOrganName,days);

           
            foreach (string str in lst)
            {
                condition += "'" +str + "',";
            }
            condition= condition.Remove (condition.Length-1);
            condition += ")";
            sql += condition;
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
            
        }

    }
}
