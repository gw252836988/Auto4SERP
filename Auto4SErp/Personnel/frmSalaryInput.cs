using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comm;
using Bll.Personnel;
using Bll;
using Model;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Bll.Sale;
using Auto4SErp.Report;

namespace Auto4SErp.Personnel
{
    public partial class frmSalaryInput : Form
    {
        private IStaff mIStaff = BllFactory.GetStaffBll();
        private IAward mIAward = BllFactory.GetAwardBll();
        private ICarSale mICarSale = BllFactory.GetCarSaleBll();
        private Staff mStaff;
        private int mYear;
        private int mMonth;
        private string mStaffID="";
        private DataTable BonusData=null;

        public int Year
        {
            get;
            set;
        }
        public int Month
        {
            get;
            set;
        }

        public string  StaffID
        {
            get;
            set;
        }
         public frmSalaryInput()
        {
            InitializeComponent();
        }
       
        //赋值
        //工资赋值
        private Salary AssginValueForSalary_Add()
        {
            Salary obj = new Salary();
            string[] tmpList = mStaff.NativePlace.Split('_');
            obj.StaffID = mStaff.StaffID;
            obj.Department = mStaff.DepartmentName;
            obj.StafffName = mStaff.StaffName;
            obj.Brand = tmpList[0];
            obj.Position = mStaff.PositionName;
            obj.Region = tmpList[1];
            return obj;
        }  
        private Salary AssginValueForSalary_Update()
        {
            Salary obj = new Salary();
            obj.StaffID = mStaff.StaffID;
            obj.Year = mYear;
            obj.Month = mMonth;
            obj.BasicSalary = txtBasicSalary.Value;
            obj.PositionAllowance = txtPositionAllowance.Value;
            obj.CertificationBonus = txtCertificationBonus.Value;
            obj.ExpenseAllowance = txtExpenseAllowance.Value;
            obj.ElsePlus = txtElsePlus.Value;
            obj.ElseMinus = txtElseMinus.Value;
            obj.ClothAllowance = txtClothAllowance.Value;
            obj.ClothDeducted = txtClothDeducted.Value;
            obj.LaborUnionDeducted = txtLaborUnionDeducted.Value;
            obj.MutualHelpDeducted = txtMutualHelpDeducted.Value;
            obj.AssessDeducted = txtAssessDeducted.Value;
            obj.TrainingAllowance = txtTrainingAllowance.Value;
            obj.ViolateDeducted = txtViolateDeducted.Value;
            obj.InsuranceDeducted = txtInsuranceDeducted.Value;
            obj.SepecialDeducted=txtSepecialDeducted.Value;
            obj.TaxDeducted=txtTaxDeducted.Value;
            obj.TotalBonus = txtTotalBonus.Value;
            obj.ActualSalary = txtActualSalary.Value;
            obj.DeserveSalary = txtDeserveSalary.Value;
            return obj;

        }
        private void AssginSalaryValuesToControls(Salary obj)
        {
            txtBasicSalary.Value = obj.BasicSalary;
            txtPositionAllowance.Value = obj.PositionAllowance;
            txtCertificationBonus.Value = obj.CertificationBonus;
            txtExpenseAllowance.Value = obj.ExpenseAllowance;
            txtElsePlus.Value = obj.ElsePlus;
            txtElseMinus.Value = obj.ElseMinus;
            txtClothAllowance.Value = obj.ClothAllowance;
            txtClothDeducted.Value = obj.ClothDeducted;
            txtLaborUnionDeducted.Value = obj.LaborUnionDeducted;
            txtMutualHelpDeducted.Value = obj.MutualHelpDeducted;
            txtAssessDeducted.Value = obj.AssessDeducted;
            txtTrainingAllowance.Value = obj.TrainingAllowance;
            txtViolateDeducted.Value = obj.ViolateDeducted;
            txtInsuranceDeducted.Value = obj.InsuranceDeducted;
            txtSepecialDeducted.Value = obj.SepecialDeducted;
            txtTaxDeducted.Value = obj.TaxDeducted;
            txtTotalBonus.Value = obj.TotalBonus;
            txtActualSalary.Value = obj.ActualSalary;
            txtDeserveSalary.Value = obj.DeserveSalary;

        }
        //把一般职位奖金赋值对象
        private OrdinaryPost AssginOrdinaryPostValuesToObject(DataRow drSource)
        {
            OrdinaryPost obj = new OrdinaryPost();
            obj.ID = (int)drSource["ID"];
            obj.BonusBeforeAssess = (decimal)drSource["BonusBeforeAssess"];
            obj.AssginRate = (decimal)drSource["AssginRate"];
            obj.ScoreAssessed = (decimal)drSource["ScoreAssessed"];
            obj.Adjust = (decimal)drSource["Adjust"];
            obj.ElseBonusPlus = (decimal)drSource["ElseBonusPlus"];
            obj.ElseBonusMinus = (decimal)drSource["ElseBonusMinus"];
            obj.UltimateBonus = (decimal)drSource["UltimateBonus"];
            return obj;
        }

