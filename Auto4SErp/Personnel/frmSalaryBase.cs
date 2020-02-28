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
namespace Auto4SErp.Personnel
{
    public partial class frmSalaryBase : ifrmBase
    {
        private IStaff mIStaff = BllFactory.GetStaffBll();
        private IAward mIAward = BllFactory.GetAwardBll();
        public frmSalaryBase()
        {
            InitializeComponent();
        }

        private void frmSalaryBase_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            int tmpRecordCount;
            int tmpPageCount;
            DataTable dt;
            List<Model.SqlElement> LstE = new List<Model.SqlElement>();
            dt = mIStaff.GetStaffsByQuery(LstE, "", mPageInfo.PageCurrent, 1000, out tmpRecordCount, out tmpPageCount);
            
            DataTable dtBase = mIAward.GetSalaryBases();
            MergeNewDt(dt, dtBase);
            gridSalary.DataSource = dt;
            dt.AcceptChanges();
          
        }


        private void MergeNewDt(DataTable dtStaff ,DataTable dtBase)
        {
            dtStaff.Columns.Add("BasicSalary",typeof(decimal));
            dtStaff.Columns.Add("AssginRate", typeof(decimal));
            dtStaff.Columns.Add("InsuranceDeducted", typeof(decimal));
            dtStaff.Columns.Add("FundDeducted", typeof(decimal));
            dtStaff.Columns.Add("LaborUnionDeducted", typeof(decimal));
            dtStaff.Columns.Add("PositionAllowance", typeof(decimal));

            for (int i = 0; i < dtStaff.Rows.Count;i++ )
            {
                string sID = dtStaff.Rows[i]["StaffID"].ToString();
                
                var reslut=dtBase.AsEnumerable().FirstOrDefault(r => r["StaffID"].ToString() == sID);
                if (reslut != null)
                {
                    decimal basicSalary = (decimal)reslut["BasicSalary"];
                    decimal positionAllowance = (decimal)reslut["PositionAllowance"];
                    decimal assginRate = (decimal)reslut["AssginRate"];
                    decimal insuranceDeducted = (decimal)reslut["InsuranceDeducted"];
                    decimal fundDeducted = (decimal)reslut["FundDeducted"];
                    decimal laborUnionDeducted = (decimal)reslut["LaborUnionDeducted"];

                    dtStaff.Rows[i]["BasicSalary"] = basicSalary;
                    dtStaff.Rows[i]["PositionAllowance"] = positionAllowance;
                    dtStaff.Rows[i]["AssginRate"] = assginRate;
                    dtStaff.Rows[i]["insuranceDeducted"] = insuranceDeducted;
                    dtStaff.Rows[i]["FundDeducted"] = fundDeducted;
                    dtStaff.Rows[i]["LaborUnionDeducted"] = laborUnionDeducted;
                }
                else
                {
                    dtStaff.Rows[i]["BasicSalary"] = 0;
                    dtStaff.Rows[i]["PositionAllowance"] = 0;
                    dtStaff.Rows[i]["AssginRate"] = 0;
                    dtStaff.Rows[i]["insuranceDeducted"] = 0;
                    dtStaff.Rows[i]["FundDeducted"] = 0;
                    dtStaff.Rows[i]["LaborUnionDeducted"] = 0;


                }

            }
              
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            DataRowView obj = (DataRowView)gridView1.GetFocusedRow();
            if (obj != null)
            {

                frmSalaryBaseInput frm = new frmSalaryBaseInput();
                frm.StaffID = obj["StaffID"].ToString();
                frm.FormClosed += new FormClosedEventHandler(DoCloseAct);
                frm.ShowDialog();

            }
            
        }

         protected void DoCloseAct(object sender, FormClosedEventArgs e)
        {
            frmSalaryBaseInput frm = (frmSalaryBaseInput)sender;
            if (frm.IsModify)      
                Bind();
         }

         private void btnOK_Click(object sender, EventArgs e)
         {
             txtBrand.Focus();
             DataTable dtStaff = (DataTable)gridSalary.DataSource;
             DataTable dtUpdate = (DataTable)dtStaff.GetChanges(DataRowState.Modified);

             if (dtUpdate != null && dtUpdate.Rows.Count > 0)
             {
                 //
                 for (int i = 0; i < dtUpdate.Rows.Count; i++)
                 {
                     DataRow dr = dtUpdate.Rows[i];
                     string staffID = (string)dr["StaffID"];
                     decimal basicSalary = (decimal)dr["BasicSalary"];
                     decimal positionAllowance = (decimal)dr["PositionAllowance"];
                     decimal assginRate = (decimal)dr["AssginRate"];
                     decimal insuranceDeducted = (decimal)dr["InsuranceDeducted"];
                     decimal fundDeducted = (decimal)dr["FundDeducted"];
                     decimal laborUnionDeducted = (decimal)dr["LaborUnionDeducted"];
                     mIAward.UpdateSalaryBase(staffID, basicSalary, assginRate, insuranceDeducted, fundDeducted, laborUnionDeducted, positionAllowance);
                 }


             }
             dtStaff.AcceptChanges();
        
         }

         private void txtBrand_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
         {
             
         }
    }
}
