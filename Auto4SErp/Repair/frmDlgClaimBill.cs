using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.Repair;
using Model;
using Bll;
namespace Auto4SErp.Repair
{
    public partial class frmDlgClaimBill : ifrmBase
    {
        private IClaim mIClaim;
        private IFinance mIFinance;
        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }


        public frmDlgClaimBill()
        {
            mIClaim = Bll.BllFactory.GetClaimBll();
            mIFinance = BllFactory.GetFinanceBll();
            InitializeComponent();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            if (dbiAllAmount.Value <= 0)
            {

                ShowMessage("开票金额不能小于0");
                return;

            }

            decimal allje = (decimal)dbiAllAmount.Value;
            txtDH.Text = mIClaim.AddClaimBill(allje);



        }


        private void RefreshClaimBillD()
        {
            dgClaim.AutoGenerateColumns = false;
            DataTable dt = mIClaim.GetClaimDOfBill(txtDH.Text);
            dbiAllAmount.Value = mIClaim.GetAllAmountOfBill(txtDH.Text);
            dgClaim.DataSource = dt;

        }
        private void btnSelect_Click(object sender, EventArgs e)
        {

            if (txtDH.Text.Length <= 0)
            {
                ShowMessage("请开票生成单号");
                return;
            }

            int status = mIClaim.GetStautsOfClaimBillH(txtDH.Text);
            if (status != 0)
            {
                ShowMessage("状态不对，无法添加");
                return;
            }
            frmClaim frm = new frmClaim();
            frm.IsSelect = true;
            frm.setTransferDelegate(delegate(object o)
            {
                List<string> lst = (List<string>)o;

                mIClaim.AddClaimBllD(txtDH.Text, lst);

                RefreshClaimBillD();


            }
            );

            frm.ShowDialogEx();

        }

        private void frmDlgClaimBill_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(dH))
            {
                txtDH.Text = dH;
                // RefreshClaimBillD();
                dbiAllAmount.Value = mIClaim.GetAmountOfClaimBillH(dH);
                btnAddBill.Enabled = false;
            }
            SetTButtonPng(toolStrip1);
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgClaim.SelectedRows.Count != 0)
            {

                DataGridViewRow seldr = dgClaim.SelectedRows[0];
                string strdh = seldr.Cells[3].Value.ToString();
                mIClaim.DelClaimBllD(txtDH.Text, strdh);
                RefreshClaimBillD();

            }



        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDH.Text)) return;
            int status = mIClaim.GetStautsOfClaimBillH(txtDH.Text);
            if (status == 0)
            {
                //Account obj = new Account();
                //obj.Amount = dbiAllAmount.Value;
                //obj.DHFrom = txtDH.Text;

                //obj.Describes = "索赔收款";

                //mIFinance.AddAmount(obj);
                mIClaim.UpdateStatusClaimBillH(1, txtDH.Text);
                ShowMessage("提交成功");
            }
            else
                ShowMessage("状态不对,无法提交");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDH.Text)) return;
            int status = mIClaim.GetStautsOfClaimBillH(txtDH.Text);
            if (status == 1)
            {
                mIFinance.DelAccountOfRep(txtDH.Text);
                mIClaim.UpdateStatusClaimBillH(0, txtDH.Text);
                ShowMessage("收款提交已放弃");
            }
            else
                ShowMessage("状态不对，无法撤销提交");

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgClaim.SelectedRows.Count != 0)
            {

                DataGridViewRow seldr = dgClaim.SelectedRows[0];
                string strdh = seldr.Cells[3].Value.ToString();
                mIClaim.DelClaimBllD(txtDH.Text, strdh);
                RefreshClaimBillD();

            }

        }

        private void dgClaim_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
            io.DTOutTo(dgClaim);
        }
    }
}