        //把销售顾问奖金赋值到对象
        private SaleCounselor AssginSaleCounselorValuesToObject(DataRow drSource)
        {
            SaleCounselor obj = new SaleCounselor();
            obj.ID = (int)drSource["ID"];
            obj.SaleCount = (int)drSource["SaleCount"];
            obj.SecondCount = (int)drSource["SecondCount"];
            obj.CarBonus = (decimal)drSource["CarBonus"];
            obj.SecondBonus = (decimal)drSource["SecondBonus"];
            obj.LongTermBonus = (decimal)drSource["LongTermBonus"];
            obj.InsuranceBonus = (decimal)drSource["InsuranceBonus"];
            obj.DecorationBonus = (decimal)drSource["DecorationBonus"];
            obj.ProlongInsuranceBonus = (decimal)drSource["ProlongInsuranceBonus"];
            obj.ReplacementBonus = (decimal)drSource["ReplacementBonus"];
            obj.FinanceBonus = (decimal)drSource["FinanceBonus"];
            obj.FRentBonus = (decimal)drSource["FRentBonus"];
            obj.RentBonus = (decimal)drSource["RentBonus"];
            obj.SynthesisBonus = (decimal)drSource["SynthesisBonus"];
            obj.ScoreAssessed = (decimal)drSource["ScoreAssessed"];
            obj.UltimateBonus = (decimal)drSource["UltimateBonus"];
            return obj;
        }
        //把销售经理奖金赋值到对象
        private SaleSupervior AssginSaleSuperviorValuesToObject(DataRow drSource)
        {
            SaleSupervior obj = new SaleSupervior();
            obj.ID = (int)drSource["ID"];
            obj.FirstCount = (decimal)drSource["FirstCount"];
            obj.MiddleCount = (decimal)drSource["MiddleCount"];
            obj.LastCount = (decimal)drSource["LastCount"];
            obj.FirstBonus = (decimal)drSource["FirstBonus"];
            obj.MiddleBonus = (decimal)drSource["MiddleBonus"];
            obj.LastBonus = (decimal)drSource["LastBonus"];
            obj.Adjust = (decimal)drSource["Adjust"];
            obj.ScoreAssessed = (decimal)drSource["ScoreAssessed"];
            obj.UltimateBonus = (decimal)drSource["UltimateBonus"];
            return obj;
        }
        //把试乘试驾赋值到对象
        private SaleCarTrial AssginSaleCartrialValuesToObject(DataRow drSource)
        {
            SaleCarTrial obj = new SaleCarTrial();
            obj.ID = (int)drSource["ID"];
            obj.TrialCount = int.Parse(drSource["TrialCount"].ToString());
            obj.BonusTrial = (decimal)drSource["BonusTrial"];
            obj.CheckCount = int.Parse(drSource["CheckCount"].ToString());
            obj.BounusCheck = (decimal)drSource["BonusCheck"];
            obj.ScoreAssessed = (decimal)drSource["ScoreAssessed"];
            obj.UltimateBonus = (decimal)drSource["UltimateBonus"];
            return obj;

        }
       //上牌及客户
        private SalePlateService AssginSalePlateServiceToObject(DataRow drSource)
        {

            SalePlateService obj = new SalePlateService();
            obj.ID = (int)drSource["ID"];
            obj.PlateCount = int.Parse(drSource["PlateCount"].ToString());
            obj.PlateBonus = (decimal)drSource["PlateBonus"];

            obj.ElsePlus = (decimal)drSource["ElsePlus"];
            obj.PhoneCount = (int)drSource["PhoneCount"];
            obj.RecordCount = (int)drSource["RecordCount"];
            obj.VisitCount = (int)drSource["VisitCount"];
            obj.ScoreAssessed = (decimal)drSource["ScoreAssessed"];
            obj.UltimateBonus = (decimal)drSource["UltimateBonus"];
            return obj;

        }
        //金融顾问
        private SaleFinance AssginSaleFinanceToObject(DataRow drSource)
        {
            SaleFinance obj = new SaleFinance();
            obj.ID = (int)drSource["ID"];
            obj.BonusBeforeAssess = (decimal)drSource["BonusBeforeAssess"];
            obj.AssginRate = (decimal)drSource["AssginRate"];
            obj.XSXCount = (int)drSource["XSXCount"];
            obj.XSXBonus = (decimal)drSource["XSXBonus"];
            obj.DCXCount = (int)drSource["DCXCount"];
            obj.DCXBonus = (decimal)drSource["DCXBonus"];
            obj.JRDCount = (int)drSource["JRDCount"];
            obj.JRDBonus = (decimal)drSource["JRDBonus"];
            obj.ScoreAssessed = (decimal)drSource["ScoreAssessed"];
            obj.UltimateBonus = (decimal)drSource["UltimateBonus"];
            return obj;

        }
        
        private void SaveSalaryInfo()
        {
            CaculateTotalBonus();
            Salary obj= AssginValueForSalary_Update();
            mIAward.UpdateSalary(obj);

        }


