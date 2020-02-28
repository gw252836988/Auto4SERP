using System;
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
using Bll;
using Comm;
namespace Auto4SErp.Repair
{
    public partial class frmAccElseOut : ifrmBase
    {
        private IAccElseOut mIAccElseOut;
        private IRepairAccessory mIRepairAccessory;
        private IAccessory mIAccessory;
        private IExtend mIExtend;
        private IRepair mIRepair;
        private int status = -1;
        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public frmAccElseOut()
        {
            InitializeComponent();
            mIAccElseOut = Bll.BllFactory.GetAccElseOutBll();
            mIRepairAccessory = Bll.BllFactory.GetRepairAccessoryBll();
            mIAccessory = Bll.BllFactory.GetAccessoryBll();
            mIExtend = Bll.BllFactory.GetExtendBll();
            mIRepair = Bll.BllFactory.GetRepariBll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtDH.Text))
            {

                if (string.IsNullOrEmpty(cmbOutType.Text))
                {
                    ShowMessage("请选择出库方式");
                    return;
                }
                if (string.IsNullOrEmpty(cmbOutToUnit.Text))
                {
                    ShowMessage("请输入出库对象");
                    return;
                }


                List<SqlElement> lst = new List<SqlElement>();
                lst.Add(new SqlElement("OutToUnit", cmbOutToUnit.Text, true));
                lst.Add(new SqlElement("OutType", cmbOutType.Text, true));
                lst.Add(new SqlElement("Creator", Comm.LoginInfoShare.getInstance().UserName, true));
                lst.Add(new SqlElement("DH", "dbo.GetElseAccOutDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", false));

                txtDH.Text = mIAccElseOut.GetDHOfAddAccElseOut(lst);
                txtCreateDate.Text = DateTime.Now.ToString();
                status = 0;
                SetStatus(status);
                IsModify = true;
            }
            else
            {
                List<SqlElement> lst = new List<SqlElement>();
                lst.Add(new SqlElement("OutToUnit", cmbOutToUnit.Text, true));
                //lst.Add(new SqlElement("OutType", cmbOutType.Text, true));
                mIAccElseOut.UpdateAccElseOut(lst, dH);
                IsModify = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDH.Text)) return;
            frmDlgTakeAcc frm = new frmDlgTakeAcc();
            frm.DH = txtDH.Text;
            frm.OutType = cmbOutType.Text;
            frm.setRefreshDelegate(delegate(bool isR)
            {
                if (isR)
                {

                    RefreshRepairAcc();


                }


            });
            frm.ShowDialogEx();
        }


        private void RefreshRepairAcc()
        {
            dgAccessory.AutoGenerateColumns = false;
            dgAccessory.DataSource = mIRepairAccessory.GetAccessorysOfRepairAsTake(txtDH.Text);
            txtSum.Text = mIRepair.GetForeAccAmountOfDH(txtDH.Text).ToString();
        }

        private void btnCompelte_Click(object sender, EventArgs e)
        {
            mIAccElseOut.SetCompleteOfStatus(txtDH.Text);
            status = 1;
            SetStatus(status);
            IsModify = true;
        }


        private void SetStatus(int status)
        {
            if (status == -1)
            {
                btnAdd.Enabled = false;
                btnRecede.Enabled = false;
                btnComplete.Enabled = false;
            }
            else if (status == 0)
            {
                btnAdd.Enabled = true;
                btnRecede.Enabled = true;
                btnComplete.Enabled = true;

            }
            else if (status == 1)
            {
                btnAdd.Enabled = false;
                btnRecede.Enabled = false;
                btnComplete.Enabled = false;

            }

        }

        private void frmAccElseOut_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            SetStatus(status);


            LoadExtendContents("出库方式", cmbOutType);
            DataTable dtUnits = mIExtend.GetSupplyUnits("售后");
            for (int i = 0; i < dtUnits.Rows.Count; i++)
            {
                cmbOutToUnit.Items.Add(dtUnits.Rows[i][1].ToString());
            }

            if (!string.IsNullOrEmpty(dH))
            {
                DataTable dt = mIAccElseOut.GetElseOutBill(dH);
                txtDH.Text = dt.Rows[0]["DH"].ToString();
                txtCreateDate.Text = dt.Rows[0]["CreateDate"].ToString();
                cmbOutType.Text = dt.Rows[0]["OutType"].ToString();
                cmbOutToUnit.Text = dt.Rows[0]["OutToUnit"].ToString();
                int tmpstatus = int.Parse(dt.Rows[0]["status"].ToString());
                SetStatus(tmpstatus);
                RefreshRepairAcc();
            }
            else
                cmbOutType.SelectedIndex = -1;
        }

        private void btnRecede_Click(object sender, EventArgs e)
        {
            //if (dgAccessory.SelectedRows.Count != 0)
            //{
            //    DataGridViewRow seldr = dgAccessory.SelectedRows[0];



            //    int xh = int.Parse(seldr.Cells[9].Value.ToString());
            //    if (!mIAccessory.IsCanRecede(txtDH.Text, xh))
            //    {
            //        ShowMessage("已经退料，无法再退");
            //        return;
            //    }
            //    AccessoryOfRep obj = new AccessoryOfRep();
            //    obj.AccType = 2;
            //    obj.AccessoryCode = seldr.Cells[1].Value.ToString();
            //    obj.HouseName = seldr.Cells[3].Value.ToString();
            //    obj.Amount = float.Parse(seldr.Cells[4].Value.ToString());
            //    obj.SalePrice = float.Parse(seldr.Cells[5].Value.ToString());
            //    obj.DH = txtDH.Text;
            //    obj.TakeMan = Comm.LoginInfoShare.getInstance().UserName;
            //    mIRepairAccessory.AddAccessoryOfRepair(obj);


            //    mIAccessory.AccessoryOutRecede(txtDH.Text, xh);
            //    RefreshRepairAcc();
            //}
            if (dgAccessory.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgAccessory.SelectedRows[0];



                int xh = int.Parse(seldr.Cells[9].Value.ToString());
                if (!mIAccessory.IsCanRecede(txtDH.Text, xh))
                {
                    ShowMessage("已经退料，无法再退");
                    return;
                }


                mIAccessory.AccessoryOutRecede(txtDH.Text, xh);
                RefreshRepairAcc();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dH))
            {
                IsModify = true;
                if (!mIAccElseOut.DelElseOutBill(dH))
                {

                    ShowMessage("该单据存在领料，无法删除");

                }
                else
                    this.Close();



            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDH.Text)) return;
            DataTable dt = mIRepairAccessory.GetAccessorysOfTakePrint(txtDH.Text, "0");

            if (dt.Rows.Count <= 0)
            {
                ShowMessage("没有领料信息");
                return;

            }
            DataTable dtAppend = new DataTable();
            dtAppend.Columns.Add("CustName", typeof(string));
            dtAppend.Columns.Add("DH", typeof(string));
            dtAppend.Columns.Add("DateTime", typeof(string));
            dtAppend.Columns.Add("OperateMan", typeof(string));
            dtAppend.Columns.Add("JE", typeof(string));

            DataRow dr = dtAppend.NewRow();
            dr[0] = cmbOutToUnit.Text;
            dr[1] = txtDH.Text;
            dr[2] = DateTime.Now.ToString();
            dr[3] = Comm.LoginInfoShare.getInstance().UserName;
            dr[4] = txtSum.Text;
            dtAppend.Rows.Add(dr);

            Dictionary<string, DataTable> dic = new Dictionary<string, DataTable>();
            dic.Add("RepAccessory", dt);
            dic.Add("Append", dtAppend);

            frmPrint frm = new frmPrint();
            //frm.DataSource = dt;
            //frm.SourceName = "RepAccessory";
            frm.DicTable = dic;
            frm.ReportFile = "TakeAcc.rdlc";
            frm.ShowDialog();
        }

        private void btnCustomerFind_Click(object sender, EventArgs e)
        {
            frmSupplyUnit frm = new frmSupplyUnit();
            frm.ShowDialogEx();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mIAccElseOut.SetOperateOfStatus(txtDH.Text);
            status = 0;
            SetStatus(status);
            IsModify = true;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut i = new ExcelInAndOut("");
            i.NewDTOutTo(dgAccessory);
        }
    }
}
