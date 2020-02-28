using Bll;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Controls;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll.Personnel;
namespace Auto4SErp.Personnel
{
    public partial class FrmDlgDepartment : ifrmBase
    {

        private string departmentid = "";
        private string parentid = "";

        public string Parentid
        {
            get { return parentid; }
            set { parentid = value; }
        }
        public string Departmentid
        {
            get { return departmentid; }
            set { departmentid = value; }
        }
        private IDepartment mIDepartment;

        public FrmDlgDepartment()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            mIDepartment = BllFactory.GetDepartmentBll();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {

            Department depart = AssginToModel();
            departmentid = departmentid.Trim();
            if (!String.IsNullOrEmpty(departmentid))
            {
                bool flg = false;
                if (departmentid == depart.ID)
                {
                    flg = true;
                }
                else
                {
                    if (!mIDepartment.ExistsId(depart))
                    {
                        flg = true;
                    }

                }

                if (flg)
                {
                    if (this.parentid != "")
                    {
                        depart.ParentID = parentid;
                    }
                    if (mIDepartment.UpdateDepartment(depart, departmentid))
                    {
                        IsModify = true;
                        this.Close();
                    }
                }

            }
            else
            {
                // 新增
                if (this.parentid != "")
                {
                    depart.ParentID = parentid;
                }

                if (mIDepartment.AddDepartment(depart))
                {
                    if (this.parentid != "")
                    {
                        this.txtID.Text = mIDepartment.AddIDString(parentid);
                    }
                    else
                    {
                        this.txtID.Text = mIDepartment.AddIDString("");
                    }
                    this.txtDepartmentName.Text = "";
                    this.txtDepartmentName.Focus();
                    IsModify = true;

                }

            }

        }


        private Department AssginToModel()
        {
            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;
            Department entity = FrmAssist.PopulateEntityFromCollection<Department>(null, lstPairs);
            return entity;
        }


        private void FrmDlgDepartment_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(departmentid))
            {
                DataTable dt = mIDepartment.GetDepartmentByID(departmentid);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    this.txtID.Text = dr["ID"].ToString().Trim();
                    parentid = dr["ParentID"].ToString().Trim();
                    this.txtDepartmentName.Text = dr["DepartmentName"].ToString().Trim();



                }
            }
            else
            {
                //计算新增部门编号
                if (String.IsNullOrEmpty(parentid))
                {
                    this.txtID.Text = mIDepartment.AddIDString("");
                    this.txtDepartmentName.Focus();
                }
                else
                {
                    this.txtID.Text = mIDepartment.AddIDString(parentid.Trim());
                    this.txtDepartmentName.Focus();
                }

            }


            mLstControls.Add(txtID);

            mLstControls.Add(txtDepartmentName);



            StartWork(null);

        }



    }


}