        private void  CaculateTotalBonus()
        {
         
            DataTable dtOrdinaryPost = (DataTable)gridOrdinaryPost.DataSource;
            DataTable dtSale_Counselor = (DataTable)gridSale_Counselor.DataSource;
            DataTable dtSale_Supervior = (DataTable)gridSale_Supervior.DataSource;
            DataTable dtSale_CarTrial = (DataTable)gridSale_CarTrial.DataSource;
            DataTable dtSale_PlateService = (DataTable)gridPlateAndService.DataSource;
            DataTable dtSale_Finance = (DataTable)gridSale_Finance.DataSource;
            decimal totalbonus=0;
            if (dtOrdinaryPost != null && dtOrdinaryPost.Rows.Count > 0)
            {
                totalbonus = totalbonus + (decimal)dtOrdinaryPost.Rows[0]["UltimateBonus"];

            }
            if (dtSale_Counselor != null && dtSale_Counselor.Rows.Count > 0)
            {
                totalbonus = totalbonus + (decimal)dtSale_Counselor.Rows[0]["UltimateBonus"];

            }
            if (dtSale_Supervior != null && dtSale_Supervior.Rows.Count > 0)
            {
                totalbonus = totalbonus + (decimal)dtSale_Supervior.Rows[0]["UltimateBonus"];

            }
            if (dtSale_CarTrial != null && dtSale_CarTrial.Rows.Count > 0)
            {
                totalbonus = totalbonus + (decimal)dtSale_CarTrial.Rows[0]["UltimateBonus"];

            }
            if (dtSale_PlateService != null && dtSale_PlateService.Rows.Count > 0)
            {
                totalbonus = totalbonus + (decimal)dtSale_PlateService.Rows[0]["UltimateBonus"];

            }
            if (dtSale_Finance != null && dtSale_Finance.Rows.Count > 0)
            {
                totalbonus = totalbonus + (decimal)dtSale_Finance.Rows[0]["UltimateBonus"];

            }
            txtTotalBonus.Value = totalbonus;

        }
        //刷新
        private void refreshOrdinaryPost()
        {
            DataTable dt= mIAward.GetRecOfOrdinaryPost(mStaff.StaffID, mYear, mMonth);
            if (dt != null && dt.Rows.Count > 0)
            {
                dt.Rows[0]["AssginRate"] = GetAssginRateOfStaff();
                gridOrdinaryPost.DataSource = dt;
            }
        }
        private void refreshSale_Supervior()
        {
            DataTable dt = mIAward.GetRecOfSaleSupervior(mStaff.StaffID, mYear, mMonth);
            if (dt != null && dt.Rows.Count > 0)
            {
                gridSale_Supervior.Visible = true;
                gridSale_Supervior.DataSource = dt;

            }      
        }
        private void refreshSale_Counselor()
        {
           // mIAward.AddRecOfSaleCounselor(mStaff.StaffID, mYear, mMonth);

             DataTable  dt= mIAward.GetRecOfSaleCounselor(mStaff.StaffID, mYear, mMonth);
             if (dt != null && dt.Rows.Count > 0)
             {
                 
                gridSale_Counselor.Visible = true;
                gridSale_Counselor.DataSource =dt;
             }
        }

        private void refreshSale_Cartrial()
        {
            DataTable dt = mIAward.GetRecOfSaleCartrial(mStaff.StaffID, mYear, mMonth);
            if (dt != null && dt.Rows.Count > 0)
            {
                gridSale_CarTrial.Visible = true;
                gridSale_CarTrial.DataSource = dt;
            }
        }

        private void refreshSale_PlateService()
        {
            DataTable dt = mIAward.GetRecOfPlateService(mStaff.StaffID, mYear, mMonth);
            if (dt != null && dt.Rows.Count > 0)
            {
                gridPlateAndService.Visible = true;
                gridPlateAndService.DataSource = dt;
            }

        }

        private void refreshSale_Finance()
        {
            DataTable dt = mIAward.GetRecOfSaleFinance(mStaff.StaffID, mYear, mMonth);
            if (dt != null && dt.Rows.Count > 0)
            {
                dt.Rows[0]["AssginRate"] = GetAssginRateOfStaff();
                gridSale_Finance.Visible = true;
                gridSale_Finance.DataSource = dt;
            }

        }

        //数字编辑的值改变处理
        private void SaleSuperviorSpin_ValueChanged(object sender, EventArgs e)
        {
            int handle = gridView3.FocusedRowHandle;

            SpinEdit edit = (SpinEdit)sender;

            string FieldName = gridView3.FocusedColumn.FieldName;
            decimal FirstCount = 0;
            decimal MiddleCount = 0;
            decimal LastCount = 0;
            decimal FirstBonus = 0;
            decimal MiddleBonus = 0;
            decimal LastBonus = 0;
            decimal ScoreAssessed = 0;
            decimal Adjust = 0;
            decimal UltimateBonus = 0;

            FirstCount = (decimal)gridView3.GetRowCellValue(handle, "FirstCount");
            MiddleCount = (decimal)gridView3.GetRowCellValue(handle, "MiddleCount");
            LastCount = (decimal)gridView3.GetRowCellValue(handle, "LastCount");
            FirstBonus = (decimal)gridView3.GetRowCellValue(handle, "FirstBonus");
            MiddleBonus = (decimal)gridView3.GetRowCellValue(handle, "MiddleBonus");
            LastBonus = (decimal)gridView3.GetRowCellValue(handle, "LastBonus");
            ScoreAssessed = (decimal)gridView3.GetRowCellValue(handle, "ScoreAssessed");
            Adjust = (decimal)gridView3.GetRowCellValue(handle, "Adjust");


            if (FieldName == "FirstCount")
                FirstCount = edit.Value;
            if (FieldName == "MiddleCount")
                MiddleCount = edit.Value;
            if (FieldName == "LastCount")
                LastCount = edit.Value;
            if (FieldName == "FirstBonus")
                FirstBonus = edit.Value;
            if (FieldName == "MiddleBonus")
                MiddleBonus = edit.Value;
            if (FieldName == "LastBonus")
                LastBonus = edit.Value;
            if (FieldName == "ScoreAssessed")
                ScoreAssessed = edit.Value;
            if (FieldName == "Adjust")
                Adjust = edit.Value;
            UltimateBonus = (FirstBonus + MiddleBonus +LastBonus ) * ScoreAssessed+ Adjust;

            gridView3.SetRowCellValue(handle, "UltimateBonus", UltimateBonus);





        }
        private void SaleCounselorNumEdit_ValueChanged(object sender, EventArgs e)
        {
            int handle = gridView2.FocusedRowHandle;
            SpinEdit edit = (SpinEdit)sender;
            string FieldName = gridView2.FocusedColumn.FieldName;
            decimal CarBonus;
            decimal SecondBonus;
            decimal LongTermBonus;
            decimal InsuranceBonus;
            decimal DecorationBonus;
            decimal ProlongInsuranceBonus;
            decimal ReplacementBonus;
            decimal FinanceBonus;
            decimal FRentBonus;
            decimal RentBonus;
            decimal SynthesisBonus;
            decimal ScoreAssessed;
            decimal UltimateBonus;

            CarBonus = (decimal)gridView2.GetRowCellValue(handle, "CarBonus");
            SecondBonus = (decimal)gridView2.GetRowCellValue(handle, "SecondBonus");
            LongTermBonus = (decimal)gridView2.GetRowCellValue(handle, "LongTermBonus");
            InsuranceBonus = (decimal)gridView2.GetRowCellValue(handle, "InsuranceBonus");
            DecorationBonus = (decimal)gridView2.GetRowCellValue(handle, "DecorationBonus");
            ProlongInsuranceBonus = (decimal)gridView2.GetRowCellValue(handle, "ProlongInsuranceBonus");
            ReplacementBonus = (decimal)gridView2.GetRowCellValue(handle, "ReplacementBonus");
            FinanceBonus = (decimal)gridView2.GetRowCellValue(handle, "FinanceBonus");
            FRentBonus = (decimal)gridView2.GetRowCellValue(handle, "FRentBonus");
            RentBonus = (decimal)gridView2.GetRowCellValue(handle, "RentBonus");
            SynthesisBonus = (decimal)gridView2.GetRowCellValue(handle, "SynthesisBonus");
            ScoreAssessed = (decimal)gridView2.GetRowCellValue(handle, "ScoreAssessed");


            if (FieldName == "CarBonus")
                CarBonus = edit.Value;
            if (FieldName == "SecondBonus")
                SecondBonus = edit.Value;
            if (FieldName == "LongTermBonus")
                LongTermBonus = edit.Value;
            if (FieldName == "InsuranceBonus")
                InsuranceBonus = edit.Value;
            if (FieldName == "DecorationBonus")
                DecorationBonus = edit.Value;
            if (FieldName == "ProlongInsuranceBonus")
                ProlongInsuranceBonus = edit.Value;
            if (FieldName == "ReplacementBonus")
                ReplacementBonus = edit.Value;
            if (FieldName == "FinanceBonus")
                FinanceBonus = edit.Value;
            if (FieldName == "FRentBonus")
                FRentBonus = edit.Value;
            if (FieldName == "RentBonus")
                RentBonus = edit.Value;
            if (FieldName == "SynthesisBonus")
                SynthesisBonus = edit.Value;
            if (FieldName == "ScoreAssessed")
                ScoreAssessed = edit.Value;

            UltimateBonus = ScoreAssessed*(CarBonus + SecondBonus + LongTermBonus + InsuranceBonus + DecorationBonus + ProlongInsuranceBonus + ReplacementBonus + FinanceBonus + FRentBonus +RentBonus+ SynthesisBonus);
            gridView2.SetRowCellValue(handle, "UltimateBonus", UltimateBonus);
        }
        
