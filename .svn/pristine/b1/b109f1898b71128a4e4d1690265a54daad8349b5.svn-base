using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using OutLookBarDemo;
namespace Auto4SErp
{
    public partial class frmLeft :ifrmBase
    {

        private List<string> funCollection=null;

        public List<string> FunCollection
        {
          //  get { return funCollection; }
            set { funCollection = value; }
        }


        private IconPanel iconPanel1;
        private IconPanel iconPanel2;
        private IconPanel iconPanel3;
        public frmLeft()
        {
            InitializeComponent();
            #region 初始化 OutLookBar
            outlookBar.BorderStyle = BorderStyle.FixedSingle;
            outlookBar.Initialize();
            iconPanel1 = new IconPanel();
            iconPanel2 = new IconPanel();
            iconPanel3 = new IconPanel();

            outlookBar.AddBand("销售", iconPanel1);
            outlookBar.AddBand("售后", iconPanel2);
            outlookBar.AddBand("财务", iconPanel3);

            iconPanel1.AddIcon("销售订单", Image.FromFile(@"img\RepRecept.png"), new EventHandler(PanelEventA), "S_CarOrderQuery_0,010301");
            //1
            iconPanel1.AddIcon("整车销售", Image.FromFile(@"img\RepRecept.png"), new EventHandler(PanelEventA), "S_CarSaleQuery_0,010302");
            //2
            iconPanel2.AddIcon("维修接车", Image.FromFile(@"img\RepRecept.png"), new EventHandler(PanelEventA), "R_RepRecept_0,0201");
            //3
            iconPanel2.AddIcon("维修领料", Image.FromFile(@"img\RepRecept.png"), new EventHandler(PanelEventA), "R_TakeAcc_0,020202");
            //4
            iconPanel3.AddIcon("财务收款", Image.FromFile(@"img\RepRecept.png"), new EventHandler(PanelEventA), "M_Account_0,0601  ");
            outlookBar.SelectBand(0);
            #endregion

        }


        private void ValidateIsEnable(IconPanel panel)
        {
            foreach (Control c in panel.Controls)
            {
                PanelIcon tmpc = c as PanelIcon;
                if (tmpc != null)
                {
                    string[] strlst = tmpc.FunName.Split(',');
                     if (funCollection.Contains(strlst[1]))
                        tmpc.Enabled = true;
                    else
                        tmpc.Enabled = false;
                }


            }

        }

        public void EnableButtons()
        {
            if (funCollection.Count > 0)
            {
                ValidateIsEnable(iconPanel1);
                ValidateIsEnable(iconPanel2);
                ValidateIsEnable(iconPanel3);
            }

        }

        public void PanelEventA(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            PanelIcon panelIcon = ctrl.Tag as PanelIcon;
            string clickInfo = string.Empty;


            string[] strlst = panelIcon.FunName.Split(',');
            if (m_del != null)
                m_del(strlst[0]);
            //switch (panelIcon.Index)
            //{
            //    case 0:
            //        clickInfo = "信息查询";
            //        break;
            //    case 1:
            //        clickInfo = "购物车管理";
            //        break;
            //}
          //  this.label1.Text = string.Format("您选择了 {0}", clickInfo);
        }

        //public void PanelEventB(object sender, EventArgs e)
        //{
        //    Control ctrl = (Control)sender;
        //    PanelIcon panelIcon = ctrl.Tag as PanelIcon;
        //    string clickInfo = string.Empty;

        //    switch (panelIcon.Index)
        //    {
        //        case 0:
        //            clickInfo = "电子邮件";
        //            break;
        //        case 1:
        //            clickInfo = "密码管理";
        //            break;
        //    }
        //   // this.label1.Text = string.Format("您选择了 {0}", clickInfo);
        //}

        //public void PanelEventC(object sender, EventArgs e)
        //{
        //    Control ctrl = (Control)sender;
        //    PanelIcon panelIcon = ctrl.Tag as PanelIcon;
        //    string clickInfo = string.Empty;
        //    switch (panelIcon.Index)
        //    {
        //        case 0:
        //            clickInfo = "时间设置";
        //            break;
        //    }
           // this.label1.Text = string.Format("您选择了 {0}", clickInfo);
        //}
    }
}
