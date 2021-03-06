﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Bll;
using Model;
using Comm;
using Auto4SErp.Cust;
using Bll.Sale;

namespace Auto4SErp.Sale
{
    public partial class frmCarSale : ifrmBase
    {
        private string mMobile = "";
        //  private int mCarDetailID = 0;
        private ICustomer mICustomer;
        private ICarDoc mICarDoc;
        private ICarSale mICarSale;
        private IFinance mIFinance;
        private DataTable mDicOfCarOrder;
        private string mAutoNumber = "";
        private int mStatus = -1;
        private string dH = "";
        private string mDHOfOrder = "";
        private ICarStock mICarStock;
        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        public frmCarSale()
        {
            mICustomer = BllFactory.GetCustomerBll();
            mICarDoc = BllFactory.GetCarDocBll();
            mICarSale = BllFactory.GetCarSaleBll();
            mIFinance = BllFactory.GetFinanceBll();
            mICarStock = BllFactory.GetCarStockBll();
            InitializeComponent();
        }

        private void SetStatus(int status)
        {
            mStatus = status;
            btnPostPrice.Enabled = false;
            dbiCarPrice.Enabled = false;
            dbiDecorPrice.Enabled = false;
            dbiLoanAmount.Enabled = false;

            //dbiInsurancePrice.Enabled = false;
            //dbiOutFee.Enabled = false;
            //dbiChangeIncome.Enabled = false;
            //dbiLoanIncome.Enabled = false;
            //dbiElseIncome.Enabled = false;
            //cmbInCompany.Enabled = false;
            if (status == -1)
            {
                tDropCheck.Enabled = false;
                //   OrderDropDownButton1.Enabled = false;
            }
            else if (status == 0)//开单阶段
            {
                tDropCheck.Enabled = true;
                mItemPostToCheck.Enabled = true;
                mItemCancelCheck.Enabled = false;
                //  OrderDropDownButton1.Enabled = true;
                tbtnSave.Enabled = false;
                lblStatusText.Text = "开单";
                dbiCarPrice.Enabled = true;

                dbiLoanAmount.Enabled = true;

                //dbiInsurancePrice.Enabled = true;
                //dbiOutFee.Enabled = true;
                //dbiChangeIncome.Enabled = true;
                //dbiLoanIncome.Enabled = true;
                //dbiElseIncome.Enabled = true;
                //cmbInCompany.Enabled = true;
                gbElse.Enabled = true;
            }

            else if (status == 1)//审核阶段
            {
                tDropCheck.Enabled = true;
                mItemPostToCheck.Enabled = false;
                mItemCancelCheck.Enabled = true;


                //OrderDropDownButton1.Enabled = false;
                tbtnSave.Enabled = false;
                lblStatusText.Text = "正在审核";
                gbElse.Enabled = false;

            }
            else if (status == 2)//收款阶段
            {
                tDropCheck.Enabled = false;
                //  OrderDropDownButton1.Enabled = false;
                tbtnSave.Enabled = false;
                btnPostPrice.Enabled = true;
                lblStatusText.Text = "正在结算";
                gbElse.Enabled = false;
            }
            else if (status == 3)//完成
            {
                tDropCheck.Enabled = false;
                // OrderDropDownButton1.Enabled = false;
                tbtnSave.Enabled = false;
                btnPostPrice.Enabled = false;
                lblStatusText.Text = "完成";
                gbElse.Enabled = false;
            }

        }



        private double GetOrderReceive()
        {
            double tmp = double.Parse(txtOrderReceive.Text);
            return tmp;
        }
        private void dbiDecorPrice_ValueChanged(object sender, EventArgs e)
        {
            // dbiTotalPrice.Value = dbiCarPrice.Value ;
            // dbiReceivableAmount.Value = dbiCarPrice.Value - GetOrderReceive() - dbiLoanAmount.Value;
        }