        private void repositoryItemNumSE_ValueChanged(object sender, EventArgs e)
        {
            int handle = gridView1.FocusedRowHandle;

            SpinEdit edit = (SpinEdit)sender;

            string FieldName = gridView1.FocusedColumn.FieldName;
            decimal BonusBeforeAssess = 0;
            decimal Adjust = 0;
            decimal ElseBonusPlus = 0;
            decimal ElseBonusMinus = 0;
            decimal AssginRate = 0;
            decimal ScoreAssessed = 0;
            decimal UltimateBonus = 0;

            Adjust = (decimal)gridView1.GetRowCellValue(handle, "Adjust");
            ElseBonusPlus = (decimal)gridView1.GetRowCellValue(handle, "ElseBonusPlus");
            ElseBonusMinus = (decimal)gridView1.GetRowCellValue(handle, "ElseBonusMinus");
            BonusBeforeAssess = (decimal)gridView1.GetRowCellValue(handle, "BonusBeforeAssess");
            AssginRate = (decimal)gridView1.GetRowCellValue(handle, "AssginRate");
            ScoreAssessed = (decimal)gridView1.GetRowCellValue(handle, "ScoreAssessed");

            if (FieldName == "BonusBeforeAssess")
                BonusBeforeAssess = edit.Value;
            if (FieldName == "AssginRate")
                AssginRate = edit.Value;
            if (FieldName == "ScoreAssessed")
                ScoreAssessed = edit.Value;
            if (FieldName == "Adjust")
                Adjust = edit.Value;
            if (FieldName == "ElseBonusPlus")
                ElseBonusPlus = edit.Value;
            if (FieldName == "ElseBonusMinus")
                ElseBonusMinus = edit.Value;
            UltimateBonus = (BonusBeforeAssess * AssginRate * ScoreAssessed) + Adjust + ElseBonusPlus - ElseBonusMinus;

            gridView1.SetRowCellValue(handle, "UltimateBonus", UltimateBonus);
        }

