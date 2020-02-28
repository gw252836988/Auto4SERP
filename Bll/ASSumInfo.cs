using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Bll
{
    public class ASSumInfo
    {
        private int m_jsnum;//结算总数

        public int JsNum
        {
            get { return m_jsnum; }
            set { m_jsnum = value; }
        }
        private double m_zje;

        public double Zje
        {
            get { return m_zje; }
            set { m_zje = value; }
        }
        private double m_hjje;

        public double Hjje
        {
            get { return m_hjje; }
            set { m_hjje = value; }
        }

        public static List<ASSumInfo> CreateObjects(string strvals)
        {
            List<ASSumInfo> lst = new List<ASSumInfo>();

            JArray ja = (JArray)JsonConvert.DeserializeObject(strvals);

            for (int i = 0; i < ja.Count; i++)
            {
                ASSumInfo info = new ASSumInfo();
                info.Hjje = Convert.ToDouble(ja[i]["hjje"].ToString());
                info.JsNum = Convert.ToInt16(ja[i]["num"].ToString());
                info.Zje = Convert.ToDouble(ja[i]["zje"].ToString());
                lst.Add(info);
            }
             return lst;
        }


    }
}
