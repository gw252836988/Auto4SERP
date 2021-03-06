﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using Comm;
using DBUtil;
using System.Data.SqlClient;
namespace Bll.Sale
{
    public class CarStockBll : ICarStock
    {
        private DBHelper mDB;
        public CarStockBll()
        {
            mDB = DBHelperShare.getInstance();
        }




        public void DelCarInD(string id)
        {
            string sql = "delete from carind where id=" + id;
            mDB.ExecuteNonQuery(sql);

        }


        public bool AddCarInD(CarInD obj)
        {
            List<SqlElement> list = new List<SqlElement>();
          
           // list.Add(new SqlElement("CarDetail", obj.CarDetail.ToString(), false));
            list.Add(new SqlElement("InPrice", obj.InPrice.ToString(), false));
           

            list.Add(new SqlElement("StorePlace", obj.StorePlace, true));
            list.Add(new SqlElement("Vin", obj.Vin, true));
            list.Add(new SqlElement("DH", obj.DH, true));
            list.Add(new SqlElement("AutoNumber", obj.AutoNumber, true));

            string sql = CreateSqlUtil.CreateInsertSql(list, "carind");
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;

        }


        public bool UpdateCarInD(CarInD obj)
        {
            List<SqlElement> list = new List<SqlElement>();

           // list.Add(new SqlElement("CarDetail", obj.CarDetail.ToString(), false));
            list.Add(new SqlElement("InPrice", obj.InPrice.ToString(), false));
            
            list.Add(new SqlElement("StorePlace", obj.StorePlace, true));
            list.Add(new SqlElement("Vin", obj.Vin, true));
            list.Add(new SqlElement("AutoNumber", obj.AutoNumber, true));

            string sql = CreateSqlUtil.CreateUpdateSql(list, "carind") + string.Format(" where id ='{0}' ", obj.ID);

            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;


        }
        public void updateDirectPriceOfCar(string autonumber,string directprice)
        {

            string sql = string.Format("update cardetail set DirectPrice={0} where autonumber ='{1}'",directprice,autonumber);
            mDB.ExecuteNonQuery(sql);
        }


       public  bool UpdateCarInH(CarInH obj)
        {
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("InDate", obj.InDate.ToString(), true));
            list.Add(new SqlElement("InPattern", obj.InPattern.ToString(), true));
            list.Add(new SqlElement("Remark", obj.Remark, true));
            list.Add(new SqlElement("Supplier", obj.Supplier, true));
            string sql = CreateSqlUtil.CreateUpdateSql(list, "carinh") + string.Format(" where DH ='{0}' ", obj.DH);

            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;


        }

        public string GetDHOfAddCarInH(CarInH obj)
        {
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("InDate", obj.InDate.ToString(), true));
            list.Add(new SqlElement("InPattern", obj.InPattern.ToString(), true));
            list.Add(new SqlElement("Remark", obj.Remark, true));
            list.Add(new SqlElement("Supplier", obj.Supplier, true));
            list.Add(new SqlElement("Status", "0", false));
            list.Add(new SqlElement("DH", "dbo.GetCarInDH('"+ Comm.LoginInfoShare.getInstance().OrganId+ "')", false));
            list.Add(new SqlElement("OperatorMan",obj.OperatorMan, true));

            string sql = CreateSqlUtil.CreateInsertSql(list, "carinh");
            sql = sql + " SELECT @@IDENTITY AS Id ";

