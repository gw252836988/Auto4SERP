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
using Model;
using System.Data.SqlClient;
using Bll.Sale;
using Bll.Repair;
using Bll.P2P;
using Comm;
using Auto4SErp.Finance;

namespace Auto4SErp
{
    public partial class frmAccountAccept : ifrmBase
    {
        private IFinance mIFinance;
        private ICarSale mICarSale;
        private IRepair mIRepair;
        private IVip mIVip;
        private ICustomer mICustomer;
        private IP2P mIP2P;
        private double amountReceivable = 0;
        private double amountQuan;
        private double jegsofOffset;
        private double jeyqofOffset;
        private double jezhofOffset;
        private double jeaccofOffset;
        private double mBalance;
        private int iD = 0;
        private string mobile;
        private Customer mCustomer;
        private bool isSC = false;
        private double mCarPrice = 0;
        private List<string> mlstQuanID;
        private string mGSQuanID = "";
        private string mYQQuanID = "";
        private string mZHQuanID = "";
        private string mAccQuanID = "";
        private string mP2PMobile = "";
        public bool IsSC
        {
            get { return isSC; }
            set { isSC = value; }
        }
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public Account mAccount = null;

        public frmAccountAccept()
        {
            InitializeComponent();
            mIFinance = BllFactory.GetFinanceBll();
            mICarSale = BllFactory.GetCarSaleBll();
            mIRepair = BllFactory.GetRepariBll();
            mIVip = BllFactory.GetVipBll();
            mIP2P = BllFactory.GetP2PBll();
            mICustomer = BllFactory.GetCustomerBll();
            mlstQuanID = new List<string>();
        }

