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
namespace Bll.Personnel
{
    public class StaffBll : IStaff,IBatchIn
    {
        private DBHelper mDB;


        public StaffBll()
        {
            mDB = DBHelperShare.getPInstance();
        }
        //public DataTable GetStaffs()
        //{
        //    string sql = "select * from staff";
        //    DataTable dt = mDB.ExecuteDataTable(sql);
        //    return dt;
        //}


        //public bool IsExistStaff(string staffid)
        //{
        //    string sql = string.Format("select * from staff where staffId='{0}'", staffid);

        //    bool b = mDB.IsExists(sql);
        //    if (b)
        //        return false;
        //    else
        //        return true;
        //}

        public DataTable GetStaffsByQuery(List<SqlElement> lst,string organid,int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {

           // string sqlhead = "select";
          //  string sqlhead1 = "select top 50 ";


            string IndexField = "ID";
            string AllFields = " Id,StaffID,StaffName,Sex,OrganName,DepartmentName,PositionName,IdentityNumber,Education,Specialty,GraduateSchool,IsMarryed,RegisteredAddress,Mobile,EntryDate";
            string Condition = "v_staff where ";

          
          //  sql="select  Id,StaffID,StaffName,Sex,OrganName,DepartmentName,PositionName,IdentityNumber,Education,Specialty,GraduateSchool,IsMarryed,RegisteredAddress,Mobile,EntryDate from v_staff where 1=1 ";
            if (lst != null && lst.Count > 0)
            {
                string conditoin = CreateSqlUtil.CreateQuerySqlOfCondition(lst, true);
                Condition = Condition  + conditoin;
              //  sql = sqlhead + sql;
            }
            else
                Condition = Condition + "1=1";

            if (organid != "")
                Condition += string.Format(" and  {0}", organid);
           // DataTable dt = mDB.ExecuteDataTable(sql.ToString());
            DataTable dt=mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, "", PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;

        }

        public bool ValidateLogin(string staffid,string pwd)
        {
            string sql = string.Format("select * from staff where  staffid='{0}' and pwd ='{1}'",staffid,pwd);
            bool b = mDB.IsExists(sql);
            return b;

        }


        public Staff GetStaff(string staffid)
        {
            string sql = string.Format("select * from v_staff where staffid='{0}'",staffid);

            DataTable dt = mDB.ExecuteDataTable(sql.ToString());

            Staff obj = new Staff();

            if (dt != null && dt.Rows.Count > 0)
            {
                obj.StaffID = dt.Rows[0]["StaffID"].ToString();
                obj.StaffName = dt.Rows[0]["StaffName"].ToString();
                obj.Sex = dt.Rows[0]["Sex"].ToString();
                obj.PositionID = int.Parse(dt.Rows[0]["PositionID"].ToString());
                obj.PositionName = dt.Rows[0]["PositionName"].ToString();
                obj.DepartmentID = dt.Rows[0]["DepartmentID"].ToString();
                obj.DepartmentName = dt.Rows[0]["DepartmentName"].ToString();
                obj.OrganId = dt.Rows[0]["OrganId"].ToString();
                obj.OrganName = dt.Rows[0]["OrganName"].ToString();
                return obj;
            }
            else
                return null;
             

        }

        public bool AddStaff(Staff obj)

        {
            string sql = CreateSqlUtil.CreateIsExistInsertStringSql("StaffID", "staff", obj.StaffID);
            bool b = mDB.IsExists(sql);
            if (!b)
            {
                List<SqlElement> list = new List<SqlElement>();
                if (!String.IsNullOrEmpty(obj.StaffID))
                {
                    list.Add(new SqlElement("StaffID", obj.StaffID, true));
                }
                if (!String.IsNullOrEmpty(obj.StaffName))
                {
                    list.Add(new SqlElement("StaffName", obj.StaffName, true));
                }
                if (!String.IsNullOrEmpty(obj.PositionID.ToString()))
                {
                    list.Add(new SqlElement("PositionID", obj.PositionID.ToString(), false));
                }
                if (!String.IsNullOrEmpty(obj.DepartmentID))
                {
                    list.Add(new SqlElement("DepartmentID", obj.DepartmentID, true));
                }
                if (!String.IsNullOrEmpty(obj.Education))
                {
                    list.Add(new SqlElement("Education", obj.Education, true));
                }
                if (!String.IsNullOrEmpty(obj.Sex))
                {
                    list.Add(new SqlElement("Sex", obj.Sex, true));
                }
                if (!String.IsNullOrEmpty(obj.Stature.ToString()))
                {
                    list.Add(new SqlElement("Stature", obj.Stature.ToString(), false));
                }
                if (!String.IsNullOrEmpty(obj.NativePlace))
                {
                    list.Add(new SqlElement("NativePlace", obj.NativePlace, true));
                }
                if (!String.IsNullOrEmpty(obj.Nation))
                {
                    list.Add(new SqlElement("Nation", obj.Nation, true));
                }
                if (!String.IsNullOrEmpty(obj.IsMarryed))
                {
                    list.Add(new SqlElement("IsMarryed", obj.IsMarryed, true));
                }
                if (!String.IsNullOrEmpty(obj.GraduateSchool))
                {
                    list.Add(new SqlElement("GraduateSchool", obj.GraduateSchool, true));
                }
                if (!String.IsNullOrEmpty(obj.Specialty))
                {
                    list.Add(new SqlElement("Specialty", obj.Specialty, true));
                }
                if (!String.IsNullOrEmpty(obj.IdentityNumber))
                {
                    list.Add(new SqlElement("IdentityNumber", obj.IdentityNumber, true));
                }
                if (!String.IsNullOrEmpty(obj.RegisteredAddress))
                {
                    list.Add(new SqlElement("RegisteredAddress", obj.RegisteredAddress, true));
                }
                if (!String.IsNullOrEmpty(obj.NowAddress))
                {
                    list.Add(new SqlElement("NowAddress", obj.NowAddress, true));
                }
                if (!String.IsNullOrEmpty(obj.Mobile))
                {
                    list.Add(new SqlElement("Mobile", obj.Mobile, true));
                }
                if (!String.IsNullOrEmpty(obj.Phone))
                {
                    list.Add(new SqlElement("Phone", obj.Phone, true));
                }
                if (!String.IsNullOrEmpty(obj.BirthDate.ToString()))
                {
                    list.Add(new SqlElement("BirthDate", obj.BirthDate.ToString(), true));
                }
                if (!String.IsNullOrEmpty(obj.EntryDate.ToString()))
                {
                    list.Add(new SqlElement("EntryDate", obj.EntryDate.ToString(), true));
                }
                if (!String.IsNullOrEmpty(obj.ContractStartDate.ToString()))
                {
                    list.Add(new SqlElement("ContractStartDate", obj.ContractStartDate.ToString(), true));
                }
                if (!String.IsNullOrEmpty(obj.ContractEndDate.ToString()))
                {
                    list.Add(new SqlElement("ContractEndDate", obj.ContractEndDate.ToString(), true));
                }
                if (!String.IsNullOrEmpty(obj.Email))
                {
                    list.Add(new SqlElement("Email", obj.Email, true));
                }
                if (!String.IsNullOrEmpty(obj.OrganId))
                {
                    list.Add(new SqlElement("OrganId", obj.OrganId, true));
                }

                sql = CreateSqlUtil.CreateInsertSql(list, "staff");
                int k = mDB.ExecuteNonQuery(sql);
                if (k > 0)
                {
                    return true;
                }
            }
            return false;
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

                mDB.BatchInsert("tmp_staff", dt);

                sql = FindRepeatRecord();
                if (sql != "")
                {
                    DelTempRecord();
                    return sql + "记录重复";

                }
                sql = "insert into staff(staffID,[StaffName],[PositionID],[DepartmentID],[Education],[Sex],[Stature],[NativePlace],[Nation],[IsMarryed],[GraduateSchool],[Specialty],[IdentityNumber],[RegisteredAddress],[NowAddress],[Mobile],[Phone],[BirthDate],[EntryDate],[ContractStartDate],[ContractEndDate],[Email],[OrganID])" +
                "  select staffID,[StaffName],[PositionID],[DepartmentID],[Education],[Sex],[Stature],[NativePlace],[Nation],[IsMarryed],[GraduateSchool],[Specialty],[IdentityNumber],[RegisteredAddress],[NowAddress],[Mobile],[Phone],[BirthDate],[EntryDate],[ContractStartDate],[ContractEndDate],[Email],[OrganID] from tmp_staff";
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
            sql = "select staffID from  tmp_staff where staffID in (select staffID from staff)";
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count != 0)
            {
                return dt.Rows[0][0].ToString();

            }
            return "";

        }

        private void DelTempRecord()
        {

            mDB.ExecuteNonQuery("delete from tmp_staff");

        }

       
    }
}
