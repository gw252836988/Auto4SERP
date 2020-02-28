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
namespace Auto4SErp.Cust
{
    public partial class frmP2PBind : ifrmBase
    {

        private string iD;

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private ICustomer mICustomer;
        private IExtend mIExtend;

        public frmP2PBind()
        {
            mICustomer = BllFactory.GetCustomerBll();
            mIExtend = BllFactory.GetExtendBll();
            InitializeComponent();
        }

        private void frmP2PBind_Load(object sender, EventArgs e)
        {

        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            mICustomer.UpdateP2PMobile(txtMobile.Text, iD);
            mIExtend.AddKeyLog(Comm.LoginInfoShare.getInstance().UserName, "绑定P2P手机号" + txtMobile.Text);
            IsModify = true;
            this.Close();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
