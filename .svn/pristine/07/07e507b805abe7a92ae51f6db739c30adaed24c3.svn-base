using System;
using System.Collections.Generic;
using System.Text;
using DBUtil;
using Model;
namespace Comm
{
    public class DBHelperShare
    {
        //private static DBHelper m_instance=null;
        private static DBHelper m_pinstance;
        private static DBHelper m_vipinstance;
        private static string m_organid;
        //public static DBHelper getInstance()
        //{
        //    if (m_instance == null)
        //    {
        //     //   LoginInfo li = Comm.LoginInfoShare.getInstance();
        //       // li.OrganId = organid;
        //        m_instance = new DBHelper(li.OrganId);
        //    }
           
        //    return m_instance;
        //}

        public static DBHelper getPInstance()
        {
            if (m_pinstance == null)
                m_pinstance = new DBHelper("000");
            return m_pinstance;
        }

        public static DBHelper getVipInstance()
        {
            if (m_vipinstance == null)
                m_vipinstance = new DBHelper("888");

            return m_vipinstance;
        }

        public static DBHelper getOAInstance()
        {
            if (m_vipinstance == null)
                m_vipinstance = new DBHelper("777");

            return m_vipinstance;
        }

        public static void  SetOrganOfLogin(string id)
        {
            m_organid = id;

        }
    }
}
