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
using System.Reflection;
namespace Auto4SErp.Cust
{
    public partial class frmCustomerEdit : ifrmBase
    {
        private ICustomer mIcustomer;
        private string mMobile;

        public bool IsSelect
        {
            get;
            set;

        }

        public string Mobile
        {

            set
            {
                mMobile = value;

                Customer obj = mIcustomer.GetCustomerByMobile(mMobile);
                InitDataByModel(obj);
            }
        }

        public frmCustomerEdit()
        {
            InitializeComponent();
            mIcustomer = BllFactory.GetCustomerBll();

            mLstControls.Add(txtMobile);
            mLstControls.Add(txtCustName);
            mLstControls.Add(cmbSex);
            mLstControls.Add(txtTelephone);
            mLstControls.Add(txtAddress);
            mLstControls.Add(txtIdentityCard);
            mLstControls.Add(cmbJob);
            mLstControls.Add(cmbIsMarryed);
            mLstControls.Add(cmbAgeScope);
            mLstControls.Add(cmbEducation);
            mLstControls.Add(txtQQ);
            mLstControls.Add(txtWx);
            mLstControls.Add(txtEmail);
        }




        //private void btnOK_Click(object sender, EventArgs e)
        //{



        //    Customer o = new Customer();
        //    o.Mobile = lblMobileV.Text;
        //    o.CustName = txtCustName.Text;
        //    o.Sex = cmbSex.Text;
        //    o.Address = txtAddress.Text;
        //    o.Telephone = txtTelephone.Text; 
        //    mIcustomer.UpdateBaseCustomerInfo(o);
        //}

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {


            //Customer o = mIcustomer.GetCustomerByMobile("123");
            ////
            //txtCustName.Text = o.Name;
            //   lblMobileV.Text = mMobile;
            //txtAddress.Text = o.Address;
            //txtTelephone.Text = o.Telephone;

            cmbSex.SelectedIndex = 0;
            cmbIsMarryed.SelectedIndex = 0;
            SetTButtonPng(toolStrip1);

            if (IsSelect)
                tbtnSave.Text = "保存并选择";
        }



        private Customer AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;


            Customer entity = FrmAssist.PopulateEntityFromCollection<Customer>(null, lstPairs);
            return entity;
        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {


        }


        private void InitDataByModel(Customer obj)
        {
            // lblMobileV.Text = obj.Mobile;
            //txtMobile.Text = obj.Mobile;
            //txtCustName.Text = obj.CustName;
            //cmbSex.Text = obj.Sex;
            //txtTelephone.Text = obj.Telephone;
            //txtAddress.Text = obj.Address;
            //txtIdentityCard.Text = obj.IdentityCard;
            //cmbJob.Text = obj.Job;
            //cmbIsMarryed.Text = obj.IsMarryed;
            //cmbAgeScope.Text = obj.AgeScope;
            //cmbEducation.Text = obj.Education;
            //txtQQ.Text = obj.QQ;
            //txtWx.Text = obj.Wx;
            //txtEmail.Text = obj.Email;
            txtMobile.ReadOnly = true;
            AssginModelToControl<Customer>(obj);

        }

        private void tbtnSave_Click_1(object sender, EventArgs e)
        {
            Customer obj = AssginToModel();




            if (obj != null)
            {
                if (string.IsNullOrEmpty(mMobile))
                {
                    if (mIcustomer.IsCustomerExists(txtMobile.Text))
                    {

                        MessageBox.Show("已存在该手机号");
                        if (IsSelect)
                        {
                            if (m_del != null)
                            {
                                m_del(txtMobile.Text);
                                this.Close();
                            }
                        }
                        return;
                    }

                }
                // obj.Mobile = lblMobileV.Text;
                mIcustomer.UpdateBaseCustomerInfo(obj);
                IsModify = true;
                if (IsSelect)
                {
                    if (m_del != null)
                        m_del(txtMobile.Text);
                    this.Close();

                }
                else
                    ShowMessage("保存成功");

            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mMobile))
            {
                if (mIcustomer.IsCustomerExists(txtMobile.Text))
                {

                    MessageBox.Show("已存在该手机号");
                    if (IsSelect)
                    {
                        if (m_del != null)
                        {
                            m_del(txtMobile.Text);
                            this.Close();
                        }
                    }

                }

            }
        }





        //private void tbtnSel_Click(object sender, EventArgs e)
        //{
        //    frmCustomerQuery frm = new frmCustomerQuery();
        //    frm.setTransferDelegate(delegate(object o)
        //    {
        //        string strbh = (string)o;
        //        Customer obj=mIcustomer.GetCustomerByMobile(strbh);
        //        InitDataByModel(obj);

        //    });
        //    frm.ShowDialogEx();
        //}
    }
}
