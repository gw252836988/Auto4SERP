﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class Car
    {
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
        private string carModel;

        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }
        private string carSer;

        public string CarSer
        {
            get { return carSer; }
            set { carSer = value; }
        }
        private string carBrand;

        public string CarBrand
        {
            get { return carBrand; }
            set { carBrand = value; }
        }

        private string carColor;

        public string CarColor
        {
            get { return carColor; }
            set { carColor = value; }
        }

        private string vin;

        public string Vin
        {
            get { return vin; }
            set { vin = value; }
        }

        public string InsuranceCompany
        {
            get;
            set;
        }

        public DateTime InBegin
        {
            get;
            set;
        }


        public DateTime InEnd
        {
            get;
            set;
        }


        public string BuyHere
        {
            get;
            set;
        }

        public DateTime KeepBegin
        {
            get;
            set;
        }

        public DateTime KeepEnd
        {
            get;
            set;
        }

        public string EngineID
        {
            get;
            set;
        }
    }
}
