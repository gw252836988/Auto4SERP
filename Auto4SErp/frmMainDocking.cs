﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Diagnostics;

using Bll;
using Model;
using Comm;
using Auto4SErp.Personnel;
using Auto4SErp.Repair;
using Auto4SErp.Report;
using Bll.Personnel;
using Auto4SErp.Sale;
using Auto4SErp.GroupReport;
using OutLookBarDemo;
using Auto4SErp.Finance;
using Auto4SErp.Cust;
using Newtonsoft.Json;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic.PowerPacks;
namespace Auto4SErp
{


    public partial class frmMainDocking : ifrmBase, IWindowsState
    {

        private IFucntion mIFunction;
        private IOperateMan mIOperateMan;
        private LoginInfo mLoginInfo;
        private IOrgan mIOrgan;
        private Form loginForm;
        private IconPanel iconPanel1;
        //private IconPanel iconPanel2;
        //private IconPanel iconPanel3;

        private List<ReflectionLabel> mlstFlowButtons;
        //  private bool IsCanBarResize=false;
        //  private frmLeft mFrmLeft;

        private List<string> mlstFormName;
        private List<string> mlstWeather;

        //private int AnimateIndex=0;
        private List<LineModel> mlstLines;
        //private int mIndex;
        //   string mInfo1;
        //  private bool isConnectPerson;
        public Form LoginForm
        {

            set { loginForm = value; }

        }


        public frmMainDocking()
        {
            InitializeComponent();
            mIFunction = BllFactory.GetFunctionBll();
            mlstFormName = new List<string>();
            mIOrgan = BllFactory.GetOrganBll();
            mlstWeather = new List<string>();
            mlstLines = new List<LineModel>();
            // timer1.Enabled = true;

        }
        private void GetRes()
        {

            //panel1.BackgroundImage = global::CustRes.Resource.mainback;
            picWeiqi.BackgroundImage = global::CustRes.Resource.weiqi;

            //   picWeiqi.LoadAsync("http://s9.rr.itc.cn/r/wapChange/201611_18_16/a2w4j97109139044855.jpeg");

        }
        private void frmMainDocking_Load(object sender, EventArgs e)
        {
#if !DEBUG
                
               testToolStripMenuItem.Visible = false;
#endif

            GetRes();
            mainTabControls.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Fill;
            mlstFlowButtons = new List<ReflectionLabel>();
            init();

            Console.WriteLine("main" + Thread.CurrentThread.ManagedThreadId);
            if (MainWindowState.getInstance().IsPersonConneted)
                lblPersonC.Text = "总部：已连接";
            else
                lblPersonC.Text = "总部：未连接";

            if (MainWindowState.getInstance().IsVipConnected)
                lblVipC.Text = "会员:已连接";
            else
                lblVipC.Text = "会员:未连接";
            //   Bll.Else.WeatherBll bll = new Bll.Else.WeatherBll();
            // bll.getWeatherbyCityName();
            lblClientInfo.Text = "";
            //frmInfo frm = new frmInfo();
            //frm.ShowDialogEx();
            // bll.WeatheInfoHandler += new Bll.Else.getWeatheInfoHandler(this.doWeatherInfo);
            // Task t= new Task(() => showWeather());
         //   Task<string> t = new Task<string>(() => getWeather());


            // Console.WriteLine("11111");
            //t.Start();

            ////Console.WriteLine("3333");
            //t.ContinueWith((r) => this.BeginInvoke(new Action(() =>

            //        showWeather(r.Result)

            //    )));



            CreateLines();
            // initClient();



        }



        private void timer2_Tick(object sender, EventArgs e)
        {

            //if (AnimateIndex <= 50)
            //{

            //   LineShape ls= (LineShape)this.shapeContainer1.Shapes.get_Item(1);
            //   ls.X2 = ls.X2 + 2;
            //   AnimateIndex++;

            //}
            //else
            //    timer2.Enabled = false;
            foreach (LineModel m in mlstLines)
            {
                m.Grow();
                if (checkLines())
                    timer2.Enabled = false;

            }



        }
        private void CreateLines()
        {

            // this.shapeContainer1.Shapes.Add(ls);
            //this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            //ls});




            mlstLines.Add(new LineModel(llbS_CarDoc_0, llbS_CarInHQuery_0, 1));
            mlstLines.Add(new LineModel(llbS_CarInHQuery_0, llbS_CarStock_0, 1));
            mlstLines.Add(new LineModel(llbC_CustomerQuery_0, llbS_CustInQuery_0, 0));

            mlstLines.Add(new LineModel(llbS_CarOrderQuery_0, llbS_CarSaleQuery_0, 1));
            mlstLines.Add(new LineModel(llbS_CarSaleQuery_0, llbS_CarSaleCheck_1, 1));
            mlstLines.Add(new LineModel(llbS_CarSaleCheck_1, llbM_Account_0_0, 0));

            // mlstLines.Add(new LineModel(llbR_RepairItem_0, llbR_AccInQuery_0, 1));
            mlstLines.Add(new LineModel(llbR_AccInQuery_0, llbR_Accessory_0, 1));
            mlstLines.Add(new LineModel(llbR_RepRecept_0, llbR_TakeAcc_0, 1));
            mlstLines.Add(new LineModel(llbR_TakeAcc_0, llbllbM_Account_0_1, 1));

            foreach (LineModel m in mlstLines)
            {
                shapeContainer1.Shapes.Add(m.Line);

            }
        }

