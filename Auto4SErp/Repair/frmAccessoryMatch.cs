using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comm;
using Bll.Repair;
using Bll;
namespace Auto4SErp.Repair
{
    public partial class frmAccessoryMatch : ifrmBase
    {

        private List<string> mLstAccCode;
        private string[] mLstBK = { "101", "301" };
        private string[] mLstXFL = { "153", "205" };
        private IAccessoryMatchBll mIAccessoryMatchBll;
        public frmAccessoryMatch()
        {
            InitializeComponent();
            mLstAccCode = new List<string>();
            mIAccessoryMatchBll = BllFactory.GetAccessoryMatchBll();

        }

        private void frmAccessoryMatch_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
        }

        private void btnOPen_Click(object sender, EventArgs e)
        {
            if (opdIn.ShowDialog() == DialogResult.OK)
            {

                string path = opdIn.FileName;
                ExcelInAndOut inO = new ExcelInAndOut(path);
                try
                {
                    DataTable dt = inO.InDataToDT();
                    DtToList(dt);
                    lblstatus.Text = "文件已装载";
                }
                catch (Exception ex)
                {
                    ShowMessage(ex.Message.ToString());
                    return;
                }


            }
        }


        private void DtToList(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                mLstAccCode.Add(dt.Rows[i][0].ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataTable dtResult = new DataTable();
            if (chbBK.Checked)
            {
                foreach (string str in mLstBK)
                {
                    mIAccessoryMatchBll.SetDBByOrgan(str);
                    DataTable dt = mIAccessoryMatchBll.GetAccsByList(mLstAccCode, igiDays.Value);
                    dtResult.Merge(dt);

                }

            }

            if (chbXFL.Checked)
            {
                foreach (string str in mLstXFL)
                {
                    mIAccessoryMatchBll.SetDBByOrgan(str);
                    DataTable dt = mIAccessoryMatchBll.GetAccsByList(mLstAccCode, igiDays.Value);
                    dtResult.Merge(dt);

                }

            }


            if (chbHM.Checked)
            {
                mIAccessoryMatchBll.SetDBByOrgan("201");
                DataTable dt = mIAccessoryMatchBll.GetAccsByList(mLstAccCode, igiDays.Value);
                dtResult.Merge(dt);
            }
            dgAccessory.DataSource = dtResult;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut i = new ExcelInAndOut("");
            i.NewDTOutTo(dgAccessory);
        }
    }
}
