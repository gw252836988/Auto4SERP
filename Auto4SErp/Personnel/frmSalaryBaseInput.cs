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
    public partial class frmSalaryBaseInput : ifrmBase
    {
        private IAward mIAward = BllFactory.GetAwardBll();
        public  bool IsModify
        {
            get;
            set;

        }

      
        public string StaffID
        {
            get;
            set;

        }
        public frmSalaryBaseInput()
        {
            InitializeComponent();
        }

        private void frmSalaryBaseInputcs_Load(object sender, EventArgs e)
        {
            DataTable dt = mIAward.GetSalaryBaseByStaffID(StaffID);

            if (dt != null)
            {
                txtBasicSalary.Value = (decimal)dt.Rows[0]["BasicSalary"];
                txtPositionAllowance.Value = (decimal)dt.Rows[0]["PositionAllowance"];
                txtAssginRate.Value = (decimal)dt.Rows[0]["AssginRate"];
                txtLaborUnionDeducted.Value = (decimal)dt.Rows[0]["LaborUnionDeducted"];
                txtFundDeducted.Value = (decimal)dt.Rows[0]["FundDeducted"];
                txtInsuranceDeducted.Value = (decimal)dt.Rows[0]["InsuranceDeducted"];
            }
                
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mIAward.UpdateSalaryBase(StaffID, txtBasicSalary.Value, txtAssginRate.Value, txtInsuranceDeducted.Value, txtFundDeducted.Value, txtLaborUnionDeducted.Value, txtPositionAllowance.Value);
            IsModify = true;
        }
    }
}