        private bool checkLines()
        {
            // bool result = false;
            foreach (LineModel m in mlstLines)
            {

                if (m.IsCompleted == false)
                    return false;

            }

            return true;
        }

        private void showNotify(string msg)
        {
            lblClientInfo.Invoke(new Action(() => showInBar(msg)));

        }

        private void showInBar(string msg)
        {
            if (msg == "connect success")
                lblClientInfo.Text = "聊天窗口";
            //else if(msg == "connect failed")
            //    lblClientInfo.Text = "";

            //if(MyClient.getInstance().IsConnected)
            //    lblClientInfo.Text = "聊天窗口";
            //else
            //    lblClientInfo.Text = "";
            if (msg.Contains("新消息"))
            {
                lblClientInfo.Text = msg;
                timer1.Enabled = true;


            }



        }

        private void initClient()
        {
            MyClient client = MyClient.getInstance();
            client.NotifyAct += new Action<string>(showNotify);
            client.Connect();

        }

        private void showWeather(string result)
        {

            Newtonsoft.Json.Linq.JObject jobject = Newtonsoft.Json.Linq.JObject.Parse(result);
            //string tmp = jobject["data"]["week"].ToString();
            string desc = jobject["data"]["forecast"][0]["desc"].ToString();
            string lowtemper = jobject["data"]["forecast"][0]["low_temper"].ToString();
            string hightemper = jobject["data"]["forecast"][0]["high_temper"].ToString();
            string aqi = jobject["data"]["aqi"].ToString();
            string desc1 = jobject["data"]["forecast"][1]["desc"].ToString();
            string lowtemper1 = jobject["data"]["forecast"][1]["low_temper"].ToString();
            string hightemper1 = jobject["data"]["forecast"][1]["high_temper"].ToString();
            labelX2.Text = string.Format("南通今日天气 {0} {1}-{2}℃ {3} 明日 {4} {5}-{6}℃", desc, lowtemper, hightemper, aqi, desc1, lowtemper1, hightemper1);
        }

        //private string getWeather()
        //{
        //    //var task= Task.Factory.StartNew<string>(() => HtmlFetch.doQuickFetch(""));
        //    //  Thread.Sleep(5000*2);
        //    // Console.WriteLine("55555");
        //    ////string str = await task.Result;
        //    //string url = "http://wea.uc.cn/v2/swa_weather.php?uc_param_str=nieidnutssvebipfcp&nn=AAQIahkP2%2FuIWlw1EHTimmRQgteERlaVzypnkKjinuz3yQ%3D%3D&dn=16297737292-637e6bb1&ut=AARgrq2K5IYrWZT7YRKn2A%2FJRrjRdXpbS571pcMlp5zxMw%3D%3D&ss=375x667&ve=12.0.0.1072&bi=997&pf=44&pc=AARTc6PTxySnYeM4t6sI5IcDRSeOtncr7Q6sEJOuWnMYZbz9bdV%2BN2PIllcGow3RPHHncoM06Yn%2Bk5x0TlO5wCbv&city=AAN2ZOU9FzCF7HGjekepP1Aj&county=AAO30abDNTCf%2FPcVzIsidzmJ&v=2&vcode=36c93d1ab0eadff7";


        //    //string result = HtmlFetch.doQuickFetch(url);


        //    //return result;
        //}

        private void doWeatherInfo(string[] result)
        {
            if (result.Count() > 0)
            {
                mlstWeather.Add(result[5]);
                mlstWeather.Add(result[6]);
                mlstWeather.Add(result[7]);

            }

        }


