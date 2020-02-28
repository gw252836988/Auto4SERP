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
using Comm;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
namespace Auto4SErp.Repair
{
    public partial class frmAccIn : ifrmBase
    {
        private IAccessory mIAccessory;
        // private DataTable mDicOfAccInD;
        private IAccessoryIn mIAccessoryIn;
        private IExtend mIExtend;
        private string dH;
        private string mOperateMan = "";
        private int Status;
        private bool IsInput;
        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        public frmAccIn()
        {
            mIAccessory = BllFactory.GetAccessoryBll();
            mIAccessoryIn = BllFactory.GetAccessoryInBll();
            mIExtend = BllFactory.GetExtendBll();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrInStore(false);


        }

        private void SaveOrInStore(bool isIn)
        {
            txtDH.Focus();
            AccInH obj = AssginToModel();//获取单据头表信息，如果为空则返回
            if (obj != null)
            {
                obj.DH = txtDH.Text;
                // mIAccessoryIn.UpdateAccIn(obj);
            }
            else
                return;

            if (string.IsNullOrEmpty(txtDH.Text))//单据单号为空
            {
                obj.OperatorMan = LoginInfoShare.getInstance().UserName;
                txtDH.Text = mIAccessoryIn.GetDHOfAddAccIn(obj);
                txtCreateDate.Text = DateTime.Now.ToString();
                RefreshAccessoryD();
            }
            else
            {
                obj.Status = -1;
                obj.DH = txtDH.Text;


                //判断状态然后保存

                if (Status == 0 && IsInput == false)
                    SaveAccessory();
                obj.Amount = decimal.Parse(lblCount.Text);
                obj.GJE = decimal.Parse(lblsum.Text);
                mIAccessoryIn.UpdateAccIn(obj);


            }


            if (isIn == true)
            {
                if (gridView1.RowCount > 0)
                {
                    mIAccessory.InAcc(txtDH.Text);//入库
                    SetStatus(1);
                }

            }
            IsModify = true;




        }




        private AccInH AssginToModel()
        {

            List<Pair> lstPairs = AssginToList();
            if (mFrmAssist.ValidIn(lstPairs)) return null;


            AccInH entity = FrmAssist.PopulateEntityFromCollection<AccInH>(null, lstPairs);
            return entity;
        }

        private void frmAccIn_Load(object sender, EventArgs e)
        {
            mLstControls.Add(txtDH);
            mLstControls.Add(txtCreateDate);
            mLstControls.Add(cmbInType);
            mLstControls.Add(cmbSupplyUnit);
            mLstControls.Add(cmbHouseName);
            //mLstControls.Add(cmbAccountType);


            LoadExtendContents("入库方式", cmbInType);
            LoadExtendContents("仓库名称", cmbHouseName);
            DataTable dt;


            dt = mIExtend.GetSupplyUnits("售后");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbSupplyUnit.Items.Add(dt.Rows[i][1].ToString());
            }



            SetStatus(0);
            if (!string.IsNullOrEmpty(dH))
            {
                AccInH obj = mIAccessoryIn.GetAccInHByDH(dH);
                if (obj != null)
                {
                    AssginModelToControl<AccInH>(obj);
                    mOperateMan = obj.OperatorMan;
                    SetStatus(obj.Status);
                    RefreshAccessoryD();
                }
            }
            IsInput = IsBatchIn();
            //if (IsIn == true)
            //  gridView1.OptionsBehavior.ReadOnly = true;
            SetTButtonPng(toolStrip1);
            gridView1.IndicatorWidth = 30;

            searchEdit.DataSource = mIAccessory.GetAccessorys();
        }

