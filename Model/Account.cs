using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Account
    {


        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string dHFrom;

        public string DHFrom
        {
            get { return dHFrom; }
            set { dHFrom = value; }
        }



        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private string describes;

        public string Describes
        {
            get { return describes; }
            set { describes = value; }
        }

        private DateTime accountDate;

        public DateTime AccountDate
        {
            get { return accountDate; }
            set { accountDate = value; }
        }


        private string acceptDate;

        public string AcceptDate
        {
            get { return acceptDate; }
            set { acceptDate = value; }
        }


        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private string custName;

        public string CustName
        {
            get { return custName; }
            set { custName = value; }
        }

        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private string plateNum;

        public string PlateNum
        {
            get { return plateNum; }
            set { plateNum = value; }
        }


        private double cash;

        public double Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        private double bank;

        public double Bank
        {
            get { return bank; }
            set { bank = value; }
        }

        private double vip;

        public double Vip
        {
            get { return vip; }
            set { vip = value; }
        }


        private double p2P;

        public double P2P
        {
            get { return p2P; }
            set { p2P = value; }
        }

       

        private string invoiceType;

        public string InvoiceType
        {
            get { return invoiceType; }
            set { invoiceType = value; }
        }

        private string invoiceNum;

        public string InvoiceNum
        {
            get { return invoiceNum; }
            set { invoiceNum = value; }
        }

        private double invoiceAmount;

        public double InvoiceAmount
        {
            get { return invoiceAmount; }
            set { invoiceAmount = value; }
        }

        private string receiveMan;

        public string ReceiveMan
        {
            get { return receiveMan; }
            set { receiveMan = value; }
        }


        private double recAmount;

        public double RecAmount
        {
            get { return recAmount; }
            set { recAmount = value; }
        }

        public double Check
        {
            get;
            set;
        }

        public double Self
        {
            get;
            set;
        }

        public double Integral
        {
            get;
            set;
        }

        public double Quan
        {
            get;
            set;
        }

        private double cs;

        public double Cs
        {
            get { return cs; }
            set { cs = value; }
        }

        private double preRecv;

        public double PreRecv
        {
            get { return preRecv; }
            set { preRecv = value; }
        }

        private double other;

        public double Other
        {
            get { return other; }
            set { other = value; }
        }


     
        public string Remark
        {
            get;
            set;
        }
    }
}
