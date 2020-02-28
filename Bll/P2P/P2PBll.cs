using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Comm;
using DBUtil;
using Model;
using System.Data;
namespace Bll.P2P
{
    
    public class P2PBll:IP2P
    {
        private MSDBHelper mDB;


        public P2PBll()
        {
            mDB = DBHelperShare.getP2PInstance(); 
        }

        public DataTable GetQuansOfCustomer(string mobile)
        {
            //string sql = string.Format("select sum(money) as je,max(type) as type from v_quan where mobilephone ='{0}' and `status`=0 group by type", mobile);
            //DataTable dt = mDB.ExecuteDataTable(sql);
            //return dt;


            string sql = string.Format("select id,type,money,typeid from v_quan where mobilephone ='{0}' and `status`=0 and over_duetime>NOW()", mobile);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }

        public string  GetIDOfQuan(string type,double money,string mobile)
        {
            DataTable dt;
            string sql;
            string id = "0";
            sql = string.Format("select id from v_quan where over_duetime>NOW() and  mobilePhone='{0}' and  typeid={1} and  money>{2} and  `status`=0 ORDER BY money ASC,ADDTIME asc LIMIT 1", mobile, type, money);
     
            dt = mDB.ExecuteDataTable(sql);
            if(dt.Rows.Count>0)
            {
                id = dt.Rows[0][0].ToString();
            }
            return id;
        }

        public string  ConductQuan(List<string> lst)
        {
            string sql;
             
            foreach (string str in lst)
            {
                sql = string.Format("select *  from v_quan where over_duetime>NOW() and  id='{0}' and `status`=0",str);
                if (!mDB.IsExists(sql))
                    return str;

            }

           foreach (string str in lst)
           {
               sql = "update dql_quan set `status`=1 where id=" + str;
               mDB.ExecuteNonQuery(sql);

           }
            
            return "";
        }
        
    }
}
