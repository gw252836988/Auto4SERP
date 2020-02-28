using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class OrdinaryPost
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

        public decimal ElseBonusPlus
        {
            get;
            set;

        }

        public decimal ElseBonusMinus
        {
            get;
            set;

        }


        public decimal UltimateBonus
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

        public DateTime CreateDate
        {
            get;
            set;
        }
    }
}
