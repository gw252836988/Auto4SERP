using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Reflection;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using Comm;
using Bll;
using DevComponents.Editors;
using Bll.Sale;

namespace Auto4SErp.Sale
{
    public partial class frmDlgCarDetail : ifrmBase
    {

        private bool isAdd;
        private int carDetailId = 0;
        private int mModelIDSeled = 0;
        private ICarDoc mICarDoc;
        public string ModelInfo
        {
            get;
            set;
        }



        public int CarDetailId
        {
            get { return carDetailId; }
            set { carDetailId = value; }
        }

        public bool IsAdd
        {
            get { return isAdd; }
            set { isAdd = value; }
        }



        public frmDlgCarDetail()
        {
            InitializeComponent();
            mICarDoc = BllFactory.GetCarDocBll();

            //mFrmAssist = new FrmAssist();
            //mFrmAssist.EErrorInfo += new ErrorInfoDelegate(this.ShowError);
            //mLstControls = new List<Control>();


        }



        private CarDetail AssginToModel()
        {




            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;


            CarDetail entity = FrmAssist.PopulateEntityFromCollection<CarDetail>(null, lstPairs);
            return entity;

        }

        private void tbtnSel_Click(object sender, EventArgs e)
        {
            Point pt = this.Location;
            frmDlgCarSuperSel frm = new frmDlgCarSuperSel();
            Point NewPoint = new Point(pt.X + this.Width, pt.Y - 50);
            frm.Location = NewPoint;
            frm.Layer = 2;
            frm.setTransferDelegate(new TransferDelegate(this.DoResultFromSuperSel));
            frm.ShowDialog();
        }

        private void DoResultFromSuperSel(object obj)
        {
            string result = (string)obj;
            string[] strtempl = result.Split('_');
            mModelIDSeled = int.Parse(strtempl[1]);
            txtCarModel.Text = strtempl[2];

        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            RenewDate();


        }


        protected override void RenewDate()
        {
            CarDetail obj = AssginToModel();
            if (obj != null)
            {
                if (carDetailId > 0)
                {
                    mICarDoc.UpdateCarDetail(obj, mModelIDSeled, carDetailId);

                    IsModify = true;
                    this.Close();

                }
                else
                {
                    if (mModelIDSeled > 0)
                    {
                        if (mICarDoc.AddCarDetail(obj, mModelIDSeled))
                        {
                            ShowMessage("该自编号已存在");
                            return;

                        }
                        IsModify = true;
                        ClearInput();
                    }
                }

            }

        }

        private void ClearInput()
        {

            foreach (Control c in this.Controls)
            {
                if (c.Name == "txtCarModel") continue;
                TextBoxX cTB = c as TextBoxX;
                if (cTB != null)
                {
                    cTB.Text = "";

                }
                else
                {
                    ComboBoxEx cb = c as ComboBoxEx;
                    if (cb != null)
                    {
                        cb.SelectedIndex = 0;
                    }

                    DoubleInput di = c as DoubleInput;
                    if (di != null)
                    {
                        di.Value = 0.00;

                    }

                }



            }



        }


        private void frmDlgCarDetail_Load(object sender, EventArgs e)
        {
            // mLstControls.Add(txtAutoNumber);
            mLstControls.Add(txtCarModel);
            mLstControls.Add(cmbDisplacement);
            mLstControls.Add(cmbTransmission);
            mLstControls.Add(cmbInnerStyle);
            mLstControls.Add(cmbColor);
            mLstControls.Add(cmbCarOfYear);
            //  mLstControls.Add(dbiCostPrice);
            mLstControls.Add(dbiAllotPrice);
            mLstControls.Add(dbiSalePrice);
            mLstControls.Add(dbiDirectPrice);
            mLstControls.Add(dbiMinPrice);
            InitData();
            SetTButtonPng(toolStrip1);
            mLstSenstiveTB.Add(btnPriceSave);
            CheckSPsOfStaff("CarDoc");
            lblTip.Text = "最大:" + mICarDoc.GetMaxZBH();
            if (!string.IsNullOrEmpty(ModelInfo))
            {
                DoResultFromSuperSel(ModelInfo);

            }
            cmbCarOfYear.SelectedIndex = 0;
        }

        private void InitData()
        {
            LoadExtendContents("内饰风格", cmbInnerStyle);
            LoadExtendContents("车身颜色", cmbColor);
            if (carDetailId > 0)
            {

                DataTable dt = mICarDoc.GetCarDetails(carDetailId);//赋值

                txtAutoNumber.Text = dt.Rows[0]["autonumber"].ToString();
                cmbColor.Text = dt.Rows[0]["color"].ToString();
                cmbDisplacement.Text = dt.Rows[0]["displacement"].ToString();
                cmbTransmission.Text = dt.Rows[0]["transmission"].ToString();
                cmbInnerStyle.Text = dt.Rows[0]["innerstyle"].ToString();

                cmbCarOfYear.Text = dt.Rows[0]["carofyear"].ToString();


                dbiAllotPrice.Value = Double.Parse(dt.Rows[0]["allotprice"].ToString());
                dbiCostPrice.Value = Double.Parse(dt.Rows[0]["costprice"].ToString());
                dbiMinPrice.Value = Double.Parse(dt.Rows[0]["minprice"].ToString());
                dbiSalePrice.Value = Double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["saleprice"].ToString()));


                dbiDirectPrice.Value = Double.Parse(Comm.ElseUtil.ReturnZero(dt.Rows[0]["directprice"].ToString()));

                txtCarModel.Text = dt.Rows[0]["carmodelname"].ToString();

                mModelIDSeled = int.Parse(dt.Rows[0]["carmodelid"].ToString());

            }


        }

        private void frmDlgCarDetail_Shown(object sender, EventArgs e)
        {

        }

        private void btnPriceSave_Click(object sender, EventArgs e)
        {
            IsModify = true;
            mICarDoc.UpdateCarPrice(txtAutoNumber.Text, dbiCostPrice.Value, dbiSalePrice.Value, dbiDirectPrice.Value);
            ShowMessage("价格修改成功");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmExtend frm = new frmExtend();
            frm.LimitContent = "车身颜色";
            frm.ShowDialogEx();
        }

        private void btnPriceQuery_Click(object sender, EventArgs e)
        {

            Point pt = this.Location;
            frmDlgLimitPrice frm = new frmDlgLimitPrice();
            frm.AutoNumber = txtAutoNumber.Text;
            Point NewPoint = new Point(pt.X + this.Width, pt.Y - 50);
            frm.Location = NewPoint;
            frm.ShowDialog();
        }






    }
}
