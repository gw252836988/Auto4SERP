using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class P2PUserInfo
    {
        public P2PUserInfo()
        {
        }
        int user_id;

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        string username;

        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }


        string realname;

        public string REALNAME
        {
            get { return realname; }
            set { realname = value; }
        }

    
        string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        string mobilePhone;

        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }
        decimal use_money;

        public decimal Use_money
        {
            get { return use_money; }
            set { use_money = value; }
        }
        decimal integral;

        public decimal Integral
        {
            get { return integral; }
            set { integral = value; }
        }

        private decimal carBao;

        public decimal CarBao
        {
            get { return carBao; }
            set { carBao = value; }
        }

        private string operateCode;

        public string OperateCode
        {
            get { return operateCode; }
            set { operateCode = value; }
        }

        private double amount;

        public double Amount
        {
          get { return amount; }
          set { amount = value; }
        }


        private string recvUnit;

        public string RecvUnit
        {
            get { return recvUnit; }
            set { recvUnit = value; }
        }

        private string dHFrom;

        public string DHFrom
        {
            get { return dHFrom; }
            set { dHFrom = value; }
        }

        private string payType;

        public string PayType
        {
            get { return payType; }
            set { payType = value; }
        }
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private double virtualMoney;

        public double VirtualMoney
        {
            get { return virtualMoney; }
            set { virtualMoney = value; }
        }
        public string Append
        {
            get;
            set;

        }
    }

    public class P2PMsg
    {
        public P2PMsg()
        {
        }

        string  oper;
        string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Oper
        {
            get { return oper; }
            set { oper = value; }
        }

        private List<P2PUserInfo> list = new List<P2PUserInfo>();

        public List<P2PUserInfo> List
        {
            get { return list; }
            set { list = value; }
        }

    
    }
}
