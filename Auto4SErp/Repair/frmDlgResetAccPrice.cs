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
namespace Auto4SErp.Repair
{
    public partial class frmDlgResetAccPrice : ifrmBase
    {

        private IRepairAccessory mIRepairAccessory;
        private IRepair mIRepair;

        private string dH;
        private int mXH = 0;
        private string mChildType = "";
        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        public frmDlgResetAccPrice()
        {
            InitializeComponent();
            mIRepairAccessory = BllFactory.GetRepairAccessoryBll();
            mIRepair = BllFactory.GetRepariBll();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if (!(mXH > 0))
            //{
            //    ShowMessage("请选择一个配件");
            //    return;
            //}



            float finalprice = 0;
            float itemprice = 0;
            //itemprice = float.Parse(txtSalePrice.Text);
            itemprice = (float)dbiSalePrice.Value;
            float discount = 100;

            //string strdis = cmbDiscount.SelectedItem.ToString();
            string strdis = cmbDiscount.Text;
            discount = float.Parse(strdis);
            finalprice = discount * itemprice / 100;



            if (cmbPriceType.SelectedItem.ToString() == "索赔" || cmbPriceType.SelectedItem.ToString() == "免单")
            {
                discount = 100;
                finalprice = 0;
            }

            DataTable dt = mIRepairAccessory.GetAccessorysOfRepairAsRep(dH);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                float saleprice = float.Parse(dt.Rows[i]["SalePrice"].ToString());
                AccessoryOfRep obj = new AccessoryOfRep();
                // obj.SalePrice=itemprice;
                obj.Discount = (1 - discount / 100);
                obj.FinalPrice = saleprice * (discount / 100);
                //  obj.PriceType = "索赔";

                obj.DH = dH;
                obj.XH = dt.Rows[i]["XH"].ToString();
                mIRepairAccessory.UpdateAccessoryOfRepair(obj);

            }
            RefreshAccssorys();

            // AccessoryOfRep obj = new AccessoryOfRep();
            //// obj.SalePrice=itemprice;
            // obj.FinalPrice = finalprice;
            // obj.PriceType = cmbPriceType.SelectedItem.ToString();
            // obj.Discount = (1-discount/100);
            // obj.DH = dH;
            // obj.XH = mXH.ToString();
            // mIRepairAccessory.UpdateAccessoryOfRepair(obj);
            // RefreshAccssorys();
        }

        private void frmDlgResetAccPrice_Load(object sender, EventArgs e)
        {
            RefreshAccssorys();
            cmbDiscount.SelectedIndex = 0;
            cmbPriceType.SelectedIndex = 0;
            SetTButtonPng(toolStrip1);
            RepairM obj = mIRepair.GetRepairByDH(dH);
            mChildType = obj.RepChildType;
        }

        private void RefreshAccssorys()
        {
            dgAccessory.AutoGenerateColumns = false;
            dgAccessory.DataSource = mIRepairAccessory.GetAccessorysOfRepairAsRep(dH);
            //   StartWork(txtDH.Text);
        }

        private void dgAccessory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAccessory.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = dgAccessory.SelectedRows[0];

                txtAccName.Text = dr.Cells["accessoryname"].Value.ToString();
                // txtSalePrice.Text = dr.Cells["SalePrice"].Value.ToString();
                dbiSalePrice.Value = double.Parse(dr.Cells["SalePrice"].Value.ToString());


                string tmpPriceType = dr.Cells["PriceType"].Value.ToString();
                AssginToPriceType(tmpPriceType);
                string tmpDiscount = dr.Cells["Discount"].Value.ToString();
                AssginToDiscount(tmpDiscount);

                mXH = int.Parse(dr.Cells[0].Value.ToString());
                //DataGridViewCell cell = dgRepairItem.SelectedCells[0];
                //int rowindex = cell.RowIndex;

                //txtItemName.Text = dgRepairItem.Rows[rowindex].Cells["ItemName"].Value.ToString();
                //txtItemPrice.Text = dgRepairItem.Rows[rowindex].Cells["ItemTotalPrice"].Value.ToString();


