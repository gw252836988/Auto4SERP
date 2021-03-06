﻿
using System;
using System.Collections.Generic;

using System.Text;
using Model;
using System.Net;
using System.Net.Sockets;
namespace DBUtil
{
   public  class ConnectionStringFactory
    {
        private static ConnectionStringFactory m_instance = new ConnectionStringFactory();

        private List<Organ> m_listorgan;
        private List<Region> m_listregion;
        private ConnectionStringFactory()
        {
            m_listorgan = new List<Organ>();
            m_listregion = new List<Region>();
            m_listorgan.Add(new Organ("111", "测试", "172.16.1.2", "sa", "123456", "", 0));
            //   m_listorgan.Add(new Organ("666", "外网测试", "sql.z88.vhostgo.com", "auto4serp", "gs839ptna0", "", 0));
            //永兴服务器
          //  m_listorgan.Add(new Organ("055", "永兴装潢", "172.16.16.188", "sa", "dzw171315765", "172.16.16.188", 1));
            m_listorgan.Add(new Organ("101", "永兴别克", "172.16.16.188", "sa", "dzw171315765", "172.16.16.188", 1));

            m_listorgan.Add(new Organ("808", "总装潢部", "172.16.16.188", "sa", "dzw171315765", "172.16.16.188", 0));
            //   m_listorgan.Add(new Organ("101", "永兴别克", "USER-20141029VC", "sa", "123", "", 0));
            m_listorgan.Add(new Organ("102", "永兴一汽大众", "172.16.16.188", "sa", "dzw171315765", "172.16.16.188", 1));
            // m_listorgan.Add(new Organ("103", "北京汽车", "172.16.16.188", "sa", "mIOrgan", "",0));
            m_listorgan.Add(new Organ("352", "永兴荣威", "172.16.16.188", "sa", "dzw171315765", "172.16.16.188", 1));


            // //观音山服务器


            //  m_listorgan.Add(new Organ("056", "观音山装潢", "172.16.0.7", "sa", "dzw171315765", "172.16.0.7", 2));
            m_listorgan.Add(new Organ("152", "先锋荣威", "172.16.2.176", "sa", "dzw171315765", "172.16.2.176", 2));
            m_listorgan.Add(new Organ("161", "先锋一汽丰田", "172.16.2.176", "sa", "dzw171315765", "172.16.2.176", 2));
            m_listorgan.Add(new Organ("153", "先锋雪佛兰", "172.16.2.176", "sa", "dzw171315765", "172.16.2.176", 2));
            m_listorgan.Add(new Organ("160", "先锋广汽丰田", "172.16.2.176", "sa", "dzw171315765", "172.16.2.176", 2));
            m_listorgan.Add(new Organ("159", "先锋北京现代", "172.16.2.176", "sa", "dzw171315765", "172.16.2.176", 2));




            //孩儿巷服务器
            // m_listorgan.Add(new Organ("251", "启东雪佛兰", "172.16.1.6", "sa", "123456", "172.16.1.6:8091",5));
            m_listorgan.Add(new Organ("100", "总公司", "172.16.1.6", "sa", "123456", "172.16.1.6:8091", 0));
            //盐城服务器
            m_listorgan.Add(new Organ("301", "盐城别克", "192.168.1.120", "sa", "123456", "172.16.16.188", 5));




            ////海门服务器
            //   m_listorgan.Add(new Organ("057", "海门装潢部", "172.19.18.100", "sa", "123456", "172.19.18.100", 4));
            m_listorgan.Add(new Organ("201", "海门别克", "172.19.18.100", "sa", "123456", "172.19.18.100", 4));
            m_listorgan.Add(new Organ("202", "海门广汽本田", "172.19.18.100", "sa", "123456", "172.19.18.100", 4));
         //   m_listorgan.Add(new Organ("203", "海门雪佛兰", "172.19.18.100", "sa", "123456", "172.16.1.6:8091", 4));

            //如东服务器
            // m_listorgan.Add(new Organ("058", "如东装潢部", "172.16.11.18", "sa", "sa", "172.16.11.18", 3));
            m_listorgan.Add(new Organ("205", "如东雪佛兰", "172.16.11.183", "sa", "sa", "172.16.1.6:8091", 3));
            m_listorgan.Add(new Organ("208", "如东荣威", "172.16.11.183", "sa", "sa", "172.16.1.6:8091", 3));
            m_listorgan.Add(new Organ("206", "如东广汽本田", "172.19.18.100", "sa", "123456", "172.19.18.100", 3));
            m_listorgan.Add(new Organ("209", "如东名爵", "172.16.11.183", "sa", "sa", "172.16.1.6:8091", 3));
            m_listorgan.Add(new Organ("210", "如东别克", "172.16.11.183", "sa", "sa", "172.16.1.6:8091", 3));



            // 启东服务器
            m_listorgan.Add(new Organ("258", "启东宝马", "172.16.1.6", "sa", "123456", "172.16.1.6:8091", 6));

            m_listorgan.Add(new Organ("207", "海安荣威", "172.16.1.6", "sa", "123456", "172.16.1.6:8091", 6));
            // 
            // 启东服务器
            m_listorgan.Add(new Organ("608", "江西奔驰", "172.16.1.6", "sa", "123456", "172.16.1.6:8091", 7));

          
            //var q1 = from s in m_listorgan
            //         where s.OrganId == "101"
            //         select s.ToConnString();
            //Organ o = (from os in m_listorgan
            //           where os.OrganId == "101"
            //           select os).First();
            //本地
           m_listregion.Add(new Region(0, "集团"));
           m_listregion.Add(new Region(1, "永兴"));
           m_listregion.Add(new Region(2, "先锋"));
           m_listregion.Add(new Region(3, "如东"));
           m_listregion.Add(new Region(4, "海门"));
           m_listregion.Add(new Region(5, "盐城"));
           m_listregion.Add(new Region(6, "启东"));
           m_listregion.Add(new Region(7, "江西"));

        }


