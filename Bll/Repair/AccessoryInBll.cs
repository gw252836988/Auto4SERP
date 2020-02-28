using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using Bll;
using DBUtil;
using Comm;
using System.Data;
namespace Bll.Repair
{
   public  class AccessoryInBll : Bll.Repair.IAccessoryIn,IBatchIn
    {
        private DBHelper mDB;

        public AccessoryInBll()
        {
            mDB = DBHelperShare.getInstance();
        }

        public string GetDHOfAddAccIn(AccInH obj)
        {
            string sql;
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("DH", "dbo.GetAccInDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", false));
            lst.Add(new SqlElement("CreateDate", "getdate()", false));
            lst.Add(new SqlElement("InType", obj.InType, true));
            lst.Add(new SqlElement("Remark", obj.Remark, true));
            lst.Add(new SqlElement("SupplyUnit", obj.SupplyUnit, true));
            lst.Add(new SqlElement("HouseName", obj.HouseName, true));
            lst.Add(new SqlElement("status", "0", false));
            lst.Add(new SqlElement("OperatorMan", obj.OperatorMan, true));


            sql = CreateSqlUtil.CreateInsertSql(lst, "accessoryinh");

            sql = sql + " SELECT @@IDENTITY AS Id ";
            DataTable dt = mDB.ExecuteDataTable(sql);
            string id = dt.Rows[0][0].ToString();
            sql = "select dh from accessoryinh where id =" + id;
            dt = mDB.ExecuteDataTable(sql);
            string dh = dt.Rows[0][0].ToString();
            return dh; 
        }

        public void UpdateAccIn(AccInH obj)
        {
            string sql;
            List<SqlElement> lst = new List<SqlElement>();
          //  lst.Add(new SqlElement("AccountType", obj.AccountType, true));
            lst.Add(new SqlElement("InType", obj.InType, true));
            lst.Add(new SqlElement("Remark", obj.Remark, true));
            lst.Add(new SqlElement("SupplyUnit", obj.SupplyUnit, true));
            lst.Add(new SqlElement("HouseName", obj.HouseName, true));
            if (obj.Status != -1)
            {
                lst.Add(new SqlElement("status", obj.Status.ToString(), false));

            }
            lst.Add(new SqlElement("Amount", obj.Amount.ToString(), false));
            lst.Add(new SqlElement("GJE", obj.GJE.ToString(), false));
            sql = CreateSqlUtil.CreateUpdateSql(lst, "accessoryinh") + " where dh='" + obj.DH  + "'";
            mDB.ExecuteNonQuery(sql);
        }

        public void AddAccInD(string dh,string itemcode,string inprice,string amount)
        {
            string sql;
            
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("DH",dh , true));
            lst.Add(new SqlElement("AccessoryCode", itemcode, true));
            lst.Add(new SqlElement("Amount", amount, false));
            lst.Add(new SqlElement("XH", "dbo.GetAccessoryDXH('" + dh + "')", false));
            lst.Add(new SqlElement("InPrice",inprice, false));

