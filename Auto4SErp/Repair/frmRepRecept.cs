using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll.Repair;
using Auto4SErp.Cust;
using Model;
using Bll;
using Comm;
namespace Auto4SErp.Repair
{
    public partial class frmRepRecept : ifrmBase
    {
        private IRepair mIRepair;
        private ICustomer mICustomer;
        private IVip mIVip;
        private List<SqlElement> mLstE = null;

        private bool isQuery = false;
        //private DataTable mDtDicOfRepair;
        //private DataTable mDtDicOfCustomer;
        public frmRepRecept()
        {
            mIRepair = Bll.BllFactory.GetRepariBll();
            mIVip = Bll.BllFactory.GetVipBll();
            InitializeComponent();
            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void frmRepRecept_Load(object sender, EventArgs e)
        {
            mICustomer = BllFactory.GetCustomerBll();
            DoQuery();
            SetTButtonPng(toolStrip1);
        }



        protected override void DoQuery()
        {

            int tmpRecordCount;
            int tmpPageCount;
            DataTable dt;
            if (isQuery == false)
                dt = mIRepair.GetRepairs(mLstE, LoginInfoShare.getInstance().UserName, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            else
                dt = mIRepair.GetRepairs(mLstE, "", mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            //FrmAssist.UpdateColumns(ref mDtDicOfRepair, dt, 15);
            //FrmAssist.UpdateColumns(ref mDtDicOfCustomer, dt, 2);
            dgRepair.AutoGenerateColumns = false;
            dgRepair.DataSource = dt;
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();

        }


        private void btnCustomerFind_Click(object sender, EventArgs e)
        {
            frmCustomerQuery frm = new frmCustomerQuery();
            frm.IsSelect = true;
            frm.IsRepair = true;
            string mobile = "";
            string plate = "";
            frm.setTransferDelegate(delegate(object o)
            {
                string strResult = (string)o;
                string[] strlst = strResult.Split(',');
                mobile = strlst[0];
                plate = strlst[1];

            });
            frm.ShowDialogEx();
            if (!string.IsNullOrEmpty(mobile))
            {
                AssinByMobile(mobile);
                if (string.IsNullOrEmpty(plate))
                {
                    txtPlateNum.Text = "";
                    txtVin.Text = "";
                    txtCarBrand.Text = "";
                    txtCarModel.Text = "";
                    txtColor.Text = "";
                }
                AssinByPlate(plate, false);
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                // AssinByMobile(txtMobile.Text);
                GetPlatesByMobile(txtMobile.Text);
            }
        }
        private void GetPlatesByMobile(string mobile)
        {
            DataTable dt = mIRepair.GetPlatesByMobile(mobile);
            if (dt.Rows.Count > 1)
            {
                cmbPlateSel.Visible = true;
                cmbPlateSel.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {

                    cmbPlateSel.Items.Add(dr[0].ToString());
                    //  cmbPlateSel.SelectedIndex = 0;
                }

            }
            else if (dt.Rows.Count == 1)
            {
                AssinByPlate(dt.Rows[0][0].ToString(), false);
            }



        }


        private void AssinByMobile(string mobile)
        {
            Customer objcust = mICustomer.GetCustomerByMobile(mobile);
            if (objcust != null)
            {
                txtCustName.Text = objcust.CustName;
                txtAddress.Text = objcust.Address;
                txtMobile.Text = objcust.Mobile;

                string cardno = objcust.CardNo;
                if (cardno != null && cardno.Length > 1)
                {
                    VipInfo info = mIVip.GetVipInfoByCardID(cardno);
                    if (info != null)
                    {
                        lblBalance.Text = "余额:" + info.Balance;
                        lblIntegral.Text = "积分:" + info.Integral;
                        lblVipType.Text = "会员类型:" + info.MemberLevel;
                        txtVip.Text = cardno;
                    }

                }
            }

        }


        private void AssinByPlate(string plate, bool flag)
        {
            Car objcar = null;
            if (!string.IsNullOrEmpty(plate) && (objcar = mICustomer.GetCarByPlate(plate)) != null)
            {
                txtPlateNum.Text = objcar.PlateNum;
                txtVin.Text = objcar.Vin;
                txtCarBrand.Text = objcar.CarBrand;
                txtCarModel.Text = objcar.CarModel;
                txtColor.Text = objcar.CarColor;
                if (flag)
                    AssinByMobile(objcar.Mobile);
                dgHistory.DataSource = mIRepair.GetRepairsByPlate(txtPlateNum.Text);

            }
            else
            {
                if (ShowMessageOfWarning("没有车牌号，是否添加？") == DialogResult.OK)
                {
                    frmRepCustomerEdit frm = new frmRepCustomerEdit();
                    frm.PlateNum = txtPlateNum.Text;
                    frm.Mobile = txtMobile.Text;
                    frm.setTransferDelegate(d =>
                        {
                            string strResult = (string)d;
                            string[] strlst = strResult.Split(',');
                            //  string mobile = strlst[0];
                            //string plate = strlst[1];
                            AssinByMobile(strlst[0]);
                            AssinByPlate(strlst[1], false);
                        });
                    frm.ShowDialogEx();
                }
            }


        }

        private void txtPlateNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (txtPlateNum.Text.Length >= 4)
                    AssinByPlate(txtPlateNum.Text, true);
                else
                    ShowMessage("输入车牌号必须大于3位");

            }
        }

        private void btnRecept_Click(object sender, EventArgs e)
        {
            frmRepair frm = new frmRepair();
            frm.MobileAndPlate = txtMobile.Text + "," + txtPlateNum.Text;
            frm.setRefreshDelegate(delegate(bool isR)
            {
                DoQuery();
            });
            frm.ShowDialog();

        }

        private void txtVip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {

                // AssinByPlate(txtPlateNum.Text);

                string cardno = txtVip.Text;
                Customer obj = mICustomer.GetCustomerByCardNo(cardno);
                if (obj != null)
                {
                    GetPlatesByMobile(obj.Mobile);

                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgRepair.SelectedRows.Count != 0)
            {
                frmRepair frm = new frmRepair();
                DataGridViewRow seldr = dgRepair.SelectedRows[0];
                string strdh = seldr.Cells[1].Value.ToString();
                frm.DH = strdh;
                frm.setRefreshDelegate(r => { if (r)DoQuery(); });

                frm.Show();

            }
        }

        private void cmbPlateSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssinByPlate(cmbPlateSel.Text, false);
            cmbPlateSel.Visible = false;
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            frmRepCustomerEdit frm = new frmRepCustomerEdit();
            if (!string.IsNullOrEmpty(txtPlateNum.Text))
                frm.PlateNum = txtPlateNum.Text;
            frm.Mobile = txtMobile.Text;
            frm.setTransferDelegate(d => DoResultByTransferData(d));
            frm.ShowDialogEx();
        }


