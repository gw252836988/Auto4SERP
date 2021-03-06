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
    public partial class frmPosition : ifrmBase
    {
        private IPosition mIPosition;
        private DataTable mPosition;
        private string departMentID = "";

        public string DepartMentID
        {
            get { return departMentID; }
            set { departMentID = value; }
        }

        public frmPosition()
        {
            InitializeComponent();
            mIPosition = BllFactory.GetPositionBll();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            //Bind();
        }
        private DataTable GetPositions()
        {
            DataTable dt = mIPosition.GetPositions();
            return dt;
        }
        private void DataToControl(DataTable dt)
        {
            FrmAssist.UpdateColumns(ref mPosition, dt, 14);
            dgvPosition.DataSource = dt;
            this.dgvPosition.Columns["id"].Visible = false;

        }
        private void Bind()
        {
            // dgvPosition.DataSource = null;

            DataToControl(GetPositions());


        }



        private void tsmAdd_Click(object sender, EventArgs e)
        {
            frmDlgPosition frm = new frmDlgPosition();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                if (isR)
                {
                    Bind();
                }
            });
            frm.ShowDialogEx();
        }


        private void BindByDepartment()
        {

            DataToControl(mIPosition.GetPositionsByDepartmentID(departMentID));
        }
        private void frmPosition_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(departMentID))
                Bind();
            else
                BindByDepartment();
            //SetTButtonPng(toolStrip1);

        }

        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPosition.Rows.Count > 0 && dgvPosition.CurrentCell.RowIndex >= 0)
            {
                object obj = dgvPosition.Rows[dgvPosition.CurrentCell.RowIndex].Cells["id"].Value;
                int id = Convert.ToInt32(obj);
                frmDlgPosition frm = new frmDlgPosition();
                frm.Positionid = id;
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                    {
                        Bind();
                    }
                });
                frm.ShowDialogEx();



            }
        }

        private void tsmDel_Click(object sender, EventArgs e)
        {
            if (dgvPosition.Rows.Count > 0 && dgvPosition.CurrentCell.RowIndex >= 0)
            {
                object obj = dgvPosition.Rows[dgvPosition.CurrentCell.RowIndex].Cells["id"].Value;
                int id = Convert.ToInt32(obj);
                if (MessageBox.Show("是否确认删除?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool result = mIPosition.DelDepartmentByID(id.ToString());
                    if (result)
                    {
                        Bind();
                    }
                }



            }
        }

        private void dgvPosition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(departMentID))
            {

                if (dgvPosition.SelectedRows.Count != 0)
                {
                    DataGridViewRow seldr = dgvPosition.SelectedRows[0];
                    string strid = seldr.Cells[0].Value.ToString();
                    string strname = seldr.Cells[1].Value.ToString();
                    if (m_del != null)
                        m_del(strid + "," + strname);
                    this.Close();
                }


            }
        }

    }
}
