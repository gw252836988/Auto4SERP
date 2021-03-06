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
using Auto4SErp.Cust;
using Bll.Sale;
using Comm;
namespace Auto4SErp.Sale
{
    public partial class frmCarOrder : ifrmBase
    {
        private ICustomer mICustomer;
        private ICarDoc mICarDoc;
        private ICarSale mICarSale;
        private IFinance mIFinance;
        private string mMobile = "";
        // private int mCarDetailID=0;
        private string dH = "";
        private DataTable mDicOfCarOrder;
        private string mAutoNumber = "";
        private ICarStock mICarStock;
        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        public frmCarOrder()
        {
            InitializeComponent();
            mICustomer = BllFactory.GetCustomerBll();
            mICarDoc = BllFactory.GetCarDocBll();
            mICarSale = BllFactory.GetCarSaleBll();
            mIFinance = BllFactory.GetFinanceBll();
            mICarStock = BllFactory.GetCarStockBll();
        }

        private void btnCustSel_Click(object sender, EventArgs e)
        {
            frmCustomerQuery frm = new frmCustomerQuery();
            frm.IsSelect = true;
            frm.setTransferDelegate(DoResultFromCustSel);
            frm.ShowDialogEx();
        }

        private void DoResultFromCustSel(object obj)
        {

            string strbh = (string)obj;
            Customer o = mICustomer.GetCustomerByMobile(strbh);

            //if (mICarSale.IsOrderBinded(o.Mobile) == false)
            //{
            //    ShowMessage("该顾客有未绑定订金，不能再增加订金");
            //    return;
            //}

            txtCustName.Text = o.CustName;
            txtMobile.Text = o.Mobile;
            txtAddress.Text = o.Address;
            mMobile = o.Mobile;


        }


        private void btnCarDocSel_Click(object sender, EventArgs e)
        {
            frmCarDoc frm = new frmCarDoc();
            frm.IsSelect = true;
            frm.setTransferDelegate(delegate(object data)
            {
                mAutoNumber = data.ToString();
                CarDetail obj = mICarDoc.GetCarDetailObjectByAutoNumber(mAutoNumber);

                txtAutoNumber.Text = obj.AutoNumber;
                txtCarBrand.Text = obj.CarBrand;
                txtCarSer.Text = obj.CarSer;
                txtCarModel.Text = obj.CarModel;
                cmbDisplacement.Text = obj.Displacement;
                cmbInnerStyle.Text = obj.InnerStyle;
                cmbTransmission.Text = obj.Transmission;
                cmbColor.Text = obj.Color;
                cmbCarOfYear.Text = obj.CarOfYear;

                //  mCarDetailID = id;
                //txtSalePrice.Text = mICarDoc.GetNewSalePrice(mAutoNumber).ToString();

            });
            frm.ShowDialogEx();
        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            if (mMobile == "")
            {
                ShowMessage("请选择客户");
                return;
            }

            if (mAutoNumber == "")
            {
                ShowMessage("请选择车型");
                return;
            }

            if (dbiCarPrice.Value <= 0)
            {
                ShowMessage("请输入整车开票价");
                return;

            }

            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("AutoNumber", mAutoNumber, true));
            list.Add(new SqlElement("mobile", mMobile, true));
            list.Add(new SqlElement("OperatorMan", LoginInfoShare.getInstance().UserName, true));
            list.Add(new SqlElement("DH", "dbo.GetCarOrderDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", false));
            list.Add(new SqlElement("SalePrice", dbiCarPrice.Value.ToString(), false));

            string strDH = mICarSale.GetDHOfAddCarOrder(list);
            txtDH.Text = strDH;
            IsModify = true;
            tbtnSave.Enabled = false;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (txtDH.Text == "")
            {
                ShowMessage("请先保存该单据");
                return;

            }

            //if (dbiAmount.Value > 20000)
            //{
            //    ShowMessage("提交订金过大");
            //    return;

            //}
            if (dbiAmount.Value <= 0)
            {
                ShowMessage("金额为0时，无需提交给财务");
                return;

            }

            if (!mICarSale.IsExistCarSaleInOrder(txtDH.Text))
            {

                ShowMessage("销售单已开，无法再提交订金");
                return;


            }

            dbiAmountSum.Value = dbiAmountSum.Value + dbiAmount.Value;
            mICarSale.PostOrderAmount(dbiAmount.Value, txtDH.Text);

            Account obj = new Account();
            obj.Mobile = txtMobile.Text;
            obj.Amount = dbiAmount.Value;
            obj.DHFrom = txtDH.Text;
            obj.Describes = "销售订金";
            obj.CustName = txtCustName.Text;

            mIFinance.AddAmount(obj);
            ShowMessage("提交成功");
            RefreshDetails(txtDH.Text);
            IsModify = true;

        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            frmCarOrderQuery frm = new frmCarOrderQuery();
            frm.setTransferDelegate(delegate(object obj)
            {
                string dh = (string)obj;
                AssinValuesToControl(dh);

            });
            frm.ShowDialogEx();
        }