        private void init()
        {


            mLoginInfo = LoginInfoShare.getInstance();
            // lblStatus.Text = "正在加载菜单......";

            InitFlowButton();
            InitOutlookBar();
            OrganSelXml xml = new OrganSelXml();
            MainWindowState.getInstance().SelOrgan = mIOrgan.GetSelOrganByLst(xml.ReadToList());
            StartWork(null);
        }
        private void InitOutlookBar()
        {

            MainWindowState.getInstance().WayOfState = this;
            outlookBar.BorderStyle = BorderStyle.FixedSingle;
            outlookBar.Initialize();
            iconPanel1 = new IconPanel();
            //  iconPanel2 = new IconPanel();
            //iconPanel3 = new IconPanel();

            outlookBar.AddBand("网址", iconPanel1, null);
            //  outlookBar.AddBand("售后", iconPanel2, null);
            // outlookBar.AddBand("财务", iconPanel3, null);

            iconPanel1.AddIcon("新城OA", global::Auto4SErp.Properties.Resources.xc, new EventHandler(PanelEventA), "http://oa.xinchengauto.com/");
            iconPanel1.AddIcon("伟启财富", global::Auto4SErp.Properties.Resources.wq, new EventHandler(PanelEventA), "http://www.weiqimoney.com/");
            iconPanel1.AddIcon("汽车之家", global::Auto4SErp.Properties.Resources.qczj, new EventHandler(PanelEventA), "http://www.autohome.com.cn/nantong/");
            iconPanel1.AddIcon("易车网", global::Auto4SErp.Properties.Resources.yc, new EventHandler(PanelEventA), "http://nantong.bitauto.com/");
            iconPanel1.AddIcon("17网", global::Auto4SErp.Properties.Resources._17, new EventHandler(PanelEventA), "http://www.17.com/nantong/");
            //1
            // iconPanel1.AddIcon("整车销售", global::Auto4SErp.Properties.Resources.bcarsale, new EventHandler(PanelEventA), "S_CarSaleQuery_0,010302");
            //2
            //iconPanel2.AddIcon("维修接车", global::Auto4SErp.Properties.Resources.RepRecept, new EventHandler(PanelEventA), "R_RepRecept_0,0201");
            ////3
            //iconPanel2.AddIcon("维修领料", global::Auto4SErp.Properties.Resources.bacctake, new EventHandler(PanelEventA), "R_TakeAcc_0,020202");

            //iconPanel2.AddIcon("入库查询", global::Auto4SErp.Properties.Resources.bacctake, new EventHandler(PanelEventA), "R_InWareRec_0,020401");
            ////3
            //iconPanel2.AddIcon("出库查询", global::Auto4SErp.Properties.Resources.bacctake, new EventHandler(PanelEventA), "R_OutWareRec_0,020402");

            //iconPanel2.AddIcon("库存查询", global::Auto4SErp.Properties.Resources.bacctake, new EventHandler(PanelEventA), "R_AccWareQuery_0,020403");

            //iconPanel2.AddIcon("销售装潢", global::Auto4SErp.Properties.Resources.bdecorate, new EventHandler(PanelEventA), "R_SaleDecorate_0,0205");
            ////4
            //iconPanel3.AddIcon("财务收款", global::Auto4SErp.Properties.Resources.breceptm, new EventHandler(PanelEventA), "M_Account_0,0601");
            outlookBar.SelectBand(0);


        }

        private void ValidateIsEnable(IconPanel panel, List<string> funCollection)
        {
            //foreach (Control c in panel.Controls)
            //{
            //    PanelIcon tmpc = c as PanelIcon;
            //    if (tmpc != null)
            //    {
            //        string[] strlst = tmpc.FunName.Split(',');
            //        if (funCollection.Contains(strlst[1]))
            //            tmpc.Enabled = true;
            //        else
            //            tmpc.Enabled = false;
            //    }


            //}

        }




        public void EnableSpecialFlowButtons()
        {
            foreach (ReflectionLabel lb in mlstFlowButtons)
            {

                lb.Enabled = false;

            }
            //llbR_TakeAcc_0.Enabled=true;
            //llbR_AccInQuery_0.Enabled = true;
            //llbR_Accessory_0.Enabled = true;
            //llbR_RepRecept_0.Enabled = true;
            //llbR_RepairItem_0.Enabled = true;
        }

        private void EnableFlowButtons(List<string> funCollection)
        {

            if (LoginInfoShare.getInstance().UserId == "admin")
            {
                foreach (ReflectionLabel lb in mlstFlowButtons)
                {
                    lb.Enabled = true;
                }
            }
            else
            {
                foreach (ReflectionLabel lb in mlstFlowButtons)
                {
                    string strtmp = lb.Tag.ToString();
                    //string[] strlst = strtmp.Split('_');
                    if (funCollection.Contains(strtmp))

                        lb.Enabled = true;
                    else
                        lb.Enabled = false;



                }


            }

            timer2.Enabled = true;
        }


