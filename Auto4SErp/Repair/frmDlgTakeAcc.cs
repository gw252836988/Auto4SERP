using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bll;
using Bll.Repair;
namespace Auto4SErp.Repair
{
    public partial class frmDlgTakeAcc : ifrmBase
    {

        private IAccessory mIAccessory;
        private IRepairAccessory mIRepairAccessory;
        private string dH;
        private string itemName = "";
        private float discount;
        private IRepair mIRepair;
        private int mStep = 0;
        private string mAppendQuery;
        private string ChildType
        {
            get;
            set;

        }
        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        private string outType;

        public string OutType
        {
            get { return outType; }
            set { outType = value; }
        }

        public frmDlgTakeAcc()
        {
            mIAccessory = BllFactory.GetAccessoryBll();
            mIRepairAccessory = BllFactory.GetRepairAccessoryBll();
            mIRepair = BllFactory.GetRepariBll();
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            mStep = 0;
            OperateStep();
        }


        private void QueryStep()
        {
            if (chbDemmad.Checked)
                dgAccWare.DataSource = mIAccessory.GetAccsInWareAsTake(cmbHouseName.Text, txtAccessoryCode1.Text, txtAccessoryName1.Text, mAppendQuery);
            else
                dgAccWare.DataSource = mIAccessory.GetAccsInWareAsTake(cmbHouseName.Text, txtAccessoryCode1.Text, txtAccessoryName1.Text, "");
            mStep++;
        }

        private void dgAccWare_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAccWare_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectStep();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mStep = 2;         //   RepairM obj = mIRepair.GetRepairByDH(dH);
            OperateStep();

        }

        private void TakeOfStep()
        {
            if (txtAccessoryCode.Text == "")
            {
                ShowMessage("请选择出库配件");
                return;
            }

            if (dbiAmount.Value <= 0)
            {
                ShowMessage("出库数量必须大于0");
                return;

            }

            if (!mIAccessory.IsAccEnough(dbiAmount.Value, txtAccessoryCode.Text, txtID.Text))
            {
                ShowMessage("批次库存数量不够");
                return;
            }

            decimal sumaount = decimal.Parse(txtSumAmount.Text);
            if (sumaount <= 0)
            {
                ShowMessage("该配件实际库存已小于1，不能出库");
                return;


            }
            AccessoryOfRep obj = new AccessoryOfRep();
            obj.HouseName = txtHouseName.Text;
            obj.AccessoryCode = txtAccessoryCode.Text;
            obj.InPrice = float.Parse(txtInPrice.Text);
            obj.SalePrice = (float)dbiSalePrice.Value;
            obj.WareID = int.Parse(txtID.Text);
            obj.Amount = (float)dbiAmount.Value;
            obj.TakeMan = txtTakeMan.Text;
            obj.PriceType = cmbPriceType.Text;
            obj.InType = txtInType.Text;
            obj.InDate = txtInDate.Text;
            obj.ItemName = itemName;
            obj.DH = dH;
            obj.AccType = 1;
            obj.Status = 0;
            obj.Discount = discount;

            //这里对最后金额进行四舍五入处理
            double tmp = (double)((1 - discount) * obj.SalePrice);
            tmp = Math.Round(tmp, 2);
            obj.FinalPrice = (float)tmp;

            //添加配件出库记录


            if (ChildType == "免费保养" || ChildType == "索赔")
                obj.FinalPrice = 0;
            // int xh = mIRepairAccessory.AddAccessoryOfRepair(obj);
            mIRepairAccessory.AddAccessoryOfRepair(obj, obj.DH, (decimal)dbiAmount.Value, int.Parse(txtID.Text), outType);
            //进行出库
            //  mIAccessory.AccOutWareOfBatch(obj.DH, xh, (decimal)dbiAmount.Value, int.Parse(txtID.Text), outType);
            IsModify = true;
            ClearContent();
            mStep = 0;

        }
        private void ClearContent()
        {
            txtHouseName.Text = "";
            txtAccessoryCode.Text = "";
            txtAccessoryName.Text = "";
            txtInPrice.Text = "";
            dbiSalePrice.Value = 0;
            txtID.Text = "";
            txtAmount.Text = "";
            txtInType.Text = "";
            txtInDate.Text = "";
            dbiAmount.Value = 1;


        }


        private void frmDlgTakeAcc_Load(object sender, EventArgs e)
        {

            DataTable dt;
            dt = mIAccessory.GetWareHouses();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    cmbHouseName.Items.Add(dt.Rows[i][0].ToString());
            //}
            LoadExtendContents("仓库名称", cmbHouseName);
            cmbHouseName.SelectedIndex = -1;
            txtTakeMan.Text = Comm.LoginInfoShare.getInstance().UserName;
            cmbPriceType.SelectedIndex = 0;
            txtAccessoryCode1.Focus();


            RepairM rep = mIRepair.GetRepairByDH(dH);
            if (rep != null)
                ChildType = rep.RepChildType;

        }

        private void btnCoplete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dbiAmount_ValueChanged(object sender, EventArgs e)
        {
            //if (txtSalePrice.Text == "")
            //    txtSalePrice.Text = "0";
            double je = dbiAmount.Value * dbiSalePrice.Value;
            txtJE.Text = je.ToString();
        }

