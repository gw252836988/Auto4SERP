using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auto4SErp.Repair
{
    public partial class frmDlgBatchIDofTake : ifrmBase
    {
        public frmDlgBatchIDofTake()
        {
            InitializeComponent();
        }

        private void frmDlgBatchIDofTake_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (m_del != null)
                m_del(itiBatchID.Value);
            this.Close();
        }
    }
}
