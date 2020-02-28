using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtil;
using Model;
namespace Comm
{
    public class DBHelperShare
    {
        private static DBHelper m_instance=null;
        private static DBHelper m_pinstance;
        private static DBHelper m_vipinstance;
        private static MSDBHelper m_p2pinstance;
   
        private static string m_organid;
        public static DBHelper getInstance()
        {
            if (m_instance == null)
            {
                LoginInfo li = Comm.LoginInfoShare.getInstance();
               // li.OrganId = organid;
                m_instance = new DBHelper(li.OrganId);
            }
           
            return m_instance;
        }


        public static void SetNewOrgan(string neworganid)
        { 
            LoginInfo li = Comm.LoginInfoShare.getInstance();
            if(m_instance==null || li.OrganId.Trim()!=neworganid.Trim())
            {   
                li.OrganId = neworganid;
                m_instance = new DBHelper(neworganid);
            }
            

        }

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


  
        public static MSDBHelper getP2PInstance()
        {
            if (m_p2pinstance == null)
                m_p2pinstance = new MSDBHelper("1000");

            return m_p2pinstance;

        }



        public static void  SetOrganOfLogin(string id)
        {
            m_organid = id;

        }
    }
}
