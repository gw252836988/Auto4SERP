using Bll;
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
    public partial class frmDlgCarSer : ifrmBase
    {
        private int carserId = 0;
        private int mBrandIDSeled=0;
        public int CarserId
        {
            get { return carserId; }
            set { carserId = value; }
        }

        private ICarDoc mICarDoc = BllFactory.GetCarDocBll();

        public frmDlgCarSer()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            
        }
    
        //private void BindBrand()
        //{
        //    DataTable dt = mICarDoc.GetCarBrands();
        //    if (dt.Rows.Count > 0)
        //    {
        //        this.cmbBrand.Items.Clear();
        //        this.cmbBrand.DataSource = dt;
        //        this.cmbBrand.DisplayMember = "brandname";
        //        this.cmbBrand.ValueMember = "id";
        //    }
        //}
        private void frmDlgCarSer_Load(object sender, EventArgs e)
        {
            //BindBrand();

            if (carserId > 0)
            {
               
                DataTable dt = mICarDoc.GetCarSer(carserId);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    this.txtCarSer.Text = dr["carser"].ToString();
                    this.txtCarBrand.Text = dr["brandname"].ToString();
                    mBrandIDSeled = int.Parse(dr["carbrand"].ToString());
                }
            }      

        }

   
       
        private void btnSel_Click(object sender, EventArgs e)
        {

            Point pt = this.Location;
            frmDlgCarSuperSel frm = new frmDlgCarSuperSel();
            Point NewPoint=new Point(pt.X+this.Width,pt.Y-50);
           
            frm.Location = NewPoint;
            frm.Layer = 0;
            frm.setTransferDelegate(new TransferDelegate(this.DoResultFromSuperSel));
            frm.ShowDialogEx();


        }


        private void DoResultFromSuperSel(object obj)
        {
            string result = (string )obj;
            string[] strtempl = result.Split('_');
            mBrandIDSeled = int.Parse(strtempl[1]);
            txtCarBrand.Text = strtempl[2];

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string carser = this.txtCarSer.Text.Trim();//获取输入值
       
            if (carser != "")
            {
                bool result = false;
              
                 if (carserId > 0)
                {

                    result = mICarDoc.UpdateCarSer(carser, mBrandIDSeled, carserId);
                    IsModify = true;
                     
                    this.Close();

                 }
                 else
                 {
                     if (mBrandIDSeled > 0)//必须选择上级
                     {
                         result = mICarDoc.AddCarSer(carser, mBrandIDSeled);
                         IsModify = true;
                     }


                 }
               
                
            }
        }
    }
}