        public List<Region> ReturnListRegion()
        {
            return m_listregion;

        }

        public static ConnectionStringFactory getInstance()
        {
           


            return m_instance;
        }


        public Organ ReturnOrganById(string oid)
        {
           Organ result= m_listorgan.Find(delegate(Organ o) {

                return o.OrganId.Trim() == oid;
            
            });

            return result;
        }

        public Organ ReturnOrganByName(string name)
        {
            Organ result = m_listorgan.Find(delegate(Organ o)
            {

                return o.OrganName.Trim() == name;

            });

            return result;
        }


        public string ReturnConnString(string oid)
        {
            string strTemp;
            //Organ o = (from os in m_listorgan
            //           where os.OrganName==oname
            //           select os).First();
            Organ organs = null;
            foreach (Organ o in m_listorgan)
            {
                if (o.OrganId.Trim().Equals(oid.Trim()))
                {
                    organs = o;
                }

            }



            if (organs != null)
                strTemp = organs.ToConnString();
            else
                strTemp = "";

            if (oid == "000")
            {
                strTemp = GeneratePersonnelString();

            }
            else if (oid == "888")
            {
                strTemp=GenerateVipString();
            }
            else if (oid == "168")
            {
                strTemp = SourceString();
            }
            else if (oid == "1000")
            {
                strTemp = MySqlString();
            }
            else if (oid == "666")
            {
                strTemp = WetDataString();
            }
            else if (oid == "777")
            {
                strTemp = GenerateOAString();
            }
            return strTemp;
        }


        private string MySqlString()
        {

            return "server=121.40.120.168;user id=root; password=Weiqi123; database=weiqidb; pooling=false";

        }

        private string WetDataString()
        {
            StringBuilder strTemp = new StringBuilder();
            strTemp.Append("Data Source=sql.z88.vhostgo.com");
            strTemp.Append(";DataBase=auto4serp");
            strTemp.Append(";User ID=auto4serp");
            strTemp.Append(";Password=gs839ptna0");
            return strTemp.ToString();


        }
        private string GenerateVipString()
        {

            StringBuilder strTemp = new StringBuilder();
            strTemp.Append("Data Source=172.16.1.6");
            strTemp.Append(";DataBase=XCAutoMember");
            strTemp.Append(";User ID=sa");
            strTemp.Append(";Password=123456");
            return strTemp.ToString();

        }


        private string GenerateOAString()
        {

            StringBuilder strTemp = new StringBuilder();
            strTemp.Append("Data Source=172.16.1.2");
            strTemp.Append(";DataBase=Auto4SPersonnel");
            strTemp.Append(";User ID=sa");
            strTemp.Append(";Password=123456");
            return strTemp.ToString();

        }
        private string GenerateP2PString()
        {
            StringBuilder strTemp = new StringBuilder();
            strTemp.Append("Data Source=172.16.1.6");
            strTemp.Append(";DataBase=XCAutoMember");
            strTemp.Append(";User ID=sa");
            strTemp.Append(";Password=123456");
            return strTemp.ToString();

        }

