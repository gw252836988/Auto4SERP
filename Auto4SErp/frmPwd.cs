using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.Personnel;
using Bll;
using Comm;
namespace Auto4SErp
{
    public partial class frmPwd : ifrmBase
    {
        private IStaff mIStaff;
        private IOperateMan mIOperateMan;
        public frmPwd()
        {
            mIStaff = Bll.BllFactory.GetStaffBll();
            mIOperateMan = Bll.BllFactory.GetOperateManBll();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string staffid;
            staffid = Comm.LoginInfoShare.getInstance().UserId;
            //if (mIStaff.ValidateLogin(staffid, txtOldPwd.Text))
            //{
            if (txtNewPwd.Text == txtConfrimPwd.Text)
            {
                if (Comm.LoginInfoShare.getInstance().IsSelf)
                    mIStaff.UpdateStaffPwd(staffid, txtNewPwd.Text);
                else
                    mIOperateMan.UpdateOperatePwd(staffid, txtNewPwd.Text);

                ShowMessage("密码修改成功");
                this.Close();
            }
            else
                ShowMessage("新密码两次输入不一致");


            //}
            //else
            //{
            //    ShowMessage("旧密码输入不正确");

            //}
        }

        private void frmPwd_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
        }
    }
}
