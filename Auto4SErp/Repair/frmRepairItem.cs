﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll.Repair;
using DevComponents.AdvTree;
namespace Auto4SErp.Repair
{
    public partial class frmRepairItem : ifrmBase
    {

        private IRepairItem mIRepairItemBll;
        private bool isSelect = false;

        public bool IsSelect
        {
            get { return isSelect; }
            set { isSelect = value; }
        }

        private IRepItemPrice mIRepItemPrice;
        public frmRepairItem()
        {
            InitializeComponent();
            mIRepairItemBll = Bll.BllFactory.GetRepairItemBll();
            mIRepItemPrice = Bll.BllFactory.GetRepItemPriceBll();
        }

        private void frmRepairItem_Load(object sender, EventArgs e)
        {
            LoadRepairTypes();
            SetTButtonPng(toolStrip1);
            SetTButtonPng(toolStrip2);
        }

        private void LoadRepairTypes()
        {
            DataTable dt = mIRepairItemBll.GetRepairTypes();
            treeRepariItem.Nodes.Clear();
            AddTree(dt, "", null);
            if (isSelect)
                btnSelect.Visible = true;
            else
                btnSelect.Visible = false;
            treeRepariItem.ExpandAll();
        }



        private void AddTree(DataTable dt, string pid, Node pNode)
        {
            DataView dvTree = new DataView(dt);

            if (pid == "")
            {
                dvTree.RowFilter = " ParentCode='' or ParentCode is null ";
            }
            else
            {
                dvTree.RowFilter = " ParentCode= '" + pid + "'";
            }

            foreach (DataRowView drv in dvTree)
            {
                Node Node = new Node();
                if (pNode == null)
                {
                    Node.Text = drv["TypeCode"].ToString().Trim() + "-" + drv["TypeName"].ToString().Trim();
                    Node.Name = drv["TypeCode"].ToString().Trim();
                    Node.Tag = drv["TypeCode"].ToString().Trim();
                    Node.ImageIndex = 1;
                    this.treeRepariItem.Nodes.Add(Node);
                    AddTree(dt, drv["TypeCode"].ToString(), Node);
                }
                else
                {

                    Node.Text = drv["TypeCode"].ToString().Trim() + "-" + drv["TypeName"].ToString().Trim();
                    Node.Name = drv["TypeCode"].ToString().Trim();
                    Node.Tag = drv["TypeCode"].ToString().Trim();
                    Node.ImageIndex = 1;
                    pNode.Nodes.Add(Node);
                    AddTree(dt, drv["TypeCode"].ToString(), Node);

                }

            }


        }

        private void tsmModifty_Click(object sender, EventArgs e)
        {
            if (treeRepariItem.SelectedNode != null)
            {
                string nodename = treeRepariItem.SelectedNode.Name;
                frmDlgRepairType frm = new frmDlgRepairType();
                frm.TypeCode = nodename;
                frm.Status = 2;
                frm.setRefreshDelegate(delegate(bool IsR)
                {
                    if (IsR)
                    {
                        LoadRepairTypes();
                        ExpandNodes(treeRepariItem.Nodes, nodename);
                    }

                });

                frm.ShowDialogEx();

            }
        }



        private void tsmRoot_Click(object sender, EventArgs e)
        {
            frmDlgRepairType frm = new frmDlgRepairType();
            frm.Status = 0;
            frm.setRefreshDelegate(delegate(bool IsR)
            {
                if (IsR)
                {
                    LoadRepairTypes();
                    ExpandNodes(treeRepariItem.Nodes, "");
                }

            });
            frm.ShowDialogEx();
        }




