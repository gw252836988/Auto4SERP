using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Data;
using Comm;
namespace Bll
{
    public abstract  class WebTask
    {

        private DelayThread backrun;
        //public delegate void MsgReportDelegate(string strval);
        //public event MsgReportDelegate EMsgReport;

        public delegate void CompeleteDelegate(object o);
        public event CompeleteDelegate ECompelete;
        protected Hashtable htPara;

        public Hashtable HtPara
        {

            set { htPara = value; }
        }


        public WebTask()
        {
            backrun = new DelayThread();
            htPara = new Hashtable();
        }

        public void StartTaskMulti()
        {
            //CreateTableHead();
            backrun.DoWork(new ThreadStart(this.StartMulti));
        }

        private void StartMulti()
        {

        }

        public void StartTaskSingle()
        {
            backrun.DoWork(new ThreadStart(this.StartSingle));
          
        }


        private void StartSingle()
        {
            WebRequestHelper jsonHelp = new WebRequestHelper();
            jsonHelp.ETransData += new TransferData(DoJsonStr);
          
            //访问Url
            jsonHelp.SynGetData(HtTOString(), GetUrl());
        }

        private string HtTOString()
        {
            string result = "";
            string tmp;


            foreach (DictionaryEntry de in htPara) //ht为一个Hashtable实例
            {
                tmp = de.Key.ToString() + "=" + de.Value.ToString();
                result += tmp + "&";
            }
            result = result.Remove(result.Length - 1, 1);
            return result;
        }


        protected virtual string GetUrl()
        {

            return "https://www.weiqimoney.com/nozzle/api4.dql?paypassword=123456&mobile=1340429797";

            // return "http://localhost:17302/FIIntegrate.ashx";
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        private void DoJsonStr(string strval, object sender)
        {

            SpecificDeal(strval);
        }

        protected abstract void SpecificDeal(string strjson);

        protected void DoCompelete(object result)
        {
            if (ECompelete != null)
                ECompelete(result);

        }
       
    }
}