        public void EnableButtons(List<string> funCollection)
        {
            //if (funCollection.Count > 0)
            //{
            //ValidateIsEnable(iconPanel1, funCollection);
            //ValidateIsEnable(iconPanel2, funCollection);
            //ValidateIsEnable(iconPanel3, funCollection);
            //}

        }

        public void PanelEventA(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            PanelIcon panelIcon = ctrl.Tag as PanelIcon;
            string clickInfo = string.Empty;

            System.Diagnostics.Process.Start(panelIcon.FunName);
            //   string[] strlst = panelIcon.FunName.Split(',');
            // OpenWindows(strlst[0]);

        }

        protected override void DoworkInBack(object sender, DoWorkEventArgs e)
        {

            Console.WriteLine("aa" + Thread.CurrentThread.ManagedThreadId);
            JsonSerialize js = new JsonSerialize();
            FileOperate fo = new FileOperate("");
            if (MainWindowState.getInstance().IsPersonConneted)
            {

                // throw new Exception("网络不通");
                DataTable dt = mIFunction.GetMenus();
                e.Result = dt;
            }
            else
            {

                string strtable = fo.readFromFile();
                if (!string.IsNullOrEmpty(strtable))
                    e.Result = js.deserializeDataTable(strtable);
                return;

            }



            //DataTable dtinfo = Bll.BllFactory.GetStaffBll().GetLatestInfos();

            //if (dtinfo.Rows.Count > 0)
            //{
            //    //lbltip1.Text = "通知信息";
            //    //if (dtinfo.Rows.Count > 1)
            //        mInfo1 =  dtinfo.Rows[0][0].ToString();

            //}

        }


        private ToolStripMenuItem CreateMenuItem(dynamic var, IEnumerable<string> lstF)
        {
            ToolStripMenuItem MenuItem = new ToolStripMenuItem();
            MenuItem.Name = "MenuItem" + var.NodeId;
            MenuItem.Text = var.NodeName;


            if (var.WindowRelated != "")
            {

                if (lstF.Contains((string)var.NodeId) || Comm.LoginInfoShare.getInstance().UserName == "admin")
                {
                    MenuItem.Click += new EventHandler(DoItemClick);
                    MenuItem.Tag = var.WindowRelated;
                }
                else
                    MenuItem.Enabled = false;

                if (var.WindowRelated == "category")
                {
                    MenuItem.ForeColor = Color.Red;
                }
            }


            return MenuItem;

        }
        protected override void DoBackatCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            Console.WriteLine("bb" + Thread.CurrentThread.ManagedThreadId);
            LoginInfo li = Comm.LoginInfoShare.getInstance();
            //   InitFlowButton();
            lblID.Text = li.UserId;
            lblName.Text = li.UserName;
            lblOrgan.Text = li.OrganName + "(" + li.OrganId + ")";
            //lblWeather.Text = "暂无";
            // bar1.Visible = true;
            if (li.IsiInner == true)
            {
                //outlookBar.Enabled = false;


                EnableSpecialFlowButtons();
                return;
            }
            if (li.IsSelf == true)
                lblSelf.Text = "本店员工";
            else
                lblSelf.Text = "非本店员工";
            //  List<string> lstFuns = mIFunction.GetFunctionsOfPosition(mLoginInfo.PositionId);


            //  mIOrgan.AssginToConnString();
            IEnumerable<string> lstFuns = null;
            if (MainWindowState.getInstance().IsPersonConneted)
            {
                mIOperateMan = BllFactory.GetOperateManBll();
                IPosition mIPosition = BllFactory.GetPositionBll();


                int tmpid = 0;
                string id = mIPosition.GetPositionidByName(li.PositionName);
                if (!string.IsNullOrEmpty(id))
                    tmpid = int.Parse(id);
                List<string> lstFunsOfP = mIFunction.GetFunctionsOfPosition(tmpid).ToList();
                List<string> lstFunsOfS = mIOperateMan.GetFunctionsOfStaff(li.UserId);
                lstFuns = lstFunsOfP.Union(lstFunsOfS);
                WriteFuncsToFile(lstFuns);
            }
            else
            {
                FileOperate fo = new FileOperate("func.txt");
                JsonSerialize js = new JsonSerialize();
                string str = fo.readFromFile();
                if (!string.IsNullOrEmpty(str))
                    lstFuns = js.deserializeList(str);
                labelX2.Text = "此时为离线登录，只能登录最后一次使用的用户";

            }


