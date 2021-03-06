﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll.Personnel;
using Model;
using Bll;
using DevComponents.AdvTree;
namespace Auto4SErp.Personnel
{
    public partial class frmStaffFunction : ifrmBase
    {

        private IStaff mIStaff;
        private IFucntion mIFunction;
        private IOperateMan mIOperateMan;
        private List<string> mlstFuns;
        private ISenstive mISenstive;
        private string staffID = "";
        private DataTable mDtPowerText;
        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        private bool isStaff = true;

        public bool IsStaff
        {
            get { return isStaff; }
            set { isStaff = value; }
        }

        public frmStaffFunction()
        {
            InitializeComponent();
            mIStaff = BllFactory.GetStaffBll();
            mIFunction = BllFactory.GetFunctionBll();
            mIOperateMan = BllFactory.GetOperateManBll();
            mISenstive = BllFactory.GetSenstiveBll();
        }



        private Node CreateNode(string text, string key)
        {

            Node node = new Node();
            node.Text = text;
            node.DataKeyString = key;
            // node.ContextMenu = cmenuCarDoc;
            return node;
        }



        private void IsNodeEnable(IEnumerable<string> lstFuns, Node node)
        {

            string nodeid = node.DataKeyString;
            string[] strlst = nodeid.Split(',');
            if (lstFuns.Contains(strlst[0]))

                node.Image = global::Auto4SErp.Properties.Resources.fselect;
            else
                node.Image = global::Auto4SErp.Properties.Resources.fcancel;


        }


        private void AddFunsOfStaff(List<string> lst)
        {

            foreach (string str in lst)
            {
                mlstFuns.Add(str);

            }

        }

