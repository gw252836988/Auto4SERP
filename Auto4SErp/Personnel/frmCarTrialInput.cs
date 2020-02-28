using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comm;
using Bll.Personnel;
using Bll;
using Model;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Bll.Sale;


namespace Auto4SErp.Personnel
{
    public partial class frmCarTrialInput : ifrmBase
    {
        private int mYear=2019;
        private int mMonth=11;
        private IAward mIAward = BllFactory.GetAwardBll();
        public frmCarTrialInput()
        {
            InitializeComponent();
        }

        private void frmCarTrialInput_Load(object sender, EventArgs e)
        {
            DataTable dt = mIAward.GetSalaryDate();
            this.Text = this.Text + string.Format("(当前工资录入日期:{0}年{1}月)", dt.Rows[0]["Year"], dt.Rows[0]["Month"]);
            mYear = int.Parse(dt.Rows[0]["Year"].ToString());
            mMonth = int.Parse(dt.Rows[0]["Month"].ToString());
            
            cmbYear.Text = DateTime.Now.Year.ToString();
            cmbMonth.Text = DateTime.Now.Month.ToString();
            BindData();
        }


        public void BindData()
        {
            DataTable dt = mIAward.GetCarTrialRecord(mYear, mMonth, Comm.LoginInfoShare.getInstance().UserId,"");
            dt.AcceptChanges();
            gridCarTrial.DataSource = dt;


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            cmbYear.Focus();
            DataTable dtCarTrial = (DataTable)gridCarTrial.DataSource;

            if (dtCarTrial == null) return;
            DataTable dtUpdate = dtCarTrial.GetChanges(DataRowState.Modified);
            DataTable dtAdd = dtCarTrial.GetChanges(DataRowState.Added);

            if (dtAdd != null && dtAdd.Rows.Count > 0)
            {
                for (int i = 0; i < dtAdd.Rows.Count; i++)
                {
                   CarTrialRecord obj= PutValuesToObject(dtAdd.Rows[i]);
                   mIAward.AddCarTrialRecord(obj);

                }
               
            }
            if (dtUpdate != null && dtUpdate.Rows.Count > 0)
            {
                for (int i = 0; i < dtUpdate.Rows.Count; i++)
                {
                    CarTrialRecord obj = PutValuesToObject(dtUpdate.Rows[i]);
                    mIAward.UpdateCarTrialRecord(obj);
                }
            }
            BindData();
           // dtCarTrial.AcceptChanges();
        }

        private CarTrialRecord PutValuesToObject(DataRow drSource)
        {
            CarTrialRecord obj = new CarTrialRecord();
            obj.ID = (int)drSource["ID"];
            obj.Year = (int)drSource["Year"];
            obj.Month =(int)drSource["Month"];
            obj.Organ = Comm.LoginInfoShare.getInstance().OrganName;
            obj.TrialDate = (DateTime)drSource["Trial_Date"];
            obj.Mobile = drSource["Mobile"].ToString();
            obj.CustName = drSource["CustName"].ToString();
            obj.StaffID = Comm.LoginInfoShare.getInstance().UserId;
            return obj;
        }



        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "Year", mYear);
            gridView1.SetRowCellValue(e.RowHandle, "Month", mMonth);
            gridView1.SetRowCellValue(e.RowHandle, "Trial_Date", DateTime.Now);
            gridView1.SetRowCellValue(e.RowHandle, "ID", -1);
        }

        private void gridView1_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridColumn cCustName = gridView1.Columns["CustName"];
            GridColumn cMobile = gridView1.Columns["Mobile"];
            GridColumn cTrial_Date = gridView1.Columns["Trial_Date"];

            //string strCode = gridView1.GetRowCellValue(e.RowHandle, cAccessoryCode).ToString();
            object CustName = gridView1.GetRowCellValue(e.RowHandle, cCustName);
            if (CustName == null || CustName.ToString().Length < 1)
            {
                e.Valid = false;
                gridView1.SetColumnError(cCustName, "请输入客户姓名");
                return;
            }


            object mobile = gridView1.GetRowCellValue(e.RowHandle, cMobile);
            if (mobile == null || mobile.ToString().Length < 1)
            {
                e.Valid = false;
                gridView1.SetColumnError(cMobile, "请输入客户手机号码");
                return;

            }

            //decimal inprice = (decimal)gridView1.GetRowCellValue(e.RowHandle, cInPrice);
            object Trial_Date = gridView1.GetRowCellValue(e.RowHandle, cTrial_Date);
            if (Trial_Date == null || Trial_Date.ToString().Length < 1)
            {
                e.Valid = false;
                gridView1.SetColumnError(cTrial_Date, "请输入试驾日期");
                return;

            }
        }

        private void gridView1_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void DeleteEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int handle = gridView1.FocusedRowHandle;
            int id =int.Parse( gridView1.GetRowCellValue(handle, "ID").ToString());


            if (id >0)
            {
                mIAward.DeleteCarTrialRecord(id);
                BindData();

            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
