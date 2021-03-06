﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using Comm;
using Model;
using Bll.Personnel;

namespace Auto4SErp.Personnel
{
    public partial class frmAddOperateMan : ifrmBase
    {

        private string mDepartmentIdSel;
        private int mPositionIdSel;
        private IOperateMan mIOperateMan;
        public frmAddOperateMan()
        {
            mIOperateMan = Bll.BllFactory.GetOperateManBll();
            InitializeComponent();
        }

        private void frmAddOperateMan_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            mLstControls.Add(txtStaffId);
            mLstControls.Add(txtStaffName);
            mLstControls.Add(txtDepartmentName);
            mLstControls.Add(txtPositionName);
        }

        private void btnDepartmentFind_Click(object sender, EventArgs e)
        {
            Point pt = this.Location;
            frmDlgDepartTree frm = new frmDlgDepartTree();
            Point NewPoint = new Point(pt.X + this.Width, pt.Y - 50);

            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = NewPoint;
            frm.setTransferDelegate(delegate(object data)
            {
                string bundle = (string)data;
                string[] strlst = bundle.Split('_');
                txtDepartmentName.Text = strlst[1];
                mDepartmentIdSel = strlst[0];

            });
            frm.ShowDialog();
        }

        private void btnPositionFind_Click(object sender, EventArgs e)
        {
            frmPosition frm = new frmPosition();
            frm.DepartMentID = mDepartmentIdSel;
            frm.setTransferDelegate(delegate(object o)
            {
                string[] strlst = o.ToString().Split(',');
                mPositionIdSel = int.Parse(strlst[0]);
                txtPositionName.Text = strlst[1];


            });
            frm.ShowDialogEx();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Staff obj = AssginToModel();
            if (obj != null)
            {
                obj.OrganId = Comm.LoginInfoShare.getInstance().OrganId;
                obj.OrganName = Comm.LoginInfoShare.getInstance().OrganName;
                obj.PositionID = mPositionIdSel;
                obj.DepartmentID = mDepartmentIdSel;
                obj.StaffID = txtStaffId.Text;
                if (mIOperateMan.AddOpreateManByCustom(obj))
                {
                    IsModify = true;
                    this.Close();
                }
                else
                    ShowMessage("该员工已添加");
            }
        }


        private Staff AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;
            Staff entity = FrmAssist.PopulateEntityFromCollection<Staff>(null, lstPairs);
            return entity;
        }
    }
}
