using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Bll
{
    public class JsonPageInfo
    {
        private int m_totalnum;

        public int Totalnum
        {
            get { return m_totalnum; }
            set { m_totalnum = value; }
        }
        private int m_totalpage;

        public int Totalpage
        {
            get { return m_totalpage; }
            set { m_totalpage = value; }
        }
        private int m_currentpage;

        public int Currentpage
        {
            get { return m_currentpage; }
            set { m_currentpage = value; }
        }

        private string m_data;

        public string Data
        {
            get { return m_data; }
            set { m_data = value; }
        }



        public static JsonPageInfo CreateObject(string strjson)
        {
            JsonPageInfo o = new JsonPageInfo();
            try
            {
                JObject jo = JObject.Parse(strjson);
                o.Totalnum = Convert.ToInt16(jo["totalnum"].ToString());
                o.Totalpage = Convert.ToInt16(jo["totalpage"].ToString());
                o.Currentpage = Convert.ToInt16(jo["currentpage"].ToString());
                o.Data = jo["info"].ToString();
              

            }
            catch (JsonReaderException ex)
            {
                Console.Write(ex.Message.ToString());
                return null;
            }
            return o;



        }
    }
}
