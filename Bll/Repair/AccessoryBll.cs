using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DBUtil;
using Comm;
using Model;
using System.Data.SqlClient;
using Bll;
namespace Bll.Repair
{
    public class AccessoryBll : IAccessory,IBatchIn
    {
        private DBHelper mDB;
      
        public AccessoryBll()
        {
            mDB = DBHelperShare.getInstance();
        }


        public bool AddAccessory(Accessory obj)
        {
            string sql;
            sql = "select * from Accessory where AccessoryCode='" + obj.AccessoryCode + "'" ;
            if (mDB.IsExists(sql))
            {
                return false;

            }
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("AccessoryCode", obj.AccessoryCode, true));
            lst.Add(new SqlElement("AccessoryName", obj.AccessoryName, true));
            lst.Add(new SqlElement("AccessoryType", obj.AccessoryType, true));
            lst.Add(new SqlElement("Brand", obj.Brand, true));
            lst.Add(new SqlElement("ApplicationModel", obj.ApplicationModel, true));
            lst.Add(new SqlElement("ChangeCode", obj.ChangeCode, true));
            lst.Add(new SqlElement("IncreaseRate", obj.IncreaseRate.ToString(), false));
            lst.Add(new SqlElement("SalePrice", obj.SalePrice.ToString(), false));
            lst.Add(new SqlElement("StorePlace", obj.StorePlace, true));
            lst.Add(new SqlElement("Unit", obj.Unit, true));
            sql = CreateSqlUtil.CreateInsertSql(lst, "Accessory");
            mDB.ExecuteNonQuery(sql);
            return true;
        }


     
        public Accessory GetAccessoryByCode(string accessorycode)
        {
            string sql = "select AccessoryCode,AccessoryName,AccessoryType,Brand,ApplicationModel,StorePlace,Unit,IncreaseRate,SalePrice,IsEnabled from Accessory where AccessoryCode='" + accessorycode + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            Accessory obj = new Accessory();
            obj.AccessoryCode = dt.Rows[0]["AccessoryCode"].ToString();
            obj.AccessoryName = dt.Rows[0]["AccessoryName"].ToString();
            obj.AccessoryType = dt.Rows[0]["AccessoryType"].ToString();
            obj.ApplicationModel = dt.Rows[0]["ApplicationModel"].ToString();
            obj.Brand = dt.Rows[0]["Brand"].ToString();
            obj.StorePlace = dt.Rows[0]["StorePlace"].ToString();
            obj.Unit = dt.Rows[0]["Unit"].ToString();
            if (dt.Rows[0]["IncreaseRate"].ToString() == "")
                obj.IncreaseRate = 0;
            else
                obj.IncreaseRate =float.Parse(dt.Rows[0]["IncreaseRate"].ToString());
            obj.SalePrice = float.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["SalePrice"].ToString()));

            if (dt.Rows[0]["IsEnabled"].ToString() == "")
                obj.IsEnabled = 0;
            else
                obj.IsEnabled = int.Parse(dt.Rows[0]["IsEnabled"].ToString());
            
            return obj;
        }

        public void UpdateAccessory(Accessory obj)
        {
            string sql;
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("AccessoryCode", obj.AccessoryCode, true));
            lst.Add(new SqlElement("AccessoryName", obj.AccessoryName, true));
            lst.Add(new SqlElement("AccessoryType", obj.AccessoryType, true));
            lst.Add(new SqlElement("Brand", obj.Brand, true));
            lst.Add(new SqlElement("ApplicationModel", obj.ApplicationModel, true));
            lst.Add(new SqlElement("ChangeCode", obj.ChangeCode, true));
            lst.Add(new SqlElement("IncreaseRate", obj.IncreaseRate.ToString(), false));
            lst.Add(new SqlElement("SalePrice", obj.SalePrice.ToString(), false));
            lst.Add(new SqlElement("StorePlace", obj.StorePlace, true));
            lst.Add(new SqlElement("Unit", obj.Unit, true));
            lst.Add(new SqlElement("SmallType", obj.SmallType, true));
            sql = CreateSqlUtil.CreateUpdateSql(lst, "Accessory");
            sql = sql + " where AccessoryCode='" + obj.AccessoryCode + "'";
            mDB.ExecuteNonQuery(sql);
        }

      

        public void InAcc(string dh)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15)
				
					};
            parameters[0].Value = dh;
          
            mDB.ExecuteNonQueryByPro("AccessoryInWare", parameters);


        }


        public DataTable GetWareHouses()
        {
            string sql = "select housename from warehouse ";
            return mDB.ExecuteDataTable(sql);
        }

        public int  BackInAcc(string dh)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15),
				    new SqlParameter("@return",SqlDbType.Int)
					};
            parameters[0].Value = dh;
            parameters[1].Direction = ParameterDirection.ReturnValue;
            mDB.ExecuteNonQueryByPro("AccessoryInBack", parameters);
            return int.Parse(parameters[1].Value.ToString());
        }

      

        public DataTable GetAccsInWareAsTake(string housename,string acccode,string accname,string append)
        {
            string sql;
            //decimal amount=0;
            //DataTable dt;
            //sql = "select IsNull(sum(amount),0) from accware where AccessoryCode='" + acccode + "'";

            //dt = mDB.ExecuteDataTable(sql);
            //if (dt.Rows.Count > 0)
            //{

            //    amount = decimal.Parse(dt.Rows[0][0].ToString());

            //}
            //if (amount <= 0) return null;
            sql = "select top 30  a.ID,a.accessorycode,b.accessoryname,a.amount,a.InDate,a.HouseName from accware as a inner join accessory as b on a.accessorycode=b.accessorycode ";

            sql = sql + string.Format(" where a.housename like '%{0}%' and a.accessorycode like '%{1}%' and b.accessoryname like '%{2}%' and a.amount>0  ", housename, acccode, accname);

            if (!string.IsNullOrEmpty(append))
            {
                sql = sql + "and " + append;

            }

            sql =sql +" order by a.InDate asc";
            return mDB.ExecuteDataTable(sql);

        }


        public decimal GetInPriceOfAcc(string AccessoryCode)
        {
            decimal inprice=0;
            string sql = string.Format("select top 1 inprice from accware where inprice >0 and AccessoryCode='{0}' order by id desc", AccessoryCode);
            DataTable dt;
            dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
                inprice = decimal.Parse(dt.Rows[0][0].ToString());
            return inprice;

        }

        public DataTable GetAccInWareAsTake(string id)
        {
            string sql = "select a.housename,a.accessorycode,b.accessoryname,a.inprice,b.saleprice,a.id,a.amount,a.intype,a.indate from accware as a inner join accessory as b on a.accessorycode=b.accessorycode ";
            sql = sql + " where id='" + id + "'";
            return mDB.ExecuteDataTable(sql);

        }

        //检查批次库存
        public bool IsAccEnough(double amount,string acccode,string wareid)
        {
            string sql =string.Format( "select IsNull(sum(amount),0) from accware where accessorycode ='{0}' and ID={1}",acccode,wareid);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                double amountnow = double.Parse(dt.Rows[0][0].ToString());
                if (amountnow >= amount)
                    return true;

                else
                    return false;

            }
            else
                return false;


        }

        public bool IsAccEnoughOfBatch(double amount,int wareid)
        {
            string sql = string.Format("select IsNull(sum(amount),0) from accware where and id={1}",wareid);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                double amountnow = double.Parse(dt.Rows[0][0].ToString());
                if (amountnow >= amount)
                    return true;

                else
                    return false;

            }
            else
                return false;

        }

        public void AccOutWare(string dh,int xh,float amount)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15),
				    new SqlParameter("@vXH", SqlDbType.Int),
                    new SqlParameter("@vAmount", SqlDbType.Float)
					};
            parameters[0].Value = dh;
            parameters[1].Value = xh;
            parameters[2].Value = amount;
            mDB.ExecuteNonQueryByPro("[AccessoryOutWare]", parameters);
           

        }


        public void AccOutWareOfBatch(string dh, int xh, decimal amount ,int wareid,string outtype)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15),
				    new SqlParameter("@vXH", SqlDbType.Int),
                    new SqlParameter("@vAmount", SqlDbType.Decimal),
                     new SqlParameter("@vWareID", SqlDbType.Int),
                      new SqlParameter("@vOutType", SqlDbType.VarChar,10)
					};
            parameters[0].Value = dh;
            parameters[1].Value = xh;
            parameters[2].Value = amount;
            parameters[3].Value = wareid;
            parameters[4].Value = outtype;
            mDB.ExecuteNonQueryByPro("[AccessoryOutWareOfBatch]", parameters);


        }


        public void AccOutWareOfNegative(string dh, int xh, decimal amount, int wareid, string outtype)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15),
				    new SqlParameter("@vXH", SqlDbType.Int),
                    new SqlParameter("@vAmount", SqlDbType.Decimal),
                     new SqlParameter("@vWareID", SqlDbType.Int),
                      new SqlParameter("@vOutType", SqlDbType.VarChar,10)
					};
            parameters[0].Value = dh;
            parameters[1].Value = xh;
            parameters[2].Value = amount;
            parameters[3].Value = wareid;
            parameters[4].Value = outtype;
            mDB.ExecuteNonQueryByPro("[AccessoryOutWareOfNegative]", parameters);

        }

        public void AccessoryOutRecede(string dh, int xh,double  amountre)
        {

            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15),
				    new SqlParameter("@vXH", SqlDbType.Int),
                    new SqlParameter("@vAmountRe", SqlDbType.Decimal)
					};
            parameters[0].Value = dh;
            parameters[1].Value = xh;
            parameters[2].Value = amountre;
            mDB.ExecuteNonQueryByPro("[AccessoryOutRecede1]", parameters);


        }

        public void AccessoryOutRecede(string dh, int xh)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15),
				    new SqlParameter("@vXH", SqlDbType.Int)
                  
					};
            parameters[0].Value = dh;
            parameters[1].Value = xh;

            mDB.ExecuteNonQueryByPro("[AccessoryOutRecede]", parameters);
           
        }

        public DataTable GetReRecord(string dh )
        {
            string sql = "select * from repair_r where dh='" + dh + "'";
            return mDB.ExecuteDataTable(sql);

        }



        public bool IsCanRecede(string dh, int xh)
        {
            //判断是否是领料
            string sql = string.Format("select * from repair_a where dh='{0}' and xh={1} and accType=1 and IsNull(AmountRecede,0)=0", dh, xh);
            if (mDB.IsExists(sql))
                return true;

            else
                return false;
        }

        public void UpdateAccessoryEnabled(string code )
        {
            string sql = "";
            sql = string.Format("update Accessory set isenabled=1-Isnull(isenabled,0)  where AccessoryCode='{0}'",code);
            mDB.ExecuteNonQuery(sql);

        }


        //public int GetEnabledOfAccessory(string code)
        //{
        //    string sql = "";
        //    sql = string.Format("select isenabled from Accessory  where AccessoryCode='{0}'",code);
        //    DataTable dt = mDB.ExecuteDataTable(sql);



        //}
        public DataTable GetAccessorys(List<SqlElement> lst, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string IndexField = "AccessoryCode";
            string AllFields = "*,case when isenabled =1 then '是' else '否' end as enabled ";
            string Condition = "Accessory where ";
            //    string sql = "select * from Accessory  where ";
            if (lst != null && lst.Count != 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(lst, true);
            else
                Condition = Condition + "1=1";

            // DataTable dt = mDB.ExecuteDataTable(sql);
            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, "", PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;
        }

       





        public DataTable GetInDtOfWareRecs(string strBegin, string strEnd, List<SqlElement> list)
        {

            string sql = "select accessorycode ,accessoryname,indate,inreason,supplyunit,Dhfrom ,housename,amount ,inprice ,cast((inprice/1.13) as decimal(18,2)) as inprice1,Cast(amount*inprice as decimal(18,2)) as JE,Cast(amount*(inprice/1.13) as decimal(18,2)) as JE1 from v_inwarerec1 where ";
            string Condition = "";
            string OrderFields = "order by InDate desc";
            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

            if (strBegin != "")
                Condition = Condition + string.Format(" and InDate>='{0}' and InDate<='{1}'", strBegin, strEnd);
            sql += Condition;
            sql += OrderFields;
            return mDB.ExecuteDataTable(sql);
        
        }


        public DataTable GetInWareRecsSum(string strBegin, string strEnd, List<SqlElement> list)
        {
            string sql = "select sum(amount) as amount ,sum(inprice*amount) as inprice  from v_inwarerec1 where  ";
            string Condition = "";

            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";
            if (strBegin != "")
                Condition = Condition + string.Format(" and InDate>='{0}' and InDate<='{1}'", strBegin, strEnd);

            sql += Condition;
            return mDB.ExecuteDataTable(sql);

        }
        public DataTable GetInWareRecs(string strBegin, string strEnd, List<SqlElement> list)
        {
            string sql = "select accessorycode ,accessoryname,indate,inreason,supplyunit,Dhfrom ,housename,amount ,inprice ,cast((inprice/1.13) as decimal(18,2)) as inprice1,Cast(amount*inprice as decimal(18,2)) as JE,Cast(amount*(inprice/1.13) as decimal(18,2)) as JE1  from v_inwarerec1 where  ";
            string Condition = "";

            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";
            if (strBegin != "")
                Condition = Condition + string.Format(" and InDate>='{0}' and InDate<='{1}'", strBegin, strEnd);

            sql += Condition;

            return mDB.ExecuteDataTable(sql);



        }



        public DataTable GetInWareRecs(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {

            string IndexField = "ID";
            string AllFields = "*,Cast(amount*inprice as decimal(18,2)) as JE";
            string Condition = "v_inwarerec where ";
            string OrderFields = "order by ID desc";
            //string sql;
            //sql = "select   *  from v_inwarerec  where ";
            if (list != null && list.Count>0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

            if (strBegin != "")
                Condition = Condition + string.Format(" and InDate>='{0}' and InDate<='{1}'", strBegin, strEnd);

            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;
        }

        public DataTable GetOutWareRecs(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount,bool isAppend,bool isPc)
        {
            string IndexField = "ID";
            isPc = true;
            string AllFields = "*,cast(inprice/1.13 as decimal(18,2)) as inprice1,cast(saleprice*amount as decimal(18,2)) as  saleamount,cast(inprice *amount as decimal(18,2)) as inamount, cast((inprice/1.13) *amount as decimal(18,2)) as je1,case when status=2 then '负出库' else ' ' end as status1 ";
            string Condition = "v_outwarerec1 where ";
            string OrderFields = "order by outdate desc";

            if(isAppend)
                Condition = "v_outwarerec where ";

            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

            if (strBegin != "")
                Condition = Condition + string.Format(" and OutDate>='{0}' and OutDate<='{1}'", strBegin, strEnd);

            if (isPc)
                Condition = Condition + " and OutReason  !='入库退货' ";
            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;
        }


        public DataTable GetOutDtOfWareRecs(string strBegin, string strEnd, List<SqlElement> list, bool isAppend)
        {
            //string AllFields = "*,cast(inprice/1.17 as decimal(18,2)) as inprice1,cast(saleprice*amount as decimal(18,2)) as  saleamount,cast(inprice *amount as decimal(18,2)) as inamount, cast((inprice/1.17) *amount as decimal(18,2)) as je1,case when status=2 then '负出库' else ' ' end as status1 ";
            string sql = "";
            string Condition = " v_outwarerec1 where ";
            if (isAppend)
                Condition = "select case when status=2 then '负出库' else ' ' end as status, AccessoryCode,AccessoryName,HouseName,OutReason,OutDate,DHFrom,Amount,InPrice,cast(inprice/1.13 as decimal(18,2)) as inprice1,cast(inprice *amount as decimal(18,2)) as inamount,cast((inprice/1.16) *amount as decimal(18,2)) as je1,SalePrice,cast(saleprice*amount as decimal(18,2)) as  saleamount,SupplyUnit,Vin,OutToUnit,CustName,platenum from v_outwarerec where ";
            else
                Condition = "select  case when status=2 then '负出库' else ' ' end as status,AccessoryCode,AccessoryName,HouseName,OutReason,OutDate,DHFrom,Amount,InPrice,cast(inprice/1.13 as decimal(18,2)) as inprice1,cast(inprice *amount as decimal(18,2)) as inamount,cast((inprice/1.16) *amount as decimal(18,2)) as je1,SalePrice,cast(saleprice*amount as decimal(18,2)) as  saleamount,'' as SupplyUnit,'' as Vin,'' as OutToUnit,'' as CustName,'' as platenum from v_outwarerec1 where ";
            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";
            if (strBegin != "")
                Condition = Condition + string.Format(" and outDate>='{0}' and outDate<='{1}'", strBegin, strEnd);

           Condition = Condition + " and OutReason  !='入库退货' ";

            sql += Condition;
            sql +=  " order by outDate desc";
            return mDB.ExecuteDataTable(sql);

        }

        public DataTable GetSumOutWareRecs(string strBegin, string strEnd, List<SqlElement> list ,bool isPC)
        {

            string sql = "select sum(amount) as amount ,sum(inprice*amount) as inprice,sum(saleprice*amount) as saleprice  from v_outwarerec where  ";
            string Condition = "";
            isPC = true;

            if (list != null && list.Count > 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";
            if (strBegin != "")
                Condition = Condition + string.Format(" and outDate>='{0}' and outDate<='{1}'", strBegin, strEnd);

            if (isPC)
                Condition = Condition + " and OutReason  !='入库退货' ";

            sql += Condition;
            return mDB.ExecuteDataTable(sql);


        }


        public string  BatchInDB(DataTable dt,string append)
        {
            try
            {
                string sql="";
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

               mDB.BatchInsert("tmp_accessory",dt);
              
               FindRepeatRecord();
                //if (sql != "")
                //{
                //    DelTempRecord();
                //    return sql + "记录重复";
                   
                //}
                sql = "insert into accessory(AccessoryCode,AccessoryName,Brand,StorePlace,AccessoryType,IncreaseRate,ChangeCode,SalePrice,ApplicationModel,Unit) select * from tmp_accessory";
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

            mDB.ExecuteNonQuery("delete from tmp_accessory");

        }

        private void FindRepeatRecord()
        {
            string sql = "";

            //删除空记录
            mDB.ExecuteNonQuery("delete from tmp_accessory where AccessoryCode is NULL or AccessoryCode=''");
          //  sql = "select AccessoryCode from  tmp_accessory where AccessoryCode in (select AccessoryCode from accessory)";

            sql = "delete from tmp_accessory where AccessoryCode in (select AccessoryCode from accessory)";
            mDB.ExecuteNonQuery(sql);
            //DataTable dt = mDB.ExecuteDataTable(sql);
            //string resutl = "";
            //for (int i= 0; i<dt.Rows.Count;i++ )
            //{
            //    resutl= resutl + " " + dt.Rows[i][0].ToString();

            //}
            //return resutl;

        }

        private void AddAccessoryToTemp(Accessory obj)
        {
            string sql;
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("AccessoryCode", obj.AccessoryCode, true));
            lst.Add(new SqlElement("AccessoryName", obj.AccessoryName, true));
            lst.Add(new SqlElement("AccessoryType", obj.AccessoryType, true));
            lst.Add(new SqlElement("Brand", obj.Brand, true));
            lst.Add(new SqlElement("ApplicationModel", obj.ApplicationModel, true));
            lst.Add(new SqlElement("ChangeCode", obj.ChangeCode, true));
            lst.Add(new SqlElement("IncreaseRate", obj.IncreaseRate.ToString(), false));
            lst.Add(new SqlElement("SalePrice", obj.SalePrice.ToString(), false));
            lst.Add(new SqlElement("StorePlace", obj.StorePlace, true));
            lst.Add(new SqlElement("Unit", obj.Unit, true));
            sql = CreateSqlUtil.CreateInsertSql(lst, "tmp_Accessory");
            mDB.ExecuteNonQuery(sql);
        }

        public DataTable GetAccWareInfo(string items, List<SqlElement> lstE, string begindate, string enddate, int days)
        {
            // string sql = "select accessorycode,Max(accessoryname) as accessoryname,sum(amount) as amount  from v_accware where accessorycode ='123'  group by  accessorycode ,InType having sum(amount)>0 ";

            string sqlItem = "select  AccessoryCode,Max(accessoryname) as AccessoryName,sum(amount) as Amount,Max(InPrice) as '成本价',Cast(sum(amount)*Max(InPrice) as decimal(18,2)) as '金额',max(storeplace) as '库位', max(smalltype) as '配件小类',max(ApplicationModel)  as '适用车型',max(ChangeCode) as '互换码' ";
            string sqlCondition = "";
            if (lstE != null && lstE.Count > 0)
                sqlCondition = Comm.CreateSqlUtil.CreateQuerySqlOfCondition(lstE, true);

            string sqlGroup = " group by accessorycode ";
            string[] lstitems;
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlItem);

            if (items.Length > 0)
            {
                lstitems = items.Split(',');
                foreach (string str in lstitems)
                {

                    sql.Append(",Max(" + str + ") as " + str);
                    sqlGroup = sqlGroup + "," + str;
                    if (str == "DHFrom")
                    {
                        sql.Append(",Max(" + "SupplyUnit" + ") as 供货单位");
                        sqlGroup = sqlGroup + "," + "SupplyUnit";

                    }


                }

            }

            sql.Append(" from v_accware where 1=1 ");
            if (lstE != null && lstE.Count > 0)
                sql.Append(" and " + sqlCondition);
            if (begindate != "")
            {
                sql.Append(string.Format("and indate>='{0}' and indate<='{1}'", begindate, enddate));
            }

            if (days > 0)
            {
                sql.Append(" and DATEDIFF(DAY,indate,getdate())>" + days);

            }
            sql.Append(sqlGroup);

            sql.Append("  having sum(amount)!=0");

            return mDB.ExecuteDataTable(sql.ToString());
        }


        public DataTable GetSumAccWare(List<SqlElement> lstE, string begindate, string enddate, int days)
        {

            //string sql = "select Isnull(sum(amount),0) as qty ,cast(Isnull(sum(amount*inprice),0) as decimal(18,2)) as je from v_accware where 1=1";
            //string sqlCondition = "";
            //DataTable dt=null;
            //if (lstE != null && lstE.Count > 0)
            //{
            //    sqlCondition = Comm.CreateSqlUtil.CreateQuerySqlOfCondition(lstE, true);
            //    sql += " and " + sqlCondition;
            //}

            //if (begindate != "")
            //{
            //    sql +=string.Format("and indate>='{0}' and indate<='{1}'", begindate, enddate);
            //}

            //if (days > 0)
            //{
            //    sql+=string.Format(" and DATEDIFF(DAY,indate,getdate())>" + days);

            //}
            //dt = mDB.ExecuteDataTable(sql);
     
            
            //return dt;



            string sql = "select sum(num) ,sum(total) from (SELECT accessorycode,sum(amount) as num,sum(amount*inprice) as total,";
            sql += "(case when sum(amount)>0 then sum(amount*inprice)/sum(amount)  else 0 end) as price FROM v_accware where 1=1  ";

            string sqlCondition = "";
            DataTable dt = null;
            if (lstE != null && lstE.Count > 0)
            {
                sqlCondition = Comm.CreateSqlUtil.CreateQuerySqlOfCondition(lstE, true);
                sql += " and " + sqlCondition;
            }

            if (begindate != "")
            {
                sql += string.Format("and indate>='{0}' and indate<='{1}'", begindate, enddate);
            }

            if (days > 0)
            {
                sql += string.Format(" and DATEDIFF(DAY,indate,getdate())>" + days);

            }
            sql += " group by accessorycode   having sum(amount)>0) as temptable ";
            dt = mDB.ExecuteDataTable(sql);


            return dt;

        }

        


        public  bool CheckStore(string acccode,float amountDemmand)
        {
            string sql =string.Format( "select isnull(sum(amount),0) as amount  from accware where  accessorycode='{0}'",acccode);
            DataTable dt = mDB.ExecuteDataTable(sql);
            bool result=false;
            if (dt.Rows.Count > 0)
            {
                string tmpamount = dt.Rows[0][0].ToString();
                float amount = float.Parse(tmpamount);
                if (amount < amountDemmand)
                    result = false;
                else 
                    result =true;

            }
            return result;
        }


        public DataTable GetWareInfoOfDemamnd(string accessorycode)
        {
            string sql = string.Format("select  top 1 * from accware where accessorycode='{0}' and amount>0",accessorycode);

            return mDB.ExecuteDataTable(sql);


        }

        public float GetAccAmount(string accessorycode)
        {
            string sql = string.Format("select isnull(sum(amount),0) as amount from accware where accessorycode='{0}'",accessorycode);

            DataTable dt = mDB.ExecuteDataTable(sql);
            float amount=0;
            if (dt.Rows.Count > 0)
            {
                amount = float.Parse(dt.Rows[0][0].ToString());
            }
            return amount;
        }

        public DataTable GetNormalAccOutRank(string housename,string acccode, string strBegin, string strEnd,bool ischb)
        {
            string condition = "where 1=1 ";
            string having="";
            string sql = "";

            if (housename != "")
                condition = condition + " and housename ='" + housename + "'";

            if (ischb)
                condition = condition + " and repchildtype  like '%索赔%'";

            if (strBegin != "")
                condition += string.Format("and outdate>='{0}' and outdate<='{1}'", strBegin, strEnd);
            if(acccode!="")
                having = having + " having Max(AccessoryCode) ='" + acccode + "'";

            sql = string.Format("select  Max(AccessoryCode) as AccessoryCode ,Max(accessoryname) as AccessoryName,Max(housename) as housename,sum(amount) as Amount ,max(inprice) as inprice,max(saleprice) as saleprice,sum(inprice*amount) as inje,sum(saleprice*amount) as zje from v_outwarerec  " + condition + " group by AccessoryCode  " + having);


          
            //if(acccode=="")
            //    sql += " union all select  '合计' as AccessoryCode,' ' as AccessoryName ,'' as housename ,sum(amount)  as Amount ,sum(inprice*amount) as inprice, sum(saleprice*amount)  as saleprice from v_outwarerec " + condition;
           
           // sql+= " order by sum(amount) desc";
            sql = "select a.*,b.sumamount from (" + sql + ") as a,v_accstock as b where a.AccessoryCode=b.AccessoryCode";
            return mDB.ExecuteDataTable(sql);
        }


        public decimal GetZHJEOfQuery(int index,string strBegin, string strEnd)
        {

            decimal result = 0;
            string sql;
            sql = "select sum(PresentDecorPrice)  from carsale where vin in ";

            if (index == 0)
                sql = sql + string.Format("(select vin from repair where ReceptTime>='{0}' and ReceptTime<='{1}' and repchildtype='销售装潢') ", strBegin, strEnd);
            else
                sql = sql + string.Format("(select vin from repair where Accounttime>='{0}' and Accounttime<='{1}' and repchildtype='销售装潢') ", strBegin, strEnd);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
                result = decimal.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0][0].ToString()));
            return result;
            
        }


        public DataTable GetZHDemandsDetails(int index,string strBegin, string strEnd)
        {
            string sql = "";

            sql = "select AccessoryCode,accessoryname,dh ,ReceptTime,AccountTime,CustName,amount,finalprice,amount*finalprice as JE ,PresentDecorPrice from v_zhdetails where ";
            if(index==0)
              sql += string.Format(" ReceptTime>='{0}' and ReceptTime<='{1}'", strBegin, strEnd);
            else
                sql += string.Format(" AccountTime>='{0}' and AccountTime<='{1}'", strBegin, strEnd);

            sql += "and acctype=0";
            return mDB.ExecuteDataTable(sql);
        }

        public DataTable GetZHOutDetails(string housename, string strBegin, string strEnd)
        {
            string sql = "";
            string childcondition = "";

            sql = "select AccessoryCode,accessoryname,dhfrom ,housename,amount,saleprice,inprice from v_outwarerec ";

            string condition = " where 1=1 and amount>0";

            if (housename != "")
                condition = condition + " and housename ='" + housename + "'" ;

            if (strBegin != "")
                childcondition += string.Format("and acceptdate>='{0}' and acceptdate<='{1}'", strBegin, strEnd);

            condition = condition + " and dhfrom  in (select dhfrom from financeaccounts where  describes='销售装潢' and status=1 " + childcondition + ")";

            sql = sql + condition;
            return mDB.ExecuteDataTable(sql);
        }

        public DataTable GetAccOutRank(string housename, string strBegin, string strEnd,int intype,bool isClaim,bool isRepair)
        {
            string condition = "where 1=1 and amount>0";
            string childcondition = "";
            string sql = "";

            if(housename !="")
            condition = condition + " and housename ='" + housename + "'";

            if (strBegin != "")
                childcondition += string.Format("and acceptdate>='{0}' and acceptdate<='{1}'", strBegin, strEnd);

            if (intype == 1)
            {
                childcondition += ("and cs=0 and len(InvoiceNum)>1");
            }
            else if (intype == 2)
            {
                childcondition += ("and cs>0 and len(InvoiceNum)>1");
            }
            else if (intype == 3)
            {
                childcondition += ("and cs=0 and len(InvoiceNum)<1");

            }
            else if (intype == 4)
            {
                childcondition += ("and cs>0 and len(InvoiceNum)<1");

            }

            string strTmp;
            if(!isRepair)
                strTmp = " describes='售后'";
            else
                strTmp = " describes!='售后'";
            condition = condition + " and dhfrom  in (select dhfrom from financeaccounts where   " + strTmp+ " and status=1 " + childcondition + ")";
            if (isClaim)
            {
                condition = condition + " and repchildtype not like '%索赔%'  ";
            }
 
            sql = string.Format("select  Max(AccessoryCode) as AccessoryCode ,Max(accessoryname) as AccessoryName,Max(housename) as housename,sum(amount) as Amount ,sum(inprice*amount) as inprice,sum(saleprice*amount) as saleprice  from v_outwarerec as a  " + condition + " group by AccessoryCode  ");
            
            //sql += " union all select  '合计' as AccessoryCode,' ' as AccessoryName ,'' as housename ,sum(amount) as Amount ,sum(inprice*amount) as inprice,sum(saleprice*amount) as saleprice from v_outwarerec " + condition + " order by sum(amount) desc";

            sql = "select a.*,b.sumamount from (" + sql + ") as a,v_accstock as b where a.AccessoryCode=b.AccessoryCode";
            
            return mDB.ExecuteDataTable(sql);
        }

        public decimal GetAmountOfAccOutInMonth(int year, int month)
        {
            DateTime begindate = DateTime.Parse(year + "-" + month + "-1");
            DateTime endDate = begindate.AddMonths(1);

            string sql;
            decimal amount=0;
            sql = string.Format("select IsNull(OutJe,0) from accrecord where year={0} and month={1}", year, month);        
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                amount = decimal.Parse(dt.Rows[0][0].ToString());
                if(amount>0)
                return amount;
            }

            sql = string.Format("select isnull(sum(amount*inprice),0) from outwarerec where outdate>='{0}' and outdate<'{1}' and  housename='配件库'", begindate, endDate);

            dt = mDB.ExecuteDataTable(sql);
           
            if (dt.Rows.Count > 0)
            {
              //   if(amount>0)
                amount = decimal.Parse(dt.Rows[0][0].ToString());

            }

            sql = string.Format("select * from accrecord where year={0} and month={1}", year, month);
            if (!mDB.IsExists(sql))
            {
                sql = string.Format("insert accrecord(year,month,OutJe) values({0},{1},{2})", year, month, amount);
                mDB.ExecuteNonQuery(sql);
            }
            else
            {
                sql = string.Format("update accrecord set OutJe={2} where year={0} and month={1}", year, month, amount);
                mDB.ExecuteNonQuery(sql);
            }
            amount = Math.Round(amount, 2);
            return amount;
        }


        public decimal GetAmountOfAccStockInMonth(int year, int month)
        {
            //比如2016年1月
            DateTime begindate = DateTime.Parse(year + "-" + month + "-1");
            DateTime endDate = begindate.AddMonths(1);
            decimal  inamount = 0;
            decimal  outamount = 0;
            decimal amount;
            string sql;

            sql = string.Format("select IsNull(AccJe,0) from accrecord where year={0} and month={1}",year,month);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                amount = decimal.Parse(dt.Rows[0][0].ToString());
                if (amount > 0)
                return amount;
            }
            
            sql = string.Format("select isnull(sum(amount*inprice),0)  from inwarerec where inDate<'{0}' and housename='配件库'", endDate);
            dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                inamount = decimal.Parse(dt.Rows[0][0].ToString());

            }
            sql = string.Format("select isnull(sum(amount*inprice),0) from outwarerec where outDate<'{0}' and housename='配件库'", endDate);
            dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                outamount = decimal.Parse(dt.Rows[0][0].ToString());

            }
            amount = inamount - outamount;

            sql = string.Format("select * from accrecord where year={0} and month={1}",year,month);
            if (!mDB.IsExists(sql))
            {
                sql = string.Format("insert accrecord(year,month,accje) values({0},{1},{2})", year, month, amount);
                mDB.ExecuteNonQuery(sql);
            }
            else
            {
                sql = string.Format("update accrecord set accje={2} where  year={0} and month={1}",year,month,amount);
                mDB.ExecuteNonQuery(sql);
            }

            amount = Math.Round(amount,2);
            return amount;
        }

        public DataTable GetOverStocks(string housename, string strBegin, string strEnd)
        {

            string sql = "select housename,AccessoryCode,AccessoryName,InType,InDate,amount,Inprice,cast(amount*inprice as decimal(18,2)) as je from v_accware ";
            sql += string.Format(" where housename like '%{0}%' and indate<'{1}' and amount>0",housename,strEnd);

            sql += string.Format(" and accessorycode not in (select Max(accessorycode) as accessoycode from repair_a where takedate>'{0}' group by accessorycode)", strBegin);
            return mDB.ExecuteDataTable(sql);
        }


        public void DelAccessory(string AccessoryCode)
        {
            string sql = "delete from Accessory where AccessoryCode='" +AccessoryCode + "'";
            mDB.ExecuteNonQuery(sql);

        }


        public DataTable GetAccessorys()
        {
            string sql = "select accessorycode,accessoryname from Accessory";
            return mDB.ExecuteDataTable(sql);

        }
    }
}
