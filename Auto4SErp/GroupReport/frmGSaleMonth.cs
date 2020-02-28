using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Comm;
namespace Auto4SErp.GroupReport
{
    public partial class frmGSaleMonth : ifrmBase
    {


        public frmGSaleMonth()
        {
            InitializeComponent();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            DoTask(sender);
        }
        protected override Hashtable GetQueryCondition()
        {
            Hashtable ht = new Hashtable();
            ht.Add("year", nudYear.Value.ToString());
            ht.Add("month", nudMonth.Value.ToString());
            ht.Add("type", cmbSaleType.SelectedIndex);
            return ht;

        }
        protected override void HandlerMsgReport(string strmsg)
        {

            this.BeginInvoke((MethodInvoker)delegate()
            {


                if (strmsg.Contains("耗时"))
                {
                    tbtnQuery.Enabled = true;
                    tbtnQuery.Text = "查询";
                    tlblConsume.Text = strmsg;
                    DoSummary();
                }
                else if (strmsg.Contains("错误"))
                {
                    lblerror.Text = strmsg;
                }
                else if (strmsg.Contains("读取"))
                    tbtnQuery.Text = strmsg;
            });
        }


        private void DoSummary()
        {

            DataTable dt = (DataTable)dgSale.DataSource;

            DataTable dtClone = dt.Clone();
            int count = dt.Rows.Count;
            DataRow drSum1 = dt.Rows[count - 1];
            DataRow drSum2 = dt.Rows[count - 2];
            dtClone.ImportRow(drSum2);
            dtClone.ImportRow(drSum1);

            dgSum.DataSource = dtClone;
            dt.Rows.Remove(drSum1);
            dt.Rows.Remove(drSum2);
            dgSale.Refresh();


        }
        protected override DataGridView GetDataContainer()
        {
            return dgSale;

        }

        private void frmGSaleMonth_Load(object sender, EventArgs e)
        {
            nudYear.Value = int.Parse(DateTime.Now.Year.ToString());
            nudMonth.Value = int.Parse(DateTime.Now.Month.ToString());
            SetTButtonPng(toolStrip1);
            cmbSaleType.SelectedIndex = 0;
        }

        private void btnSelOrgan_Click(object sender, EventArgs e)
        {
            frmOrganSel frm = new frmOrganSel();
            frm.ShowDialogEx();
        }


    }
}
