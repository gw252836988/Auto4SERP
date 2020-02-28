using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class CarSale
    {
        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        private decimal orderAmount;

        public decimal OrderAmount
        {
            get { return orderAmount; }
            set { orderAmount = value; }
        }

        private decimal totalPrice;

        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private decimal carPrice;

        public decimal CarPrice
        {
            get { return carPrice; }
            set { carPrice = value; }
        }

        private double insurancePrice;

        public double InsurancePrice
        {
            get { return insurancePrice; }
            set { insurancePrice = value; }
        }

        private decimal decorPrice;

        public decimal DecorPrice
        {
            get { return decorPrice; }
            set { decorPrice = value; }
        }

        public double  PlateFee
        {
            get;
            set;

        }

        private string vin;

        public string Vin
        {
            get { return vin; }
            set { vin = value; }
        }


        private int detailID;

        public int DetailID
        {
            get { return detailID; }
            set { detailID = value; }
        }

        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }


        private decimal loanAmount;

        public decimal LoanAmount
        {
            get { return loanAmount; }
            set { loanAmount = value; }
        }

        private decimal receivableAmount;

        public decimal ReceivableAmount
        {
            get { return receivableAmount; }
            set { receivableAmount = value; }
        }

        private string checkMan;

        public string CheckMan
        {
            get { return checkMan; }
            set { checkMan = value; }
        }

        private int isSpecial;

        public int IsSpecial
        {
            get { return isSpecial; }
            set { isSpecial = value; }
        }


        private string saleType;

        public string SaleType
        {
            get { return saleType; }
            set { saleType = value; }
        }


        private double outFee;

        public double OutFee
        {
            get { return outFee; }
            set { outFee = value; }
        }

        public double UpKeepCharge
        {
            get;
            set;

        }

        public double OilCharge
        {
            get;
            set;
        }
        private double loanIncome;

        public double LoanIncome
        {
            get { return loanIncome; }
            set { loanIncome = value; }
        }


        private double changeIncome;

        public double ChangeIncome
        {
            get { return changeIncome; }
            set { changeIncome = value; }
        }

        private double elseIncome;

        public double ElseIncome
        {
            get { return elseIncome; }
            set { elseIncome = value; }
        }

        private string autoNumber;

        public string AutoNumber
        {
            get { return autoNumber; }
            set { autoNumber = value; }
        }

        private string inCompany;

        public string InCompany
        {
            get { return inCompany; }
            set { inCompany = value; }
        }

        public double BTPrice
        {
            get;
            set;
        }
    }
}
