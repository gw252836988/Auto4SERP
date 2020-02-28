using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtil;
using Comm;
using System.Data;
using Model;
namespace Bll
{
    public class CarOfCustBll : IBatchIn, ICarOfCust
    {

        private DBHelper mDB;
        public CarOfCustBll()
        {
            mDB = DBHelperShare.getInstance();
        }
        public string BatchInDB(DataTable dt, string append)
        {
            try
            {
                string sql = "";
                DelTempRecord();
                //foreach (DataRow dr in dt.Rows)
                //{
                //    Accessory obj = new Accessory();
                //    obj.AccessoryCode = dr[0].ToString();
                //    obj.AccessoryName = dr[1].ToString();
                //    obj.Brand = dr[2].ToString();
                //    obj.StorePlace = dr[3].ToString();
                //    obj.AccessoryType = dr[4].ToString();
                //    obj.IncreaseRate = float.Parse(dr[5].ToString());
                //    obj.ChangeCode = dr[6].ToString();
                //    obj.SalePrice = float.Parse(dr[7].ToString());
                //    obj.ApplicationModel = dr[7].ToString();
                //    obj.Unit = dr[8].ToString();
                //    AddAccessoryToTemp(obj);

                //}

                mDB.BatchInsert("tmp_carofcustomer", dt);

                sql = FindRepeatRecord();
                if (sql != "")
                {
                    DelTempRecord();
                    return sql + "记录重复";

                }
                sql = "insert into carofcustomer([Mobile] ,[PlateNum] ,[Vin],[CarBrand] ,[CarSer] ,[CarModel] ,[CarColor]) "
                    + " select * from tmp_carofcustomer";
                mDB.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {

                DelTempRecord();

                return e.Message.ToString();
            }

            return "";
        }

        private string FindRepeatRecord()
        {
            string sql = "";
            sql = "select PlateNum from  tmp_carofcustomer where PlateNum in (select PlateNum from carofcustomer)";
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count != 0)
            {
                return dt.Rows[0][0].ToString();

            }
            return "";

        }

        private void DelTempRecord()
        {

            mDB.ExecuteNonQuery("delete from tmp_carofcustomer");

        }
    }
}
