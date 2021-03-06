﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Model;
using Comm;
using Bll.Personnel;

namespace Auto4SErp
{
    public partial class frmLogin : ifrmBase
    {
        private IStaff mIStaff;
        private IOperateMan mIOperateMan;
        private IOrgan mIOrgan;
        public frmLogin()
        {
            InitializeComponent();


            mIOrgan = BllFactory.GetOrganBll();
        }


        //private void SetLoginInfo(string organid)
        //{
        //    Organ obj = mIOrgan.GetOrganObject(organid);
        //    LoginInfo li = Comm.LoginInfoShare.getInstance();
        //    li.OrganName = obj.OrganName;


        //}


        private void offlineLogin()
        {
            LoginInfo info = LoginInfoShare.getInstance();
            XmlConfig xc = new XmlConfig();
            //string selvalue = xc.GetConfigValue("selorgan");
            //string selpwd = xc.GetConfigValue("password");
            //string userid = xc.GetConfigValue("userid");
            info.OrganId = xc.GetConfigValue("organid");
            info.UserId = xc.GetConfigValue("userid");
            info.OrganName = xc.GetConfigValue("selorgan");
            info.UserName = xc.GetConfigValue("username");
            this.DialogResult = DialogResult.OK;

        }


        private void Login()
        {
            if (!MainWindowState.getInstance().IsPersonConneted)
            {
                offlineLogin();
                return;


            }


            string organid = "";
            string organname = "";


            //if (MainWindowState.getInstance().IsPersonConneted)
            //{
            DevComponents.AdvTree.Node node = cbtOrgan.SelectedNode;

            if (node == null) return;
            organid = node.DataKeyString;
            organname = mIOrgan.GetOrganName(organid.Trim());
            // }
            //else
            //{
            //    XmlConfig xc = new XmlConfig();
            //    string strvalue= xc.GetConfigValue("selorgan");
            //    string[] strlst = strvalue.Split(',');
            //    organid = strlst[1];
            //    organname = strlst[0];

            //}
            LoginInfo li = Comm.LoginInfoShare.getInstance();
            Comm.LoginInfoShare.getInstance().IsSelf = false;
            mIOrgan.SetNewOrgan(organid.Trim());
            li.OrganId = organid.Trim();
            li.OrganName = organname;

            if (chbIsNB.Checked)
                li.IsiInner = true;

            SetOrganToConfig(li.OrganName, li.OrganId);
            mIOperateMan = BllFactory.GetOperateManBll();

            //#if DEBUG
            //     txtStaffID.Text = "admin";
            //#endif

            if (txtStaffID.Text == "admin")
            {
#if !DEBUG
                SystemInfo info = mIOperateMan.GetSystemInfo();
                if (info.AdminPwd == txtPwd.Text)
                {
                    //   frmMainDocking frm = new frmMainDocking();
                    //  li.OrganName = tmpStaff.OrganName;
                    li.UserId = "admin";
                    li.UserName = "admin";
                    li.PositionName = "管理员";
                    //SetOrganToConfig(li.OrganName, li.OrganId);
                    this.DialogResult = DialogResult.OK;
                    SetPassWord();

                }
                else
                {
                    ShowMessage("登录失败");

                }
                return;
#endif
                //  frmMainDocking frm1 = new frmMainDocking();
                //  li.OrganName = tmpStaff.OrganName;
                li.UserId = "admin";
                li.UserName = "admin";

                li.PositionName = "管理员";
                // SetOrganToConfig(li.OrganName, li.OrganId);
                this.DialogResult = DialogResult.OK;
                return;

            }





            Staff tmpStaff = null;
            bool IsPwdVerify = false;
            bool IsSelfVerify = false;
            //此处为网络验证
            if (Comm.LoginInfoShare.getInstance().IsiInner == false)
            {
                mIStaff = BllFactory.GetStaffBll();
                if (mIStaff.ValidateLogin(txtStaffID.Text.Trim(), txtPwd.Text.Trim()))
                {
                    tmpStaff = mIStaff.GetStaff(txtStaffID.Text.Trim());

                    IsPwdVerify = true;
                    if (tmpStaff.OrganName == "总公司总公司") tmpStaff.OrganName = "总公司";
                    if (tmpStaff.OrganName != li.OrganName)
                    {

                        tmpStaff = null;
                        IsSelfVerify = false;
                    }
                    else
                        IsSelfVerify = true;


                    Comm.LoginInfoShare.getInstance().IsSelf = true;
                }
            }

            //网络验证后失败，做本地验证
            if (IsPwdVerify == false || IsSelfVerify == false)
            {
                tmpStaff = mIOperateMan.GetOperateMan(txtStaffID.Text.Trim());


                //在本店注册该员工的情况下
                if (tmpStaff != null)
                {
                    tmpStaff.OrganId = li.OrganId;
                    if (IsPwdVerify == false)
                    {
                        bool final = mIOperateMan.ValidateLogin(txtStaffID.Text.Trim(), txtPwd.Text.Trim());
                        if (final == false)
                            tmpStaff = null;
                    }

                }
                Comm.LoginInfoShare.getInstance().IsSelf = false;
            }





            if (tmpStaff != null)
            {

                LoginInfo info = LoginInfoShare.getInstance();

                info.UserId = tmpStaff.StaffID;
                info.UserName = RemoveDian(tmpStaff.StaffName);
                info.PositionId = tmpStaff.PositionID;
                info.PositionName = RemoveDuo(tmpStaff.PositionName);
                li.PositionName = RemoveDuo(tmpStaff.PositionName);

                SetPassWord();
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                if (IsPwdVerify == false)
                {
                    ShowMessage("登录失败,工号或密码错误");
                    return;
                }

                if (IsSelfVerify == false)
                {
                    ShowMessage("登录失败,该员工号不属于该本店");
                    return;
                }
                ShowMessage("登录失败");
                return;
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            try
            {
                Login();

            }
            catch (Exception ex)
            {

                MessageBox.Show("网络连接错误（" + ex.Message.ToString() + ")");

            }

        }



        private string RemoveDuo(string position)
        {
            string newstr = "";
            if (position.Contains("兼"))
            {

                newstr = position.Substring(0, 4);


            }
            else
                newstr = position;

            return newstr;

        }
        private string RemoveDian(string name)
        {
            string newstr = name.Replace('.', ' ');
            newstr = newstr.Trim();
            return newstr;

        }

        private void SetPassWord()
        {

            LoginInfo info = LoginInfoShare.getInstance();
            XmlConfig xc = new XmlConfig();
            if (chbpassword.Checked)
            {
                //xc.SetConfigValue("userid", txtStaffID.Text);
                xc.SetConfigValue("password", txtPwd.Text);
            }
            else
            {
                //xc.SetConfigValue("userid", "");
                xc.SetConfigValue("password", "");
            }
            xc.SetConfigValue("userid", info.UserId);
            xc.SetConfigValue("username", info.UserName);
            xc.SetConfigValue("organid", info.OrganId);


        }
        private void SetOrganToConfig(string organname, string organid)
        {
            XmlConfig xc = new XmlConfig();
            xc.SetConfigValue("selorgan", organname);


        }



        private void GetRec()  
        {

            // =CustAsset.User_64px_1115223_easyicon_net;
            pnlLogin.BackgroundImage = global::CustRes.Resource.login;
            pictureBox1.Image = global::CustRes.Resource.loginuser;


        }
        private void frmLogin_Load(object sender, EventArgs e)
        {


            GetRec();
            StartWork(null);
            this.Text = "初始化程序.....";
            btnLogin.Enabled = false;


        }

        private void SetOrganSelected()
        {
            XmlConfig xc = new XmlConfig();
            string selvalue = xc.GetConfigValue("selorgan");
            string selpwd = xc.GetConfigValue("password");
            string userid = xc.GetConfigValue("userid");
            txtPwd.Text = selpwd;
            txtStaffID.Text = userid;
            if (!string.IsNullOrEmpty(userid))
                chbpassword.Checked = true;
#if  DEBUG
            txtStaffID.Text = "admin";
#endif
            //// selvalue = "dasf";
            // string[] strlst = selvalue.Split(',');
            // selvalue = strlst[0];

            //string organname = LoginInfoShare.getInstance().OrganName;

            foreach (DevComponents.AdvTree.Node nd in cbtOrgan.Nodes)
            {
                foreach (DevComponents.AdvTree.Node nd1 in nd.Nodes)
                {
                    if (selvalue == nd1.Text)
                    {
                        cbtOrgan.SelectedNode = nd1;

                    }
                }
            }

        }


        protected override void DoworkInBack(object sender, DoWorkEventArgs e)
        {
            StartCheck();
            LoadOrgans(cbtOrgan, false);



            //mIOrgan.AssginToConnString();


        }





        protected override void DoBackatCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Text = "登录";
            btnLogin.Enabled = true;
            SetOrganSelected();

            //if (MainWindowState.getInstance().IsPersonConneted)
            //{
            //    cbtOrgan.Visible = true;
            //    txtOrgan.Visible = false;
            //}
            //else
            //{
            //    cbtOrgan.Visible = false;
            //    txtOrgan.Visible = true;
            //    XmlConfig xc = new XmlConfig();


            //    string[] strlst = xc.GetConfigValue("selorgan").Split(',');
            //    //selvalue = strlst[0];
            //    txtOrgan.Text = strlst[0];
            //}

        }


        private void StartCheck()
        {

            bool isP = ServerCheckBll.IsPersonConnected();
            bool isV = ServerCheckBll.IsVipConnected();
            this.BeginInvoke((MethodInvoker)delegate()
            {
                MainWindowState.getInstance().IsPersonConneted = isP;
                MainWindowState.getInstance().IsVipConnected = isV;


            });

        }
        private void lblUpdate_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
