using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RepairM
    {
        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private string custName;

        public string CustName
        {
            get { return custName; }
            set { custName = value; }
        }


        private string vin;

        public string Vin
        {
            get { return vin; }
            set { vin = value; }
        }


        private string carModel;

        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }


        private string repType;

        public string RepType
        {
            get { return repType; }
            set { repType = value; }
        }
        private string repChildType;

        public string RepChildType
        {
            get { return repChildType; }
            set { repChildType = value; }
        }

        private string receptMan;

        public string ReceptMan
        {
            get { return receptMan; }
            set { receptMan = value; }
        }
        private string preItemAmount;

        public string PreItemAmount
        {
            get { return preItemAmount; }
            set { preItemAmount = value; }
        }
        private string preAccessoryAmount;

        public string PreAccessoryAmount
        {
            get { return preAccessoryAmount; }
            set { preAccessoryAmount = value; }
        }
        private string plateNum;

        public string PlateNum
        {
            get { return plateNum; }
            set { plateNum = value; }
        }
        private string receptTime;

        public string ReceptTime
        {
            get { return receptTime; }
            set { receptTime = value; }
        }
        private string completeTime;

        public string CompleteTime
        {
            get { return completeTime; }
            set { completeTime = value; }
        }

        private string accountTime;

        public string AccountTime
        {
            get { return accountTime; }
            set { accountTime = value; }
        }


        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }


        private string insuranceCompany;

        public string InsuranceCompany
        {
            get { return insuranceCompany; }
            set { insuranceCompany = value; }
        }

        private string sendRepMan;

        public string SendRepMan
        {
            get { return sendRepMan; }
            set { sendRepMan = value; }
        }

        private string sendRepTel;

        public string SendRepTel
        {
            get { return sendRepTel; }
            set { sendRepTel = value; }
        }

        private bool isWillVisit;

        public bool IsWillVisit
        {
            get { return isWillVisit; }
            set { isWillVisit = value; }
        }

        private bool isWash;

        public bool IsWash
        {
            get { return isWash; }
            set { isWash = value; }
        }

        private bool isNeedOld;

        public bool IsNeedOld
        {
            get { return isNeedOld; }
            set { isNeedOld = value; }
        }

        private float gAmount;

        public float GAmount
        {
            get { return gAmount; }
            set { gAmount = value; }
        }

        private string cardNo;

        public string CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }


        private string vipLevel;

        public string VipLevel
        {
            get { return vipLevel; }
            set { vipLevel = value; }
        }

        public string DecorateDH
        {
            get;
            set;
        }


        public string InMil
        {
            get;
            set;
        }

        public string NextKeepMil
        {

            get;
            set;
        }

        public DateTime NextKeepDate
        {

            get;
            set;
        }


        public DateTime EstimateComplete
        {
            get;
            set;

        }
        public string Remark
        {
            get;
            set;

        }

        public string ComeType
        {
            get;
            set;
        }


        public string SystemDH
        {
            get;
            set;
        }

        public decimal AccessAmount
        {
            get;
            set;
        }
    }
}
