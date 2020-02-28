using System;
using System.Collections.Generic;

using System.Text;


namespace DBUtil
{
    public class Organ
    {

        public Organ(string oid,string oname,string sip,string dname,string dpwd,string webrul,int region)
        {
            organId = oid;
            organName = oname;
            serverIp = sip;
            dbUserName = dname;
            dbPwd = dpwd;
            url = webrul;
            m_region = region;

        }


        private string organId;

        public string OrganId
        {
            get { return organId; }
            set { organId = value; }
        }
        private string organName;

        public string OrganName
        {
            get { return organName; }
            set { organName = value; }
        }
        private string serverIp;

        public string ServerIp
        {
            get { return serverIp; }
            set { serverIp = value; }
        }
        private string dbUserName;

        public string DbUserName
        {
            get { return dbUserName; }
            set { dbUserName = value; }
        }
        private string dbPwd;

        public string DbPwd
        {
            get { return dbPwd; }
            set { dbPwd = value; }
        }

        private string url;

        public string Url
        {
            get {
                string strcom = "";

                if (url == "") strcom = "http://" + serverIp + "/xc/";
                else strcom = "http://" + url +"/xc/";

                return strcom;
            
            
            }
            set { 
                url = value;        
            }
        }

        private int m_region;

        public int Region
        {
            get { return m_region; }
            set { m_region = value; }
        } 


        public string ToConnString()
        {
            StringBuilder strTemp = new StringBuilder();
            strTemp.Append("Data Source=" + serverIp);
            strTemp.Append(";DataBase=" + "Auto4SErp_" + organId);
            strTemp.Append(";User ID=" + dbUserName);
            strTemp.Append(";Password=" + dbPwd);
            return strTemp.ToString();
        }

    }
}
