using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using Bll.Repair;
using Comm;


namespace Auto4SErp.Report
{
    public partial class frmLostCustomer : ifrmBase
    {

        private IRepair mIRepair;
        public frmLostCustomer()
        {
            InitializeComponent();
            mIRepair = BllFactory.GetRepariBll();
        }

        private void frmLostCustomer_Load(object sender, EventArgs e)
        {
            DoQuery();
            SetTButtonPng(toolStrip1);

        }


        protected override void DoQuery()
        {

            dgResult.DataSource = mIRepair.GetLostCustomers(itiCount.Value);
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut eio = new ExcelInAndOut("");
            //eio.Title = "维修查询";

            eio.NewDTOutTo(dgResult);
        }

        private void dgResult_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }

        private void dgResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgResult.SelectedRows.Count != 0)
            {

                DataGridViewRow seldr = dgResult.SelectedRows[0];
                string strdh = seldr.Cells[2].Value.ToString();

                dgHistory.DataSource = mIRepair.GetRepairsByPlate(strdh);

            }
        }





    }
}
