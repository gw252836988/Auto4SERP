using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Comm;
namespace Auto4SErp.Cust
{
    public partial class frmDlgCarOfCustQuery : ifrmBase
    {
        public frmDlgCarOfCustQuery()
        {
            InitializeComponent();
        }

        private void frmDlgCarOfCustQuerycs_Load(object sender, EventArgs e)
        {

            mLstControls.Add(txtPlateNum);
            mLstControls.Add(txtVin);

            SetTButtonPng(toolStrip1);
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            List<Pair> lst = AssginToListOfQuery();

            List<SqlElement> lstE = CreateMedialSqlElement(lst);


            if (m_del != null)
            {
                m_del(lstE);
            }
            this.Close();
        }
    }
}