        private void AssinValuesToControl(string strDH)
        {

            DataTable dt = mICarSale.CarOrderByDH(strDH);
            if (dt.Rows.Count <= 0) return;
            txtDH.Text = dt.Rows[0]["DH"].ToString();
            txtCustName.Text = dt.Rows[0]["CustName"].ToString();
            txtMobile.Text = dt.Rows[0]["Mobile"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            dbiAmountSum.Value = double.Parse(dt.Rows[0]["AmountSum"].ToString());
            dbiAmountReceice.Value = double.Parse(dt.Rows[0]["AmountReceive"].ToString());
            mAutoNumber = dt.Rows[0]["AutoNumber"].ToString();
            dbiCarPrice.Value = double.Parse(dt.Rows[0]["SalePrice"].ToString());
            txtAutoNumber.Text = mAutoNumber;
            if (!string.IsNullOrEmpty(dt.Rows[0]["CustNameM"].ToString()))
                txtCustName.Text = dt.Rows[0]["CustNameM"].ToString();

            int status = int.Parse(dt.Rows[0]["Status"].ToString());
            if (status == 1) btnPost.Enabled = false;
            else
                btnPost.Enabled = true;
            CarDetail obj = mICarDoc.GetCarDetailObjectByAutoNumber(mAutoNumber);

            AssginModelToControl<CarDetail>(obj);

        }

        private void frmCarOrder_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtCarBrand);
            mLstControls.Add(txtCarSer);
            mLstControls.Add(txtCarModel);
            mLstControls.Add(cmbDisplacement);
            mLstControls.Add(cmbTransmission);
            mLstControls.Add(cmbInnerStyle);
            mLstControls.Add(cmbColor);
            mLstControls.Add(cmbCarOfYear);

            if (dH != "")
            {
                AssinValuesToControl(dH);
                RefreshDetails(dH);
                tbtnSave.Enabled = false;
            }
            else
                tbtnSave.Enabled = true;
            SetTButtonPng(toolStrip1);
        }

        private void RefreshDetails(string dh)
        {
            DataTable dt = mIFinance.GetDetailsOfAmount(dh);
            dgAmount.DataSource = dt;
            FrmAssist.UpdateColumns(ref mDicOfCarOrder, dt, 8);
            dgAmount.Columns["id"].Visible = false;

        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgAmount.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgAmount.SelectedRows[0];
                string strid = seldr.Cells[0].Value.ToString();
                double amount = double.Parse(seldr.Cells[1].Value.ToString());
                Account aObj = mIFinance.GetAmountByID(int.Parse(strid));
                if (aObj.Status == 0)
                {
                    mIFinance.DelAccount(txtDH.Text, int.Parse(strid), amount, "销售订金");
                    RefreshDetails(txtDH.Text);

                    dbiAmountSum.Value = dbiAmountSum.Value - amount;
                }

            }
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomerEdit frm = new frmCustomerEdit();
            frm.IsSelect = true;
            frm.setTransferDelegate(DoResultFromCustSel);
            frm.ShowDialogEx();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dH))
            {
                if (mICarSale.DelCarOrder(dH))
                {
                    ShowMessage("无法删除，可能已收订金款");

                }
                else
                    this.Close();
            }

        }

        private void btnElseSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text == "")
            {
                ShowMessage("请选择客户");
                return;
            }

            if (txtAutoNumber.Text == "")
            {
                ShowMessage("请选择车型");
                return;

            }

            if (txtDH.Text == "")
            {
                ShowMessage("没有生成单号");
                return;

            }
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("AutoNumber", txtAutoNumber.Text, true));
            list.Add(new SqlElement("mobile", txtMobile.Text, true));
            // list.Add(new SqlElement("OperatorMan", LoginInfoShare.getInstance().UserName, true));
            //   list.Add(new SqlElement("DH", "dbo.GetCarOrderDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", false));
            //  list.Add(new SqlElement("SalePrice", dbiCarPrice.Value.ToString(), false));
            if (mICarSale.CarOrderSaveAgain(txtDH.Text, list))
                ShowMessage("保存成功");
            else
                ShowMessage("已关联销售单据，请先删除该销售单据再操作");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtVin.Text.Length > 4)
            {
                string autonumber = mICarStock.GetCarStockAutoNumber(txtVin.Text);
                mAutoNumber = autonumber;
                CarDetail obj = mICarDoc.GetCarDetailObjectByAutoNumber(autonumber);
                if (obj != null)
                {
                    txtAutoNumber.Text = obj.AutoNumber;
                    txtCarBrand.Text = obj.CarBrand;
                    txtCarSer.Text = obj.CarSer;
                    txtCarModel.Text = obj.CarModel;
                    cmbDisplacement.Text = obj.Displacement;
                    cmbInnerStyle.Text = obj.InnerStyle;
                    cmbTransmission.Text = obj.Transmission;
                    cmbColor.Text = obj.Color;
                    cmbCarOfYear.Text = obj.CarOfYear;
                    //  mCarDetailID = id;
                    // txtSalePrice.Text = mICarDoc.GetNewSalePrice(mAutoNumber).ToString();
                }
                else
                    ShowMessage("没有找到匹配的车架号");

            }

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
            mICarSale.ModifyCustNameOfOrder(txtDH.Text, txtCustName.Text, txtMobile.Text, ism);
            IsModify = true;
        }
    }
}
