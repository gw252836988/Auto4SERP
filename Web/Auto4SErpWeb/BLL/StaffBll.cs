using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DBUtil;
using Model;
using System.Data.SqlClient;
using Comm;
namespace Bll.Personnel
{
    public class StaffBll 
    {
        private DBHelper mDB;

        private DBHelper mOAOfDB;
        public StaffBll()
        {
            mDB = DBHelperShare.getPInstance();
            mOAOfDB = DBHelperShare.getOAInstance();
        }


        public DataTable GetSalersOfOrgan(string organid)
        {
            string sql = "";
            string Condition="";
            if (organid != "")
            {

                //organid = organid.Substring(10,3);
                ConnectionStringFactory cf = ConnectionStringFactory.getInstance();
                Organ o = cf.ReturnOrganById(organid);
                if (o != null)
                {
                    string tmporganname = o.OrganName;
                    if (tmporganname == "总部")
                        tmporganname = "总公司总公司";
                    Condition += string.Format(" and  (brand + typeid)='{0}'", tmporganname.Trim());


                }
            }
            sql = "select Name from dv_user where zhiwu='销售顾问' and (mtype = 1) " + Condition;
            DataTable dt = mOAOfDB.ExecuteDataTable(sql);
            dt.TableName = "a1";
            return dt;

        }
        public DataTable GetStaffByID(string ID)
        {
            string AllFields = " userid as Id,username as StaffID,Name as StaffName,case when UserSex=1 then '男' else '女' end as Sex" +
               ",brand + typeid as OrganName,bm as DepartmentName,zhiwu as PositionName,'' as  IdentityNumber,xueli as Education,'' as Specialty,'' as GraduateSchool,marr as IsMarryed,nowjg as NowAddress,jttel as Mobile,joindate as EntryDate,'' as ContractStartDate,'' as ContractEndDate";
            string sql = "";

            sql = "select " + AllFields + " from dv_user where  username='" + ID +"'";
            DataTable dt = mOAOfDB.ExecuteDataTable(sql);
            dt.TableName = "a1";
            return dt;
        }
        public DataTable GetStaffsByQuery(List<SqlElement> lst,string organid,int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {

           // string sqlhead = "select";
          //  string sqlhead1 = "select top 50 ";


            string IndexField = "userID";
            string AllFields = " userid as Id,username as StaffID,Name as StaffName,case when UserSex=1 then '男' else '女' end as Sex" +
                ",brand + typeid as OrganName,bm as DepartmentName,zhiwu as PositionName,'' as  IdentityNumber,xueli as Education,'' as Specialty,'' as GraduateSchool,marr as IsMarryed,nowjg as NowAddress,jttel as Mobile,joindate as EntryDate,'' as ContractStartDate,'' as ContractEndDate";
            string Condition = "dv_user where ";

           
          //  sql="select  Id,StaffID,StaffName,Sex,OrganName,DepartmentName,PositionName,IdentityNumber,Education,Specialty,GraduateSchool,IsMarryed,RegisteredAddress,Mobile,EntryDate from v_staff where 1=1 ";
            if (lst != null && lst.Count > 0)
            {
                foreach (SqlElement e in lst)
                {
                    if (e.Name == "StaffName")
                        e.Name = "Name";

                    if (e.Name == "StaffId")
                        e.Name = "username";

                }
                string conditoin = CreateSqlUtil.CreateQuerySqlOfCondition(lst, true);
                Condition = Condition + conditoin;
                //  sql = sqlhead + sql;
            }
            else
                Condition = Condition + "1=1";

            Condition += " and (mtype = 1)";

            if (organid != "")
            {
               
                //organid = organid.Substring(10,3);
                ConnectionStringFactory cf = ConnectionStringFactory.getInstance();
                Organ o = cf.ReturnOrganById(organid);
                if (o != null)
                {
                    string tmporganname = o.OrganName;
                    if (tmporganname == "总部")
                        tmporganname = "总公司总公司";
                    Condition += string.Format(" and  (brand + typeid)='{0}'", tmporganname.Trim());


                }

            }
           // DataTable dt = mDB.ExecuteDataTable(sql.ToString());
            DataTable dt = mOAOfDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, "", PageIndex, PageSize, out RecordCount, out PageCount);
            dt.TableName = "a1";
            return dt;

        }

        public bool ValidateLogin(string staffid,string pwd)
        {
            //string sql = string.Format("select * from staff where  staffid='{0}' and pwd ='{1}'", staffid, pwd);
            //bool b = mDB.IsExists(sql);
            //return b;
            string sql = string.Format("select * from dv_user where  username='{0}' and left(userpassword,3) ='{1}'", staffid, pwd);
            bool b = mOAOfDB.IsExists(sql);
            return b;
        }

        public void UpdateStaffPwd(string staffid,string newpwd)
        {
            string sql;
            sql = string.Format("update staff set pwd='{0}' where staffid='{1}'", newpwd, staffid);

            mDB.ExecuteNonQuery(sql);

        }