        private void chbDemmad_CheckValueChanged(object sender, EventArgs e)
        {
            if (chbDemmad.Checked)
            {
                if (string.IsNullOrEmpty(mAppendQuery))
                    mAppendQuery = mIRepairAccessory.GetQueryStrOfDemmand(dH);
                btnAllTake.Enabled = true;

            }
            else
                btnAllTake.Enabled = false;

        }

        private void btnAllTake_Click(object sender, EventArgs e)
        {

            if (mIRepair.IsTakeAll(dH))
            {
                ShowMessage("已经一键领料，无法再操作");
                return;

            }


            if (chbDemmad.Checked == false)
            {

                ShowMessage("请打勾需求选项");
                return;

            }
            DataTable dt = mIRepairAccessory.GetAccessorysOfRepairAsDemand(dH);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                float amountdemand = float.Parse(dt.Rows[i]["amount"].ToString());
                if (amountdemand == 1)
                {
                    DataTable dtDemmand = mIAccessory.GetWareInfoOfDemamnd(dt.Rows[i]["AccessoryCode"].ToString());

                    if (dtDemmand.Rows.Count > 0)
                    {
                        AccessoryOfRep obj = new AccessoryOfRep();
                        obj.HouseName = dtDemmand.Rows[0]["HouseName"].ToString();
                        obj.AccessoryCode = dtDemmand.Rows[0]["AccessoryCode"].ToString();
                        obj.InPrice = float.Parse(dtDemmand.Rows[0]["InPrice"].ToString());
                        obj.SalePrice = 0;

                        obj.WareID = int.Parse(dtDemmand.Rows[0]["ID"].ToString());
                        obj.Amount = 1;
                        obj.TakeMan = Comm.LoginInfoShare.getInstance().UserName;
                        obj.PriceType = "正常";
                        obj.InType = dtDemmand.Rows[0]["InType"].ToString();
                        obj.InDate = dtDemmand.Rows[0]["InDate"].ToString();
                        obj.ItemName = itemName;
                        obj.DH = dH;
                        obj.AccType = 1;
                        obj.Status = 0;
                        obj.FinalPrice = obj.SalePrice;

                        int xh = mIRepairAccessory.AddAccessoryOfRepair(obj);

                        //  进行出库
                        mIAccessory.AccOutWareOfBatch(obj.DH, xh, (decimal)dbiAmount.Value, obj.WareID, outType);
                        // mIRepairAccessory.AddAccessoryOfRepair(obj, obj.DH, (decimal)dbiAmount.Value, int.Parse(txtID.Text), outType);

                    }


                }


            }
            mIRepair.SetRepTakeAllFlag(dH);
            IsModify = true;
            this.Close();

        }

        private void dbiSalePrice_ValueChanged(object sender, EventArgs e)
        {
            double je = dbiAmount.Value * dbiSalePrice.Value;
            txtJE.Text = je.ToString();
        }

        private void frmDlgTakeAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {

                OperateStep();


            }
        }

        private void SelectStep()
        {
            if (dgAccWare.SelectedCells.Count != 0)
            {
                DataGridViewRow seldr = dgAccWare.SelectedRows[0];
                string id = seldr.Cells[0].Value.ToString();

                DataTable dt = mIAccessory.GetAccInWareAsTake(id);
                txtHouseName.Text = dt.Rows[0][0].ToString();
                txtAccessoryCode.Text = dt.Rows[0][1].ToString();
                txtAccessoryName.Text = dt.Rows[0][2].ToString();
                txtInPrice.Text = dt.Rows[0][3].ToString();
                //txtSalePrice.Text = dt.Rows[0][4].ToString();
                dbiSalePrice.Value = Double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0][4].ToString()));
                txtJE.Text = dt.Rows[0][4].ToString();
                txtID.Text = dt.Rows[0][5].ToString();
                txtAmount.Text = dt.Rows[0][6].ToString();
                txtInType.Text = dt.Rows[0][7].ToString();
                txtInDate.Text = dt.Rows[0][8].ToString();

                float accamount = mIAccessory.GetAccAmount(txtAccessoryCode.Text);
                txtSumAmount.Text = accamount.ToString();

                mStep++;

                dbiSalePrice.Focus();
            }


        }
        private void OperateStep()
        {


            if (dbiSalePrice.Focused)
            {
                dbiAmount.Focus();
                return;
            }
            if (mStep == 0)
            {
                QueryStep();

                dgAccWare.Focus();
                lblTip.Text = "提示:按回车----选定材料";
                //  mStep++;

            }
            else if (mStep == 1)
            {
                SelectStep();

                lblTip.Text = "提示:按回车----确定材料";

                //mStep++;
            }
            else if (mStep == 2)
            {
                TakeOfStep();
                // mStep = 0;
                lblTip.Text = "提示:按回车----查询材料";
                txtAccessoryCode1.Focus();
                txtAccessoryCode1.Text = "";
            }

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter)    //监听回车事件 
            {

                if (dgAccWare.Focused)
                {
                    OperateStep();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

    }
}
