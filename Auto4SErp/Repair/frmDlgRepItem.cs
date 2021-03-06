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
using Model;
using Auto4SErp.Personnel;
using Bll;
namespace Auto4SErp.Repair
{
    public partial class frmDlgRepItem : ifrmBase
    {
        private IRepairItem mIRepairItem;
        private IRepair mIRepair;
        private string mItemCode = "";
        private string mPriceId = "";
        private repair_iM repairIM = null;
        private ICustomer mICustomer;
        private IVip mIVip;
        private float disCount = -1F;
        private string vipNo;

        public bool IsSpecial
        {
            get;
            set;

        }
        public string ChiliType
        {
            get;
            set;

        }

        public string Mobile
        {

            get;
            set;

        }
        public string VipNo
        {
            get { return vipNo; }
            set { vipNo = value; }
        }

        public float DisCount
        {
            get { return disCount; }
            set { disCount = value; }
        }

        public repair_iM RepairIM
        {
            get { return repairIM; }
            set { repairIM = value; }
        }

        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        public frmDlgRepItem()
        {
            mIRepairItem = Bll.BllFactory.GetRepairItemBll();
            mIRepair = Bll.BllFactory.GetRepariBll();
            mIVip = BllFactory.GetVipBll();
            mICustomer = BllFactory.GetCustomerBll();
            InitializeComponent();

        }


        private void AddElseRegular()
        {
            if (txtItemCode.Text.Contains("JD") || txtItemCode.Text.Contains("BJ") || txtItemCode.Text.Contains("YQ") || txtItemCode.Text.Contains("ZH") || txtItemCode.Text.Contains("MR"))
            {
                dbiEmpWorkH.Enabled = false;
                dbiActWorkH.Enabled = true;
                dbiWorkHPrice.Enabled = true;

            }
            if (txtItemCode.Text.Contains("JD22") || txtItemCode.Text.Contains("JD23") || txtItemCode.Text.Contains("JD24") || txtItemCode.Text.Contains("BJ02"))
            {
                dbiEmpWorkH.Enabled = true;
                dbiActWorkH.Enabled = true;
                dbiWorkHPrice.Enabled = true;
            }

            if (Comm.LoginInfoShare.getInstance().OrganId == "608" && txtItemCode.Text.Contains("BY"))
            {
                dbiEmpWorkH.Enabled = true;
                dbiActWorkH.Enabled = true;
                dbiWorkHPrice.Enabled = true;
            }
        }
        private void AssginToControl(string result)
        {
            //需改动
            string[] tmplst = result.Split(',');
            string item = tmplst[0];
            string price = tmplst[1];
            DataTable dtItem = mIRepairItem.GetRepairItemByCode(item);

            if (dtItem.Rows.Count > 0)
            {


                txtItemName.Text = dtItem.Rows[0]["ItemName"].ToString();
                mItemCode = dtItem.Rows[0]["ItemCode"].ToString();
                txtItemCode.Text = dtItem.Rows[0]["ItemCode"].ToString();


                if (txtItemName.Text.Contains("■") || txtItemCode.Text.Contains("DZ"))
                {
                    dbiEmpWorkH.Enabled = true;
                    dbiActWorkH.Enabled = true;
                    dbiWorkHPrice.Enabled = true;
                    //  txtItemName.ReadOnly = false;
                }
                else
                {
                    dbiEmpWorkH.Enabled = false;
                    dbiActWorkH.Enabled = false;
                    dbiWorkHPrice.Enabled = false;
                }

                AddElseRegular();
            }

            if (!string.IsNullOrEmpty(price))
            {
                DataTable dtPrice = mIRepairItem.GetRepairPriceByID(price);
                if (dtPrice.Rows.Count > 0)
                {
                    mPriceId = price;
                    dbiWorkHPrice.Value = double.Parse(dtPrice.Rows[0]["WorkHPrice"].ToString());
                    dbiActWorkH.Value = double.Parse(dtPrice.Rows[0]["ActWorkH"].ToString());
                    dbiEmpWorkH.Value = double.Parse(dtPrice.Rows[0]["EmpWorkH"].ToString());
                    txtCarLevel.Text = ConvertCarLevelToName(dtPrice.Rows[0]["CarLevel"].ToString());


                }
            }


        }

        private string ConvertCarLevelToName(string carlevelid)
        {
            string result = "";
            switch (carlevelid)
            {
                case "100":
                    result = "高档";
                    break;
                case "200":
                    result = "中高档";
                    break;
                case "300":
                    result = "中档";
                    break;
                default:
                    result = "低档";
                    break;

            }
            return result;


        }
        private string ConvertCarLevelToID(string carlevelid)
        {
            string result = "";
            switch (carlevelid)
            {
                case "高档":
                    result = "100";
                    break;
                case "中高档":
                    result = "200";
                    break;
                case "中档":
                    result = "300";
                    break;
                default:
                    result = "400";
                    break;

            }
            return result;


        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            repair_iM obj;

            if (RepairIM == null) obj = new repair_iM();
            else obj = RepairIM;


            obj.DH = dH;
            //     obj.ItemCode = mItemCode;

            if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                ShowMessage("请选择维修项目");
                return;
            }

            if (dbiWorkHPrice.Value < 0)
            {
                ShowMessage("工时费不能小于0");
                return;

            }
            //if (string.IsNullOrEmpty(cmbWorkMan.Text))
            //{
            //    ShowMessage("请选择作业人员");
            //    return;
            //}

            //obj.PriceId = mPriceId;
            obj.ItemCode = txtItemCode.Text;
            obj.EmpWorkH = float.Parse(dbiEmpWorkH.Value.ToString());
            obj.ActWorkH = float.Parse(dbiActWorkH.Value.ToString());
            obj.CarLevel = ConvertCarLevelToID(txtCarLevel.Text);
            obj.WorkHPrice = (float)dbiWorkHPrice.Value;

