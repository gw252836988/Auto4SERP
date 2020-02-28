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
    class RepairAccessoryBll : Bll.Repair.IRepairAccessory
    {

        private DBHelper mDB;

        public RepairAccessoryBll()
        {
            mDB = DBHelperShare.getInstance();
        }

        //public DataTable GetAccessorysOfRepair(string dh)
        //{
        //    string sql = "select case when a.AccType=0 then '需求' when a.AccType=1 then '领料'  else '退料' end as AccType,a.accessorycode,b.accessoryname from repair_a as a  inner join accessory  as b on a.accessorycode =b.accessorycode  where a.dh='" + dh + "'";
        //    return mDB.ExecuteDataTable(sql);

        //}
        
        public DataTable GetAccessorysOfRepairAsTake(string dh)
        {
                                                                                                                                                                                                                                                                                                        //  select case when a.AccType=0 then '需求' when a.AccType=1 then '领料'  else '退料' end as AccType
            string sql = "select case when a.AccType=0 then '需求' when a.AccType=1 then '领料'  else '退料' end as AccType,BatchID,a.accessorycode,b.accessoryname,a.HouseName,a.Amount,a.SalePrice,cast(a.Amount*a.SalePrice as decimal(18,2)) as Sum ,a.TakeMan,a.TakeDate,a.XH,a.ItemName, case when a.status=2 then '负出库' else ' ' end as status  from repair_a as a  inner join accessory  as b on a.accessorycode =b.accessorycode  where a.dh='" + dh + "'  order by takedate asc";
            return mDB.ExecuteDataTable(sql);

        }


        public int UpdateBatchID(string dh)
        {
            int batchID=0;
            string sql = "select IsNull(max(batchid),0) from repair_a where dh='" + dh + "'";
            DataTable dt;
            dt = mDB.ExecuteDataTable(sql);
            if(dt.Rows.Count>0)
            {
                batchID = int.Parse(dt.Rows[0][0].ToString());
            }
            batchID = batchID + 1;
            sql = string.Format("update repair_a set batchid={0} where dh='{1}' and batchid is null", batchID, dh);
            mDB.ExecuteNonQuery(sql);
            return batchID;
        }

        public DataTable GetAccessorysOfTakePrint(string dh,string batchid)
        {

            string sql = "select case when a.AccType=0 then '需求' when a.AccType=1 then '领料'  else '退料' end as AccType,a.accessorycode,b.accessoryname,a.HouseName,a.Amount,a.SalePrice,cast(a.Amount*a.SalePrice  as decimal(18,2)) as Sum ,a.TakeMan,a.TakeDate,a.XH,a.ItemName,case when a.status=2 then '负出库' else ' ' end as Remark  from repair_a as a  inner join accessory  as b on a.accessorycode =b.accessorycode  where a.dh='" + dh + "' and  a.AccType in (1,2)" ;
            if (batchid != "0")
                sql += " and a.batchid=" + batchid;
            return mDB.ExecuteDataTable(sql);


        }


        public DataTable GetAccessorysOfRepairAsRep(string dh)
        {

            string sql = "select case when a.AccType=0 then '需求'  when a.AccType=1  then '领料'  else '退料' end as AccType,a.accessorycode,b.accessoryname,a.HouseName,a.Amount,a.SalePrice,a.FinalPrice,cast(a.Amount*a.SalePrice as decimal(18,2)) as Sum ,a.TakeMan,a.TakeDate,a.XH,a.ItemName,a.status,a.PriceType,cast(a.Amount*a.FinalPrice  as decimal(18,2)) as sum1, cast((100-a.Discount*100) as decimal(18,2)) as Discount  from repair_a as a  inner join accessory  as b on a.accessorycode =b.accessorycode  where a.dh='" + dh + "' and a.Status in(0,1,2) ";
            return mDB.ExecuteDataTable(sql);

        }

        public string GetQueryStrOfDemmand(string dh)
        {
            string sql = string.Format("select accessorycode from repair_a where AccType=0 and dh='{0}'",dh);

            DataTable dt = mDB.ExecuteDataTable(sql);
            StringBuilder strB = new StringBuilder();
            
            if (dt.Rows.Count > 0)
            {
                strB.Append("a.accessorycode in(");
                for (int i = 0; i < dt.Rows.Count;i++ )
                    strB.Append("'"+ dt.Rows[i][0].ToString() + "',");
                strB.Remove(strB.Length-1,1);
                strB.Append(")");
            }
            return strB.ToString();

        }

        public DataTable GetAccessorysOfRepairAsDemand(string dh)
        {

            string sql = "select case when a.AccType=0 then '需求' when a.AccType=1 then '领料'  else '退料' end as AccType,a.accessorycode,b.accessoryname,a.HouseName,a.Amount,a.SalePrice, cast(a.Amount*a.SalePrice as decimal(18,2)) as Sum ,cast(a.Amount*a.FinalPrice as decimal(18,2)) as SumF,a.TakeMan,a.TakeDate,a.XH,a.ItemName,a.status  from repair_a as a  inner join accessory  as b on a.accessorycode =b.accessorycode  where a.dh='" + dh + "' and a.AccType=0";
            return mDB.ExecuteDataTable(sql);

        }

        public void DelAccessoryDemand(string dh ,string xh)
        {
            string sql = string.Format("delete from repair_a where dh='{0}' and xh ='{1}'",dh,xh);
            mDB.ExecuteNonQuery(sql);
        }

        public AccessoryOfRep GetAccessoryOfRep(string xh,string dh)
        {
            string sql;
            sql = string.Format("select * from repair_a where dh='{0}' and xh={1}",dh,xh);
            DataTable dt = mDB.ExecuteDataTable(sql);
            AccessoryOfRep obj = null;
            if (dt.Rows.Count > 0)
            {
                obj = new AccessoryOfRep();
                obj.AccessoryCode = dt.Rows[0]["AccessoryCode"].ToString();
                obj.Amount = float.Parse(dt.Rows[0]["Amount"].ToString());
                obj.SalePrice = float.Parse(dt.Rows[0]["SalePrice"].ToString());
            }
            return obj;
        }


        public void UpdateAccessoryOfRepair(AccessoryOfRep obj)
        {
            string sql;
            List<SqlElement> lst = new List<SqlElement>();
            if(obj.Amount >0)
               lst.Add(new SqlElement("Amount", obj.Amount.ToString(), false));
            if (obj.SalePrice > 0)
              lst.Add(new SqlElement("SalePrice", obj.SalePrice.ToString(), false));
            if (!string.IsNullOrEmpty(obj.PriceType))
                lst.Add(new SqlElement("PriceType", obj.PriceType, true));
            if (obj.Discount >=0)
                lst.Add(new SqlElement("Discount", obj.Discount.ToString(), false));

            lst.Add(new SqlElement("FinalPrice", obj.FinalPrice.ToString(), false));

            sql = CreateSqlUtil.CreateUpdateSql(lst, "repair_a") + "where dh='" +  obj.DH + "' and xh=" + obj.XH.ToString();
            mDB.ExecuteNonQuery(sql);
        }



        public void AddAccessoryOfRepair(AccessoryOfRep obj, string dh, decimal amount, int wareid, string outtype)
        {
          
            string sql1;
            string sql2;
            StringBuilder strB = new StringBuilder();
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("DH", obj.DH, true));
            lst.Add(new SqlElement("AccessoryCode", obj.AccessoryCode, true));
            lst.Add(new SqlElement("XH", "dbo.GetRepairAXH('" + obj.DH + "')", false));
            lst.Add(new SqlElement("InPrice", obj.InPrice.ToString(), false));
            lst.Add(new SqlElement("SalePrice", obj.SalePrice.ToString(), false));
            lst.Add(new SqlElement("TakeMan", obj.TakeMan, true ));
            lst.Add(new SqlElement("Status", obj.Status.ToString(), false));
            lst.Add(new SqlElement("PriceType", "正常", true));
            lst.Add(new SqlElement("InType", obj.InType, true));
            lst.Add(new SqlElement("InDate", obj.InDate, true));
            lst.Add(new SqlElement("Amount", obj.Amount.ToString() , false));
            lst.Add(new SqlElement("WareID", obj.WareID.ToString(), false));
            lst.Add(new SqlElement("AccType", obj.AccType.ToString(), false));
            lst.Add(new SqlElement("TakeDate", "GetDate()", false));
            lst.Add(new SqlElement("HouseName", obj.HouseName, true));
            lst.Add(new SqlElement("ItemName", obj.ItemName, true));
            lst.Add(new SqlElement("Discount",obj.Discount.ToString(), false));
            lst.Add(new SqlElement("FinalPrice", obj.FinalPrice.ToString(), false));

            sql1 = CreateSqlUtil.CreateInsertSql(lst, "repair_a");
            //  mDB.ExecuteNonQuery(sql1);

            sql2 = "select  @id=max(xh) from repair_a where dh ='" + obj.DH + "'";
           // DataTable dt = mDB.ExecuteDataTable(sql1);

            strB.Append("begin transaction  ");
            strB.Append(sql1);
            strB.Append(";declare @id int;");
            strB.Append(sql2);
            strB.Append(string.Format(";exec AccessoryOutWareOfBatch '{0}',@id,{1},{2},'{3}' ", dh, amount, wareid, outtype));

            strB.Append("; commit  transaction");
            mDB.ExecuteNonQuery(strB.ToString());
           // int i =int.Parse(dt.Rows[0][0].ToString());
          //  return i;

        }
        public int  AddAccessoryOfRepair(AccessoryOfRep obj)
        {

            string sql;
      
            StringBuilder strB = new StringBuilder();
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("DH", obj.DH, true));
            lst.Add(new SqlElement("AccessoryCode", obj.AccessoryCode, true));
            lst.Add(new SqlElement("XH", "dbo.GetRepairAXH('" + obj.DH + "')", false));
            lst.Add(new SqlElement("InPrice", obj.InPrice.ToString(), false));
            lst.Add(new SqlElement("SalePrice", obj.SalePrice.ToString(), false));
            lst.Add(new SqlElement("TakeMan", obj.TakeMan, true));
            lst.Add(new SqlElement("Status", obj.Status.ToString(), false));
            lst.Add(new SqlElement("PriceType", "正常", true));
            lst.Add(new SqlElement("InType", obj.InType, true));
            lst.Add(new SqlElement("InDate", obj.InDate, true));
            lst.Add(new SqlElement("Amount", obj.Amount.ToString(), false));
            lst.Add(new SqlElement("WareID", obj.WareID.ToString(), false));
            lst.Add(new SqlElement("AccType", obj.AccType.ToString(), false));
            lst.Add(new SqlElement("TakeDate", "GetDate()", false));
            lst.Add(new SqlElement("HouseName", obj.HouseName, true));
            lst.Add(new SqlElement("ItemName", obj.ItemName, true));
            lst.Add(new SqlElement("Discount", obj.Discount.ToString(), false));
            lst.Add(new SqlElement("FinalPrice", obj.FinalPrice.ToString(), false));

            sql = CreateSqlUtil.CreateInsertSql(lst, "repair_a");
            mDB.ExecuteNonQuery(sql);

            sql = "select  max(xh) from repair_a where dh ='" + obj.DH + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);


            int i = int.Parse(dt.Rows[0][0].ToString());
            return i;

        }

        public decimal IsCanRecede(string dh ,int xh,string acccode,double  amount)
        {
            decimal result=0;
            string sql = string.Format("select * from repair_a where dh='{0}' and xh={1} and accessorycode='{2}' and amount>=Isnull(AmountRecede,0)+{3} and acctype=1",dh,xh,acccode ,amount);
            DataTable dt;
            dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                result = decimal.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["AmountRecede"].ToString()));
            }
            else
                result = -1;
            return result;
        }




        public void AddAccNavInfo(string acccode,double inprice,string housename)
        {
            string sql;
            sql = string.Format("insert accware(accessorycode,amount,inprice,housename,status) values('{0}',0,{1},'{2}',0)", acccode, inprice, housename);
            mDB.ExecuteNonQuery(sql);


        }



        public DataTable GetZHOutDemandsAndTakes(int index, string strBegin, string strEnd,int type)
        {
            string sql = "";

            sql = "select case when AccType=0 then '需求' when AccType=1 then '领料'  else '退料' end as AccType,AccessoryCode,CustName,SaleMan,accessoryname,dh ,amount,finalprice,amount*finalprice as JE  from v_zhdetails where ";
            if (index == 0)
                sql += string.Format(" ReceptTime>='{0}' and ReceptTime<='{1}'", strBegin, strEnd);
            else
                sql += string.Format(" AccountTime>='{0}' and AccountTime<='{1}'", strBegin, strEnd);
            sql += " and  gamount>0  and acctype=" + type + "order by dh asc";
            return mDB.ExecuteDataTable(sql);
        }

        public  DataTable  AccNegativeOut(string acccode ,decimal amount)
        {
            // 判断是曾有入库记录

            string sql = string.Format("select top 1 * from accware where accessorycode='{0}' order by indate desc",acccode);
            DataTable dt1 = mDB.ExecuteDataTable(sql);
           // bool reslut = true; ;
            if (dt1.Rows.Count > 0)
            {
                sql = string.Format("select * from accware where accessorycode='{0}' and status=2",acccode );
                //DataTable dt2 = mDB.ExecuteDataTable(sql);

                if (!mDB.IsExists(sql))
                {
                    sql = string.Format("insert accware(accessorycode,amount,inprice,housename,status) values('{0}',0,{1},'{2}',2)", dt1.Rows[0]["accessorycode"], dt1.Rows[0]["inprice"], dt1.Rows[0]["HouseName"]);
                    mDB.ExecuteNonQuery(sql);
                }
                //sql = string.Format("update accware set amount=amount-{0} where accessorycode='{0}' and status=2");
                //mDB.ExecuteNonQuery(sql);
                sql = string.Format("select * from accware where accessorycode='{0}' and status=2", acccode);

                return mDB.ExecuteDataTable(sql);

            }
            else
                return  null;


        }
       
    }
}
