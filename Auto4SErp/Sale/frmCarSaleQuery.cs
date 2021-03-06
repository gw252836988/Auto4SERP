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
using Bll.Sale;
namespace Auto4SErp.Sale
{
    public partial class frmCarSaleQuery : ifrmBase
    {
        private ICarSale mICarSale;

        private List<SqlElement> mLstE;
        private int status = -1;
        private bool isSelect = false;

        public bool IsSaler
        {
            get;
            set;

        }
        public bool IsSelect
        {
            get { return isSelect; }
            set { isSelect = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public frmCarSaleQuery()
        {
            InitializeComponent();
            mICarSale = BllFactory.GetCarSaleBll();
            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            List<Pair> lst = AssginToListOfQuery();
            mLstE = CreateMedialSqlElement(lst);
            DoQuery();
        }


        protected override void DoQuery()
        {


            DataTable dt;
            string strBegin = "";
            string strEnd = "";
            int tmpRecordCount;
            int tmpPageCount;
            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            }


            dt = mICarSale.GetCarSalesByQuery(strBegin, strEnd, mLstE, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount, IsSaler);
            DataToControl(dt);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();

        }


        private void DataToControl(DataTable dt)
        {
            //FrmAssist.UpdateColumns(ref mDicOfCarDoc, dt, 1);
            //FrmAssist.UpdateColumns(ref mDicOfCustomer, dt, 2);
            //FrmAssist.UpdateColumns(ref mDicOfCarSale, dt, 7);
            dgCarSale.AutoGenerateColumns = false;
            dgCarSale.DataSource = dt;



        }



        private void dgCarSale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isSelect)
            {
                if (dgCarSale.SelectedRows.Count != 0)
                {
                    DataGridViewRow seldr = dgCarSale.SelectedRows[0];
                    string strbh = seldr.Cells["DH"].Value.ToString();

                    if (m_del != null)
                    {
                        m_del(strbh);
                    }
                    this.Close();
                }
            }
            else
            {
                if (dgCarSale.SelectedRows.Count != 0)
                {
                    DataGridViewRow seldr = dgCarSale.SelectedRows[0];
                    string strdh = seldr.Cells[0].Value.ToString();

                    frmCarSale frm = new frmCarSale();
                    frm.DH = strdh;
                    frm.setRefreshDelegate(delegate(bool isR)
                    {
                        DoQuery();


                    });
                    frm.ShowDialogEx();

                }

            }
        }

        private void frmDlgCarSaleQuery_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            string strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            string strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";
            //  DataTable dt;
            //if (status == -1)
            //{
            //    //dt=mICarSale.GetCarSalesByQuery(strBegin, strEnd, null);

            //}
            //else
            //{
            //    cmbStatus.SelectedIndex = status;
            //    cmbStatus.Enabled = false;
            //    SqlElement sqlE = new SqlElement() {Name="Status",Value=status.ToString(),IsFuzzy=false,IsStr=false };
            //    mLstE = new List<SqlElement>();
            //    mLstE.Add(sqlE);
            //    //dt = mICarSale.GetCarSalesByQuery(strBegin, strEnd, mLstE);
            //}

            //  DataToControl(dt);
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());


            mLstControls.Add(txtCustName);
            mLstControls.Add(txtMobile);
            mLstControls.Add(cmbStatus);
            mLstControls.Add(txtDH);
            mLstControls.Add(txtSaleMan);
            mLstControls.Add(txtVin);



            if (isSelect)
            {
                tbtnAdd.Visible = false;
                tbtnOpen.Visible = false;
                cmbStatus.SelectedIndex = -1;
                //    cmbStatus.Enabled = false;

            }
            SetTButtonPng(toolStrip1);
            if (Comm.LoginInfoShare.getInstance().PositionName == "销售顾问")
                IsSaler = true;
            if (isSelect == false)
                DoQuery();

        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            frmCarSale frm = new frmCarSale();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                DoQuery();


            });

            frm.ShowDialogEx();
        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {

            if (dgCarSale.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCarSale.SelectedRows[0];
                string strdh = seldr.Cells["DH"].Value.ToString();

                frmCarSale frm = new frmCarSale();
                frm.DH = strdh;
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                        DoQuery();


                });
                frm.ShowDialog();

            }



        }

        private void chbIsDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsDate.Checked)
            {
                datBegin.Enabled = true;
                datEnd.Enabled = true;
            }
            else
            {
                datBegin.Enabled = false;
                datEnd.Enabled = false;
            }
        }
    }
}
