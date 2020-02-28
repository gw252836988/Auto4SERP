using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Bll
{
    public class SLSumInfo
    {
        private int m_num;

        public int Num
        {
            get { return m_num; }
            set { m_num = value; }
        }
        private double m_je;

        public double Je
        {
            get { return m_je; }
            set { m_je = value; }
        }



        public static List<SLSumInfo> CreateObjects(string strvals)
        {
            List<SLSumInfo> lst = new List<SLSumInfo>();

            JArray ja = (JArray)JsonConvert.DeserializeObject(strvals);

            for (int i = 0; i < ja.Count; i++)
            {
                SLSumInfo info = new SLSumInfo();
                info.Je = Convert.ToDouble(ja[i]["hjje"].ToString());
                info.Num = Convert.ToInt16(ja[i]["num"].ToString());
                
                lst.Add(info);
            }
            return lst;
        }








    }
}
