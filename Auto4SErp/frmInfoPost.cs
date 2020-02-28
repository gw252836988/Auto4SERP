﻿using System;
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
    public partial class frmInfoPost : ifrmBase
    {
        private IStaff mIStaff;
        public frmInfoPost()
        {
            mIStaff = Bll.BllFactory.GetStaffBll();
            InitializeComponent();
        }

        private void frmInfoPost_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtInfo.Text.Length > 1)
            {
                mIStaff.AddInfo(txtInfo.Text);
                this.Close();
            }

        }
    }
}
