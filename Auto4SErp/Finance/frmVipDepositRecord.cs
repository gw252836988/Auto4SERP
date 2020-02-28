using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
namespace Auto4SErp.Finance
{
    public partial class frmVipDepositRecord : ifrmBase
    {
        private IVip mIVip;
        public string CardID
        {
            get;
            set;

        }
        public frmVipDepositRecord()
        {
            mIVip = Bll.BllFactory.GetVipBll();
            InitializeComponent();
        }

        private void frmVipDepositRecord_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CardID))
            {
                DataTable dt = mIVip.GetDepositRecord(CardID);
                dgRecord.AutoGenerateColumns = false;
                dgRecord.DataSource = dt;
            }

        }
    }
}
