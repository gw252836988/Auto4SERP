
using System;
using System.Collections.Generic;

using System.Text;


namespace DBUtil
{
   public  class ConnectionStringFactory
    {
        private static ConnectionStringFactory m_instance = new ConnectionStringFactory();

        private ConnectionStringFactory()
        {
            m_listorgan = new List<Organ>();
            m_listorgan.Add(new Organ("111", "测试", "172.16.1.2", "sa", "123456", "", 0));
            //   m_listorgan.Add(new Organ("666", "外网测试", "sql.z88.vhostgo.com", "auto4serp", "gs839ptna0", "", 0));
            //永兴服务器
            m_listorgan.Add(new Organ("055", "永兴装潢", "172.16.16.188", "sa", "dzw171315765", "172.16.16.188", 1));
            m_listorgan.Add(new Organ("101", "永兴别克", "172.16.16.188", "sa", "dzw171315765", "172.16.16.188", 1));
            //   m_listorgan.Add(new Organ("101", "永兴别克", "USER-20141029VC", "sa", "123", "", 0));
            m_listorgan.Add(new Organ("102", "永兴一汽大众", "172.16.16.188", "sa", "dzw171315765", "172.16.16.188", 1));
            // m_listorgan.Add(new Organ("103", "北京汽车", "172.16.16.188", "sa", "mIOrgan", "",0));
            m_listorgan.Add(new Organ("352", "永兴荣威", "172.16.16.188", "sa", "dzw171315765", "172.16.16.188", 1));


            // //观音山服务器


            //  m_listorgan.Add(new Organ("056", "观音山装潢", "172.16.0.7", "sa", "dzw171315765", "172.16.0.7", 2));
            m_listorgan.Add(new Organ("152", "观音山荣威", "172.16.0.7", "sa", "dzw171315765", "172.16.0.7", 2));
            m_listorgan.Add(new Organ("161", "观音山一汽丰田", "172.16.0.7", "sa", "dzw171315765", "172.16.0.7", 2));
            m_listorgan.Add(new Organ("153", "观音山雪佛兰", "172.16.0.7", "sa", "dzw171315765", "172.16.0.7", 2));
            m_listorgan.Add(new Organ("160", "观音山广汽丰田", "172.16.0.7", "sa", "dzw171315765", "172.16.0.7", 2));
            m_listorgan.Add(new Organ("159", "观音山北京现代", "172.16.0.176", "sa", "admin", "172.16.0.7", 2));




            //孩儿巷服务器
            // m_listorgan.Add(new Organ("251", "启东雪佛兰", "172.16.1.6", "sa", "123456", "172.16.1.6:8091",5));
            m_listorgan.Add(new Organ("100", "总部", "172.16.1.6", "sa", "123456", "172.16.1.6:8091", 0));
            //盐城服务器
            m_listorgan.Add(new Organ("301", "盐城别克", "192.168.1.120", "sa", "123456", "172.16.16.188", 5));

            ////海门服务器
            //   m_listorgan.Add(new Organ("057", "海门装潢部", "172.19.18.100", "sa", "123456", "172.19.18.100", 4));
            m_listorgan.Add(new Organ("201", "海门别克", "172.19.18.100", "sa", "123456", "172.19.18.100", 4));
            m_listorgan.Add(new Organ("202", "海门广汽本田", "172.19.18.100", "sa", "123456", "172.19.18.100", 4));
            m_listorgan.Add(new Organ("203", "海门雪佛兰", "172.19.18.100", "sa", "123456", "172.19.18.100", 4));

            //如东服务器
            // m_listorgan.Add(new Organ("058", "如东装潢部", "172.16.11.18", "sa", "sa", "172.16.11.18", 3));
            m_listorgan.Add(new Organ("205", "如东雪佛兰", "172.16.11.18", "sa", "sa", "172.16.11.18", 3));
            m_listorgan.Add(new Organ("208", "如东荣威", "172.16.11.18", "sa", "sa", "172.16.11.18", 3));
            m_listorgan.Add(new Organ("206", "如东广汽本田", "172.19.18.100", "sa", "123456", "172.19.18.100", 3));
            m_listorgan.Add(new Organ("209", "如东名爵", "172.16.11.18", "sa", "sa", "172.16.11.18", 3));



            // 启东服务器
            m_listorgan.Add(new Organ("258", "启东宝马", "172.16.1.6", "sa", "123456", "172.16.1.6:8091", 6));
            m_listorgan.Add(new Organ("608", "江西奔驰", "172.16.1.6", "sa", "123456", "172.16.1.6:8091", 7));
            
            // 
            //var q1 = from s in m_listorgan
            //         where s.OrganId == "101"
            //         select s.ToConnString();
            //Organ o = (from os in m_listorgan
            //           where os.OrganId == "101"
            //           select os).First();
            //本地
      

        }


        
        private List<Organ> m_listorgan;
        public static ConnectionStringFactory getInstance()
        {


            if (m_instance == null)
                m_instance = new ConnectionStringFactory();
            return m_instance;
        }


        //public Organ ReturnOrganByName(string oname)
        //{

        //    Organ result = m_listorgan.Find(delegate(Organ o)
        //    {

        //        return o.OrganId == oname;

        //    });

        //    return result;

        //}
        
        public Organ ReturnOrganById(string oid)
        {
           Organ result= m_listorgan.Find(delegate(Organ o) {

                return o.OrganId == oid;
            
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
                if (o.OrganId.Trim().Equals(oid))
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
            else if (oid == "777")
            {
                strTemp = GenerateOAString();
            }
            return strTemp;
        }

        private string GenerateVipString()
        {

            StringBuilder strTemp = new StringBuilder();
            strTemp.Append("Data Source=192.168.0.102");
            strTemp.Append(";DataBase=Auto4SVip");
            strTemp.Append(";User ID=sa");
            strTemp.Append(";Password=123");
            return strTemp.ToString();

        }


        private string GenerateOAString()
        {

            //StringBuilder strTemp = new StringBuilder();
            //strTemp.Append("Data Source=172.16.1.2");
            //strTemp.Append(";DataBase=Auto4SERP_111");
            //strTemp.Append(";User ID=sa");
            //strTemp.Append(";Password=123456");
            //return strTemp.ToString();
            StringBuilder strTemp = new StringBuilder();
            strTemp.Append("Data Source=192.168.0.170");
            strTemp.Append(";DataBase=#@xcjt2008SQL");
            strTemp.Append(";User ID=sa");
            strTemp.Append(";Password=7788991314258");
            return strTemp.ToString();
        }
         

        private string GeneratePersonnelString()
        {
            //StringBuilder strTemp = new StringBuilder();
            //strTemp.Append("Data Source=172.16.16.188");
            //strTemp.Append(";DataBase=Auto4SPersonnel");
            //strTemp.Append(";User ID=sa");
            //strTemp.Append(";Password=dzw171315765");
            //return strTemp.ToString();

            StringBuilder strTemp = new StringBuilder();
            strTemp.Append("Data Source=172.16.1.2");
            strTemp.Append(";DataBase=Auto4SPersonnel");
            strTemp.Append(";User ID=sa");
            strTemp.Append(";Password=123456");
            return strTemp.ToString();

        }

       

        public List<Organ> GetAllOrgans()
        {

            return m_listorgan;


        }
    }
}