            sql = CreateSqlUtil.CreateInsertSql(lst, "accessoryind");
            mDB.ExecuteNonQuery(sql);

        }

        public DataTable GetAccInDs(string dh)
        {
            string sql = "select a.XH,a.AccessoryCode,b.AccessoryName,a.Amount,a.InPrice,cast(a.Amount*a.InPrice as decimal(18,4)) as JE from accessoryind  as a inner join accessory as b on a.AccessoryCode=b.AccessoryCode  where a.dh='" + dh + "'";
            return mDB.ExecuteDataTable(sql);

        }
        public void UpdateAccInD(string dh, string xh,string  amount,string InPrice,string accessorycode)
        {
            string sql;

            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("amount", amount, false));
            lst.Add(new SqlElement("InPrice", InPrice, false));
            lst.Add(new SqlElement("accessorycode", accessorycode, true));

            sql = CreateSqlUtil.CreateUpdateSql(lst, "accessoryind") + string.Format(" where dh='{0}' and xh={1}",dh,xh);
            mDB.ExecuteNonQuery(sql);
        }

        public void DelAccInD(string dh, string xh )
        {
            string sql = string.Format("delete from accessoryind where dh='{0}' and xh={1}",dh,xh);
            mDB.ExecuteNonQuery(sql);

        }

        public AccInH GetAccInHByDH(string dh)
        {
            string sql;
            sql = "select * from accessoryinh where dh='" + dh + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt != null && dt.Rows.Count>0)
            {
                AccInH obj = new AccInH();
               
                obj.CreateDate = dt.Rows[0]["CreateDate"].ToString();
                obj.DH = dh;
                obj.HouseName = dt.Rows[0]["HouseName"].ToString();
                obj.InType = dt.Rows[0]["InType"].ToString();
                obj.Remark = dt.Rows[0]["Remark"].ToString();
                obj.Status = int.Parse(dt.Rows[0]["Status"].ToString());
                obj.SupplyUnit = dt.Rows[0]["SupplyUnit"].ToString();
                obj.OperatorMan = dt.Rows[0]["OperatorMan"].ToString();
                return obj;
            }
            return null;
        }

        public DataTable GetAccInHsOfQuery(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            string IndexField = "ID";
            string AllFields = "case when Status=0 then '未入库' else '已入库' end as Status,DH,OperatorMan,CreateDate,InType,SupplyUnit,HouseName,Amount as '数量',GJE as '含税价', cast(GJE/1.13 as decimal(18,4))as '不含税价' ";
            string Condition = "accessoryinh where ";
            string order = "order by CreateDate desc";

            //string sqlHead="select top 100";
            //string sql =  "  case when Status=0 then '未入库' else '已入库' end as Status,DH,CreateDate,InType,SupplyUnit,HouseName  from accessoryinh where ";
           
            if (list != null && list.Count >0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

            if (strBegin != "")
                Condition = Condition + string.Format(" and CreateDate>='{0}' and CreateDate<='{1}'", strBegin, strEnd);

            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, order, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;


        }

        public int DelAccInH(string dh)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@vDH", SqlDbType.Char,15),
				    new SqlParameter("@return",SqlDbType.Int)
					};
            parameters[0].Value = dh;
            parameters[1].Direction = ParameterDirection.ReturnValue;
            mDB.ExecuteNonQueryByPro("DelAccInH", parameters);
            return int.Parse(parameters[1].Value.ToString());

        }


        public string BatchInDB(DataTable dt, string strappend)
        {
            try
            {

                string dh;
                string housename;

                string[] strlst = strappend.Split(',');
                dh = strlst[0];
                housename = strlst[1];
                string sql = "";
                DelTempRecord();
                mDB.BatchInsert("tmp_accessoryind", dt);
                mDB.ExecuteNonQuery("delete from tmp_accessoryind where AccessoryCode is NULL or AccessoryCode=''");
                CheckAccessoryCode(housename);

                //删除所有原先单据下的配件明细
                mDB.ExecuteNonQuery(string.Format("delete from accessoryind where dh='{0}'",dh));
               
                
                sql = string.Format("insert into accessoryind(DH,XH,AccessoryCode,Amount,InPrice) select '{0}',-1,AccessoryCode,Amount,InPrice from tmp_accessoryind where amount>0", dh);
                mDB.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                DelTempRecord();

                return e.Message.ToString();

            }
            return "";


        }

       //需转化存储过程
        private void   CheckAccessoryCode(string housename)
        {
            string sql;
            string acctype = "";

            acctype = housename.Substring(0, 2);

            if (acctype.Contains("装"))
                acctype = "装具";
            sql = "select AccessoryCode,AccessoryName,IsNull(SalePrice,0) as SalePrice from  tmp_accessoryind ";

            DataTable dt = mDB.ExecuteDataTable(sql);
            //string result = "";
            decimal saleprice;
            string acceorycode;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                saleprice =decimal.Parse( dt.Rows[i][2].ToString());
                acceorycode = dt.Rows[i][0].ToString().Trim();


                sql = "select AccessoryCode from accessory where AccessoryCode ='" + acceorycode + "'";
                if (mDB.IsExists(sql))
                {
                    if (saleprice > 0)
                        sql = string.Format("update Accessory set saleprice={0} where AccessoryCode='{1}'", saleprice, acceorycode);

                }
                else
                {
                    if (saleprice == 0)
                        sql = string.Format("insert into accessory(AccessoryCode,AccessoryName,SalePrice,AccessoryType) values ('{0}','{1}',0,'{2}')", acceorycode, dt.Rows[i][1].ToString(),acctype);
                    else
                        sql = string.Format("insert into accessory(AccessoryCode,AccessoryName,SalePrice,AccessoryType) values ('{0}','{1}',{2},'{3}')", acceorycode, dt.Rows[i][1].ToString(), saleprice,acctype);



                }
                mDB.ExecuteNonQuery(sql);

            }
           
        }


    
        private void DelTempRecord()
        {

            mDB.ExecuteNonQuery("delete from tmp_accessoryind");

        }

    }
}
