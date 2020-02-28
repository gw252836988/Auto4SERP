using System;
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
using Auto4SErp.Sale;
using Auto4SErp.Repair;
using Bll.Repair;
namespace Auto4SErp
{
    public partial class frmAccount : ifrmBase
    {
        private List<SqlElement> mLstE;
        private IFinance mIFinance;
        private IRepair mIRepair;
        //  private DataTable mDtDicOfCustomer = null;
        //   private DataTable mDtDicOfAccount = null;
        //   private bool mIsOut = false;
        public frmAccount()
        {
            InitializeComponent();
            mIFinance = BllFactory.GetFinanceBll();
            mIRepair = BllFactory.GetRepariBll();
            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
            //this.DoubleBuffered = true;
        }

        protected override void DoQuery()
        {
            DataTable dt;
            string strBegin = "";
            string strEnd = "";
            int datetype = 0;
            int tmpRecordCount;
            int tmpPageCount;
            //if (chbIsDate.Checked)
            //{
            //    strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            //    strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            //}

            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            datetype = cmbDateType.SelectedIndex;

            //if (mLstE != null)
            //{
            //    if (mLstE.Count > 0)
            //    {
            dt = mIFinance.GetAccounts(strBegin, strEnd, mLstE, datetype, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();
            DataToControl(dt);
            //        return;
            //    }
            //}


            //   DataToControl(mIFinance.GetAccounts(strBegin, strEnd, null, datetype));

        }

        private void DataToControl(DataTable dt)
        {

            //FrmAssist.UpdateColumns(ref mDtDicOfCustomer, dt, 2);
            //FrmAssist.UpdateColumns(ref mDtDicOfAccount, dt,10);


            dgAccount.AutoGenerateColumns = false;
            dgAccount.DataSource = dt;
            dgAccount.Columns[0].Visible = false;


        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

            mLstControls.Add(txtCustName);
            mLstControls.Add(txtMobile);
            mLstControls.Add(txtDHFrom);
            mLstControls.Add(cmbDescribes);
            mLstControls.Add(txtPlate);
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            //mLstE = new List<SqlElement>();
            //mLstE.Add(new SqlElement(){Name="Status",Value="0",IsFuzzy=false,IsStr=false});

            cmbDateType.SelectedIndex = 0;
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();
            SetTButtonPng(toolStrip1);
        }

        private void tbtbAccept_Click(object sender, EventArgs e)
        {

            if (dgAccount.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgAccount.SelectedRows[0];
                string dhfrom;

                dhfrom = seldr.Cells[8].Value.ToString().Trim();

                if (seldr.Cells[5].Value.ToString() == "售后")
                {
                    RepairM repobj = mIRepair.GetRepairByDH(dhfrom);
                    if (repobj.RepChildType == "索赔" || repobj.RepChildType == "免费保养")
                    {
                        frmRepair frm1 = new frmRepair();
                        frm1.DH = seldr.Cells["DHFrom"].Value.ToString().Trim();
                        frm1.FinanceID = int.Parse(seldr.Cells[0].Value.ToString());
                        frm1.setRefreshDelegate(delegate(bool IsR)
                        {
                            if (IsR)
                                DoQuery();

                        });
                        frm1.ShowDialogEx();
                        return;
                    }
                }

                frmAccountAccept frm = new frmAccountAccept();
                if (seldr.Cells[5].Value.ToString() == "赊销回款")
                    frm.IsSC = true;
                frm.ID = int.Parse(seldr.Cells[0].Value.ToString());
                frm.Mobile = seldr.Cells[3].Value.ToString();
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                        DoQuery();

                });
                frm.ShowDialogEx();


            }

        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DoQuery();

        }

        private void chbIsDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAllNoAccept_Click(object sender, EventArgs e)
        {

        }

        private void tbtnAllNoAccept_Click(object sender, EventArgs e)
        {
            cmbDateType.SelectedIndex = 0;
            mLstE = new List<SqlElement>();
            mLstE.Add(new SqlElement() { Name = "Status", Value = "0", IsFuzzy = false, IsStr = false });
            DoQuery();
        }

