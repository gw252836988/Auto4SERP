using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using Model;
using Comm;
using Auto4SErp.Cust;
using Bll.Sale;


namespace Auto4SErp.Sale
{
    public partial class frmCarAllot : ifrmBase
    {

        private ICarDoc mICarDoc;
        private ICarSale mICarSale;
        private ICarStock mICarStock;
        private IFinance mIFinance;
        private IExtend mIExtend;
        public string DH
        {
            get;
            set;
        }
        //  private int mStatus=0;
        public frmCarAllot()
        {
            mICarDoc = BllFactory.GetCarDocBll();
            mICarSale = BllFactory.GetCarSaleBll();
            mICarStock = BllFactory.GetCarStockBll();
            mIFinance = BllFactory.GetFinanceBll();
            mIExtend = BllFactory.GetExtendBll();
            InitializeComponent();
        }

        private void frmCarAllot_Load(object sender, EventArgs e)
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
            datAllot.Value = DateTime.Now;
            SetTButtonPng(toolStrip1);


            DataTable dtExtend = mIExtend.GetSupplyUnits("销售");
            for (int i = 0; i < dtExtend.Rows.Count; i++)
            {
                cmbSupplier.Items.Add(dtExtend.Rows[i][1].ToString());
            }
            if (!string.IsNullOrEmpty(DH))
            {

                DataTable dt = mICarSale.GetCarAllot(DH);
                if (dt.Rows.Count < 1) return;
                txtDH.Text = dt.Rows[0]["DH"].ToString();
                txtSaleMan.Text = dt.Rows[0]["OperatorMan"].ToString();
                txtVin.Text = dt.Rows[0]["Vin"].ToString();
                dbiAllotPrice.Value = double.Parse(dt.Rows[0]["AllotPrice"].ToString());
                cmbSupplier.Text = dt.Rows[0]["AllotUnit"].ToString();
                datAllot.Value = DateTime.Parse(dt.Rows[0]["AllotDate"].ToString());
                int status = int.Parse(dt.Rows[0]["status"].ToString());
                SetStatus(status);
                CarDetail detailObj = mICarDoc.GetCarDetailObjectByVin(txtVin.Text);
                AssginModelToControl<CarDetail>(detailObj);
            }
            else
                SetStatus(0);
        }

        private void btnVin_Click(object sender, EventArgs e)
        {
            frmCarStock frm = new frmCarStock();
            frm.IsSelect = true;
            //  frm.DetailID = mCarDetailID;

            frm.Status = 0;
            frm.setTransferDelegate(delegate(object o)
            {
                CarStock stockObj = (CarStock)o;
                CarDetail detailObj = mICarDoc.GetCarDetailObjectByVin(stockObj.Vin);


                AssginModelToControl<CarDetail>(detailObj);

                txtVin.Text = stockObj.Vin;

            });
            frm.ShowDialogEx();
        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVin.Text))
            {
                ShowMessage("请选择车俩");
                return;
            }

            if (string.IsNullOrEmpty(cmbSupplier.Text))
            {
                ShowMessage("请选择调拨单位");
                return;

            }
            List<SqlElement> list = new List<SqlElement>();
            list.Add(new SqlElement("Vin", txtVin.Text, true));
            list.Add(new SqlElement("AllotPrice", dbiAllotPrice.Value.ToString(), true));
            list.Add(new SqlElement("AllotUnit", cmbSupplier.Text, true));
            list.Add(new SqlElement("AllotDate", datAllot.Value.ToShortDateString(), true));
            list.Add(new SqlElement("OperatorMan", LoginInfoShare.getInstance().UserName, true));
            list.Add(new SqlElement("DH", "dbo.GetAllotCarDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", false));

            string strDH = mICarSale.GetDHOfAddCarAllot(list);
            txtDH.Text = strDH;
            txtSaleMan.Text = LoginInfoShare.getInstance().UserName;

            IsModify = true;
            SetStatus(1);
            mICarSale.SetCarAllotStatus(txtDH.Text, 1);

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            mICarStock.UpdateStatus(txtVin.Text, 2);
            mICarSale.SetCarAllotStatus(txtDH.Text, 2);
            Account obj = new Account();
            // obj.Mobile = txtMobile.Text;
            obj.Amount = dbiAllotPrice.Value;
            obj.DHFrom = txtDH.Text;
            obj.Describes = "整车调拨";
            obj.CustName = cmbSupplier.Text;

            mIFinance.AddAmount(obj);
            SetStatus(2);
            IsModify = true;
        }

        private void SetStatus(int status)
        {
            if (status == 0)
            {
                gbDB.Enabled = true;
                btnPost.Enabled = false;
                btnUndo.Enabled = false;
                tbtnSave.Enabled = true;
                btnDel.Enabled = false;
            }
            else if (status == 1)
            {
                gbDB.Enabled = false;
                btnPost.Enabled = true;
                btnUndo.Enabled = false;
                tbtnSave.Enabled = false;
                btnDel.Enabled = true;
            }
            else if (status == 2)
            {
                gbDB.Enabled = false;
                btnPost.Enabled = false;
                btnUndo.Enabled = true;
                tbtnSave.Enabled = false;
                btnDel.Enabled = false;
            }



        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            mICarStock.UpdateStatus(txtVin.Text, 0);
            mICarSale.SetCarAllotStatus(txtDH.Text, 1);
            mIFinance.DelAccountOfRep(txtDH.Text);
            SetStatus(1);
            IsModify = true;
        }

        private void btnCustomerFind_Click(object sender, EventArgs e)
        {
            frmSupplyUnit frm = new frmSupplyUnit();
            frm.ShowDialogEx();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            IsModify = true;
            mICarSale.DelCarAllot(txtDH.Text);
            this.Close();
        }
    }
}
