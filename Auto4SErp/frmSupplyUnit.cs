using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Bll;
namespace Auto4SErp
{
    public partial class frmSupplyUnit : ifrmBase
    {

        private List<SqlElement> mLstE;
        private IExtend mIExtend;

        public frmSupplyUnit()
        {
            mIExtend = BllFactory.GetExtendBll();
            InitializeComponent();
        }

        private void frmSupplyUnit_Load(object sender, EventArgs e)
        {
            mLstControls.Add(cmbUnitType);
            mLstControls.Add(txtUnitAddress);
            SetTButtonPng(toolStrip1);
            DoQuery();
        }

        protected override void DoQuery()
        {
            DataTable dt;
            dt = mIExtend.GetSupplyUnitsByQuery(mLstE);

            dgUnit.DataSource = dt;

        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            frmDlgUnit frm = new frmDlgUnit();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                DoQuery();
            });
            frm.ShowDialogEx();
        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgUnit.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgUnit.SelectedRows[0];
                int id = int.Parse(dr.Cells[0].Value.ToString());
                frmDlgUnit frm = new frmDlgUnit();
                frm.ID = id;
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    DoQuery();
                });
                frm.ShowDialogEx();

            }
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgUnit.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgUnit.SelectedRows[0];
                int id = int.Parse(dr.Cells[0].Value.ToString());

                mIExtend.DelSupplyUnit(id);
                DoQuery();


            }
        }
    }
}
