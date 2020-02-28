using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using Model;
using Bll.Sale;
namespace Auto4SErp
{
    public partial class Form1 : Form
    {
        private ICarSale mICarSale;
        //private DataTable dt;
        public Form1()
        {
            InitializeComponent();
            mICarSale = BllFactory.GetCarSaleBll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
           // string strBegin = "";
           // string strEnd = "";
           // int tmpRecordCount;
           // int tmpPageCount;
           
           //strBegin = "2016-03-01"+ " 00:00:00";
           //strEnd = "2016-03-29" + " 23:59:59";

         


           // dt = mICarSale.GetCarSalesByQuery(strBegin, strEnd, null,0, 10, out tmpRecordCount, out tmpPageCount,isSaler);
           // this.repositoryItemSearchLookUpEdit1.DataSource = dt;
           // gridControl1.DataSource = dt;


           // lookUpEdit1.Properties.DisplayMember = "DH";
           // lookUpEdit1.Properties.ValueMember = "DH";
           // lookUpEdit1.Properties.DataSource = dt;

           // lookUpEdit1.Properties.Columns[1].Caption = "姓名";
           // lookUpEdit1.Properties.Columns[2].Caption = "身份证号";
           // lookUpEdit1.Properties.Columns[1].Width = 120;
           // lookUpEdit1.Properties.Columns[2].Width = 300;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName == "DH")
            //{
            //    string dh= e.Value.ToString();
            //    DataRow[] dr = dt.Select(string.Format("ID = '{0}'", dh));
            //    if (dr != null && dr.Length > 0)
            //    {
            //        DataRow row = dr[0];
            //        string name = row["Name"].ToString();
            //        gridView1.SetRowCellValue(e.RowHandle, "Name", name);
            //    }
            //}
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.NullText = null;
        }
    }
}
