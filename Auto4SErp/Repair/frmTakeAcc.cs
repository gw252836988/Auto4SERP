using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auto4SErp.Cust;
using Model;
using Bll;
using Bll.Repair;
namespace Auto4SErp.Repair
{
    public partial class frmTakeAcc : ifrmBase
    {
        private IRepair mIRepair;
        private ICustomer mICustomer;
        private IRepairAccessory mIRepairAccessory;
        private IAccessory mIAccessory;
        private float mDiscount = 0;
        private IVip mIVip;
        public frmTakeAcc()
        {
            mIRepair = BllFactory.GetRepariBll();
            mICustomer = BllFactory.GetCustomerBll();
            mIRepairAccessory = BllFactory.GetRepairAccessoryBll();
            mIAccessory = BllFactory.GetAccessoryBll();
            mIVip = BllFactory.GetVipBll();

            InitializeComponent();
        }

        private void btnDHFind_Click(object sender, EventArgs e)
        {
            //单据选择
            //  string dh = "101RP1505190003";

            frmDlgRepTakeSel frm = new frmDlgRepTakeSel();
            frm.setTransferDelegate(delegate(object o)
            {
                string dh = (string)o;
                //txtMobile.Text = "";
                RepairM obj = mIRepair.GetRepairByDH(dh);
                AssinByMobile(obj.Mobile);
                AssinByPlate(obj.PlateNum);
                txtRepType.Text = obj.RepType;
                txtMobile.Text = obj.Mobile;
                GetDiscount(obj.Mobile);
                txtReceptTime.Text = obj.ReceptTime;
                txtDH.Text = obj.DH;
                txtVin.Text = obj.Vin;
                RefreshRepairItem();
                RefreshRepairAcc();


            });
            frm.ShowDialogEx();


        }

        private void GetDiscount(string mobile)
        {
            //if (!string.IsNullOrEmpty(mobile))
            //{
            //    Customer objcust = mICustomer.GetCustomerByMobile(mobile);
            //    if (objcust != null)
            //    {

            //        string cardno = objcust.CardNo;
            //        VipInfo obj = mIVip.GetVipInfoByCardID(cardno);
            //        try
            //        {
            //            if (obj != null)
            //            {
            //                string level = obj.MemberLevel;
            //                DataTable dt = mICustomer.GetVipInfoOfLevel(level);
            //                if (dt.Rows.Count > 0)
            //                {

            //                    string strdicountofitem = dt.Rows[0]["accdiscount"].ToString();
            //                    mDiscount = float.Parse(strdicountofitem);

            //                    if (obj.Balance <= 0) mDiscount = 0;
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message.ToString());
            //        }
            //    }
            //}

        }


        private void AssinByPlate(string plate)
        {
            if (!string.IsNullOrEmpty(plate))
            {


                Car objcar = mICustomer.GetCarByPlate(plate);
                if (objcar != null)
                {
                    txtPlateNum.Text = objcar.PlateNum;
                    txtVin.Text = objcar.Vin;

                    txtCarModel.Text = objcar.CarModel;



                }
            }
            else
            {
                txtPlateNum.Text = "";
                txtVin.Text = "";

                txtCarModel.Text = "";

            }
        }

        private void AssinByMobile(string mobile)
        {
            if (!string.IsNullOrEmpty(mobile))
            {
                Customer objcust = mICustomer.GetCustomerByMobile(mobile);
                if (objcust != null)
                {
                    txtCustName.Text = objcust.CustName;

                }
            }

        }

        private void frmTakeAcc_Load(object sender, EventArgs e)
        {
            //TextCmb.Items.Add("123");
            //TextCmb.Items.Add("321");

            //if (Comm.LoginInfoShare.getInstance().OrganId == "301" || Comm.LoginInfoShare.getInstance().OrganId == "301")
            //    btnRecede.Enabled = true;
            //else
            //    btnRecede.Enabled = false;
        }

