using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.P2P;
using Bll;
using Model;
using System.Collections;
namespace Auto4SErp
{
    public partial class frmTestWeb : Form
    {
        public frmTestWeb()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            P2PGetUserInfoTask task = new P2PGetUserInfoTask();
            Hashtable ht = new Hashtable();
            ht.Add("phone", "13962852128");
            ht.Add("callBack", "doit");
            task.HtPara = ht;
            task.ECompelete += new WebTask.CompeleteDelegate(OnComplete);
            task.StartTaskSingle();
        }

        private void OnComplete(object o)
        {
            P2PUserInfo obj = (P2PUserInfo)o;


        }
    }
}