        private void tbtnSave_Click(object sender, EventArgs e)
        {

            if (mMobile == "")
            {
                ShowMessage("请选择客户");
                return;
            }
            if (txtVin.Text == "")
            {
                ShowMessage("请选择车架号");
                return;

            }
            if (string.IsNullOrEmpty(txtSalePrice.Text))
                txtSalePrice.Text = "0";

            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("AutoNumber", mAutoNumber.ToString(), true));
            list.Add(new SqlElement("mobile", mMobile, true));
            list.Add(new SqlElement("CreateDate", "getdate()", false));
            list.Add(new SqlElement("Vin", txtVin.Text, true));
            list.Add(new SqlElement("SaleMan", LoginInfoShare.getInstance().UserName, true));
            list.Add(new SqlElement("DH", "dbo.GetCarSaleDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", false));
            //list.Add(new SqlElement("SalePrice", txtSalePrice.Text, false ));

            list.Add(new SqlElement("CarPrice", dbiCarPrice.Value.ToString(), false));
            list.Add(new SqlElement("OrderDH", mDHOfOrder, true));
            list.Add(new SqlElement("OrderReceive", txtOrderReceive.Text, false));

            txtDH.Text = mICarSale.GetDHOfAddCarSale(list);
            mICarSale.BindCarSaleToOrder(mDHOfOrder, txtDH.Text);
            txtSaleMan.Text = LoginInfoShare.getInstance().UserName;
            SetStatus(0);
            IsModify = true;
            //  FetchOrderAmount(txtMobile.Text);

        }

        private void FetchOrderAmount(string mobile, string dh)
        {
            double je = mICarSale.BindOrderFromSale(mobile, dh);

            txtOrderReceive.Text = je.ToString();

            double tmp;
            tmp = dbiCarPrice.Value - GetOrderReceive() - dbiLoanAmount.Value;
            txtReceivableAmount.Text = tmp.ToString();
        }


        private void btnCustSel_Click(object sender, EventArgs e)
        {
            if (mStatus == -1)
            {
                frmCarOrderQuery frm = new frmCarOrderQuery();
                frm.IsSelect = true;
                frm.setTransferDelegate(DoResultFromCustSel);
                frm.ShowDialogEx();
            }
            else
            {
                ShowMessage("只有开单之前才可进行选择");
            }

        }


        private void DoResultFromCustSel(object obj)
        {

            string strresult = (string)obj;
            string[] strlst = strresult.Split(',');
            string dh = strlst[0];
            string autonumer = strlst[2];
            string mobile = strlst[1];
            string saleprice = strlst[3];

            decimal AmountReceive = 0;
            decimal AmountSum = 0;
            DataTable dt = mICarSale.GetAmountOfOrderRecv(dh);
            if (dt.Rows.Count > 0)
            {
                AmountReceive = decimal.Parse(dt.Rows[0][0].ToString());
                AmountSum = decimal.Parse(dt.Rows[0][1].ToString());
            }

            if (AmountSum > 0 && AmountReceive == 0)
            {
                ShowMessage("该订单有提交金额，请先收款再进行操作");
                return;

            }

            Customer o = mICustomer.GetCustomerByMobile(mobile);
            txtCustName.Text = o.CustName;
            txtMobile.Text = o.Mobile;
            txtAddress.Text = o.Address;
            mMobile = o.Mobile;


            CarDetail detailObj = mICarDoc.GetCarDetailObjectByAutoNumber(autonumer);

            AssginModelToControl<CarDetail>(detailObj);
            mAutoNumber = autonumer;


            //这里需要更改
            //txtSalePrice.Text = saleprice;



            txtOrderReceive.Text = AmountReceive.ToString();
            dbiCarPrice.Value = double.Parse(saleprice);
            mDHOfOrder = dh;
            txtOrderDH.Text = dh;
            //  mICarSale.GetCarOrderJEByMobile(mMobile);
            //  lblOrderJE.Text = "未绑定订金：" + mICarSale.GetCarOrderJEByMobile(mMobile);
            //dbiOrderPrice.Value=mICarSale.BindOrderFromSale(mMobile,strbh);


        }



