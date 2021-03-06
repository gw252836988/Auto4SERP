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
using System.IO;
using Comm;
namespace Auto4SErp.Sale
{
    public partial class frmCarStock : ifrmBase
    {
        private ICarStock mICarStock;
        //private DataTable mDicOfCarDoc;
        //private DataTable mDicOfCarStock;
        private List<SqlElement> mLstE;
        private bool isSelect = false;
        private int m_countofstock = 0;
        private int status = -1;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public bool IsSelect
        {
            get { return isSelect; }
            set { isSelect = value; }
        }


        private bool mIsOut = false;
        //private int detailID=0; 

        //public int DetailID
        //{
        //    get { return detailID; }
        //    set { detailID = value; }
        //}


        public frmCarStock()
        {
            InitializeComponent();
            mICarStock = BllFactory.GetCarStockBll();
        }


        public string AutoNumberOfStock
        {
            get;
            set;

        }
        private void frmCarStock_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtCarSer);
            mLstControls.Add(txtCarModel);
            mLstControls.Add(cmbColor);
            mLstControls.Add(cmbDisplacement);
            mLstControls.Add(cmbStorePlace);
            mLstControls.Add(txtVin);
            mLstControls.Add(cmbStatus);
            LoadExtendContents("存放位置", cmbStorePlace);
            LoadExtendContents("车身颜色", cmbColor);
            cmbStorePlace.SelectedIndex = -1;
            cmbColor.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            if (isSelect)
            {
                //if (detailID > 0)
                //{
                //    mLstE = new List<SqlElement>();
                //    SqlElement sqlE = new SqlElement();
                //    sqlE.Name = "DetailID";
                //    sqlE.Value = detailID.ToString();
                //    sqlE.IsFuzzy = false;
                //    sqlE.IsStr = false;
                //    mLstE.Add(sqlE);
                //    DoQuery();
                //}

                if (status != -1)
                {
                    mLstE = new List<SqlElement>();
                    SqlElement sqlE = new SqlElement();
                    sqlE.Name = "Status";
                    sqlE.Value = status.ToString();
                    sqlE.IsFuzzy = false;
                    sqlE.IsStr = false;
                    mLstE.Add(sqlE);
                    mLstE.Add(new SqlElement { Name = "AutoNumber", Value = AutoNumberOfStock, IsFuzzy = false, IsStr = true });
                    DoQuery();
                    if (!string.IsNullOrEmpty(AutoNumberOfStock))
                        tbtnQuery.Enabled = false;

                }
                cmbStatus.Enabled = false;

            }
            else
                StartWork(null);

            SetTButtonPng(toolStrip1);
        }



        protected override void DoworkInBack(object sender, DoWorkEventArgs e)
        {
            DataTable dt = mICarStock.GetCarsOfStock();

            e.Result = dt;

        }

        protected override void DoBackatCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataTable dt = (DataTable)e.Result;
            DataToControl(dt, true);

        }


        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            List<Pair> lst = AssginToListOfQuery();
            mLstE = CreateMedialSqlElement(lst);

            DoQuery();
        }

        protected override void DoQuery()
        {

            if (mLstE != null)
            {
                if (mLstE.Count > 0)
                {


                    DataTable dt = mICarStock.GetCarsOfStockByQuery(mLstE, igiDays.Value);
                    DataToControl(dt, false);
                    return;
                }
            }


            DataToControl(mICarStock.GetCarsOfStock(), true);




        }


        private void DataToControl(DataTable dt, bool isflag)
        {
            //FrmAssist.UpdateColumns(ref mDicOfCarDoc, dt, 5);
            //FrmAssist.UpdateColumns(ref mDicOfCarStock, dt, 1);


            if (mIsOut)
            {
                Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
                io.DTOutTo(dt, null);
                mIsOut = false;
                return;

            }

            dgCarStock.AutoGenerateColumns = false;
            dgCarStock.DataSource = dt;

            if (isflag)
            {
                int overstock;
                decimal rate;
                m_countofstock = dt.Rows.Count;
                overstock = mICarStock.GetOverCountOfStock();
                if (m_countofstock > 0)
                {
                    rate = (decimal)overstock / (decimal)m_countofstock;
                    rate = Math.Round(rate, 2);
                    lblOver.Text = string.Format("超龄库存(>90)占比:{0}", rate);
                }
            }
            lblSum.Text = "数量:" + dt.Rows.Count;
            dgCarStock.Columns["ID"].Visible = false;
            dgCarStock.Columns["ItemIDFrom"].Visible = false;
            dgCarStock.Columns["DetailID"].Visible = false;

        }


        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (dgCarStock.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCarStock.SelectedRows[0];

                if (ShowMessageOfWarning("确定删除吗") == DialogResult.OK)
                {
                    mICarStock.DeleteCarStock(seldr.Cells[0].Value.ToString(), seldr.Cells[15].Value.ToString());
                    DoQuery();
                }
            }

        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgCarStock.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCarStock.SelectedRows[0];

                CarStock obj = new CarStock();

                obj.ID = (int)seldr.Cells[0].Value;
                string inprice;
                if (seldr.Cells["inprice"].Value == null)
                {
                    inprice = "0";
                }
                else
                    inprice = ElseUtil.ReturnZero(seldr.Cells["inprice"].Value.ToString());

                obj.InPrice = decimal.Parse(inprice);

                obj.StorePlace = seldr.Cells["StorePlace"].Value.ToString();
                obj.Vin = seldr.Cells["Vin"].Value.ToString();
                obj.AutoNumber = seldr.Cells["AutoNumber"].Value.ToString();
                //  obj.Image = seldr.Cells["Image"].Value.ToString();
                frmDlgCarStockModify frm = new frmDlgCarStockModify();
                frm.CarStock = obj;
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR) DoQuery();

                });
                frm.ShowDialogEx();

            }
        }

        private void dgCarStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isSelect)
            {
                if (dgCarStock.SelectedRows.Count != 0)
                {
                    DataGridViewRow seldr = dgCarStock.SelectedRows[0];
                    string strAutoNumber = seldr.Cells["AutoNumber"].Value.ToString();
                    string strVin = seldr.Cells["Vin"].Value.ToString();

                    CarStock obj = new CarStock();
                    obj.AutoNumber = strAutoNumber;
                    obj.Vin = strVin;

                    if (m_del != null)
                    {
                        m_del(obj);
                    }
                    this.Close();

                }
            }
        }

        private void dgCarStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCarStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory;
            //string imgpath;
            //if (dgCarStock.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow dr = dgCarStock.SelectedRows[0];

            //    string img = dr.Cells["image"].Value.ToString();


            //        if (!string.IsNullOrEmpty(img))
            //        {
            //            imgpath = path + "img\\" + img;
            //            if (File.Exists(imgpath))
            //            {
            //                picCar.ImageLocation = imgpath;
            //                lblInfo.Text = "";
            //            }
            //            else
            //                lblInfo.Text = "未找到图片";

            //        }


            //}
        }

        private void dgCarStock_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //ExcelInAndOut eio = new ExcelInAndOut("");
            ////eio.Title = "维修查询";
            //DataTable dt = dgCarStock.DataSource as DataTable;
            //eio.DTOutTo((DataGridView)dgCarStock);

            List<Pair> lst = AssginToListOfQuery();
            mLstE = CreateMedialSqlElement(lst);
            mIsOut = true;
            DoQuery();
        }


    }
}
