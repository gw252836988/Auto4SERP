using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace Comm
{
    public class XmlConfig
    {
        private XmlDocument mXD;
        public  XmlConfig()
        {
            mXD = new XmlDocument();
            mXD.Load(System.AppDomain.CurrentDomain.BaseDirectory + "config.xml");
        }

        public string GetConfigValue(string name)
        {

            XmlNode xn = mXD.SelectSingleNode("/config/" + name);

            return xn.InnerText;
        }

        public void SetConfigValue(string name,string value)
        {


            XmlNode xn = mXD.SelectSingleNode("/config/" + name);
            xn.InnerText = value;
            mXD.Save(System.AppDomain.CurrentDomain.BaseDirectory + "config.xml");
        }


    }
}