        private void DoResultByTransferData(object o)
        {
            string strResult = (string)o;
            string[] strlst = strResult.Split(',');
            string mobile = strlst[0];
            string plate = strlst[1];
            AssinByMobile(mobile);
            AssinByPlate(plate, false);

        }


        private void QueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDlgRepRecept frm = new frmDlgRepRecept();
            frm.setTransferDelegate(delegate(object o)
            {
                mLstE = (List<SqlElement>)o;
                isQuery = true;
                DoQuery();
            });
            frm.ShowDialogEx();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (dgHistory.SelectedRows.Count != 0)
            {
                frmRepair frm = new frmRepair();
                DataGridViewRow seldr = dgHistory.SelectedRows[0];
                string strdh = seldr.Cells[1].Value.ToString();
                frm.DH = strdh;
                frm.setRefreshDelegate(r => { if (r)DoQuery(); });

                frm.Show();

            }
        }

        private void btnCarEdit_Click(object sender, EventArgs e)
        {
            frmRepCustomerEdit frm = new frmRepCustomerEdit();
            if (!string.IsNullOrEmpty(txtPlateNum.Text))
                frm.PlateNum = txtPlateNum.Text;
            frm.Mobile = txtMobile.Text;
            frm.setTransferDelegate(d => DoResultByTransferData(d));
            frm.ShowDialogEx();
        }

        private void dgRepair_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }


    }
}
