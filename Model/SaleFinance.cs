using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SaleFinance
    {

        public int ID
        {
            get;
            set;
        }
        public decimal BonusBeforeAssess
        {
            get;
            set;
        }

        public decimal AssginRate
        {
            get;
            set;
        }

        public int XSXCount
        {
            get;
            set;

        }

        public decimal XSXBonus
        {
            get;
            set;
        }
        public int DCXCount
        {
            get;
            set;
        }
        public decimal DCXBonus
        {
            get;
            set;
        }
        public int JRDCount
        {
            get;
            set;
        }
        public decimal JRDBonus
        {
            get;
            set;
        }
        public decimal ScoreAssessed
        {
            get;
            set;
        }
        public decimal UltimateBonus
        {
            get;
            set;
        }
        public string  StaffID
        {
            get;
            set;
        }
        public int Month
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }
    }
}
