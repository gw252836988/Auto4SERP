﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using System.Collections;
using Model;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using System.Reflection;

using Comm;
using Bll.Personnel;
namespace Auto4SErp
{

    public delegate void TransferDelegate(object obj);
    public delegate void RefreshDelegate(bool isRefresh);
    public delegate void TransferAnonymousObjDelegate(dynamic obj);

    public partial class ifrmBase : Form
    {


        private BackgroundWorker mBackWorker;
        protected TransferDelegate m_del;
        protected RefreshDelegate m_delRefresh;
        protected TransferAnonymousObjDelegate m_anyDel;
        protected bool IsModify = false;
        protected FrmAssist mFrmAssist;
        protected List<Control> mLstControls;
        protected List<ToolStripItem> mLstSenstiveTB;
        protected PageInfo mPageInfo = new PageInfo(50);

        protected ToolStripButton tsbNext = null;
        protected ToolStripButton tsbPre = null;
        protected ToolStripButton tsbFirst = null;
        protected ToolStripButton tsbLast = null;
        protected ToolStripTextBox tstbPageCurrent;
        protected ToolStripLabel tstbPageCount;
        protected ToolStripLabel tstbRecordCount;
        private bool isWindow = false;
        private IOrgan mIOrgan = BllFactory.GetOrganBll();


        public bool IsWindow
        {
            get { return isWindow; }
            set { isWindow = value; }
        }


        public ifrmBase()
        {
            InitializeComponent();

            mBackWorker = new BackgroundWorker();
            mBackWorker.DoWork += new DoWorkEventHandler(this.DoworkInBack);
            mBackWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.DoBackatCompleted);
            this.FormClosed += new FormClosedEventHandler(DoClose);

            mFrmAssist = new FrmAssist();
            mFrmAssist.EErrorInfo += new ErrorInfoDelegate(this.ShowError);
            mFrmAssist.EErrorRemove += new ErrorRemoveDelegate(this.RemoveError);
            mLstControls = new List<Control>();
            mLstSenstiveTB = new List<ToolStripItem>();
            this.BackColor = Color.White;

        }

        protected void CheckSPsOfStaff(string name)
        {
            if (mLstSenstiveTB.Count <= 0) return;
            ISenstive isens = BllFactory.GetSenstiveBll();
            //List<string> lstSen = isens.GetSPsOfStaff(Comm.LoginInfoShare.getInstance().UserId);
            string userid = Comm.LoginInfoShare.getInstance().UserId;
            List<string> lstSen = isens.GetSPsOfStaff(userid, name);



            foreach (ToolStripItem c in mLstSenstiveTB)
            {


                if (lstSen.Contains(c.Tag.ToString()) || userid == "admin")
                {
                    c.Enabled = true;

                }
                else
                {

                    c.Enabled = false;
                }

            }


        }


        protected virtual void ShowError(string controlname, string infotext)
        {
            GetErrorProvider().SetError(FindCountrolByName(controlname), infotext);

        }

        protected virtual void RemoveError(string controlname)
        {
            GetErrorProvider().SetError(FindCountrolByName(controlname), null);

        }

        public void setTransferDelegate(TransferDelegate del)
        {

            m_del = del;
        }
        public void setRefreshDelegate(RefreshDelegate del)
        {

            m_delRefresh = del;
        }

        public void setTransferAnyDelegate(TransferAnonymousObjDelegate del)
        {

            m_anyDel = del;
        }

        protected void DoClose(object sender, FormClosedEventArgs e)
        {
            if (m_delRefresh != null) m_delRefresh(IsModify);

            if (isWindow == true)
            {
                IWindowsState i = MainWindowState.getInstance().WayOfState;
                if (i != null)
                {
                    i.ToggleWindowVisible(this.Name);

                }
            }


        }

        protected virtual void DoworkInBack(object sender, DoWorkEventArgs e)
        {


        }