            obj.WorkMan = cmbWorkMan.Text;
            obj.FaultDescribe = txtFaultDescribe.Text;
            obj.FaultReason = txtFaultReason.Text;
            obj.TypeOfWork = cmbTypeOfWork.Text;
            obj.FinalPrice = obj.WorkHPrice;
            obj.Discount = disCount;



            if (repairIM == null)
            {
                if (obj.Discount == -1) obj.Discount = 0;
                decimal tmpf = 0;
                tmpf = (decimal)(obj.WorkHPrice * (1 - obj.Discount));
                tmpf = Math.Round(tmpf, 2);
                obj.FinalPrice = (float)tmpf;
                if (ChiliType == "索赔" || ChiliType == "免费保养")
                {
                    obj.FinalPrice = 0;
                }
                mIRepair.AddItemOfRepairEx(obj);
            }
            else
            {
                if (ChiliType == "索赔" || ChiliType == "免费保养")
                {
                    obj.FinalPrice = 0;
                }
                mIRepair.UpdateRepairItemOfModel(obj);
            }
            IsModify = true;
            this.Close();
        }

        private void frmDlgRepItem_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            LoadExtendContents("作业人员", cmbWorkMan);
            cmbWorkMan.SelectedIndex = -1;
            if (repairIM != null)
            {
                // btnFindItem.Visible = true;
                // AssginToControl(repairIM.PriceId);

                txtItemCode.Text = repairIM.ItemCode;
                txtItemName.Text = repairIM.ItemName;
                dbiEmpWorkH.Value = double.Parse(repairIM.EmpWorkH.ToString());
                dbiActWorkH.Value = double.Parse(repairIM.ActWorkH.ToString());
                dbiWorkHPrice.Value = double.Parse(repairIM.WorkHPrice.ToString());
                //  txtWorkHPrice.Text = repairIM.WorkHPrice.ToString();
                txtCarLevel.Text = repairIM.CarLevel.ToString();
                txtFaultDescribe.Text = repairIM.FaultDescribe;
                txtFaultReason.Text = repairIM.FaultReason;
                cmbWorkMan.Text = repairIM.WorkMan;
                cmbTypeOfWork.Text = repairIM.TypeOfWork;

                if (txtItemName.Text.Contains("■") || txtItemCode.Text.Contains("DZ"))
                {
                    dbiEmpWorkH.Enabled = true;
                    dbiActWorkH.Enabled = true;
                    dbiWorkHPrice.Enabled = true;
                    //    txtItemName.ReadOnly = false;
                }
                else
                {
                    dbiEmpWorkH.Enabled = false;
                    dbiActWorkH.Enabled = false;
                    dbiWorkHPrice.Enabled = false;
                }
                AddElseRegular();
                // btnFindItem.Visible = false;

            }

            //   会员折扣
            //if (!string.IsNullOrEmpty(vipNo))
            //{
            //    VipInfo obj = mIVip.GetVipInfoByCardID(vipNo);
            //    if (obj != null)
            //    {
            //        string level = obj.MemberLevel;
            //        DataTable dt = mICustomer.GetVipInfoOfLevel(level);
            //        if (dt.Rows.Count > 0)
            //        {

            //            string strdicountofitem = dt.Rows[0]["itemdiscount"].ToString();
            //            disCount = float.Parse(strdicountofitem);
            //            if (obj.Balance <= 0)
            //                disCount = 0;
            //        }

            //    }
            //}
            if (!string.IsNullOrEmpty(Mobile))
            {
                Customer objcust = mICustomer.GetCustomerByMobile(Mobile);
                if (objcust != null)
                {

                    string cardno = objcust.CardNo;
                    VipInfo obj = mIVip.GetVipInfoByCardID(cardno);
                    DataTable dt;
                    try
                    {
                        if (obj != null)
                        {
                            string level = obj.MemberLevel;
                            dt = mICustomer.GetVipInfoOfLevel(level);
                            //有会员卡的情况
                            if (dt.Rows.Count > 0)
                            {

                                string strdicountofitem = dt.Rows[0]["accdiscount"].ToString();
                                disCount = float.Parse(strdicountofitem);

                                if (obj.Balance <= 0) disCount = 0;
                            }
                        }

                        if (objcust.VipTypeID > 80)
                        {
                            dt = mICustomer.GetVipInfoOfLevelByID(objcust.VipTypeID.ToString());
                            string strdicountofitem = dt.Rows[0]["itemdiscount"].ToString();
                            disCount = float.Parse(strdicountofitem);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }

            if (IsSpecial)
            {
                dbiWorkHPrice.Enabled = false;
                dbiActWorkH.Enabled = false;
                dbiEmpWorkH.Enabled = false;
            }

        }

        private void btnFindStaff_Click(object sender, EventArgs e)
        {
            Point pt = this.Location;
            frmDlgStaffTree frm = new frmDlgStaffTree();
            Point NewPoint = new Point(pt.X + this.Width, pt.Y - 50);
            frm.Location = NewPoint;
            frm.setTransferDelegate(delegate(object o)
            {
                cmbWorkMan.Text = (string)o;

            });
            frm.ShowDialog();
        }

        private void btnFindItem_Click_1(object sender, EventArgs e)
        {

            frmRepairItem frm = new frmRepairItem();
            frm.IsSelect = true;
            frm.setTransferDelegate(delegate(object data)
            {
                string str = data.ToString();

                //string[] strlst = str.Split(',');
                AssginToControl(str);

            });
            frm.ShowDialogEx();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmExtend frm = new frmExtend();
            frm.LimitContent = "作业人员";
            frm.ShowDialogEx();
        }
    }
}
