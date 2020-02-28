using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Comm;
using DBUtil;
using System.Data;
using System.Data.SqlClient;


namespace Bll.Sale
{
    public class CarModelBll : Bll.IBatchIn
    {  
        private DBHelper mDB;

         public CarModelBll()
        {
            mDB = DBHelperShare.getInstance();
        }
        public string BatchInDB(DataTable dt, string append)
        {
            try
            {
                string sql = "";
                DelTempRecord();
                mDB.BatchInsert("tmp_carmodel", dt);

                sql = "insert into carmodel([ID],[CarSer],[CarModel],[CarSerName]) select [ID],[CarSer],[CarModel],[CarSerName] from tmp_carmodel";
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

            mDB.ExecuteNonQuery("delete from tmp_carmodel");

        }
    }
}
