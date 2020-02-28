using System;
using System.Windows.Forms;
using System.Collections;
namespace Auto4SErp.GroupReport
{
    public partial class frmGFinance : ifrmBase
    {
        public frmGFinance()
        {
            InitializeComponent();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoTask(sender);

        }

        private void frmGFinance_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            dateBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            string strBegin = dateBegin.Value.ToShortDateString() + " 00:00:00";
            string strEnd = dateEnd.Value.ToShortDateString() + " 23:59:59";
            SetTButtonPng(toolStrip1);
        }

        protected override Hashtable GetQueryCondition()
        {
            Hashtable ht = new Hashtable();
            ht.Add("beginT", dateBegin.Text);
            ht.Add("endT", dateEnd.Text);
            return ht;

        }

        protected override DataGridView GetDataContainer()
        {
            return dgFinance;

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
                    // DoSummary();
                }
                else if (strmsg.Contains("错误"))
                {
                    lblerror.Text = strmsg;
                }
                else if (strmsg.Contains("读取"))
                    tbtnQuery.Text = strmsg;
            });
        }

        private void btnSelOrgan_Click(object sender, EventArgs e)
        {
            frmOrganSel frm = new frmOrganSel();
            frm.ShowDialogEx();
        }
    }
}