        public Staff GetStaff(string staffid)
        {

            string sql = string.Format("select username,[name],bm,zhiwu,brand,typeid from dv_user where UserName='{0}'", staffid);

            DataTable dt = mOAOfDB.ExecuteDataTable(sql.ToString());

            Staff obj = new Staff();

            if (dt != null && dt.Rows.Count > 0)
            {
                obj.StaffID = dt.Rows[0]["username"].ToString();
                obj.StaffName = dt.Rows[0]["name"].ToString();
                obj.DepartmentName = dt.Rows[0]["bm"].ToString();
                obj.PositionName = dt.Rows[0]["zhiwu"].ToString();
                obj.OrganName = dt.Rows[0]["brand"].ToString() + dt.Rows[0]["typeid"].ToString();
                return obj;
            }
            else
                return null;





                //string sql = string.Format("select * from v_staff where staffid='{0}'", staffid);

                //DataTable dt = mDB.ExecuteDataTable(sql.ToString());

                //Staff obj = new Staff();

                //if (dt != null && dt.Rows.Count > 0)
                //{
                //    obj.StaffID = dt.Rows[0]["StaffID"].ToString();
                //    obj.StaffName = dt.Rows[0]["StaffName"].ToString();
                //    obj.Sex = dt.Rows[0]["Sex"].ToString();
                //    obj.PositionID = int.Parse(dt.Rows[0]["PositionID"].ToString());
                //    obj.PositionName = dt.Rows[0]["PositionName"].ToString();
                //    obj.DepartmentID = dt.Rows[0]["DepartmentID"].ToString();
                //    obj.DepartmentName = dt.Rows[0]["DepartmentName"].ToString();
                //    obj.OrganId = dt.Rows[0]["OrganId"].ToString();
                //    obj.OrganName = dt.Rows[0]["OrganName"].ToString();

                //    obj.Education = dt.Rows[0]["Education"].ToString();
                //    obj.Stature = int.Parse(dt.Rows[0]["Stature"].ToString());
                //    obj.NativePlace = dt.Rows[0]["NativePlace"].ToString();
                //    obj.Nation = dt.Rows[0]["Nation"].ToString();
                //    obj.IsMarryed = dt.Rows[0]["IsMarryed"].ToString();
                //    obj.GraduateSchool = dt.Rows[0]["GraduateSchool"].ToString();
                //    obj.Specialty = dt.Rows[0]["Specialty"].ToString();
                //    obj.IdentityNumber = dt.Rows[0]["IdentityNumber"].ToString();
                //    obj.RegisteredAddress = dt.Rows[0]["RegisteredAddress"].ToString();
                //    obj.NowAddress = dt.Rows[0]["NowAddress"].ToString();
                //    obj.Mobile = dt.Rows[0]["Mobile"].ToString();
                //    obj.Phone = dt.Rows[0]["Phone"].ToString();
                //    obj.BirthDate = DateTime.Parse(dt.Rows[0]["BirthDate"].ToString());
                //    obj.EntryDate = DateTime.Parse(dt.Rows[0]["EntryDate"].ToString());
                //    obj.ContractStartDate = DateTime.Parse(dt.Rows[0]["ContractStartDate"].ToString());
                //    obj.ContractEndDate = DateTime.Parse(dt.Rows[0]["ContractEndDate"].ToString());
                //    obj.Email = dt.Rows[0]["Email"].ToString();
                //    return obj;
            //}
            //else
            //    return null;
             

        }


        public DataTable GetStaffNameOfOrgan(string organid)
        {
            string sql = string.Format("select StaffName,departmentID  from staff where organid='{0}'",organid);
            DataTable dt = mDB.ExecuteDataTable(sql);
            dt.TableName = "a1";
            return dt;

        }
        public bool AddStaff(Staff obj)

        {
           // string sql = CreateSqlUtil.CreateIsExistInsertStringSql("StaffID", "staff", obj.StaffID);
            string sql = "select staffid from staff where staffid='" + obj.StaffID + "'";
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



        public bool UpdateStaff(Staff obj)
        {
            string sql;
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

            sql = CreateSqlUtil.CreateUpdateSql(list, "staff") + " where StaffID='" + obj.StaffID + "'";
            int k = mDB.ExecuteNonQuery(sql);
            if (k > 0)
            {
                return true;
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


        public void DeleteStaff(string staffid)
        {

            string sql = string.Format("delete from staff where staffid ='{0}'",staffid);
            mDB.ExecuteNonQuery(sql);

        }

        public void AddInfo(string txt)
        {

            string sql = "";
            sql = string.Format("insert into info(Context,postdate) values('{0}',getdate())",txt);
            mDB.ExecuteNonQuery(sql);
        }

        public DataTable GetLatestInfos()
        {
            string sql = "select top 1 context from info order by postdate desc";
            DataTable dt= mDB.ExecuteDataTable(sql);
            dt.TableName = "a1";
            return dt;

        }
        private void DelTempRecord()
        {

            mDB.ExecuteNonQuery("delete from tmp_staff");

        }

       
    }
}
