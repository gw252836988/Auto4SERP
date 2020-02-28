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
using Comm;
namespace Auto4SErp
{
    public partial class frmDlgCustomerQuery : ifrmBase
    {
        public frmDlgCustomerQuery()
        {
            InitializeComponent();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            List<Pair> lst = AssginToListOfQuery();

            List<SqlElement> lstE=CreateMedialSqlElement(lst);

            string str=CreateSqlUtil.CreateQuerySqlOfCondition(lstE,true);

        }

        private void frmDlgCustomerQuery_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtCustName);
            mLstControls.Add(txtBH);
            mLstControls.Add(txtMobile);
        }

      
    }
}