        private void LoadFunctionsOfPosition(int positionid)
        {

            mlstFuns = mIFunction.GetFunctionsOfPosition(positionid).ToList();
            List<string> lstFunsOfS = mIOperateMan.GetFunctionsOfStaff(staffID);
            //mlstFuns = lstFunsOfS.Union(lstFunsOfP);
            AddFunsOfStaff(lstFunsOfS);
            //string[] lstFuns = mIFunction.GetFunctionsOfPosition(positionid);
            DataTable mDtMenu = mIFunction.GetMenus();


            DataView dvFirst = new DataView(mDtMenu);
            dvFirst.RowFilter = "ParentID=0";
            dvFirst.Sort = "SortID";
            for (int i = 0; i < dvFirst.Count; i++)
            {
                DataRowView drFirst = dvFirst[i];
                //ToolStripMenuItem firstMenuItem = new ToolStripMenuItem();
                //firstMenuItem.Name = "MenuItem" + drFirst["NodeID"].ToString().Trim();
                //firstMenuItem.Text = drFirst["NodeName"].ToString();
                //menuMain.Items.Add(firstMenuItem);


                Node nodeFirst = CreateNode(drFirst["NodeName"].ToString(), drFirst["NodeID"].ToString().Trim() + "," + drFirst["WindowRelated"].ToString().Trim());
                treeFunction.Nodes.Add(nodeFirst);
                IsNodeEnable(mlstFuns, nodeFirst);
                DataView dvSecond = new DataView(mDtMenu);
                dvSecond.RowFilter = "ParentID=" + drFirst["NodeID"].ToString();
                for (int j = 0; j < dvSecond.Count; j++)
                {
                    DataRowView drSecond = dvSecond[j];
                    //ToolStripMenuItem secondMenuItem = new ToolStripMenuItem();
                    //secondMenuItem.Name = "MenuItem" + drSecond["NodeID"].ToString().Trim(); ;
                    //secondMenuItem.Text = drSecond["NodeName"].ToString();

                    Node nodeSecond = CreateNode(drSecond["NodeName"].ToString(), drSecond["NodeID"].ToString().Trim() + "," + drSecond["WindowRelated"].ToString().Trim());
                    nodeFirst.Nodes.Add(nodeSecond);
                    IsNodeEnable(mlstFuns, nodeSecond);

                    DataView dvThird = new DataView(mDtMenu);
                    dvThird.RowFilter = "ParentID=" + drSecond["NodeID"].ToString();

                    for (int k = 0; k < dvThird.Count; k++)
                    {
                        DataRowView drThird = dvThird[k];
                        //ToolStripMenuItem thirdMenuItem = new ToolStripMenuItem();
                        //thirdMenuItem.Name = "MenuItem" + drThird["NodeID"].ToString().Trim(); ;
                        //thirdMenuItem.Text = drThird["NodeName"].ToString();
                        //thirdMenuItem.Tag = drThird["WindowRelated"].ToString();
                        //thirdMenuItem.Click += new EventHandler(DoItemClick);
                        //secondMenuItem.DropDownItems.Add(thirdMenuItem);
                        // thirdMenuItem.Enabled = false;
                        Node nodeThird = CreateNode(drThird["NodeName"].ToString(), drThird["NodeID"].ToString().Trim() + "," + drThird["WindowRelated"].ToString().Trim());
                        IsNodeEnable(mlstFuns, nodeThird);
                        nodeSecond.Nodes.Add(nodeThird);

                    }

                }

            }



        }
        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Node selNode = treeFunction.SelectedNode;
            string[] strlst = selNode.DataKeyString.Split(',');
            string nodeid = strlst[0];
            if (selNode != null)
            {
                selNode.Image = global::Auto4SErp.Properties.Resources.fcancel;

                mIOperateMan.CancelFunction(staffID, nodeid);


            }
        }

        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Node selNode = treeFunction.SelectedNode;
            string[] strlst = selNode.DataKeyString.Split(',');
            string nodeid = strlst[0];
            //如果已存在则返回
            if (mlstFuns.Contains(selNode.DataKeyString)) return;
            if (selNode != null)
            {

                selNode.Image = global::Auto4SErp.Properties.Resources.fselect;

                mIOperateMan.EnableFunction(staffID, nodeid);

            }
        }


        private void frmStaffFunction_Load(object sender, EventArgs e)
        {
            Staff obj;
            if (isStaff)
                obj = mIStaff.GetStaff(staffID);
            else
                obj = mIOperateMan.GetOperateMan(staffID);
            mDtPowerText = mISenstive.GetPowerTexts();
            LoadFunctionsOfPosition(obj.PositionID);


        }

        private void treeFunction_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            if (pnlPower.Controls.Count > 0) pnlPower.Controls.Clear();
            string strtmp = e.Node.DataKeyString;
            string[] strlst = strtmp.Split(',');
            string winrelated = strlst[1];
            if (winrelated.Length > 1)
            {
                if (winrelated == "category") return;
                string[] lstwin = winrelated.Split('_');
                string[] str = mISenstive.GetPowerList(lstwin[1]);
                if (str != null)
                    AddPowerControls(str, lstwin[1]);
            }
        }

        private void AddPowerControls(string[] strpower, string formName)
        {
            //CheckBox chb = new CheckBox();
            //Point pt = new Point(0,0);
            //chb.Location = pt;
            //chb.Size = new System.Drawing.Size(78, 16);
            //chb.Text = "1111";
            //pnlPower.Controls.Add(chb);

            int top = 0;
            // int index = 0;
            List<string> lstPower = mISenstive.GetSPsOfStaff(staffID, formName);
            foreach (string str in strpower)
            {
                CheckBox chb = new CheckBox();
                Point pt = new Point(0, top);
                chb.Size = new System.Drawing.Size(78, 16);
                chb.Location = pt;

                chb.Name = str;
                chb.Text = GetPowerText(str) + "权限";
                chb.Tag = formName;
                chb.CheckedChanged += new EventHandler(Power_CheckedChanged);

                if (lstPower.Contains(str))

                    chb.Checked = true;
                else
                    chb.Checked = false;
                pnlPower.Controls.Add(chb);

                top = top + 36;
            }



        }

        private string GetPowerText(string spname)
        {
            for (int i = 0; i < mDtPowerText.Rows.Count; i++)
            {
                if (spname == mDtPowerText.Rows[i][0].ToString().Trim())
                {

                    return mDtPowerText.Rows[i][1].ToString();

                }
            }

            return "";

        }

        private void Power_CheckedChanged(Object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            if (chb.Checked)
            {
                mISenstive.AddSP(staffID, chb.Tag.ToString(), chb.Name);

            }
            else
            {
                mISenstive.DelSP(staffID, chb.Tag.ToString(), chb.Name);

            }
        }



    }
}
