﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Model;
using Bll.Sale;
using System.Text.RegularExpressions;
namespace Auto4SErp.Sale
{
    public partial class frmDlgCarInD : ifrmBase
    {
        private ICarDoc mICarDoc;
        private ICarStock mICarStock;
        private string dH;
        //private int mCarDetailIdSel=0;
        private string mAutoNumber;
        private CarInD carInD;

        public CarInD CarInD
        {
            get { return carInD; }
            set { carInD = value; }
        }

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }


        public frmDlgCarInD()
        {
            InitializeComponent();
            mICarDoc = BllFactory.GetCarDocBll();
            mICarStock = BllFactory.GetCarStockBll();
        }

        private void tbtnSel_Click(object sender, EventArgs e)
        {

        }




        private void DoResultFromSuperSel(object obj)
        {
            //string result = (string)obj;
            //string[] strtempl = result.Split('_');
            //mModelIDSeled = int.Parse(strtempl[1]);
            //txtCarModel.Text = strtempl[2];
            string autonumber = (string)obj;
            FillValueToControls(autonumber);

        }

        private void FillValueToControls(string autonumber)
        {
            CarDetail obj = mICarDoc.GetCarDetailObjectByAutoNumber(autonumber);
            txtAutoNumber.Text = obj.AutoNumber;
            txtCarbrand.Text = obj.CarBrand;
            txtCarSer.Text = obj.CarSer;
            txtCarModel.Text = obj.CarModel;
            cmbDisplacement.Text = obj.Displacement;
            cmbInnerStyle.Text = obj.InnerStyle;
            cmbTransmission.Text = obj.Transmission;
            cmbColor.Text = obj.Color;
            cmbCarOfYear.Text = obj.CarOfYear;
            mAutoNumber = autonumber;
            if (Comm.LoginInfoShare.getInstance().OrganId == "301")
                txtInPrice.Text = (obj.DirectPrice * (decimal)0.96).ToString();

            txtDirectPrice.Text = obj.DirectPrice.ToString();
        }


        private void tbtnOK_Click(object sender, EventArgs e)
        {
            CarInD obj = AssginToModel();
            if (obj != null)
            {
                obj.DH = DH;
                //if (mCarDetailIdSel == 0)
                //{
                //    ShowMessage("请选择车辆信息");
                //    return;                         
                //}
                //else
                bool b = mICarStock.IsExistOfVin(txtVin.Text);
                if (b == true)
                {
                    ShowMessage("该车架号已存在");
                    return;
                }


                //if (!Regex.IsMatch(txtDirectPrice.Text, @"^[1-9]\d*$"))
                //{
                //    ShowMessage("请输入指导价");
                //    return;
                //}

                obj.AutoNumber = mAutoNumber;
                if (carInD == null)
                {

                    mICarStock.AddCarInD(obj);

                }
                else
                {
                    obj.ID = carInD.ID;
                    mICarStock.UpdateCarInD(obj);

                }

                mICarStock.updateDirectPriceOfCar(mAutoNumber, txtDirectPrice.Text);
                IsModify = true;


                this.Close();
            }
        }


        private CarInD AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;


            CarInD entity = FrmAssist.PopulateEntityFromCollection<CarInD>(null, lstPairs);
            return entity;

        }

        private void frmDlgCarInD_Load(object sender, EventArgs e)
        {

            mLstControls.Add(txtAutoNumber);
            mLstControls.Add(txtInPrice);
            mLstControls.Add(cmbStorePlace);
            mLstControls.Add(txtVin);
            mLstControls.Add(txtDirectPrice);

            if (carInD != null)
            {
                FillValueToControls(carInD.AutoNumber);
                txtInPrice.Text = carInD.InPrice.ToString();

                cmbStorePlace.Text = carInD.StorePlace;
                txtVin.Text = carInD.Vin;
            }
            LoadExtendContents("存放位置", cmbStorePlace);
            SetTButtonPng(toolStrip1);
        }

        private void dbiInPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCarDocSel_Click(object sender, EventArgs e)
        {
            Point pt = this.Location;
            frmCarDoc frm = new frmCarDoc();
            //   Point NewPoint = new Point(pt.X + this.Width, pt.Y - 50);
            frm.IsSelect = true;
            //   frm.Location = NewPoint;

            frm.setTransferDelegate(new TransferDelegate(this.DoResultFromSuperSel));
            frm.ShowDialogEx();
        }



    }
}
