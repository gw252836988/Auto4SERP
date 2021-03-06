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
using Comm;
using Auto4SErp.Cust;
using Auto4SErp.Personnel;
using Bll.Sale;
using Bll.Personnel;
namespace Auto4SErp.Sale
{
    public partial class frmDlgCustVist : ifrmBase
    {
        private ICustomer mICustomer;
        private ICarDoc mICarDoc;
        private ICustVist mICustVist;
        private IStaff mIStaff;
        private int iD = 0;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public frmDlgCustVist()
        {
            InitializeComponent();
            mICustomer = BllFactory.GetCustomerBll();
            mICarDoc = BllFactory.GetCarDocBll();
            mICustVist = BllFactory.GetCustVistBll();
            mIStaff = BllFactory.GetStaffBll();
        }

        private void btnCustSel_Click(object sender, EventArgs e)
        {


            frmCustomerQuery frm = new frmCustomerQuery();
            frm.IsSelect = true;
            frm.setTransferDelegate(DoResultFromCustSel);
            frm.ShowDialogEx();
        }

        private void btnCarDocSel_Click(object sender, EventArgs e)
        {
            frmCarDoc_R frm = new frmCarDoc_R();
            frm.IsSelect = true;
            frm.setTransferDelegate(delegate(object o)
            {

                string autonumber = (string)o;
                //int id = int.Parse(obj.ToString());
                CarDetail obj = mICarDoc.GetCarDetailObjectByAutoNumber(autonumber);
                txtIntentCarBrand.Text = obj.CarBrand;
                txtIntentCarModel.Text = obj.CarModel;
                txtIntentCarSer.Text = obj.CarSer;
                cmbIntentColor.Text = obj.Color;
                cmbIntentDisplacement.Text = obj.Displacement;
                cmbIntentInnerStyle.Text = obj.InnerStyle;
                cmbIntentTransmission.Text = obj.Transmission;
                cmbCarOfYear.Text = obj.CarOfYear;




            });
            frm.ShowDialogEx();

        }




        private void DoResultFromCustSel(object obj)
        {

            string strbh = (string)obj;
            Customer o = mICustomer.GetCustomerByMobile(strbh);
            txtCustName.Text = o.CustName;
            txtMobile.Text = o.Mobile;
            //  txtAddress.Text = o.Address;

            DateTime dt = dtiVistTime.Value;

        }

        private void frmDlgCustVist_Load(object sender, EventArgs e)
        {
            dtiVistTime.Value = DateTime.Now;
            mLstControls.Add(txtMobile);
            mLstControls.Add(dtiVistTime);
            mLstControls.Add(txtRegister);
            mLstControls.Add(cmbVistWay);
            mLstControls.Add(cmbVistReason);
            mLstControls.Add(txtIntentCarBrand);
            mLstControls.Add(txtIntentCarSer);
            mLstControls.Add(txtIntentCarModel);
            mLstControls.Add(cmbIntentDisplacement);
            mLstControls.Add(cmbIntentTransmission);
            mLstControls.Add(cmbIntentInnerStyle);
            mLstControls.Add(cmbIntentColor);
            mLstControls.Add(cmbIntentLevel);
            mLstControls.Add(dipIntentPrice);
            mLstControls.Add(txtElseDemand);
            mLstControls.Add(txtSalesMan);
            mLstControls.Add(txtCustName);

            LoadExtendContents("内饰风格", cmbIntentInnerStyle);
            LoadExtendContents("车身颜色", cmbIntentColor);
            LoadExtendContents("意向级别", cmbIntentLevel);
            LoadExtendContents("促使原因", cmbVistReason);
            LoadExtendContents("来访方式", cmbVistWay);
            cmbIntentInnerStyle.SelectedIndex = -1;
            cmbIntentColor.SelectedIndex = -1;
            cmbIntentLevel.SelectedIndex = -1;
            txtRegister.Text = LoginInfoShare.getInstance().UserName;

            if (iD > 0)
            {

                CustVist obj = mICustVist.GetCustIn(iD);
                AssginModelToControl<CustVist>(obj);
                //Customer oc = mICustomer.GetCustomerByMobile(obj.Mobile);
                //if (oc != null)
                //txtCustName.Text = oc.CustName;
                // txtAddress.Text = oc.Address;
            }
            SetTButtonPng(toolStrip1);
            StartWork(null);

        }


        protected override void DoworkInBack(object sender, DoWorkEventArgs e)
        {

            DataTable dt = mIStaff.GetSalersOfOrgan(LoginInfoShare.getInstance().OrganId);
            //   txtSalesMan.DataSource = dt;
            e.Result = dt;
        }


        protected override void DoBackatCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            DataTable dt = (DataTable)e.Result;
            txtSalesMan.DataSource = dt;
        }

        private CustVist AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;


            CustVist entity = FrmAssist.PopulateEntityFromCollection<CustVist>(null, lstPairs);
            return entity;

        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            CustVist obj = AssginToModel();

            if (obj != null)
            {
                if (iD == 0)
                    mICustVist.AddCustVist(obj);
                else
                {
                    obj.ID = iD;
                    mICustVist.UpdateCustVist(obj);
                }
                this.Close();

            }
        }

        private void tbtnAddCustomer_Click(object sender, EventArgs e)
        {
            //CustVist obj = new CustVist();
            //obj.Mobile = "123";
            //AssginModelToControl<CustVist>(obj);
            frmCustomerEdit frm = new frmCustomerEdit();
            frm.ShowDialogEx();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomerEdit frm = new frmCustomerEdit();
            frm.IsSelect = true;
            frm.setTransferDelegate(DoResultFromCustSel);
            frm.ShowDialogEx();
        }

        private void lblIntentPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnSelStaff_Click(object sender, EventArgs e)
        {
            Point pt = this.Location;
            frmDlgStaffTree frm = new frmDlgStaffTree();
            Point NewPoint = new Point(pt.X + this.Width, pt.Y - 50);
            frm.Location = NewPoint;
            frm.setTransferDelegate(delegate(object o)
            {
                txtSalesMan.Text = (string)o;

            });
            frm.ShowDialog();
        }

        private void btnCommVisit_Click(object sender, EventArgs e)
        {
            txtCustName.Text = "匿名";
            txtMobile.Text = "13900000000";
            txtSalesMan.Text = "暂无";

        }

    }
}
