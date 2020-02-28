using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comm;
using Bll.Personnel;
using Bll;
using Model;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Bll.Sale;

namespace Auto4SErp.Personnel
{
    public partial class frmSalaryList : ifrmBase
    {
        private IAward mIAward = BllFactory.GetAwardBll();
        private int Year;
        private int Month;
        public frmSalaryList()
        {
            InitializeComponent();
        }

        private void frmSalaryList_Load(object sender, EventArgs e)
        {
            cmbYear.Text = DateTime.Now.Year.ToString();
            cmbMonth.Text = DateTime.Now.Month.ToString();
            BindData();

         


        }

        private void BindData()
        {
            Year = int.Parse(cmbYear.Text);
            Month = int.Parse(cmbMonth.Text);
            DataTable dt = mIAward.GetSalaryList(Year, Month, "");
            gridSalary.DataSource = dt;

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            frmSalaryInput frm = new frmSalaryInput();
            frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSalaryInput_FormClosed);
            frm.ShowDialog();
        }

        private void frmSalaryInput_FormClosed(object sender, FormClosedEventArgs e)
        {

            BindData();

        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnOPen_Click(object sender, EventArgs e)
        {
            DataRowView obj = (DataRowView)gridView1.GetFocusedRow();
            if (obj != null)
            {
               // mIAward.GetSalaryOfOneStaff(obj["StaffID"].ToString(),int.Parse(obj["Year"].ToString()),int.Parse(obj["Month"].ToString()));
                frmSalaryInput frm = new frmSalaryInput();
                frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSalaryInput_FormClosed);
           
                frm.StaffID = obj["StaffID"].ToString();
                frm.Year = int.Parse(obj["Year"].ToString());
                frm.Month = int.Parse(obj["Month"].ToString());
                frm.ShowDialog();

            }
        }

        private void btnDateSetting_Click(object sender, EventArgs e)
        {

            mIAward.UpdateSalaryDate(int.Parse(cmbYear.Text),int.Parse(cmbMonth.Text));
        }
    }
}
