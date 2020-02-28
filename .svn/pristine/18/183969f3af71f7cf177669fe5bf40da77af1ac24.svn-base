using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comm;
using DBUtil;
using System.Data;
using Model;
namespace Bll.Personnel
{
    public class OperateManBll :IOperateMan
    {

        private DBHelper mDB;
     
        public OperateManBll()
        {
            mDB = DBHelperShare.getInstance();
            
        }


        public bool AddOpreateManByCustom(Staff obj)
        {

            string sql = string.Format("select * from operateman where staffId='{0}'", obj.StaffID);
            IStaff istaff = BllFactory.GetStaffBll();
            
            bool b = mDB.IsExists(sql);
            if (b)
                return false;
            else
            {
                List<SqlElement> list = new List<SqlElement>();
                list.Add(new SqlElement("StaffID", obj.StaffID, true));
                list.Add(new SqlElement("staffname", obj.StaffName, true));
                list.Add(new SqlElement("positionid", obj.PositionID.ToString(), false));
                list.Add(new SqlElement("positionname", obj.PositionName, true));
                list.Add(new SqlElement("departmentid", obj.DepartmentID, true));
                list.Add(new SqlElement("departmentname", obj.DepartmentName, true));
                list.Add(new SqlElement("organid", obj.OrganId, true));
                list.Add(new SqlElement("organname", obj.OrganName, true));
                //  sql = string.Format("insert  into operateman(staffid,staffname,positionid,departmentid,organid)  select staffid,staffname,positionid,departmentid,organid where  staffId='{0}'", staffid);
                sql = CreateSqlUtil.CreateInsertSql(list, "operateman");
                mDB.ExecuteNonQuery(sql);
                return true;

            }



        }

        public bool AddOperateMan(string staffid)
        {
            string sql = string.Format("select * from operateman where staffId='{0}'", staffid);
            IStaff istaff = BllFactory.GetStaffBll();
            Staff obj = istaff.GetStaff(staffid);
            bool b = mDB.IsExists(sql);
            if (b)
                return false;
            else
            {
                List<SqlElement> list = new List<SqlElement>();
                list.Add(new SqlElement("StaffID", obj.StaffID, true));
                list.Add(new SqlElement("staffname", obj.StaffName, true));
                list.Add(new SqlElement("positionid", obj.PositionID.ToString(), false));
                list.Add(new SqlElement("positionname", obj.PositionName, true));
                list.Add(new SqlElement("departmentid", obj.DepartmentID, true));
                list.Add(new SqlElement("departmentname", obj.DepartmentName, true));
                list.Add(new SqlElement("organid", obj.OrganId, true));
                list.Add(new SqlElement("organname", obj.OrganName, true));
                //  sql = string.Format("insert  into operateman(staffid,staffname,positionid,departmentid,organid)  select staffid,staffname,positionid,departmentid,organid where  staffId='{0}'", staffid);
                sql = CreateSqlUtil.CreateInsertSql(list, "operateman");
                mDB.ExecuteNonQuery(sql);
                return true;

            }
          
        }

        public void UpdateOperatePwd(string staffid, string pwd)
        {
            string sql = string.Format("update operateman set pwd ='{0}' where  staffid='{1}'", pwd, staffid);
            mDB.ExecuteNonQuery(sql);

        }
   
        public bool ValidateLogin(string staffid, string pwd)
        {
            string sql = string.Format("select * from operateman where  staffid='{0}' and pwd ='{1}'", staffid, pwd);
            bool b = mDB.IsExists(sql);
            return b;

        }

        public bool ValidateStaffID(string staffid)
        {
            string sql = string.Format("select * from operateman where  staffid='{0}'", staffid);
            bool b = mDB.IsExists(sql);
            return b;


        }

        public void DelOperateMan(string staffid)
        {
            string sql = string.Format("delete from operateman  where staffid='{0}';delete from stafffunction where staffid='{0}'", staffid);
            mDB.ExecuteNonQuery(sql);

        }

        public Staff GetOperateMan(string staffid)
        {
            string sql = string.Format("select * from operateman where staffid='{0}'", staffid);

            DataTable dt = mDB.ExecuteDataTable(sql.ToString());

            Staff obj = new Staff();

            if (dt != null && dt.Rows.Count > 0)
            {
                obj.StaffID = dt.Rows[0]["StaffID"].ToString();
                obj.StaffName = dt.Rows[0]["StaffName"].ToString();
            //    obj.Sex = dt.Rows[0]["Sex"].ToString();
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
        public DataTable GetOperateMans(List<SqlElement> lst)
        {
            string sql;
            sql = "select ID, StaffID,StaffName,OrganName,DepartmentName,PositionName from operateman where 1=1 ";
            if (lst != null && lst.Count > 0)
            {
                string conditoin = CreateSqlUtil.CreateQuerySqlOfCondition(lst, true);
                sql = sql + "and " + conditoin;
                //  sql = sqlhead + sql;
            }


            DataTable dt = mDB.ExecuteDataTable(sql.ToString());
            return dt;


        }


        public void EnableFunction(string staffid,string nodeId)
        {
            string sql = string.Format("delete from stafffunction where staffid='{0}' and nodeid='{1}';  insert stafffunction(staffid,nodeid) values({0},'{1}')", staffid, nodeId);
            mDB.ExecuteNonQuery(sql);
        }

        public void CancelFunction(string staffid,string nodeId)
        {
            string sql = string.Format("delete from stafffunction where staffid='{0}' and nodeid='{1}'", staffid, nodeId);
            mDB.ExecuteNonQuery(sql);
        }


        public List<string> GetFunctionsOfStaff(string  staffid)
        {
            string sql = string.Format("select nodeid from stafffunction where staffid='{0}'", staffid);
            DataTable dt = mDB.ExecuteDataTable(sql);
            List<string> lst = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Add(dt.Rows[i][0].ToString().Trim());

            }
            return lst;
        }

        public void DeleteFunctionsOfStaff(string staffid)
        {
            string sql=string.Format("delete from stafffunction where staffid='{0}'",staffid);
            mDB.ExecuteNonQuery(sql);
    
        }

        public SystemInfo GetSystemInfo()
        {
            string sql = "select * from SystemInfo";
            DataTable dt = mDB.ExecuteDataTable(sql);
            SystemInfo obj = new SystemInfo();
            if (dt.Rows.Count > 0)
            {
                obj.CompanyAddress = dt.Rows[0]["CompanyAddress"].ToString();
                obj.CompanyName = dt.Rows[0]["CompanyName"].ToString();
                obj.TelePhone = dt.Rows[0]["TelePhone"].ToString();
                obj.AdminPwd = dt.Rows[0]["AdminPwd"].ToString();
            }
            return obj;
        }
    }


   
}
