﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auto4SErp.Sale;
using Bll.Sale;
using Bll;
using Model;
namespace Auto4SErp.Cust
{
    public partial class frmDlgCarOfCustomer : ifrmBase
    {
        private ICarDoc mICarDoc;
        private ICustomer mICustomer;
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private string plate = "";

        public string Plate
        {
            get { return plate; }
            set { plate = value; }
        }


        private string iD;

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }


        public frmDlgCarOfCustomer()
        {
            InitializeComponent();
            mICarDoc = Bll.BllFactory.GetCarDocBll();
            mICustomer = Bll.BllFactory.GetCustomerBll();
        }

        private void btnCarDocSel_Click(object sender, EventArgs e)
        {
            //frmCarDoc frm = new frmCarDoc();
            //frm.IsSelect = true;
            //frm.setTransferDelegate(delegate(object obj)
            //{
            //    //int id = int.Parse(obj.ToString());
            //    string autonumber = (string )obj;
            //    CarDetail o= mICarDoc.GetCarDetailObjectByAutoNumber(autonumber);
            //    txtCarBrand.Text =o.CarBrand;
            //    txtCarModel.Text =o.CarModel;
            //    txtCarSer.Text = o.CarSer;
            //    txtCarColor.Text = o.Color;

            //});
            //frm.ShowDialogEx();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            //Car obj= AssginToModel();
            //if (obj != null)
            //{
            //    obj.Mobile = mobile;
            //    if (string.IsNullOrEmpty(plate))
            //    {

            //        mICustomer.AddCarOfCustomer(obj);
            //        ShowMessage("添加成功");
            //        this.Close();
            //    }
            //    else
            //    {
            //        mICustomer.UpdateCarOfCustomer(obj);
            //        ShowMessage("修改成功");
            //        this.Close();
            //    }

            //}

            if (txtPlateNum.Text.Length < 3)
            {
                ShowMessage("请输入正确的车牌号");
                return;
            }

            if (mICustomer.IsPlateNumExists(txtPlateNum.Text))
            {
                ShowMessage("已有该车牌号，不能重复录入");
                return;
            }
            mICustomer.ModifyPlateNumOfCar(iD, txtPlateNum.Text);
            this.Close();
        }

        private Car AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;


            Car entity = FrmAssist.PopulateEntityFromCollection<Car>(null, lstPairs);
            return entity;
        }

        private void frmDlgCarOfCustomer_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtPlateNum);
            mLstControls.Add(txtVin);
            mLstControls.Add(txtCarBrand);
            mLstControls.Add(txtCarSer);
            mLstControls.Add(txtCarModel);
            mLstControls.Add(txtCarColor);
            SetTButtonPng(toolStrip1);

            if (!string.IsNullOrEmpty(iD))
            {
                Car obj = mICustomer.GetCarByID(iD);
                if (obj != null)
                {
                    txtCarBrand.Text = obj.CarBrand;
                    txtCarModel.Text = obj.CarModel;
                    txtCarSer.Text = obj.CarSer;
                    txtCarColor.Text = obj.CarColor;
                    txtPlateNum.Text = obj.PlateNum;
                    txtVin.Text = obj.Vin;
                    btnOK.Enabled = true;
                }

            }

        }
    }
}
