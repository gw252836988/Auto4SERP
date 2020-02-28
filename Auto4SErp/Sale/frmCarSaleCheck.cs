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
using Bll.Sale;
using Comm;
namespace Auto4SErp.Sale
{
    public partial class frmCarSaleCheck : ifrmBase
    {
        private ICarSale mICarSale;
        private ICarDoc mICarDoc;
        private ICarStock mICarStock;
        private bool mIsSpecial = false;
        public frmCarSaleCheck()
        {
            mICarSale = BllFactory.GetCarSaleBll();
            mICarDoc = BllFactory.GetCarDocBll();
            mICarStock = BllFactory.GetCarStockBll();
            InitializeComponent();
        }

        private void tbtbOpen_Click(object sender, EventArgs e)
        {

        }

        private void AssinToControls(string dh)
        {
            DataTable dt = mICarSale.GetCarSaleByDH(dh);
            if (dt.Rows.Count <= 0) return;
            txtDH.Text = dh;
            txtCustName.Text = dt.Rows[0]["custname"].ToString();
            txtMobile.Text = dt.Rows[0]["Mobile"].ToString();
            txtIdentity.Text = dt.Rows[0]["IdentityCard"].ToString();
            txtVin.Text = dt.Rows[0]["vin"].ToString();
            dbiTotalPrice.Value = double.Parse(dt.Rows[0]["TotalPrice"].ToString());
            dbiSalePrice.Value = double.Parse(dt.Rows[0]["SalePrice"].ToString());
            dbiCarPrice.Value = double.Parse(dt.Rows[0]["CarPrice"].ToString());
            //   dbiDecorPrice.Value = double.Parse(dt.Rows[0]["DecorPrice"].ToString());
            int status = int.Parse(dt.Rows[0]["status"].ToString());

            //int detailID = int.Parse(dt.Rows[0]["CarDetailId"].ToString());
            string autonumber = dt.Rows[0]["AutoNumber"].ToString();
            string isspecial = Comm.ElseUtil.ReturnZero(dt.Rows[0]["IsSpecial"].ToString());
            if (isspecial == "1") mIsSpecial = true;
            if (mIsSpecial)
                btnSpecial.Visible = true;
            else
                btnSpecial.Visible = false;

            dbiLoanAmount.Value = double.Parse(dt.Rows[0]["LoanAmount"].ToString());
            dbiInsurancePrice.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["InsurancePrice"].ToString()));

            dbiOutFee.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["OutFee"].ToString()));
            //  dbiLoanIncome.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["LoanIncome"].ToString()));
            dbiChangeIncome.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["ChangeIncome"].ToString()));
            dbiElseIncome.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["ElseIncome"].ToString()));
            dbiDecorPrice.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["Gamount"].ToString()));
            dbiPlateFee.Value = double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["PlateFee"].ToString()));

            SetStatus(status);
            CarDetail obj = mICarDoc.GetCarDetailObjectByAutoNumber(autonumber);
            AssginModelToControl<CarDetail>(obj);
        }


        private void SetStatus(int status)
        {


            if (status == 0)//开单阶段
            {

                lblStatusText.Text = "开单";
            }

            else if (status == 1)//审核阶段
            {

                lblStatusText.Text = "正在审核";

            }
            else if (status == 2)//收款阶段
            {

                lblStatusText.Text = "正在结算";
            }

        }
        private void frmCarSaleCheck_Load(object sender, EventArgs e)
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
            // mLstControls.Add(dbiAllotPrice);
            // mLstControls.Add(dbiSalePrice);
            // mLstControls.Add(dbiCostPrice);
            mLstControls.Add(dbiDirectPrice);
            // mLstControls.Add(dbiMinPrice);
            SetTButtonPng(toolStrip1);
            SetTButtonPng(toolStrip1);

            mLstSenstiveTB.Add(btnSpecial);
            CheckSPsOfStaff(this.Name.Substring(3));
        }

        private void tbtnCheck_Click(object sender, EventArgs e)
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


            if (dbiCarPrice.Value < dbiSalePrice.Value)
            {
                ShowMessage("车辆裸车价不能低于最销售价");
                return;

            }

            mICarSale.UpdateCarSaleStatus(txtDH.Text, 2, LoginInfoShare.getInstance().UserName);
            mICarStock.UpdateStatus(txtVin.Text, 1);
            ShowMessage("审核成功");
            SetStatus(2);
        }

        private void tbtnCancel_Click(object sender, EventArgs e)
        {
            if (txtDH.Text == "")
            {
                ShowMessage("请选择单据");
                return;

            }
            int status = mICarSale.GetCarSaleStatus(txtDH.Text);
            if (status != 2)
            {

                ShowMessage("该单据状态不对，无法取消审核");
                return;

            }
            bool b = mICarSale.IsExistAmountOfPost(txtDH.Text);
            if (b)
            {
                ShowMessage("该单据已提交金额，无法取消审核");
                return;
            }

            mICarSale.UpdateCarSaleStatus(txtDH.Text, 1, LoginInfoShare.getInstance().UserName);
            mICarStock.UpdateStatus(txtVin.Text, 0);
            ShowMessage("取消审核成功");
            SetStatus(1);
        }

        private void tbtnCOpen_Click(object sender, EventArgs e)
        {

        }

        private void CheckSelItem_Click(object sender, EventArgs e)
        {
            frmCarSaleQuery frm = new frmCarSaleQuery();
            frm.Status = 1;
            frm.IsSelect = true;
            frm.setTransferDelegate(delegate(object obj)
            {
                string dh = (string)obj;
                AssinToControls(dh);
            });
            frm.ShowDialogEx();
        }

        private void CancelSelItem_Click(object sender, EventArgs e)
        {
            frmCarSaleQuery frm = new frmCarSaleQuery();
            frm.Status = 2;
            frm.IsSelect = true;
            frm.setTransferDelegate(delegate(object obj)
            {
                string dh = (string)obj;
                AssinToControls(dh);
            });
            frm.ShowDialogEx();
        }

        private void btnSpecial_Click(object sender, EventArgs e)
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


            //if (dbiCarPrice.Value < dbiSalePrice.Value)
            //{
            //    ShowMessage("车辆裸车价不能低于最销售价");
            //    return;

            //}

            mICarSale.UpdateCarSaleStatus(txtDH.Text, 2, LoginInfoShare.getInstance().UserName);
            mICarStock.UpdateStatus(txtVin.Text, 1);
            ShowMessage("审核成功");
            SetStatus(2);
        }

        private void tDropCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
