using Bll;
using DevComponents.AdvTree;
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
    public partial class frmDlgDepartTree : ifrmBase
    {
        private IDepartment mIDepartment;
        public frmDlgDepartTree()
        {
            InitializeComponent();
            mIDepartment = BllFactory.GetDepartmentBll();
        }
        private int layer;

        public int Layer
        {
            get { return layer; }
            set { layer = value; }
        }
        private void Bind()
        {
            DataTable dt = mIDepartment.GetDepartments();
            Node nod = new Node();
            nod.Tag = "";
            nod.Text = "请选择";
            this.treeDepartment.Nodes.Insert(0, nod);
            AddTree(dt, "", null);

        }

        private void AddTree(DataTable dt, string pid, Node pNode)
        {

            DataView dvTree = new DataView(dt);
            if (pid == "")
            {
                dvTree.RowFilter = " ParentID='' or ParentID is null ";
            }
            else
            {
                dvTree.RowFilter = " ParentID= '" + pid + "'";
            }

            foreach (DataRowView drv in dvTree)
            {
                Node Node = new Node();
                if (pNode == null)
                {
                    Node.Text = drv["DepartmentName"].ToString();
                    Node.Name = drv["DepartmentName"].ToString();
                    Node.Tag = drv["ID"].ToString();
                    Node.ImageIndex = 1;
                    this.treeDepartment.Nodes.Add(Node);
                    AddTree(dt, drv["id"].ToString(), Node);
                }
                else
                {

                    Node.Text = drv["DepartmentName"].ToString();
                    Node.Name = drv["DepartmentName"].ToString();
                    Node.Tag = drv["ID"].ToString();
                    Node.ImageIndex = 1;
                    pNode.Nodes.Add(Node);
                    AddTree(dt, drv["id"].ToString(), Node);

                }

            }
        }

        private void frmDlgDepartTree_Load(object sender, EventArgs e)
        {
            Bind();
        }


        private void treeDepartment_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            if (this.treeDepartment.SelectedNode != null)
            {
                string id = this.treeDepartment.SelectedNode.Tag.ToString().Trim();
                string name = this.treeDepartment.SelectedNode.Text.Trim();
                m_del(id + "_" + name);
                this.Close();
            }
        }

    }
}
