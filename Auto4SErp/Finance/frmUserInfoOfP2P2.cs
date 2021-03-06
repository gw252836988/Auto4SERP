﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.P2P;
using Bll;
using Model;
using System.Collections;
namespace Auto4SErp
{
    public partial class frmUserInfoOfP2P2 : ifrmBase
    {

        private string mOperateCode = "";
        private P2PUserInfo mP2PInfo;
        private double p2PJE = 0;
        private IFinance mIFinance;
        private string p2PMobile;

        public string P2PMobile
        {
            get { return p2PMobile; }
            set { p2PMobile = value; }
        }
        public double P2PJE
        {
            get { return p2PJE; }
            set { p2PJE = value; }
        }

        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }


        public frmUserInfoOfP2P2()
        {
            InitializeComponent();
            mIFinance = Bll.BllFactory.GetFinanceBll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMobile.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                ShowMessage("手机或密码输入不能为空");
                return;
            }

            P2PGetUserInfoTask2 task = new P2PGetUserInfoTask2();
            Hashtable ht = new Hashtable();
            ht.Add("mobile", txtMobile.Text);
            ht.Add("paypassword", txtPassword.Text);
            task.HtPara = ht;
            task.ECompelete += new WebTask.CompeleteDelegate(OnComplete);
            task.StartTaskSingle();
        }

        private void OnComplete(object o)
        {
            DataTable dt = (DataTable)o;
            DataRow dr = dt.Rows[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                this.BeginInvoke((MethodInvoker)delegate()
                {
                    if (dr["status"].ToString().Trim() == "1")
                    {
                        mP2PInfo = new P2PUserInfo();

                        this.txtName.Text = dr["realname"].ToString(); ;
                        this.txtAccount.Text = dr["username"].ToString();

                        this.txtLevel.Text = dr["level"].ToString();
                        txtBalance.Text = dr["carbao"].ToString();
                        mOperateCode = dr["opera"].ToString();

                        mP2PInfo.REALNAME = txtName.Text;
                        mP2PInfo.Amount = p2PJE;


                        btnValidate.Enabled = true;
                        btnLogin.Enabled = false;
                        txtMobile.ReadOnly = true;
                        txtPassword.ReadOnly = true;

                    }
                    else
                        ShowMessage("密码错误或其它网络故障");
                });
            }

        }




        private void OnPostComplete(object o)
        {
            string strresult = o.ToString();

            this.BeginInvoke((MethodInvoker)delegate()
            {
                if (strresult != "提交信息失败")
                {
                    txtValidateCode.Enabled = true;
                    btnRec.Enabled = true;
                    btnValidate.Enabled = false;
                }
                else
                    ShowMessage("提交失败");
            });

        }

        private void frmUserInfoOfP2P2_Load(object sender, EventArgs e)
        {
            dbiJE.Value = p2PJE;
            this.DialogResult = DialogResult.None;
            txtMobile.Text = p2PMobile;
            txtMobile.Focus();

        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValidateCode.Text))
            {
                ShowMessage("请输入验证码");
                return;

            }
            btnRec.Enabled = false;
            P2PDeductCostTask2 task = new P2PDeductCostTask2();
            Hashtable ht = new Hashtable();
            ht.Add("opera", mOperateCode);
            ht.Add("rdCode", txtValidateCode.Text);

            task.HtPara = ht;
            task.ECompelete += new WebTask.CompeleteDelegate(OnDeductComplete);
            task.StartTaskSingle();
        }

        private void OnDeductComplete(object o)
        {
            string strresult = o.ToString();

            this.BeginInvoke((MethodInvoker)delegate()
            {
                if (strresult == "扣费失败")
                {
                    txtValidateCode.Text = "";
                    ShowMessage("扣费失败");

                }
                else
                {
                    mP2PInfo.MobilePhone = txtMobile.Text;
                    mP2PInfo.DHFrom = dH;
                    //收款单位

                    mP2PInfo.RecvUnit = "新城集团";
                    mP2PInfo.PayType = "购车宝";
                    mIFinance.AddP2PInfo(mP2PInfo);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            });


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //double tmpJE = dbiJE.Value;
            double tmpJEOfP2P = double.Parse(txtBalance.Text);
            if (p2PJE > tmpJEOfP2P)
            {

                ShowMessage("余额不足");
                return;

            }

            P2PPostCostTask2 task = new P2PPostCostTask2();
            Hashtable ht = new Hashtable();
            ht.Add("val", p2PJE.ToString());
            ht.Add("opera", mOperateCode);
            task.HtPara = ht;
            task.ECompelete += new WebTask.CompeleteDelegate(OnPostComplete);
            task.StartTaskSingle();
        }
    }
}
