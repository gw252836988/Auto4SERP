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
using Bll.Repair;
using Comm;
using Auto4SErp.Sale;
using Bll.Sale;
namespace Auto4SErp.Report
{
    public partial class frmRRepair : ifrmBase
    {
        private List<SqlElement> mLstE;
        private IRepair mIRepair;
        private bool mIsOut = false;
        private ICarDoc mICarDoc;
        public frmRRepair()
        {
            mIRepair = BllFactory.GetRepariBll();
            mICarDoc = BllFactory.GetCarDocBll();
            InitializeComponent();

            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {


        }

        protected override void DoQuery()
        {
            string strBegin = "";
            string strEnd = "";
            int tmpRecordCount;
            int tmpPageCount;
            List<string> lstStatus = null;
            if (cmbStatus.SelectedIndex == 1)
            {
                lstStatus = new List<string>();
                if (chbPreAccount.Checked == true)
                    lstStatus.Add("2");

                if (chbWorking.Checked == true)
                {
                    lstStatus.Add("1");
                    lstStatus.Add("0");
                }

                if (chbPreAccount.Checked == false && chbWorking.Checked == false)
                {
                    lstStatus.Add("100");

                }

            }
            else if (cmbStatus.SelectedIndex == 2)
            {
                lstStatus = new List<string>();
                lstStatus.Add("3");
            }

            if (txtDate.SelectedIndex != 0)
            {
                strBegin = dtpBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = dtpEnd.Value.ToShortDateString() + " 23:59:59";

            }

            if (mIsOut)
            {
                DataTable dtout = mIRepair.GetOutRepairsOfQuery(mLstE, txtDate.SelectedIndex, strBegin, strEnd, lstStatus);
                ExcelInAndOut eio = new ExcelInAndOut("");

                eio.DTOutTo(dtout, dgRepair);
                return;

            }
            DataTable dt = mIRepair.GetRepairsOfQuery(mLstE, txtDate.SelectedIndex, strBegin, strEnd, lstStatus, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            dgRepair.AutoGenerateColumns = false;
            dgRepair.DataSource = dt;
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();
            DataTable dtsum = mIRepair.GetSumRepairsOfQuery(mLstE, txtDate.SelectedIndex, strBegin, strEnd, lstStatus);
            string result = "0";
            if (dtsum.Rows.Count > 0)
                result = dtsum.Rows[0][0].ToString();
            lblSum.Text = string.Format("合计 应收金额:{0}", result);
        }

        private void frmR_Repair_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtDH);
            mLstControls.Add(txtPlateNum);
            mLstControls.Add(txtReceptMan);
            mLstControls.Add(cmbRepType);
            mLstControls.Add(cmbRepChildType);
            mLstControls.Add(txtCarModel);
            mLstControls.Add(txtCustName);
            mLstControls.Add(txtVin);

            //mLstSenstiveTB.Add(tbtnOut);
            //CheckSPsOfStaff(this.Name.Substring(3));
            SetTButtonPng(toolStrip1);

            DateTime dtNow = DateTime.Now;
            dtpBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            string strBegin = dtpBegin.Value.ToShortDateString() + " 00:00:00";
            string strEnd = dtpEnd.Value.ToShortDateString() + " 23:59:59";
            txtDate.SelectedIndex = 1;

        }

        private void txtDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDate.SelectedIndex != 0)
            {
                dtpBegin.Enabled = true;
                dtpEnd.Enabled = true;

            }
            else
            {
                dtpBegin.Enabled = false;
                dtpEnd.Enabled = false;

            }
        }

        private void cmbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex == 1)

                gpStatus.Enabled = true;
            else
            {
                gpStatus.Enabled = false;
                chbPreAccount.Checked = false;
                chbWorking.Checked = false;

            }

        }

        private void cmbRepType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRepChildType.Items.Clear();
            if (cmbRepType.SelectedIndex == 1)
            {
                cmbRepChildType.Items.Add("一般维修");
                cmbRepChildType.Items.Add("事故维修");
                cmbRepChildType.Items.Add("总成大修");
                cmbRepChildType.Items.Add("免费保养");
                //cmbRepChildType.Items.Add("首保");
                cmbRepChildType.Items.Add("常规保养");
                cmbRepChildType.Items.Add("自费事故维修");
                cmbRepChildType.Items.Add("索赔");
                cmbRepChildType.Items.Add("PDI");
                cmbRepChildType.Items.Add("免费检测");

            }
            else if (cmbRepType.SelectedIndex == 2)
            {
                cmbRepChildType.Items.Add("销售装潢");
                cmbRepChildType.Items.Add("售后装潢");
                cmbRepChildType.SelectedIndex = 0;
            }
            else if (cmbRepType.SelectedIndex == 2)
            {
                cmbRepChildType.Items.Clear();

            }



        }

        private void btnOut_Click(object sender, EventArgs e)
        {


        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            if (dgRepair.SelectedRows.Count != 0)
            {
                Auto4SErp.Repair.frmRepair frm = new Auto4SErp.Repair.frmRepair();
                DataGridViewRow seldr = dgRepair.SelectedRows[0];
                string strdh = seldr.Cells[1].Value.ToString();
                frm.DH = strdh;
                frm.ShowDialogEx();

            }
        }

        private void tbtnOut_Click(object sender, EventArgs e)
        {
            //ExcelInAndOut eio = new ExcelInAndOut("");
            ////eio.Title = "维修查询";
            //DataTable dt = dgRepair.DataSource as DataTable;
            //eio.NewDTOutTo((DataGridView)dgRepair);

            //mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            //ExcelInAndOut eio = new ExcelInAndOut("");
            //DataTable dt = mIRepair.GetOutRepairsOfQuery();
            mIsOut = true;
            DoQuery();
        }

        private void btnCarDocSel_Click(object sender, EventArgs e)
        {
            frmCarDoc frm = new frmCarDoc();
            frm.IsSelect = true;
            frm.setTransferDelegate(delegate(object obj)
            {
                //int id = int.Parse(obj.ToString());
                string autonumber = (string)obj;
                CarDetail o = mICarDoc.GetCarDetailObjectByAutoNumber(autonumber);

                txtCarModel.Text = o.CarModel;


            });
            frm.ShowDialogEx();
        }


    }
}
