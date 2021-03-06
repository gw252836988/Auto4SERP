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
using Bll;
using Model;
using Comm;
namespace Auto4SErp.Repair
{
    public partial class frmAccWareQuery : ifrmBase
    {
        private IAccessory mIAccessory;
        private List<SqlElement> mLstE;
        private DataTable mDtAccOfDic;
        public frmAccWareQuery()
        {
            InitializeComponent();
            mIAccessory = BllFactory.GetAccessoryBll();
            //tsbFirst = bindingNavigatorMoveFirstItem;
            //tsbLast = bindingNavigatorMoveLastItem;
            //tsbPre = bindingNavigatorMovePreviousItem;
            //tsbNext = bindingNavigatorMoveNextItem;
            //tstbPageCount = bindingNavigatorCountItem;
            //tstbPageCurrent = bindingNavigatorPositionItem;
            //tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

            DoQuery();
        }


        protected override void DoQuery()
        {
            string items = "";


            string strBegin = "";
            string strEnd = "";
            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            }


            mLstE = CreateMedialSqlElement(AssginToListOfQuery());

            if (chbDH.Checked == true) items = items + "DHFrom,";
            if (chbHouseName.Checked == true) items = items + "HouseName,";
            if (chbIndate.Checked == true) items = items + "InDate,";
            if (chbInType.Checked == true) items = items + "InType,";

            if (chbInPrice.Checked == true) items = items + "InPrice,";

            if (items.Length > 0)
                items = items.Remove(items.Length - 1);

            DataTable dt = mIAccessory.GetAccWareInfo(items, mLstE, strBegin, strEnd, igiDays.Value);
            FrmAssist.UpdateColumns(ref mDtAccOfDic, dt, 13);
            dgAccWare.DataSource = dt;

            DataTable dtSum = mIAccessory.GetSumAccWare(mLstE, strBegin, strEnd, igiDays.Value);
            ShowSumAmount(dtSum);

        }

        private void ShowSumAmount(DataTable dt)
        {
            //float sum = 0;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    sum =sum+ float.Parse(dt.Rows[i][2].ToString());

            //}
            //lblSum.Text = "总数量：" + sum.ToString();
            if (dt != null)
                lblSum.Text = string.Format("总数量:{0} 总金额：{1}(加权平均)", dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString());


        }


        private void frmAccWareQuery_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtAccessoryCode);
            mLstControls.Add(txtAccessoryName);
            mLstControls.Add(cmbHouseName);
            mLstControls.Add(txtSmallType);
            mLstControls.Add(txtApplicationModel);
            mLstControls.Add(txtStorePlace);
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");


            DataTable dt;
            dt = mIAccessory.GetWareHouses();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    cmbHouseName.Items.Add(dt.Rows[i][0].ToString());
            //}
            //cmbHouseName.SelectedIndex = 0;
            LoadExtendContents("仓库名称", cmbHouseName);
            cmbHouseName.SelectedIndex = -1;
            SetTButtonPng(toolStrip1);

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut i = new ExcelInAndOut("");
            i.NewDTOutTo(dgAccWare);
        }
    }
}
