using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.AdvTree;
using Bll;
using System.Collections;
namespace Auto4SErp
{
    public partial class frmCarDoc : ifrmBase
    {

        private ICarDoc mICarDoc;
        private DataTable mDtDicOfCarDeital=null;
   
        public frmCarDoc()
        {
            InitializeComponent();
      
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Text = treeCarDoc.SelectedNode.Text;
        }

        private void frmCarDoc_Load(object sender, EventArgs e)
        {
            mICarDoc = BllFactory.GetCarDocBll();
           

            LoadNodes();
      
        }


        protected override void DoworkInBack(object sender, DoWorkEventArgs e)
        {

               DataSet ds = mICarDoc.GetCarDocAll();
               e.Result = ds;
        }


        protected override void DoBackatCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            DataSet ds = (DataSet)e.Result;
            DataTable dtBrands = ds.Tables["CarBrand"];
            DataTable dtCarSers = ds.Tables["CarSer"];
            DataTable dtCarModels = ds.Tables["CarModel"];


            //DataView dvCarSers=dtCarSers.DefaultView;
            foreach (DataRow drBrand in dtBrands.Rows)
            {
                Node nodeBrand = CreateNode(drBrand[1].ToString(), "brand_" + drBrand[0].ToString());

                treeCarDoc.Nodes.Add(nodeBrand);



                DataView dvCarSers = new DataView(dtCarSers);
                dvCarSers.RowFilter = "carbrand=" + drBrand[0].ToString();

                for (int i = 0; i < dvCarSers.Count; i++)
                {
                    DataRowView drCarSer = dvCarSers[i];
                    Node nodeSer = CreateNode(drCarSer["carser"].ToString(), "ser_" + drCarSer[0].ToString());
                    nodeBrand.Nodes.Add(nodeSer);


                    DataView dvCarModels = new DataView(dtCarModels);
                    dvCarModels.RowFilter = "carser=" + drCarSer[0].ToString();

                    for (int j = 0; j < dvCarModels.Count; j++)
                    {
                        DataRowView drCarModel = dvCarModels[j];
                        Node nodeModel = CreateNode(drCarModel["carmodel"].ToString(), "model_" + drCarModel[0].ToString());
                        nodeSer.Nodes.Add(nodeModel);

                    }
                }
            }
            treeCarDoc.ExpandAll();

        }

        private void LoadNodes()
        {
            StartWork();

           

        }


        private void ReLoadNodes()
        {
            treeCarDoc.Nodes.Clear();
            LoadNodes();
        }

        private Node CreateNode(string text, string key)
        {

            Node node = new Node();
            node.Text = text;
            node.DataKeyString = key;
            node.ContextMenu = cmenuCarDoc;
            return node;
        }

    

        private void cmenuCarDoc_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Node selNode=treeCarDoc.SelectedNode;
            string[] strLst = selNode.DataKeyString.Split('_');
            switch(strLst[0])
            {
                case "brand":

                    if (e.ClickedItem.Text == "删除")
                    {
                        mICarDoc.DelCarBrand(int.Parse(strLst[1]));
                        ReLoadNodes();
                    }
                    else
                    {
                        frmDlgCarBrand frmBrand = new frmDlgCarBrand();
                        frmBrand.BrandID = int.Parse(strLst[1]);
                        frmBrand.ShowDialogEx();
                        ReLoadNodes();

                    }
                    break;

                case "ser":
                    if (e.ClickedItem.Text == "删除")
                    {
                        mICarDoc.DelCarSer(int.Parse(strLst[1]));
                        ReLoadNodes();
                    }
                    else
                    {
                        frmDlgCarSer frmSer = new frmDlgCarSer();
                        frmSer.CarserId = int.Parse(strLst[1]);
                        frmSer.ShowDialogEx();
                        ReLoadNodes();
                    }


                    break;

                case "model":
                    if (e.ClickedItem.Text == "删除")
                    {
                        mICarDoc.DelCarModel(int.Parse(strLst[1]));
                        ReLoadNodes();
                    }
                    else
                    {
                        frmDlgCarModel frmModel = new frmDlgCarModel();
                        frmModel.CarModelId = int.Parse(strLst[1]);
                        frmModel.ShowDialogEx();
                        ReLoadNodes();
                    }



                    break;

                default:

                    break;


            }



        }

      
        private void cmenuCarDetail_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (dgCarDetails.SelectedRows.Count != 0)
            {

                DataGridViewRow seldr = dgCarDetails.SelectedRows[0];
                string strid= seldr.Cells[0].Value.ToString();
                string strmodleid = seldr.Cells[seldr.Cells.Count-1].Value.ToString();
                if (e.ClickedItem.Text == "删除")
                {
                    mICarDoc.DelCarDetail(int.Parse(strid));
                    RefreshCarDetails(int.Parse(strmodleid));
                }
                else
                {
                    frmDlgCarDetail frm = new frmDlgCarDetail();
                    frm.CarDetailId = int.Parse(strid);
                    frm.setRefreshDelegate(delegate(bool isR)
                    {
                        if (isR) RefreshCarDetails(int.Parse(strmodleid));
                    });
                    frm.ShowDialogEx();
                  
                }
            }

          
        }

        private void RefreshCarDetails(int carmodel)
        {
            DataTable dt = mICarDoc.GetCarDetailByCarmodel(carmodel);
            dt.Columns.RemoveAt(dt.Columns.Count - 1);
            FrmAssist.UpdateColumns(mDtDicOfCarDeital, dt, 1);
           
            dgCarDetails.DataSource = dt;
            dgCarDetails.Columns[0].Visible = false;
            dgCarDetails.Columns[dgCarDetails.Columns.Count - 1].Visible = false;


        }

        private void treeCarDoc_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            Node node = e.Node;
            string[] strLst=e.Node.DataKeyString.Split('_');
            if (strLst[0] == "model")
            {
                RefreshCarDetails(Int16.Parse(strLst[1]));
                
            }
        
        }

        

        private void mItemAddBrand_Click(object sender, EventArgs e)
        {
            frmDlgCarBrand frm = new frmDlgCarBrand();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                if (isR) ReLoadNodes();
            });
            frm.ShowDialogEx();
           

        }
        private void mItemAddSer_Click(object sender, EventArgs e)
        {
            frmDlgCarSer frm = new frmDlgCarSer();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                if (isR) ReLoadNodes();
            });
            frm.ShowDialogEx();
          
        }

        private void mItemAddModel_Click(object sender, EventArgs e)
        {
            frmDlgCarModel frm = new frmDlgCarModel();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                if (isR) ReLoadNodes();
            });
            frm.ShowDialogEx();
        }

        private void mItemAddDtail_Click(object sender, EventArgs e)
        {
            frmDlgCarDetail frm = new frmDlgCarDetail();
            frm.setRefreshDelegate(delegate(bool isR)
            {
                if (isR) ReLoadNodes();
            });
            frm.ShowDialogEx();
           
        }

    }
}
