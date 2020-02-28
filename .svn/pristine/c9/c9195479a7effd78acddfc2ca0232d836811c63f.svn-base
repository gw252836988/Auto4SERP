using System;
using System.Collections.Generic;
using System.Text;
using Comm;
using DBUtil;
using Model;
using System.Data;
namespace  Bll.Personnel
{
    public class SenstiveBll
    {
        private DBHelper mDB;

        public SenstiveBll()
        {
            mDB = DBHelperShare.getPInstance();
        }

        public string[] GetPowerList(string formname)
        {
            string sql = "select powerlist from senstivepower where formname =  '" + formname + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                string strtmp = dt.Rows[0][0].ToString();
                string[] strlst = strtmp.Split(',');
                return strlst;

            }
            return null;
        }

        public DataTable GetPowerTexts()
        {
            string sql = "select PowerName,PowerText from sptable ";
            DataTable dt = mDB.ExecuteDataTable(sql);
            dt.TableName = "a";
            return dt;

        }
    }
}
