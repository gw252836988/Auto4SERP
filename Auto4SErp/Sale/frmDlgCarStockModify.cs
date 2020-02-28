using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bll;
using Bll.Sale;
namespace Auto4SErp.Sale
{
    public partial class frmDlgCarStockModify : ifrmBase
    {


        private CarStock carStock;
        private ICarStock mICarStock;
        public CarStock CarStock
        {
            get { return carStock; }
            set { carStock = value; }
        }


        public frmDlgCarStockModify()
        {
            InitializeComponent();
            mICarStock = BllFactory.GetCarStockBll();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            CarStock obj = AssginToModel();

            if (obj != null)
            {
                obj.ID = carStock.ID;
                mICarStock.UpdateCarStockInfo(obj);

                IsModify = true;
                this.Close();
            }

        }

        private CarStock AssginToModel()
        {
            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;
            CarStock entity = FrmAssist.PopulateEntityFromCollection<CarStock>(null, lstPairs);
            return entity;
        }

        private void frmDlgCarStockModify_Load(object sender, EventArgs e)
        {
            mLstControls.Add(cmbStorePlace);
            mLstControls.Add(txtVin);
            mLstControls.Add(txtInPrice);
            mLstControls.Add(txtImage);
            mLstControls.Add(txtAutoNumber);
            LoadExtendContents("存放位置", cmbStorePlace);
            cmbStorePlace.Text = carStock.StorePlace;
            txtVin.Text = carStock.Vin;
            // dbiInPrice.Value = (double)carStock.InPrice;
            txtInPrice.Text = carStock.InPrice.ToString();
            txtImage.Text = carStock.Image;

            txtAutoNumber.Text = carStock.AutoNumber;

        }



    }
}
