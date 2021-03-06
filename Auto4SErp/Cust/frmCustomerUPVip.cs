﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Model;
namespace Auto4SErp.Cust
{
    public partial class frmCustomerUPVip : ifrmBase
    {
        private ICustomer mICustomer;
        private string mobile;


        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private string iD;

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public frmCustomerUPVip()
        {
            mICustomer = BllFactory.GetCustomerBll();

            InitializeComponent();
        }

        private void frmCustomerUPVip_Load(object sender, EventArgs e)
        {
            DataTable dt = mICustomer.GetVipTypes();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbVipType.Items.Add(dt.Rows[i][0].ToString() + "-" + dt.Rows[i][1].ToString());

            }
            Customer obj = mICustomer.GetCustomerByID(iD);

            if (obj.VipTypeID != 0)
                cmbVipType.SelectedIndex = (obj.VipTypeID - 1);
            txtCardID.Text = obj.CardNo;




        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            string viptype;
            string vipno;
            if (!string.IsNullOrEmpty(cmbVipType.Text))
                viptype = cmbVipType.Text.Substring(0, 2);
            else
                viptype = "NULL";
            if (!string.IsNullOrEmpty(txtCardID.Text))
                vipno = txtCardID.Text;
            else
                vipno = "NULL";
            mICustomer.UpdateVipType(viptype, vipno, iD);

            IsModify = true;
            this.Close();
        }
    }
}