        protected void SetRoleNavigatorState()
        {
            if (mPageInfo.PageCount > 0)
            {


                if (mPageInfo.PageCurrent == 1)
                {
                    this.tsbFirst.Enabled = false;
                    this.tsbPre.Enabled = false;
                    this.tsbNext.Enabled = true;
                    this.tsbLast.Enabled = true;

                }
                else if (mPageInfo.PageCurrent == mPageInfo.PageCount)
                {
                    this.tsbFirst.Enabled = true;
                    this.tsbPre.Enabled = true;
                    this.tsbNext.Enabled = false;
                    this.tsbLast.Enabled = false;

                }
                else
                {
                    this.tsbFirst.Enabled = true;
                    this.tsbPre.Enabled = true;
                    this.tsbNext.Enabled = true;
                    this.tsbLast.Enabled = true;

                }
            }
            else if (mPageInfo.PageCount <= 1)
            {
                this.tsbFirst.Enabled = false;
                this.tsbPre.Enabled = false;
                this.tsbNext.Enabled = false;
                this.tsbLast.Enabled = false;


            }

            tstbPageCurrent.Text = mPageInfo.PageCurrent.ToString();
            tstbRecordCount.Text = mPageInfo.RecordCount.ToString();
            tstbPageCount.Text = "/ {" + mPageInfo.PageCount + "}";
        }

