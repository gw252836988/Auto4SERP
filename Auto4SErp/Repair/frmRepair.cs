﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll.Repair;
using Auto4SErp.Cust;
using Model;
using Bll;
using System.Data.SqlClient;
using Auto4SErp.Sale;
using Bll.Personnel;
using Bll.Sale;

using Comm;
using DevExpress.XtraReports.UI;
namespace Auto4SErp.Repair
{
    public partial class frmRepair : ifrmBase
    {
        private IRepairItem mIRepairItem;
        private ICustomer mICustomer;
        private IRepair mIRepair;
        private IFinance mIFinance;
        private IRepairAccessory mIRepairAccessory;
        private IOperateMan mIOperateMan;
        private IVip mIVip;
        private ICarSale mICarSale;
        private Company CompanyInfo;

        public int FinanceID
        {
            get;
            set;
        }
        //  private DataTable mDtTemp;

        //private int mNowRow=0;
        //private int mNowColumn;
        private int mAddRow = 0;

        // private TextBox mNowTextBox;
        // private string mTextOfI="";
        private string mobileAndPlate;
        private string dH = "";


        private bool isSaleDecorate = false;

        public bool IsSaleDecorate
        {
            get { return isSaleDecorate; }
            set { isSaleDecorate = value; }
        }

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        public string MobileAndPlate
        {
            get { return mobileAndPlate; }
            set { mobileAndPlate = value; }
        }

        public string SaleDH
        {
            get;
            set;

        }
        public frmRepair()
        {
            InitializeComponent();

        }


        private void CreateCompany()
        {
            CompanyInfo = new Company();
            string organid = Comm.LoginInfoShare.getInstance().OrganId;
            if (organid == "161")
            {
                CompanyInfo.CompanyName = "南通先锋新城丰田汽车销售服务有限公司";
                CompanyInfo.CompanyAddress = "江苏省南通通州区青年东路618号";
                CompanyInfo.TelePhone = "0513-86329698";
                CompanyInfo.ComplainPhone = "968895";
                CompanyInfo.Bank = "江苏银行静海支行";
                CompanyInfo.BankAccount = "50260188000845247";

            }
            else if (organid == "159")
            {
                CompanyInfo.CompanyName = "南通新城世纪汽车销售服务有限公司";
                CompanyInfo.CompanyAddress = "江苏省南通通州区青年东路618号";
                CompanyInfo.TelePhone = "0513-55018599";
                CompanyInfo.ComplainPhone = "968895";
                CompanyInfo.Bank = "华夏银行南通分行";
                CompanyInfo.BankAccount = "13950000000047005";

            }
        }

        private void frmRepair_Load(object sender, EventArgs e)
        {
            //  dgRepairItem.DataSource = null;
            SetTButtonPng(toolStrip1);
            mIRepairItem = Bll.BllFactory.GetRepairItemBll();
            mICustomer = BllFactory.GetCustomerBll();
            mIRepair = BllFactory.GetRepariBll();
            mIRepairAccessory = BllFactory.GetRepairAccessoryBll();
            mIFinance = BllFactory.GetFinanceBll();
            mIVip = BllFactory.GetVipBll();
            mIOperateMan = BllFactory.GetOperateManBll();
            mICarSale = BllFactory.GetCarSaleBll();
            //     dgRepairItem.DataSource = mIRepairItem.GetRepariItemBySpell("gl");
            //mDtTemp = new DataTable();
            //mDtTemp.Columns.Add("id");
            //mDtTemp.Columns.Add("itemcode");
            //mDtTemp.Columns.Add("itemname");

            //DataRow dr = mDtTemp.NewRow();
            //dr["itemname"] = "aa";
            //mDtTemp.Rows.Add(dr);
            //dgRepairItem.DataSource = mDtTemp;
            //mRows = mDtTemp.Rows.Count;
            txtReceptMan.Text = Comm.LoginInfoShare.getInstance().UserName;
            timer1.Enabled = false;
            cmbComeType.SelectedIndex = -1;
            //CarLevel.Items.Add("中档");
            //CarLevel.Items.Add("高档");
            //CarLevel.Items.Add("低档");
            //CarLevel.Items.Add("豪华");
            cmbRepType.SelectedIndex = 0;

            if (!string.IsNullOrEmpty(mobileAndPlate))
            {
                string[] strLst = mobileAndPlate.Split(',');
                string mobile = strLst[0];
                string plate = strLst[1];

                if (!string.IsNullOrEmpty(mobile))
                {
                    AssinByMobile(mobile);
                    AssinByPlate(plate);
                }


            }

            if (!string.IsNullOrEmpty(dH))
            {
                RepairM obj = mIRepair.GetRepairByDH(dH);
                if (obj != null)
                {

                    if (obj.RepChildType == "销售装潢")
                        isSaleDecorate = true;
                    // cmbRepType.Text = obj.RepType;
                    SetRepType(obj.RepType);
                    //此处有循环 i


                    SetRepChildType(obj.RepChildType);


                    AssinByMobile(obj.Mobile);
                    AssinByPlate(obj.PlateNum);
                    //  if(!string.IsNullOrEmpty(obj.ReceptMan))
                    txtReceptMan.Text = obj.ReceptMan;
                    //  txtPreItemAmount.Text = obj.PreItemAmount;
                    //   txtPreAccessoryAmount.Text = obj.PreAccessoryAmount;
                    txtReceptTime.Text = obj.ReceptTime;
                    txtAccessAmount.Text = obj.AccessAmount.ToString();
                    // txtCompleteTime.Text = obj.CompleteTime;
                    txtDH.Text = obj.DH;
                    //  txtInsuranceCompany.Text = obj.InsuranceCompany;

                    txtSendRepMan.Text = obj.SendRepMan;
                    txtDecorateDH.Text = obj.DecorateDH;

                    txtSendRepTel.Text = obj.SendRepTel;
                    chbIsNeedOld.Checked = obj.IsNeedOld;
                    chbIsWash.Checked = obj.IsWash;
                    chbIsWillVisit.Checked = obj.IsWillVisit;
                    cmbComeType.Text = obj.ComeType;
                    txtSystemDH.Text = obj.SystemDH;
                    if (obj.InMil != null)
                        txtInMil.Text = obj.InMil;
                    if (obj.NextKeepMil != null)
                        txtNextKeepMil.Text = obj.NextKeepMil;
                    if (obj.NextKeepDate != null && obj.NextKeepDate.Year != 1)
                        datNextKeepDate.Value = obj.NextKeepDate;

                    if (obj.EstimateComplete != null && obj.EstimateComplete.Year != 1)
                        dtpEstimateComplete.Value = obj.EstimateComplete;
                    txtRemark.Text = obj.Remark;
                    txtVin.Text = obj.Vin;

                    SetStatus(obj.Status);
                    txtLastMil.Text = mIRepair.GetLastInMil(txtPlateNum.Text, txtReceptTime.Text);
                    //给预估材料赋值
                    // txtPreAccessoryAmount.Text=  mIRepair.GetAccAmountOfDH(obj.DH).ToString();
                    // StartWork(txtDH.Text + "," + cmbRepChildType.Text);
                    RefreshRepairItem();
                    RefreshAccssorys();
                }

            }
            else
                SetStatus(-1);




            dgRepairItem.Columns[0].ReadOnly = true;
            dgRepairItem.Columns[1].ReadOnly = true;
            dgRepairItem.Columns[2].ReadOnly = true;
            dgRepairItem.Columns[3].ReadOnly = true;
            dgRepairItem.Columns[4].ReadOnly = true;
            dgRepairItem.Columns[5].ReadOnly = true;

            btnPrintDemand.Enabled = false;
            if (isSaleDecorate == true)
            {
                cmbRepType.SelectedIndex = 1;

                //cmbRepChildType.SelectedIndex = 0;
                cmbRepChildType.Enabled = true;
                cmbRepType.Enabled = false;
                btnPrintDemand.Enabled = true;
                lblDecorateDH.Visible = true;
                txtDecorateDH.Visible = true;
                txtVin.ReadOnly = false;
                chbPresent.Visible = true;
                if (!string.IsNullOrEmpty(SaleDH))
                {
                    AssinBySaleDH(SaleDH);

                }
                btnModify.Enabled = true;
                this.Width = 760;
            }
            else
                btnModify.Enabled = false;

            if (FinanceID > 0)
            {
                menuClaim.Enabled = true;

            }

            CreateCompany();


        }



        private void SetRepType(string reptype)
        {
            for (int i = 0; i < cmbRepType.Items.Count; i++)
            {
                if (cmbRepType.Items[i].ToString() == reptype)
                {
                    cmbRepType.SelectedIndex = i;
                    return;

                }
            }


        }

        private void SetRepChildType(string repchildtype)
        {
            for (int i = 0; i < cmbRepChildType.Items.Count; i++)
            {

                if (cmbRepChildType.Items[i].ToString() == repchildtype)
                {
                    cmbRepChildType.SelectedIndex = i;
                    return;

                }
            }


        }


