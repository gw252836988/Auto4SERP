using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Collections;
namespace Auto4SErp.GroupReport
{
   public class OrganSelXml
   {
       private XmlDocument m_xd;
       private string m_path;
       public OrganSelXml()
       {
           m_xd = new XmlDocument();
           m_path = System.AppDomain.CurrentDomain.BaseDirectory + "selConf.xml";
           m_xd.Load(m_path);


       }



       public List<string> ReadToList()
       {

           List<string> lstR = new List<string>();
           XmlNodeList nodeList = m_xd.SelectSingleNode("config").ChildNodes;
           //XmlNodeList xlst = m_xd.SelectNodes("/config/selorgan");
          
           foreach (XmlNode xn in nodeList)
           {
               lstR.Add(xn.InnerText);


           }

           return lstR;
       }

       public void WriteByList(List<string> lstAdd)
       {
           XmlNode nodRoot = m_xd.SelectSingleNode("config");
           nodRoot.RemoveAll();


           foreach (string str in lstAdd)
           {

              XmlElement xnew = m_xd.CreateElement("selorgan");
              xnew.InnerText = str;
              nodRoot.AppendChild(xnew); 

           }
        


           m_xd.Save(m_path);
          
       }



   }
}