        private void CarTrialItemSpinEdit_ValueChanged(object sender, EventArgs e)
        {
            int handle = gridView4.FocusedRowHandle;
            SpinEdit edit = (SpinEdit)sender;
            string FieldName = gridView4.FocusedColumn.FieldName;
            int CheckCount = 0;
            decimal ScoreAssessed = 0;
            decimal BonusCheck = 0;
            decimal UltimateBonus = 0;
            decimal BonusTrial=0;
            CheckCount = (int)gridView4.GetRowCellValue(handle, "CheckCount");
            ScoreAssessed = (decimal)gridView4.GetRowCellValue(handle, "ScoreAssessed");
            BonusCheck = (decimal)gridView4.GetRowCellValue(handle, "BonusCheck");
            BonusTrial=(decimal)gridView4.GetRowCellValue(handle, "BonusTrial");

            if (FieldName == "CheckCount")
            {
                CheckCount = (int)edit.Value;
                BonusCheck = CheckCount * 30;
            }
            if (FieldName == "ScoreAssessed")
                ScoreAssessed = edit.Value;

            gridView4.SetRowCellValue(handle, "BonusCheck", BonusCheck);
            UltimateBonus = (BonusCheck + BonusTrial) * ScoreAssessed;
            gridView4.SetRowCellValue(handle, "UltimateBonus", UltimateBonus);

        }
        private void PlateAndServiceSpinEdit_ValueChanged(object sender, EventArgs e)
        {
            int handle = gridView5.FocusedRowHandle;

            SpinEdit edit = (SpinEdit)sender;
            string FieldName = gridView5.FocusedColumn.FieldName;
            int PlateCount=0;
            decimal PlateBonus=0;
            decimal ElsePlus = 0;
            int PhoneCount = 0;
            int RecordCount = 0;
            int VisitCount = 0;
            decimal ScoreAssessed = 0;
            decimal UltimateBonus = 0;

            PlateCount = (int)gridView5.GetRowCellValue(handle, "PlateCount");
            PlateBonus = (decimal)gridView5.GetRowCellValue(handle, "PlateBonus");
            ElsePlus = (decimal)gridView5.GetRowCellValue(handle, "ElsePlus");
            PhoneCount = (int)gridView5.GetRowCellValue(handle, "PhoneCount");
            RecordCount = (int)gridView5.GetRowCellValue(handle, "RecordCount");
            VisitCount = (int)gridView5.GetRowCellValue(handle, "VisitCount");
            ScoreAssessed = (decimal)gridView5.GetRowCellValue(handle, "ScoreAssessed");

            if (FieldName == "PlateCount")
            {
                PlateCount = (int)edit.Value;
                PlateBonus = PlateCount * 30;
            }
            //if (FieldName == "PlateBonus")
            //    PlateBonus = edit.Value;
            if (FieldName == "ElsePlus")
                ElsePlus = edit.Value;
            if (FieldName == "PhoneCount")
                PhoneCount = (int)edit.Value;
            if (FieldName == "RecordCount")
                RecordCount = (int)edit.Value;
            if (FieldName == "VisitCount")
                VisitCount = (int)edit.Value;
            if (FieldName == "ScoreAssessed")
                ScoreAssessed = edit.Value;

            gridView5.SetRowCellValue(handle, "PlateBonus", PlateBonus);
            UltimateBonus = (PlateBonus + PhoneCount * 8 + RecordCount * 15 + VisitCount * 10) * ScoreAssessed + ElsePlus;
            gridView5.SetRowCellValue(handle, "UltimateBonus", UltimateBonus);

          
        }


        private void SaleFinanceSpinEdit_ValueChanged(object sender, EventArgs e)
        {
            int handle = gridView6.FocusedRowHandle;

            SpinEdit edit = (SpinEdit)sender;
            string FieldName = gridView6.FocusedColumn.FieldName;
            decimal BonusBeforeAssess = 0;
            decimal AssginRate = 0;
            int XSXCount = 0;
            decimal XSXBonus = 0;
            int DCXCount = 0;
            decimal DCXBonus = 0;
            int JRDCount = 0;
            decimal JRDBonus = 0;
            decimal ScoreAssessed = 0;
            decimal UltimateBonus = 0;

            BonusBeforeAssess = (decimal )gridView6.GetRowCellValue(handle, "BonusBeforeAssess");
            AssginRate = (decimal)gridView6.GetRowCellValue(handle, "AssginRate");
            XSXBonus = (decimal)gridView6.GetRowCellValue(handle, "XSXBonus");
            DCXBonus = (decimal)gridView6.GetRowCellValue(handle, "DCXBonus");
            JRDBonus = (decimal)gridView6.GetRowCellValue(handle, "JRDBonus");
            ScoreAssessed = (decimal)gridView6.GetRowCellValue(handle, "ScoreAssessed");
            UltimateBonus = (decimal)gridView6.GetRowCellValue(handle, "UltimateBonus");

            if (FieldName == "BonusBeforeAssess")
            {
                BonusBeforeAssess = edit.Value;
            }
            if (FieldName == "AssginRate")
            {
                AssginRate = edit.Value;
            }
            if (FieldName == "XSXCount")
            {
                XSXCount = (int)edit.Value;
                XSXBonus = XSXCount * 200;
            }

            if (FieldName == "DCXCount")
            {
                DCXCount = (int)edit.Value;
                DCXBonus = DCXCount * 500;
            }
            if (FieldName == "JRDCount")
            {
                JRDCount = (int)edit.Value;
                JRDBonus = JRDCount * 100;
            }
            if (FieldName == "ScoreAssessed")
            {
                ScoreAssessed = edit.Value;
            }

            gridView6.SetRowCellValue(handle, "XSXBonus", XSXBonus);
            gridView6.SetRowCellValue(handle, "DCXBonus", DCXBonus);
            gridView6.SetRowCellValue(handle, "JRDBonus", JRDBonus);

            UltimateBonus = (BonusBeforeAssess * AssginRate * ScoreAssessed) + (XSXBonus + DCXBonus + JRDBonus) * ScoreAssessed;
            gridView6.SetRowCellValue(handle, "UltimateBonus", UltimateBonus);
        }

        private void btnCarTrial_Click(object sender, EventArgs e)
        {
            gridSale_CarTrial.Visible = true;
            
            mIAward.AddRecOfSaleCartrial(mStaff.StaffID, mYear, mMonth);
            refreshSale_Cartrial();
        }
        
        private void btnSale_Counselor_Click(object sender, EventArgs e)
        {
            gridSale_Counselor.Visible = true;
            
            mIAward.AddRecOfSaleCounselor(mStaff.StaffID, mYear , mMonth);
            refreshSale_Counselor();
        }

        private void btnSale_Supervior_Click(object sender, EventArgs e)
        {
            gridSale_Supervior.Visible = true;
            mIAward.AddRecOfSaleSupervior(mStaff.StaffID,mYear,mMonth);
            refreshSale_Supervior();
        }


