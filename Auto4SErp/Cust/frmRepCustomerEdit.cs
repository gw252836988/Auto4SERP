﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.Sale;
using Bll;
using Model;
using Auto4SErp.Sale;
namespace Auto4SErp.Cust
{
    public partial class frmRepCustomerEdit : ifrmBase
    {

        private ICustomer mICustomer;
        private ICarDoc mICarDoc;
        private ICarSale mICarSale;
        private bool mBuyhere = false;
        public string PlateNum
        {
            get;
            set;
        }


        public string Mobile
        {
            get;
            set;
        }
        public frmRepCustomerEdit()
        {
            mICustomer = BllFactory.GetCustomerBll();
            mICarDoc = Bll.BllFactory.GetCarDocBll();
            mICarSale = Bll.BllFactory.GetCarSaleBll();
            InitializeComponent();
        }

        private void frmRepCustomerEdit_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            LoadExtendContents("保险公司", cmbInsuranceCompany);
            cmbInsuranceCompany.SelectedIndex = -1;


            //有手机号，没有车牌号的时候
            if (!string.IsNullOrEmpty(Mobile) && string.IsNullOrEmpty(PlateNum))
            {
                txtMobile.Text = Mobile;

                Customer cust = mICustomer.GetCustomerByMobile(txtMobile.Text);
                if (cust != null)
                {
                    txtCustName.Text = cust.CustName;
                    cmbCustType.Text = cust.CustType;
                    txtAddress.Text = cust.Address;
                }

                string vin = mICarSale.CheckBuyFormHere(txtMobile.Text);
                if (!string.IsNullOrEmpty(vin))
                {
                    txtVin.Text = vin;
                    mBuyhere = true;
                    chbBuyHere.Checked = true;
                }



            }
            //有车牌号的时候
            if (!string.IsNullOrEmpty(PlateNum))
            {
                txtPlateNum.Text = PlateNum;
                DataTable dt = mICustomer.GetCarByPalteNum(PlateNum);
                if (dt != null)
                {
                    txtCarBrand.Text = dt.Rows[0]["CarBrand"].ToString();
                    txtCarModel.Text = dt.Rows[0]["CarModel"].ToString();
                    txtCarSer.Text = dt.Rows[0]["CarSer"].ToString();
                    txtColor.Text = dt.Rows[0]["CarColor"].ToString();
                    txtPlateNum.Text = dt.Rows[0]["PlateNum"].ToString();
                    txtVin.Text = dt.Rows[0]["Vin"].ToString();
                    txtAddress.Text = dt.Rows[0]["address"].ToString();

                    txtMobile.Text = dt.Rows[0]["Mobile"].ToString();
                    txtCustName.Text = dt.Rows[0]["CustName"].ToString();
                    cmbCustType.Text = dt.Rows[0]["CustType"].ToString();
                    txtEngineID.Text = dt.Rows[0]["EngineID"].ToString();
                    if (dt.Rows[0]["InsuranceCompany"] != null)
                        cmbInsuranceCompany.Text = dt.Rows[0]["InsuranceCompany"].ToString();
                    if (dt.Rows[0]["InBegin"] != null && !string.IsNullOrEmpty(dt.Rows[0]["InBegin"].ToString()))
                        datInBegin.Value = DateTime.Parse(dt.Rows[0]["InBegin"].ToString());
                    if (dt.Rows[0]["InEnd"] != null && !string.IsNullOrEmpty(dt.Rows[0]["InEnd"].ToString()))
                        datInEnd.Value = DateTime.Parse(dt.Rows[0]["InEnd"].ToString());

                    if (dt.Rows[0]["KeepBegin"] != null && !string.IsNullOrEmpty(dt.Rows[0]["KeepBegin"].ToString()))
                        datKeepBegin.Value = DateTime.Parse(dt.Rows[0]["KeepBegin"].ToString());
                    if (dt.Rows[0]["KeepEnd"] != null && !string.IsNullOrEmpty(dt.Rows[0]["KeepEnd"].ToString()))
                        datKeepEnd.Value = DateTime.Parse(dt.Rows[0]["KeepEnd"].ToString());

                    if (dt.Rows[0]["BuyHere"] != null && dt.Rows[0]["BuyHere"].ToString() == "是")
                        chbBuyHere.Checked = true;
                    else
                        chbBuyHere.Checked = false;

                    if (dt.Rows[0]["P2PMobile"] != null && !string.IsNullOrEmpty(dt.Rows[0]["P2PMobile"].ToString()))
                        chbP2PVip.Checked = true;
                    else
                        chbP2PVip.Checked = false;


                    txtPlateNum.ReadOnly = true;
                }

            }
            mBuyhere = chbBuyHere.Checked;
            txtPlateNum.Focus();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void SetStatus(int status)
        {

            if (status == 0)
            {
                txtPlateNum.Enabled = true;


            }
            else
            {
                txtPlateNum.Enabled = false;

            }
        }


