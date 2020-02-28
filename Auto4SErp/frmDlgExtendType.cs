﻿using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto4SErp
{
    public partial class frmDlgExtendType : ifrmBase
    {
        private int typeid = 0;

        public int Typeid
        {
            get { return typeid; }
            set { typeid = value; }
        }



        private IExtend mIExtend = BllFactory.GetExtendBll();
        public frmDlgExtendType()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void frmDlgExtendType_Load(object sender, EventArgs e)
        {
            if (typeid > 0)
            {
                DataTable dt = mIExtend.GetExtendtype(typeid);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    this.txtName.Text = dr["extendname"].ToString();

                }
            }


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string extendname = this.txtName.Text.Trim();
            if (extendname != "")
            {
                bool result = false;
                if (typeid > 0)
                {
                    result = mIExtend.UpdateExtendtype(extendname, typeid);
                }
                else
                {
                    result = mIExtend.AddExtendtype(extendname);
                }
                if (result)
                {
                    IsModify = true;

                    this.Close();
                }
            }
        }
    }
}