        protected virtual void DoBackatCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            UpdateUIAfterWork();

        }


        protected void StartWork(object argument)
        {

            // mBackWorker.RunWorkerAsync();
            mBackWorker.RunWorkerAsync(argument);
        }



        protected virtual void UpdateUIAfterWork()
        {


        }

        protected void LoadExtendContents(string typeName, ComboBox cmb)
        {
            IExtend iExtend = BllFactory.GetExtendBll();
            DataTable dtExtend = iExtend.GetExtendcontentByExtendtypeName(typeName);
            if (dtExtend.Rows.Count > 0)
            {
                cmb.Items.Clear();
                cmb.DisplayMember = "content";
                cmb.ValueMember = "id";
                cmb.DataSource = dtExtend;

            }

        }

        public DialogResult ShowDialogEx()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            return ShowDialog();
        }



        //protected Control FindCountrolByName(string strName)
        //{
        //    Control[] cs = this.Controls.Find(strName, true);

        //    if (cs.Length > 0) return cs[0];
        //    else
        //        return null;
        //}


        protected Control FindCountrolByName(string strName)
        {
            foreach (Control c in mLstControls)
            {
                if (c.Name.Substring(3) == strName)
                {
                    return c;

                }
            }
            return null;
        }


        protected virtual void RenewDate()
        {


        }



        protected void AssginModelToControl<T>(T entity)
        {
            Type type = typeof(T);
            //取得属性集合
            PropertyInfo[] pi = type.GetProperties();
            if (entity == null) return;
            foreach (PropertyInfo item in pi)
            {

                Control c = FindControlInLst(item.Name);
                if (c != null)
                {
                    if (c.Name.Substring(0, 3) == "dbi")
                    {
                        DoubleInput dbiC = c as DoubleInput;
                        object oValue = item.GetValue(entity, null);
                        dbiC.Value = double.Parse(oValue.ToString());
                        // dbiC.Value = (double)item.GetValue(entity);

                    }
                    else if (c.Name.Substring(0, 3) == "dti")
                    {
                        DateTimeInput dbiC = c as DateTimeInput;
                        dbiC.Value = (DateTime)item.GetValue(entity, null);
                    }
                    else
                    {
                        if (item.GetValue(entity, null) == null)
                            c.Text = "";
                        else
                            c.Text = item.GetValue(entity, null).ToString();
                    }

                }

            }

        }
        private Control FindControlInLst(string propertyName)
        {
            foreach (Control c in mLstControls)
            {
                if (c.Name.Contains(propertyName))
                    return c;


            }
            return null;

        }


        protected List<Pair> AssginToList()
        {
            List<Pair> lstPairs = new List<Pair>();
            foreach (Control c in mLstControls)
            {
                //   string str1=c.ToString();
                TextBoxX cTB = c as TextBoxX;
                if (cTB != null)
                {
                    string str = cTB.Name.Substring(3);
                    // HtValues.Add(str,cTB.Text + "_" +cTB.Tag);
                    lstPairs.Add(new Pair() { Key = str, Value = cTB.Text + "_" + cTB.Tag });

                }
                else
                {
                    ComboBoxEx cb = c as ComboBoxEx;
                    if (cb != null)
                    {
                        string str = cb.Name.Substring(3);
                        // HtValues.Add(str, cb.Text + "_" + cb.Tag);
                        lstPairs.Add(new Pair() { Key = str, Value = cb.Text + "_" + cb.Tag });

                    }

                    DoubleInput di = c as DoubleInput;
                    if (di != null)
                    {
                        string str = di.Name.Substring(3);
                        //  HtValues.Add(str, di.Value + "_" + di.Tag);
                        lstPairs.Add(new Pair() { Key = str, Value = di.Value + "_" + di.Tag });
                    }

                    DateTimeInput dti = c as DateTimeInput;
                    if (dti != null)
                    {
                        string str = dti.Name.Substring(3);
                        //  HtValues.Add(str, di.Value + "_" + di.Tag);
                        lstPairs.Add(new Pair() { Key = str, Value = dti.Value + "_" + dti.Tag });
                    }


                }



            }

            return lstPairs;

        }

        protected List<Pair> AssginToListOfQuery()
        {

            List<Pair> lstPairs = new List<Pair>();
            foreach (Control c in mLstControls)
            {
                //   string str1=c.ToString();
                TextBoxX cTB = c as TextBoxX;
                if (cTB != null)
                {
                    string str = cTB.Name.Substring(3);
                    // HtValues.Add(str,cTB.Text + "_" +cTB.Tag);
                    if (cTB.Text.Length > 0)
                        lstPairs.Add(new Pair() { Key = str, Value = cTB.Text + "_" + cTB.Tag });

                }
                else
                {
                    ComboBoxEx cb = c as ComboBoxEx;
                    if (cb != null)
                    {
                        string str = cb.Name.Substring(3);
                        // HtValues.Add(str, cb.Text + "_" + cb.Tag);
                        if (cb.Text.Length > 0)
                        {
                            if (cb.Tag.ToString().Substring(4, 2) == "B1")
                            {
                                lstPairs.Add(new Pair() { Key = str, Value = cb.SelectedIndex + "_" + cb.Tag });
                            }
                            else
                            {
                                lstPairs.Add(new Pair() { Key = str, Value = cb.Text + "_" + cb.Tag });
                            }
                        }

                    }

                    DoubleInput di = c as DoubleInput;
                    if (di != null)
                    {
                        string str = di.Name.Substring(3);
                        //  HtValues.Add(str, di.Value + "_" + di.Tag);
                        if (di.Value.ToString().Length > 0)
                            lstPairs.Add(new Pair() { Key = str, Value = di.Value.ToString() + "_" + di.Tag });
                    }

                }



            }

            return lstPairs;


        }

        protected List<SqlElement> CreateMedialSqlElement(List<Pair> lst)
        {
            List<SqlElement> lstE = new List<SqlElement>();
            foreach (Pair p in lst)
            {
                SqlElement e = new SqlElement();

                string[] strlst = p.Value.Split('_');
                e.Name = p.Key;
                e.Value = strlst[0];
                if (strlst[1].Substring(0, 2) == "F1")
                    e.IsFuzzy = true;
                else
                    e.IsFuzzy = false;
                if (strlst[1].Substring(2, 2) == "S1")
                    e.IsStr = true;
                else
                    e.IsStr = false;
                lstE.Add(e);

            }
            return lstE;


        }

        protected void ShowMessage(string txt)
        {
            MessageBox.Show(txt, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        protected DialogResult ShowMessageOfWarning(string txt)
        {
            return MessageBox.Show(txt, "重要提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }

        protected ErrorProvider GetErrorProvider()
        {
            return this.eProvider;
        }

        protected void LoadOrgans(ComboTree cbt, bool isRemoveNow)
        {
            //DataTable dtRegion;
            //DataTable dtOrgan;
            string nowOrgan = LoginInfoShare.getInstance().OrganName;
            Bll.Personnel.IOrgan mIOrgan = BllFactory.GetOrganBll();
            //dtRegion = mIOrgan.GetRegions();
            //dtOrgan = mIOrgan.GetOrgans();
            List<Organ> lstAll = mIOrgan.GetAllOrgans();
            List<Model.Region> lstRegion = mIOrgan.GetListRegion();


            //string region = "";
            //for (int i = 0; i <= 6; i++)
            //{
            //    switch (i)
            //    {

            //        case 0:
            //            region = "集团";
            //            break;
            //        case 1:
            //            region = "永兴";
            //            break;
            //        case 2:
            //            region = "观音山";
            //            break;
            //        case 3:
            //            region = "如东";
            //            break;

            //        case 4:
            //            region = "海门";
            //            break;
            //        case 5:
            //            region = "盐城";
            //            break;
            //        case 6:
            //            region = "启东";
            //            break;
            //        default:
            //            break;
            //    }


            foreach (Model.Region r in lstRegion)
            {
                DevComponents.AdvTree.Node nd = new DevComponents.AdvTree.Node();

                nd.Text = r.RegionName;
                nd.Selectable = false;
                cbt.Nodes.Add(nd);

                //DataView dv = new DataView(dtOrgan);
                //dv.RowFilter = "regionID=" + dtRegion.Rows[i][0].ToString();
                //筛选机构


                IEnumerable<Organ> lstOrgan;
                lstOrgan = (from os in lstAll
                            where os.Region == r.RegionID
                            select os);


                foreach (Organ o in lstOrgan)
                {

                    DevComponents.AdvTree.Node nd_chi = new DevComponents.AdvTree.Node();
                    nd_chi.Text = o.OrganName;
                    nd_chi.DataKeyString = o.OrganId;
                    if (!isRemoveNow)
                        nd.Nodes.Add(nd_chi);
                    else
                    {
                        if (nowOrgan != o.OrganName)
                        {
                            nd.Nodes.Add(nd_chi);
                        }

                    }

                }

            }



        }

        protected void SetTButtonPng(ToolStrip toolstrip)
        {
            foreach (ToolStripItem item in toolstrip.Items)
            {
                string pngtag;
                if (item.Tag == null)
                    pngtag = "";
                else
                    pngtag = item.Tag.ToString();

                switch (pngtag)
                {
                    case "query":
                        item.Image = global::Auto4SErp.Properties.Resources.query;
                        break;
                    case "select":
                        item.Image = global::Auto4SErp.Properties.Resources.select;
                        break;
                    case "add":
                        item.Image = global::Auto4SErp.Properties.Resources.add;
                        break;
                    case "ok":
                        item.Image = global::Auto4SErp.Properties.Resources.ok;
                        break;
                    case "cancel":
                        item.Image = global::Auto4SErp.Properties.Resources.fcancel;
                        break;
                    case "save":
                        item.Image = global::Auto4SErp.Properties.Resources.save;
                        break;
                    case "in":
                        item.Image = global::Auto4SErp.Properties.Resources._in;
                        break;
                    case "out":
                        item.Image = global::Auto4SErp.Properties.Resources._out;
                        break;
                    case "open":
                        item.Image = global::Auto4SErp.Properties.Resources.open;
                        break;
                    case "print":
                        item.Image = global::Auto4SErp.Properties.Resources.print;
                        break;
                    case "instore":
                        item.Image = global::Auto4SErp.Properties.Resources.instore;
                        break;
                    case "check":
                        item.Image = global::Auto4SErp.Properties.Resources.check;
                        break;
                    case "uncheck":
                        item.Image = global::Auto4SErp.Properties.Resources.uncheck;
                        break;
                    case "delete":
                        item.Image = global::Auto4SErp.Properties.Resources.delete;
                        break;
                    case "modify":
                        item.Image = global::Auto4SErp.Properties.Resources.modify;
                        break;
                    case "back":
                        item.Image = global::Auto4SErp.Properties.Resources.back;
                        break;
                    default:
                        break;



                }


            }



        }

        private void ifrmBase_Load(object sender, EventArgs e)
        {

            if (tstbPageCurrent != null && tstbPageCount != null)
            {
                mPageInfo.PageCurrent = 1;
                tstbPageCurrent.Enabled = true;
                tstbPageCount.Enabled = true;
            }

            if (tsbFirst != null)
                this.tsbFirst.Click += new System.EventHandler(this.tsbFirst_Click);

            if (tsbLast != null)
                this.tsbLast.Click += new System.EventHandler(this.tsbLast_Click);

            if (tsbNext != null)
                this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);

            if (tsbPre != null)
                this.tsbPre.Click += new System.EventHandler(this.tsbPre_Click);
        }

        private void tsbFirst_Click(object sender, EventArgs e)
        {
            mPageInfo.PageCurrent = 1;
            DoQuery();
        }

        private void tsbLast_Click(object sender, EventArgs e)
        {
            mPageInfo.PageCurrent = mPageInfo.PageCount;
            DoQuery();
        }


        private void tsbNext_Click(object sender, EventArgs e)
        {
            mPageInfo.PageCurrent = mPageInfo.PageCurrent + 1;
            if (mPageInfo.PageCurrent <= mPageInfo.PageCount)
                DoQuery();
            else
                mPageInfo.PageCurrent = mPageInfo.PageCurrent - 1;
        }

        private void tsbPre_Click(object sender, EventArgs e)
        {
            mPageInfo.PageCurrent = mPageInfo.PageCurrent - 1;
            if (mPageInfo.PageCurrent >= 1)
                DoQuery();
            else
                mPageInfo.PageCurrent = mPageInfo.PageCurrent + 1;

        }

        protected virtual void DoQuery()
        {



        }


        protected void AddYearsToCmb(ComboBoxEx cmb)
        {

            int nowyear = DateTime.Now.Year;

            cmb.Items.Clear();
            cmb.Items.Add(nowyear);
            cmb.Items.Add(nowyear - 1);
            cmb.Items.Add(nowyear - 2);
            cmb.Items.Add(nowyear - 3);
        }

        protected virtual void OnComplete(DataTable dtResult, object o)
        {

            DataGridView grid = GetDataContainer();

            grid.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate()
            {
                if (dtResult.Rows.Count > 0)
                {

                    grid.Columns.Clear();
                    grid.DataSource = dtResult;
                    grid.Columns[0].Frozen = true;
                    grid.Columns[1].Frozen = true;
                    grid.Columns[2].Frozen = true;
                }
            });

            List<string> lstfail = (List<string>)o;
            string Info = "";
            if (lstfail.Count <= 0) return;
            foreach (string str in lstfail)
            {

                Organ organ = mIOrgan.GetOrganObject(str);
                Info += organ.OrganName + " ";
            }
            Info += "读取失败";


            MessageBoxEx.Show(Info, "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
        protected virtual DataGridView GetDataContainer()
        {
            return null;
        }
        protected virtual Hashtable GetQueryCondition()
        {
            return null;
        }
        protected virtual void HandlerMsgReport(String strmsg)
        {



        }


        protected void DrawGridID(DataGridViewRowPostPaintEventArgs e)
        {

            SolidBrush B = new SolidBrush(Color.Black);
            e.Graphics.DrawString(Convert.ToString(e.RowIndex + 1, System.Globalization.CultureInfo.CurrentUICulture), e.InheritedRowStyle.Font, B, e.RowBounds.Location.X + 14, e.RowBounds.Location.Y + 4);

        }

        protected void DoTask(object sender)
        {

            string taskname = this.Name.Substring(3) + "Task";
            DataTask task = (DataTask)Assembly.Load("Bll").CreateInstance("Bll.Task." + taskname);

            task.HtPara = GetQueryCondition();
            task.LstOrgan = Comm.MainWindowState.getInstance().SelOrgan;
            //test
            //List<Organ> lst = new List<Organ>();

            //lst.Add(mIOrgan.GetOrganObject("152"));
            // task.LstOrgan = lst;
            task.EMsgReport += new DataTask.MsgReportDelegate(HandlerMsgReport);
            task.ECompelete += new DataTask.CompeleteDelegate(OnComplete);
            ToolStripButton btn = (ToolStripButton)sender;
            btn.Enabled = false;
            btn.Text = "正在获取数据";

            task.StartTaskMulti();

        }

    }
}
