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
using Bll.Personnel;
namespace Auto4SErp.Personnel
{
    public partial class frmDlgPosition : ifrmBase
    {
        private IPosition mIPosition = BllFactory.GetPositionBll();
        private string departmentid = "";
        private int positionid = 0;

        public int Positionid
        {
            get { return positionid; }
            set { positionid = value; }
        }
        public frmDlgPosition()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Point pt = this.Location;

            frmDlgDepartTree frm = new frmDlgDepartTree();
            Point NewPoint = new Point(pt.X + this.Width, pt.Y - 50);
            frm.Location = NewPoint;
            frm.Layer = 1;
            frm.setTransferDelegate(new TransferDelegate(this.DoResultFromSuperSel));
            frm.ShowDialog();
        }
        private void DoResultFromSuperSel(object obj)
        {
            string result = (string)obj;
            string[] strtempl = result.Split('_');
            departmentid = strtempl[0];
            txtDepart.Text = strtempl[1];

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string position = this.txtPosition.Text.Trim();
            bool flg = false;
            if (positionid == 0)
            {
                flg = Add(position);
            }
            else
            {
                flg = Update(positionid, departmentid, position);
            }
            if (flg)
            {
                IsModify = true;
                this.Close();
            }

        }
        private bool Add(string position)
        {
            bool flag = false;
            flag = mIPosition.AddPosition(departmentid, position);

            return flag;
        }

        private bool Update(int positionid, string departmentid, string position)
        {
            bool flag = false;
            flag = mIPosition.UpdateDepartment(departmentid, position, positionid.ToString());
            return flag;
        }

        private void frmDlgPosition_Load(object sender, EventArgs e)
        {
            if (positionid > 0)
            {
                DataTable dt = mIPosition.GetPositionByID(positionid.ToString());
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    departmentid = dr["departmentid"].ToString();
                    this.txtDepart.Text = dr["departmentname"].ToString();
                    this.txtPosition.Text = dr["positionname"].ToString();
                }
            }
        }

        private void btnDepartmentFind_Click(object sender, EventArgs e)
        {
            Point pt = this.Location;

            frmDlgDepartTree frm = new frmDlgDepartTree();
            Point NewPoint = new Point(pt.X + this.Width, pt.Y - 50);
            frm.Location = NewPoint;
            frm.Layer = 1;
            frm.setTransferDelegate(new TransferDelegate(this.DoResultFromSuperSel));
            frm.ShowDialog();
        }

    }
}
