using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Comm;
using DBUtil;
using System.Data;
namespace Bll.Sale
{
    public class CustVistBll :ICustVist
    {

        private DBHelper mDB;
        public CustVistBll()
        {
            mDB = DBHelperShare.getInstance();
        }
        public void AddCustVist(CustVist obj)
        {

            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("ElseDemand", obj.ElseDemand, true));
            list.Add(new SqlElement("IntentCarBrand", obj.IntentCarBrand, true));
            list.Add(new SqlElement("IntentCarModel", obj.IntentCarModel, true));
            list.Add(new SqlElement("IntentCarSer", obj.IntentCarSer, true));
            list.Add(new SqlElement("IntentColor", obj.IntentColor, true));
            list.Add(new SqlElement("IntentDisplacement", obj.IntentDisplacement, true));
            list.Add(new SqlElement("IntentInnerStyle", obj.IntentInnerStyle, true));
            list.Add(new SqlElement("IntentLevel", obj.IntentLevel, true));
            list.Add(new SqlElement("IntentPrice", obj.IntentPrice.ToString(), false));
            list.Add(new SqlElement("IntentTransmission", obj.IntentTransmission, true));
            list.Add(new SqlElement("Register", obj.Register, true));
            list.Add(new SqlElement("VistReason", obj.VistReason, true));
            list.Add(new SqlElement("VistTime", obj.VistTime.ToString(), true));
            list.Add(new SqlElement("VistWay", obj.VistWay, true));
            list.Add(new SqlElement("Mobile", obj.Mobile, true));
            list.Add(new SqlElement("CustName", obj.CustName, true));
            list.Add(new SqlElement("SalesMan", obj.SalesMan, true));
            string sql = CreateSqlUtil.CreateInsertSql(list, "custvist");
            mDB.ExecuteNonQuery(sql);

        }


        public void UpdateCustVist(CustVist obj)
        {

            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("ElseDemand", obj.ElseDemand, true));
            list.Add(new SqlElement("IntentCarBrand", obj.IntentCarBrand, true));
            list.Add(new SqlElement("IntentCarModel", obj.IntentCarModel, true));
            list.Add(new SqlElement("IntentCarSer", obj.IntentCarSer, true));
            list.Add(new SqlElement("IntentColor", obj.IntentColor, true));
            list.Add(new SqlElement("IntentDisplacement", obj.IntentDisplacement, true));
            list.Add(new SqlElement("IntentInnerStyle", obj.IntentInnerStyle, true));
            list.Add(new SqlElement("IntentLevel", obj.IntentLevel, true));
            list.Add(new SqlElement("IntentPrice", obj.IntentPrice.ToString(), false));
            list.Add(new SqlElement("IntentTransmission", obj.IntentTransmission, true));
            list.Add(new SqlElement("Register", obj.Register, true));
            list.Add(new SqlElement("VistReason", obj.VistReason, true));
            list.Add(new SqlElement("VistTime", obj.VistTime.ToString(), true));
            list.Add(new SqlElement("VistWay", obj.VistWay, true));
            list.Add(new SqlElement("Mobile", obj.Mobile, true));
            list.Add(new SqlElement("CustName", obj.CustName, true));
            list.Add(new SqlElement("SalesMan", obj.SalesMan, true));
            string sql = CreateSqlUtil.CreateUpdateSql(list, "custvist");
            sql += " where id =" + obj.ID;
            mDB.ExecuteNonQuery(sql);

        }

        public CustVist GetCustIn(int id)
        {

            string sql = "select * from custvist where id=" + id;
            DataTable dt = mDB.ExecuteDataTable(sql);
            CustVist obj = new CustVist() ;
            obj.VistWay = dt.Rows[0]["VistWay"].ToString();
            obj.VistReason = dt.Rows[0]["VistReason"].ToString();
            obj.VistTime = DateTime.Parse(dt.Rows[0]["VistTime"].ToString());
            obj.SalesMan = dt.Rows[0]["SalesMan"].ToString();
            obj.Register = dt.Rows[0]["Register"].ToString();
            obj.ElseDemand = dt.Rows[0]["ElseDemand"].ToString();
            obj.IntentCarBrand = dt.Rows[0]["IntentCarBrand"].ToString();
            obj.IntentCarModel = dt.Rows[0]["IntentCarModel"].ToString();
            obj.IntentCarSer = dt.Rows[0]["IntentCarSer"].ToString();
            obj.IntentColor = dt.Rows[0]["IntentColor"].ToString();
            obj.IntentDisplacement = dt.Rows[0]["IntentDisplacement"].ToString();
            obj.IntentInnerStyle = dt.Rows[0]["IntentInnerStyle"].ToString();
            obj.IntentLevel = dt.Rows[0]["IntentLevel"].ToString();
            obj.IntentPrice = decimal.Parse(dt.Rows[0]["IntentPrice"].ToString());
            obj.IntentTransmission = dt.Rows[0]["IntentTransmission"].ToString();
            obj.Mobile = dt.Rows[0]["Mobile"].ToString();
            obj.CustName = dt.Rows[0]["CustName"].ToString();
            
            return obj;
        }

        public DataTable GetCustIns(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {

            string IndexField = "ID";
            string AllFields = "[ID],Mobile,CustName,VistWay,VistReason,VistTime,IntentLevel,SalesMan,Register";
            string Condition = "custvist where ";
            string OrderFields = "order by visttime desc";


            //string sqlhead = "select ";
            //string sqlhead1 = "select top 50 ";
            //string sql = "[ID],Mobile,CustName,VistWay,VistReason,VistTime,SalesMan,Register  from v_custin where ";
            if (list != null && list.Count >0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(list, true);
            else
                Condition = Condition + "1=1";

           

            if (strBegin != "")
            {
                Condition = Condition + string.Format(" and visttime>='{0}' and visttime<='{1}'", strBegin, strEnd);
                        
            }

            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;

        }


       
    }
}
