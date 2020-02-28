using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comm;
using Bll.Repair;
using Bll;
namespace Auto4SErp
{
    public partial class frmBatchIn : ifrmBase
    {


        private DataTable mDtResult = null;
        private string tableName = "Accessory";
        private IBatchIn mIBatchIn = null;
        private string append;

        public string Append
        {
            get { return append; }
            set { append = value; }
        }
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        public frmBatchIn()
        {


            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            if (opdIn.ShowDialog() == DialogResult.OK)
            {

                string path = opdIn.FileName;
                ExcelInAndOut inO = new ExcelInAndOut(path);
                try
                {
                    mDtResult = inO.InDataToDT();

                }
                catch (Exception ex)
                {
                    ShowMessage(ex.Message.ToString());
                    return;
                }
                dgResult.DataSource = mDtResult;

            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (mDtResult != null)
            {
                string err = mIBatchIn.BatchInDB(mDtResult, append);
                if (err != "")
                {
                    ShowMessage(err);
                }
                else
                {
                    ShowMessage("导入成功");
                    this.Close();
                }
            }
            else
                ShowMessage("未选择导入文件");
        }



        private void frmBatchIn_Load(object sender, EventArgs e)
        {

            if (tableName == "Accessory")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetAccessoryBll();
            }
            else if (tableName == "RepairItem")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetRepairItemBll();
            }
            else if (tableName == "RepItemPrice")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetRepItemPriceBll();
            }
            else if (tableName == "AccessoryIn")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetAccessoryInBll();
            }
            else if (tableName == "Staff")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetStaffBll();
            }
            else if (tableName == "Customer")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetCustomerBll();
            }
            else if (tableName == "CarOfCust")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetCarOfCustBll();
            }
            else if (tableName == "SaleAward")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetAwardBll();
            }
            else if (tableName == "CarSer")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetCarSerBll();
            }
            else if (tableName == "CarModel")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetCarModelBll();
            }
            else if (tableName == "CarDetail")
            {
                mIBatchIn = (IBatchIn)BllFactory.GetCarDocBll();
            }

            opdIn.Filter = "xls files (*.xls)|*.xls";
            SetTButtonPng(toolStrip1);
        }


    }
}
