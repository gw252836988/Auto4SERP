using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;

namespace Auto4SErp.Cust
{
    public partial class frmVipType : ifrmBase
    {
        private ICustomer mICustomer;
        public frmVipType()
        {
            InitializeComponent();
            mICustomer = BllFactory.GetCustomerBll();
        }

        private void frmVipType_Load(object sender, EventArgs e)
        {
            dgVipType.AutoGenerateColumns = false;
            dgVipType.DataSource = mICustomer.GetAllVipTypes();
        }
    }
}