                //string tmpPriceType = dgRepairItem.Rows[rowindex].Cells["PriceType"].Value.ToString();
                //AssginToPriceType(tmpPriceType);
                //string tmpDiscount = dgRepairItem.Rows[rowindex].Cells["Discount"].Value.ToString();
                //AssginToDiscount(tmpDiscount);


                //mXH = int.Parse(dgRepairItem.Rows[rowindex].Cells["XH"].Value.ToString());
            }
        }

        private void AssginToPriceType(string pricetype)
        {
            if (!string.IsNullOrEmpty(pricetype))
            {
                for (int i = 0; i < cmbPriceType.Items.Count; i++)
                {
                    if (pricetype == cmbPriceType.Items[i].ToString())
                    {
                        cmbPriceType.SelectedIndex = i;
                        return;
                    }
                }
            }
            else
                cmbPriceType.SelectedIndex = 0;

        }
        private void AssginToDiscount(string discount)
        {
            if (!string.IsNullOrEmpty(discount))
            {
                for (int i = 0; i < cmbDiscount.Items.Count; i++)
                {
                    if (discount == cmbDiscount.Items[i].ToString())
                    {
                        cmbDiscount.SelectedIndex = i;
                        return;
                    }
                }
            }
            else
                cmbDiscount.SelectedIndex = 0;


        }

        private void btnResetZero_Click(object sender, EventArgs e)
        {

            if (!mChildType.Contains("索赔"))
            {
                if (!mChildType.Contains("免费"))
                {
                    ShowMessage("非索赔免费保养单据无法进行此操作");
                    return;
                }
            }



            DataTable dt = mIRepairAccessory.GetAccessorysOfRepairAsRep(dH);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AccessoryOfRep obj = new AccessoryOfRep();
                // obj.SalePrice=itemprice;
                obj.FinalPrice = 0;
                obj.PriceType = "索赔";
                // obj.Discount = (1 - discount / 100);
                obj.DH = dH;
                obj.XH = dt.Rows[i]["XH"].ToString();
                mIRepairAccessory.UpdateAccessoryOfRepair(obj);

            }
            RefreshAccssorys();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (!(mXH > 0))
            {
                ShowMessage("请选择一个配件");
                return;
            }



            float finalprice = 0;
            float itemprice = 0;
            //itemprice = float.Parse(txtSalePrice.Text);
            itemprice = (float)dbiSalePrice.Value;
            float discount = 100;

            string strdis = cmbDiscount.SelectedItem.ToString();
            discount = float.Parse(strdis);
            finalprice = discount * itemprice / 100;

            if (!(mChildType.Contains("索赔") || mChildType.Contains("免费")))
            {
                if (cmbPriceType.SelectedItem.ToString() == "索赔")
                {
                    ShowMessage("非索赔免费保养单据无法进行此操作");
                    return;
                }
            }


            if (cmbPriceType.SelectedItem.ToString() == "索赔" || cmbPriceType.SelectedItem.ToString() == "免单")
            {
                discount = 100;
                finalprice = 0;
            }

            //DataTable dt = mIRepairAccessory.GetAccessorysOfRepairAsRep(dH);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    float saleprice = float.Parse(dt.Rows[i]["SalePrice"].ToString());
            //    AccessoryOfRep obj = new AccessoryOfRep();
            //    // obj.SalePrice=itemprice;
            //    obj.Discount = (1 - discount / 100);
            //    obj.FinalPrice = saleprice * (discount / 100);
            //    //  obj.PriceType = "索赔";

            //    obj.DH = dH;
            //    obj.XH = dt.Rows[i]["XH"].ToString();
            //    mIRepairAccessory.UpdateAccessoryOfRepair(obj);

            //}
            // RefreshAccssorys();

            AccessoryOfRep obj = new AccessoryOfRep();
            // obj.SalePrice=itemprice;
            obj.FinalPrice = finalprice;
            obj.PriceType = cmbPriceType.SelectedItem.ToString();
            obj.Discount = (1 - discount / 100);
            obj.DH = dH;
            obj.XH = mXH.ToString();
            mIRepairAccessory.UpdateAccessoryOfRepair(obj);
            RefreshAccssorys();
        }
    }
}