            //  lstFunsOfS.Union(lstFuns);
            DataTable dt = (DataTable)e.Result;


            WritePowerToFile(dt);

            var qAll = dt.AsEnumerable().Select(r => new { NodeId = Comm.ElseUtil.RO(r["nodeid"]).Trim(), NodeName = Comm.ElseUtil.RO(r["nodename"]), ParentId = Comm.ElseUtil.RO(r["parentid"]).Trim(), WindowRelated = Comm.ElseUtil.RO(r["WindowRelated"]), SortID = Comm.ElseUtil.RO(r["SortID"]) });


            var qOne = qAll.OrderBy(r => r.SortID).Where(r => r.ParentId == "0");


            foreach (var pO in qOne)
            {

                ToolStripMenuItem oneMenu = CreateMenuItem(pO, lstFuns);
                menuMain.Items.Add(oneMenu);


                var qSecond = qAll.OrderBy(r => r.SortID).Where(r => r.ParentId == pO.NodeId);
                foreach (var pS in qSecond)
                {
                    ToolStripMenuItem secondMenu = CreateMenuItem(pS, lstFuns);
                    oneMenu.DropDownItems.Add(secondMenu);

                    var qThird = qAll.OrderBy(r => r.SortID).Where(r => r.ParentId == pS.NodeId);
                    foreach (var pT in qThird)
                    {
                        ToolStripMenuItem thirdMenu = CreateMenuItem(pT, lstFuns);
                        secondMenu.DropDownItems.Add(thirdMenu);
                    }
                }

            }


            //DataView dvFirst = new DataView(dt);
            //dvFirst.RowFilter = "ParentID=0";
            //dvFirst.Sort = "SortID";
            //for (int i = 0; i < dvFirst.Count; i++)
            //{
            //    DataRowView drFirst = dvFirst[i];
            //    ToolStripMenuItem firstMenuItem = new ToolStripMenuItem();
            //    firstMenuItem.Name = "MenuItem" + drFirst["NodeID"].ToString().Trim();
            //    firstMenuItem.Text = drFirst["NodeName"].ToString();
            //    menuMain.Items.Add(firstMenuItem);
            //    IsItemEnable(lstFuns, firstMenuItem);

            //    DataView dvSecond = new DataView(dt);
            //    dvSecond.RowFilter = "ParentID=" + drFirst["NodeID"].ToString();
            //    dvSecond.Sort = "SortID";
            //    for (int j = 0; j < dvSecond.Count; j++)
            //    {
            //        DataRowView drSecond = dvSecond[j];
            //        ToolStripMenuItem secondMenuItem = new ToolStripMenuItem();
            //        secondMenuItem.Name = "MenuItem" + drSecond["NodeID"].ToString().Trim(); ;
            //        secondMenuItem.Text = drSecond["NodeName"].ToString();
            //        string winRelated = drSecond["WindowRelated"].ToString();
            //        if (winRelated != "")
            //        {
            //            secondMenuItem.Click += new EventHandler(DoItemClick);
            //            secondMenuItem.Tag = winRelated;
            //        }

            //        firstMenuItem.DropDownItems.Add(secondMenuItem);
            //        IsItemEnable(lstFuns, secondMenuItem);

            //        DataView dvThird = new DataView(dt);
            //        dvThird.RowFilter = "ParentID=" + drSecond["NodeID"].ToString();
            //        dvThird.Sort = "SortID";
            //        for (int k = 0; k < dvThird.Count; k++)
            //        {
            //            DataRowView drThird = dvThird[k];
            //            ToolStripMenuItem thirdMenuItem = new ToolStripMenuItem();
            //            thirdMenuItem.Name = "MenuItem" + drThird["NodeID"].ToString().Trim(); ;
            //            thirdMenuItem.Text = drThird["NodeName"].ToString();
            //            thirdMenuItem.Tag = drThird["WindowRelated"].ToString();

            //            secondMenuItem.DropDownItems.Add(thirdMenuItem);
            //            // thirdMenuItem.Enabled = false;
            //            IsItemEnable(lstFuns, thirdMenuItem);
            //            if (thirdMenuItem.Tag.ToString() != "category")
            //            {
            //                thirdMenuItem.Click += new EventHandler(DoItemClick);
            //                //thirdMenuItem.Enabled = false;
            //            }
            //            else
            //            {
            //                thirdMenuItem.ForeColor = Color.Red;
            //                if (thirdMenuItem.Tag.ToString() != "category")
            //                {
            //                    thirdMenuItem.Click += new EventHandler(DoItemClick);
            //                    //thirdMenuItem.Enabled = false;
            //                }
            //                else
            //                {
            //                    thirdMenuItem.ForeColor = Color.Red;
            //                    thirdMenuItem.Enabled = true;
            //                }
            //            }