        private void btnPlateAndService_Click(object sender, EventArgs e)
        {
            gridPlateAndService.Visible = true;
            mIAward.AddRecOfPlateService(mStaff.StaffID, mYear, mMonth);
            refreshSale_PlateService();
      
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            gridSale_Finance.Visible = true;
            mIAward.AddRecOfSaleFinance(mStaff.StaffID, mYear, mMonth);
            refreshSale_Finance();
        }

        private void txtBasicSalary_ValueChanged(object sender, EventArgs e)
        {
            
        }


        private void DeserveSalary_ValueChangd(object sender, EventArgs e)
        {

            txtDeserveSalary.Value = txtBasicSalary.Value +txtTotalBonus.Value + txtPositionAllowance.Value + txtCertificationBonus.Value + txtExpenseAllowance.Value + txtElsePlus.Value - txtElseMinus.Value + txtClothAllowance.Value;
            txtActualSalary.Value = txtDeserveSalary.Value - txtClothDeducted.Value - txtLaborUnionDeducted.Value - txtMutualHelpDeducted.Value - txtAssessDeducted.Value - txtTrainingAllowance.Value - txtViolateDeducted.Value - txtFundDeducted.Value - txtInsuranceDeducted.Value - txtSepecialDeducted.Value-txtTaxDeducted.Value;

            txtTaxDeducted.Value = CaculatePersonelTax();
        }
        private decimal CaculatePersonelTax()
        {
            decimal diffValue = 0;
            decimal tax = 0;
            diffValue = txtBasicSalary.Value - txtFundDeducted.Value - txtInsuranceDeducted.Value - txtSepecialDeducted.Value;
            if (diffValue <= 5000)
            {
                tax = 0;
            }
            else if (diffValue > 5000 && diffValue <= 8000)
            {
                tax = diffValue * 0.03m;
            }
            else if (diffValue > 8000 && diffValue <= 17000)
            {
                tax = diffValue * 0.1m - 210;
            }
            else if (diffValue > 17000 && diffValue <= 30000)
            {
                tax = diffValue * 0.2m - 1410;
            }
            else if (diffValue > 30000 && diffValue <= 40000)
            {
                tax = diffValue * 0.25m - 2660;
            }
            return tax;
        }

        private void ActualSalary_ValueChangd(object sender, EventArgs e)
        {
        }

        private void frmSalaryInput_Load(object sender, EventArgs e)
        {

            DataTable dt = mIAward.GetSalaryDate();
            //获取工资日期
            this.Text = this.Text + string.Format("(当前工资录入日期:{0}年{1}月)", dt.Rows[0]["Year"], dt.Rows[0]["Month"]);
            mYear = int.Parse(dt.Rows[0]["Year"].ToString());
            mMonth = int.Parse(dt.Rows[0]["Month"].ToString());


            //此处是传递过来的员工工资信息
            if (StaffID != null)
            {
                mStaffID = StaffID;
                mYear = Year;
                mMonth = Month;
                //Salary obj = mIAward.GetSalaryOfOneStaff(mStaffID, mYear, mMonth);
                //AssginSalaryValuesToControls(obj);
                mStaff = mIStaff.GetStaff(mStaffID);
                AssginAllData();
                AutoMatchRewardByPosition();

            }
        
            BindEvents();
             
        }

        private void AutoMatchRewardByPosition()
        {
            if (mStaff.PositionName == "销售顾问")
            {
                mIAward.AddRecOfSaleCounselor(mStaffID,Year,Month);
                refreshSale_Counselor();

            }
            else  if(mStaff.PositionName == "销售经理")
            {
                refreshSale_Supervior();
            }
            else if (mStaff.PositionName.Contains("试驾"))
            {
                refreshSale_Cartrial();

            }
            else if (mStaff.PositionName.Contains("上牌"))
            {
                refreshSale_PlateService();

            }
            else if (mStaff.PositionName.Contains("金融"))
            {
                refreshSale_Finance();

            }


        }
        private void BindEvents()
        {
            this.txtBasicSalary.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            this.txtPositionAllowance.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtCertificationBonus.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtExpenseAllowance.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtElsePlus.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtElseMinus.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtClothAllowance.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtTotalBonus.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);

            txtClothDeducted.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtLaborUnionDeducted.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtMutualHelpDeducted.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtAssessDeducted.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtTrainingAllowance.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtViolateDeducted.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtFundDeducted.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtInsuranceDeducted.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtSepecialDeducted.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            txtTaxDeducted.ValueChanged += new System.EventHandler(this.DeserveSalary_ValueChangd);
            this.SaleCounselorNumEdit.ValueChanged += new System.EventHandler(this.SaleCounselorNumEdit_ValueChanged);

        }

       

        private void ActualSalary_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            txtStaffID.Focus();
            DataTable dtSaleCounselor = null;
            DataTable dtOrdinaryPost = null;
            DataTable dtSaleSupervior = null;
            DataTable dtCarTrial = null;
            DataTable dtPalteService = null;
            DataTable dtSaleFinance = null;
            dtOrdinaryPost = (DataTable)gridOrdinaryPost.DataSource;

            dtSaleCounselor = (DataTable)gridSale_Counselor.DataSource;
                   
            dtSaleSupervior = (DataTable)gridSale_Supervior.DataSource;
 
            dtCarTrial = (DataTable)gridSale_CarTrial.DataSource;

            dtPalteService = (DataTable)gridPlateAndService.DataSource;
            dtSaleFinance = (DataTable)gridSale_Finance.DataSource;
            
            if (dtOrdinaryPost != null && dtOrdinaryPost.Rows.Count > 0)
            {
                for (int i = 0; i < dtOrdinaryPost.Rows.Count; i++)
                {
                    OrdinaryPost obj = AssginOrdinaryPostValuesToObject(dtOrdinaryPost.Rows[i]);
                    // txtTotalBonus.Value = txtTotalBonus.Value + obj.UltimateBonus;
                    mIAward.UpdateOrdinaryPost(obj);
                }
                refreshOrdinaryPost();
            }


