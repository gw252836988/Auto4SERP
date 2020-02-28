using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Comm;
using Bll.Personnel;
using System.Reflection;
using System.Data;

namespace Auto4SErp.Personnel
{
    public partial class frmDlgStaff : ifrmBase
    {
        private IStaff mIStaff = BllFactory.GetStaffBll();
        private IPosition mIPosition = BllFactory.GetPositionBll();
        private IDepartment mIDepartment = BllFactory.GetDepartmentBll();
        private IOrgan mIOrgan = BllFactory.GetOrganBll();
        private string mDepartmentIdSel = "";
        private string mOrganIdSel = "";
        private int mPositionIdSel;
        private string staffId = "";

        public string StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }

        public frmDlgStaff()
        {
            InitializeComponent();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            DateTime dtBirth = dtiBirthDate.Value;
            DateTime dtEntryDate = dtiEntryDate.Value;
            DateTime dtContractStartDate = dtiContractStartDate.Value;
            DateTime dtContractEndDate = dtiContractEndDate.Value;

            if (txtDepartmentName.Text == "")
            {
                ShowMessage("请选择部门");
                return;
            }

            if (txtPositionName.Text == "")
            {
                ShowMessage("请选择职位");
                return;
            }

            if (dtBirth.Year == 1)
            {
                ShowMessage("请选择生日的日期");
                return;
            }

            if (dtEntryDate.Year == 1)
            {
                ShowMessage("请选择入职日期");
                return;
            }

            if (dtContractStartDate.Year == 1)
            {
                ShowMessage("请选择合同开始日期");
                return;
            }

            if (dtContractEndDate.Year == 1)
            {
                ShowMessage("请选择合同结束日期");
                return;
            }

            Staff obj = AssginToModel();


            if (obj != null)
            {
                obj.DepartmentID = mDepartmentIdSel.ToString();
                obj.PositionID = mPositionIdSel;
                obj.OrganId = mOrganIdSel;

                if (string.IsNullOrEmpty(staffId))
                {
                    Staff tmp = mIStaff.GetStaff(txtStaffID.Text);
                    if (tmp != null)
                    {
                        ShowMessage("该员工已存在于" + tmp.OrganName + "，不能重复添加");
                        return;
                    }
                    mIStaff.AddStaff(obj);
                }
                else
                {
                    obj.StaffID = staffId;
                    mIStaff.UpdateStaff(obj);

                }
                IsModify = true;
                ShowMessage("保存成功");

            }

        }


        //private Bll.localhost.Staff StaffConvert(Staff obj)
        //{
        //    Bll.localhost.Staff newobj = new Bll.localhost.Staff();

        //    Type type = typeof(Staff);
        //    //取得属性集合
        //    PropertyInfo[] pi = type.GetProperties();
        //     foreach (PropertyInfo item in pi)
        //    {

        //        item.SetValue(newobj, Convert.ChangeType(item.GetValue(obj), item.PropertyType),null);
        //    }
        //     return newobj;
        //}

        private Staff AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;
            Staff entity = FrmAssist.PopulateEntityFromCollection<Staff>(null, lstPairs);
            return entity;
        }


        private void frmDlgStaff_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtStaffID);
            mLstControls.Add(txtStaffName);
            mLstControls.Add(cmbSex);
            //mLstControls.Add(txtOrganId);
            //    mLstControls.Add(txtDepartmentName);
            //    mLstControls.Add(txtPositionName);
            mLstControls.Add(txtMobile);
            mLstControls.Add(txtIdentityNumber);

            mLstControls.Add(dbiStature);
            mLstControls.Add(cmbIsMarryed);
            mLstControls.Add(dtiBirthDate);
            mLstControls.Add(cmbEducation);
            mLstControls.Add(cmbNation);
            mLstControls.Add(txtNativePlace);
            mLstControls.Add(txtPhone);
            mLstControls.Add(txtEmail);
            mLstControls.Add(txtGraduateSchool);
            mLstControls.Add(txtSpecialty);
            mLstControls.Add(txtRegisteredAddress);
            mLstControls.Add(txtNowAddress);


            mLstControls.Add(dtiEntryDate);
            mLstControls.Add(dtiContractStartDate);
            mLstControls.Add(dtiContractEndDate);

            //
            // cmbOrganName.Text = LoginInfoShare.getInstance().OrganName;
            LoadOrgans(cmbOrganName, false);
            // mOrganIdSel = LoginInfoShare.getInstance().OrganId;

            SetTButtonPng(toolStrip1);
            if (!string.IsNullOrEmpty(staffId))
                AssginStaffToControls();


        }

        private void AssginStaffToControls()
        {
            Staff obj = mIStaff.GetStaff(staffId);
            AssginModelToControl<Staff>(obj);
            DataTable dt = mIPosition.GetPositionByID(obj.PositionID.ToString());
            mPositionIdSel = obj.PositionID;

            if (dt.Rows.Count > 0)
                txtPositionName.Text = dt.Rows[0]["PositionName"].ToString();

            dt = mIDepartment.GetDepartmentByID(obj.DepartmentID.ToString());
            mDepartmentIdSel = obj.DepartmentID;

            if (dt.Rows.Count > 0)
                txtDepartmentName.Text = dt.Rows[0]["DepartmentName"].ToString();

            // cmbOrganName.Text = mIOrgan.GetOrganName(obj.OrganId);
            SetOrganSelected(obj.OrganId);

        }


        private void SetOrganSelected(string organid)
        {


            foreach (DevComponents.AdvTree.Node nd in cmbOrganName.Nodes)
            {
                foreach (DevComponents.AdvTree.Node nd1 in nd.Nodes)
                {
                    if (organid == nd1.DataKeyString.Trim())
                    {
                        cmbOrganName.SelectedNode = nd1;
                        mOrganIdSel = nd1.DataKeyString.Trim();
                    }
                }
            }

        }
        private void btnCustSel_Click(object sender, EventArgs e)
        {
            Point pt = this.Location;
            frmDlgDepartTree frm = new frmDlgDepartTree();
            Point NewPoint = new Point(pt.X + this.Width, pt.Y - 50);

            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = NewPoint;
            frm.setTransferDelegate(delegate(object data)
            {
                string bundle = (string)data;
                string[] strlst = bundle.Split('_');
                txtDepartmentName.Text = strlst[1];
                mDepartmentIdSel = strlst[0];

            });
            frm.ShowDialog();

        }

        private void btnPositionFind_Click(object sender, EventArgs e)
        {
            frmPosition frm = new frmPosition();
            frm.DepartMentID = mDepartmentIdSel;
            frm.setTransferDelegate(delegate(object o)
            {
                string[] strlst = o.ToString().Split(',');
                mPositionIdSel = int.Parse(strlst[0]);
                txtPositionName.Text = strlst[1];


            });
            frm.ShowDialogEx();
        }

        private void cmbOrganName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrganName.SelectedNode != null)
                mOrganIdSel = cmbOrganName.SelectedNode.DataKeyString.Trim();
        }

    }
}
