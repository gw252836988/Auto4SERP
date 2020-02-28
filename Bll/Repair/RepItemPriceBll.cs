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
    public class RepItemPriceBll :  IRepItemPrice ,Bll.IBatchIn
    {
        private DBHelper mDB;

        public RepItemPriceBll()
        {
            mDB = DBHelperShare.getInstance();
        }

        public string BatchInDB(DataTable dt,string append)
        {
            try
            {
                string sql = "";
                DelTempRecord();
                mDB.BatchInsert("tmp_repitemprice", dt);

                sql = "insert into repitemprice([ItemCode],[EmpWorkH],[ActWorkH],[WorkHPrice],[CarLevel]) select * from tmp_repitemprice";
                mDB.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                DelTempRecord();

                return e.Message.ToString();

            }
            return "";

        }


        private void DelTempRecord()
        {

            mDB.ExecuteNonQuery("delete from tmp_repitemprice");

        }


        public DataTable GerRepPriceByItemCode(string itemcode)
        {
            string sql;
            sql = "select ID,itemcode ,EmpWorkH,ActWorkH,WorkHPrice,case when CarLevel=100 then '高档' when CarLevel=200 then '中高档'  when CarLevel=300 then '中档' else '低档' end  as CarLevel from repitemprice where itemcode ='" + itemcode + "'";
            return mDB.ExecuteDataTable(sql);

        }



        public DataTable GetRepPriceByID(string id)
        {
            string sql;
            sql = "select * from repitemprice where id=" + id;
            return mDB.ExecuteDataTable(sql);

        }

        public void AddRepPrice(List<SqlElement> lst)
        {
            string sql;
            sql = CreateSqlUtil.CreateInsertSql(lst, "repitemprice");
            mDB.ExecuteNonQuery(sql);
            
        }

        public void UpdateRepPrice(List<SqlElement> lst ,string id)
        {
            string sql;
            sql = CreateSqlUtil.CreateUpdateSql(lst, "repitemprice");
            sql = sql + " where id=" + id;
            mDB.ExecuteNonQuery(sql);
        }

        public void DelRepPrice(string id)
        {
            string sql;
            sql = "delete from repitemprice where id=" + id;
            mDB.ExecuteNonQuery(sql);
        }


    }
}