        private void RefreshRepairItem()
        {
            dgRepairItem.AutoGenerateColumns = false;
            dgRepairItem.DataSource = mIRepair.GetItemsOfDHInTake(txtDH.Text);

        }

        private void dgRepairItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.ColumnIndex;

            if (i != 1) return;
            //string aa="";
            bool isChecked = false;

            for (int j = 0; j < dgRepairItem.Rows.Count; j++)
            {
                DataGridViewCheckBoxCell chkcell = dgRepairItem[e.ColumnIndex, j] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chkcell.FormattedValue) == true && j != e.RowIndex)
                {

                    isChecked = true; break;
                }

            }

            if (isChecked == true)
            {
                DataGridViewCheckBoxCell chkcell = dgRepairItem[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                //bool IsChecked = Convert.ToBoolean(chkcell.EditedFormattedValue);
                chkcell.EditingCellFormattedValue = false;
                MessageBox.Show("只能选择一项");

            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtDH.Text)) return;



            string strItemName = "";
            int indexS = 0;
            //   bool isCheck = false;
            for (int j = 0; j < dgRepairItem.Rows.Count; j++)
            {
                DataGridViewCheckBoxCell chkcell = dgRepairItem[1, j] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chkcell.FormattedValue) == true)
                {

                    indexS = j;
                    // isCheck = true;
                    //strItemName = chkcell.Value.ToString();
                    strItemName = dgRepairItem[3, j].Value.ToString();

                    break;
                }

            }

            //if (isCheck == false)
            //{

            //    ShowMessage("请选择维修项目");
            //    return;

            //}
            frmDlgTakeAcc frm = new frmDlgTakeAcc();
            frm.DH = txtDH.Text;
            if (txtRepType.Text.Contains("装潢"))
                frm.OutType = "装潢领料";
            else
                frm.OutType = "维修领料";
            frm.ItemName = strItemName;
            frm.Discount = mDiscount;
            frm.setRefreshDelegate(delegate(bool isR)
            {
                if (isR)
                {

                    RefreshRepairAcc();


                }


            });
            frm.ShowDialogEx();
        }

        private void RefreshRepairAcc()
        {
            // dgRepairItem.AutoGenerateColumns = false;
            dgAccessory.DataSource = mIRepairAccessory.GetAccessorysOfRepairAsTake(txtDH.Text);
            txtSum.Text = mIRepair.GetForeAccAmountOfDH(txtDH.Text).ToString();
            //dgRe.AutoGenerateColumns = false;
            //dgRe.DataSource = mIAccessory.GetReRecord(txtDH.Text);
        }

        private void btnRecede_Click(object sender, EventArgs e)
        {

            if (dgAccessory.SelectedRows.Count != 0)
            {


                DataGridViewRow seldr = dgAccessory.SelectedRows[0];



                int xh = int.Parse(seldr.Cells["xh1"].Value.ToString());
                string status = seldr.Cells["status1"].Value.ToString();
                string acccode = seldr.Cells["accessorycode"].Value.ToString();
                // string acctype = seldr.Cells["acctype"].Value.ToString();
                //if (!mIAccessory.IsCanRecede(txtDH.Text, xh))//判断该领料记录是否存在，若删除则表明已退料
                //{
                //    ShowMessage("该状态下无法退料");
                //    return;
                //}

                //if (status == "负出库")
                //{
                //    if (ShowMessageOfWarning("该批次领料将全部撤销，确定吗") != DialogResult.OK)
                //    {
                //        return;
                //    }
                //    mIAccessory.AccessoryOutRecede(txtDH.Text, xh);
                //    RefreshRepairAcc();
                //}
                //else
                //{
                double amountre = 0;
                frmDlgAccRecedeAmount frm = new frmDlgAccRecedeAmount();
                frm.setTransferDelegate(d =>
                {
                    amountre = (double)d;
                });
                frm.ShowDialogEx();

                if (amountre > 0)
                {
                    decimal result = mIRepairAccessory.IsCanRecede(txtDH.Text, xh, acccode, amountre);
                    if (result >= 0)
                    {
                        mIAccessory.AccessoryOutRecede(txtDH.Text, xh, amountre);
                        RefreshRepairAcc();
                    }
                    else
                    {
                        ShowMessage(string.Format("输入的退货数量总和将大于出库数量，无法出库", result));

                    }

                }
                //}
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgAccessory.SelectedRows.Count != 0)
            {


                DataGridViewRow seldr = dgAccessory.SelectedRows[0];



                int xh = int.Parse(seldr.Cells["xh1"].Value.ToString());
                string status = seldr.Cells["status1"].Value.ToString();
                string acccode = seldr.Cells["accessorycode"].Value.ToString();
                // string acctype = seldr.Cells["acctype"].Value.ToString();
                if (!mIAccessory.IsCanRecede(txtDH.Text, xh))//判断该领料记录是否存在，若删除则表明已退料
                {
                    ShowMessage("该状态下无法删除");
                    return;
                }
                if (ShowMessageOfWarning("该批次领料将全部撤销，确定吗") != DialogResult.OK)
                {
                    return;
                }
                mIAccessory.AccessoryOutRecede(txtDH.Text, xh);
                RefreshRepairAcc();


            }



        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDH.Text)) return;

            string batch = "0";
            frmDlgBatchIDofTake frmbatch = new frmDlgBatchIDofTake();
            frmbatch.setTransferDelegate(d =>
            {
                batch = d.ToString();
            });
            frmbatch.ShowDialogEx();
            DataTable dt;
            decimal sum = 0;

            dt = mIRepairAccessory.GetAccessorysOfTakePrint(txtDH.Text, batch);
            if (dt.Rows.Count > 0)
            {

                sum = dt.AsEnumerable().Sum(r => decimal.Parse(r["sum"].ToString()));

            }
            if (dt.Rows.Count <= 0)
            {
                ShowMessage("没有领料信息");
                return;

            }




            DataTable dtAppend = new DataTable();
            dtAppend.Columns.Add("CustName", typeof(string));
            dtAppend.Columns.Add("DH", typeof(string));
            dtAppend.Columns.Add("DateTime", typeof(string));
            dtAppend.Columns.Add("OperateMan", typeof(string));
            dtAppend.Columns.Add("Remark", typeof(string));
            dtAppend.Columns.Add("TotalJE", typeof(string));
            dtAppend.Columns.Add("JE", typeof(string));

            DataRow dr = dtAppend.NewRow();
            if (txtRepType.Text.Contains("维修"))
                dr[0] = "[" + txtPlateNum.Text + "]" + txtCustName.Text;
            else
                dr[0] = "[" + txtVin.Text.Substring(txtVin.Text.Length - 6) + "]" + txtCustName.Text;
            dr[1] = txtDH.Text;
            dr[2] = DateTime.Now.ToString();
            dr[3] = Comm.LoginInfoShare.getInstance().UserName;
            dr[5] = batch;
            dr[6] = sum;
            dtAppend.Rows.Add(dr);

            Dictionary<string, DataTable> dic = new Dictionary<string, DataTable>();
            dic.Add("RepAccessory", dt);
            dic.Add("Append", dtAppend);

            frmPrint frm = new frmPrint();
            //frm.DataSource = dt;
            //frm.SourceName = "RepAccessory";
            frm.DicTable = dic;
            frm.ReportFile = "TakeAcc.rdlc";
            frm.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgAccessory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DrawGridID(e);
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (dgAccessory.SelectedRows.Count != 0)
            {


                DataGridViewRow seldr = dgAccessory.SelectedRows[0];

                string status = seldr.Cells["AccType"].Value.ToString();
                string accessorycode = seldr.Cells["accessorycode"].Value.ToString();
                string accessoryname = seldr.Cells["accessoryname"].Value.ToString();
                decimal amount = decimal.Parse(seldr.Cells["amount"].Value.ToString());
                if (status != "需求")
                {
                    ShowMessage("非装潢领料需求无法负库存出库");
                    return;
                }
                float accamount = mIAccessory.GetAccAmount(accessorycode);
                if (accamount > 0)
                {

                    ShowMessage("该配件有库存无法负出库");
                    return;

                }
                //  获得改配件库存的信息
                DataTable accDt = mIRepairAccessory.AccNegativeOut(accessorycode, amount);
                //  string housename = accDt.Rows[0]["HouseName"].ToString();

                if (accDt == null)
                {
                    ShowMessage("该配件没有入过库，无法进行负出库,请先登记");
                    frmDlgNavAcc frm1 = new frmDlgNavAcc();

                    frm1.AccessoryCode = accessorycode;
                    frm1.ShowDialogEx();
                    return;

                }

                double price = 0;
                frmDlgPriceInOfTake frm = new frmDlgPriceInOfTake();
                frm.setTransferDelegate(d =>
                {
                    price = (double)d;
                });
                frm.ShowDialogEx();

                AccessoryOfRep obj = new AccessoryOfRep();
                obj.HouseName = accDt.Rows[0]["HouseName"].ToString();
                obj.AccessoryCode = accessorycode;
                obj.InPrice = float.Parse(accDt.Rows[0]["InPrice"].ToString());
                obj.SalePrice = (float)price;

                obj.WareID = int.Parse(accDt.Rows[0]["ID"].ToString());
                obj.Amount = (float)amount;
                obj.TakeMan = Comm.LoginInfoShare.getInstance().UserName;
                obj.PriceType = "正常";
                // obj.InType = dtDemmand.Rows[0]["InType"].ToString();
                //obj.InDate = dtDemmand.Rows[0]["InDate"].ToString();
                //     obj.ItemName = accessoryname;
                obj.DH = txtDH.Text;
                obj.AccType = 1;
                obj.Status = 2;//2即为负出库
                obj.FinalPrice = 0;

                int xh = mIRepairAccessory.AddAccessoryOfRepair(obj);
                mIAccessory.AccOutWareOfNegative(txtDH.Text, xh, amount, obj.WareID, "装潢领料");
                RefreshRepairAcc();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (txtDH.Text != "")
            {
                mIRepairAccessory.UpdateBatchID(txtDH.Text);
                RefreshRepairAcc();

            }
        }

        private void dgAccessory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTakeAcc_KeyUp(object sender, KeyEventArgs e)
        {

        }


        private void frmTakeAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string str = "";
        }

        private void dgAccessory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAccessory.SelectedRows.Count != 0)
            {
                DataGridViewRow seldr = dgAccessory.SelectedRows[0];
                string id = seldr.Cells["BatchID"].Value.ToString();
                string strtakedate = seldr.Cells["TakeDate"].Value.ToString();
                if (!string.IsNullOrEmpty(strtakedate))
                {
                    DateTime takedate = DateTime.Parse(strtakedate);
                    DateTime nowdate = DateTime.Now;
                    if (takedate.Date == nowdate.Date)
                    {
                        btnRecede.Enabled = false;
                        btnDel.Enabled = true;
                    }
                    else
                    {
                        btnRecede.Enabled = true;
                        btnDel.Enabled = false;

                    }

                    //if (Comm.LoginInfoShare.getInstance().OrganId.Trim() == "159" || Comm.LoginInfoShare.getInstance().OrganId.Trim() == "152")
                    //{
                    //    btnRecede.Enabled = true;
                    //    btnDel.Enabled = true;

                    //}
                }
                txtBatch.Text = id;
                if (!string.IsNullOrEmpty(id))
                {
                    decimal sum = 0;
                    DataTable dt;
                    dt = mIRepairAccessory.GetAccessorysOfTakePrint(txtDH.Text, id);
                    if (dt.Rows.Count > 0)
                    {

                        sum = dt.AsEnumerable().Sum(r => decimal.Parse(r["sum"].ToString()));
                        txtBatchJE.Text = sum.ToString();

                    }
                }
            }
        }


    }
}