        private void BindOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (txtMobile.Text == "" || txtDH.Text == "")
            //{
            //    ShowMessage("单号不能为空");
            //    return;
            //}

            FetchOrderAmount(txtMobile.Text, txtDH.Text);
            //    lblOrderJE.Text = "未绑定订金：0.0";

        }

        private void RelieveOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (txtMobile.Text == "" || txtDH.Text == "")
            //{
            //    ShowMessage("单号不能为空");
            //    return;
            //}
            mICarSale.RelieveOrderFromSale(txtDH.Text);

            //   lblOrderJE.Text = "未绑定订金：" + mICarSale.GetCarOrderJEByMobile(mMobile);

            txtOrderReceive.Text = "0";
            double tmp;
            tmp = dbiCarPrice.Value - GetOrderReceive() - dbiLoanAmount.Value;
            txtReceivableAmount.Text = tmp.ToString();
        }

        private void tbtbOpen_Click(object sender, EventArgs e)
        {
            frmCarSaleQuery frm = new frmCarSaleQuery();
            frm.setTransferDelegate(delegate(object obj)
            {
                string dh = (string)obj;
                AssinToControls(dh);
            });
            frm.ShowDialogEx();
        }

        private void AssinToControls(string dh)
        {
            DataTable dt = mICarSale.GetCarSaleByDH(dh);
            if (dt.Rows.Count <= 0) return;
            txtDH.Text = dh;
            txtCustName.Text = dt.Rows[0]["custname"].ToString();
            txtAddress.Text = dt.Rows[0]["address"].ToString();
            txtIdentity.Text = dt.Rows[0]["IdentityCard"].ToString();
            txtVin.Text = dt.Rows[0]["vin"].ToString();
            txtSaleMan.Text = dt.Rows[0]["SaleMan"].ToString();

            txtTotalPrice.Text = dt.Rows[0]["TotalPrice"].ToString();
            txtOrderReceive.Text = dt.Rows[0]["OrderReceive"].ToString();
            dbiCarPrice.Value = double.Parse(dt.Rows[0]["CarPrice"].ToString());
            dbiDecorPrice.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["Gamount"].ToString()));
            dbiLoanAmount.Value = double.Parse(dt.Rows[0]["LoanAmount"].ToString());
            txtAmountReceive.Text = dt.Rows[0]["AmountReceive"].ToString();
            cmbInCompany.Text = dt.Rows[0]["InCompany"].ToString();
            //SetInCompany(dt.Rows[0]["InCompany"].ToString());
            txtAmountPost.Text = dt.Rows[0]["AmountPost"].ToString();
            txtSalePrice.Text = dt.Rows[0]["SalePrice"].ToString();
            txtOrderDH.Text = dt.Rows[0]["OrderDH"].ToString();

            dbiInsurancePrice.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["InsurancePrice"].ToString()));
            dbiBTPrice.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["BTPrice"].ToString()));


            dbiOutFee.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["OutFee"].ToString()));
            //dbiLoanIncome.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["LoanIncome"].ToString()));
            dbiChangeIncome.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["ChangeIncome"].ToString()));
            dbiElseIncome.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["ElseIncome"].ToString()));
            dbiPlateFee.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["PlateFee"].ToString()));
            dbiUpKeepCharge.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["UpKeepCharge"].ToString()));
            dbiOilCharge.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["OilCharge"].ToString()));

            if (!string.IsNullOrEmpty(dt.Rows[0]["CustNameM"].ToString()))
                txtCustName.Text = dt.Rows[0]["CustNameM"].ToString();
            if (Comm.ElseUtil.ReturnZero(dt.Rows[0]["IsSpecial"].ToString()) == "1")
                chbIsSpecial.Checked = true;
            else
                chbIsSpecial.Checked = false;
            string saletype = Comm.ElseUtil.ReturnZero(dt.Rows[0]["saletype"].ToString());
            switch (saletype)
            {

                case "二网":
                    rbt2.Checked = true;
                    break;
                case "展厅":
                    rbt3.Checked = true;
                    break;
                default:
                    rbt3.Checked = true;
                    break;



            }



            mMobile = dt.Rows[0]["mobile"].ToString();



            txtMobile.Text = mMobile;
            int status = int.Parse(dt.Rows[0]["status"].ToString());
            SetStatus(status);
            //获取订金
            // txtOrderReceive.Text= mICarSale.GetOrderAmountByDH(dh).ToString();


            mAutoNumber = dt.Rows[0]["AutoNumber"].ToString();
            CarDetail obj = mICarDoc.GetCarDetailObjectByVin(txtVin.Text);
            if (obj != null)
                AssginModelToControl<CarDetail>(obj);
        }


        private void SetInCompany(string repchildtype)
        {

            for (int i = 0; i < cmbInCompany.Items.Count; i++)
            {
                string st = cmbInCompany.Items[i].ToString();
                if (cmbInCompany.Items[i].ToString() == repchildtype)
                {
                    cmbInCompany.SelectedIndex = i;
                    return;

                }
            }

        }
        private void frmCarSale_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtAutoNumber);
            mLstControls.Add(txtCarBrand);
            mLstControls.Add(txtCarSer);
            mLstControls.Add(txtCarModel);
            mLstControls.Add(cmbDisplacement);
            mLstControls.Add(cmbTransmission);
            mLstControls.Add(cmbInnerStyle);
            mLstControls.Add(cmbColor);
            mLstControls.Add(cmbCarOfYear);
            //mLstControls.Add(txtSalePrice);
            LoadExtendContents("保险公司", cmbInCompany);
            //cmbInCompany.SelectedIndex = -1;
            SetStatus(-1);
            if (dH != "")
            {

                AssinToControls(dH);
                RefreshDetails(dH);
                //    lblOrderJE.Text = "未绑定订金：" + mICarSale.GetCarOrderJEByMobile(txtMobile.Text);
            }
            else
                SetStatus(-1);
            SetTButtonPng(toolStrip1);


            // dbiInsurancePrice.ValueChanged += new EventHandler(this.price_ValueChanged);
            dbiOutFee.ValueChanged += new EventHandler(this.price_ValueChanged);
            dbiChangeIncome.ValueChanged += new EventHandler(this.price_ValueChanged);
            // dbiLoanIncome.ValueChanged += new EventHandler(this.price_ValueChanged);
            dbiElseIncome.ValueChanged += new EventHandler(this.price_ValueChanged);
            dbiPlateFee.ValueChanged += new EventHandler(this.price_ValueChanged);
            dbiCarPrice.ValueChanged += new EventHandler(this.price_ValueChanged);
            dbiLoanAmount.ValueChanged += new EventHandler(this.price_ValueChanged);
            dbiOilCharge.ValueChanged += new EventHandler(this.price_ValueChanged);
            dbiUpKeepCharge.ValueChanged += new EventHandler(this.price_ValueChanged);


            pricechange();
            // this.Width = 1066;
            if (Comm.LoginInfoShare.getInstance().PositionName == "销售经理" || Comm.LoginInfoShare.getInstance().UserId == "admin")
            {
                txtSaleMan.ReadOnly = false;
                btnModifySaler.Enabled = true;
            }
            else
            {
                txtSaleMan.ReadOnly = true;
                btnModifySaler.Enabled = false;
            }


            //if (Comm.LoginInfoShare.getInstance().UserId == "admin")
            //{
            //    btnBack.Visible = true;
            //}
            //else
            //    btnBack.Visible = false;
        }

        private void pricechange()
        {
            double totalprice = dbiOutFee.Value + dbiChangeIncome.Value + dbiElseIncome.Value + dbiCarPrice.Value + dbiPlateFee.Value + dbiOilCharge.Value + dbiUpKeepCharge.Value;
            double ReceivableAmount;
            ReceivableAmount = totalprice - GetOrderReceive() - dbiLoanAmount.Value;
            txtTotalPrice.Text = totalprice.ToString();
            txtReceivableAmount.Text = ReceivableAmount.ToString();

            //设置提交金额
            double tmp = double.Parse(txtAmountReceive.Text);
            dbiAmount.Value = ReceivableAmount - tmp;


        }
        private void price_ValueChanged(object sender, EventArgs e)
        {

            pricechange();

        }


        private void btnVin_Click(object sender, EventArgs e)
        {

            if (mStatus != -1)
            {
                ShowMessage("只有开单之前才可选择");
                return;
            }

            if (txtAutoNumber.Text == "")
            {
                ShowMessage("自编号还未生成");
                return;
            }
            frmCarStock frm = new frmCarStock();
            frm.IsSelect = true;
            //  frm.DetailID = mCarDetailID;
            frm.AutoNumberOfStock = mAutoNumber;
            frm.Status = 0;
            frm.setTransferDelegate(delegate(object o)
            {
                CarStock stockObj = (CarStock)o;
                //CarDetail detailObj = mICarDoc.GetCarDetailObjectByAutoNumber(stockObj.AutoNumber);

                //AssginModelToControl<CarDetail>(detailObj);
                //mAutoNumber = stockObj.AutoNumber;
                txtVin.Text = stockObj.Vin;

            });
            frm.ShowDialogEx();
        }


        private void NoCheckPattern()
        {
            if (txtDH.Text == "")
            {
                ShowMessage("请选择单据");
                return;

            }
            int status = mICarSale.GetCarSaleStatus(txtDH.Text);
            if (status != 1)
            {

                ShowMessage("该单据状态不对，无法审核");
                return;

            }

            status = mICarStock.GetCarStockStatus(txtVin.Text);
            if (status != 0)
            {
                ShowMessage("该车辆已不是未出库车辆，无法审核");
                return;
            }

            double saleprice = 0;
            if (string.IsNullOrEmpty(txtSalePrice.Text))
                saleprice = 0;
            else
                saleprice = double.Parse(txtSalePrice.Text);
            if (dbiCarPrice.Value < saleprice)
            {
                ShowMessage("车辆裸车价不能低于最销售价");
                return;

            }

            mICarSale.UpdateCarSaleStatus(txtDH.Text, 2, LoginInfoShare.getInstance().UserName);
            //    mICarStock.UpdateStatus(txtVin.Text, 1);
            ShowMessage("审核成功");
            SetStatus(2);




        }

        private void mItemPostToCheck_Click(object sender, EventArgs e)
        {
            //查找有没有该客户未绑定的订金

            if (txtMobile.Text == "" || txtDH.Text == "")
            {
                ShowMessage("单号不能为空");
                return;
            }
            if (txtVin.Text == "")
            {
                ShowMessage("Vin不能为空");
                return;

            }
            if (dbiCarPrice.Value <= 0)
            {
                ShowMessage("请输入裸车价");
                return;


            }
            int status;
            status = mICarSale.GetCarSaleStatus(txtDH.Text);
            if (status != 0)
            {
                ShowMessage("单据状态不对,无法提交审核");
                return;
            }

            string dh = txtDH.Text;
            string mobile = txtMobile.Text;
            //if (GetOrderReceive() <= 0)
            //{
            //    bool isBinded = mICarSale.IsOrderBinded(mobile);
            //    if (isBinded == false)
            //    {
            //        ShowMessage("该客户有订金未绑定，请先绑定");

            //        return;
            //    }
            //}

            //确认订金
            if (GetOrderReceive() > 0)
            {
                mICarSale.GetOrderAmountByDH(dh);

            }


            CarSale obj = new CarSale();

            obj.TotalPrice = decimal.Parse(txtTotalPrice.Text);
            obj.CarPrice = (decimal)dbiCarPrice.Value;
            obj.DecorPrice = (decimal)dbiDecorPrice.Value;
            obj.LoanAmount = (decimal)dbiLoanAmount.Value;
            obj.ReceivableAmount = decimal.Parse(txtReceivableAmount.Text);
            obj.Vin = txtVin.Text;
            obj.Mobile = txtMobile.Text;
            obj.AutoNumber = txtAutoNumber.Text;
            obj.InCompany = cmbInCompany.Text;
            //obj.DetailID = mCarDetailID;
            obj.DH = dh;
            obj.CheckMan = LoginInfoShare.getInstance().UserName;

            obj.InsurancePrice = dbiInsurancePrice.Value;
            obj.BTPrice = dbiBTPrice.Value;

            if (chbIsSpecial.Checked)
                obj.IsSpecial = 1;
            else
                obj.IsSpecial = 0;


            if (rbt2.Checked)
                obj.SaleType = rbt2.Text;
            if (rbt3.Checked)
                obj.SaleType = rbt3.Text;

            //obj.OutFee = dbiOutFee.Value;
            //obj.LoanIncome = dbiLoanIncome.Value;
            //obj.ChangeIncome = dbiChangeIncome.Value;
            //obj.ElseIncome = dbiElseIncome.Value;

            mICarSale.PostToCheck(obj);
            ElseDataPost();
            ShowMessage("提交审核成功");
            SetStatus(1);
            IsModify = true;


            if (Comm.LoginInfoShare.getInstance().OrganId == "301")
                NoCheckPattern();
        }

        private void mItemCancelCheck_Click(object sender, EventArgs e)
        {
            int status;
            status = mICarSale.GetCarSaleStatus(txtDH.Text);
            if (status != 1)
            {
                ShowMessage("单据状态不对,无法撤销审核");
                return;
            }
            mICarSale.UpdateCarSaleStatus(txtDH.Text, 0, "");
            ShowMessage("撤销审核成功");
            SetStatus(0);
            IsModify = true;
        }

        private double GetReceivableAmount()
        {

            return double.Parse(txtReceivableAmount.Text);
        }
        private void btnPostPrice_Click(object sender, EventArgs e)
        {
            double amount = dbiAmount.Value;

            //if (dbiAmount.Value <= 0)
            //{
            //    ShowMessage("请提交大于0 的金额");
            //    return;
            //}
            DataTable dt = mICarSale.GetCarSaleByDH(txtDH.Text);
            double amountpost = double.Parse(dt.Rows[0]["AmountPost"].ToString());

            //double totalamount = dbiTotalPrice.Value;
            //double supplusamount = totalamount - orderrecive - amountreceive;
            double supplusamount = GetReceivableAmount() - amountpost;
            if (amount > supplusamount)
            {
                ShowMessage("输入的金额过大，将超过总价");
                return;
            }
            Account obj = new Account();
            obj.Mobile = txtMobile.Text;
            obj.Amount = amount;
            obj.DHFrom = txtDH.Text;
            obj.Describes = "销售收款";
            obj.CustName = txtCustName.Text;

            mIFinance.AddAmount(obj);
            mICarSale.UpdateCarSaleAmountPost(txtDH.Text, amount);
            double tmp = dbiAmount.Value + GetAmountPost();
            txtAmountPost.Text = tmp.ToString();


            dbiAmount.Value = 0;
            ShowMessage("提交成功");
            RefreshDetails(txtDH.Text);

        }

        private double GetAmountPost()
        {

            return double.Parse(txtAmountPost.Text);

        }

        private void RefreshDetails(string dh)
        {
            DataTable dt = mIFinance.GetDetailsOfAmount(dh);
            FrmAssist.UpdateColumns(ref mDicOfCarOrder, dt, 8);
            dgAmount.DataSource = dt;
            dgAmount.Columns["ID"].Visible = false;

        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomerEdit frm = new frmCustomerEdit();
            frm.IsSelect = true;
            frm.setTransferDelegate(DoResultFromCustSel);
            frm.ShowDialogEx();
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgAmount.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgAmount.SelectedRows[0];
                string strid = seldr.Cells[0].Value.ToString();
                double amount = double.Parse(seldr.Cells[1].Value.ToString());
                string txt = seldr.Cells[2].Value.ToString();
                if (txt == "未收款")
                {
                    mIFinance.DelAccount(txtDH.Text, int.Parse(strid), amount, "整车销售");
                    RefreshDetails(txtDH.Text);
                    double tmp;
                    tmp = GetAmountPost() - amount;
                    txtAmountPost.Text = tmp.ToString();
                }
            }
        }

        private void tbtnPrint_Click(object sender, EventArgs e)
        {
            string strCarInfo = string.Format("{0} {1} {2} {3} {4} {5}", txtCarBrand.Text, txtCarSer.Text, txtCarModel.Text, cmbDisplacement.Text, cmbTransmission.Text, cmbColor.Text);
            DataTable dt = mICarSale.GetPrintInfo(txtDH.Text, strCarInfo);
            Dictionary<string, DataTable> dic = new Dictionary<string, DataTable>();
            dic.Add("CarSale", dt);

            frmPrint frm = new frmPrint();
            //frm.DataSource = dt;
            //frm.SourceName = "CarSale";
            frm.DicTable = dic;
            frm.ReportFile = "CarSale.rdlc";
            frm.ShowDialog();

        }



        private void btnDecorate_Click(object sender, EventArgs e)
        {

            //DataTable dt = mICarSale.GetCarSaleByDH(txtDH.Text);
            //if (dt.Rows.Count > 0)
            //{
            //    string decoratedh = dt.Rows[0]["DecorateDH"].ToString();
            //    if (decoratedh.Length < 1)
            //    {
            Auto4SErp.Repair.frmRepair frm = new Auto4SErp.Repair.frmRepair();
            frm.IsSaleDecorate = true;
            frm.SaleDH = txtDH.Text;
            //frm.setTransferDelegate(delegate(object o)
            //{
            //    if (o != null)
            //    {
            //        string dh = o.ToString();
            //        mICarSale.AddCarSaleDecorateDH(txtDH.Text, dh);

            //    }

            //});
            frm.ShowDialogEx();

            //}
            //else
            //{
            //    Auto4SErp.Repair.frmRepair frm = new Auto4SErp.Repair.frmRepair();
            //    frm.IsSaleDecorate = true;
            //    frm.DH = decoratedh;
            //    frm.ShowDialogEx();

            //}


            //}

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!mICarSale.DelCarSale(txtDH.Text))
            {
                ShowMessage("状态不对或者存在该单号对应的装潢单，无法删除");
            }
            else
            {
                IsModify = true;
                mICarSale.BindCarSaleToOrder(txtOrderDH.Text, "");
                this.Close();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExpan_Click(object sender, EventArgs e)
        {
            //if (btnExpan.Text == ">")
            //{
            //    btnExpan.Text = "<";
            //    this.Width = 1066;

            //}
            //else
            //{
            //    btnExpan.Text = ">";
            //    this.Width = 873;
            //}
        }


        private void ElseDataPost()
        {
            CarSale obj = new CarSale();
            obj.OutFee = dbiOutFee.Value;
            //  obj.LoanIncome = dbiLoanIncome.Value;
            obj.ChangeIncome = dbiChangeIncome.Value;//置换
            obj.ElseIncome = dbiElseIncome.Value;//其它
            //  obj.InsurancePrice = dbiInsurancePrice.Value;
            obj.OutFee = dbiOutFee.Value;//手续费
            obj.PlateFee = dbiPlateFee.Value;//上牌费

            obj.UpKeepCharge = dbiUpKeepCharge.Value;
            obj.OilCharge = dbiOilCharge.Value;

            obj.TotalPrice = decimal.Parse(txtTotalPrice.Text);
            obj.InCompany = cmbInCompany.Text;
            obj.DH = txtDH.Text;
            mICarSale.UpdateSaleManageDate(obj);


        }
        private void btnOK_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtDH.Text))
            {
                CarSale obj = new CarSale();
                obj.OutFee = dbiOutFee.Value;
                //  obj.LoanIncome = dbiLoanIncome.Value;
                obj.ChangeIncome = dbiChangeIncome.Value;//置换
                obj.ElseIncome = dbiElseIncome.Value;//其它
                //  obj.InsurancePrice = dbiInsurancePrice.Value;
                obj.OutFee = dbiOutFee.Value;//手续费
                obj.PlateFee = dbiPlateFee.Value;//上牌费

                obj.OilCharge = dbiOilCharge.Value;
                obj.UpKeepCharge = dbiUpKeepCharge.Value;

                obj.TotalPrice = decimal.Parse(txtTotalPrice.Text);
                obj.InCompany = cmbInCompany.Text;
                obj.DH = txtDH.Text;
                mICarSale.UpdateSaleManageDate(obj);
            }
            else
                ShowMessage("没有单号");

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtDH.Text == "")
            {
                ShowMessage("没有生成单号");
                return;

            }
            bool ism = false; ;
            if (ShowMessageOfWarning("同时更新原有客户资料吗？") == DialogResult.OK)
            {
                ism = true;

            }
            mICarSale.ModifyCustNameOfSale(txtDH.Text, txtCustName.Text, txtMobile.Text, ism);
            IsModify = true;
        }

        private void btnModifySaler_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDH.Text))
            {
                ShowMessage("没有生成单号");
                return;

            }
            if (ShowMessageOfWarning("与改销售顾问相关的所有单将被修改，确定吗") == DialogResult.OK)
            {
                mICarSale.ModifySalerOfCarSale(txtDH.Text, txtSaleMan.Text);
                IsModify = true;
            }
        }

        private void rbt2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt3.Checked)
                mICarSale.ChangeTypeOfCarsale(txtDH.Text, "展厅");
            else
                mICarSale.ChangeTypeOfCarsale(txtDH.Text, "二网");
            IsModify = true;
        }

        private void rbt3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt3.Checked)
                mICarSale.ChangeTypeOfCarsale(txtDH.Text, "展厅");
            else
                mICarSale.ChangeTypeOfCarsale(txtDH.Text, "二网");
            IsModify = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDH.Text))
            {

                if (Comm.LoginInfoShare.getInstance().UserName == "admin")
                {
                    //mICarSale.CarSaleToBack(txtDH.Text, txtVin.Text);
                    //this.Close();

                }
                else
                {
                    int status = mICarSale.GetCarSaleStatus(txtDH.Text);
                    if (status < 3)
                    {
                        mICarSale.CarSaleToBackNomal(txtDH.Text, txtVin.Text);
                        this.Close();
                    }

                }



            }
        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            //double amountre;
            //dynamic anonymousObj;
            frmDlgInsurance frm = new frmDlgInsurance();
            frm.InsuranceJe = dbiInsurancePrice.Value;
            frm.BTPrice = dbiBTPrice.Value;
            frm.VinOld = txtVin.Text;
            frm.setTransferDelegate(d =>
            {
                // anonymousObj = d;
                //d.DH = txtDH.Text;

                mICarSale.updateInsuranceJE(frm.InsuranceJe, frm.BTPrice, txtDH.Text);
            });
            frm.ShowDialogEx();
        }

    }
}
