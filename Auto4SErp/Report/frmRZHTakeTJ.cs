using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Bll.Repair;
using Comm;
using DevExpress.XtraGrid.Views.Grid;
namespace Auto4SErp.Report
{
    public partial class frmRZHTakeTJ : ifrmBase
    {
        private IRepairAccessory mIRepairAccessory;
        public frmRZHTakeTJ()
        {
            InitializeComponent();
            mIRepairAccessory = Bll.BllFactory.GetRepairAccessoryBll();
        }

        private void frmRZHTakeTJ_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "/" + dtNow.Month + "/01 00:00");
            txtDate.SelectedIndex = 0;
            SetTButtonPng(toolStrip1);
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            string strBegin = "";
            string strEnd = "";

            dataSet1.Relations.Clear();
            dataSet1.Tables.Clear();

            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";



            DataTable dt = mIRepairAccessory.GetZHOutDemandsAndTakes(txtDate.SelectedIndex, strBegin, strEnd, 0);
            DataTable dt1 = mIRepairAccessory.GetZHOutDemandsAndTakes(txtDate.SelectedIndex, strBegin, strEnd, 1);

            dataSet1.Tables.Add(dt);
            dataSet1.Tables.Add(dt1);

            DataColumn keyColumn = dt.Columns["DH"];
            DataColumn foreignKeyColumn = dt1.Columns["DH"];

            DataColumn[] keys = { keyColumn, dt.Columns["AccessoryCode"] };
            DataColumn[] foreignkeys = { foreignKeyColumn, dt1.Columns["AccessoryCode"] };
            dataSet1.Relations.Add("DemandsAndTake", keys, foreignkeys, false);

            gridControl1.DataSource = dt;
            gridControl1.ForceInitialize();


            gridView1.Columns["CustName"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            // GridView cardView1 = new GridView(gridControl1);
            //  gridControl1.LevelTree.Nodes.Add("DemandsAndTake", cardView1);

            //gridView2.PopulateColumns(dt1);
            //dgOutWareRec.DataSource = dt;

            //dgOutWareRec1.AutoGenerateColumns = false;
            //dgOutWareRec1.DataSource = dt1;
            // dgOutWareRec.AutoGenerateColumns = false;


        }
    }
}