        protected override void DoworkInBack(object sender, DoWorkEventArgs e)
        {

            string[] strlst = e.Argument.ToString().Split(',');
            string PreAccessoryAmount;
            if (!strlst[1].Contains("装潢"))
                PreAccessoryAmount = mIRepair.GetAccAmountOfDH(strlst[0]).ToString();
            else
                PreAccessoryAmount = mIRepair.GetAccDemandAmountOfDH(strlst[0]).ToString();
            string PreItemAmount = mIRepair.GetItemAmountOfDH(strlst[0]).ToString();

            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtPreAccessoryAmount.Text = PreAccessoryAmount;
                txtPreItemAmount.Text = PreItemAmount;
                CacuAllPreAmount();
                dgAccessory.AutoGenerateColumns = false;
                dgAccessory.DataSource = mIRepairAccessory.GetAccessorysOfRepairAsRep(txtDH.Text);
            });

        }

        private void AssinByMobile(string mobile)
        {
            if (!string.IsNullOrEmpty(mobile))
            {
                Customer objcust = mICustomer.GetCustomerByMobile(mobile);
                if (objcust != null)
                {
                    txtCustName.Text = objcust.CustName;
                    txtAddress.Text = objcust.Address;
                    txtMobile.Text = objcust.Mobile;
                    txtCardNo.Text = objcust.CardNo;
                    //    cmbCustType.Text = objcust.CustType;
                    if (!string.IsNullOrEmpty(objcust.CardNo))
                    {
                        GetVipInfo(objcust.CardNo);
                    }
                }

                string vin = mICarSale.CheckBuyFormHere(mobile);
                if (!string.IsNullOrEmpty(vin))
                {
                    chbBuyHere.Checked = true;
                }

            }

        }


        private void GetVipInfo(string cardno)
        {

            VipInfo obj;

            obj = mIVip.GetVipInfoByCardID(cardno);


            if (obj != null)
            {
                string level = obj.MemberLevel;
                lblVipType.Text = level;
                lblBalance.Visible = true;
                labelX1.Visible = true;
                lblBalance.Text = obj.Balance.ToString();

            }



        }
        private void AssinByPlate(string plate)
        {
            if (!string.IsNullOrEmpty(plate))
            {


                //Car objcar = mICustomer.GetCarByPlate(plate);
                //if (objcar != null)
                //{
                //    txtPlateNum.Text = objcar.PlateNum;
                //    txtVin.Text = objcar.Vin;
                //    txtCarBrand.Text = objcar.CarBrand;
                //    txtCarModel.Text = objcar.CarModel;
                //    txtColor.Text = objcar.CarColor;


                //}

                System.Data.DataTable dt = mICustomer.GetCarByPalteNum(plate);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtCarBrand.Text = dt.Rows[0]["CarSer"].ToString();
                    txtCarModel.Text = dt.Rows[0]["CarModel"].ToString();
                    //txtCarSer.Text = dt.Rows[0]["CarSer"].ToString();
                    txtColor.Text = dt.Rows[0]["CarColor"].ToString();
                    txtPlateNum.Text = dt.Rows[0]["PlateNum"].ToString();
                    txtVin.Text = dt.Rows[0]["Vin"].ToString();
                    txtEngineID.Text = dt.Rows[0]["EngineID"].ToString();
                    txtMobile.Text = dt.Rows[0]["Mobile"].ToString();
                    txtCustName.Text = dt.Rows[0]["CustName"].ToString();


                    if (dt.Rows[0]["InsuranceCompany"] != null)
                        txtInsuranceCompany.Text = dt.Rows[0]["InsuranceCompany"].ToString();
                    if (dt.Rows[0]["InBegin"] != null && !string.IsNullOrEmpty(dt.Rows[0]["InBegin"].ToString()))
                        datInBegin.Value = DateTime.Parse(dt.Rows[0]["InBegin"].ToString());
                    if (dt.Rows[0]["InEnd"] != null && !string.IsNullOrEmpty(dt.Rows[0]["InEnd"].ToString()))
                        datInEnd.Value = DateTime.Parse(dt.Rows[0]["InEnd"].ToString());

                    if (dt.Rows[0]["KeepBegin"] != null && !string.IsNullOrEmpty(dt.Rows[0]["KeepBegin"].ToString()))
                        datKeepBegin.Value = DateTime.Parse(dt.Rows[0]["KeepBegin"].ToString());
                    if (dt.Rows[0]["KeepEnd"] != null && !string.IsNullOrEmpty(dt.Rows[0]["KeepEnd"].ToString()))
                        datKeepEnd.Value = DateTime.Parse(dt.Rows[0]["KeepEnd"].ToString());

                    if (dt.Rows[0]["P2PMobile"] != null && !string.IsNullOrEmpty(dt.Rows[0]["P2PMobile"].ToString()))
                        chbP2PVip.Checked = true;
                    else
                        chbP2PVip.Checked = false;
                    cmbCustType.Text = mIRepair.GetCustType(plate);



                }

            }
            else
            {
                txtPlateNum.Text = "";
                txtVin.Text = "";
                txtCarBrand.Text = "";
                txtCarModel.Text = "";
                txtColor.Text = "";
                if (!IsSaleDecorate)
                {
                    if (cmbRepType.SelectedIndex == 1) return;
                    if (ShowMessageOfWarning("没有车牌号，是否添加？") == DialogResult.OK)
                    {
                        frmRepCustomerEdit frm = new frmRepCustomerEdit();
                        //   frm.PlateNum = txtPlateNum.Text;
                        //  frm.Mobile = txtMobile.Text;
                        frm.Mobile = txtMobile.Text;
                        frm.setTransferDelegate(d => DoResultByTransferData(d));
                        frm.ShowDialogEx();
                    }
                }

            }


        }


        private void RefreshRepairItem()
        {
            dgRepairItem.AutoGenerateColumns = false;

            txtPreItemAmount.Text = mIRepair.GetItemAmountOfDH(txtDH.Text).ToString();
            CacuAllPreAmount();
            System.Data.DataTable dt = mIRepair.GetItemsOfDH(txtDH.Text);
            dgRepairItem.DataSource = dt;
            //StartWork(txtDH.Text);

        }

        private void CacuAllPreAmount()
        {
            decimal item = 0;
            decimal acc = 0;

            if (txtPreItemAmount.Text.Length > 1)
                item = decimal.Parse(txtPreItemAmount.Text);

            if (txtPreAccessoryAmount.Text.Length > 1)
                acc = decimal.Parse(txtPreAccessoryAmount.Text);
            txtAll.Text = (item + acc).ToString();
        }

        private void dgRepairItem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int i = dgRepairItem.Rows.Count;
            mAddRow = e.RowIndex;
            // DataTable dt = mDtTemp;

        }


        private void frmRepair_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //private void dgRepairItem_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyValue == 27)
        //    {
        //        dgResult.Visible = false;
        //        dgResult.DataSource = null;

        //    }
        //}

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if(mNowTextBox!=null)
        //    {
        //        if (mNowColumn == 2)
        //        {

        //            if (mTextOfI != mNowTextBox.Text)
        //            {

        //                dgResult.DataSource = mIRepairItem.GetRepariItemBySpell(mNowTextBox.Text);
        //                dgResult.Visible = true;
        //                mTextOfI = mNowTextBox.Text;

        //            }
        //        }
        //    }
        //}




        private void btnSave_Click(object sender, EventArgs e)
        {
            Bll.Sale.ICarSale mICarSale;
            mICarSale = Bll.BllFactory.GetCarSaleBll();

            if (string.IsNullOrEmpty(txtCustName.Text))
            {
                ShowMessage("请选择客户");
                return;
            }


            if (!cmbRepChildType.Text.Contains("装潢"))
            {
                if (string.IsNullOrEmpty(txtPlateNum.Text))
                {
                    ShowMessage("请选择车辆");
                    return;

                }

                if (string.IsNullOrEmpty(txtInsuranceCompany.Text))
                {
                    ShowMessage("请选择保险公司");
                    return;
                }

                if (string.IsNullOrEmpty(txtInMil.Text))
                {
                    ShowMessage("请填写进厂里程");
                    return;
                }
                if (Comm.LoginInfoShare.getInstance().OrganId == "161")
                {

                    if (string.IsNullOrEmpty(txtNextKeepMil.Text))
                    {
                        ShowMessage("请输入下次保养里程");
                        return;

                    }


                    DateTime dtBegin = datInBegin.Value;
                    DateTime dtEnd = datInEnd.Value;

                    TimeSpan ts = dtEnd - dtBegin;

                    if (ts.Days < 30)
                    {
                        ShowMessage("请输入正确的保险起始日期");
                        return;
                    }

                    if (string.IsNullOrEmpty(txtSendRepMan.Text))
                    {
                        ShowMessage("请输入送修人姓名");
                        return;

                    }


                    if (string.IsNullOrEmpty(txtSendRepTel.Text))
                    {
                        ShowMessage("请输入送修人电话");
                        return;

                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtVin.Text))
                {
                    ShowMessage("请输入Vin码");
                    return;
                }


            }
            if (cmbRepChildType.Text == "事故维修")
            {
                if (cmbComeType.SelectedIndex == -1)
                {
                    ShowMessage("事故维修需要选择进店方式");
                    return;


                }

            }



            if (string.IsNullOrEmpty(txtDH.Text))
            {
                RepairM obj = new RepairM();
                obj.Mobile = txtMobile.Text;
                obj.PlateNum = txtPlateNum.Text;
                obj.RepType = cmbRepType.SelectedItem.ToString();
                obj.RepChildType = cmbRepChildType.SelectedItem.ToString();
                obj.ReceptMan = txtReceptMan.Text;
                obj.CarModel = txtCarModel.Text;
                obj.CustName = txtCustName.Text;
                obj.Vin = txtVin.Text;
                obj.CardNo = txtCardNo.Text;
                obj.VipLevel = lblVipType.Text;
                obj.DecorateDH = txtDecorateDH.Text;
                obj.ComeType = cmbComeType.Text;
                obj.SystemDH = txtSystemDH.Text;
                txtDH.Text = mIRepair.GetDHOfAddRepair(obj);
                txtReceptTime.Text = DateTime.Now.ToString();
                txtLastMil.Text = mIRepair.GetLastInMil(txtPlateNum.Text, txtReceptTime.Text);
                if (m_del != null) m_del(txtDH.Text);
                SetStatus(0);
            }
            else
            {
                RepairM obj = CreateObjOfValues();
                obj.RepType = cmbRepType.SelectedItem.ToString();
                obj.RepChildType = cmbRepChildType.SelectedItem.ToString();
                obj.CustName = txtCustName.Text;
                obj.Vin = txtVin.Text;
                obj.CarModel = txtCarModel.Text;
                obj.DecorateDH = txtDecorateDH.Text;

                mIRepair.UpdateRepair(obj);

            }

            //if (!string.IsNullOrEmpty(txtDecorateDH.Text))
            //{
            //    mICarSale.AddCarSaleDecorateDH(txtDecorateDH.Text ,txtDH.Text);

            //}
            IsModify = true;



        }




        private void btnRecept_Click(object sender, EventArgs e)
        {

        }


        private RepairM CreateObjOfValues()
        {
            RepairM obj = new RepairM();
            obj.DH = txtDH.Text;
            // obj.ReceptMan = txtReceptMan.Text;
            obj.RepType = cmbRepType.Text;
            obj.RepChildType = cmbRepChildType.Text;
            //   obj.InsuranceCompany = txtInsuranceCompany.Text;
            obj.SendRepMan = txtSendRepMan.Text;
            obj.SendRepTel = txtSendRepTel.Text;
            obj.Status = -1;
            obj.IsNeedOld = chbIsNeedOld.Checked;
            obj.IsWash = chbIsWash.Checked;
            obj.IsWillVisit = chbIsWillVisit.Checked;
            obj.CarModel = txtCarModel.Text;
            obj.CustName = txtCustName.Text;
            obj.Vin = txtVin.Text;
            obj.InMil = txtInMil.Text;
            obj.NextKeepMil = txtNextKeepMil.Text;
            obj.NextKeepDate = datNextKeepDate.Value;
            obj.EstimateComplete = dtpEstimateComplete.Value;
            obj.Remark = txtRemark.Text;
            obj.Mobile = txtMobile.Text;
            obj.PlateNum = txtPlateNum.Text;
            obj.ComeType = cmbComeType.Text;
            obj.SystemDH = txtSystemDH.Text;
            return obj;

        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgRepairItem.SelectedCells.Count != 0)
            {

                DataGridViewCell cell = dgRepairItem.SelectedCells[0];
                int rowindex = cell.RowIndex;
                object xho = dgRepairItem.Rows[rowindex].Cells[0].Value;
                // string xh = dgRepairItem.Rows[rowindex].Cells[0].Value.ToString();
                if (xho != null && !string.IsNullOrEmpty(xho.ToString()))
                {
                    mIRepair.DeleteItemOfRepair(txtDH.Text, xho.ToString());

                }
                RefreshRepairItem();
            }
        }


        private void SetStatus(int status)
        {
            tdrAccount.Enabled = true;
            tdrRecept.Enabled = true;
            btnSave.Text = "保存";
            btnSave.Image = global::Auto4SErp.Properties.Resources.save;
            btnPrintAccount.Enabled = false;
            if (status == -1)
            {
                dgRepairItem.ReadOnly = true;

                //   btnRecept.Enabled = false;
                tdrAccount.Enabled = false;
                tdrRecept.Enabled = false;
                cmenuRepairItem.Enabled = false;
                cmenuAcc.Enabled = false;
                btnSave.Text = "开单";
                btnSave.Image = global::Auto4SErp.Properties.Resources.add;
            }
            else if (status == 0)
            {
                dgRepairItem.ReadOnly = false;


                this.Text = "维修单--开单";
                tbtnRecept.Enabled = true;
                tbtnUnRecept.Enabled = false;
                tdrAccount.Enabled = false;
                cmenuRepairItem.Enabled = true;
                cmenuAcc.Enabled = true;
                //btnSave.Enabled = true;
                btnPrintRep.Enabled = false;

            }
            else if (status == 1)
            {

                dgRepairItem.ReadOnly = false;
                this.Text = "维修单--接车";
                // btnSave.Enabled = true;
                tbtnRecept.Enabled = false;
                tbtnUnRecept.Enabled = true;

                tbtnPreAccount.Enabled = true;
                tbtnUnPreAccount.Enabled = false;
                cmenuRepairItem.Enabled = true;
                cmenuAcc.Enabled = true;
                btnPrintRep.Enabled = true;

            }
            else if (status == 2)
            {
                dgRepairItem.ReadOnly = true;
                //  btnSave.Enabled = false;
                tdrRecept.Enabled = false;
                tbtnPreAccount.Enabled = false;
                tbtnUnPreAccount.Enabled = true;
                this.Text = "维修单--已预结算";
                cmenuRepairItem.Enabled = false;
                cmenuAcc.Enabled = false;
                btnPrintRep.Enabled = true;
                btnPrintAccount.Enabled = true;

            }

            else if (status == 3)
            {
                dgRepairItem.ReadOnly = false;
                // btnSave.Enabled = false;
                tdrRecept.Enabled = false;
                tbtnPreAccount.Enabled = false;
                tbtnUnPreAccount.Enabled = false;
                this.Text = "维修单--已结算";
                //cmenuRepairItem.Enabled = false;
                JsStatus();
                cmenuAcc.Enabled = false;
                btnPrintRep.Enabled = true;
                btnPrintAccount.Enabled = true;

            }
        }


        private void JsStatus()
        {

            AddItemToolStripMenuItem.Enabled = false;
            DelToolStripMenuItem.Enabled = false;
            ResetItemToolStripMenuItem.Enabled = false;
            ModifyToolStripMenuItem.Enabled = true;
        }

        private void AddtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtDH.Text))
            //    ShowMessage("");
            frmAccessory frm = new frmAccessory();
            frm.IsSelect = true;
            frm.RepChildType = cmbRepChildType.Text;
            //frm.IsCheckAcc = true;
            frm.IsPresent = chbPresent.Checked;
            frm.DH = txtDH.Text;

            frm.setRefreshDelegate(delegate(bool isR)
            {
                //string result = (string)o;
                //string[] strlst = result.Split(',');
                //AccessoryOfRep obj = new AccessoryOfRep();
                //obj.DH = txtDH.Text;
                //obj.AccessoryCode = strlst[0];
                //obj.SalePrice = float.Parse(strlst[1]);
                //obj.FinalPrice = obj.SalePrice;
                //obj.Amount = 1;
                //mIRepairAccessory.AddAccessoryOfRepair(obj);
                RefreshAccssorys();

            });
            frm.ShowDialogEx();
        }

        private void RefreshAccssorys()
        {
            StartWork(txtDH.Text + "," + cmbRepChildType.Text);

            //   StartWork(txtDH.Text);

        }


        private void tbtnRecept_Click(object sender, EventArgs e)
        {
            if (txtPlateNum.Text == "")
            {
                if (!cmbRepChildType.Text.Contains("装潢"))
                {
                    ShowMessage("没有输入车牌号");
                    return;
                }
            }


            if (!cmbRepChildType.Text.Contains("装潢"))
            {
                if (string.IsNullOrEmpty(txtInsuranceCompany.Text))
                {
                    ShowMessage("请选择保险公司");
                    return;
                }

                if (string.IsNullOrEmpty(txtInMil.Text))
                {
                    ShowMessage("请填写进厂里程");
                    return;
                }
            }





            RepairM obj = CreateObjOfValues();
            obj.RepType = cmbRepType.SelectedItem.ToString();
            obj.RepChildType = cmbRepChildType.SelectedItem.ToString();
            //obj.ReceptMan = txtReceptMan.Text;
            //   obj.ReceptTime = "getdate()";
            //txtReceptTime.Text = DateTime.Now.ToString();
            obj.Status = 1;

            mIRepair.UpdateRepair(obj);
            SetStatus(1);
            IsModify = true;
        }

        private void tbtnPreAccount_Click(object sender, EventArgs e)
        {

            if (cmbRepChildType.Text == "索赔" || cmbRepChildType.Text == "免费保养")
            {
                frmDlgAccessAmount frm1 = new frmDlgAccessAmount();
                frm1.DH = txtDH.Text;
                frm1.setRefreshDelegate(delegate(bool IsR)
                {
                    if (IsR)
                        SetStatus(2);

                });
                frm1.ShowDialogEx();
                return;


            }
            bool isAddWork = mIRepair.IsAllfWorkerAdded(txtDH.Text);
            if (isAddWork == false)
            {
                ShowMessage("存在没有添加作业人员的维修项目");
                return;
            }




            frmDlgPreAccount frm = new frmDlgPreAccount();
            frm.DH = txtDH.Text;
            frm.RepChildType = cmbRepChildType.Text;
            frm.Balance = double.Parse(lblBalance.Text);
            frm.Vip = lblVipType.Text;
            frm.setRefreshDelegate(delegate(bool IsR)
            {
                if (IsR)
                    SetStatus(2);

            });
            IsModify = true;
            frm.ShowDialogEx();
            // this.Close();
        }

        private void tbtnUnRecept_Click(object sender, EventArgs e)
        {
            RepairM obj = mIRepair.GetRepairByDH(txtDH.Text);
            if (obj.Status == 1)
            {
                obj.Status = 0;
                mIRepair.SetRepStatus(obj);
                SetStatus(0);
                IsModify = true;
            }
            else
                ShowMessage("单据状态不对");
        }

        private void tbtnUnPreAccount_Click(object sender, EventArgs e)
        {
            RepairM obj = mIRepair.GetRepairByDH(txtDH.Text);
            if (obj.Status == 2)
            {
                obj.Status = 1;
                mIRepair.SetRepStatus(obj);
                SetStatus(1);
                mIFinance.DelAccountOfRep(txtDH.Text);
                IsModify = true;
            }
            else
            {
                ShowMessage("单据状态不对");
            }
        }


        private void AddItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDlgRepItem frm = new frmDlgRepItem();
            frm.DH = txtDH.Text;
            frm.VipNo = txtCardNo.Text;
            frm.Mobile = txtMobile.Text;
            frm.ChiliType = cmbRepChildType.Text;

            frm.setRefreshDelegate(delegate(bool isR)
            {
                if (isR)
                {
                    RefreshRepairItem();
                }

            });
            frm.ShowDialogEx();
        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgRepairItem.SelectedCells.Count != 0)
            {

                DataGridViewCell cell = dgRepairItem.SelectedCells[0];
                int rowindex = cell.RowIndex;

                RepairM objtmp = mIRepair.GetRepairByDH(txtDH.Text);
                int status = objtmp.Status;
                frmDlgRepItem frm = new frmDlgRepItem();
                frm.DH = txtDH.Text;
                frm.Mobile = txtMobile.Text;
                frm.ChiliType = cmbRepChildType.Text;
                if (objtmp.Status == 3)
                    frm.IsSpecial = true;

                //frm.ItemCode = dgRepairItem.Rows[rowindex].Cells["ItemCode"].Value.ToString();
                //frm.PriceId = dgRepairItem.Rows[rowindex].Cells["priceidhide"].Value.ToString();

                repair_iM obj = new repair_iM();
                obj.ItemCode = dgRepairItem.Rows[rowindex].Cells["ItemCode"].Value.ToString();
                // obj.PriceId = dgRepairItem.Rows[rowindex].Cells["priceidhide"].Value.ToString();
                obj.WorkMan = dgRepairItem.Rows[rowindex].Cells["WorkMan"].Value.ToString();
                obj.FaultDescribe = dgRepairItem.Rows[rowindex].Cells["FaultDescribe"].Value.ToString();
                obj.FaultReason = dgRepairItem.Rows[rowindex].Cells["FaultReason"].Value.ToString();
                obj.TypeOfWork = dgRepairItem.Rows[rowindex].Cells["TypeOfWork"].Value.ToString();
                obj.XH = int.Parse(dgRepairItem.Rows[rowindex].Cells["XH"].Value.ToString());
                obj.ItemName = dgRepairItem.Rows[rowindex].Cells["ItemName"].Value.ToString();
                obj.ActWorkH = float.Parse(dgRepairItem.Rows[rowindex].Cells["ActWorkH"].Value.ToString());
                obj.EmpWorkH = float.Parse(dgRepairItem.Rows[rowindex].Cells["EmpWorkH"].Value.ToString());
                obj.WorkHPrice = float.Parse(dgRepairItem.Rows[rowindex].Cells["ItemTotalPrice"].Value.ToString());
                obj.CarLevel = dgRepairItem.Rows[rowindex].Cells["CarLevel"].Value.ToString();
                //obj.FinalPrice = obj.WorkHPrice;
                frm.RepairIM = obj;
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                    {
                        RefreshRepairItem();

                    }

                });
                frm.ShowDialogEx();



            }
        }

        private void dModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (dgAccessory.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgAccessory.SelectedRows[0];
                string xh = dr.Cells[0].Value.ToString();
                string dh = txtDH.Text;
                string name = dr.Cells[3].Value.ToString();
                frmAccDemandDlg frm = new frmAccDemandDlg();
                frm.XH = xh;
                frm.DH = dh;
                frm.AccessoryName = name;
                frm.setRefreshDelegate(delegate(bool isR)
                {
                    if (isR)
                        RefreshAccssorys();


                });
                frm.ShowDialogEx();

            }
        }



        private void DelDemandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgAccessory.SelectedCells.Count > 0)
            {

                DataGridViewCell cell = dgAccessory.SelectedCells[0];
                int rowindex = cell.RowIndex;

                //DataGridViewRow dr = dgAccessory.SelectedRows[0];
                //object oid = dgRepairItem.Rows[mNowRow].Cells[0].Value;

                string xh = dgAccessory.Rows[rowindex].Cells[0].Value.ToString();
                string dh = txtDH.Text;
                //  string name = dgRepairItem.Rows[mNowRow].Cells[3].Value.ToString();

                if (dgAccessory.Rows[rowindex].Cells[1].Value.ToString() == "需求")
                {
                    mIRepairAccessory.DelAccessoryDemand(dh, xh);
                    RefreshAccssorys();
                }




            }
        }

        private void ResetItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDlgResetItemPrice frm = new frmDlgResetItemPrice();
            frm.DH = txtDH.Text;
            frm.setRefreshDelegate(delegate(bool isR)
            {

                RefreshRepairItem();

            });
            frm.ShowDialogEx();
        }

        private void ResetAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDlgResetAccPrice frm = new frmDlgResetAccPrice();
            frm.DH = txtDH.Text;
            frm.setRefreshDelegate(delegate(bool isR)
            {

                RefreshAccssorys();

            });

            frm.ShowDialogEx();
        }


        private void AssinBySaleDH(string dh)
        {
            Bll.Sale.ICarSale mICarSale;
            mICarSale = Bll.BllFactory.GetCarSaleBll();
            System.Data.DataTable dt = mICarSale.GetCarSaleByDH(dh);

            string mobile = dt.Rows[0]["Mobile"].ToString();
            string vin = dt.Rows[0]["vin"].ToString();
            AssinByMobile(mobile);
            txtVin.Text = vin;
            txtDecorateDH.Text = dh;

        }

        private void btnCustomerFind_Click_1(object sender, EventArgs e)
        {


            string userid = Comm.LoginInfoShare.getInstance().UserId;
            //Staff staffobj = mIOperateMan.GetOperateMan(userid);
            string username = Comm.LoginInfoShare.getInstance().UserName;
            if (cmbRepChildType.Text == "销售装潢" && !(username.Contains("二网") || username.Contains("*")))
            {
                frmCarSaleQuery frm = new frmCarSaleQuery();
                //frm.Status = 3;
                frm.IsSelect = true;
                frm.setTransferDelegate(delegate(object obj)
                {
                    string dh = (string)obj;
                    AssinBySaleDH(dh);
                });
                frm.ShowDialogEx();
            }
            else
            {
                frmCustomerQuery frm = new frmCustomerQuery();
                frm.IsSelect = true;
                frm.IsRepair = true;
                string mobile = "";
                string plate = "";
                frm.setTransferDelegate(delegate(object o)
                {
                    string strResult = (string)o;
                    string[] strlst = strResult.Split(',');
                    mobile = strlst[0];
                    plate = strlst[1];

                });
                frm.ShowDialogEx();

                if (!string.IsNullOrEmpty(mobile))
                {
                    AssinByMobile(mobile);
                    AssinByPlate(plate);
                }
            }
        }

        private void DoResultByTransferData(object o)
        {
            string strResult = (string)o;
            string[] strlst = strResult.Split(',');
            string mobile = strlst[0];
            string plate = strlst[1];
            AssinByMobile(mobile);
            AssinByPlate(plate);

        }


        private void cmbRepType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbRepChildType.Items.Clear();
            if (cmbRepType.SelectedIndex == 0)
            {
                cmbRepChildType.Items.Add("一般维修");
                cmbRepChildType.Items.Add("事故维修");
                cmbRepChildType.Items.Add("总成大修");
                cmbRepChildType.Items.Add("免费保养");
                // cmbRepChildType.Items.Add("首保");
                cmbRepChildType.Items.Add("常规保养");
                cmbRepChildType.Items.Add("自费事故维修");
                cmbRepChildType.Items.Add("索赔");
                cmbRepChildType.Items.Add("PDI");
                cmbRepChildType.Items.Add("免费检测");
            }
            else if (cmbRepType.SelectedIndex == 1)
            {
                if (isSaleDecorate)
                {
                    cmbRepChildType.Items.Add("销售装潢");
                    // cmbRepChildType.Items.Add("原厂装潢");
                }
                else
                    cmbRepChildType.Items.Add("售后装潢");
            }
            cmbRepChildType.SelectedIndex = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!mIRepair.DelRepair(txtDH.Text))
                ShowMessage("无法删除，可能状态不对");
            else
            {
                IsModify = true;
                this.Close();
            }
        }

        private void btnGetVin_Click(object sender, EventArgs e)
        {
            string tmp = mICustomer.GetVinOfCustomer(txtMobile.Text);
            if (!string.IsNullOrEmpty(tmp))
                txtVin.Text = tmp;
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {


            if (isSaleDecorate == false)
            {
                frmRepCustomerEdit frm = new frmRepCustomerEdit();
                if (!string.IsNullOrEmpty(txtPlateNum.Text))
                    frm.PlateNum = txtPlateNum.Text;
                frm.Mobile = txtMobile.Text;
                frm.setTransferDelegate(d => DoResultByTransferData(d));
                frm.ShowDialogEx();
            }
            else
            {
                frmCustomerEdit frm = new frmCustomerEdit();


                frm.ShowDialogEx();

            }
        }




        private void btnPrintRep_Click(object sender, EventArgs e)
        {

            PrintWTS();


            //  DataTable dtAppend = new DataTable();
            //  dtAppend.Columns.Add("CustName", typeof(string));
            //  dtAppend.Columns.Add("DH", typeof(string));
            //  dtAppend.Columns.Add("Vin", typeof(string));
            //  dtAppend.Columns.Add("PlateNum", typeof(string));
            //  dtAppend.Columns.Add("Address", typeof(string));
            //  dtAppend.Columns.Add("CarBrand", typeof(string));
            //  dtAppend.Columns.Add("CarModel", typeof(string));
            //  dtAppend.Columns.Add("RepType", typeof(string));
            //  dtAppend.Columns.Add("ReceptMan", typeof(string));
            //  dtAppend.Columns.Add("Mobile", typeof(string));
            //  dtAppend.Columns.Add("ReceptTime", typeof(string));
            //  dtAppend.Columns.Add("ItemSum", typeof(float));
            //  dtAppend.Columns.Add("AccSum", typeof(float));

            //  dtAppend.Columns.Add("InMil", typeof(string));
            //  dtAppend.Columns.Add("NextKeepMil", typeof(string));
            //  dtAppend.Columns.Add("NextKeepDate", typeof(string));
            //  dtAppend.Columns.Add("KeepBegin", typeof(string));
            //  dtAppend.Columns.Add("KeepEnd", typeof(string));
            //  dtAppend.Columns.Add("EstimateComplete", typeof(string));
            // // dtAppend.Columns.Add("TotalSum", typeof(float));

            //  float itemsum = mIRepair.GetItemAmountOfDH(dH);
            //  float accsum = mIRepair.GetAccAmountOfDH(dH);
            //  float totalsum = itemsum + accsum;
            //  DataRow dr = dtAppend.NewRow();
            //  dr[0] = txtCustName.Text;
            //  dr[1] = txtDH.Text;
            //  dr[2] = txtVin.Text;
            //  dr[3] = txtPlateNum.Text;
            //  dr[4] = txtAddress.Text;
            //  dr[5] = txtCarBrand.Text;
            //  dr[6] = txtCarModel.Text;
            //  dr[7] = cmbRepChildType.Text;
            //  dr[8] = txtSendRepMan.Text;
            //  dr[9] = txtMobile.Text;
            //  dr[10] = txtReceptTime.Text;
            //  dr[11] = itemsum;
            //  dr[12] = accsum;
            //  dr[13] = txtInMil.Text;
            //  dr[14] = txtNextKeepMil.Text;
            //  dr[15] = datNextKeepDate.Value;
            //  dr[16] = datKeepBegin.Value;
            //  dr[17] = datKeepEnd.Value;
            //  dr[18] = dtpEstimateComplete.Value;
            //  //double tmpsum;
            //  //tmpsum = Math.Round((double)totalsum, MidpointRounding.AwayFromZero);
            //  //dr[18] = tmpsum;

            //  dtAppend.Rows.Add(dr);

            //  Dictionary<string, DataTable> dic = new Dictionary<string, DataTable>();

            ////  DataTable dtAcc = mIRepairAccessory.GetAccessorysOfTakePrint(txtDH.Text);

            //  DataTable dtItem = mIRepair.GetItemsOfDH(txtDH.Text);
            ////  dic.Add("RepAccessory", dtAcc);
            //  dic.Add("Repair", dtAppend);
            //  dic.Add("RepItem", dtItem);
            //  frmPrint frm = new frmPrint();
            //  //frm.DataSource = dt;
            //  //frm.SourceName = "RepAccessory";
            //  frm.DicTable = dic;
            //  frm.ReportFile = "RepairDele.rdlc";
            //  frm.ShowDialog();
        }
        private void btnPrintDemand_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = mIRepairAccessory.GetAccessorysOfRepairAsDemand(txtDH.Text);

            if (dt.Rows.Count <= 0)
            {
                ShowMessage("没有领料需求");
                return;

            }
            System.Data.DataTable dtAppend = new System.Data.DataTable();
            dtAppend.Columns.Add("CustName", typeof(string));
            dtAppend.Columns.Add("DH", typeof(string));
            dtAppend.Columns.Add("Vin", typeof(string));

            DataRow dr = dtAppend.NewRow();
            dr[0] = txtCustName.Text;
            dr[1] = txtDH.Text;
            dr[2] = txtVin.Text;

            dtAppend.Rows.Add(dr);

            Dictionary<string, System.Data.DataTable> dic = new Dictionary<string, System.Data.DataTable>();
            dic.Add("RepAccessory", dt);
            dic.Add("Append", dtAppend);

            frmPrint frm = new frmPrint();
            //frm.DataSource = dt;
            //frm.SourceName = "RepAccessory";
            frm.DicTable = dic;
            frm.ReportFile = "SaleDecorateAcc.rdlc";
            frm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblDH_Click(object sender, EventArgs e)
        {

        }

        private void txtVin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtDH.Text == "")
            {
                ShowMessage("没有生成单号");
                return;

            }

            mIRepair.ModifyCustNameOfRepair(txtDH.Text, txtCustName.Text);
        }

        private void btnRepAccount_Click(object sender, EventArgs e)
        {
            PrintJSD();
            //System.Data.DataTable dtAppend = new System.Data.DataTable();
            //dtAppend.Columns.Add("CustName", typeof(string));
            //dtAppend.Columns.Add("DH", typeof(string));
            //dtAppend.Columns.Add("Vin", typeof(string));
            //dtAppend.Columns.Add("PlateNum", typeof(string));
            //dtAppend.Columns.Add("Address", typeof(string));
            //dtAppend.Columns.Add("CarBrand", typeof(string));
            //dtAppend.Columns.Add("CarModel", typeof(string));
            //dtAppend.Columns.Add("RepType", typeof(string));
            //dtAppend.Columns.Add("ReceptMan", typeof(string));
            //dtAppend.Columns.Add("Mobile", typeof(string));
            //dtAppend.Columns.Add("ReceptTime", typeof(string));
            //dtAppend.Columns.Add("ItemSum", typeof(float));
            //dtAppend.Columns.Add("AccSum", typeof(float));

            //dtAppend.Columns.Add("InMil", typeof(string));
            //dtAppend.Columns.Add("NextKeepMil", typeof(string));
            //dtAppend.Columns.Add("NextKeepDate", typeof(string));
            //dtAppend.Columns.Add("KeepBegin", typeof(string));
            //dtAppend.Columns.Add("KeepEnd", typeof(string));
            //dtAppend.Columns.Add("TotalSum", typeof(float));

            //float itemsum = mIRepair.GetItemAmountOfDH(dH);
            //float accsum = mIRepair.GetAccAmountOfDH(dH);
            //float totalsum = itemsum + accsum;
            //DataRow dr = dtAppend.NewRow();
            //dr[0] = txtCustName.Text;
            //dr[1] = txtDH.Text;
            //dr[2] = txtVin.Text;
            //dr[3] = txtPlateNum.Text;
            //dr[4] = txtAddress.Text;
            //dr[5] = txtCarBrand.Text;
            //dr[6] = txtCarModel.Text;
            //dr[7] = cmbRepChildType.Text;
            //dr[8] = txtSendRepMan.Text;
            //dr[9] = txtMobile.Text;
            //dr[10] = txtReceptTime.Text;
            //dr[11] = itemsum;
            //dr[12] = accsum;
            //dr[13] = txtInMil.Text;
            //dr[14] = txtNextKeepMil.Text;
            //dr[15] = datNextKeepDate.Value;
            //dr[16] = datKeepBegin.Value;
            //dr[17] = datKeepEnd.Value;
            //double tmpsum;
            //tmpsum = Math.Round((double)totalsum, MidpointRounding.AwayFromZero);
            //dr[18] = tmpsum;

            //dtAppend.Rows.Add(dr);

            //Dictionary<string, System.Data.DataTable> dic = new Dictionary<string, System.Data.DataTable>();

            //System.Data.DataTable dtAcc = mIRepairAccessory.GetAccessorysOfTakePrint(txtDH.Text, "0");

            //System.Data.DataTable dtItem = mIRepair.GetItemsOfDH(txtDH.Text);
            //dic.Add("RepAccessory", dtAcc);
            //dic.Add("Repair", dtAppend);
            //dic.Add("RepItem", dtItem);
            //frmPrint frm = new frmPrint();
            ////frm.DataSource = dt;
            ////frm.SourceName = "RepAccessory";
            //frm.DicTable = dic;
            //frm.ReportFile = "Repair.rdlc";
            //frm.ShowDialog();
        }
        //private void dgRepairItem_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        //{
        //    //string strvalue = dgRepairItem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        //    //dgResult.DataSource = mIRepairItem.GetRepariItemBySpell(strvalue);
        //   // dgRepairItem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
        //  //  mNowRow = e.RowIndex;
        //    //mNowColumn = e.ColumnIndex;
        //    //timer1.Enabled = true;
        //}

        //private void dgRepairItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{

        //  //  dgRepairItem.DataSource = mIRepairItem.GetRepariItemBySpell("gl");

        //    //if (e.RowIndex >= mRows)
        //    //{
        //    //    Thread thread = new Thread(WorkAfterEdit);
        //    //    thread.Start();
        //    //}

        //    //dgRepairItem.Rows[e.RowIndex].Cells[0].Value = mItemCodeTemp;
        //   // dgRepairItem.Rows[e.RowIndex].Cells[1].Value = mItemNameTemp;
        //  //  if (e.ColumnIndex!=1) dgRepairItem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
        //   // mNowRow = e.RowIndex;
        //    ////timer1.Enabled = false;

        //    //if(e.ColumnIndex==6)
        //    //{
        //    //   string carlevel=  dgRepairItem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        //    //   string itemcode = dgRepairItem.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    //   string xh = dgRepairItem.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    //   mIRepair.UpdateRepairItemPrice(txtDH.Text,xh,itemcode,carlevel);
        //    //   WorkAfterEdit();
        //    //}
        //}


        //private void WorkAfterEdit()
        //{
        //    this.BeginInvoke((MethodInvoker)delegate()
        //     {

        //         //if (mAddRow != 0)
        //         //{
        //         //    dgRepairItem.Rows.RemoveAt(mAddRow - 1);
        //         //    mAddRow = 0;
        //         //}
        //         RefreshRepairItem();

        //     });
        //}


        //private void dgRepairItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{


        //        if (e.Control is TextBox)
        //        {
        //            TextBox tb = e.Control as TextBox;
        //            //  tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        //          //  tb.TextChanged += new EventHandler(tb_TextChanged);
        //            mNowTextBox = tb;
        //        }


        //}


        //private void tb_TextChanged(object sender, EventArgs e)
        //{

        //    if (mNowColumn == 0)
        //    {
        //        TextBox tb = (TextBox)sender;
        //        dgResult.DataSource = mIRepairItem.GetRepariItemBySpell(tb.Text);
        //        dgResult.Visible = true;

        //    }

        //}

        //private void dgResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgResult.SelectedRows.Count != 0)
        //    {

        //        DataGridViewRow seldr = dgResult.SelectedRows[0];
        //        string ItemCodeTemp = seldr.Cells[0].Value.ToString();
        //        string ItemNameTemp = seldr.Cells[1].Value.ToString();
        //        string ItemPriceIDTemp = seldr.Cells[2].Value.ToString();
        //        //DataRow dr = mDtTemp.NewRow();
        //        //dr["itemname"] = strbh;
        //        //mDtTemp.Rows.Add(dr);
        //        ////dgRepairItem.DataSource = mDtTemp;

        //        //mRows = mDtTemp.Rows.Count;

        //        object oid = dgRepairItem.Rows[mNowRow].Cells[0].Value;
        //        if (oid == null || oid.ToString() == "")
        //        {
        //            mIRepair.AddItemOfRepair(txtDH.Text, ItemCodeTemp, ItemPriceIDTemp);
        //            //dgRepairItem.Rows[mNowRow].Cells[1].Value = mItemCodeTemp;
        //            // dgRepairItem.Rows[mNowRow].Cells[0].Value = idNew;
        //             RefreshRepairItem();
        //        }
        //        else
        //        {
        //            mIRepair.UpdateItemOfRepair(txtDH.Text, oid.ToString(), ItemCodeTemp, int.Parse(ItemPriceIDTemp));
        //            RefreshRepairItem();

        //        }
        //     //   dgRepairItem.Rows[mNowRow].Cells[2].Value = mItemNameTemp;




        //        dgResult.Visible = false;
        //        dgResult.DataSource = null;
        //    }
        //}


        //private void SetCellStyle(Excel.Application excel, int row1, int column1, int row2, int column2, int Merge, int Size, string FontName, string HorizontalAlignment, int LineStyle, object color, int ColumnWidth, int RowHeight)
        //{

        //    Excel.Range range = excel.Range[excel.Cells[row1, column1], excel.Cells[row2, column2]];
        //    if (Merge == 0)
        //    {
        //        range.Merge(0);
        //    }
        //    range.Font.Size = Size;//字体大小
        //    range.Font.Name = FontName; //字体
        //    if (HorizontalAlignment == "center")
        //    {
        //        range.HorizontalAlignment = XlHAlign.xlHAlignCenter;//文字对齐
        //    }
        //    else if (HorizontalAlignment == "left")
        //    {
        //        range.HorizontalAlignment = XlHAlign.xlHAlignLeft;//文字对齐
        //    }
        //    else if (HorizontalAlignment == "right")
        //    {
        //        range.HorizontalAlignment = XlHAlign.xlHAlignRight;//文字对齐
        //    }
        //    else if (HorizontalAlignment == "justify")
        //    {
        //        range.HorizontalAlignment = XlHAlign.xlHAlignJustify;//文字对齐
        //    }
        //    else if (HorizontalAlignment == "general")
        //    {
        //        range.HorizontalAlignment = XlHAlign.xlHAlignGeneral;//文字对齐
        //    }

        //    if (LineStyle == 0)
        //    {
        //        range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlLineStyleNone;//边框
        //    }
        //    else
        //    {
        //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, System.Drawing.Color.Black.ToArgb());
        //    }
        //    if (color != null)
        //    {
        //        range.Cells.Interior.Color = color; //背景
        //    }

        //    // range.Cells.Interior.Color = System.Drawing.Color.FromArgb(0, 0, 0).ToArgb(); //背景
        //    if (ColumnWidth > 0)
        //    {
        //        range.ColumnWidth = ColumnWidth;
        //    }


        //    if (RowHeight > 0)
        //    {
        //        range.RowHeight = RowHeight;
        //    }


        //}
        public void PrintWTS()
        {
            reportWT report = new reportWT();
            report.ItemTable = dgRepairItem.DataSource as System.Data.DataTable;
            report.DH = txtDH.Text;
            report.CompanyInfo = CompanyInfo;
            report.CarColor = txtColor.Text;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();

            //return;

            ////    Excel.Range r = mySheet.get_Range(mySheet.Cells[3, 1], mySheet.Cells[14, 7]);
            ////    Excel.Range r = mySheet.get_Range(mySheet.Cells[3, 1], mySheet.Cells[14, 7]);
            //Excel.Application excel = new Excel.Application();
            //excel.Application.Workbooks.Add(true);
            //excel.Visible = true;
            //int gray1 = System.Drawing.Color.FromArgb(223, 223, 223).ToArgb();
            //int gray2 = System.Drawing.Color.FromArgb(223, 223, 223).ToArgb();
            //int row = 1;
            //excel.Cells[row, 8] = "维修委托书";
            //SetCellStyle(excel, row, 1, row, 8, 0, 16, "黑体", "center", 0, null, 0, 0);
            //row = row + 1;

            //excel.Cells[row, 1] = "维修委托书号码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "NO.";
            //excel.Cells[row, 2] = txtDH.Text;

            //SetCellStyle(excel, row, 2, row, 2, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "委托书打印时间";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = DateTime.Now.Year + " 年";
            //SetCellStyle(excel, row, 4, row, 4, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = DateTime.Now.Month + " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = DateTime.Now.Day + " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = DateTime.Now.Hour + "  时";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = DateTime.Now.Minute + " 分";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "车辆所有者";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = txtCustName.Text ;

            //excel.Cells[row, 5] = "联系电话";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 6] =txtMobile.Text;

            //excel.Cells[row, 7] = "其他联系方式";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "送修客户";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] =txtSendRepMan.Text;

            //excel.Cells[row, 5] = "联系电话";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 6] = txtSendRepTel.Text;

            //excel.Cells[row, 7] = "其他联系方式";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "邮寄地址";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 6, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 7] = "邮政编码";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "车牌号码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 2] =txtPlateNum.Text ;

            //excel.Cells[row, 3] = "车型号";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 4] = txtCarModel.Text;

            //excel.Cells[row, 5] = "车身颜色";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 6] = txtColor.Text;

            //excel.Cells[row, 7] = "行驶里程";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 8] = txtInMil.Text + " Km";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "车辆识别码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 6, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = txtVin.Text;


            //excel.Cells[row, 7] = "索赔单号码";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "发动机号码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "销售日期";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = DateTime .Parse(txtReceptTime.Text).Year.ToString() + " 年";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = DateTime .Parse(txtReceptTime.Text).Month.ToString() + " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] =  DateTime .Parse(txtReceptTime.Text).Day.ToString()+ " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = "PWA号码";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "上次服务结算单";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "NO.";
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "上次进店日期";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = dtpEstimateComplete.Value.Year + " 年";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = " 时";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 分";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "客户主述";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "诊断结果";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "维修项目";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "已经确认□";//■□
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "预计交车时间";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = dtpEstimateComplete.Value.Year  + " 年";

            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = dtpEstimateComplete.Value.Month + " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = dtpEstimateComplete.Value.Day  + " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = " 时";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 分";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "变更项目";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "已经确认□";//■□
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "变更交车时间";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = " 年";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = " 时";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 分";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "维修代码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "维修项目";
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 3] = "维修类型";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = " 预计工时费";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 5] = "配件编号";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 6] = "配件名称";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 7] = "配件数量";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 8] = "预计配件费";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //row++;

            ////循环显示具体项目

            //System.Data.DataTable dtItem = dgRepairItem.DataSource as System.Data.DataTable;
            //for (int i = 0; i < dtItem.Rows.Count;i++ )
            //{
            //    //维修项目代码
            //    excel.Cells[row, 1] =dtItem.Rows[i]["itemcode"].ToString().Trim();
            //    SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, null, 11, 0);

            //    //维修代码名称
            //    excel.Cells[row, 2] = dtItem.Rows[i]["itemName"];
            //    SetCellStyle(excel, row, 2, row, 1, 1, 9, "宋体", "center", 1, null, 11, 0);

            //    //价类
            //    excel.Cells[row, 3] = dtItem.Rows[i]["pricetype"];
            //    SetCellStyle(excel, row, 3, row, 1, 1, 9, "宋体", "center", 1, null, 11, 0);

            //    //项目金额
            //    excel.Cells[row, 4] = dtItem.Rows[i]["finalprice"];
            //    SetCellStyle(excel, row, 4, row, 1, 1, 9, "宋体", "center", 1, null, 11, 0);

            //    excel.Cells[row, 5] = "";
            //    SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, null, 11, 0);
            //    excel.Cells[row, 6] = "";
            //    SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            //    excel.Cells[row, 7] = "";
            //    SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, null, 11, 0);
            //    excel.Cells[row, 8] = "";
            //    SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //    row++;

            //}


            ////excel.Cells[row, 1] = "";
            ////SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 2] = "1";
            ////SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 3] = "";
            ////SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 4] = " ";
            ////SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 5] = "";
            ////SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 6] = "";
            ////SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 7] = "";
            ////SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 8] = "";
            ////SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////row++;

            ////excel.Cells[row, 1] = "";
            ////SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 2] = "";
            ////SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 3] = "2";
            ////SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 4] = " ";
            ////SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 5] = "";
            ////SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 6] = "";
            ////SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 7] = "";
            ////SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 8] = "";
            ////SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////row++;

            ////excel.Cells[row, 1] = "";
            ////SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 2] = "";
            ////SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 3] = "3";
            ////SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 4] = " ";
            ////SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 5] = "";
            ////SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 6] = "";
            ////SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 7] = "";
            ////SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 8] = "";
            ////SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////row++;


            //excel.Cells[row, 1] = "预计工时费小计";
            //SetCellStyle(excel, row, 1, row, 2, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 3] = txtPreItemAmount.Text + " 元";
            //SetCellStyle(excel, row, 3, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = "预计配件费小计";
            //SetCellStyle(excel, row, 5, row, 6, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 7] = " 元";
            //SetCellStyle(excel, row, 7, row, 8, 0, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "预计服务费总计";
            //SetCellStyle(excel, row, 1, row, 6, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 7] = " 元";
            //SetCellStyle(excel, row, 7, row, 8, 0, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 8] = "";
            //SetCellStyle(excel, row, 1, row, 8, 0, 16, "黑体", "center", 1, null, 0, 5);
            //row++;

            //excel.Cells[row, 1] = "维修技师备注和建议增加事项";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "justify", 1, gray2, 11, 0);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 38);
            //row++;

            //excel.Cells[row, 1] = "维修代码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 2] = "增加维修项目";
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 3] = "维修类型";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 4] = " 预计工时费";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 5] = "配件编号";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 6] = "增加配件名称";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 7] = "配件数量";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 8] = "预计配件费";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, gray2, 11, 0);
            //row++;

            ////循环显示具体项目
            //excel.Cells[row, 1] = "";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = "";
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 3] = "";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 4] = " ";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 5] = "";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 6] = "";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 7] = "";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 8] = "";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            ////excel.Cells[row, 1] = "";
            ////SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 2] = "";
            ////SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 3] = "";
            ////SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 4] = " ";
            ////SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 5] = "";
            ////SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 6] = "";
            ////SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 7] = "";
            ////SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 8] = "";
            ////SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////row++;

            ////excel.Cells[row, 1] = "";
            ////SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 2] = "";
            ////SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 3] = "";
            ////SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 4] = " ";
            ////SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 5] = "";
            ////SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 6] = "";
            ////SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 7] = "";
            ////SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////excel.Cells[row, 8] = "";
            ////SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            ////row++;


            //excel.Cells[row, 1] = "预计增加工时小计";
            //SetCellStyle(excel, row, 1, row, 2, 0, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 3] = " 元";
            //SetCellStyle(excel, row, 3, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = "预计增加配件费小计";
            //SetCellStyle(excel, row, 5, row, 6, 0, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 7] = " 元";
            //SetCellStyle(excel, row, 7, row, 8, 0, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "预计增加服务费总计";
            //SetCellStyle(excel, row, 1, row, 6, 0, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 7] = " 元";
            //SetCellStyle(excel, row, 7, row, 8, 0, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "送修客户确认";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray2, 11, 0);
            //excel.Cells[row, 2] = "确认增加□";//■□
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "不同意增加□";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 4] = "下次进店维修□";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 5] = "送修客户签字";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray2, 11, 0);
            //SetCellStyle(excel, row, 6, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 8] = "";
            //SetCellStyle(excel, row, 1, row, 8, 0, 16, "黑体", "center", 1, null, 0, 5);
            //row++;

            //excel.Cells[row, 1] = "客户等候方式";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "店内等候□";//■□
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "离店等候□";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 4] = "需要代步服务□";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 5] = "客户付款方式";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 6] = "现金□";
            //SetCellStyle(excel, row, 6, row, 6, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 7] = "信用卡□";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 8] = "其他:";
            //SetCellStyle(excel, row, 8, row, 8, 0, 9, "宋体", "left", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "非索赔旧件处理";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "客户带走□";//■□
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "店内保留□";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 4] = "保留(    )天";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 5] = "清洗车辆";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 6] = "无需清洗□";
            //SetCellStyle(excel, row, 6, row, 6, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 7] = "需要清洗□";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 8] = "其他:";
            //SetCellStyle(excel, row, 8, row, 8, 0, 9, "宋体", "left", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "预计费说明";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "预计费用是估算的费用,实际费用以服务结算单中的最终的费用为准.";
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "取车提示";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "客户凭此委托书领取车辆,请您妥善保管,领取车辆时,请您出示此维修委托书并且交给服务顾问.";
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "服务顾问签字";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 5] = "送修客户签字";
            //SetCellStyle(excel, row, 5, row, 5, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "维修开始";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "已经确认□";//■□
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "实际开始时间";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 4] = " 年";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = " 时";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 分";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "维修完工";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "已经确认□";//■□
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "实际完工时间";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 4] = " 年";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = " 时";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 分";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "维修技师签字";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 5] = "洗车专员签字";
            //SetCellStyle(excel, row, 5, row, 5, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "质量检验结果";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "检验合格,准备交车□";
            //SetCellStyle(excel, row, 2, row, 3, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 4] = "经技术经理监督维修过程□";
            //SetCellStyle(excel, row, 4, row, 5, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 6] = "由技术经理指导后再进行维修□";
            //SetCellStyle(excel, row, 6, row, 7, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 8] = "其他:";
            //SetCellStyle(excel, row, 8, row, 8, 0, 9, "宋体", "left", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "质量检测说明";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 40);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 40);
            //row++;

            //excel.Cells[row, 1] = "技术经理签字";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 5] = "质量检验员签字";
            //SetCellStyle(excel, row, 5, row, 5, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "维修质量保证";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 8] = "";
            //SetCellStyle(excel, row, 1, row, 8, 0, 16, "黑体", "center", 1, null, 0, 5);
            //row++;

            //excel.Cells[row, 1] = "公司名称";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 6, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = CompanyInfo.CompanyName;

            //excel.Cells[row, 7] = "邮政编码";
            //SetCellStyle(excel, row, 7, row, 7, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "公司地址";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = CompanyInfo.CompanyAddress;
            //row++;

            //excel.Cells[row, 1] = "服务热线";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = CompanyInfo.TelePhone;

            //excel.Cells[row, 3] = "预约电话";
            //SetCellStyle(excel, row, 3, row, 3, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 4] = CompanyInfo.TelePhone;

            //excel.Cells[row, 5] = "救援电话";
            //SetCellStyle(excel, row, 5, row, 5, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 6, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 6] = CompanyInfo.TelePhone;

            //excel.Cells[row, 7] = "投诉电话";
            //SetCellStyle(excel, row, 7, row, 7, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 8] = "968895";
            //row++;
            ////excel.Quit();
            ////excel = null;
            ////GC.Collect();//垃圾回收   


        }


        public void PrintJSD()
        {
            reportJS report = new reportJS();
            report.ItemTable = dgRepairItem.DataSource as System.Data.DataTable;
            report.AccTable = dgAccessory.DataSource as System.Data.DataTable;
            report.DH = txtDH.Text;
            report.CompanyInfo = CompanyInfo;
            report.CarColor = txtColor.Text;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();


            //return;
            //Excel.Application excel = new Excel.Application();
            //excel.Application.Workbooks.Add(true);
            //excel.Visible = true;
            //int gray1 = System.Drawing.Color.FromArgb(223, 223, 223).ToArgb();
            //int row = 1;
            //excel.Cells[row, 8] = "服务结算单";
            //SetCellStyle(excel, row, 1, row, 8, 0, 16, "黑体", "center", 0, null, 0, 0);
            //row = row + 1;

            //excel.Cells[row, 1] = "服务结算单号码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "NO." + txtDH.Text;
            //SetCellStyle(excel, row, 2, row, 2, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "结算单打印时间";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = DateTime.Now.Year + " 年";
            //SetCellStyle(excel, row, 4, row, 4, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = DateTime.Now.Month + " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = DateTime.Now.Day + " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = DateTime.Now.Hour + "  时";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = DateTime.Now.Minute + " 分";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "车辆所有者";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = txtCustName.Text ;

            //excel.Cells[row, 5] = "联系电话";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row,6] = txtMobile.Text ;

            //excel.Cells[row, 7] = "其他联系方式";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "送修客户";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] =txtSendRepMan.Text ;
            //excel.Cells[row, 5] = "联系电话";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 6] = txtSendRepTel.Text;

            //excel.Cells[row, 7] = "其他联系方式";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "邮寄地址";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 6, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 7] = "邮政编码";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "车牌号码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 2] =txtPlateNum.Text;

            //excel.Cells[row, 3] = "车牌型号";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 4] =txtCarModel.Text ;

            //excel.Cells[row, 5] = "车身颜色";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 6] = txtColor.Text;

            //excel.Cells[row, 7] = "行驶里程";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 8] = txtInMil.Text + " Km";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "车辆识别码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 6, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = txtVin.Text;

            //excel.Cells[row, 7] = "索赔单号码";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "发动机号码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "销售日期";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = DateTime .Parse(txtReceptTime.Text).Year.ToString()+" 年";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] =DateTime .Parse(txtReceptTime.Text).Month.ToString()+ " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] =DateTime .Parse(txtReceptTime.Text).Day.ToString()+ " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = "PWA号码";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "维修委托书号码";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "NO.";
            //SetCellStyle(excel, row, 2, row, 2, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "委托书打印时间";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = " 年";
            //SetCellStyle(excel, row, 4, row, 4, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = DateTime.Now.Hour + "  时";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 分";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "取车凭证";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "已经回收□";
            //SetCellStyle(excel, row, 2, row, 2, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "实际交车时间";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = " 年";
            //SetCellStyle(excel, row, 4, row, 4, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = " 月";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = " 日";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = "  时";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 分";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;



            ////循环显示具体项目
            //System.Data.DataTable dtItem = dgRepairItem.DataSource as System.Data.DataTable;
            //System.Data.DataTable dtAcc = dgAccessory.DataSource as System.Data.DataTable;
            //RepairM repobj=mIRepair.GetRepairByDH(txtDH.Text);
            //string all="0";
            //if (repobj != null)
            //    all = repobj.GAmount.ToString();

            //int itemcount = dtItem.Rows.Count;
            //int acccount = dtAcc.Rows.Count;
            ////int count;
            ////if (itemcount >= acccount)
            ////    count = itemcount;
            ////else
            ////    count = acccount;
            //excel.Cells[row, 1] = "维修代码";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "维修项目";
            //SetCellStyle(excel, row, 2, row,6, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 7] = "维修类型";
            //SetCellStyle(excel, row, 7, row,7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 8] = " 工时费";
            //SetCellStyle(excel, row,8, row,8, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //row++;


            //for (int i = 0; i < itemcount; i++)
            //{
            //    //维修项目代码
            //    //if (i < itemcount)
            //    //{
            //        excel.Cells[row, 1] = dtItem.Rows[i]["itemcode"].ToString().Trim();
            //        SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, null, 11, 0);

            //        //维修代码名称
            //        excel.Cells[row, 3] = dtItem.Rows[i]["itemName"];
            //        SetCellStyle(excel, row, 2, row, 6, 0, 9, "宋体", "center", 1, null, 11, 0);

            //        //价类
            //        excel.Cells[row, 7] = dtItem.Rows[i]["pricetype"];
            //        SetCellStyle(excel, row, 7, row,7, 1, 9, "宋体", "center", 1, null, 11, 0);

            //        //项目金额
            //        excel.Cells[row, 8] = dtItem.Rows[i]["finalprice"];
            //        SetCellStyle(excel, row, 8, row,8, 1, 9, "宋体", "center", 1, null, 11, 0);

            //    //}

            //    //if (i < acccount)
            //    //{
            //    //    excel.Cells[row, 5] = dtAcc.Rows[i]["accessorycode"];
            //    //    SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, null, 11, 0);

            //    //    excel.Cells[row, 6] = dtAcc.Rows[i]["accessoryname"];
            //    //    SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, null, 11, 0);

            //    //    excel.Cells[row, 7] = dtAcc.Rows[i]["amount"];
            //    //    SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, null, 11, 0);

            //    //    excel.Cells[row, 8] = dtAcc.Rows[i]["sum1"];
            //    //    SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);
            //    //}
            //        row++;

            //}




            //excel.Cells[row, 1] = "配件编号";
            //SetCellStyle(excel, row, 1, row, 2, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = "配件名称";
            //SetCellStyle(excel, row, 3, row, 6, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 7] = "配件数量";
            //SetCellStyle(excel, row, 7, row,7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 8] = "配件费";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //row++;



            //for (int i = 0; i < acccount; i++)
            //{

            //    excel.Cells[row, 1] = dtAcc.Rows[i]["accessorycode"];
            //    SetCellStyle(excel, row, 1, row, 2, 0, 9, "宋体", "center", 1, null, 11, 0);

            //    excel.Cells[row, 4] = dtAcc.Rows[i]["accessoryname"];
            //    SetCellStyle(excel, row, 3, row,6, 0, 9, "宋体", "center", 1, null, 11, 0);

            //    excel.Cells[row,7] = dtAcc.Rows[i]["amount"];
            //    SetCellStyle(excel, row, 7, row,7, 1, 9, "宋体", "center", 1, null, 11, 0);

            //    excel.Cells[row, 8] = dtAcc.Rows[i]["sum1"];
            //    SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, null, 11, 0);

            //    row++;

            //}


            //excel.Cells[row, 1] = "结算工时费小计";
            //SetCellStyle(excel, row, 1, row, 2, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 3] =txtPreItemAmount.Text +" 元";
            //SetCellStyle(excel, row, 3, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] ="结算配件费小计";
            //SetCellStyle(excel, row, 5, row, 6, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 7] = txtPreAccessoryAmount.Text + " 元";
            //SetCellStyle(excel, row, 7, row, 8, 0, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "结算服务费总计";
            //SetCellStyle(excel, row, 1, row, 6, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 7] = all+ " 元";
            //SetCellStyle(excel, row, 7, row, 8, 0, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "服务费用说明";
            //SetCellStyle(excel, row, 1, row, 2, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 3] = "结算金额";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = " 优惠金额";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 5] = "优惠后金额";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 6] = "应收金额";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 7] = "实收金额";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 8] = "欠收金额";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "工时费小计";
            //SetCellStyle(excel, row, 1, row, 2, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 3] = " 元";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 4] = "  元";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = " 元";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = " 元";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = txtPreItemAmount.Text + " 元";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 元";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "配件费小计";
            //SetCellStyle(excel, row, 1, row, 2, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 3] = " 元";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 4] = "  元";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = " 元";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = " 元";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] =txtPreAccessoryAmount.Text + " 元";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 元";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "其他费小计";
            //SetCellStyle(excel, row, 1, row, 2, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 3] = " 元";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 4] = "  元";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = " 元";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = " 元";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = " 元";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 元";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "服务费总计";
            //SetCellStyle(excel, row, 1, row, 2, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 3] = " 元";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 4] = "  元";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = " 元";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 6] = " 元";
            //SetCellStyle(excel, row, 6, row, 6, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = all+  " 元";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 元";
            //SetCellStyle(excel, row, 8, row, 8, 1, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "客户付款方式";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "现金□";
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "信用卡□";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 4] = "其他:";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 5] = "开具发票说明";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 6] = "已开具发票□";//■□
            //SetCellStyle(excel, row, 6, row, 6, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 7] = "没开具发票□";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 8] = "其他:";
            //SetCellStyle(excel, row, 8, row, 8, 0, 9, "宋体", "left", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "下次进店提示";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "已经确认□";
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "预计行驶里程";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 4] = " Km";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 5] = "预计开店时间";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 6] = " 年";//■□
            //SetCellStyle(excel, row, 6, row, 6, 0, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 7] = " 月";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "right", 1, null, 11, 0);
            //excel.Cells[row, 8] = " 日";
            //SetCellStyle(excel, row, 8, row, 8, 0, 9, "宋体", "right", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "建议服务项目";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 40);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 40);
            //row++;

            //excel.Cells[row, 1] = "使用注意事项";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 40);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 40);
            //row++;

            //excel.Cells[row, 1] = "首选回访时间";
            //SetCellStyle(excel, row, 1, row, 1, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 2] = "上午□";
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 3] = "下午□";
            //SetCellStyle(excel, row, 3, row, 3, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 4] = "其他:";
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 5] = "首选联系方式";
            //SetCellStyle(excel, row, 5, row, 5, 1, 9, "宋体", "center", 1, gray1, 11, 0);
            //excel.Cells[row, 6] = "电话□";//■□
            //SetCellStyle(excel, row, 6, row, 6, 0, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 7] = "非电话□";
            //SetCellStyle(excel, row, 7, row, 7, 1, 9, "宋体", "left", 1, null, 11, 0);
            //excel.Cells[row, 8] = "其他:";
            //SetCellStyle(excel, row, 8, row, 8, 0, 9, "宋体", "left", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "服务顾问签字";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 5] = "送修客户签字";
            //SetCellStyle(excel, row, 5, row, 5, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 8] = "";
            //SetCellStyle(excel, row, 1, row, 8, 0, 16, "黑体", "center", 1, null, 0, 5);
            //row++;

            //excel.Cells[row, 1] = "公司名称";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 6, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = CompanyInfo.CompanyName;

            //excel.Cells[row, 7] = "邮政编码";
            //SetCellStyle(excel, row, 7, row, 7, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //row++;

            //excel.Cells[row, 1] = "公司地址";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = CompanyInfo.CompanyAddress;

            //row++;

            //excel.Cells[row, 1] = "服务热线";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 2, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] =CompanyInfo.TelePhone;


            //excel.Cells[row, 3] = "预约电话";
            //SetCellStyle(excel, row, 3, row, 3, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 4, row, 4, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 4] = CompanyInfo.TelePhone;

            //excel.Cells[row, 5] = "救援电话";
            //SetCellStyle(excel, row, 5, row, 5, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 6, row, 6, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 5] = CompanyInfo.TelePhone;

            //excel.Cells[row, 7] = "投诉电话";
            //SetCellStyle(excel, row, 7, row, 7, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 8, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 8] = "968895";
            //row++;

            //excel.Cells[row, 1] = "开户银行";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = CompanyInfo.Bank;
            //row++;

            //excel.Cells[row, 1] = "开户名称";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = CompanyInfo.CompanyName;
            //row++;

            //excel.Cells[row, 1] = "银行账号";
            //SetCellStyle(excel, row, 1, row, 1, 0, 9, "宋体", "center", 1, gray1, 11, 0);
            //SetCellStyle(excel, row, 2, row, 8, 0, 9, "宋体", "center", 1, null, 11, 0);
            //excel.Cells[row, 2] = "'" + CompanyInfo.BankAccount;
            //row++;



        }

        private void btnPrintDele_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void cmenuRepairItem_Opening(object sender, CancelEventArgs e)
        {

        }

        private void takeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ExcelInAndOut i = new ExcelInAndOut("");
            i.NewDTOutTo(dgAccessory);

        }

        private void btnClaimOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCalimSure_Click(object sender, EventArgs e)
        {
            Account obj = new Account();
            obj.ID = FinanceID;
            obj.Cash = 0;
            obj.Vip = 0;
            obj.Bank = 0;
            obj.P2P = 0;
            obj.Cs = 0;
            obj.PreRecv = 0;
            obj.Other = 0;
            obj.Check = 0;
            obj.Self = 0;
            obj.Integral = 0;

            obj.Quan = 0;
            obj.InvoiceAmount = 0;
            obj.InvoiceNum = "";
            obj.InvoiceType = "";
            obj.Describes = "售后";
            obj.DHFrom = dH;
            obj.Amount = 0;
            obj.ReceiveMan = LoginInfoShare.getInstance().UserName;
            obj.Remark = "";
            //  obj.RecAmount = amountReceivable;
            obj.RecAmount = 0;
            IsModify = true;
            mIFinance.AcceptAmount(obj);
            this.Close();
        }

        private void menuClaim_Click(object sender, EventArgs e)
        {

        }

        private void btnClaimModify_Click(object sender, EventArgs e)
        {
            frmDlgAccessAmount frm1 = new frmDlgAccessAmount();
            frm1.DH = txtDH.Text;
            frm1.Modify = true;
            frm1.AccessAmount = double.Parse(txtAccessAmount.Text);
            frm1.setRefreshDelegate(delegate(bool IsR)
            {
                if (IsR)
                    SetStatus(2);

            });
            frm1.ShowDialogEx();
        }

        private void dgRepairItem_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgRepairItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgRepairItem_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void cmbRepChildType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
