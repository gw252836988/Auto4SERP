﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarInD
    {



        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private int carDetail;

        public int CarDetail
        {
            get { return carDetail; }
            set { carDetail = value; }
        }

        private decimal inPrice;

        public decimal InPrice
        {
            get { return inPrice; }
            set { inPrice = value; }
        }


       

        private string storePlace;

        public string StorePlace
        {
            get { return storePlace; }
            set { storePlace = value; }
        }

        private string vin;

        public string Vin
        {
            get { return vin; }
            set { vin = value; }
        }

        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        private string autoNumber;

        public string AutoNumber
        {
            get { return autoNumber; }
            set { autoNumber = value; }
        }
    }
}
