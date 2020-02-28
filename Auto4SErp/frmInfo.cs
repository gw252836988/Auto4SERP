using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.Personnel;
namespace Auto4SErp
{
    public partial class frmInfo : ifrmBase
    {
        private IStaff mIStaff;
        public frmInfo()
        {
            mIStaff = Bll.BllFactory.GetStaffBll();
            InitializeComponent();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            DataTable dt = mIStaff.GetLatestInfos();
            if (dt.Rows.Count > 0)
            {
                lbltip1.Text = "通知信息";
                if (dt.Rows.Count > 1)
                    lbltip2.Text = "2." + dt.Rows[1][0].ToString();

            }
            else
                this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
