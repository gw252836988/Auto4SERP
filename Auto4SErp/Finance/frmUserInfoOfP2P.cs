using System;
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
    public partial class frmUserInfoOfP2P : ifrmBase
    {


        private double p2PJE = 0.2;
        private string mOperateCode = "";
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


        private P2PUserInfo mP2PInfo;
        private IFinance mIFinance;

        public frmUserInfoOfP2P()
        {
            InitializeComponent();
            mIFinance = Bll.BllFactory.GetFinanceBll();
        }

        private void frmUserInfoOfP2P_Load(object sender, EventArgs e)
        {
            //P2PGetUserInfoTask task = new P2PGetUserInfoTask();
            //Hashtable ht = new Hashtable();
            //ht.Add("phone", "13962852128");
            //ht.Add("callBack", "doit");
            //task.HtPara = ht;
            //task.ECompelete += new WebTask.CompeleteDelegate(OnComplete);
            //task.StartTaskSingle();
            lblJEMust.Text = p2PJE.ToString();
            txtMobile.Text = p2PMobile;
            txtMobile.Focus();

        }

        private void OnComplete(object o)
        {
            P2PUserInfo info = (P2PUserInfo)o;

            this.BeginInvoke((MethodInvoker)delegate()
            {
                this.txtName.Text = info.REALNAME;
                this.txtAccount.Text = info.USERNAME;
                this.txtPhone.Text = info.MobilePhone;
                this.txtLevel.Text = info.Value;
                this.txtBalance.Text = info.Use_money.ToString();
                this.txtXCMoney.Text = info.Integral.ToString();
                mOperateCode = info.OperateCode;
                btnValidate.Enabled = true;
                btnLogin.Enabled = false;
                mP2PInfo = new P2PUserInfo();
                mP2PInfo.REALNAME = info.REALNAME;
                mP2PInfo.Amount = p2PJE;

            });

            // this.txtStatus.Text = info.Status;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {


        }

        private void OnPostComplete(object o)
        {
            string strresult = o.ToString();

            if (string.IsNullOrEmpty(strresult))
            {
                ShowMessage("信息返回错误");
                return;

            }
            this.BeginInvoke((MethodInvoker)delegate()
           {
               if (strresult == "提交成功")
               {
                   txtValidateCode.ReadOnly = false;
                   btnRec.Enabled = true;
                   btnValidate.Enabled = false;
                   btnLogin.Enabled = false;
               }
               else
                   ShowMessage("提交失败");
           });

        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValidateCode.Text))
            {
                ShowMessage("请输入验证码");
                return;

            }
            P2PDeductCostTask task = new P2PDeductCostTask();
            Hashtable ht = new Hashtable();



            ht.Add("tra_name", mP2PInfo.REALNAME);
            ht.Add("tra_no", dH);
            ht.Add("rdCode", txtValidateCode.Text);
            ht.Add("opera", mOperateCode);

            task.HtPara = ht;
            task.ECompelete += new WebTask.CompeleteDelegate(OnDeductComplete);
            task.StartTaskSingle();
        }


        private void OnDeductComplete(object o)
        {
            string strresult = o.ToString();

            this.BeginInvoke((MethodInvoker)delegate()
            {
                if (strresult == "提交信息失败")
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
                    mIFinance.AddP2PInfo(mP2PInfo);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            });


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                ShowMessage("手机输入不能为空");
                return;
            }
            try
            {
                P2PGetUserInfoTask task = new P2PGetUserInfoTask();
                Hashtable ht = new Hashtable();
                ht.Add("phone", txtMobile.Text);
                ht.Add("callBack", "doit");
                task.HtPara = ht;
                task.ECompelete += new WebTask.CompeleteDelegate(OnComplete);
                task.StartTaskSingle();

            }
            catch (Exception ex)
            {
                MessageBox.Show("错误:" + ex.Message);

            }

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            double tmpJE = dbiJE.Value;
            double tmpXC = dbiXC.Value;
            double tmpJEOfP2P = double.Parse(txtBalance.Text);
            double tmpXCOfP2P = double.Parse(txtXCMoney.Text);
            if ((tmpJE + tmpXC) != p2PJE)
            {
                ShowMessage("输入的金额与要扣的金额不等");
                return;
            }


            if (tmpJE > tmpJEOfP2P)
            {
                ShowMessage("输入的金额过大");
                return;
            }

            if (tmpXC > tmpXCOfP2P)
            {
                ShowMessage("输入的新城币过大");
                return;
            }

            P2PPostCostTask task = new P2PPostCostTask();
            Hashtable ht = new Hashtable();




            ht.Add("intergralval", tmpXC.ToString());
            ht.Add("val", tmpJE.ToString());
            if (tmpJE > 0 && tmpXC > 0)
            {
                ht.Add("type", "2");
                mP2PInfo.PayType = "余额和新城币";
            }
            else if (tmpXC == 0)
            {
                ht.Add("type", "1");
                mP2PInfo.PayType = "余额";
            }
            else if (tmpJE == 0)
            {
                ht.Add("type", "0");
                mP2PInfo.PayType = "新城币";
            }
            mP2PInfo.Balance = tmpJE;
            mP2PInfo.VirtualMoney = tmpXC;

            ht.Add("callBack", "doit");
            ht.Add("opera", mOperateCode);

            task.HtPara = ht;
            task.ECompelete += new WebTask.CompeleteDelegate(OnPostComplete);
            task.StartTaskSingle();
        }

    }
}
