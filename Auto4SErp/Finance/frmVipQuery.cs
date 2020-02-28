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
namespace Auto4SErp.Finance
{
    public partial class frmVipQuery : ifrmBase
    {
        private IVip mIVip;
        public frmVipQuery()
        {
            mIVip = Bll.BllFactory.GetVipBll();
            InitializeComponent();
        }

        private void frmVipQuery_Load(object sender, EventArgs e)
        {

        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            VipInfo obj = mIVip.GetVipInfoByCardID(txtCardNo.Text);
            if (obj != null)
            {
                txtMemberLevel.Text = obj.MemberLevel;
                txtBalance.Text = obj.Balance.ToString();
                txtIntegral.Text = obj.Integral.ToString();
                txtInOrgan.Text = obj.InOrgan;
            }
        }
    }
}
