using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Comm;
using Model;
using System.Collections;
using System.Threading;
using System.Runtime.CompilerServices;
using Bll.Personnel;
namespace Bll
{
    public abstract class DataTask
    {
        protected DataTable dtCreate;
        private List<Organ> lstOrgan;
        private DelayThread backrun;
        private bool IsCreateHead = false;
        protected int m_Columns = 0;
        protected string m_handler;
        private List<string> lstFail;

        public delegate void MsgReportDelegate(string strval);
        public event MsgReportDelegate EMsgReport;

        public delegate void CompeleteDelegate(DataTable dtResult, object o);
        public event CompeleteDelegate ECompelete;
        private IOrgan mIOrgan;

        public List<Organ> LstOrgan
        {

            set { lstOrgan = value; }
        }
        protected Hashtable htPara;

        public Hashtable HtPara
        {

            set { htPara = value; }
        }

        public DataTask()
        {
            dtCreate = new DataTable();
            htPara = new Hashtable();
            backrun = new DelayThread();
            lstFail = new List<string>();
            mIOrgan = BllFactory.GetOrganBll();
        }


        protected abstract void CreateTableHead();

        protected abstract void CreateTableItem(object o, string strorgan);

        protected abstract void CaculateAmount();
        protected void UpdateToDataGrid()
        {

            //grid.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate()
            //{
            //    if (dtCreate.Rows.Count > 0)
            //    {
            //        CaculateAmount();

            //        grid.DataSource = dtCreate;
            //        grid.Columns[0].Frozen = true;
            //        grid.Columns[1].Frozen = true;
            //        grid.Columns[2].Frozen = true;
            //    }
            //});
            if (dtCreate.Rows.Count > 0)
            {
                CaculateAmount();

            }


            if (ECompelete != null)
            {
                ECompelete(dtCreate, lstFail);
            }



        }


        public void StartTask()
        {
            //CreateTableHead();
            backrun.DoWork(new ThreadStart(this.Start));
        }
        public void StartTaskMulti()
        {
            //CreateTableHead();
            backrun.DoWork(new ThreadStart(this.StartMulti));
        }

        private List<int> CalOrganRegion()
        {
            List<int> lstResult = new List<int>();
            foreach (Organ o in lstOrgan)
            {
                if (o == null) continue;
                if (!lstResult.Contains(o.Region))
                {
                    lstResult.Add(o.Region);

                }
           

            }
            return lstResult;
        }

        private Thread DoBackRun(ThreadStart thdel)
        {

            Thread th = new Thread(thdel);
            th.Start();
            return th;

        }


        private void StartMulti()
        {
            DateTime tRunBeign = DateTime.Now;
            List<int> lstRegion = CalOrganRegion();
            List<Thread> lstThread = new List<Thread>();
            foreach (int i in lstRegion)
            {
                //List<Organ> lstPartOrgan = lstOrgan.FindAll(delegate(Organ o)
                //{
                //    return o.Region == i;


                //}
                //    );

               List<Organ> lstPartOrgan= lstOrgan.Where(o=>o.Region==i).ToList();
                // backrun.DoWork(delegate { StartWithOrgans(lstPartOrgan); });
               lstThread.Add(DoBackRun(delegate { StartWithOrgans(lstPartOrgan); }));
            }
            //Thread.Sleep(500);
            foreach (Thread t in lstThread)
            {
               
                t.Join();

            }
            UpdateToDataGrid();
            string strConsume = string.Format("耗时：{0}秒", (DateTime.Now - tRunBeign).TotalSeconds);
            if (EMsgReport != null)
                EMsgReport(strConsume);


        }

        private void StartWithOrgans(List<Organ> lstOrgans)
        {


            foreach (Organ o in lstOrgans)
            {
                if (EMsgReport != null)
                    EMsgReport(o.OrganName + "开始读取");

                WebRequestHelper jsonHelp = new WebRequestHelper();
                jsonHelp.Organid = o.OrganId;
                jsonHelp.ETransData += new TransferData(DoJsonStr);
             //   htPara["organ"] = o.OrganId;

                jsonHelp.SynGetData(HtTOString() + "&organ=" + o.OrganId, GetUrl(o));

            }


        }


        private void Start()
        {


            DateTime tRunBeign = DateTime.Now;


            foreach (Organ o in lstOrgan)
            {
                if (EMsgReport != null)
                    EMsgReport(o.OrganName + "开始读取");
                WebRequestHelper jsonHelp = new WebRequestHelper();
                jsonHelp.Organid = o.OrganId;
                jsonHelp.ETransData += new TransferData(DoJsonStr);
                //htPara["organ"] = o.OrganId;
                jsonHelp.SynGetData(HtTOString() + "&organ=" + o.OrganId, GetUrl(o));

            }
            string strConsume = string.Format("耗时：{0}秒", (DateTime.Now - tRunBeign).TotalSeconds);
            if (EMsgReport != null)
                EMsgReport(strConsume);
            UpdateToDataGrid();

        }
        private string GetUrl(Organ o)
        {

            return o.Url + m_handler;
          
           // return "http://172.16.0.7/XC/SLMonth.ashx";
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

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void DoJsonStr(string strval, object sender)
        {

            WebRequestHelper h = (WebRequestHelper)sender;
            if (strval == "")
            {
                lstFail.Add(h.Organid);
                return;
            }
            JsonPageInfo po = null;
            try
            {
                JsonData obj = JsonData.CreateObject(strval);
                po = JsonPageInfo.CreateObject(obj.Data);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                string error = "错误:" + h.Organid +"读取失败";
                if (EMsgReport != null)
                    EMsgReport(error);
                return;
            }

            Object o = CreateDataObjects(po.Data);
            if (IsCreateHead == false)
            {
                CreateTableHead();
                IsCreateHead = true;
            }
            Console.WriteLine("创建" + h.Organid);
            CreateTableItem(o,  mIOrgan.GetOrganName(h.Organid) );

         

        }


        protected abstract object CreateDataObjects(string strval);

        protected string ZeroToNull(object o)
        {
            if (o.ToString() == "0")
                return "";
            else
                return o.ToString();

        }
    }
}