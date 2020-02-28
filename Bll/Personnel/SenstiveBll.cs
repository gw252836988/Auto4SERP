using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DBUtil;
using Comm;
using Bll.senstivews;
namespace Bll.Personnel
{
    public class SenstiveBll:ISenstive
    {
        private DBHelper mDB;
        private SenstiveOfService mWS;
         public SenstiveBll()
        {
            mDB = DBHelperShare.getInstance();
            mWS = new SenstiveOfService();
        }
        public List<string> GetSPsOfStaff(string staffid,string formname)
        {

            string sql = string.Format("select spname from spofstaff where StaffId ='{0}' and formname='{1}'", staffid, formname);
            DataTable dt = mDB.ExecuteDataTable(sql);
             List<string> lst = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Add(dt.Rows[i][0].ToString().Trim());

            }
            return lst;
        }


        public void AddSP(string staffid, string formname,string spname)
        {
            string sql = "";
            sql = string.Format("delete from spofstaff where StaffId ='{0}' and formname='{1}' and  spname='{2}';insert into spofstaff(staffid,formname,spname) values('{0}','{1}','{2}')", staffid, formname, spname);
            mDB.ExecuteNonQuery(sql);
        }

        public void DelSP(string staffid, string formname, string spname)
        {
            string sql = "";
            sql = string.Format("delete from spofstaff where StaffId ='{0}' and formname='{1}' and  spname='{2}'", staffid, formname, spname);
            mDB.ExecuteNonQuery(sql);

        }

        public string[] GetPowerList(string formname)
        {
            return mWS.GetPowerList(formname);


        }

        public DataTable GetPowerTexts()
        {
            return  mWS.GetPowerTexts();

        }

    }
}