        private void frmAccountAccept_Load(object sender, EventArgs e)
        {
            dbiBank.ValueChanged += new EventHandler(this.AmountValueChanged);
            dbiCash.ValueChanged += new EventHandler(this.AmountValueChanged);
            dbiVip.ValueChanged += new EventHandler(this.AmountValueChanged);
            dbiP2P.ValueChanged += new EventHandler(this.AmountValueChanged);
            dbiSC.ValueChanged += new EventHandler(this.AmountValueChanged);
            dbiPreRecv.ValueChanged += new EventHandler(this.AmountValueChanged);
            dbiCheck.ValueChanged += new EventHandler(this.AmountValueChanged);
            dbiOther.ValueChanged += new EventHandler(this.AmountValueChanged);
            dbiSelf.ValueChanged += new EventHandler(this.AmountValueChanged);
            dbiIntegral.ValueChanged += new EventHandler(this.AmountValueChanged);
            cmbInvoiceType.SelectedIndex = 0;
            if (iD > 0)
            {
                mAccount = mIFinance.GetAmountByID(iD);
                if (mAccount.Status != 0) tbtnOK.Enabled = false;
                amountReceivable = mAccount.Amount;
                mBalance = 0 - amountReceivable;
                txtPlateNum.Text = mAccount.PlateNum;
                dbiCash.Value = mAccount.Cash;
                dbiBank.Value = mAccount.Bank;
                dbiVip.Value = mAccount.Vip;
                dbiP2P.Value = mAccount.P2P;
                dbiSC.Value = mAccount.Cs;
                dbiCheck.Value = mAccount.Check;
                dbiPreRecv.Value = mAccount.PreRecv;
                dbiOther.Value = mAccount.Other;
                dbiQuan.Value = mAccount.Quan;
                dbiSelf.Value = mAccount.Self;
                dbiIntegral.Value = mAccount.Integral;
                txtRemark.Text = mAccount.Remark;
                cmbInvoiceType.Text = mAccount.InvoiceType;
                txtInvoiceNum.Text = mAccount.InvoiceNum;
                dbiInvoiceAmount.Value = mAccount.InvoiceAmount;
                txtCustName.Text = mAccount.CustName;


                mCustomer = mICustomer.GetCustomerByMobile(mobile);
                if (!string.IsNullOrEmpty(mobile) && mCustomer != null)
                {
                    txtCustName.Text = mCustomer.CustName;
                    txtMobile.Text = mobile;
                    mP2PMobile = mCustomer.P2PMobile;
                    lblP2PMobile.Text = "P2P绑定号码:" + mP2PMobile;
                    if (!string.IsNullOrEmpty(mCustomer.CardNo))
                    {
                        txtCardNo.Text = mCustomer.CardNo;
                        VipInfo objVip = mIVip.GetVipInfoByCardID(mCustomer.CardNo);
                        if (objVip != null)
                        {
                            lblVipBalance.Text = objVip.Balance.ToString();
                            lblVipType.Text = objVip.MemberLevel;
                            if (lblVipType.Text == "油漆基金")
                                lblelse.Text = "使用油漆基金按50%金额开票";
                            else if (lblVipType.Text == "保养基金")
                                lblelse.Text = "使用保养基金按80%金额开票";
                        }

                    }
                }


                if (mAccount.Describes == "销售收款" || mAccount.Describes == "售后")
                {


                    pnmMiddle.Visible = true;
                    this.Height = 607;
                    DataTable dt;
                    if (mAccount.Describes == "销售收款")
                    {
                        dt = mICarSale.GetCarSaleByDH(mAccount.DHFrom);
                        txtCarPrice.Text = Comm.ElseUtil.ReturnZero(dt.Rows[0]["CarPrice"].ToString());
                        mCarPrice = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["CarPrice"].ToString()));
                        txtOutFee.Text = Comm.ElseUtil.ReturnZero(dt.Rows[0]["OutFee"].ToString());
                        txtChangeIncome.Text = Comm.ElseUtil.ReturnZero(dt.Rows[0]["ChangeIncome"].ToString());
                        txtElseIncome.Text = Comm.ElseUtil.ReturnZero(dt.Rows[0]["ElseIncome"].ToString());
                        txtPlateFee.Text = Comm.ElseUtil.ReturnZero(dt.Rows[0]["PlateFee"].ToString());
                        txtTotalPrice.Text = dt.Rows[0]["TotalPrice"].ToString();
                        txtOrderReceive.Text = dt.Rows[0]["OrderReceive"].ToString();
                        txtLoanAmount.Text = dt.Rows[0]["LoanAmount"].ToString();
                        dbiPureCarPrice.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["PureCarPrice"].ToString()));
                        dbiPresentDecorPrice.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["PresentDecorPrice"].ToString()));
                        gbSale.Visible = true;
                        gbRep.Visible = false;
                    }
                    else
                    {

                        //if (!string.IsNullOrEmpty(mP2PMobile))
                        //{
                        RepairM repobj = mIRepair.GetRepairByDH(mAccount.DHFrom);

                        //DataTable p2pDt = mIP2P.GetQuansOfCustomer(mP2PMobile);
                        //for (int i = 0; i < p2pDt.Rows.Count; i++)
                        //{
                        //    cmbMyQuan.Items.Add(string.Format("{0} {1} {2} {3}", p2pDt.Rows[i]["id"].ToString(), p2pDt.Rows[i]["typeid"].ToString(), p2pDt.Rows[i]["type"].ToString(), p2pDt.Rows[i]["money"].ToString()));

                        //}

                        //var result=p2pDt.AsEnumerable().Where(r => r[1].ToString() == "工时券");
                        //if (result.Count() > 0)
                        //    txtQuanGS.Text = result.First()[0].ToString();
                        //result = p2pDt.AsEnumerable().Where(r => r[1].ToString() == "油漆券");
                        //if (result.Count() > 0)
                        //    txtQuanYQ.Text = result.First()[0].ToString();
                        //result = p2pDt.AsEnumerable().Where(r => r[1].ToString() == "装潢券");

                        if (repobj != null)
                        {
                            lblGgs.Text = string.Format("工时金额:{0}", repobj.PreItemAmount);
                            lblAccJe.Text = string.Format("{0}", repobj.PreAccessoryAmount);

                        }

                        if (repobj.RepChildType.Contains("装潢"))
                        {
                            lblZH.Text = mIRepair.GetRepairByDH(mAccount.DHFrom).GAmount.ToString();
                        }
                        else
                        {
                            lblYQ.Text = mIRepair.GetJeOfYQ(mAccount.DHFrom).ToString();
                            lblGS.Text = mIRepair.GetJeOfGS(mAccount.DHFrom).ToString();
                        }

                        gbSale.Visible = false;
                        gbRep.Visible = true;

                    }
                    //}

                }
                else
                {
                    pnmMiddle.Visible = false;
                    this.Height = 431;

                }
            }

            lblAmountRV.Text = amountReceivable.ToString();
            SetTButtonPng(toolStrip1);


            lblPreRecvB.Text = string.Format("预收款余额:{0}", mIFinance.GetPreRecv(txtMobile.Text, txtCustName.Text));


            if (isSC == true)
                dbiSC.Enabled = false;
            
        }

        private void AmountValueChanged(object sender, EventArgs e)
        {

            AmountChanged();
        }

        private void AmountChanged()
        {
            mBalance = amountReceivable - dbiBank.Value - dbiCash.Value - dbiVip.Value - dbiP2P.Value - dbiSC.Value - dbiPreRecv.Value - dbiOther.Value - dbiCheck.Value - dbiSelf.Value - dbiQuan.Value - dbiIntegral.Value;
            mBalance = Math.Round(mBalance, 2);
            lblBalanceV.Text = mBalance.ToString();
            // dbiQuan.Value = .;

        }




        private string DeductPreRecv(Account obj)
        {
            string msg = "";
            if (!mIFinance.DeductPreRecv(txtMobile.Text, txtCustName.Text, obj.PreRecv))
            {
                msg = "预收款余额不足";
            }

            return msg;

        }


        private string DeductVip(Account obj)
        {

            string msg = "";
            if (string.IsNullOrEmpty(txtCardNo.Text))
            {

                return "没有绑定会员卡号，请在客户管理中升级会员";


            }
            double balance = double.Parse(lblVipBalance.Text);
            if (obj.Vip > balance)
            {
                return ("余额不足，无法用会员卡支付");

            }

            frmDlgVipPwd frm = new frmDlgVipPwd();
            bool IsValidate = false;
            frm.setTransferDelegate(delegate(object o)
            {
                string pwd = (string)o;

                IsValidate = mIVip.IsValidateByPwd(txtCardNo.Text.Trim(), pwd);

            });
            frm.ShowDialogEx();

            if (IsValidate == false)
            {
                return ("密码不正确");

            }

            if (mIVip.IsBalanceEnough(obj.Vip, txtCardNo.Text))
            {
                mIVip.VipAccept(txtCardNo.Text, obj.Vip, "", "[储值扣费]", LoginInfoShare.getInstance().UserName, LoginInfoShare.getInstance().OrganName, obj.DHFrom);

            }
            else
            {
                return ("会员余额不足");

            }

            return msg;

        }


        private string DeductP2P(Account obj)
        {
            string msg = "";
            double tmp = obj.P2P;
            if ((int)tmp != tmp)
            {
                return ("P2P扣款金额不能有小数");


            }

            if (obj.Describes.Contains("销售订金"))
            {

                frmUserInfoOfP2P2 frm1 = new frmUserInfoOfP2P2();
                frm1.DH = obj.DHFrom;
                frm1.P2PJE = obj.P2P;
                frm1.P2PMobile = mCustomer.P2PMobile;
                frm1.ShowDialogEx();

                if (DialogResult.OK != frm1.DialogResult)
                {
                    return ("P2P收款不成功");


                }

            }
            else
            {
                frmUserInfoOfP2P frm2 = new frmUserInfoOfP2P();
                frm2.DH = obj.DHFrom;
                frm2.P2PJE = obj.P2P;
                frm2.P2PMobile = mCustomer.P2PMobile;
                frm2.ShowDialogEx();
                if (DialogResult.OK != frm2.DialogResult)
                {
                    return ("P2P收款不成功");


                }

            }
            return msg;

        }



        private string GetIDOfQuanType(string typename)
        {
            string typeid = "";
            switch (typename)
            {
                case "工时券":
                    typeid = "2";
                    break;
                case "油漆券":
                    typeid = "8";
                    break;
                case "装潢券":
                    typeid = "12";
                    break;
                default:
                    typeid = "0";
                    break;

            }
            return typeid;

        }

        private string QuanConduct()
        {

            //double p2pOfyq = double.Parse(txtQuanYQ.Text);
            //double p2pOfzh = double.Parse(txtQuanZH.Text);
            //double p2pOfgs = double.Parse(txtQuanGS.Text);

            //double jeofyq = double.Parse(txtYQ.Text);
            //double jeofzh = double.Parse(txtZH.Text);
            //double jeofgs = double.Parse(txtGS.Text);
            string str = "";
            //string gsid = "0";
            //string yqid = "0";
            //string zhid = "0";

            //if (p2pOfgs > 0)
            //{
            //    if ((gsid = mIP2P.GetIDOfQuan(GetIDOfQuanType("工时券"), 0, "13962852128")) == "0")
            //    {
            //        str = "工时券";
            //    }
            //}

            //if (p2pOfyq > 0)
            //{
            //    if ((yqid = mIP2P.GetIDOfQuan(GetIDOfQuanType("油漆券"), 0, "13962852128")) == "0")
            //    {
            //        str = "油漆券";
            //    }
            //}

            //if (p2pOfzh > 0)
            //{
            //    if ((zhid = mIP2P.GetIDOfQuan(GetIDOfQuanType("装潢券"), 0, "13962852128")) == "0")
            //    {
            //        str = "装潢券";
            //    }
            //}
            str = mIP2P.ConductQuan(mlstQuanID);

            P2PUserInfo info = new P2PUserInfo();
            info.DHFrom = mAccount.DHFrom;
            info.MobilePhone = txtMobile.Text;
            info.REALNAME = txtCustName.Text;
            info.RecvUnit = "新城集团";

            if (string.IsNullOrEmpty(str))
            {
                if (jegsofOffset > 0)
                {
                    //mIP2P.ConductQuan(gsid);
                    info.PayType = "工时券";
                    info.Amount = jegsofOffset;
                    info.Append = mGSQuanID;
                    mIFinance.AddP2PInfo(info);


                }
                if (jezhofOffset > 0)
                {
                    // mIP2P.ConductQuan(zhid);
                    info.PayType = "装潢券";
                    info.Amount = jezhofOffset;
                    info.Append = mZHQuanID;
                    mIFinance.AddP2PInfo(info);

                }
                if (jeyqofOffset > 0)
                {
                    // mIP2P.ConductQuan(zhid);
                    info.PayType = "油漆券";
                    info.Amount = jeyqofOffset;
                    info.Append = mYQQuanID;
                    mIFinance.AddP2PInfo(info);
                }
                if (jeaccofOffset > 0)
                {
                    info.PayType = "抵用材料券";
                    info.Amount = jeaccofOffset;
                    info.Append = mAccQuanID;
                    mIFinance.AddP2PInfo(info);

                }
            }
            return str;

        }

        private void tbtnOK_Click(object sender, EventArgs e)
        {

            //确认状态
            string tiperror = "";
            if (mBalance == 0)
            {
                Account obj = new Account();
                obj.ID = iD;
                obj.Cash = dbiCash.Value;
                obj.Vip = dbiVip.Value;
                obj.Bank = dbiBank.Value;
                obj.P2P = dbiP2P.Value;
                obj.Cs = dbiSC.Value;
                obj.PreRecv = dbiPreRecv.Value;
                obj.Other = dbiOther.Value;
                obj.Check = dbiCheck.Value;
                obj.Self = dbiSelf.Value;
                obj.Integral = dbiIntegral.Value;

                obj.Quan = dbiQuan.Value;
                obj.InvoiceAmount = dbiInvoiceAmount.Value;
                obj.InvoiceNum = txtInvoiceNum.Text;
                obj.InvoiceType = cmbInvoiceType.Text;
                obj.Describes = mAccount.Describes;
                obj.DHFrom = mAccount.DHFrom;
                obj.Amount = amountReceivable;
                obj.ReceiveMan = LoginInfoShare.getInstance().UserName;
                obj.Remark = txtRemark.Text;
                //  obj.RecAmount = amountReceivable;
                obj.RecAmount = amountReceivable - obj.Other - obj.PreRecv - obj.Cs;


                if (mAccount.Describes == "售后")
                {

                    RepairM model = mIRepair.GetRepairByDH(obj.DHFrom);
                    if (model.Status != 2)
                    {
                        ShowMessage("状态不对，无法收款");

                        return;
                    }



                }

                try
                {
                    if (mAccount.Describes == "销售订金")
                    {
                        if (!mICarSale.IsExistCarSaleInOrder(obj.DHFrom))
                        {
                            ShowMessage("已开销售单，无法收销售订金");
                            return;
                        }

                    }

                    if (obj.PreRecv > 0)
                    {
                        tiperror = DeductPreRecv(obj);
                        if (!string.IsNullOrEmpty(tiperror))
                        {
                            ShowMessage(string.Format("优惠券抵用失败，可能是{0}号券过期或已使用", tiperror));
                            return;
                        }

                    }


                    //if (dbiQuan.Value > 0)
                    //{
                  //  tiperror = QuanConduct();
                    //    if (!string.IsNullOrEmpty(tiperror))
                    //    {
                    //        ShowMessage(tiperror + "无法扣除");
                    //        return;
                    //    }

                    //}

                    //Vip会员收款
                    if (obj.Vip > 0)
                    {
                        tiperror = DeductVip(obj);
                        if (!string.IsNullOrEmpty(tiperror))
                        {
                            ShowMessage(tiperror);
                            return;
                        }
                    }

                    //P2P收款
                    if (obj.P2P > 0)
                    {
                        tiperror = DeductP2P(obj);
                        if (!string.IsNullOrEmpty(tiperror))
                        {
                            ShowMessage(tiperror);
                            return;
                        }


                    }
                    if (obj.Cs > 0)
                    {

                        // obj.RecAmount = amountReceivable - obj.Cs;
                        //mIFinance.AddAmount();
                        mAccount.Amount = obj.Cs;
                        mAccount.Describes = "赊销回款";
                        mAccount.CustName = txtCustName.Text;
                        mAccount.Mobile = txtMobile.Text;
                        mIFinance.AddAmount(mAccount);
                    }




                    //需优化
                    mIFinance.AcceptAmount(obj);
                    // UpdateBill();
                    //ShowMessage("收款成功");

                    if (obj.Vip > 0)
                    {
                        double tmpbalance = double.Parse(lblVipBalance.Text);
                        VipPrint(obj.DHFrom, amountReceivable.ToString(), (tmpbalance - obj.Vip).ToString(), "", "会员卡支付");

                    }
                    if (obj.P2P > 0)
                    {

                        VipPrint(obj.DHFrom, amountReceivable.ToString(), "P2P请网上查询", "", "P2P支付");
                    }
                    //if (obj.Quan > 0)
                    //{

                    //    VipPrint(obj.DHFrom, amountReceivable.ToString(), "P2P请网上查询", "", "抵用券支付");
                    //}


                    IsModify = true;
                    if (mAccount.Describes == "销售收款")
                    {
                        mICarSale.UpdateCarPurePrice(mAccount.DHFrom.Trim(), dbiPureCarPrice.Value, dbiPresentDecorPrice.Value);

                    }


                    this.Close();


                }
                catch (SqlException ex)
                {
                    ShowMessage("收款出现错误");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                ShowMessage("输入的金额不对,必须等于应收金额");
            }
        }





        private void UpdateBill()
        {
            string billDescribe = mAccount.Describes;
            if (billDescribe == "销售订金")
            {
                mICarSale.UpdateCarOrderReceive(amountReceivable, mAccount.DHFrom);
            }
            else if (billDescribe == "销售收款")
            {

                mICarSale.UpdateCarSaleReceive(amountReceivable, mAccount.DHFrom);
            }
            else if (billDescribe == "售后维修")
            {
                RepairM obj = new RepairM();
                obj.DH = mAccount.DHFrom;
                obj.Status = 3;
                mIRepair.SetRepStatus(obj);

            }

        }

        private void cmbInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInvoiceType.SelectedIndex == 0)
            {
                txtInvoiceNum.Enabled = false;
                dbiInvoiceAmount.Enabled = false;
            }
            else
            {
                txtInvoiceNum.Enabled = true;
                dbiInvoiceAmount.Enabled = true;

            }
        }

        private void btnPreRecv_Click(object sender, EventArgs e)
        {
            frmDlgPreRecv frm = new frmDlgPreRecv();
            frm.Mobile = txtMobile.Text;
            frm.Custname = txtCustName.Text;
            frm.ShowDialogEx();
        }

        private void VipPrint(string dh, string amountvip, string balance, string acceptdate, string type)
        {
            //DataTable dtAppend = new DataTable();

            //dtAppend.Columns.Add("DH", typeof(string));
            //dtAppend.Columns.Add("AmountRecv", typeof(string));
            //dtAppend.Columns.Add("AmountVip", typeof(string));
            //dtAppend.Columns.Add("OrganName", typeof(string));
            //dtAppend.Columns.Add("VipNo", typeof(string));
            //dtAppend.Columns.Add("VipBalance", typeof(string));
            //dtAppend.Columns.Add("ConductDate", typeof(string));
            //dtAppend.Columns.Add("Cash", typeof(string));
            //dtAppend.Columns.Add("Bank", typeof(string));


            //DataRow dr = dtAppend.NewRow();
            //dr[0] = dh;
            //dr[1] = lblAmountRV.Text;
            //dr[2] = (dbiVip.Value+dbiP2P.Value).ToString();
            //dr[3] = Comm.LoginInfoShare.getInstance().OrganName;
            //dr[4] = txtCardNo.Text;
            //dr[5] = balance;
            //dr[7] = dbiCash.Value.ToString();
            //dr[8] = dbiBank.Value.ToString();
            //if (string.IsNullOrEmpty(acceptdate))
            //    dr[6] = DateTime.Now.ToString();
            //else
            //    dr[6] = acceptdate;

            //dtAppend.Rows.Add(dr);

            //Dictionary<string, DataTable> dic = new Dictionary<string, DataTable>();
            //dic.Add("VipPrint", dtAppend);
            //frmPrint frm = new frmPrint();
            //frm.DicTable = dic;
            //frm.ReportFile = "VipPrint.rdlc";
            //frm.ShowDialog();

            StringBuilder sb = new StringBuilder();
            string conductdate;
            sb.Append("             南通新城集团    \n");
            sb.Append("\n");
            sb.Append("单号:" + dh + "\n");
            sb.Append("门店:" + Comm.LoginInfoShare.getInstance().OrganName + "\n");
            sb.Append("-------------------------------------------\n");
            sb.Append("应付金额:" + lblAmountRV.Text + "\n");
            sb.Append(type + ":" + (dbiVip.Value + dbiP2P.Value).ToString() + "\n");
            sb.Append("优惠券:" + dbiQuan.Value.ToString() + "\n");

            sb.Append("现金:" + dbiCash.Value.ToString() + "\n");
            sb.Append("银行卡:" + dbiBank.Value.ToString() + "\n");
            sb.Append("-------------------------------------------\n");
            if (type == "会员卡支付")
            {
                sb.Append("会员卡号:" + txtCardNo.Text + "\n");
                sb.Append("余额:" + balance + "\n");
            }

            if (string.IsNullOrEmpty(acceptdate))
                conductdate = DateTime.Now.ToString();
            else
                conductdate = acceptdate;
            sb.Append("扣费日期:" + conductdate + "\n");
            sb.Append("服务热线：968895\n");
            sb.Append("       谢谢惠顾欢迎下次光临       \n");
            sb.Append("欢迎访问新城汽车网:\n");
            sb.Append("www.xinchengauto.com       \n");
            sb.Append("在线咨询、投诉、预约各项服务！      \n");

            SmallPrint sp = new SmallPrint();
            sp.PrintContent = sb.ToString();
            sp.Print();
        }

        private void btnVipConsume_Click(object sender, EventArgs e)
        {

            VipPrint(mAccount.DHFrom, mAccount.Vip.ToString(), lblVipBalance.Text, mAccount.AcceptDate, "会员卡支付");
        }

        private void p2PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VipPrint(mAccount.DHFrom, amountReceivable.ToString(), "P2P请网上查询", mAccount.AcceptDate, "P2P支付");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pnmMiddle.Visible = false;
            this.Height = 431;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pnmMiddle.Visible = true;
            this.Height = 607;
        }

        private void dbiPureCarPrice_ValueChanged(object sender, EventArgs e)
        {
            //dbiPresentDecorPrice.Value = mCarPrice - dbiPureCarPrice.Value;
        }

        private void dbiPresentDecorPrice_ValueChanged(object sender, EventArgs e)
        {
            dbiPureCarPrice.Value = mCarPrice - dbiPresentDecorPrice.Value;
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            mIFinance.UpdateInvoice(iD, cmbInvoiceType.Text, txtInvoiceNum.Text, dbiInvoiceAmount.Value);
            if (mAccount.Describes == "销售收款")
            {
                mICarSale.UpdateCarPurePrice(mAccount.DHFrom.Trim(), dbiPureCarPrice.Value, dbiPresentDecorPrice.Value);

            }
            ShowMessage("补登数据成功");
            IsModify = true;
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        //private void cbbQuan_CheckValueChanged(object sender, EventArgs e)
        //{
        //    if (chbQuan.Checked)
        //    {
        //        CaculateQuan();
        //        AmountChanged();
        //        lblQuan.Text = "优惠券金额:" + amountQuan;
        //    }
        //    else
        //    {
        //        amountQuan = 0;
        //        jegsofOffset = 0;
        //        jeyqofOffset = 0;
        //        jezhofOffet = 0;
        //        AmountChanged();
        //        lblQuan.Text = "优惠券金额:0";
        //    }
        //}

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }




        private void btnUse_Click(object sender, EventArgs e)
        {
            string quanitem = cmbMyQuan.Text;
            int index = cmbMyQuan.SelectedIndex;
            if (!string.IsNullOrEmpty(quanitem))
            {
                double jeofyq = double.Parse(lblYQ.Text);
                double jeofzh = double.Parse(lblZH.Text);
                double jeofgs = double.Parse(lblGS.Text);
                double jeofacc = double.Parse(lblAccJe.Text);

                string[] strlst = quanitem.Split(' ');
                string typeid = strlst[1];
                double jequan = double.Parse(strlst[3]);

                //油漆
                if (typeid == "8" || typeid == "13")
                {
                    if (jeofyq > 0 && jeofyq > jeyqofOffset)
                    {

                        if (jeofyq > jequan)
                        {
                            amountQuan = amountQuan + jequan;
                            jeyqofOffset += jequan;
                        }
                        else
                        {
                            amountQuan = amountQuan + jeofyq;
                            jeyqofOffset += jeofyq;
                        }
                        // dbiQuan.Value =dbiQuan.Value +jeyqofOffset;
                        lblYQJ.Text = "(-" + jeyqofOffset.ToString() + ")";
                        mYQQuanID = mYQQuanID + " " + strlst[0];
                        mlstQuanID.Add(strlst[0]);
                        //cmbMyQuan.Items.RemoveAt(index);

                    }
                }
                //工时
                if (typeid == "2" || typeid == "9" || typeid == "14" || typeid == "10")
                {

                    if (jeofgs > 0 && jeofgs > jegsofOffset)
                    {
                        double tmpgs = jeofgs - jegsofOffset;
                        if (tmpgs > jequan)
                        {
                            amountQuan = amountQuan + jequan;
                            jegsofOffset += jequan;
                        }
                        else
                        {
                            amountQuan = amountQuan + jeofgs;
                            jegsofOffset += tmpgs;

                        }
                        if (typeid == "14")
                            jequan = jequan - tmpgs;

                        // dbiQuan.Value = dbiQuan.Value + jegsofOffset;
                        lblGSJ.Text = "(-" + jegsofOffset.ToString() + ")";
                        mGSQuanID = mGSQuanID + " " + strlst[0];
                        mlstQuanID.Add(strlst[0]);

                        //cmbMyQuan.Items.RemoveAt(index);
                    }
                }

                if (typeid == "14")
                {
                    if (jequan <= 0)
                    {
                        dbiQuan.Value = jeaccofOffset + jeyqofOffset + jezhofOffset + jegsofOffset;
                        AmountChanged();
                        return;
                    }
                    if (jeofacc > 0 && jeofacc > jeaccofOffset)
                    {

                        double tmpacc = jeofacc - jeaccofOffset;
                        if (tmpacc > jequan)
                        {
                            amountQuan = amountQuan + jequan;
                            jeaccofOffset += jequan;
                        }
                        else
                        {
                            amountQuan = amountQuan + jeofacc;
                            jeaccofOffset += jeofacc;
                        }

                        //     dbiQuan.Value = dbiQuan.Value + jeaccofOffset;
                        lblAccJ.Text = "(-" + jeaccofOffset.ToString() + ")";
                        mAccQuanID = mAccQuanID + " " + strlst[0];

                        //if (cmbMyQuan.Items.Contains(quanitem))
                        //    cmbMyQuan.Items.RemoveAt(index);

                        mlstQuanID.Add(strlst[0]);

                    }
                }

                //装潢
                if (typeid == "12")
                {

                    if (jeofzh > 0 && jezhofOffset == 0)
                    {

                        if (jeofzh > jequan)
                        {
                            amountQuan = amountQuan + jequan;
                            jezhofOffset = jequan;
                        }
                        else
                        {
                            amountQuan = amountQuan + jeofzh;
                            jezhofOffset = jeofzh;
                        }
                        // dbiQuan.Value = dbiQuan.Value + jezhofOffset;
                        lblZHJ.Text = "(-" + jezhofOffset.ToString() + ")";
                        mZHQuanID = strlst[0];
                     //   cmbMyQuan.Items.RemoveAt(index);
                        mlstQuanID.Add(strlst[0]);
                    }
                    // dbiQuan.Value = amountQuan;
                }


                dbiQuan.Value = jeaccofOffset + jeyqofOffset + jezhofOffset + jegsofOffset;
                AmountChanged();

            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            frmVipDepositRecord frm = new frmVipDepositRecord();
            frm.CardID = txtCardNo.Text;
            frm.ShowDialogEx();
        }

        private void gbRep_Enter(object sender, EventArgs e)
        {

        }

    }
}
