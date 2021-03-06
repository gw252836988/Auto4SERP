﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.Repair;
using Model;
using Bll;
namespace Auto4SErp.Cust
{
    public partial class frmDlgRepVisit : ifrmBase
    {
        private IRepair mIRepair;
        private IVisit mIVisit;
        public string DH
        {
            get;
            set;

        }


        public string ID
        {

            get;
            set;

        }
        public frmDlgRepVisit()
        {
            InitializeComponent();
            mIRepair = Bll.BllFactory.GetRepariBll();
            mIVisit = Bll.BllFactory.GetVisitBll();
        }

        private void frmDlgRepVisit_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DH))
            {
                RepairM obj = mIRepair.GetRepairByDH(DH);
                txtDH.Text = obj.DH;
                txtCustName.Text = obj.CustName;
                txtPlateNum.Text = obj.PlateNum;
                txtCarModel.Text = obj.CarModel;
                SetTButtonPng(toolStrip1);
            }
            if (!string.IsNullOrEmpty(ID))
            {
                DataTable dt = mIVisit.GetVisit(ID);
                if (dt.Rows.Count > 0)
                {
                    datVisitDate.Value = DateTime.Parse(dt.Rows[0]["VisitDate"].ToString());
                    cmbVisitType.Text = dt.Rows[0]["VisitType"].ToString();
                    cmbVisitResult.Text = dt.Rows[0]["VisitResult"].ToString();
                    cmbVisitReturn.Text = dt.Rows[0]["VisitReturn"].ToString();
                    txtVisitRemark.Text = dt.Rows[0]["VisitRemark"].ToString();
                }
            }

        }


        private List<SqlElement> GenerateData()
        {
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement { IsFuzzy = true, IsStr = true, Name = "DH", Value = txtDH.Text });
            lst.Add(new SqlElement { IsFuzzy = true, IsStr = true, Name = "VisitType", Value = cmbVisitType.Text });
            lst.Add(new SqlElement { IsFuzzy = true, IsStr = true, Name = "VisitResult", Value = cmbVisitResult.Text });
            lst.Add(new SqlElement { IsFuzzy = true, IsStr = true, Name = "VisitReturn", Value = cmbVisitReturn.Text });
            lst.Add(new SqlElement { IsFuzzy = true, IsStr = true, Name = "VisitDate", Value = datVisitDate.Value.ToString() });
            lst.Add(new SqlElement { IsFuzzy = true, IsStr = true, Name = "VisitRemark", Value = txtVisitRemark.Text });
            lst.Add(new SqlElement { IsFuzzy = true, IsStr = true, Name = "VisitMan", Value = Comm.LoginInfoShare.getInstance().UserName });
            return lst;

        }


        private void tbtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                mIVisit.AddReturnVisit(GenerateData());
                this.Close();
            }
            else
            {
                mIVisit.UpdateReturnVisit(GenerateData(), ID);
                this.Close();

            }
        }
    }
}
