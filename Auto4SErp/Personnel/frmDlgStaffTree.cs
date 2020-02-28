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
using DevComponents.AdvTree;
using Comm;
namespace Auto4SErp.Personnel
{
    public partial class frmDlgStaffTree : ifrmBase
    {

        private IDepartment mIDepartment;
        private IStaff mIStaff;
        public frmDlgStaffTree()
        {
            InitializeComponent();
            mIDepartment = BllFactory.GetDepartmentBll();
            mIStaff = BllFactory.GetStaffBll();
        }

        private void frmDlgStaffTree_Load(object sender, EventArgs e)
        {
            DataTable dtDepartment = mIDepartment.GetDepartments();

            DataTable dtStaff = mIStaff.GetStaffNameOfOrgan(LoginInfoShare.getInstance().OrganId);
            AddTree(dtDepartment, dtStaff);

        }

        private void AddTree(DataTable dtDepartment, DataTable dtStaff)
        {
            DataView dvDepartment = new DataView(dtDepartment);

            dvDepartment.RowFilter = "ParentID is null";
            foreach (DataRowView drv in dvDepartment)
            {
                Node Node = new Node();

                Node.Text = drv["DepartmentName"].ToString();
                Node.Name = drv["DepartmentName"].ToString();
                Node.Tag = drv["ID"].ToString();
                Node.ImageIndex = 1;
                this.treeStaff.Nodes.Add(Node);
                DataView dvStaff = new DataView(dtStaff);
                dvStaff.RowFilter = string.Format("departmentID like '{0}%'", drv["ID"].ToString().Trim());
                foreach (DataRowView drv1 in dvStaff)
                {
                    Node Node1 = new Node();
                    Node1.Text = drv1["staffname"].ToString();
                    Node1.DataKeyString = "1";
                    Node.Nodes.Add(Node1);
                }

            }

        }

        private void treeStaff_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            Node sel = e.Node;
            if (sel.DataKeyString == "1")
            {
                if (m_del != null)
                    m_del(e.Node.Text);
                this.Close();
            }

        }
    }
}
