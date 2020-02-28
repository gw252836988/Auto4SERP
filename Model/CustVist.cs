using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class CustVist
    {
        public CustVist()
        { }
        #region Model
        private string _mobile;
        private string _vistway;
        private string _vistreason;
        private string _intentcarmodel;
        private string _intentcarser;
        private string _intentcolor;
        private string _intentcarbrand;
        private string _intentdisplacement;
        private string _intentinnerstyle;
        private decimal _intentprice;
        private string _contactphone;
        private string _elsedemand;
        private string _intenttransmission;
        private DateTime  _visttime;
        private string _register;
        private string  _intentlevel;
        private string _salesman;
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string CustName
        {
            get;
            set;


        }
        /// <summary>
        /// 
        /// </summary>
        public string Mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VistWay
        {
            set { _vistway = value; }
            get { return _vistway; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VistReason
        {
            set { _vistreason = value; }
            get { return _vistreason; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IntentCarModel
        {
            set { _intentcarmodel = value; }
            get { return _intentcarmodel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IntentCarSer
        {
            set { _intentcarser = value; }
            get { return _intentcarser; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IntentColor
        {
            set { _intentcolor = value; }
            get { return _intentcolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IntentCarBrand
        {
            set { _intentcarbrand = value; }
            get { return _intentcarbrand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IntentDisplacement
        {
            set { _intentdisplacement = value; }
            get { return _intentdisplacement; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IntentInnerStyle
        {
            set { _intentinnerstyle = value; }
            get { return _intentinnerstyle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal IntentPrice
        {
            set { _intentprice = value; }
            get { return _intentprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ContactPhone
        {
            set { _contactphone = value; }
            get { return _contactphone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ElseDemand
        {
            set { _elsedemand = value; }
            get { return _elsedemand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IntentTransmission
        {
            set { _intenttransmission = value; }
            get { return _intenttransmission; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime  VistTime
        {
            set { _visttime = value; }
            get { return _visttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Register
        {
            set { _register = value; }
            get { return _register; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IntentLevel
        {
            set { _intentlevel = value; }
            get { return _intentlevel; }
        }

        public string SalesMan
        {
            set { _salesman = value; }
            get { return _salesman; }
        }

        #endregion Model

        

    }
}