            if (dtSaleCounselor != null && dtSaleCounselor.Rows.Count > 0)
            {
                for (int i = 0; i < dtSaleCounselor.Rows.Count; i++)
                {
                
                    SaleCounselor obj = AssginSaleCounselorValuesToObject(dtSaleCounselor.Rows[i]);
                    mIAward.UpdateSaleCounselor(obj);

                }
                refreshSale_Counselor();
            }

            if (dtSaleSupervior != null && dtSaleSupervior.Rows.Count > 0)
            {
                for (int i = 0; i < dtSaleSupervior.Rows.Count; i++)
                {

                    SaleSupervior obj = AssginSaleSuperviorValuesToObject(dtSaleSupervior.Rows[i]);
                    mIAward.UpdateSaleSupervior(obj);

                }
                refreshSale_Supervior();
            }

            if (dtCarTrial != null && dtCarTrial.Rows.Count > 0)
            {
                for (int i = 0; i < dtCarTrial.Rows.Count; i++)
                {
                    SaleCarTrial obj = AssginSaleCartrialValuesToObject(dtCarTrial.Rows[i]);
                    mIAward.UpdateRecOfSaleCartrial(obj);
                }
                refreshSale_Cartrial();
            }

           
            if (dtCarTrial != null && dtCarTrial.Rows.Count > 0)
            {
                for (int i = 0; i < dtCarTrial.Rows.Count; i++)
                {
                    SaleCarTrial obj = AssginSaleCartrialValuesToObject(dtCarTrial.Rows[i]);
                    mIAward.UpdateRecOfSaleCartrial(obj);
                }
                refreshSale_Cartrial();
            }

            if (dtPalteService != null && dtPalteService.Rows.Count > 0)
            {
                for (int i = 0; i < dtPalteService.Rows.Count; i++)
                {
                    SalePlateService obj = AssginSalePlateServiceToObject(dtPalteService.Rows[i]);
                    mIAward.UpdatePlateService(obj);
                }
                refreshSale_PlateService();
            }

            if (dtSaleFinance != null && dtSaleFinance.Rows.Count > 0)
            {
                for (int i = 0; i < dtSaleFinance.Rows.Count; i++)
                {

                    SaleFinance obj = AssginSaleFinanceToObject(dtSaleFinance.Rows[i]);
                    mIAward.UpdateRecOfSaleFinance(obj);
                }
                refreshSale_PlateService();
            }

