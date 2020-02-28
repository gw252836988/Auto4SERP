using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class  Accessory
    {
        private string accessoryCode;

        public string AccessoryCode
        {
            get { return accessoryCode; }
            set { accessoryCode = value; }
        }
        private string accessoryName;

        public string AccessoryName
        {
            get { return accessoryName; }
            set { accessoryName = value; }
        }
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        private string storePlace;

        public string StorePlace
        {
            get { return storePlace; }
            set { storePlace = value; }
        }
        private string accessoryType;

        public string AccessoryType
        {
            get { return accessoryType; }
            set { accessoryType = value; }
        }
        private float increaseRate;

        public float IncreaseRate
        {
            get { return increaseRate; }
            set { increaseRate = value; }
        }
        private string changeCode;

        public string ChangeCode
        {
            get { return changeCode; }
            set { changeCode = value; }
        }
        private float salePrice;

        public float SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }

        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        private string applicationModel;

        public string ApplicationModel
        {
            get { return applicationModel; }
            set { applicationModel = value; }
        }

        public string SmallType
        {
            get;
            set;
        }



        public int IsEnabled
        {
            get;
            set;
        }
    }
}
