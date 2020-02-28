using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarInH
    {
        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        private string inDate;

        public string InDate
        {
            get { return inDate; }
            set { inDate = value; }
        }

        private string supplier;

        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }


        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private string inPattern;

        public string InPattern
        {
            get { return inPattern; }
            set { inPattern = value; }
        }

        private string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        private string operatorMan;

        public string OperatorMan
        {
            get { return operatorMan; }
            set { operatorMan = value; }
        }


    }
}