        private void tbtnRefund_Click(object sender, EventArgs e)
        {

        }

        private void tbtnBack_Click(object sender, EventArgs e)
        {
            if (dgAccount.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgAccount.SelectedRows[0];
                string describe = seldr.Cells["Describes"].Value.ToString();
                string dh = seldr.Cells["DHFrom"].Value.ToString().Trim();
                string info = "";
                // string status = seldr.Cells[8].Value.ToString();
                //if (status != "已收款")
                //{
                //    ShowMessage("未收款无法退款");
                //    return;


                //}
                if ((info = mIFinance.IsCanRefund(describe, dh, int.Parse(seldr.Cells[0].Value.ToString()))) != "")
                {
                    ShowMessage(info);
                    return;

                }

                frmRefund frm = new frmRefund();
                frm.ID = int.Parse(seldr.Cells[0].Value.ToString());
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    DoQuery();

                });
                frm.ShowDialogEx();


            }
        }

        private void btnPreRecv_Click(object sender, EventArgs e)
        {
            frmDlgPreRecv frm = new frmDlgPreRecv();

            frm.ShowDialogEx();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dgAccount.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgAccount.SelectedRows[0];
                // string describe = seldr.Cells[4].Value.ToString();
                string dh = seldr.Cells["DHFrom"].Value.ToString().Trim();
                string describe = seldr.Cells["Describes"].Value.ToString();
                if (describe == "销售收款")
                {
                    frmCarSale frm = new frmCarSale();
                    frm.DH = dh;
                    frm.ShowDialogEx();
                }
                else if (describe == "整车调拨")
                {
                    frmCarAllot frm = new frmCarAllot();
                    frm.DH = dh;
                    frm.ShowDialogEx();

                }
                else
                {
                    frmRepair frm = new frmRepair();
                    frm.DH = dh;
                    frm.ShowDialogEx();
                }
            }
        }

        private void dgAccount_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            string strBegin = "";
            string strEnd = "";
            int datetype = 0;

            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            datetype = cmbDateType.SelectedIndex;
            mLstE = CreateMedialSqlElement(AssginToListOfQuery());
            DataTable dt = mIFinance.GetOutToAccounts(strBegin, strEnd, mLstE, datetype);
            Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
            io.DTOutTo(dt, dgAccount);
        }

        private void repairBack_Click(object sender, EventArgs e)
        {

        }

        private void orderBack_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void tnbtBack_Click(object sender, EventArgs e)
        {

            //   if (Comm.LoginInfoShare.getInstance().UserId != "admin") return;

            if (dgAccount.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgAccount.SelectedRows[0];
                string describe = seldr.Cells["Describes"].Value.ToString();
                string dh = seldr.Cells["DHFrom"].Value.ToString().Trim();
                string info = "";

                //判断是否能退款
                if ((info = mIFinance.IsCanRefund(describe, dh, int.Parse(seldr.Cells[0].Value.ToString()))) != "")
                {
                    ShowMessage(info);
                    return;

                }

                frmRefund frm = new frmRefund();
                frm.ID = int.Parse(seldr.Cells[0].Value.ToString());
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    DoQuery();

                });
                frm.ShowDialogEx();


            }
        }

        private void btnReAccount_Click(object sender, EventArgs e)
        {
            if (dgAccount.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgAccount.SelectedRows[0];
                string describe = seldr.Cells["Describes"].Value.ToString();
                string dh = seldr.Cells["DHFrom"].Value.ToString().Trim();

                frmDlgPriceInOfTake frm = new frmDlgPriceInOfTake();
                frm.setTransferDelegate((r) => repairReAccount((double)r, dh));
                frm.ShowDialogEx();

            }

        }

        private void repairReAccount(double account, string dh)
        {

            mIRepair.ReAccount(account, dh);
            DoQuery();

        }
    }
}