            DataTable dt = mDB.ExecuteDataTable(sql);
            string id = dt.Rows[0][0].ToString();
            sql = "select dh from carinh where id =" + id;
            dt = mDB.ExecuteDataTable(sql);
            string dh = dt.Rows[0][0].ToString();
            return dh;


        }


        public DataTable GetCarInDs(string dh)
        {
            string sql = "select carind.id,carind.Cardetail,v_cardoc.AutoNumber,v_cardoc.CarModel,v_cardoc.Color,v_cardoc.Displacement,carind.InPrice,carind.StorePlace,carind.Vin from carind left join v_cardoc on carind.autonumber=v_cardoc.autonumber" + " where carind.dh='" + dh + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }

        public CarInH GetCarInH(string dh)
        {
            string sql = "select * from carinH where dh='" + dh + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            CarInH obj = new CarInH();
            obj.DH =dt.Rows[0]["dh"].ToString();
            obj.InDate = dt.Rows[0]["InDate"].ToString();
            obj.InPattern = dt.Rows[0]["InPattern"].ToString();
            obj.Remark = dt.Rows[0]["Remark"].ToString();
            obj.Supplier = dt.Rows[0]["Supplier"].ToString();
            obj.Status = int.Parse( dt.Rows[0]["Status"].ToString());
            

            return obj;
        }


        public DataTable GetCarInHsOfDefault()
        {
            string sql = "select top 30 case when Status=0 then '未入库' else '已入库' end as Status,DH,InDate,Supplier,InPattern from carinh";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }

        public DataTable GetCarInHsOfQuery(string strBegin,string strEnd,CarInH obj)
        {
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement() { Name = "Supplier", Value = obj.Supplier, IsFuzzy = true, IsStr = true });
            list.Add(new SqlElement() {Name="DH",Value=obj.DH,IsFuzzy=true,IsStr=true});
            string sql = "select  case when Status=0 then '未入库' else '已入库' end as Status,DH,InDate,Supplier,InPattern from carinh where ";
            sql=sql +  CreateSqlUtil.CreateQuerySqlOfCondition(list,true);
            sql = sql +string.Format(" and InDate>='{0}' and inDate<='{1}'",strBegin,strEnd);
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }



        public DataTable GetCarInHsOfQuery(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string IndexField = "DH";
            string AllFields = "case when Status=0 then '未入库' else '已入库' end as Status,DH,OperatorMan,InDate,Supplier,InPattern";
            string Condition = "carinh where ";
            string OrderFields = "order by inDate desc";
            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

            //string sql = "select  case when Status=0 then '未入库' else '已入库' end as Status,DH,InDate,Supplier,InPattern from carinh where ";
            //if (list != null)
            //    sql = sql + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            //else
            //    sql = sql + "1=1";
            if(strBegin!="")
                Condition = Condition + string.Format(" and InDate>='{0}' and inDate<='{1}'", strBegin, strEnd);
            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;


        }

        public void DoCarInStock(string dh)
        {
            string sql = "update carinH set status=1 where dh ='" + dh + "'";
            mDB.ExecuteNonQuery(sql);
            
            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15),
				    new SqlParameter("@succount", SqlDbType.Int)
					};
            parameters[0].Value = dh;
            parameters[1].Direction = ParameterDirection.Output;
            mDB.ExecuteNonQueryByPro("CarInStock",parameters);

        }

        public bool IsInOfCarinH(string dh)
        {
            string sql = string.Format("select * from CarinH where dh='{0}' and status=1", dh);
            bool b = mDB.IsExists(sql);
            return b;

        }

        public bool DelCarInH(string dh)
        {
            string sql = string.Format("select dh from carinD where dh='{0}'",dh);
            if (!mDB.IsExists(sql))
            {
                sql = string.Format("delete from carinH where dh='{0}'", dh);
                mDB.ExecuteNonQuery(sql);
                return true;
            }
            else
                return false;
        }


        public DataTable GetCarsOfStock()
        {
            string sql = "select [ID],case when status=0 then '未出库'  when status=1 then '锁定' else '已出库' end as Status ,DetailID,AutoNumber,DATEDIFF(DAY,CarInDate,getdate()) as StockDays,BrandName,CarSer,CarModel,Color,Displacement,Transmission,CarOfYear,SalePrice,StorePlace,Vin,ItemIDFrom,Image,CarInDate,InPrice,DirectPrice from v_carstock where status=0";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;
        }

        public DataTable GetCarsOfStockByQuery(List<SqlElement> lst,int days)
        {
            var r=lst.Where(o => o.Name == "Status");
            string sql ;
            int status=0;
            if (r.Count() > 0)
            {
                SqlElement o = r.First();
                status = int.Parse(o.Value);
            }
            string conditoin = CreateSqlUtil.CreateQuerySqlOfCondition(lst, true);
            if (status < 2)
            {
                sql = "select [ID],case when status=0 then '未出库'  when status=1 then '锁定' else '已出库' end as Status,DetailID,AutoNumber,DATEDIFF(DAY,CarInDate,getdate()) as StockDays,BrandName,CarSer,CarModel,Color,Displacement,Transmission,CarOfYear,SalePrice,StorePlace,Vin,ItemIDFrom,Image,CarInDate,InPrice,DirectPrice from v_carstock where  " + conditoin;
                if (days > 0)
                    sql += " and DATEDIFF(DAY,CarInDate,getdate())>" + days;
            }
            else
                sql = "select [ID],case when status=0 then '未出库'  when status=1 then '锁定' else '已出库' end as Status,DetailID,AutoNumber,0 as StockDays,BrandName,CarSer,CarModel,Color,Displacement,Transmission,CarOfYear,SalePrice,StorePlace,Vin,ItemIDFrom,Image,CarInDate,InPrice,DirectPrice from v_carstock where  " + conditoin;
            
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }

        public bool UpdateCarStockInfo(CarStock obj)
        {
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("InPrice", obj.InPrice.ToString(), false));
            list.Add(new SqlElement("StorePlace", obj.StorePlace, true));
            list.Add(new SqlElement("Vin", obj.Vin, true));
            list.Add(new SqlElement("Image", obj.Image, true));
            list.Add(new SqlElement("AutoNumber", obj.AutoNumber, true));


            string sql = CreateSqlUtil.CreateUpdateSql(list, "carstock");
            sql = sql + string.Format(" where id ={0} ", obj.ID);

            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
            }
            return false;
        }

        public void DeleteCarStock(string id,string itemId)
        {
            string sql = string.Format("delete from carstock where id='{0}';delete from carind where id='{1}'", id, itemId);
            mDB.ExecuteNonQuery(sql);
        }

        public void UpdateStatus(string vin,int stauts)
        {
            string sql = string.Format("update carstock set status={0} where vin='{1}'",stauts,vin);
            mDB.ExecuteNonQuery(sql);
        }

        public int GetCarStockStatus(string vin)
        {
            string sql = "select status from carstock where vin='" + vin + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            int status = 0;
            if(dt.Rows.Count >0)
                status = int.Parse(dt.Rows[0][0].ToString());
            return status;

        }

        public string  GetCarStockAutoNumber(string vin)
        {
            string sql = "select AutoNumber from carstock where vin like '%" + vin + "%'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            string autonumber = "";
            if (dt.Rows.Count > 0)
                autonumber =dt.Rows[0][0].ToString();
            return autonumber;

        }

        public bool IsExistOfVin(string vin)
        {
            string sql = "select * from carstock where vin ='" + vin +"'";
            bool b = mDB.IsExists(sql);
            return b;

        }


        public int GetOverCountOfStock()
        {
            string sql = "select isnull(count(*),0) from carstock where DATEDIFF(DAY,CarInDate,getdate())>90 and status=0";
            DataTable dt = mDB.ExecuteDataTable(sql);
            int count = 0;
            if (dt.Rows.Count > 0)
            {
                count =int.Parse(dt.Rows[0][0].ToString());

            }
            return count;

        }

        public void CarInHBack(string dh)
        {

            string sql;
            sql = "delete from carstock where dhfrom='" + dh +"'";
            mDB.ExecuteNonQuery(sql);
            sql = "update carind set status=0  where dh='" + dh + "'";
            mDB.ExecuteNonQuery(sql);
            sql = "update carinH  set status=0 where dh='" + dh + "'";
            mDB.ExecuteNonQuery(sql);

        }

        public bool CarInHIsBack(string dh)
        {
            string sql = "";
            sql = "select * from carstock where dhfrom='" + dh + "' and status!=0";

            if (mDB.IsExists(sql))
            {
                return false;
            }
            else
                return true;
        }


        public DataTable GetCarsOutAndInReport(string year)
        {
            DateTime tBegin = Convert.ToDateTime(year + "-" +"01-01");
            DateTime tEnd;
            string sql;
            DataTable dtReport = new DataTable();
            dtReport.Columns.Add("month", typeof(string));
            dtReport.Columns.Add("incount",typeof(string));
            dtReport.Columns.Add("inje", typeof(string));
            dtReport.Columns.Add("outcount", typeof(string));
            dtReport.Columns.Add("outje", typeof(string));
            for (int i = 1; i <= 12; i++)
            {
                tEnd = tBegin.AddMonths(1);
                DataRow dr=dtReport.NewRow();
               
                sql = string.Format("select count(*) as incount ,sum(inprice) as inje from carind as a  inner join carinh as b on a.dh=b.dh  where b.status=1 and b.indate>='{0}' and b.indate<'{1}'", tBegin.ToShortDateString(), tEnd.ToShortDateString());
                DataTable dt = mDB.ExecuteDataTable(sql);
                dr["incount"] = dt.Rows[0][0];
                dr["inje"] = dt.Rows[0][1];

                sql = string.Format("select count(*) as outcount ,sum(carprice) outje  from carsale where status=3 and  accountdate>='{0}' and accountdate<'{1}'", tBegin.ToShortDateString(), tEnd.ToShortDateString());
                dt = mDB.ExecuteDataTable(sql);
                dr["outcount"] = dt.Rows[0][0];
                dr["outje"] = dt.Rows[0][1];

                dr["month"] = i + "月";
                dtReport.Rows.Add(dr);
                tBegin = tEnd;
            }
            return dtReport;
        }


        public void ChangeVinOfSale(string vinOld,string vinNew)
        {
            string sql;
            sql = string.Format("update carstock set status=0 where vin='{0}';update carstock set status=2 where vin='{1}';update carsale set vin='{1}' where vin='{0}'",vinOld,vinNew);
            mDB.ExecuteNonQuery(sql);

        }
    
    }
}
