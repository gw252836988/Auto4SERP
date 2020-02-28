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

namespace Auto4SErp
{
    public partial class FrmDepartment : Form
    {
        private IDepartment mIDepartment;
        private DataTable mDepartment;
        public FrmDepartment()
        {
            InitializeComponent();
            mIDepartment = BllFactory.GetDepartmentBll();
        }

        private void DataToControl(DataTable dt)
        {
            FrmAssist.UpdateColumns(ref mDepartment, dt, 9);
            dgvDepart.DataSource = dt;



        }

        private void Bind()
        {
            this.dgvDepart.DataSource = null;
            this.treeDepart.Nodes.Clear();
            DataTable dt = mIDepartment.GetDepartments();

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
                    Node.Text = drv["DepartmentName"].ToString().Trim();
                    Node.Name = drv["ID"].ToString().Trim();
                    Node.Tag = drv["ID"].ToString().Trim();
                    Node.ImageIndex = 1;
                    this.treeDepart.Nodes.Add(Node);
                    AddTree(dt, drv["id"].ToString(), Node);
                }
                else
                {

                    Node.Text = drv["DepartmentName"].ToString().Trim();
                    Node.Name = drv["ID"].ToString().Trim();
                    Node.Tag = drv["ID"].ToString().Trim();
                    Node.ImageIndex = 1;
                    pNode.Nodes.Add(Node);
                    AddTree(dt, drv["id"].ToString(), Node);

                }

            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FrmDlgDepartment frm = new FrmDlgDepartment();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                if (isR)
                {
                    Bind();
                }
            });
            frm.ShowDialogEx();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void treeDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.treeDepart.SelectedNode != null)
            {
                DataTable dt = mIDepartment.GetDepartmentByID(this.treeDepart.SelectedNode.Tag.ToString().Trim());
                DataToControl(dt);
            }
        }



        private void tsmModifty_Click(object sender, EventArgs e)
        {
            if (this.treeDepart.SelectedNode != null)
            {
                string obj = this.treeDepart.SelectedNode.Name;
                FrmDlgDepartment frm = new FrmDlgDepartment();
                frm.Departmentid = this.treeDepart.SelectedNode.Tag.ToString();
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                    {
                        Bind();
                        ExpandNodes(treeDepart.Nodes, obj.Trim());
                    }
                });
                frm.ShowDialogEx();
            }
        }



        //遍历所有节点，找出指定节点
        private void ExpandNodes(NodeCollection tnodes, string name)
        {

            foreach (Node node in tnodes)
            {
                if (node.Nodes.Count > 0)
                {
                    if (node.Name.Trim() == name.Trim())
                    {
                        this.treeDepart.SelectedNode = node;
                        if (node.Parent != null)
                        {
                            ExpandParentNodes(node.Parent.Nodes);//调用下一个递归方法
                        }
                        return;
                    }
                    ExpandNodes(node.Nodes, name);
                }
                else
                {
                    if (node.Name.Trim() == name.Trim())
                    {
                        if (node.Parent != null)
                        {
                            ExpandParentNodes(node.Parent.Nodes);//调用下一个递归方法
                        }
                        this.treeDepart.SelectedNode = node;
                      
                    }
                }
            }
        }

        //关键点所在
        private void ExpandParentNodes(NodeCollection tnodes)
        {
            Node parentNode;
            foreach (Node node in tnodes)
            {
                parentNode = node;
                if (parentNode.Parent != null)
                {
                    parentNode.Parent.Expand();
                    if (parentNode.Parent.Parent != null)
                    {
                        ExpandParentNodes(parentNode.Parent.Parent.Nodes);
                    }
                    else
                        break;
                }
            }
        }
        private void tsmDel_Click(object sender, EventArgs e)
        {
            if (this.treeDepart.SelectedNode != null)
            {
                if (MessageBox.Show("是否确认删除?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = this.treeDepart.SelectedNode.Tag.ToString();
                    bool result = mIDepartment.DelDepartmentByID(id);
                    if (result)
                    {
                        Bind();
                    }
                }
            }
        }
    }
}