        public bool IsVipConnect()
        {
            return Ping("172.16.1.6");
        }

        public bool IsPersonConnect()
        {
            return isSetPort(8082, "221.130.108.114");
        }

        private bool isSetPort(int portNum,string ip)
        {
            string ipAddress = ip; ;
            System.Net.IPAddress myIpAddress = IPAddress.Parse(ipAddress);
            IPEndPoint point = new IPEndPoint(myIpAddress, portNum);

            try
            {
                using (Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    sock.Connect(point);
                    return true;
                }
            }
            catch (SocketException ex)
            {
                Console.Write(ex.Message.ToString());
                return false;
            }
        }

        private  bool Ping(string ip)
        {
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingOptions options = new System.Net.NetworkInformation.PingOptions();
            options.DontFragment = true;
            string data = "Test Data!";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 1000; // Timeout 时间，单位：毫秒
            System.Net.NetworkInformation.PingReply reply = p.Send(ip, timeout, buffer, options);
            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                return true;
            else
                return false;
        }


        private string GeneratePersonnelString()
        {
            StringBuilder strTemp = new StringBuilder();
            strTemp.Append("Data Source=172.16.1.2");
            strTemp.Append(";DataBase=Auto4SPersonnel");
            strTemp.Append(";User ID=sa");
            strTemp.Append(";Password=123456");
            return strTemp.ToString();

        }


        private string SourceString()
        {


            //StringBuilder strTemp = new StringBuilder();
            //strTemp.Append("Data Source=172.16.16.188");
            //strTemp.Append(";DataBase=DzwAutoXC3_101");
            //strTemp.Append(";User ID=sa");
            //strTemp.Append(";Password=dzw171315765");
            //return strTemp.ToString();

            //StringBuilder strTemp = new StringBuilder();
            //strTemp.Append("Data Source=172.16.11.18");
            //strTemp.Append(";DataBase=DzwAutoXC3_205");
            //strTemp.Append(";User ID=sa");
            //strTemp.Append(";Password=sa");
            //return strTemp.ToString();


            StringBuilder strTemp = new StringBuilder();
            strTemp.Append("Data Source=172.16.0.7");
            strTemp.Append(";DataBase=DzwAutoXC3_153");
            strTemp.Append(";User ID=sa");
            strTemp.Append(";Password=dzw171315765");
            return strTemp.ToString();

            //StringBuilder strTemp = new StringBuilder();
            //strTemp.Append("Data Source=172.16.0.176");
            //strTemp.Append(";DataBase=DzwAutoXC3_159");
            //strTemp.Append(";User ID=sa");
            //strTemp.Append(";Password=admin");
            //return strTemp.ToString();



            //StringBuilder strTemp = new StringBuilder();
            //strTemp.Append("Data Source=192.168.1.120");
            //strTemp.Append(";DataBase=DzwAutoXC3_301");
            //strTemp.Append(";User ID=sa");
            //strTemp.Append(";Password=123456");
            //return strTemp.ToString();


            //StringBuilder strTemp = new StringBuilder();
            //strTemp.Append("Data Source=172.19.18.100");
            //strTemp.Append(";DataBase=DzwAutoXC3_202");
            //strTemp.Append(";User ID=sa");
            //strTemp.Append(";Password=123456");
            //return strTemp.ToString();

            //StringBuilder strTemp = new StringBuilder();
            //strTemp.Append("Data Source=58.221.91.234");
            //strTemp.Append(";DataBase=qzt_soft");
            //strTemp.Append(";User ID=sa");
            //strTemp.Append(";Password=Qzt2011");
            //return strTemp.ToString();

        }


        //private string GeneratePersonnelString()
        //{
        //    //StringBuilder strTemp = new StringBuilder();
        //    //strTemp.Append("Data Source=172.16.16.188");
        //    //strTemp.Append(";DataBase=Auto4SPersonnel");
        //    //strTemp.Append(";User ID=sa");
        //    //strTemp.Append(";Password=dzw171315765");
        //    //return strTemp.ToString();

        //    StringBuilder strTemp = new StringBuilder();
        //    strTemp.Append("Data Source=172.16.1.2");
        //    strTemp.Append(";DataBase=Auto4SPersonnel");
        //    strTemp.Append(";User ID=sa");
        //    strTemp.Append(";Password=123456");
        //    return strTemp.ToString();

        //}

       

        public List<Organ> GetAllOrgans()
        {

            return m_listorgan;


        }
    }
}
