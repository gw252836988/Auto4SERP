using System;
using System.Collections.Generic;
using System.Text;
using DBUtil;
using Comm;
using System.Data;
namespace Bll.Personnel
{
    public   class OrganBll 
    {
        private DBHelper mDB;
        public OrganBll()
        {
            mDB = DBHelperShare.getPInstance();
            DBHelperShare.getVipInstance();
        }

        public DataTable GetRegions()
        {
            string sql = "select * from region";

            DataTable dt = mDB.ExecuteDataTable(sql);
            dt.TableName = "a";
            return dt;
        }

        public DataTable GetOrgans()
        {
            string sql = "select * from organ";
            DataTable dt = mDB.ExecuteDataTable(sql);
            dt.TableName = "a";
            return dt;

        }

        //public void AssginToConnString()
        //{
        //    DataTable dtOrgans = GetOrgans();
        //    ConnectionStringFactory cf = ConnectionStringFactory.getInstance();
        //    List<Organ> lstOrgan = cf.GetAllOrgans();
        //    if (lstOrgan.Count > 0) return;
        //    lstOrgan.Clear();
        //    for (int i = 0; i < dtOrgans.Rows.Count;i++ )
        //    {
        //        //lstOrgan.Add(new Organ(dtOrgans.Rows[i]["organname"].ToString(), , "永兴别克", "USER-20141029VC", "sa", "123", "", 0));
        //        lstOrgan.Add(new Organ(dtOrgans.Rows[i]["organid"].ToString(), dtOrgans.Rows[i]["organname"].ToString(), dtOrgans.Rows[i]["IP"].ToString(), "sa", dtOrgans.Rows[i]["PassWord"].ToString(), "", 0));

        //    }
  
        //}

    }
}
