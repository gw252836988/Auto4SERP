﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll.Repair;
namespace Auto4SErp.Repair
{
    public partial class frmDlgRepairType : ifrmBase
    {

        private string parentCode;
        private string typeCode;
        private IRepairItem mIRepairItem;
        private int status = 0;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }


        public string TypeCode
        {
            get { return typeCode; }
            set { typeCode = value; }
        }

        public string ParentCode
        {
            get { return parentCode; }
            set { parentCode = value; }
        }
        public frmDlgRepairType()
        {
            InitializeComponent();
            mIRepairItem = Bll.BllFactory.GetRepairItemBll();
        }

        private void frmDlgRepairType_Load(object sender, EventArgs e)
        {



            if (status == 0)
            {
                txtTypeCode.ReadOnly = false;


            }
            else if (status == 1)
            {
                txtTypeCode.ReadOnly = true;

            }
            else if (status == 2)
            {
                txtTypeCode.ReadOnly = true;
                if (!String.IsNullOrEmpty(typeCode))
                {
                    DataTable dt = mIRepairItem.GetRepairTypeByCode(typeCode);
                    if (dt.Rows.Count > 0)
                    {
                        txtTypeCode.Text = dt.Rows[0]["TypeCode"].ToString();
                        txtTypeName.Text = dt.Rows[0]["TypeName"].ToString();

                    }
                }
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                if ((txtTypeCode.Text.Length) != 2)
                {
                    ShowMessage("根类别的编码必须是2位字符");
                    return;
                }
                if (!mIRepairItem.AddRootType(txtTypeCode.Text, txtTypeName.Text))
                {
                    ShowMessage("添加根类别失败，可能已重复");
                    return;

                }
                else
                    txtTypeName.Text = "";

            }
            else if (status == 1)
            {
                mIRepairItem.AddChildType(parentCode, txtTypeName.Text);
                txtTypeName.Text = "";

            }
            else if (status == 2)
            {
                mIRepairItem.UpdateRepairType(typeCode, txtTypeName.Text);

            }
            // this.Close();
            ShowMessage("添加成功");
            IsModify = true;
        }
    }
}
