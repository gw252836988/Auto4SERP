using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public partial class Staff
    {
		private int _id;
		private string _staffid;
		private string _staffname;
		private string _pwd;
		private int _positionid;
		private string _departmentid;
		private string _education;
		private string _sex;
		private int _stature;
		private string _nativeplace;
		private string _nation;
		private string _ismarryed;
		private string _graduateschool;
		private string _specialty;
		private string _identitynumber;
		private string _registeredaddress;
		private string _nowaddress;
		private string _mobile;
		private string _phone;
		private DateTime _birthdate;
		private DateTime _entrydate;
		private DateTime _contractstartdate;
		private DateTime _contractenddate;
		private string _email;
		private string _organid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StaffID
		{
			set{ _staffid=value;}
			get{return _staffid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StaffName
		{
			set{ _staffname=value;}
			get{return _staffname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PositionID
		{
			set{ _positionid=value;}
			get{return _positionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DepartmentID
		{
			set{ _departmentid=value;}
			get{return _departmentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Education
		{
			set{ _education=value;}
			get{return _education;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Stature
		{
			set{ _stature=value;}
			get{return _stature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NativePlace
		{
			set{ _nativeplace=value;}
			get{return _nativeplace;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Nation
		{
			set{ _nation=value;}
			get{return _nation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsMarryed
		{
			set{ _ismarryed=value;}
			get{return _ismarryed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GraduateSchool
		{
			set{ _graduateschool=value;}
			get{return _graduateschool;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Specialty
		{
			set{ _specialty=value;}
			get{return _specialty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IdentityNumber
		{
			set{ _identitynumber=value;}
			get{return _identitynumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegisteredAddress
		{
			set{ _registeredaddress=value;}
			get{return _registeredaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NowAddress
		{
			set{ _nowaddress=value;}
			get{return _nowaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BirthDate
		{
			set{ _birthdate=value;}
			get{return _birthdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EntryDate
		{
			set{ _entrydate=value;}
			get{return _entrydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ContractStartDate
		{
			set{ _contractstartdate=value;}
			get{return _contractstartdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ContractEndDate
		{
			set{ _contractenddate=value;}
			get{return _contractenddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrganId
		{
			set{ _organid=value;}
			get{return _organid;}
		}

        private string organName;

        public string OrganName
        {
            get { return organName; }
            set { organName = value; }
        }

        private string positionName;

        public string PositionName
        {
            get { return positionName; }
            set { positionName = value; }
        }
        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

	}
}

