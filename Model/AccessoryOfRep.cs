using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AccessoryOfRep
    {
        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }
        private string xH;

        public string XH
        {
            get { return xH; }
            set { xH = value; }
        }
        private string accessoryCode;

        public string AccessoryCode
        {
            get { return accessoryCode; }
            set { accessoryCode = value; }
        }

        private int accType;

        public int AccType
        {
            get { return accType; }
            set { accType = value; }
        }

        private float amount;

        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private float salePrice;

        public float SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }
        private string takeMan;

        public string TakeMan
        {
            get { return takeMan; }
            set { takeMan = value; }
        }
        private string houseName;

        public string HouseName
        {
            get { return houseName; }
            set { houseName = value; }
        }
        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private string takeDate;

        public string TakeDate
        {
            get { return takeDate; }
            set { takeDate = value; }
        }
        private float inPrice;

        public float InPrice
        {
            get { return inPrice; }
            set { inPrice = value; }
        }
        private string priceType;

        public string PriceType
        {
            get { return priceType; }
            set { priceType = value; }
        }

        private string inType;

        public string InType
        {
            get { return inType; }
            set { inType = value; }
        }

        private string inDate;

        public string InDate
        {
            get { return inDate; }
            set { inDate = value; }
        }

        private int wareID;

        public int WareID
        {
            get { return wareID; }
            set { wareID = value; }
        }


      
        private float discount;

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private float finalPrice;

        public float FinalPrice
        {
            get { return finalPrice; }
            set { finalPrice = value; }
        }
    }
}
