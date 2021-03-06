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
using Model;
namespace Auto4SErp.Repair
{
    public partial class frmDlgRepairItem : ifrmBase
    {

        private string typeCode;
        private IRepairItem mIRepairItemBll;
        private int status = 0;
        private string itemCode;
        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }


        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private string spellCode;

        public string SpellCode
        {
            get { return spellCode; }
            set { spellCode = value; }
        }

        public string TypeCode
        {
            get { return typeCode; }
            set { typeCode = value; }
        }

        public frmDlgRepairItem()
        {
            InitializeComponent();
            mIRepairItemBll = Bll.BllFactory.GetRepairItemBll();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RepairItem obj = AssginToModel();

            if (obj == null) return;
            if (status == 0)
            {
                mIRepairItemBll.AddRepariItem(obj);
                ShowMessage("添加成功");
            }
            else
            {
                mIRepairItemBll.UpdateRepairItem(obj);
                ShowMessage("更新成功");


            }
            IsModify = true;
        }

        private RepairItem AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;
            RepairItem entity = FrmAssist.PopulateEntityFromCollection<RepairItem>(null, lstPairs);
            return entity;
        }

        private void frmDlgRepairItem_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtItemName);
            mLstControls.Add(txtItemType);
            mLstControls.Add(txtItemCode);
            mLstControls.Add(txtSpellCode);
            if (status == 0)
            {
                // txtItemCode.ReadOnly = true;
                //  txtItemType.ReadOnly = true;
                txtItemType.Text = typeCode;
            }
            else if (status == 1)
            {
                //txtItemCode.ReadOnly = false;
                // txtItemType.ReadOnly = true;
                txtItemCode.Text = itemCode;
                txtItemName.Text = itemName;
                txtItemType.Text = typeCode;
                txtSpellCode.Text = spellCode;
            }
            SetTButtonPng(toolStrip1);
        }


    }
}