        private void dgAccessory_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //string str=dgAccessory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //dgAccessory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";

        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDH.Text != "")
            {
                frmAccessory frm = new frmAccessory();
                frm.IsSelect = true;
                frm.setTransferDelegate(delegate(object o)
                {
                    string result = (string)o;
                    string[] strlst = result.Split(',');

                    AccInH obj = mIAccessoryIn.GetAccInHByDH(txtDH.Text);
                    if (obj.Status == 1)
                    {
                        ShowMessage("该入库单已入库，无法再进行操作");
                        return;
                    }
                    string priceChange = "";
                    if (IsPriceChange.Checked)
                    {
                        priceChange = "0";

                    }
                    else
                        priceChange = strlst[2];
                    mIAccessoryIn.AddAccInD(txtDH.Text, strlst[0], priceChange, "1");
                    RefreshAccessoryD();

                });
                frm.ShowDialogEx();



            }


        }

        private void RefreshAccessoryD()
        {
            //DataTable dt = mIAccessoryIn.GetAccInDs(txtDH.Text);
            //FrmAssist.UpdateColumns(ref mDicOfAccInD,dt,16);
            //dgAccessory.DataSource = dt;
            //CalulateSum(dt);
            //dgAccessory.Columns[0].Visible = false;

            //dgAccessory.ReadOnly = true;

            DataTable dt = mIAccessoryIn.GetAccInDs(txtDH.Text);
            CalulateSum(dt);
            //dt.AcceptChanges();
            gridControl1.DataSource = dt;


        }


        private void CalulateSum(DataTable dt)
        {


            decimal d = dt.AsEnumerable().Sum(r => (decimal.Parse(r[3] != null ? r[3].ToString() : "0") * decimal.Parse(r[4] != null ? r[4].ToString() : "0")));
            //d = d + decimal.Parse("0.005");
            //d = Math.Round(d, 3);
            decimal c = dt.AsEnumerable().Sum(r => (decimal.Parse(r[3].ToString())));
            lblsum.Text = d.ToString();
            lblCount.Text = c.ToString();


        }
        private void dgAccessory_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            //dgAccessory.Rows[e.RowIndex].ErrorText = "";


            //if (dgAccessory.Rows[e.RowIndex].IsNewRow) { return; }

            //if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            //{
            //    double newDouble;
            //    if (!double.TryParse(e.FormattedValue.ToString(),
            //       out newDouble) || newDouble < 0)
            //    {
            //        e.Cancel = true;
            //        dgAccessory.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
            //    }


            //}
        }

        private void dgAccessory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // if (dgAccessory.Rows[e.RowIndex].IsNewRow) { return; }

            //if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            //{

            //    if (dgAccessory.Rows[e.RowIndex].Cells[0].Value != null)
            //    {
            //        mIAccessoryIn.UpdateAccInD(txtDH.Text, dgAccessory.Rows[e.RowIndex].Cells[0].Value.ToString(), dgAccessory.Rows[e.RowIndex].Cells[3].Value.ToString(), dgAccessory.Rows[e.RowIndex].Cells[4].Value.ToString());
            //        CalulateSum(dgAccessory.DataSource as DataTable);
            //    }
            //}
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            SaveOrInStore(true);
            //txtDH.Focus();
            //if (txtDH.Text != "")
            //{
            //    if (dgAccessory.Rows.Count > 0)
            //    {
            //        AccInH obj = AssginToModel();

            //        if (obj != null)
            //        {
            //            obj.DH = txtDH.Text;
            //            obj.Amount = decimal.Parse(lblCount.Text);
            //            obj.GJE = decimal.Parse(lblsum.Text);
            //            mIAccessoryIn.UpdateAccIn(obj);//保存入库单信息
            //            mIAccessory.InAcc(txtDH.Text);
            //            SetStatus(1);
            //            IsModify = true;
            //        }
            //    }

            //}
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDH.Text != "")
            {
                if (mIAccessory.BackInAcc(txtDH.Text) == 1)
                {
                    ShowMessage("无法回滚");
                    return;
                }
                IsModify = true;
                SetStatus(0);
            }
        }

        private void SetStatus(int i)
        {
            if (i == 0)
            {
                btnIn.Enabled = true;
                dgAccessory.ReadOnly = false;
                BackToolStripMenuItem.Enabled = false;
                // cmenuAccessory.Enabled = true;
                Status = 0;

            }
            else if (i == 1)
            {
                btnIn.Enabled = false;
                dgAccessory.ReadOnly = true;
                BackToolStripMenuItem.Enabled = true;
                //  cmenuAccessory.Enabled = false;
                Status = 1;


            }



        }

        private void DelAccInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDH.Text != "")
            {
                if (mIAccessoryIn.DelAccInH(txtDH.Text) == 1)
                {

                    ShowMessage("存在入库记录，无法删除该单据");
                    return;
                }
                IsModify = true;
                this.Close();

            }
        }

        private void btnBatchIn_Click(object sender, EventArgs e)
        {
            //if (gridView1.RowCount > 1)
            //{
            //    ShowMessage("请先清空表格数据");
            //    return;
            //}

            if (txtDH.Text != "")
            {
                AccInH obj = AssginToModel();
                if (obj != null)
                {
                    obj.DH = txtDH.Text;

                    obj.Status = -1;
                    mIAccessoryIn.UpdateAccIn(obj);
                    frmBatchIn frm = new frmBatchIn();
                    frm.TableName = "AccessoryIn";
                    frm.Append = txtDH.Text + "," + cmbHouseName.Text;
                    frm.setRefreshDelegate(delegate(bool isr)
                    {
                        RefreshAccessoryD();
                        IsInput = true;
                    });
                    frm.ShowDialogEx();

                }
            }
            else
                ShowMessage("请先保存生成单号");

        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgAccessory.SelectedCells.Count != 0)
            {
                DataGridViewCell cell = dgAccessory.SelectedCells[0];
                int rowindex = cell.RowIndex;
                string xh = dgAccessory.Rows[rowindex].Cells[0].Value.ToString();
                mIAccessoryIn.DelAccInD(dH, xh);
                RefreshAccessoryD();


            }
        }


        private void AddXHTODt(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][0] = i + 1;

            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDH.Text)) return;
            DataTable dt = mIAccessoryIn.GetAccInDs(txtDH.Text);
            //dt.Columns.Add("XH", typeof(int));
            // AddXHTODt(dt);
            if (dt.Rows.Count <= 0)
            {
                ShowMessage("没有领料信息");
                return;

            }
            DataTable dtAppend = new DataTable();

            dtAppend.Columns.Add("DH", typeof(string));
            dtAppend.Columns.Add("DateTime", typeof(string));
            dtAppend.Columns.Add("SupplyUnit", typeof(string));
            dtAppend.Columns.Add("HouseName", typeof(string));
            dtAppend.Columns.Add("OperateMan", typeof(string));
            dtAppend.Columns.Add("TotalJE", typeof(string));
            DataRow dr = dtAppend.NewRow();
            dr[0] = txtDH.Text;
            dr[1] = txtCreateDate.Text;
            dr[2] = cmbSupplyUnit.Text;
            dr[3] = cmbHouseName.Text;
            dr[4] = mOperateMan;
            dr[5] = lblsum.Text;
            dtAppend.Rows.Add(dr);

            Dictionary<string, DataTable> dic = new Dictionary<string, DataTable>();
            AddXHTODt(dt);
            dic.Add("RepAccessory", dt);
            dic.Add("Append", dtAppend);


            frmPrint frm = new frmPrint();
            //frm.DataSource = dt;
            //frm.SourceName = "RepAccessory";
            frm.DicTable = dic;
            frm.ReportFile = "AccIn.rdlc";
            frm.ShowDialog();
        }

        private void btnCustomerFind_Click(object sender, EventArgs e)
        {
            frmSupplyUnit frm = new frmSupplyUnit();
            frm.ShowDialogEx();

        }

        private void dgAccessory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }

        private void frmAccIn_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgAccessory.SelectedCells.Count != 0)
            {
                DataGridViewCell cell = dgAccessory.SelectedCells[0];
                int rowindex = cell.RowIndex;
                string xh = dgAccessory.Rows[rowindex].Cells[0].Value.ToString();
                double amount = double.Parse(dgAccessory.Rows[rowindex].Cells[3].Value.ToString());
                double inprice = double.Parse(dgAccessory.Rows[rowindex].Cells[4].Value.ToString());
                frmDlgAccIn frm = new frmDlgAccIn();
                frm.Amount = amount;
                frm.InPrice = inprice;
                string[] strlist = null;

                if (xh == "-1")
                {

                    ShowMessage("导入的数据不能直接修改，请在导入文件中修改");
                    return;

                }
                frm.setTransferDelegate(d =>
                {
                    strlist = d.ToString().Split(',');
                    amount = double.Parse(strlist[0]);
                    inprice = double.Parse(strlist[1]);
                });
                frm.ShowDialogEx();

                if (strlist != null)
                {

                    AccInH obj = mIAccessoryIn.GetAccInHByDH(txtDH.Text);
                    if (obj.Status == 1)
                    {
                        ShowMessage("该入库单已入库，无法再进行操作");
                        return;
                    }



                    double priceChange = 0;
                    if (IsPriceChange.Checked)
                    {
                        priceChange = inprice * 1.13;

                    }
                    else
                        priceChange = inprice;

                    //mIAccessoryIn.UpdateAccInD(txtDH.Text, xh, amount.ToString(), priceChange.ToString());
                    RefreshAccessoryD();
                }


            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "AccessoryCode")
                e.RepositoryItem = AccessoryCodeEdit;
            else if (e.Column.FieldName == "Amount")
                e.RepositoryItem = NumEdit;
            else if (e.Column.FieldName == "InPrice")
                e.RepositoryItem = NumEdit;
        }
        //devexpress
        private void AccessoryCodeEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {




            if (txtDH.Text != "")
            {
                frmAccessory frm = new frmAccessory();
                frm.IsSelect = true;
                frm.setTransferDelegate(delegate(object o)
                {
                    string result = (string)o;
                    string[] strlst = result.Split(',');

                    AccInH obj = mIAccessoryIn.GetAccInHByDH(txtDH.Text);
                    if (obj.Status == 1)
                    {
                        ShowMessage("该入库单已入库，无法再进行操作");
                        return;
                    }


                    int handle = gridView1.GetSelectedRows()[0];

                    // GridCell cell = gridView1.GetSelectedCells()[0];

                    //if(handle<0)
                    //    gridView1.AddNewRow();
                    ButtonEdit bt = (ButtonEdit)sender;
                    bt.Text = strlst[0];                 // gridView1.SetRowCellValue(handle, "AccessoryCode", strlst[0]);
                    gridView1.SetRowCellValue(handle, "AccessoryName", strlst[3]);
                    string priceChange = "";
                    if (IsPriceChange.Checked)
                    {
                        priceChange = "0";

                    }
                    else
                        priceChange = strlst[2];
                    gridView1.SetRowCellValue(handle, "InPrice", priceChange);
                    //mIAccessoryIn.AddAccInD(txtDH.Text, strlst[0], priceChange);
                    //RefreshAccessoryD();

                });
                frm.ShowDialogEx();



            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            // ColumnView view = sender as ColumnView;

            GridColumn cAmount = gridView1.Columns["Amount"];
            GridColumn cAccessoryCode = gridView1.Columns["AccessoryCode"];
            GridColumn cInPrice = gridView1.Columns["InPrice"];

            //string strCode = gridView1.GetRowCellValue(e.RowHandle, cAccessoryCode).ToString();
            object code = gridView1.GetRowCellValue(e.RowHandle, cAccessoryCode);
            if (code != null && code.ToString().Length < 1)
            {
                e.Valid = false;
                gridView1.SetColumnError(cAccessoryCode, "请选择配件编码");
                return;
            }
            //object oAmount = gridView1.GetRowCellValue(e.RowHandle, cAmount);

            // decimal amount = (decimal)gridView1.GetRowCellValue(e.RowHandle, cAmount);
            //decimal amount = (decimal)gridView1.GetRowCellValue(e.RowHandle, cAmount);

            object amount = gridView1.GetRowCellValue(e.RowHandle, cAmount);
            if (amount != null && (decimal)amount <= 0)
            {
                e.Valid = false;
                gridView1.SetColumnError(cAmount, "数量不能小于等于0");
                return;

            }

            //decimal inprice = (decimal)gridView1.GetRowCellValue(e.RowHandle, cInPrice);
            object inprice = gridView1.GetRowCellValue(e.RowHandle, cInPrice);
            if (inprice != null && (decimal)inprice < 0)
            {
                e.Valid = false;
                gridView1.SetColumnError(cInPrice, "成本价不能小于0");
                return;

            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "Amount", 1.00);
            gridView1.SetRowCellValue(e.RowHandle, "InPrice", 0.00);

        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {


        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {

        }


        private void SaveAccessory()
        {
            txtDH.Focus();
            DataTable dt = (DataTable)gridControl1.DataSource;
            DataTable dtUpdate = dt.GetChanges(DataRowState.Modified);
            DataTable dtAdd = dt.GetChanges(DataRowState.Added);
            // DataTable dtDelete = dt.GetChanges(DataRowState.Deleted);
            if (dtUpdate != null)
            {
                for (int i = 0; i < dtUpdate.Rows.Count; i++)
                {


                    string xh = dtUpdate.Rows[i]["xh"].ToString();
                    string amount = dtUpdate.Rows[i]["amount"].ToString();
                    string price = dtUpdate.Rows[i]["inprice"].ToString();
                    string accessorycode = dtUpdate.Rows[i]["accessorycode"].ToString();
                    mIAccessoryIn.UpdateAccInD(txtDH.Text, xh, amount.ToString(), price, accessorycode);



                }
            }

            if (dtAdd != null)
            {
                for (int i = 0; i < dtAdd.Rows.Count; i++)
                {


                    string code = dtAdd.Rows[i]["AccessoryCode"].ToString();
                    string price = dtAdd.Rows[i]["inprice"].ToString();
                    string amount = dtAdd.Rows[i]["amount"].ToString();
                    mIAccessoryIn.AddAccInD(txtDH.Text, code, price, amount);

                }


            }
            RefreshAccessoryD();




        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //int handle = e.RowHandle;
            //if (!(e.Column.FieldName == "Amount" || e.Column.FieldName == "InPrice")) return;
            //object oAmount = gridView1.GetRowCellValue(handle, "Amount");
            //    object oInPrice = gridView1.GetRowCellValue(handle, "InPrice");
            //    if (oAmount == null || oInPrice == null) return;
            //    decimal amount = (decimal)oAmount;
            //    decimal inprice = (decimal)oInPrice;
            //    gridView1.SetRowCellValue(handle, "JE", amount * inprice);


        }

        private void gridView1_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void DeleteEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            if (Status == 1) return;
            int handle = gridView1.FocusedRowHandle;
            object xh = gridView1.GetRowCellValue(handle, "XH");
            if (xh == null) return;


            if (e.Button.Caption == "删除")
            {


                if (handle >= 0)
                {

                    xh = gridView1.GetRowCellValue(handle, "XH");
                    if (xh.ToString() != "")
                    {
                        mIAccessoryIn.DelAccInD(txtDH.Text, xh.ToString());


                    }

                    gridView1.DeleteRow(handle);



                    SaveOrInStore(false);

                    if (gridView1.RowCount <= 1)
                        IsInput = false;
                }


            }


            //if (dgAccessory.SelectedCells.Count != 0)
            //{
            //    DataGridViewCell cell = dgAccessory.SelectedCells[0];
            //    int rowindex = cell.RowIndex;
            //    string xh = dgAccessory.Rows[rowindex].Cells[0].Value.ToString();
            //    mIAccessoryIn.DelAccInD(dH, xh);
            //    RefreshAccessoryD();


            //}
        }

        private void NumEdit_ValueChanged(object sender, EventArgs e)
        {
            int handle = gridView1.FocusedRowHandle;

            SpinEdit edit = (SpinEdit)sender;
            string cation = gridView1.FocusedColumn.Caption;
            decimal amount = 0;
            decimal inprice = 0;
            if (cation == "成本单价")
            {
                inprice = edit.Value;
                amount = (decimal)gridView1.GetRowCellValue(handle, "Amount");

            }

            if (cation == "数量")
            {
                amount = edit.Value;
                inprice = (decimal)gridView1.GetRowCellValue(handle, "InPrice");
            }

            //gridView1.Appearance.FocusedCell.BackColor = Color.Red;
            //GridColumn gridView1.FocusedColumn
            //if (!(e.Column.FieldName == "Amount" || e.Column.FieldName == "InPrice")) return;
            //object oAmount = gridView1.GetRowCellValue(handle, "Amount");
            //object oInPrice = gridView1.GetRowCellValue(handle, "InPrice");
            //if (oAmount == null || oInPrice == null) return;
            //decimal amount = (decimal)oAmount;
            //decimal inprice = (decimal)oInPrice;

            gridView1.SetRowCellValue(handle, "JE", Math.Round(amount * inprice, 4));

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.RowHandle ==2)
            //{
            //    e.Appearance.BackColor = Color.DeepSkyBlue;
            //    e.Appearance.BackColor2 = Color.LightCyan;

            //}
            if (e.RowHandle < 0) return;
            object xh = gridView1.GetRowCellValue(e.RowHandle, "XH");
            if (xh != null && xh.ToString() == "-1")
            {
                e.Appearance.BackColor = Color.RoyalBlue;
                e.Appearance.BackColor2 = Color.LightCyan;



            }
            ////单元格  
            //if (e.Column.ColumnHandle == 0)  
            //{  
            //     //e.Appearance.BackColor = Color.DeepSkyBlue;  
            //     //e.Appearance.BackColor2 = Color.LightCyan;
            //    e.Column.AppearanceCell.BackColor = Color.DeepSkyBlue;
            // }



        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {

            //if(e.Column.Caption=="配件编码")
            //    e.Appearance.BackColor = Color.DeepSkyBlue;
            //GridCell cell = gridView1.GetSelectedCells()[0];


        }

        private bool IsBatchIn()
        {
            int count = gridView1.RowCount;
            string xh = "";
            for (int i = 0; i < count; i++)
            {

                object o = gridView1.GetRowCellValue(i, "XH");
                if (o == null) continue;
                xh = o.ToString();
                if (xh == "-1")
                    return true;
            }
            return false;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void searchEdit_EditValueChanged(object sender, EventArgs e)
        {


            SearchLookUpEdit edit = (SearchLookUpEdit)sender;

            string str1 = edit.EditValue.ToString();
            string str2 = edit.Text;

            int handle = gridView1.GetSelectedRows()[0];


            gridView1.SetRowCellValue(handle, "AccessoryName", str2);

        }

        private void searchEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {

        }



    }

    //根据不同条件
    //private void ConditionsAdjustment()
    //   {
    //       StyleFormatCondition cn;
    //       cn = new StyleFormatCondition(FormatConditionEnum.LessOrEqual, grdDataView.Columns["States"], null, "成功");//找到你要改变颜色的列名,再输入你判断的依据!
    //       //cn.Appearance.BackColor = Color.Yellow;//某个单元格的背景颜色

    //       cn.Appearance.ForeColor = Color.FromArgb(4,4,4,4);//某个单元格内容的颜色
    //       grdDataView.FormatConditions.Add(cn);//添加到XtraGrid控件上!
    //       cn = new StyleFormatCondition(FormatConditionEnum.GreaterOrEqual, grdDataView.Columns["States"], null, "失败");
    //       cn.Appearance.ForeColor = Color.Red;
    //       grdDataView.FormatConditions.Add(cn);
    //       cn = new StyleFormatCondition(FormatConditionEnum.GreaterOrEqual, grdDataView.Columns["States"], null, "已提交");
    //       cn.Appearance.ForeColor = Color.FromArgb(8,2,252);
    //       grdDataView.FormatConditions.Add(cn);
    //   }
}
