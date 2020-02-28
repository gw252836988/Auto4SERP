using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto4SErp
{
    public partial class frmDlgExtendcontent : ifrmBase
    {
        private int extendcontentid = 0;
        private int extendtypeid = 0;

        public int Extendtypeid
        {
            get { return extendtypeid; }
            set { extendtypeid = value; }
        }



        public int Extendcontentid
        {
            get { return extendcontentid; }
            set { extendcontentid = value; }
        }
        private IExtend mIExtend = BllFactory.GetExtendBll();
        public frmDlgExtendcontent()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void BindExtendType()
        {
            DataTable dt = mIExtend.GetExtendtypes();
            this.cmbType.Items.Clear();
            this.cmbType.DisplayMember = "extendname";
            this.cmbType.ValueMember = "id";
            this.cmbType.DataSource = dt;

        }


        private void frmDlgExtendcontent_Load(object sender, EventArgs e)
        {
            BindExtendType();
            if (extendtypeid > 0)
            {
                this.cmbType.SelectedValue = extendtypeid;
                this.txtContent.Focus();
            }


            if (extendcontentid > 0)
            {
                DataTable dt = mIExtend.GetExtendcontent(extendcontentid);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    this.cmbType.SelectedValue = dr["typeid"];
                    this.txtContent.Text = dr["content"].ToString();
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int typeid = Convert.ToInt32(this.cmbType.SelectedValue);
            string content = this.txtContent.Text.Trim();

            if (content != "")
            {
                bool result = false;
                if (extendcontentid > 0)
                {
                    result = mIExtend.UpdateExtendcontent(content, typeid, extendcontentid);
                    this.Close();
                }
                else
                {
                    result = mIExtend.AddExtendcontent(content, typeid);
                    txtContent.Text = "";
                }
                if (result)
                {
                    IsModify = true;

                }
            }
        }


    }
}
