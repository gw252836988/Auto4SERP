using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Comm;
namespace Auto4SErp.Cust
{
    public partial class frmDlgCustomerQuery : ifrmBase
    {
        public frmDlgCustomerQuery()
        {
            InitializeComponent();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {

            List<Pair> lst = AssginToListOfQuery();

            List<SqlElement> lstE = CreateMedialSqlElement(lst);

            if (chbVip.Checked == true)
                lstE.Add(new SqlElement { Name = "Vip" });
            if (m_del != null)
            {
                m_del(lstE);
            }
            this.Close();

        }

        private void frmDlgCustomerQuery_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtCustName);
            mLstControls.Add(txtBH);
            mLstControls.Add(txtMobile);
            mLstControls.Add(cmbSex);
            mLstControls.Add(txtIdentityCard);
            mLstControls.Add(txtAddress);
            mLstControls.Add(txtTelephone);

            SetTButtonPng(toolStrip1);
        }


    }
}
