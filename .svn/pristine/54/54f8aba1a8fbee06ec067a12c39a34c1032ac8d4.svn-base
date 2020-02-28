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
    public partial class frmDlgCarBrand : ifrmBase
    {
        private int brandId = 0;
        private ICarDoc mICarDoc=BllFactory.GetCarDocBll();


        public frmDlgCarBrand()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

      

        public int BrandID
        {
            get { return brandId; }
            set { brandId = value; }
        }
        

   
        private void frmDlgCarBrand_Load(object sender, EventArgs e)
        {
            if (brandId > 0)
            {
                DataTable dt = mICarDoc.GetCarBrand(brandId);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    this.txtBrand.Text = dr["brandname"].ToString();
                }

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string brandname = this.txtBrand.Text.Trim();
            if (brandname != "")
            {
                bool result = false;
                if (brandId > 0)
                {
                    result = mICarDoc.UpdateCarBrand(brandname, brandId);
                    IsModify = true; 
                    this.Close();
                }
                else
                {

                    result = mICarDoc.AddCarBrand(brandname);
                    IsModify = true;
                    ClearAllInput();

                }
            }
           
        }

        private void ClearAllInput()
        {
            txtBrand.Text = "";

        }

    }
}