        private Car CreateValuesOfObject()
        {

            Car obj = new Car();
            obj.PlateNum = txtPlateNum.Text;
            obj.Vin = txtVin.Text;
            obj.CarSer = txtCarSer.Text;
            obj.CarBrand = txtCarBrand.Text;
            obj.CarModel = txtCarModel.Text;
            obj.CarColor = txtColor.Text;
            obj.Mobile = txtMobile.Text;

            obj.InsuranceCompany = cmbInsuranceCompany.Text;
            obj.InBegin = datInBegin.Value;
            obj.InEnd = datInEnd.Value;
            obj.KeepBegin = datKeepBegin.Value;
            obj.KeepEnd = datKeepEnd.Value;
            obj.EngineID = txtEngineID.Text;
            if (mBuyhere)
                obj.BuyHere = "是";

            return obj;
        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            if (txtPlateNum.Text.Length < 3)
            {
                ShowMessage("请输入正确的车牌号");
                return;
            }

            if (txtVin.Text.Length < 3)
            {
                ShowMessage("请输入Vin码");
                return;
            }

            if (txtMobile.Text.Length != 11)
            {
                ShowMessage("请输入正确的手机号码");
                return;
            }

            if (string.IsNullOrEmpty(txtCustName.Text))
            {
                ShowMessage("客户姓名不能为空");
                return;
            }

            Car obj = CreateValuesOfObject();

            //添加或更新客户信息
            Customer cust = new Customer();
            cust.Mobile = obj.Mobile;
            cust.CustName = txtCustName.Text;
            cust.CustType = cmbCustType.Text;
            cust.Address = txtAddress.Text;
            mICustomer.UpdateBaseCustomerInfo(cust);


            //string vin = mICarSale.CheckBuyFormHere(txtMobile.Text);
            //if(!string.IsNullOrEmpty(vin))
            //{
            //    if (!mBuyhere)
            //    {
            //        if (ShowMessageOfWarning("该车在本店有购买记录，是否检查后保存") == DialogResult.OK)
            //            return;
            //    }
            //}


            bool isCar = mICustomer.IsCarByPlateAndMobile(txtPlateNum.Text, txtMobile.Text);




            //已经拥有车辆信息的情况
            if (isCar)
            {
                mICustomer.UpdateCarOfCustomer(obj);

            }
            else
            {
                Car objcar = mICustomer.GetCarByPlate(obj.PlateNum);
                if (mICustomer.IsPlateNumExists(obj.PlateNum))
                {
                    ShowMessage("已有该车牌号，不能重复录入");
                    return;
                }
                if (mICustomer.IsPlateVinExists(obj.Vin))
                {
                    if (ShowMessageOfWarning("该Vin已有，是否删除原有Vin") == DialogResult.OK)
                    {
                        mICustomer.DelVinOfCar(obj.Vin);
                        // return;

                    }
                    else
                        return;
                }
                mICustomer.AddCarOfCustomer(obj);

            }
            //if (objcar==null)
            //{           
            //    mICustomer.AddCarOfCustomer(obj);
            //}
            //else
            //{
            //    //更新客户资料
            //    mICustomer.UpdateCarOfCustomer(obj);

            //}
            if (m_del != null)
            {
                m_del(obj.Mobile + "," + obj.PlateNum);
                this.Close();

            }
        }

        private void btnCarDocSel_Click(object sender, EventArgs e)
        {
            frmCarDoc_R frm = new frmCarDoc_R();
            frm.IsSelect = true;
            frm.setTransferDelegate(delegate(object obj)
            {
                //int id = int.Parse(obj.ToString());
                string autonumber = (string)obj;
                CarDetail o = mICarDoc.GetCarDetailObjectByAutoNumber(autonumber);
                txtCarBrand.Text = o.CarBrand;
                txtCarModel.Text = o.CarModel;
                txtCarSer.Text = o.CarSer;
                txtColor.Text = o.Color;

            });
            frm.ShowDialogEx();
        }


        private void btnGet_Click(object sender, EventArgs e)
        {


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text.Length != 11)
            {
                ShowMessage("请先输入手机号码");
                return;
            }

            Customer cust = mICustomer.GetCustomerByMobile(txtMobile.Text);
            if (cust != null)
            {
                txtCustName.Text = cust.CustName;
            }
            string vin = mICarSale.CheckBuyFormHere(txtMobile.Text);
            if (!string.IsNullOrEmpty(vin))
            {
                txtVin.Text = vin;
                mBuyhere = true;
                chbBuyHere.Checked = true;
            }
        }

        private void cmbInsuranceCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInsuranceCompany.SelectedIndex == -1)
            {
                datInBegin.Enabled = false;
                datInEnd.Enabled = false;

            }
            else
            {
                datInBegin.Enabled = true;
                datInEnd.Enabled = true;

            }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
