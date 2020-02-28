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
    public partial class frmDlgResetItemPrice : ifrmBase
    {

        private IRepair mIRepair;
        private string dH;
        private int mXH = 0;
        private string mChildType = "";
        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        public frmDlgResetItemPrice()
        {
            mIRepair = BllFactory.GetRepariBll();
            InitializeComponent();
        }

        private void RefreshRepairItem()
        {
            dgRepairItem.AutoGenerateColumns = false;
            dgRepairItem.DataSource = mIRepair.GetItemsOfDH(dH);
            //StartWork(txtDH.Text);

        }

        private void frmDlgResetItemPrice_Load(object sender, EventArgs e)
        {
            RefreshRepairItem();
            cmbPriceType.SelectedIndex = 0;
            cmbDiscount.SelectedIndex = 0;
            SetTButtonPng(toolStrip1);
            RepairM obj = mIRepair.GetRepairByDH(dH);
            mChildType = obj.RepChildType;


        }

        private void dgRepairItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRepairItem.SelectedCells.Count != 0)
            {

                DataGridViewCell cell = dgRepairItem.SelectedCells[0];
                int rowindex = cell.RowIndex;

                txtItemName.Text = dgRepairItem.Rows[rowindex].Cells["ItemName"].Value.ToString();
                txtItemPrice.Text = dgRepairItem.Rows[rowindex].Cells["ItemTotalPrice"].Value.ToString();


                string tmpPriceType = dgRepairItem.Rows[rowindex].Cells["PriceType"].Value.ToString();
                AssginToPriceType(tmpPriceType);
                string tmpDiscount = dgRepairItem.Rows[rowindex].Cells["Discount"].Value.ToString();
                AssginToDiscount(tmpDiscount);


                mXH = int.Parse(dgRepairItem.Rows[rowindex].Cells["XH"].Value.ToString());
            }
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



        private void btnOK_Click(object sender, EventArgs e)
        {

            if (!(mXH > 0))
            {
                ShowMessage("请选择一个维修项目");
                return;
            }



            float finalprice = 0;
            float itemprice = 0;
            itemprice = float.Parse(txtItemPrice.Text);
            float discount = 100;



            string strdis = cmbDiscount.Text;
            discount = float.Parse(strdis);
            finalprice = discount * itemprice / 100;


            if (cmbPriceType.SelectedItem.ToString() == "免单")
            {
                discount = 100;
                finalprice = 0;
            }
            if (cmbPriceType.SelectedItem.ToString() == "索赔")
            {
                discount = 100;
                finalprice = 0;
                if (mChildType != "索赔")
                {
                    if (mChildType != "免费保养")
                    {
                        ShowMessage("请将单据改为索赔或免费保养类别");
                        return;
                    }

                }



            }



            repair_iM obj = new repair_iM();
            obj.FinalPrice = finalprice;
            obj.PriceType = cmbPriceType.SelectedItem.ToString();
            obj.Discount = (1 - discount / 100);
            obj.DH = dH;
            obj.XH = mXH;
            mIRepair.UpdatePriceOfRepairItem(obj);
            RefreshRepairItem();
        }


        private void btnBachDis_Click(object sender, EventArgs e)
        {
            DataTable dt = mIRepair.GetItemsOfDH(dH);
            float finalprice = 0;
            float itemprice = 0;
            //itemprice = float.Parse(txtItemPrice.Text);
            float discount = 100;



            string strdis = cmbDiscount.SelectedItem.ToString();
            discount = float.Parse(strdis);
            //  finalprice = discount * itemprice / 100;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                itemprice = float.Parse(dt.Rows[i]["itemtotalprice"].ToString());
                finalprice = discount * itemprice / 100;

                if (dt.Rows[i]["PriceType"].ToString() == "索赔" || dt.Rows[i]["PriceType"].ToString() == "免单")
                {
                    discount = 100;
                    finalprice = 0;

                }
                repair_iM obj = new repair_iM();
                obj.FinalPrice = finalprice;
                obj.PriceType = dt.Rows[i]["PriceType"].ToString();
                obj.Discount = (1 - discount / 100);
                obj.DH = dH;
                obj.XH = int.Parse(dt.Rows[i]["xh"].ToString());
                mIRepair.UpdatePriceOfRepairItem(obj);

            }
            RefreshRepairItem();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