        private void tsmNode_Click(object sender, EventArgs e)
        {
            Node selNode;
            if ((selNode = treeRepariItem.SelectedNode) != null)
            {
                if (selNode.Level > 2)
                {
                    ShowMessage("级数超过限制");
                    return;

                }


                string nodename = selNode.Name;
                frmDlgRepairType frm = new frmDlgRepairType();
                frm.ParentCode = nodename;
                frm.Status = 1;
                frm.setRefreshDelegate(delegate(bool IsR)
                {
                    if (IsR)
                    {
                        LoadRepairTypes();
                        ExpandNodes(treeRepariItem.Nodes, nodename);
                        if (treeRepariItem.SelectedNode != null)
                            treeRepariItem.SelectedNode.Expand();
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
                        this.treeRepariItem.SelectedNode = node;
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
                        this.treeRepariItem.SelectedNode = node;

                    }
                }
            }
        }


        private void ExpandNodes2(NodeCollection tnodes, string name)
        {

            foreach (Node node in tnodes)
            {
                if (node.Nodes.Count > 0)
                {
                    if (node.Name.Trim() == name.Trim())
                    {
                        node.Expanded = true;

                        return;
                    }
                    ExpandNodes(node.Nodes, name);
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
            Node selNode;
            if ((selNode = treeRepariItem.SelectedNode) != null)
            {

                mIRepairItemBll.DelType(selNode.Name);
                LoadRepairTypes();
            }
        }

        private void dgRepairItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void treeRepariItem_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {

        }

        private void treeRepariItem_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            Node node = e.Node;

            RefreshRepairItem(e.Node.Name);
        }


        private void RefreshRepairItem(string typecode)
        {
            DataTable dt = mIRepairItemBll.GetRepairItemsByCode(typecode);

            dgRepairItem.DataSource = dt;


            //DataGridViewRow dr = dgRepairItem.SelectedRows[0];

            //string itemcode = dr.Cells[0].Value.ToString();

            //dgRepItemPrice.DataSource = mIRepItemPrice.GerRepPriceByItemCode(itemcode);
            if (dt.Rows.Count > 0)
            {
                string itemcode = dt.Rows[0][0].ToString();
                dgRepItemPrice.DataSource = mIRepItemPrice.GerRepPriceByItemCode(itemcode);

            }


        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {



            Node selNode;
            if ((selNode = treeRepariItem.SelectedNode) != null)
            {

                //if (selNode.Level == 0)
                //{
                //    ShowMessage("一级类别不可以添加项目");
                //    return;
                //}

                //DataGridViewRow seldr = dgRepairItem.SelectedRows[0];
                //string strbh = seldr.Cells[0].Value.ToString();

                frmDlgRepairItem frm = new frmDlgRepairItem();
                frm.TypeCode = selNode.Name;
                frm.Status = 0;
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                    {
                        RefreshRepairItem(selNode.Name);

                    }


                });
                frm.ShowDialogEx();


            }


        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgRepairItem.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgRepairItem.SelectedRows[0];
                //string strbh = seldr.Cells[0].Value.ToString();
                frmDlgRepairItem frm = new frmDlgRepairItem();
                frm.Status = 1;
                frm.ItemCode = seldr.Cells[0].Value.ToString();
                frm.ItemName = seldr.Cells[1].Value.ToString();
                frm.TypeCode = seldr.Cells[2].Value.ToString();
                frm.SpellCode = seldr.Cells[4].Value.ToString();
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                    {
                        RefreshRepairItem(treeRepariItem.SelectedNode.Name);

                    }


                });
                frm.ShowDialogEx();

            }
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgRepairItem.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgRepairItem.SelectedRows[0];

                mIRepairItemBll.DeleteRepairItem(seldr.Cells[1].Value.ToString());
                RefreshRepairItem(treeRepariItem.SelectedNode.Name);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmBatchIn frm = new frmBatchIn();
            frm.TableName = "RepairItem";
            frm.ShowDialog();
        }

        private void btnInPrice_Click(object sender, EventArgs e)
        {
            frmBatchIn frm = new frmBatchIn();
            frm.TableName = "RepItemPrice";
            frm.ShowDialog();
        }

        private void dgRepairItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRepairItem.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgRepairItem.SelectedRows[0];

                string itemcode = dr.Cells[0].Value.ToString();

                dgRepItemPrice.DataSource = mIRepItemPrice.GerRepPriceByItemCode(itemcode);

            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dgRepairItem.DataSource = mIRepairItemBll.GetRepairItemsByQuery(txtItemCode.Text, txtItemName.Text);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string itemcode = "";
            string priceid = "";
            string result;
            if (dgRepairItem.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgRepairItem.SelectedRows[0];
                itemcode = dr.Cells[0].Value.ToString();

                if (dgRepItemPrice.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr1 = dgRepItemPrice.SelectedRows[0];
                    priceid = dr1.Cells[0].Value.ToString();
                }
                result = itemcode + "," + priceid;
                if (m_del != null)
                {
                    m_del(result);
                    this.Close();
                }

            }
        }

        private void btnPriceAdd_Click(object sender, EventArgs e)
        {
            // string priceid;
            string itemcode;

            if (dgRepairItem.SelectedRows.Count > 0)
            {
                DataGridViewRow dr1 = dgRepairItem.SelectedRows[0];
                // priceid = dr1.Cells["id"].Value.ToString();
                itemcode = dr1.Cells["itemcode"].Value.ToString();
                frmDlgRepairItemPrice frm = new frmDlgRepairItemPrice();
                //frm.ID = priceid;
                frm.ItemCode = itemcode;
                frm.setRefreshDelegate(r => dgRepItemPrice.DataSource = mIRepItemPrice.GerRepPriceByItemCode(itemcode));
                frm.ShowDialogEx();
                // this.Close();
            }
        }

        private void btnPriceModify_Click(object sender, EventArgs e)
        {
            string priceid;
            string itemcode;
            if (dgRepItemPrice.SelectedRows.Count > 0)
            {
                DataGridViewRow dr1 = dgRepItemPrice.SelectedRows[0];
                priceid = dr1.Cells["id"].Value.ToString();
                itemcode = dr1.Cells["itemcode1"].Value.ToString();
                frmDlgRepairItemPrice frm = new frmDlgRepairItemPrice();
                frm.ID = priceid;
                frm.setRefreshDelegate(r => dgRepItemPrice.DataSource = mIRepItemPrice.GerRepPriceByItemCode(itemcode));
                frm.ShowDialogEx();
            }
        }

        private void btnPriceDel_Click(object sender, EventArgs e)
        {
            string priceid;
            string itemcode;
            if (dgRepItemPrice.SelectedRows.Count > 0)
            {
                DataGridViewRow dr1 = dgRepItemPrice.SelectedRows[0];
                priceid = dr1.Cells["id"].Value.ToString();
                itemcode = dr1.Cells["itemcode1"].Value.ToString();
                mIRepItemPrice.DelRepPrice(priceid);
                dgRepItemPrice.DataSource = mIRepItemPrice.GerRepPriceByItemCode(itemcode);

            }
        }

    }
}
