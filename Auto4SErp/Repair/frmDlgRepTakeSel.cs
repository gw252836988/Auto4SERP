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

using Model;
using Bll;
namespace Auto4SErp.Repair
{
    public partial class frmDlgRepTakeSel : ifrmBase
    {
        private IRepair mIRepair;
        private bool isClaim;
        private IRepairAccessory mIRepairAccessory;
        public bool IsClaim
        {
            get { return isClaim; }
            set { isClaim = value; }
        }
        public frmDlgRepTakeSel()
        {
            InitializeComponent();
            mIRepair = BllFactory.GetRepariBll();
            mIRepairAccessory = BllFactory.GetRepairAccessoryBll();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RefreshRepair();
        }

        private void RefreshRepair()
        {

            if (chbClaim.Checked)
            {
                dgRepair.DataSource = mIRepair.GetRepsOfClaim();
                return;
            }
            if (!chbSale.Checked)
                dgRepair.DataSource = mIRepair.GetRepsOfTake(txtPlateNum.Text, txtDH.Text, txtVin.Text, txtCustName.Text, 0);
            else
                dgRepair.DataSource = mIRepair.GetRepsOfTake(txtPlateNum.Text, txtDH.Text, txtVin.Text, txtCustName.Text, 1);

        }

        private void txtPlateNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                RefreshRepair();

            }
        }

        private void txtDH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                RefreshRepair();

            }
        }

        private void dgRepair_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRepair.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgRepair.SelectedRows[0];
                string dh;
                if (chbClaim.Checked)
                    dh = seldr.Cells[1].Value.ToString();
                else
                    dh = seldr.Cells[0].Value.ToString();
                if (m_del != null)
                    m_del(dh);
                this.Close();
            }
        }

        private void frmDlgRepTakeSel_Load(object sender, EventArgs e)
        {
            if (isClaim)
            {
                chbClaim.Checked = true;

            }
            RefreshRepair();
        }

        private void chbSale_CheckValueChanged(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click_1(object sender, EventArgs e)
        {
            RefreshRepair();
        }

        private void dgRepair_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRepair.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgRepair.SelectedRows[0];
                string dh;
                if (chbClaim.Checked)
                    dh = seldr.Cells[1].Value.ToString();
                else
                    dh = seldr.Cells[0].Value.ToString();
                //if (m_del != null)
                //    m_del(dh);
                //this.Close();
                dgAccessory.AutoGenerateColumns = false;
                dgAccessory.DataSource = mIRepairAccessory.GetAccessorysOfRepairAsRep(dh);
            }
        }
    }
}
