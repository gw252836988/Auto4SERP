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
namespace Auto4SErp
{
    public partial class frmCustomerEdit : ifrmBase
    {
        private ICustomer mIcustomer;
        private string mMobile;

        private bool isAdd;

        public bool IsAdd
        {
            get { return isAdd; }
            set { isAdd = value; }
        }



        public string Mobile
        {

            set { mMobile = value; }
        }

        public frmCustomerEdit()
        {
            InitializeComponent();
           
        }


        protected override void ShowError(string controlname, string infotext)
        {
            this.errorProvider1.SetError(FindCountrolByName(controlname), infotext);

        }

        protected override void RemoveError(string controlname)
        {
            this.errorProvider1.SetError(FindCountrolByName(controlname), null);

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
           
         

            Customer o = new Customer();
            o.Mobile = lblMobileV.Text;
            o.CustName = txtCustName.Text;
            o.Sex = cmbSex.Text;
            o.Address = txtAddress.Text;
            o.Telephone = txtTelephone.Text; 
            mIcustomer.UpdateBaseCustomerInfo(o);
        }

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {
            mIcustomer = BllFactory.GetCustomerBll();
          
            //Customer o = mIcustomer.GetCustomerByMobile("123");
            ////
            //txtCustName.Text = o.Name;
             lblMobileV.Text = mMobile;
            //txtAddress.Text = o.Address;
            //txtTelephone.Text = o.Telephone;

            cmbSex.SelectedIndex = 0;
            cmbIsMarryed.SelectedIndex = 0;
            
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



        private Customer AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;


            Customer entity = FrmAssist.PopulateEntityFromCollection<Customer>(null, lstPairs);
            return entity;
        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {

           Customer obj= AssginToModel();
            
           if (obj != null)
           {
               obj.Mobile = lblMobileV.Text;
               mIcustomer.UpdateBaseCustomerInfo(obj);

           }
        }


        private void InitDataByModel(Customer obj)
        {
            lblMobileV.Text = obj.Mobile;
            txtCustName.Text = obj.CustName;
            cmbSex.Text = obj.Sex;
            txtTelephone.Text = obj.Telephone;
            txtAddress.Text = obj.Address;
            txtIdentityCard.Text = obj.IdentityCard;
            cmbJob.Text = obj.Job;
            cmbIsMarryed.Text = obj.IsMarryed;
            cmbAgeScope.Text = obj.AgeScope;
            cmbEducation.Text = obj.Education;
            txtQQ.Text = obj.QQ;
            txtWx.Text = obj.Wx;
            txtEmail.Text = obj.Email;

        }
    }
}
