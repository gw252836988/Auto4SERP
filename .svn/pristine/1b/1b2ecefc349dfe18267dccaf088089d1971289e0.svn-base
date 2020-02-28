using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Comm
{
    public class LoginInfoShare
    {
        private static LoginInfo m_instance = null;
        public static LoginInfo getInstance()
        {
            if (m_instance == null)
            {
                m_instance = new LoginInfo();

                m_instance.OrganId = "101";
                m_instance.UserName = "admin";
                m_instance.UserId = "admin";
                m_instance.OrganName = "永兴别克";
            }
            return m_instance;
        }


    }
}