            //        }

            //    }

            //}



            EnableButtons(lstFuns.ToList());

            EnableFlowButtons(lstFuns.ToList());



        }

        private void WriteFuncsToFile(IEnumerable<string> list)
        {
            JsonSerialize js = new JsonSerialize();
            string str = js.serializeList(list);

            FileOperate fo = new FileOperate("func.txt");
            fo.writeToFile(str);

        }
        private void WritePowerToFile(DataTable dt)
        {


            JsonSerialize js = new JsonSerialize();
            FileOperate fo = new FileOperate("");
            //if (!fo.isExists())
            //{
            string strTable = js.serializeDataTable(dt);
            fo.writeToFile(strTable);
            //}

        }

        private void InitFlowButton()
        {

            foreach (Control c in panel1.Controls)
            {
                ReflectionLabel ll = c as ReflectionLabel;
                if (ll != null)
                {

                    if (!mlstFlowButtons.Contains(ll))
                    {
                        mlstFlowButtons.Add(ll);

                        // ll.LinkBehavior = LinkBehavior.HoverUnderline;
                        // ll.ActiveLinkColor = Color.White;
                        ll.Click += new EventHandler(FlowClick);
                    }

                }
            }

        }

        private void FlowClick(object sender, EventArgs e)
        {

            ReflectionLabel ll = (ReflectionLabel)sender;
            string strtmp = ll.Name.Substring(3);
            OpenWindows(strtmp);


        }
        private void IsItemEnable(IEnumerable<string> lstFuns, ToolStripMenuItem item)
        {
            string nodeid = item.Name.Substring(8);
            if (lstFuns.Contains(nodeid))
                item.Enabled = true;
            else
                item.Enabled = false;
            if (mLoginInfo.UserId == "admin") item.Enabled = true;

        }


        private void OpenWindows(string funcname)
        {

            if (funcname != "")
            {




                string[] strlst = funcname.Split('_');


                string midStr = "";


                //if (mlstFormName.Contains("frm" + strlst[1]))
                //    return;

                if (IsOpenOfWindow("frm" + strlst[1]))
                    return;

                switch (strlst[0])
                {
                    case "C":
                        midStr = "Cust";
                        break;
                    case "S":
                        midStr = "Sale";
                        break;
                    case "P":
                        midStr = "Personnel";
                        break;
                    case "R":
                        midStr = "Repair";
                        break;
                    case "M":
                        midStr = "";
                        break;
                    case "T":
                        midStr = "Report";
                        break;
                    case "G":
                        midStr = "GroupReport";
                        break;
                    case "F":
                        midStr = "Finance";
                        break;
                    default:
                        midStr = "";
                        break;


                }
                string strTemp = "";
                if (midStr != "")
                    strTemp = "Auto4SErp." + midStr + ".frm" + strlst[1];
                else
                    strTemp = "Auto4SErp.frm" + strlst[1];
                ifrmBase frm = (ifrmBase)Assembly.Load("Auto4SErp").CreateInstance(strTemp);
                if (strlst[2] == "0")
                {
                    //panel1.Visible = false;
                    //dockPanel1.Visible = true;
                    //frm.MdiParent = this;
                    //frm.WindowState = FormWindowState.Maximized;
                    frm.IsWindow = true;
                    //mlstFormName.Add("frm" + strlst[1]);
                    //frm.Show(this.dockPanel1);

                    mainTabControls.Visible = true;
                    panel1.Visible = false;

                    DevComponents.DotNetBar.TabItem tabItemNew = new DevComponents.DotNetBar.TabItem();

                    DevComponents.DotNetBar.TabControlPanel tabControlPanelNew = new DevComponents.DotNetBar.TabControlPanel();

                    tabControlPanelNew.Dock = System.Windows.Forms.DockStyle.Fill;
                    tabControlPanelNew.Name = "TestPanle";
                    tabControlPanelNew.TabItem = tabItemNew;

                    tabItemNew.AttachedControl = tabControlPanelNew;
                    tabItemNew.Name = frm.Name;
                    tabItemNew.Text = frm.Text;

                    mainTabControls.Controls.Add(tabControlPanelNew);
                    mainTabControls.Tabs.Add(tabItemNew);

                    frm.FormBorderStyle = FormBorderStyle.None;//mdiForm为窗体实例
                    frm.TopLevel = false;
                    frm.Parent = tabControlPanelNew;
                    frm.Dock = DockStyle.Fill;
                    tabControlPanelNew.Controls.Add(frm);
                    frm.Show();
                    mainTabControls.Refresh();
                    mainTabControls.SelectedTab = tabItemNew;


                }
                else
                {
                    frm.ShowDialogEx();

                }



            }




        }

