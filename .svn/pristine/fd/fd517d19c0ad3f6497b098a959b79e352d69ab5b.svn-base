using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using System.Reflection;
using Model;

using Comm;
using Auto4SErp.Personnel;
using Auto4SErp.Repair;
using Auto4SErp.Report;
using Bll.Personnel;
using Auto4SErp.Sale;

//using Microsoft.ApplicationBlocks.ApplicationUpdater;
//using Microsoft.ApplicationBlocks.ApplicationUpdater.Interfaces;
//using Microsoft.ApplicationBlocks.ExceptionManagement;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Xml;


namespace Auto4SErp
{
    public partial class frmMain : ifrmBase
    {
        private IFucntion mIFunction;
        private LoginInfo mLoginInfo;
        private IOrgan mIOrgan;
        private Form loginForm;





        public Form LoginForm
        {
         
            set { loginForm = value; }
        }

     


        public frmMain()
        {
            InitializeComponent();
        //    InitializeAutoUpdate();
            mIFunction = BllFactory.GetFunctionBll();
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
           // frmFStatistics frm = new frmFStatistics();
            frmAccElseOut frm = new frmAccElseOut();
            frm.ShowDialog();
           
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            StartWork(null);
            mLoginInfo = LoginInfoShare.getInstance();
            lblStatus.Text = "正在加载菜单......";

        
        }



        protected override void DoworkInBack(object sender, DoWorkEventArgs e)
        {
            DataTable dt = mIFunction.GetMenus();
            e.Result = dt;
        }

        protected override void DoBackatCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          //  List<string> lstFuns = mIFunction.GetFunctionsOfPosition(mLoginInfo.PositionId);

            string[] lstFuns = mIFunction.GetFunctionsOfPosition(2);
            DataTable dt = (DataTable)e.Result;
            DataView dvFirst = new DataView(dt);
            dvFirst.RowFilter = "ParentID=0";
            dvFirst.Sort = "SortID";
            for (int i = 0; i < dvFirst.Count; i++)
            {
                DataRowView drFirst = dvFirst[i];
                ToolStripMenuItem firstMenuItem = new ToolStripMenuItem();
                firstMenuItem.Name = "MenuItem" + drFirst["NodeID"].ToString().Trim();
                firstMenuItem.Text = drFirst["NodeName"].ToString();
                menuMain.Items.Add(firstMenuItem);
                IsItemEnable(lstFuns, firstMenuItem);

                DataView dvSecond = new DataView(dt);
                dvSecond.RowFilter = "ParentID=" + drFirst["NodeID"].ToString();
                for (int j = 0; j < dvSecond.Count; j++)
                {
                    DataRowView drSecond = dvSecond[j];
                    ToolStripMenuItem secondMenuItem = new ToolStripMenuItem();
                    secondMenuItem.Name = "MenuItem" + drSecond["NodeID"].ToString().Trim(); ;
                    secondMenuItem.Text = drSecond["NodeName"].ToString();
                    string winRelated = drSecond["WindowRelated"].ToString();
                    if (winRelated != "")
                    {
                        secondMenuItem.Click += new EventHandler(DoItemClick);
                        secondMenuItem.Tag = winRelated;
                    }

                    firstMenuItem.DropDownItems.Add(secondMenuItem);
                    IsItemEnable(lstFuns, secondMenuItem);

                    DataView dvThird = new DataView(dt);
                    dvThird.RowFilter = "ParentID=" + drSecond["NodeID"].ToString();

                    for (int k = 0; k < dvThird.Count; k++)
                    {
                        DataRowView drThird = dvThird[k];
                        ToolStripMenuItem thirdMenuItem = new ToolStripMenuItem();
                        thirdMenuItem.Name = "MenuItem" + drThird["NodeID"].ToString().Trim(); ;
                        thirdMenuItem.Text = drThird["NodeName"].ToString();
                        thirdMenuItem.Tag = drThird["WindowRelated"].ToString();
                        thirdMenuItem.Click += new EventHandler(DoItemClick);
                        secondMenuItem.DropDownItems.Add(thirdMenuItem);
                        // thirdMenuItem.Enabled = false;
                        IsItemEnable(lstFuns, thirdMenuItem);


                    }

                }

            }
            
            lblStatus.Text = "";
            LoginInfo li = Comm.LoginInfoShare.getInstance();
            //li.OrganId = "101";
            lblLoginInfo.Text = string.Format("工号:{0}  姓名:{1}   门店:{2}", li.UserId, li.UserName, li.OrganName);
            mIOrgan = BllFactory.GetOrganBll();
            mIOrgan.AssginToConnString();
         
        
        }

        private void IsItemEnable(string[]  lstFuns,ToolStripMenuItem item)
        {
            string nodeid = item.Name.Substring(8);
            if (lstFuns.Contains(nodeid))
                item.Enabled = true;
            else
                item.Enabled = false;


        }
        private void DoItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string winRelated = item.Tag.ToString();
            if (winRelated != "")
            {

                string[] strlst = winRelated.Split('_');
                string midStr = "";
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
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();

                }
                else
                {
                    frm.ShowDialogEx();

                }
                


            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            if (loginForm != null)
                loginForm.Close();
        }

    
 

    }
}
