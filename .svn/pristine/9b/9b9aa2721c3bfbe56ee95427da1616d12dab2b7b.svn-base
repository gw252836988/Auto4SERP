using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bll;
using Model;
using Newtonsoft.Json;
using System.Data;
using Comm;

namespace Bll.P2P
{
    public class P2PGetUserInfoTask:WebTask 
    {

        private string urlpage = "http://www.weiqimoney.com/nozzle/api1.dql";
     
        protected override string GetUrl()
        {
            return urlpage;
        }

        protected override void SpecificDeal(string strjson)
        {
            if (!string.IsNullOrEmpty(strjson))
            {
                string str = strjson.Substring(5, strjson.Length - 6);
                P2PMsg msg;
                try
                {
                     msg= JsonConvert.DeserializeObject<P2PMsg>(str);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    msg = null;


                }
                if (msg != null)
                {
                    if (msg.State == "1")
                    {
                        // oper = msg.Oper;
                        P2PUserInfo info = msg.List[0];
                        info.OperateCode = msg.Oper;
                        DoCompelete(info);
                    }
                }
            }
       
        }





    }

    public class P2PPostCostTask : WebTask
    {
        private string urlpage = "http://www.weiqimoney.com/nozzle/api2.dql";


        protected override string GetUrl()
        {
            return urlpage;
        }

        protected override void SpecificDeal(string strjson)
        {
            if (!string.IsNullOrEmpty(strjson))
            {
                string str;
                str = strjson.Substring(5, strjson.Length - 6);
                DataTable dt = JsonUtil.JsonToDataTable("[" + str + "]");
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr["state"].ToString().Trim() == "1")
                    {

                        // MessageBox.Show(dr["rst"].ToString());
                        DoCompelete(dr["rst"].ToString());

                    }
                    else
                    {
                        // MessageBox.Show("提交信息失败");
                        DoCompelete("提交信息失败");
                    }
                }


            }

        }

    }

    public class P2PDeductCostTask : WebTask
    {
        private string urlpage = "http://www.weiqimoney.com/nozzle/api3.dql";
        //private string vistPage;

        //public string VistPage
        //{
        //    get { return vistPage; }
        //    set { vistPage = value; }
        //}

        protected override string GetUrl()
        {
            return urlpage;
        }

        protected override void SpecificDeal(string strjson)
        {
            if (!string.IsNullOrEmpty(strjson))
            {
                string str = strjson.Substring(5, strjson.Length - 6);

                DataTable dt = JsonUtil.JsonToDataTable("[" + str + "]");
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr["state"].ToString().Trim() == "1")
                    {

                      //  MessageBox.Show(dr["rst"].ToString());
                        DoCompelete(dr["rst"].ToString());

                    }
                    else
                    {
                        //MessageBox.Show("提交信息失败");
                        DoCompelete("提交信息失败");
                    }
                }


            }

        }


    }

    public class P2PGetUserInfoTask2 : WebTask
    {

        private string urlpage = "http://www.weiqimoney.com/nozzle/api4.dql";

        protected override string GetUrl()
        {
            return urlpage;
        }
        protected override void SpecificDeal(string strjson)
        {
            if (!string.IsNullOrEmpty(strjson))
            {
                DataTable dt = JsonUtil.JsonToDataTable("[" + strjson + "]");
                if (dt.Rows.Count > 0)
                {
                    DoCompelete(dt);
                }
                

            }

        }




    }

    public class P2PPostCostTask2 : WebTask
    {
        private string urlpage = "http://www.weiqimoney.com/nozzle/api5.dql";


        protected override string GetUrl()
        {
            return urlpage;
        }
        protected override void SpecificDeal(string strjson)
        {
            if (!string.IsNullOrEmpty(strjson))
            {
                DataTable dt = JsonUtil.JsonToDataTable("[" + strjson + "]");

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr["state"].ToString().Trim() == "1")
                    {
                        DoCompelete(dr["rst"].ToString());
                    }
                    else
                    {
                        DoCompelete("提交信息失败");
                    }
                }
            }
        }


    }

    public class P2PDeductCostTask2 : WebTask
    {
        private string urlpage = "http://www.weiqimoney.com/nozzle/api6.dql";
        protected override string GetUrl()
        {
            return urlpage;
        }

        protected override void SpecificDeal(string strjson)
        {
            if (!string.IsNullOrEmpty(strjson))
            {
                DataTable dt = JsonUtil.JsonToDataTable("[" + strjson + "]");
                 if (dt.Rows.Count > 0)
                 {
                     DataRow dr = dt.Rows[0];
                     if (dr["state"].ToString().Trim() == "1")
                     {

                         //MessageBox.Show(dr["rst"].ToString());
                         DoCompelete(dr["rst"].ToString());

                     }
                     else
                     {
                         //MessageBox.Show("扣费失败");
                         DoCompelete("扣费失败");
                     }
                 }
            }

        }
    }
}
