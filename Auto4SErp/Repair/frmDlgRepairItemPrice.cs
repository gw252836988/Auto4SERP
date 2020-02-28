using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.Repair;
using Model;
namespace Auto4SErp.Repair
{
    public partial class frmDlgRepairItemPrice : ifrmBase
    {
        private IRepItemPrice mIRepItemPrice;
        private IRepairItem mIRepairItem;
        public string ID
        {
            get;
            set;

        }
        public string ItemCode
        {
            get;
            set;
        }
        public frmDlgRepairItemPrice()
        {
            mIRepItemPrice = Bll.BllFactory.GetRepItemPriceBll();
            mIRepairItem = Bll.BllFactory.GetRepairItemBll();
            InitializeComponent();
        }

        private void frmDlgRepairItemPrice_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(ID))
            {
                DataTable dt = mIRepItemPrice.GetRepPriceByID(ID);

                txtItemCode.Text = dt.Rows[0]["ItemCode"].ToString();
                cmbCarLevel.Text = ConvertCarLevelToName(dt.Rows[0]["CarLevel"].ToString());
                itiEmpWorkH.Value = int.Parse(dt.Rows[0]["EmpWorkH"].ToString());
                itiWorkHPrice.Value = int.Parse(dt.Rows[0]["WorkHPrice"].ToString());
                itiActWorkH.Value = int.Parse(dt.Rows[0]["ActWorkH"].ToString());




            }
            else
                txtItemCode.Text = ItemCode;
            DataTable dt1 = mIRepairItem.GetRepairItemByCode(txtItemCode.Text);
            if (dt1.Rows.Count > 0)
            {
                txtItemName.Text = dt1.Rows[0]["itemname"].ToString();

            }
            SetTButtonPng(toolStrip1);
        }



        private string ConvertCarLevelToName(string carlevelid)
        {
            string result = "";
            switch (carlevelid)
            {
                case "100":
                    result = "高档";
                    break;
                case "200":
                    result = "中高档";
                    break;
                case "300":
                    result = "中档";
                    break;
                default:
                    result = "低档";
                    break;

            }
            return result;


        }
        private string ConvertNameToLevel(string carlevelname)
        {
            string result = "";
            switch (carlevelname)
            {
                case "高档":
                    result = "100";
                    break;
                case "中高档":
                    result = "200";
                    break;
                case "中档":
                    result = "300";
                    break;
                default:
                    result = "400";
                    break;

            }
            return result;


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<SqlElement> lst = new List<SqlElement>();

            lst.Add(new SqlElement("CarLevel", ConvertNameToLevel(cmbCarLevel.SelectedItem.ToString()), true));
            lst.Add(new SqlElement("EmpWorkH", itiEmpWorkH.Value.ToString(), false));
            lst.Add(new SqlElement("WorkHPrice", itiWorkHPrice.Value.ToString(), false));
            lst.Add(new SqlElement("ActWorkH", itiActWorkH.Value.ToString(), false));
            lst.Add(new SqlElement("itemcode", txtItemCode.Text, true));

            if (string.IsNullOrEmpty(ID))
            {
                mIRepItemPrice.AddRepPrice(lst);
                this.Close();

            }
            else
            {
                mIRepItemPrice.UpdateRepPrice(lst, ID);

            }

        }
    }
}