        private void DoItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string winRelated = item.Tag.ToString();
            OpenWindows(winRelated);
        }




        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personnel.frmStaffFunction frm = new Personnel.frmStaffFunction();
            frm.ShowDialogEx();
        }

        public int GetWindowsCount()
        {
            //return dockPanel1.DocumentsCount;
            return 0;
        }

        public void ToggleWindowVisible(string formname)
        {
            //if (dockPanel1.DocumentsCount > 1)
            //{
            //    panel1.Visible = false;
            //    dockPanel1.Visible = true;


            //}
            //else
            //{
            //    panel1.Visible = true;

            //    dockPanel1.Visible = false;

            //}
            mlstFormName.Remove(formname);


        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = (LinkLabel)sender;
            string strtmp = ll.Name.Substring(3);
            OpenWindows(strtmp);
        }

        private void frmMainDocking_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void menuLogOut_Click(object sender, EventArgs e)
        {
            frmLogin loginfrm = new frmLogin();
            loginfrm.ShowDialog();
            if (DialogResult.OK == loginfrm.DialogResult)
            {
                ClearMenus();
                mainTabControls.Tabs.Clear();
                // outlookBar.Controls.Clear();
                init();
            }

        }


        private void ClearMenus()
        {
            //for (int i = 0; i < menuMain.Items.Count; i++)
            //{
            //   // menuMain.Items.RemoveAt(i);
            //    //string tmp = menuMain.Items[0].

            //     menuMain.Items.
            //}

            List<ToolStripItem> tmplist = new List<ToolStripItem>();
            foreach (ToolStripItem item in menuMain.Items)
            {
                if (item.Text != "界面")
                    tmplist.Add(item);

            }
            foreach (ToolStripItem item in tmplist)
            {
                menuMain.Items.Remove(item);

            }


        }

        private void testToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            frmSalaryBase frm = new frmSalaryBase();
            frm.ShowDialog();

            //frmRCarAward frm = new frmRCarAward();
            //frm.Show();
            //Bll.Repair.ConvertBll bll = new Bll.Repair.ConvertBll();
            //bll.CarSaleToDB();
            // bll.AccessoryToDB();

            //   bll.DelData();
            // bll.AccessoryToDB();
            //bll.CarOrderToDB();
            //bll.CarSerToDB();
            //bll.CarModelToDB();
            //bll.CarDeitailToDB();
            // bll.CarStockToDB();
            //bll.OldZHRepToDB();
            //  bll.WareToDB();
            //    bll.OldRepToDB();
            //bll.OldJSRepToDB();
            //bll.AddCustomerInfo();
            //bll.CarStockToDB();

            //bll.AccessoryToDB();

            //bll.OldZHRepToDB();
            // bll.CarSaleToDB();
            // bll.CarSaleToDB();
            //bll.CarStockToDB();
            //bll.RepItemTypeToDB();
            //bll.RepItemToDB();
            //bll.RepItemPriceToDB();
            // bll.StaffToDB();
            //bll.CustomerToDB();
            // bll.AddCarInfo();
            //Form1 frm = new Form1();
            //frm.Show();

            //frmDevCarSaleQuery frm = new frmDevCarSaleQuery();
            //frm.Show();

            // 弘丰系统
            //bll.hf_customer();
        }

        private void mainTabControls_TabRemoved(object sender, EventArgs e)
        {
            if (mainTabControls.Tabs.Count == 0)
            {

                panel1.Visible = true;
                mainTabControls.Visible = false;
            }
        }

        private void mainTabControls_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {

        }


        private bool IsOpenOfWindow(string newwindow)
        {
            for (int i = 0; i < mainTabControls.Tabs.Count; i++)
            {
                if (mainTabControls.Tabs[i].Name == newwindow)
                    return true;


            }

            return false;
        }

        private void 界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPwd frm = new frmPwd();
            frm.ShowDialogEx();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (lblClientInfo.Visible)
                lblClientInfo.Visible = false;
            else
                lblClientInfo.Visible = true;

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInfoPost_Click(object sender, EventArgs e)
        {

        }

        private void frmMainDocking_KeyPress(object sender, KeyPressEventArgs e)
        {
            // char aa = e.KeyChar;
        }

        private void frmMainDocking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 112)
            {

                Process.Start("ERP.CHM");

            }
        }

        private void lblClientInfo_Click(object sender, EventArgs e)
        {
            //bool b = MyClient.getInstance().IsConnected;
            // MyClient.getInstance().IsConnected = true;

            // MyClient client = MyClient.getInstance();
            if (MyClient.getInstance().IsConnected)
            {
                timer1.Enabled = false;
                this.lblClientInfo.Visible = true;
                this.lblClientInfo.Text = "聊天窗口";
                frmDlgMessage dlg = new frmDlgMessage();

                dlg.ShowDialog();

            }
        }



        private void frmMainDocking_SizeChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void llbR_RepRecept_0_Click(object sender, EventArgs e)
        {

        }

        private void frmMainDocking_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loginForm != null)
                loginForm.Close();
            //  this.notifyIcon1.Visible = false;

            MyClient client = MyClient.getInstance();
            if (client.IsConnected)
            {
                client.Close();


            }
        }


        //private void CheckServer()
        //{
        //    DelayThread backrun = new DelayThread();
        //    backrun.DoWork(new ThreadStart(this.StartCheck));


        //}

        //private void StartCheck()
        //{

        //    bool isP = ServerCheckBll.IsPersonConnected();
        //    bool isV = ServerCheckBll.IsVipConnected();
        //    this.BeginInvoke((MethodInvoker)delegate()
        //    {
        //        MainWindowState.getInstance().IsPersonConneted = isP;
        //        MainWindowState.getInstance().IsVipConnected = isV;

        //        if (isP)
        //            lblPersonC.Text = "总部：已连接";
        //        else
        //            lblPersonC.Text = "总部：未连接";

        //        if (isV)
        //            lblVipC.Text = "会员:已连接";
        //        else
        //            lblVipC.Text = "会员:未连接";

        //    });


        //}
    }


    public class LineModel
    {

        private int Step = 10;
        private bool isCompleted = false;
        public LineModel(Control b, Control e, int dirction)
        {
            BeginPt = new Point();
            EndPt = new Point();

            Direction = dirction;
            if (dirction == 0)   //水平
            {
                BeginPt = caculateButtonLeft(b);
                EndPt = caculateButtonRight(e);

                Line = new LineShape(BeginPt.X, BeginPt.Y, BeginPt.X, EndPt.Y);

            }
            else
            {
                BeginPt = caculateButtonButtom(b);
                EndPt = caculateButtonTop(e);
                Line = new LineShape(BeginPt.X, BeginPt.Y, EndPt.X, BeginPt.Y);

            }
            Line.BorderColor = Color.Gray;

        }


        public void Grow()
        {
            if (isCompleted) return;
            if (Direction == 0)
            {
                Line.X2 = Line.X2 + Step;
                if (Line.X2 >= EndPt.X)
                {
                    Line.X2 = EndPt.X;
                    isCompleted = true;

                }

            }
            else
            {

                Line.Y2 = Line.Y2 + Step / 3;
                if (Line.Y2 >= EndPt.Y)
                {
                    Line.Y2 = EndPt.Y;
                    isCompleted = true;

                }

            }



        }

        public bool IsCompleted
        {
            get
            {
                return isCompleted;
            }
        }

        private Point caculateButtonButtom(Control rl)
        {
            Point pt = new Point();
            pt.X = rl.Location.X + rl.Size.Width / 2;
            pt.Y = rl.Location.Y + rl.Size.Height;
            return pt;
        }


        private Point caculateButtonTop(Control rl)
        {
            Point pt = new Point();
            pt.X = rl.Location.X + rl.Size.Width / 2;
            pt.Y = rl.Location.Y;
            return pt;
        }
        private Point caculateButtonRight(Control rl)
        {
            Point pt = new Point();
            pt.X = rl.Location.X + rl.Size.Width;
            pt.Y = rl.Location.Y + rl.Size.Height / 2;
            return pt;
        }

        private Point caculateButtonLeft(Control rl)
        {
            Point pt = new Point();
            pt.X = rl.Location.X;
            pt.Y = rl.Location.Y + rl.Size.Height / 2;
            return pt;
        }


        public int Direction
        {
            get;
            set;
        }
        public Point BeginPt
        {
            get;
            set;
        }

        public Point EndPt
        {
            get;
            set;
        }


        public LineShape Line
        {
            get;
            set;

        }

    }
}