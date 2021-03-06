﻿using Comm;
using DBUtil;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Sale
{
    public class CarDocBll : ICarDoc,Bll.IBatchIn
    {
        private DBHelper mDB;
        public CarDocBll()
        {
            mDB = DBHelperShare.getInstance();
        }

        public string BatchInDB(DataTable dt, string append)
        {
            try
            {
                string sql = "";
                DelTempRecord();
                mDB.BatchInsert("tmp_cardetail", dt);

                sql = "insert into cardetail([AutoNumber],[Color],[Displacement],Transmission,InnerStyle,CarOfYear,CarModel) select [AutoNumber],[Color],[Displacement],Transmission,InnerStyle,CarOfYear,CarModel from tmp_cardetail";
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

            mDB.ExecuteNonQuery("delete from tmp_cardetail");

        }

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
           // string sql = CreateSqlUtil.CreateDelSql("id", "carser", id);
            string sql = "update carser set disabled=1 where id=" + id;
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetCarSers()
        {
            string sql = "select a.id,a.carser,a.carbrand,a.disabled,b.BrandName  from carser as a left join carbrand as b on a.carbrand = b.id order by a.carbrand asc";
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
       
        public bool AddCarModel(string carmodel, int carser_id,string  id)
        {
            //string sql = CreateSqlUtil.CreateIsExistInsertStringSql("carmodel", "carmodel", carmodel);
            //bool b = mDB.IsExists(sql);
            //if (!b)
            //{
                string sql = "";
                List<SqlElement> list = new List<SqlElement>();
                list.Add(new SqlElement("carmodel", carmodel, true));
                list.Add(new SqlElement("carser", carser_id.ToString(), false));
                list.Add(new SqlElement("ID", id, false));
                sql = CreateSqlUtil.CreateInsertSql(list, "carmodel");
                int k = mDB.ExecuteNonQuery(sql);
                if (k > 0)
                {
                    return true;
                }
            //}
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
          // string sql = CreateSqlUtil.CreateDelSql("id", "carmodel", id);
            string sql = "update carmodel set disabled=1 where id=" + id;
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable GetCarModels()
        {
            string sql = "select a.id,a.carmodel,a.carser,b.carser as carsername,a.disabled from carmodel as a left join carser as b on a.carser = b.id order by a.carser asc";
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
      
        public bool AddCarDetail(CarDetail obj, int carmodel_id)
        {

            //lst.Add(new SqlElement("DH", "dbo.GetRepairDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", false));
           // string sql = CreateSqlUtil.CreateIsExistInsertStringSql("autonumber", "cardetail", obj.AutoNumber);
           // bool b = mDB.IsExists(sql);
            //if (!b)
            //{
                string sql;
                string pre = "";

                pre = Comm.ElseUtil.GetCarAutoNumberPre();
                string autonumber = string.Format("dbo.GetCarDetailXH('{0}')", pre);
                
                List<SqlElement> list = new List<SqlElement>();

                list.Add(new SqlElement("autonumber", autonumber, false));

                list.Add(new SqlElement("color", obj.Color, true));


                list.Add(new SqlElement("displacement", obj.Displacement, true));


                list.Add(new SqlElement("transmission", obj.Transmission, true));


                list.Add(new SqlElement("innerstyle", obj.InnerStyle, true));


                list.Add(new SqlElement("carofyear", obj.CarOfYear, true));


                list.Add(new SqlElement("costprice", obj.CostPrice.ToString(), false));

                list.Add(new SqlElement("allotprice", obj.AllotPrice.ToString(), false));

                list.Add(new SqlElement("DirectPrice", obj.DirectPrice.ToString(), false));

                list.Add(new SqlElement("saleprice", obj.SalePrice.ToString(), false));

                list.Add(new SqlElement("minprice", obj.MinPrice.ToString(), false));

                if (carmodel_id > 0)
                {
                    list.Add(new SqlElement("carmodel", carmodel_id.ToString(), false));
                }
                sql = CreateSqlUtil.CreateInsertSql(list, "cardetail");
                int k = mDB.ExecuteNonQuery(sql);
                return false;
            //}
            //else
            //    return true;
        }


        public bool UpdateCarDetail(CarDetail obj,  int carmodel_id, int id)
        {
       
            List<SqlElement> list = new List<SqlElement>();

      
     
            list.Add(new SqlElement("color", obj.Color, true));
          
            list.Add(new SqlElement("displacement", obj.Displacement, true));
            
            list.Add(new SqlElement("transmission", obj.Transmission, true));
          
           
            list.Add(new SqlElement("innerstyle", obj.InnerStyle, true));
          
        
            list.Add(new SqlElement("carofyear", obj.CarOfYear, true));
        
         
           //  list.Add(new SqlElement("costprice", obj.CostPrice.ToString(), false));
        
          
           list.Add(new SqlElement("allotprice", obj.AllotPrice.ToString(), false));


           list.Add(new SqlElement("DirectPrice", obj.DirectPrice.ToString(), false));
           
           
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
            bool isDo;
            string sql;
            sql = string.Format("select * from carstock  WHERE AutoNumber =(SELECT AutoNumber  FROM  cardetail  WHERE  ID = {0})",id);
           
            isDo = mDB.IsExists(sql);

            if (isDo) return false;

            sql = CreateSqlUtil.CreateDelSql("id", "cardetail", id);
            mDB.ExecuteNonQuery(sql);
            return true;
         
        }
        public DataTable GetCarDetails()
        {
            string sql = "select  a.autonumber, a.color, a.displacement, a.transmission,a.innerstyle, a.carofyear, a.costprice, a.allotprice, a.saleprice, a.minprice  from cardetail as a left join carmodel as b on a.carmodel = b.id order by a.carmodel asc";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }
        public DataTable GetCarDetails(int id)
        {
            string sql = string.Format("select  a.autonumber, a.color, a.displacement, a.transmission,a.innerstyle, a.carofyear, a.costprice, a.allotprice,a.directprice, a.saleprice, a.minprice,b.id as carmodelid,b.carmodel as carmodelname from cardetail as a left join carmodel as b on a.carmodel = b.id where a.id={0} order by a.carmodel asc", id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }

        public DataTable GetCarDetailByCarmodel(int carmodel_id)
        {
            string sql ;
            if(carmodel_id>0)
               sql = string.Format("select  a.id,a.AutoNumber, a.Color, a.Displacement, a.Transmission,a.InnerStyle, a.CarOfYear, a.CostPrice ,a.SalePrice,a.DirectPrice, a.carmodel,b.carmodel as carmodelname  from cardetail as a left join carmodel as b on a.carmodel = b.id where b.id={0} order by a.carmodel asc", carmodel_id);
            else
                sql = "select  a.id,a.AutoNumber, a.Color, a.Displacement, a.Transmission,a.InnerStyle, a.CarOfYear, a.CostPrice ,a.SalePrice,a.DirectPrice, a.carmodel,b.carmodel as carmodelname  from cardetail as a left join carmodel as b on a.carmodel = b.id  order by a.carmodel asc";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }

        public DataTable GetCarDetailByPrice(string price)
        {
            string sql;
            DataTable dt = null;
            if (!string.IsNullOrEmpty(price))
            {
                sql = string.Format("select  a.id,a.AutoNumber, a.Color, a.Displacement, a.Transmission,a.InnerStyle, a.CarOfYear, a.CostPrice ,a.SalePrice,a.DirectPrice, a.carmodel,b.carmodel as carmodelname  from cardetail as a left join carmodel as b on a.carmodel = b.id where a.DirectPrice={0} and b.CarSer>799 order by a.carmodel asc", price);
                dt = mDB.ExecuteDataTable(sql);
            }
            return dt;
        }

        public DataTable GetCarDetailVById(int detailId)
        {
            string sql = string.Format("select * from v_cardoc where id=" + detailId);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;


        }

        public CarDetail GetCarDetailObjectById(int detailId)
        {
            string sql = string.Format("select * from v_cardoc where id=" + detailId);
            DataTable dt = mDB.ExecuteDataTable(sql);

            CarDetail obj = new CarDetail();
            obj.AutoNumber = dt.Rows[0]["autonumber"].ToString();
            obj.Color = dt.Rows[0]["color"].ToString();
            obj.Displacement = dt.Rows[0]["displacement"].ToString();
            obj.Transmission = dt.Rows[0]["transmission"].ToString();
            obj.InnerStyle = dt.Rows[0]["innerstyle"].ToString();

            obj.CarOfYear= dt.Rows[0]["carofyear"].ToString();
            obj.AllotPrice = decimal.Parse(dt.Rows[0]["allotprice"].ToString());
            obj.CostPrice = decimal.Parse(dt.Rows[0]["costprice"].ToString());
            obj.MinPrice = decimal.Parse(dt.Rows[0]["minprice"].ToString());
            obj.SalePrice = decimal.Parse(dt.Rows[0]["saleprice"].ToString());

            obj.CarBrand = dt.Rows[0]["BrandName"].ToString();
            obj.CarModel = dt.Rows[0]["CarModel"].ToString();
            obj.CarSer = dt.Rows[0]["CarSer"].ToString();
            return obj;
        }

        public CarDetail GetCarDetailObjectByAutoNumber(string  autonumber)
        {
            string sql = string.Format("select * from v_cardoc where autonumber='" + autonumber + "'");
            DataTable dt = mDB.ExecuteDataTable(sql);
            CarDetail obj = null;
            if (dt.Rows.Count > 0)
            {
                obj = new CarDetail();

                obj.AutoNumber = dt.Rows[0]["autonumber"].ToString();
                obj.Color = dt.Rows[0]["color"].ToString();
                obj.Displacement = dt.Rows[0]["displacement"].ToString();
                obj.Transmission = dt.Rows[0]["transmission"].ToString();
                obj.InnerStyle = dt.Rows[0]["innerstyle"].ToString();

                obj.CarOfYear = dt.Rows[0]["carofyear"].ToString();
                obj.AllotPrice = decimal.Parse(dt.Rows[0]["allotprice"].ToString());
                obj.CostPrice = decimal.Parse(dt.Rows[0]["costprice"].ToString());
                obj.MinPrice = decimal.Parse(dt.Rows[0]["minprice"].ToString());
                obj.SalePrice = decimal.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["saleprice"].ToString()));
                obj.DirectPrice = decimal.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["DirectPrice"].ToString()));

                obj.CarBrand = dt.Rows[0]["BrandName"].ToString();
                obj.CarModel = dt.Rows[0]["CarModel"].ToString();
                obj.CarSer = dt.Rows[0]["CarSer"].ToString();
            }
            return obj;
        }

        public CarDetail GetCarDetailObjectByVin(string Vin)
        {
            string sql = string.Format("select * from v_carstock where vin='" + Vin + "'");
            DataTable dt = mDB.ExecuteDataTable(sql);
            CarDetail obj = null;
            if (dt.Rows.Count > 0)
            {
                obj = new CarDetail();

                obj.AutoNumber = dt.Rows[0]["autonumber"].ToString();
                obj.Color = dt.Rows[0]["color"].ToString();
                obj.Displacement = dt.Rows[0]["displacement"].ToString();
                obj.Transmission = dt.Rows[0]["transmission"].ToString();
                obj.InnerStyle = dt.Rows[0]["innerstyle"].ToString();

                obj.CarOfYear = dt.Rows[0]["carofyear"].ToString();
               // obj.AllotPrice = decimal.Parse(dt.Rows[0]["allotprice"].ToString());
               // obj.CostPrice = decimal.Parse(dt.Rows[0]["costprice"].ToString());
               // obj.MinPrice = decimal.Parse(dt.Rows[0]["minprice"].ToString());
                obj.SalePrice = decimal.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["saleprice"].ToString()));
                //obj.DirectPrice = decimal.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["DirectPrice"].ToString()));

                obj.CarBrand = dt.Rows[0]["BrandName"].ToString();
                obj.CarModel = dt.Rows[0]["CarModel"].ToString();
                obj.CarSer = dt.Rows[0]["CarSer"].ToString();
            }
            return obj;
        }
        

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

        public string GetMaxZBH()
        {
            string sql = "select max(autonumber) as autonumber from cardetail";
            return mDB.ExecuteDataTable(sql).Rows[0][0].ToString();

        }

        public string GetMaxCarModelID(int serid)
        {
            string sql = "select max(ID) as maxID from carmodel where carser=" + serid  ;
            string max="";
            max=mDB.ExecuteDataTable(sql).Rows[0][0].ToString();
            if (max == "")
                max = serid + "001";
            return max;
        }

        public void UpdateCarPrice(string autonumber, double costprice, double saleprice, double directprice)
        {

            string sql = string.Format("update cardetail set costprice={0},saleprice={1},directprice={2} where autonumber='{3}'", costprice, saleprice, directprice, autonumber);

            mDB.ExecuteNonQuery(sql);

            sql = string.Format("insert saleprice(LimitPrice,autonumber,OperateMan) values({0},'{1}','{2}')", saleprice,autonumber,Comm.LoginInfoShare.getInstance().UserName);
            mDB.ExecuteNonQuery(sql);

        }

        public decimal GetNewSalePrice(string autonumber)
        {
            string sql = "SELECT     TOP 1  LimitPrice  FROM  saleprice  where autonumber='" + autonumber + "' ORDER BY InDate DESC";
            DataTable dt = mDB.ExecuteDataTable(sql);
            decimal price = 0;
            if(dt.Rows.Count >0)
            {
                price = decimal.Parse(dt.Rows[0][0].ToString());

            }
            return price;
        }


        public DataTable GetCarSerAndModels()
        {
            string sql;
            if(Comm.LoginInfoShare.getInstance().OrganId!="608")
                sql = "select a.carser,b.carmodel from carser as a inner join carmodel as b on a.ID=b.carser where a.ID>=800 and a.disabled is null and  b.disabled is null  order by a.carser asc";
            else
                sql = "select a.carser,b.carmodel from carser as a inner join carmodel as b on a.ID=b.carser where a.disabled is null and  b.disabled is null order by a.carser asc";

            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }

        public DataTable GetSalePricesOfYear(int year,string autonumber)
        {

            DateTime begindate = DateTime.Parse(year + "-1-1");
            DateTime enddate = begindate.AddYears(1);

            string sql = string.Format("select ID,limitprice,indate,operateman from saleprice where indate>='{0}' and indate<'{1}' and autonumber='{2}'", begindate.ToShortDateString(), enddate.ToShortDateString(),autonumber);
            return mDB.ExecuteDataTable(sql);

        }
    }
}