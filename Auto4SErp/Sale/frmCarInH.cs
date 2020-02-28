using System;
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
using Comm;
namespace Auto4SErp.Sale
{
    public partial class frmCarInH : ifrmBase
    {
        private ICarStock mICarStock;
        private DataTable mDicOfCarInD;
        private DataTable mDicOfCarDoc;
        // private bool mIsAdd=true;
        private IExtend mIExtend;

        private string dH = "";

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        public frmCarInH()
        {
            InitializeComponent();
            mICarStock = BllFactory.GetCarStockBll();
            mIExtend = BllFactory.GetExtendBll();
        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            CarInH obj = AssginToModel();
            if (obj != null)
            {
                obj.InDate = datInDate.Value.ToShortDateString();
                if (txtDH.Text == "")
                {
                    obj.OperatorMan = LoginInfoShare.getInstance().UserName;
                    string dh = mICarStock.GetDHOfAddCarInH(obj);
                    txtDH.Text = dh;
                    IsModify = true;
                    //  mIsAdd = false;
                }
                else
                {
                    obj.DH = txtDH.Text;
                    mICarStock.UpdateCarInH(obj);
                    IsModify = true;

                }


            }
        }

        //private void SetStatus(int status)
        //{




        //}

        private CarInH AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;


            CarInH entity = FrmAssist.PopulateEntityFromCollection<CarInH>(null, lstPairs);
            return entity;

        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control c in mLstControls)
            {
                c.Text = "";
            }
            dgCarInD.DataSource = null;
            cMenuCarInD.Enabled = true;
            this.Text = "车辆入库单";
        }

        private void frmCarInH_Load(object sender, EventArgs e)
        {
            // mLstControls.Add(txtDH);
            mLstControls.Add(datInDate);
            mLstControls.Add(cmbSupplier);
            mLstControls.Add(cmbInPattern);
            mLstControls.Add(txtRemark);

            // txtInDate.Text = DateTime.Now.ToShortDateString();
            LoadExtendContents("入库方式", cmbInPattern);
            if (dH != "")
            {
                CarInH o = mICarStock.GetCarInH(dH);
                txtDH.Text = o.DH;
                // txtInDate.Text = o.InDate.Substring(0, o.InDate.Length - 8);
                datInDate.Value = DateTime.Parse(o.InDate);
                txtRemark.Text = o.Remark;
                cmbSupplier.Text = o.Supplier;
                cmbInPattern.Text = o.InPattern;
                if (o.Status == 1)
                {
                    cMenuCarInD.Enabled = false;
                    this.Text = "车辆入库单(已入库)";
                }
                else
                {
                    cMenuCarInD.Enabled = true;
                    this.Text = "车辆入库单";
                }
                RefreshCarInD();

            }
            DataTable dt = mIExtend.GetSupplyUnits("销售");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbSupplier.Items.Add(dt.Rows[i][1].ToString());
            }


            SetTButtonPng(toolStrip1);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDH.Text != "")
            {
                frmDlgCarInD frm = new frmDlgCarInD();

                frm.DH = txtDH.Text;
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR) RefreshCarInD();
                });
                frm.ShowDialogEx();
            }
            else
                ShowMessage("请先保存单据");
        }

        private void RefreshCarInD()
        {
            string dh = txtDH.Text;
            DataTable dt = mICarStock.GetCarInDs(dh);
            FrmAssist.UpdateColumns(ref mDicOfCarInD, dt, 4);
            FrmAssist.UpdateColumns(ref mDicOfCarDoc, dt, 1);

            dgCarInD.DataSource = dt;
            dgCarInD.Columns[0].Visible = false;
            dgCarInD.Columns[1].Visible = false;
            lblCount.Text = "当前入库数量：" + dgCarInD.Rows.Count;
        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgCarInD.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCarInD.SelectedRows[0];
                string strid = seldr.Cells[0].Value.ToString();
                CarInD obj = new CarInD();
                frmDlgCarInD frm = new frmDlgCarInD();
                obj.ID = int.Parse(strid);
                // obj.CarDetail = int.Parse(seldr.Cells[1].Value.ToString());
                obj.AutoNumber = seldr.Cells[2].Value.ToString();
                obj.InPrice = decimal.Parse(seldr.Cells[6].Value.ToString());
                obj.StorePlace = seldr.Cells[7].Value.ToString();
                obj.Vin = seldr.Cells[8].Value.ToString();
                frm.CarInD = obj;


                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR) RefreshCarInD();
                });
                frm.ShowDialogEx();

            }
        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            frmCarInHQuery frm = new frmCarInHQuery();
            frm.setTransferDelegate(delegate(object obj)
            {
                string dh = (string)obj;
                CarInH o = mICarStock.GetCarInH(dh);
                txtDH.Text = o.DH;
                //    txtInDate.Text = o.InDate.Substring(0,o.InDate.Length-8);
                datInDate.Value = DateTime.Parse(o.InDate);
                txtRemark.Text = o.Remark;
                cmbSupplier.Text = o.Supplier;
                cmbInPattern.Text = o.InPattern;
                if (o.Status == 1)
                {
                    cMenuCarInD.Enabled = false;
                    this.Text = "车辆入库单(已入库)";
                }
                else
                {
                    cMenuCarInD.Enabled = true;
                    this.Text = "车辆入库单";
                }
                RefreshCarInD();

            });
            frm.ShowDialogEx();
        }

        private void tbtnIn_Click(object sender, EventArgs e)
        {
            if (txtDH.Text != "")
            {
                if (mICarStock.IsInOfCarinH(txtDH.Text))
                {
                    ShowMessage("该单据已做入库处理");
                    return;
                }
                if (dgCarInD.Rows.Count > 0)
                {
                    mICarStock.DoCarInStock(txtDH.Text);
                    cMenuCarInD.Enabled = false;
                    ShowMessage("入库成功");
                    IsModify = true;
                }

            }
            else
            {
                ShowMessage("请先保存生成单号");
            }

        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgCarInD.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgCarInD.SelectedRows[0];
                string strid = seldr.Cells[0].Value.ToString();
                mICarStock.DelCarInD(strid);
                RefreshCarInD();

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtDH.Text != "")
            {
                if (!mICarStock.DelCarInH(txtDH.Text))
                {
                    ShowMessage("存在车辆增加记录，无法删除");

                }
                else
                {
                    IsModify = true;
                    this.Close();
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {


            if (mICarStock.CarInHIsBack(txtDH.Text))
            {

                if (ShowMessageOfWarning("单据回滚将删除该批次库存车，确定吗？") == DialogResult.OK)
                {
                    mICarStock.CarInHBack(txtDH.Text);

                }

            }
            else
            {
                ShowMessage("该单据存在非库存车，无法回滚");
            }
        }
    }
}