            SaveSalaryInfo();

        }


        private void txtStaffID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string id = txtStaffID.Text;
            mStaff = mIStaff.GetStaff(id);

            if (mStaff != null)
            {
                ClearControls();
               

                Salary obj = AssginValueForSalary_Add();
                //添加工资记录，和奖金记录
                mIAward.AddRecOfOrdinaryPost(mStaff.StaffID, mYear, mMonth);
                int r=mIAward.AddRecOfSalary(obj, mYear, mMonth);

                //if (r == 0)
                //{
                AssginAllData();
                AutoMatchRewardByPosition();
                // }
                if(r==1)
                {
                    DataTable dtBaseSalary=mIAward.GetSalaryBaseByStaffID(mStaff.StaffID);
                    if (dtBaseSalary != null)
                    {
                       txtBasicSalary.Value= (decimal)dtBaseSalary.Rows[0]["BasicSalary"];
                       txtPositionAllowance.Value=(decimal)dtBaseSalary.Rows[0]["PositionAllowance"] ;
                      // txtAssginRate.Value = (decimal)dtBaseSalary.Rows[0]["AssginRate"];
                      //在表格里初始化

                       txtInsuranceDeducted.Value = (decimal)dtBaseSalary.Rows[0]["insuranceDeducted"];
                       txtFundDeducted.Value = (decimal)dtBaseSalary.Rows[0]["FundDeducted"];
                       txtLaborUnionDeducted.Value = (decimal)dtBaseSalary.Rows[0]["LaborUnionDeducted"];
                    }

                }

               
            }
        }


        private void AssginAllData()
        {

            string[] tmpList = mStaff.NativePlace.Split('_');
            txtStaffID.Text = mStaff.StaffID;
            txtDepartment.Text = mStaff.DepartmentName;
            txtName.Text = mStaff.StaffName;
            txtBrand.Text = tmpList[0];
            txtRegion.Text = tmpList[1];
            txtPosition.Text = mStaff.PositionName;

            Salary objS = mIAward.GetSalaryOfOneStaff(mStaff.StaffID, mYear, mMonth);

            
            AssginSalaryValuesToControls(objS);

           // when add firstly,it will be some wasted
            refreshOrdinaryPost();
            refreshSale_Counselor();
            refreshSale_Supervior();
            refreshSale_Cartrial();
            refreshSale_PlateService();
            refreshSale_Finance();

        }
        private void ClearControls()
        {
            txtBasicSalary.Value = 0;
            txtPositionAllowance.Value = 0;
            txtCertificationBonus.Value =0;
            txtExpenseAllowance.Value = 0;
            txtElsePlus.Value =0;
            txtElseMinus.Value = 0;
            txtClothAllowance.Value = 0;
            txtClothDeducted.Value =0;
            txtLaborUnionDeducted.Value = 0;
            txtMutualHelpDeducted.Value =0;
            txtAssessDeducted.Value = 0;
            txtTrainingAllowance.Value = 0;
            txtViolateDeducted.Value = 0;
            txtInsuranceDeducted.Value = 0;
            txtSepecialDeducted.Value = 0;
            txtTaxDeducted.Value =0;
            txtTotalBonus.Value = 0;
            txtActualSalary.Value = 0;
            txtDeserveSalary.Value = 0;

            gridOrdinaryPost.DataSource = null;
            gridSale_Counselor.Visible = false;
            gridSale_Counselor.DataSource = null;
            gridSale_CarTrial.Visible = false;
            gridSale_CarTrial.DataSource = null;
            gridSale_Finance.Visible = false;
            gridSale_Finance.DataSource = null;
            gridSale_Supervior.Visible = false;
            gridSale_Supervior.DataSource = null;
            gridPlateAndService.Visible = false;
            gridPlateAndService.DataSource = null;
        }

        private SaleCounselor GetBonusOfSaleCounselor()
        {
           // DataTable dt=mICarSale.GetCarSalesOfMonth("","",2019,11,"高阳","");
            var DtOfSaleCounselor = BonusData.AsEnumerable().Where(r => r["SaleMan"].ToString()=="高阳");
            SaleCounselor obj = null;
            if (BonusData!=null)
            {
                obj = AssginSaleCounselorValuesToObject(((DataTable)gridSale_Counselor.DataSource).Rows[0]);
                //dt.AsEnumerable().Sum(r => (decimal.Parse(r[4].ToString())));
                obj.ReplacementBonus = DtOfSaleCounselor.AsEnumerable().Sum(r => (decimal.Parse(r["ChangeReward"].ToString())));
                obj.FinanceBonus = DtOfSaleCounselor.AsEnumerable().Sum(r => (decimal.Parse(r["LoanReward"].ToString())));
                obj.DecorationBonus = DtOfSaleCounselor.AsEnumerable().Sum(r => (decimal.Parse(r["DecorateAward"].ToString())));
                obj.InsuranceBonus = DtOfSaleCounselor.AsEnumerable().Sum(r => (decimal.Parse(r["InsuranceReward"].ToString())));
                obj.SynthesisBonus = DtOfSaleCounselor.AsEnumerable().Sum(r => (decimal.Parse(r["ServiceReward"].ToString())));
                obj.CarBonus = DtOfSaleCounselor.AsEnumerable().Sum(r => (decimal.Parse(r["award"].ToString())));

                obj.UltimateBonus = obj.ScoreAssessed * (obj.CarBonus + obj.SecondBonus + obj.LongTermBonus + obj.InsuranceBonus + obj.DecorationBonus + obj.ProlongInsuranceBonus + obj.ReplacementBonus + obj.FinanceBonus + obj.FRentBonus + obj.RentBonus + obj.SynthesisBonus);
                 
            }
            return obj;
        
        }

        private void btnGetBonusOfCounselor_Click(object sender, EventArgs e)
        {
            if (BonusData != null)
            {
                DataTable dt = (DataTable )gridSale_Counselor.DataSource;
                SaleCounselor obj = GetBonusOfSaleCounselor();
                gridView2.SetRowCellValue(0, "SynthesisBonus", obj.SynthesisBonus);
                gridView2.SetRowCellValue(0, "InsuranceBonus", obj.InsuranceBonus);
                gridView2.SetRowCellValue(0, "ReplacementBonus", obj.ReplacementBonus);
                gridView2.SetRowCellValue(0, "FinanceBonus", obj.FinanceBonus);
                gridView2.SetRowCellValue(0, "DecorationBonus", obj.DecorationBonus);
                gridView2.SetRowCellValue(0, "CarBonus", obj.CarBonus);
                gridView2.SetRowCellValue(0, "UltimateBonus", obj.UltimateBonus);
           

            }
            else
                MessageBox.Show("请先加载奖金数据");
        }


        private void btnGetCarTrial_Click(object sender, EventArgs e)
        {
            if (gridSale_CarTrial.Visible)
            {

                DataTable dt = (DataTable)gridSale_CarTrial.DataSource;
               
                int count = mIAward.GetCountOfCarTrial(mStaff.StaffID, mYear, mMonth);
                gridView4.SetRowCellValue(0, "TrialCount", count);
                gridView4.SetRowCellValue(0, "BonusTrial", count * 30);

                DataRowView dr = (DataRowView)gridView4.GetRow(0);
                decimal ScoreAssessed = (decimal)dr["ScoreAssessed"];
                decimal BonusCheck = (decimal)dr["BonusCheck"];
                decimal BonusTrial = (decimal)dr["BonusTrial"];

                decimal UltimateBonus = (BonusCheck + BonusTrial) * ScoreAssessed;
                gridView4.SetRowCellValue(0, "UltimateBonus", UltimateBonus);


             }
        }


        private void btnLoadBonusData_Click(object sender, EventArgs e)
        {
            frmRCarAward frm = new frmRCarAward();
            frm.FormClosed += new FormClosedEventHandler(BonusCallBack);
            frm.ShowDialog();
        }
        private void BonusCallBack(object sender, FormClosedEventArgs e)
        {
            frmRCarAward frm = (frmRCarAward)sender;
            BonusData = frm.mDt;

        }

        private void txtStaffID_EditValueChanged(object sender, EventArgs e)
        {

        }



        //Get AssginRate
        private decimal GetAssginRateOfStaff()
        {
            decimal reslult = 0;
            DataTable dtBaseSalary = mIAward.GetSalaryBaseByStaffID(mStaff.StaffID);
            if (dtBaseSalary != null)
            {

                reslult = (decimal)dtBaseSalary.Rows[0]["AssginRate"];
                //在表格里初始

            }
            return reslult;
        }

        //Init ordinary
        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
          //  gridView1.SetRowCellValue(e.RowHandle, "AssginRate", GetAssginRateOfStaff());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (mStaffID != "")
            {
                mIAward.DeleteSalaryInfo(mStaffID,Year,Month);
                
                this.Close();

            }
        }

    

      

       

        

     
       

      


    }
}
