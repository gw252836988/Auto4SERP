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
namespace Auto4SErp.Repair
{
    public partial class frmDlgRepRecept : ifrmBase
    {
        public frmDlgRepRecept()
        {
            InitializeComponent();
        }

        private void frmDlgRepRecept_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            mLstControls.Add(txtCustName);
            mLstControls.Add(txtDH);
            mLstControls.Add(txtPlateNum);
            mLstControls.Add(cmbStatus);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<SqlElement> mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            if (m_del != null)
            {
                m_del(mLstE);
                this.Close();
            }

        }
    }
}
