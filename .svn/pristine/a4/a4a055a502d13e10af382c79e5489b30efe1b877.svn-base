using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading;
using DBUtil;

namespace Comm
{
    public delegate void TransferData(string strvalue, object sender);
    public class WebRequestHelper
    {

        private DelayThread backrun;
        public event TransferData ETransData;


        private string m_organid;

        public string Organid
        {
            get { return m_organid; }
            set { m_organid = value; }
        }

         public WebRequestHelper()
       {
           backrun = new DelayThread();

       }

         private void GetData(object s)
         {
             string[] args = s as string[];
             string RequestPara = args[0];
             string Url = args[1];
             RequestPara = RequestPara.IndexOf('?') > -1 ? (RequestPara) : ("?" + RequestPara);

             string allurl = Url + RequestPara;
             WebRequest hr = HttpWebRequest.Create(allurl);

             Console.WriteLine(allurl + "执行");
           //  byte[] buf = System.Text.Encoding.GetEncoding("utf-8").GetBytes(RequestPara);
            // hr.Method = "GET";
            // hr.ContentType ="text/xml";

             hr.ContentType = "text/html";
             string ReturnVal;
            
             HttpWebResponse res=null;
             try
             {
                 res = (HttpWebResponse)hr.GetResponse();
             }
             catch (WebException ex)
             {
                 res = (HttpWebResponse)ex.Response;
             }

             try
             {

                 StreamReader reader = new StreamReader(res.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                 ReturnVal = reader.ReadToEnd();
                 reader.Close();
                 res.Close();

             }
             catch (Exception ex)
             {
               
                 Console.Write(ex.Message.ToString());
                 ReturnVal = "";
             }

             if (ETransData != null)
             {

                 ETransData(ReturnVal, this);
             }
         }


         public void AsyGetData(string RequestPara, string Url)
         {

             backrun.DoWorkWithPara(new ParameterizedThreadStart(GetData), new string[] { RequestPara, Url });


         }


         public void SynGetData(string RequestPara, string Url)
         {
             GetData(new string[] { RequestPara, Url });

         }
    }
}
