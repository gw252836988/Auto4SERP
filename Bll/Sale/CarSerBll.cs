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
    public class CarSerBll:Bll.IBatchIn
    {
        private DBHelper mDB;

        public CarSerBll()
        {
            mDB = DBHelperShare.getInstance();
        }
        public string BatchInDB(DataTable dt, string append)
        {
            try
            {
                string sql = "";
                DelTempRecord();
                mDB.BatchInsert("tmp_carser", dt);

                sql = "insert into carser([ID],[CarSer],[CarBrand]) select [ID],[CarSer],[CarBrand] from tmp_carser";
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

            mDB.ExecuteNonQuery("delete from tmp_carser");

        }



    }
}
