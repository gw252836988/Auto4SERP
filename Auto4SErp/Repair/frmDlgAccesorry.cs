using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Comm;
using Model;
using Bll.Repair;
namespace Auto4SErp.Repair
{
    public partial class frmDlgAccesorry : ifrmBase
    {
        private IAccessory mIAccessory;
        private string accesorryCode;
        private int status = 0;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public string AccesorryCode
        {
            get { return accesorryCode; }
            set { accesorryCode = value; }
        }

        public frmDlgAccesorry()
        {
            mIAccessory = Bll.BllFactory.GetAccessoryBll();
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Accessory obj = AssginToModel();
            if (obj != null)
            {
                if (status == 0)
                {
                    if (!mIAccessory.AddAccessory(obj))
                    {
                        ShowMessage("已存在该配件，不能重复录入");
                        return;

                    }
                }
                else
                {
                    mIAccessory.UpdateAccessory(obj);

                }
                IsModify = true;
                this.Close();
            }
        }



        private Accessory AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;


            Accessory entity = FrmAssist.PopulateEntityFromCollection<Accessory>(null, lstPairs);
            return entity;
        }
        private void frmDlgAccesorry_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtAccessoryCode);
            mLstControls.Add(txtAccessoryName);
            mLstControls.Add(txtChangeCode);
            mLstControls.Add(dbiIncreaseRate);
            mLstControls.Add(dbiSalePrice);
            mLstControls.Add(txtStorePlace);
            mLstControls.Add(cmbAccessoryType);
            mLstControls.Add(cmbApplicationModel);
            mLstControls.Add(cmbBrand);
            mLstControls.Add(cmbUnit);
            mLstControls.Add(txtSmallType);
            SetTButtonPng(toolStrip1);
            LoadExtendContents("配件类型", cmbAccessoryType);

            if (status == 1)
            {
                Accessory obj = mIAccessory.GetAccessoryByCode(accesorryCode);
                AssginModelToControl<Accessory>(obj);
                txtAccessoryCode.ReadOnly = true;
                if (obj.IsEnabled == 0)
                    btnEnabled.Text = "停用";
                else
                    btnEnabled.Text = "启用";
            }

        }

        private void btnEnabled_Click(object sender, EventArgs e)
        {
            mIAccessory.UpdateAccessoryEnabled(txtAccessoryCode.Text);
            if (btnEnabled.Text == "停用")
                btnEnabled.Text = "启用";
            else
                btnEnabled.Text = "停用";
            IsModify = true;
        }
    }
}
