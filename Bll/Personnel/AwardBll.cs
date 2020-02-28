using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Comm;
using DBUtil;
using System.Data;
using System.Data.SqlClient;
namespace Bll.Personnel
{
    public class AwardBll : Bll.Personnel.IAward, Bll.IBatchIn
    {
         private DBHelper mDB;
        

        public AwardBll()
        {
            mDB=DBHelperShare.getPInstance();

        }

        public DataTable GetAwards()
        {
            string sql = "select * from saleaward";
            return mDB.ExecuteDataTable(sql);

        }

        public string BatchInDB(DataTable dt, string append)
        {
            try
            {
                string sql = "";
                DelTempRecord();
                mDB.BatchInsert("tmp_saleaward", dt);

                sql = "insert into saleaward([CarSer],[CarModel],[award]) select CarSer,CarModel,award from tmp_saleaward";
                mDB.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                DelTempRecord();

                return e.Message.ToString();

            }
            return "";

        }

        private void DelTempRecord()
        {

            mDB.ExecuteNonQuery("delete from tmp_saleaward;delete from saleaward");

        }

        //code follewed about salary


         // 一般岗位
         public void AddRecOfOrdinaryPost(string staffid ,int year ,int month)
         {
             string sql = string.Format("select * from ordinary_post  where staffid='{0}' and year={1} and month={2}",staffid ,year,month);
             if (!mDB.IsExists(sql))
             {
                 sql = string.Format("insert into ordinary_post(staffid ,year ,month) values('{0}',{1},{2})", staffid, year, month);
                 mDB.ExecuteNonQuery(sql);
             }
         }
         public DataTable GetRecOfOrdinaryPost(string staffid, int year, int month)
         {
             string sql = string.Format("select * from ordinary_post  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             return mDB.ExecuteDataTable(sql);
         }
         public void UpdateOrdinaryPost(OrdinaryPost obj)
         {
             string sql = "";
             sql = "update ordinary_post set BonusBeforeAssess={0},AssginRate={1},ScoreAssessed={2},Adjust={3},ElseBonusPlus={4},ElseBonusMinus={5},UltimateBonus={6} where ID ={7}";
             sql = string.Format(sql,obj.BonusBeforeAssess,obj.AssginRate,obj.ScoreAssessed,obj.Adjust,obj.ElseBonusPlus,obj.ElseBonusMinus,obj.UltimateBonus,obj.ID);
             mDB.ExecuteNonQuery(sql);
         }

         //销售顾问
         public void AddRecOfSaleCounselor(string staffid, int year, int month)
         {

             string sql = string.Format("select * from sale_counselor  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             if (!mDB.IsExists(sql))
             {
                 sql = string.Format("insert into sale_counselor(staffid ,year ,month) values('{0}',{1},{2})", staffid, year, month);
                 mDB.ExecuteNonQuery(sql);
             }
         }
         public DataTable GetRecOfSaleCounselor(string staffid, int year, int month)
         {
             string sql = string.Format("select * from sale_counselor  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             return mDB.ExecuteDataTable(sql);
         }
         public void UpdateSaleCounselor(SaleCounselor obj)
         {
             string sql = "";
             sql = "update sale_counselor set SaleCount={0},SecondCount={1},CarBonus={2},SecondBonus={3},LongTermBonus={4},ProlongInsuranceBonus={5},InsuranceBonus={6},DecorationBonus={7},ReplacementBonus={8},FinanceBonus={9},FRentBonus={10},RentBonus={11},SynthesisBonus={12},ScoreAssessed={13},UltimateBonus={14} where ID ={15}";
             sql = string.Format(sql, obj.SaleCount, obj.SecondBonus, obj.CarBonus, obj.SecondBonus, obj.LongTermBonus, obj.ProlongInsuranceBonus, obj.InsuranceBonus, obj.DecorationBonus,obj.ReplacementBonus ,obj.FinanceBonus,obj.FRentBonus,obj.RentBonus,obj.SynthesisBonus,obj.ScoreAssessed,obj.UltimateBonus,obj.ID);
             mDB.ExecuteNonQuery(sql);
         }

         //销售经理
         public int AddRecOfSaleSupervior(string staffid ,int year,int month)
         {
             int r = 0;
             string sql = string.Format("select * from Sale_Supervior  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             if (!mDB.IsExists(sql))
             {
                 sql = string.Format("insert into Sale_Supervior(staffid ,year ,month) values('{0}',{1},{2})", staffid, year, month);
                 mDB.ExecuteNonQuery(sql);
                 r = 1;
             }
             return r;

         }
         public DataTable GetRecOfSaleSupervior(string staffid, int year, int month)
         {
             string sql = string.Format("select * from Sale_Supervior  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             return mDB.ExecuteDataTable(sql);

         }
         public void UpdateSaleSupervior(SaleSupervior obj)
         {
             string sql = "";
             sql = "update Sale_Supervior set FirstCount={0},MiddleCount={1},LastCount={2},FirstBonus={3},MiddleBonus={4},LastBonus={5},ScoreAssessed={6},Adjust={7},UltimateBonus={8} where ID ={9}";
             sql = string.Format(sql, obj.FirstCount, obj.MiddleCount, obj.LastCount, obj.FirstBonus, obj.MiddleBonus, obj.LastBonus, obj.ScoreAssessed, obj.Adjust, obj.UltimateBonus, obj.ID);
             mDB.ExecuteNonQuery(sql);
         }


         //上牌及客服
         public int AddRecOfPlateService(string staffid, int year, int month)
         {
             int r = 0;
             string sql = string.Format("select * from sale_plateandservice  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             if (!mDB.IsExists(sql))
             {
                 sql = string.Format("insert into sale_plateandservice(staffid ,year ,month) values('{0}',{1},{2})", staffid, year, month);
                 mDB.ExecuteNonQuery(sql);
                 r = 1;
             }
             return r;

         }
         public DataTable GetRecOfPlateService(string staffid, int year, int month)
         {
             string sql = string.Format("select * from sale_plateandservice  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             return mDB.ExecuteDataTable(sql);
         }
         public void UpdatePlateService(SalePlateService obj)
         {
             string sql = "";
             sql = "update sale_plateandservice set PlateCount={0},PlateBonus ={1},ElsePlus={2},PhoneCount={3},RecordCount={4},VisitCount={5},ScoreAssessed={6},UltimateBonus={7} where ID ={8}";
             sql = string.Format(sql, obj.PlateCount, obj.PlateBonus, obj.ElsePlus, obj.PhoneCount, obj.RecordCount, obj.VisitCount, obj.ScoreAssessed, obj.UltimateBonus, obj.ID);
             mDB.ExecuteNonQuery(sql);
         }


        //金融顾问
         public int AddRecOfSaleFinance(string staffid, int year, int month)
         {
             int r = 0;
             string sql = string.Format("select * from sale_finance  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             if (!mDB.IsExists(sql))
             {
                 sql = string.Format("insert into sale_finance(staffid ,year ,month) values('{0}',{1},{2})", staffid, year, month);
                 mDB.ExecuteNonQuery(sql);
                 r = 1;
             }
             return r;

         }
         public DataTable GetRecOfSaleFinance(string staffid, int year, int month)
         {
             string sql = string.Format("select * from sale_finance  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             return mDB.ExecuteDataTable(sql);
         }

         public void UpdateRecOfSaleFinance(SaleFinance obj)
         {
             string sql = "";
             sql = "update sale_finance set BonusBeforeAssess={0},AssginRate ={1},XSXCount={2},XSXBonus={3},DCXCount={4},DCXBonus={5},JRDCount={6},JRDBonus={7},ScoreAssessed={8},UltimateBonus={9} where ID ={10}";
             sql = string.Format(sql, obj.BonusBeforeAssess, obj.AssginRate, obj.XSXCount, obj.XSXBonus, obj.DCXCount, obj.DCXBonus, obj.JRDCount, obj.JRDBonus, obj.ScoreAssessed,obj.UltimateBonus,obj.ID);
             mDB.ExecuteNonQuery(sql);
         }

         //试乘试驾
         public void AddCarTrialRecord(CarTrialRecord obj)
         {
            string sql = "INSERT INTO  [cartrial_record]"
            + "([Year]"
            + ",[Month]"
            + " ,[trial_date]"
            + ",[Mobile]"
            + ",[CustName]"
            + ",[StaffID]"
            + ",[Organ])"
            + " VALUES"
            + "({0},{1},'{2}','{3}','{4}','{6}','{5}')";

           sql = string.Format(sql,obj.Year,obj.Month,obj.TrialDate,obj.Mobile,obj.CustName,obj.Organ,obj.StaffID);
           mDB.ExecuteNonQuery(sql);

         }
         public void UpdateCarTrialRecord(CarTrialRecord obj)
         {
             string sql = 
             "UPDATE  [cartrial_record] " +
             "set [trial_date] ='{0}'" +
             ",[Mobile] = '{1}'" +
              ",[StaffID] = '{4}'" + 
             ",[CustName] = '{2}'  where ID={3}";

             sql = string.Format(sql,obj.TrialDate,obj.Mobile,obj.CustName,obj.ID,obj.StaffID);
             mDB.ExecuteNonQuery(sql);

         }
         public DataTable  GetCarTrialRecord(int year ,int month,string staffid,string organ)
         { 
             string sql = string.Format("select * from cartrial_record where year={0} and month={1} ",year,month);
             if (staffid != "")
             {
                 sql = sql + " and StaffID='" + staffid + "'";
             }

             if (organ != "")
             {
                 sql = sql + " and Organ='" + organ + "'";
             }

             DataTable dt = mDB.ExecuteDataTable(sql);

             return dt;
         }

         public void DeleteCarTrialRecord(int id)
         {
             string sql = string.Format("delete from cartrial_record  where id=" + id );
             mDB.ExecuteNonQuery(sql);
         }
         public int AddRecOfSaleCartrial(string staffid, int year, int month)
         {
             int r = 0;
             string sql = string.Format("select * from sale_cartrial  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             if (!mDB.IsExists(sql))
             {
                 sql = string.Format("insert into sale_cartrial(staffid ,year ,month) values('{0}',{1},{2})", staffid, year, month);
                 mDB.ExecuteNonQuery(sql);
                 r = 1;
             }
             return r;
         }
         public DataTable GetRecOfSaleCartrial(string staffid, int year, int month)
         {
             string sql = string.Format("select * from sale_cartrial  where staffid='{0}' and year={1} and month={2}", staffid, year, month);
             return mDB.ExecuteDataTable(sql);

         }
         public void UpdateRecOfSaleCartrial(SaleCarTrial obj)
         {
             string sql =
             "UPDATE  [sale_cartrial] " +
             "set [TrialCount] ={0}" +
             ",[BonusTrial] = {1}" +
             ",[CheckCount] = {2}" +
             ",[BonusCheck] = {3}" +
             ",[ScoreAssessed] = {4}" +
             ",[UltimateBonus] = {5}" +
             "  where ID={6}";
             sql = string.Format(sql, obj.TrialCount, obj.BonusTrial, obj.CheckCount,obj.BounusCheck,obj.ScoreAssessed,obj.UltimateBonus, obj.ID);
             mDB.ExecuteNonQuery(sql);
         }
         public int GetCountOfCarTrial(string staffid,int year,int month)
         {
             string sql =string.Format( "select count(*) from cartrial_record where staffid='{0}' and year={1} and month={2}",staffid,year,month);
             DataTable dt=mDB.ExecuteDataTable(sql);
             int result = 0;
             if (dt != null && dt.Rows.Count > 0)
             {
                 result = int.Parse(dt.Rows[0][0].ToString());

             }
             return result;
         }
         

         //工资
         public void UpdateSalary(Salary obj)
         {
             string sql = " UPDATE [salary] Set " +
                 "[BasicSalary] = {3}" +
                " ,[PositionAllowance] = {4}" +
                 ",[CertificationBonus] ={5}" +
      " ,[ExpenseAllowance] ={6}" +
      " ,[ElsePlus] = {7}" +
     " ,[ElseMinus] ={8}" +
     " ,[ClothAllowance] = {9}" +
     " ,[TotalBonus] = {10}" +
      ",[ClothDeducted] ={11}" +
     " ,[LaborUnionDeducted] = {12}" +
      ",[MutualHelpDeducted] ={13}" +
      ",[AssessDeducted] = {14}" +
      ",[TrainingAllowance] = {15}" +
      ",[ViolateDeducted] ={16}" +
      ",[FundDeducted] ={17}" +
      ",[InsuranceDeducted] = {18}" +
      ",[SepecialDeducted] ={19}" +
      ",[TaxDeducted] = {20}" +
      ",[ActualSalary] = {21}" +
      ",[DeserveSalary] = {22}" +
      " where [StaffID]='{0}' and year={1} and month={2} ";

             sql = string.Format(sql, obj.StaffID, obj.Year, obj.Month, obj.BasicSalary, obj.PositionAllowance, obj.CertificationBonus, obj.ExpenseAllowance, obj.ElsePlus, obj.ElseMinus, obj.ClothAllowance, obj.TotalBonus, obj.ClothDeducted, obj.LaborUnionDeducted, obj.MutualHelpDeducted, obj.AssessDeducted, obj.TrainingAllowance, obj.ViolateDeducted, obj.FundDeducted, obj.InsuranceDeducted, obj.SepecialDeducted, obj.TaxDeducted, obj.ActualSalary, obj.DeserveSalary);
             mDB.ExecuteNonQuery(sql);

         }
         public DataTable GetSalaryList(int year ,int month ,string inputman)
         {
             string sql = string.Format("select * from salary where year={0} and month={1}",year,month);
             if (inputman != "")
             {
                 sql = sql + " and inputman='" + inputman  + "'";
             }
             return mDB.ExecuteDataTable(sql);

         }
         public Salary GetSalaryOfOneStaff(string staffid,int year ,int month)
         {
             string sql = string.Format("select * from salary where staffid='{0}' and year={1} and month={2}",staffid,year,month);
             DataTable dt = mDB.ExecuteDataTable(sql);
             Salary obj = null ;
             if(dt!=null && dt.Rows.Count>0)
             {
                 obj = new Salary();
                 obj.BasicSalary = (decimal)dt.Rows[0]["BasicSalary"];
                 obj.PositionAllowance = (decimal)dt.Rows[0]["PositionAllowance"];
                 obj.CertificationBonus = (decimal)dt.Rows[0]["CertificationBonus"];
                 obj.ExpenseAllowance = (decimal)dt.Rows[0]["ExpenseAllowance"];
                 obj.ElsePlus = (decimal)dt.Rows[0]["ElsePlus"];
                 obj.ElseMinus = (decimal)dt.Rows[0]["ElseMinus"];
                 obj.ClothAllowance = (decimal)dt.Rows[0]["ClothAllowance"];
                 obj.TotalBonus = (decimal)dt.Rows[0]["TotalBonus"];
                 obj.ClothDeducted = (decimal)dt.Rows[0]["ClothDeducted"];
                 obj.LaborUnionDeducted = (decimal)dt.Rows[0]["LaborUnionDeducted"];
                 obj.MutualHelpDeducted = (decimal)dt.Rows[0]["MutualHelpDeducted"];
                 obj.AssessDeducted = (decimal)dt.Rows[0]["AssessDeducted"];
                 obj.TrainingAllowance = (decimal)dt.Rows[0]["TrainingAllowance"];
                 obj.ViolateDeducted = (decimal)dt.Rows[0]["ViolateDeducted"];
                 obj.FundDeducted = (decimal)dt.Rows[0]["FundDeducted"];
                 obj.InsuranceDeducted = (decimal)dt.Rows[0]["InsuranceDeducted"];
                 obj.SepecialDeducted = (decimal)dt.Rows[0]["SepecialDeducted"];
                 obj.TaxDeducted = (decimal)dt.Rows[0]["TaxDeducted"];
                 obj.ActualSalary = (decimal)dt.Rows[0]["ActualSalary"];
                 obj.DeserveSalary = (decimal)dt.Rows[0]["DeserveSalary"];
                 
                 }

               return obj;
           }
         public int AddRecOfSalary(Salary obj, int year, int month)
         {
             int r = 0;
             string sql = string.Format("select * from salary  where staffid='{0}' and year={1} and month={2}", obj.StaffID, year, month);
             if (!mDB.IsExists(sql))
             {
                 sql = string.Format("insert into salary(staffid ,year ,month,staffname,department,position,InputMan,Brand,Region) values('{0}',{1},{2},'{3}','{4}','{5}','{6}','{7}','{8}')", obj.StaffID, year, month, obj.StafffName, obj.Department, obj.Position,Comm.LoginInfoShare.getInstance().UserName,obj.Brand,obj.Region);
                 mDB.ExecuteNonQuery(sql);
                 r = 1;
             }
             return r;
         }
    
         //工资日期
         public void UpdateSalaryDate(int year,int month)
         {
             string sql = string.Format("update salary_date set year={0} , month={1} where id=1",year,month);
             mDB.ExecuteNonQuery(sql);
         }

         public DataTable GetSalaryDate()
         {
             string sql = "select * from salary_date where id=1";
             return mDB.ExecuteDataTable(sql);

         }
        

        //基本工资信息
        public void UpdateSalaryBase(string staffid, decimal basicSalary, decimal assginRate, decimal insurance, decimal fund, decimal laborunit, decimal positionAllowance)
        {
            string sql="";
            sql="select * from salary_base where staffid='" +staffid  + "'";

            if(!mDB.IsExists(sql))
            {
                sql = string.Format("insert salary_base (StaffID,BasicSalary,AssginRate,InsuranceDeducted,FundDeducted,LaborUnionDeducted,PositionAllowance) values('{0}',{1},{2},{3},{4},{5},{6})", staffid, basicSalary, assginRate, insurance, fund, laborunit,positionAllowance);
                mDB.ExecuteNonQuery(sql);
            }
            else
            {
                sql = string.Format(string.Format("update salary_base set BasicSalary={0},AssginRate={1},InsuranceDeducted={2},FundDeducted={3},LaborUnionDeducted={4},PositionAllowance={6} where StaffID='{5}'", basicSalary, assginRate, insurance, fund, laborunit, staffid,positionAllowance));
                mDB.ExecuteNonQuery(sql);       
            }
        }
        public DataTable GetSalaryBases()
        {
            string sql = "";
            sql = "select * from salary_base";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;


        }
        public DataTable GetSalaryBaseByStaffID(string staffID)
        {
            string sql = "";
            sql = "select * from salary_base where staffid='" + staffID + "'";
            DataTable dt = mDB.ExecuteDataTable(sql);;

            if (dt.Rows.Count > 0)
                return dt;
            else
                return null;
        }

        //删除某月员工的工资信息
        public void DeleteSalaryInfo(string staffid,int year ,int month)
        {
            string sql = "delete from salary where staffid='{0}' and year={1} and month={2};";
            sql += "delete from sale_cartrial where staffid='{0}' and year={1} and  month={2};";
            sql += "delete from sale_counselor where staffid='{0}' and year={1} and month={2};";
            sql += "delete from sale_finance where staffid='{0}' and year={1} and  month={2};";
            sql += "delete from sale_plateandservice where staffid='{0}' and year={1} and month={2};";
            sql += "delete from sale_supervior where staffid='{0}' and year={1} and month={2};";
            sql = string.Format(sql,staffid,year,month);
            mDB.ExecuteNonQuery(sql);
        }


    }



}
