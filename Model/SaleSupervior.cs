using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SaleSupervior
    {
        public int ID
        {
            get;
            set;

        }


        public string StaffID
        {
            get;
            set;
        }

        public int Year
        {

            get;
            set;
        }

        public int Month
        {
            get;
            set;

        }
        public decimal FirstCount
        {
            get;
            set;
        }

        public decimal MiddleCount
        {
            get;
            set;
        }

        public decimal LastCount
        {
            get;
            set;
        }

        public decimal FirstBonus
        {
            get;
            set;
        }
        public decimal MiddleBonus
        {
            get;
            set;
        }

        public decimal LastBonus
        {
            get;
            set;
        }

        public decimal ScoreAssessed
        {
            get;
            set;
        }

        public decimal Adjust
        {
            get;
            set;
        }


        public decimal UltimateBonus
        {
            get;
            set;
        }
    }
}
