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
    public class CarDocBll : ICarDoc
    {
        private DBHelper mDB;
        public CarDocBll()
        {
            mDB = DBHelperShare.getInstance();
        }
        #region carbrand
        public bool AddCarBrand(string brandname)
        {
            string sql = CreateSqlUtil.CreateIsExistInsertStringSql("brandname", "carbrand", brandname);
            bool b = mDB.IsExists(sql);
            if (!b)
            {
                List<SqlElement> list = new List<SqlElement>();
                list.Add(new SqlElement("brandname", brandname, true));
                sql = CreateSqlUtil.CreateInsertSql(list, "carbrand");
                int k = mDB.ExecuteNonQuery(sql);
                if (k > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateCarBrand(string brandname, int id)
        {
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("brandname", brandname, true));
            string sql = CreateSqlUtil.CreateUpdateSql(list, "carbrand");
            sql = sql + string.Format(" where id ={0} ", id);
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }

        public bool DelCarBrand(int id)
        {
            string sql = CreateSqlUtil.CreateDelSql("id", "carbrand", id);
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetCarBrands()
        {
            string sql = "select id,brandname from carbrand order by id asc";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }

        public DataTable GetCarBrand(int id)
        {
            string sql = string.Format("select id,brandname from carbrand where id={0}", id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }
        #endregion

        #region carser
        public bool AddCarSer(string carser, int carbrand_id)
        {
            string sql = CreateSqlUtil.CreateIsExistInsertStringSql("carser", "carser", carser);
            bool b = mDB.IsExists(sql);
            if (!b)
            {
                List<SqlElement> list = new List<SqlElement>();
                list.Add(new SqlElement("carser", carser, true));
                list.Add(new SqlElement("carbrand", carbrand_id.ToString(), false));
                sql = CreateSqlUtil.CreateInsertSql(list, "carser");
                int k = mDB.ExecuteNonQuery(sql);
                if (k > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UpdateCarSer(string carser, int carbrand_id, int id)
        {
            List<SqlElement> list = new List<SqlElement>();
            if (carser != "")
            {
                list.Add(new SqlElement("carser", carser, true));
            }
            if (carbrand_id > 0)
            {
                list.Add(new SqlElement("carbrand", carbrand_id.ToString(), false));
            }
            string sql = CreateSqlUtil.CreateUpdateSql(list, "carser");
            sql = sql + string.Format(" where id ={0} ", id);
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }

        public bool DelCarSer(int id)
        {
            string sql = CreateSqlUtil.CreateDelSql("id", "carser", id);
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetCarSers()
        {
            string sql = "select a.id,a.carser,a.carbrand,b.BrandName  from carser as a left join carbrand as b on a.carbrand = b.id order by a.carbrand asc";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }

        public DataTable GetCarSer(int id)
        {
            string sql = string.Format("select a.id,a.carser,a.carbrand,b.BrandName  from carser as a left join carbrand as b on a.carbrand = b.id where a.id={0} order by a.carbrand asc", id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }

        public DataTable GetCarSerByCarbrand(int carbrand_id)
        {
            string sql = string.Format("select a.id,a.carser,a.carbrand,b.BrandName  from carser as a left join carbrand as b on a.carbrand = b.id where b.id={0} order by a.carbrand asc", carbrand_id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }
        #endregion
        #region carmodel
        public bool AddCarModel(string carmodel, int carser_id)
        {
            string sql = CreateSqlUtil.CreateIsExistInsertStringSql("carmodel", "carmodel", carmodel);
            bool b = mDB.IsExists(sql);
            if (!b)
            {
                List<SqlElement> list = new List<SqlElement>();
                list.Add(new SqlElement("carmodel", carmodel, true));
                list.Add(new SqlElement("carser", carser_id.ToString(), false));
                sql = CreateSqlUtil.CreateInsertSql(list, "carmodel");
                int k = mDB.ExecuteNonQuery(sql);
                if (k > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public bool UpdateCarModel(string carmodel, int carser_id, int id)
        {
            List<SqlElement> list = new List<SqlElement>();
            if (carmodel != "")
            {
                list.Add(new SqlElement("carmodel", carmodel, true));
            }
            if (carser_id > 0)
            {
                list.Add(new SqlElement("carser", carser_id.ToString(), false));
            }
            string sql = CreateSqlUtil.CreateUpdateSql(list, "carmodel");
            sql = sql + string.Format(" where id ={0} ", id);
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }
        public bool DelCarModel(int id)
        {
            string sql = CreateSqlUtil.CreateDelSql("id", "carmodel", id);
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable GetCarModels()
        {
            string sql = "select a.id,a.carmodel,a.carser,b.carser as carsername  from carmodel as a left join carser as b on a.carser = b.id order by a.carser asc";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }
        public DataTable GetCarModel(int id)
        {
            string sql = string.Format("select a.id,a.carmodel,a.carser,b.carser as carsername  from carmodel as a left join carser as b on a.carser = b.id where a.id={0}  order by a.carser asc", id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }
        public DataTable GetCarModelByCarser(int carser_id)
        {
            string sql = string.Format("select a.id,a.carmodel,a.carser,b.carser as carsername  from carmodel as a left join carser as b on a.carser = b.id where b.id={0}  order by a.carser asc", carser_id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }
        #endregion

        #region cardetail
        public bool AddCarDetail(CarDetail obj, int carmodel_id)
        {

          
            string sql = CreateSqlUtil.CreateIsExistInsertStringSql("autonumber", "cardetail", obj.AutoNumber);
            bool b = mDB.IsExists(sql);
            if (!b)
            {
                List<SqlElement> list = new List<SqlElement>();
              
                list.Add(new SqlElement("autonumber", obj.AutoNumber, true));
              
                list.Add(new SqlElement("color", obj.Color, true));
               
              
                list.Add(new SqlElement("displacement", obj.Displacement, true));
               
                
                list.Add(new SqlElement("transmission", obj.Transmission, true));
              
            
                list.Add(new SqlElement("innerstyle", obj.InnerStyle, true));
               
              
                list.Add(new SqlElement("carofyear", obj.CarOfYear, true));
            
              
               list.Add(new SqlElement("costprice", obj.CostPrice.ToString(), false));
            
               list.Add(new SqlElement("allotprice", obj.AllotPrice.ToString(), false));
              
               list.Add(new SqlElement("saleprice", obj.SalePrice.ToString(), false));
              
               list.Add(new SqlElement("minprice", obj.MinPrice.ToString(), false));
              
                if (carmodel_id>0)
                {
                    list.Add(new SqlElement("carmodel", carmodel_id.ToString(), false));
                }
                sql = CreateSqlUtil.CreateInsertSql(list, "cardetail");
                int k = mDB.ExecuteNonQuery(sql);
                if (k > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public bool UpdateCarDetail(CarDetail obj,  int carmodel_id, int id)
        {
       
            List<SqlElement> list = new List<SqlElement>();

      
     
            list.Add(new SqlElement("color", obj.Color, true));
          
            list.Add(new SqlElement("displacement", obj.Displacement, true));
            
            list.Add(new SqlElement("transmission", obj.Transmission, true));
          
           
            list.Add(new SqlElement("innerstyle", obj.InnerStyle, true));
          
        
            list.Add(new SqlElement("carofyear", obj.CarOfYear, true));
        
         
            list.Add(new SqlElement("costprice", obj.CostPrice.ToString(), false));
        
          
            list.Add(new SqlElement("allotprice", obj.AllotPrice.ToString(), false));
         
          
            list.Add(new SqlElement("saleprice", obj.SalePrice.ToString(), false));
           
           
            list.Add(new SqlElement("minprice", obj.MinPrice.ToString(), false));
          
      
            string sql = CreateSqlUtil.CreateUpdateSql(list, "cardetail");
            sql = sql + string.Format(" where id ={0} ", id);
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }
        public bool DelCarDetail(int id)
        {
            string sql = CreateSqlUtil.CreateDelSql("id", "cardetail", id);
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable GetCarDetails()
        {
            string sql = "select  a.autonumber, a.color, a.displacement, a.transmission,a.innerstyle, a.carofyear, a.costprice, a.allotprice, a.saleprice, a.minprice  from cardetail as a left join carmodel as b on a.carmodel = b.id order by a.carmodel asc";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }
        public DataTable GetCarDetails(int id)
        {
            string sql = string.Format("select  a.autonumber, a.color, a.displacement, a.transmission,a.innerstyle, a.carofyear, a.costprice, a.allotprice, a.saleprice, a.minprice,b.id as carmodelid,b.carmodel as carmodelname from cardetail as a left join carmodel as b on a.carmodel = b.id where a.id={0} order by a.carmodel asc", id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }
        public DataTable GetCarDetailByCarmodel(int carmodel_id)
        {
            string sql = string.Format("select  a.id,a.autonumber, a.color, a.displacement, a.transmission,a.innerstyle, a.carofyear, a.costprice, a.allotprice, a.saleprice, a.minprice, a.carmodel,b.carmodel as carmodelname  from cardetail as a left join carmodel as b on a.carmodel = b.id where b.id={0} order by a.carmodel asc", carmodel_id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }
        #endregion

        public DataSet GetCarDocAll()
        {
            DataSet ds = new DataSet();
            DataTable dtCarBrand = GetCarBrands();
            dtCarBrand.TableName = "CarBrand";
            DataTable dtCarSer = GetCarSers();
            dtCarSer.TableName = "CarSer";
            DataTable dtCarModel = GetCarModels();
            dtCarModel.TableName = "CarModel";
            //DataTable dtCarDetail = GetCarDetails();
            //dtCarDetail.TableName = "CarDetail";
            ds.Tables.Add(dtCarBrand);
            ds.Tables.Add(dtCarSer);
            ds.Tables.Add(dtCarModel);
            //ds.Tables.Add(dtCarDetail);

            return ds;
        }
    }
}
