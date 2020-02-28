using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Bll
{
    public class JsonData
    {
        private int m_status;

        public int Status
        {
            get { return m_status; }
            set { m_status = value; }
        }
        private string m_msg;

        public string Msg
        {
            get { return m_msg; }
            set { m_msg = value; }
        }
        private string m_data;

        public string Data
        {
            get { return m_data; }
            set { m_data = value; }
        }

        public static JsonData CreateObject(string strjson)
        {
            JsonData o = new JsonData();
            try
            {
                JObject jo = JObject.Parse(strjson);
                string str = jo["status"].ToString(); 
                o.Msg = jo["msg"].ToString();
                o.Status =Convert.ToInt16(jo["status"].ToString());
               
                o.Data = jo["data"].ToString();

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
