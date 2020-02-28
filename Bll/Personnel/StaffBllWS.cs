﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.localhost;
using System.Data;
using System.Reflection;

namespace Bll.Personnel
{
    public class StaffBllWS:IStaff,IBatchIn
    {
        private StaffOfService mWS;
     
        
        public StaffBllWS()
        {
           // ServiceReference1.Service1SoapClient aa = new ServiceReference1.Service1SoapClient();

            mWS = new StaffOfService();
        }

        public Model.Staff GetStaff(string staffid)
        {
            
            //ServiceReference1.Service1SoapClient aa = new ServiceReference1.Service1SoapClient();
            //ServiceReference1.Staff obj_s = aa.GetStaff(staffid);

            Staff obj_s = mWS.GetStaff(staffid);
            if (obj_s == null)
                return null;
            else
                return ObjectDeConvert(obj_s);
            
        }

         public DataTable GetStaffNameOfOrgan(string organid)
        {

            return mWS.GetStaffNameOfOrgan(organid);
             
         }

        public DataTable GetStaffsByQuery(List<Model.SqlElement> lst, string organid, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {

            return mWS.GetStaffsByQuery(SqlElementConvert(lst), organid, PageIndex, PageSize, out RecordCount, out PageCount);

        }

        public bool ValidateLogin(string staffid, string pwd)
        {
            return mWS.ValidateLogin(staffid, pwd);
        }

        public bool AddStaff(Model.Staff obj)
        {

            return mWS.AddStaff(ObjectConvert(obj));
        }
        public DataTable GetSalersOfOrgan(string organid)
        {

            return mWS.GetSalersOfOrgan(organid);
        }


        private Staff ObjectConvert(Model.Staff obj)
        {
            Staff newobj = new Staff();

            Type type = typeof(Staff);
            //取得属性集合
            PropertyInfo[] pi = type.GetProperties();
            foreach (PropertyInfo item in pi)
            {
                PropertyInfo pi1 = typeof(Model.Staff).GetProperty(item.Name);
                object value = pi1.GetValue(obj,null);

                item.SetValue(newobj, Convert.ChangeType(value, item.PropertyType), null);
            }
            return newobj;
        }


        private Model.Staff ObjectDeConvert(Staff  obj)
        {
            Model.Staff newobj = new Model.Staff();
            Type type = typeof(Model.Staff);
            //取得属性集合
            PropertyInfo[] pi = type.GetProperties();
           
            foreach (PropertyInfo item in pi)
            {
                PropertyInfo pi1 = typeof(Staff).GetProperty(item.Name);
                object value = pi1.GetValue(obj,null);

                item.SetValue(newobj, Convert.ChangeType(value, item.PropertyType), null);
            }
            return newobj;

        }

   

        private SqlElement[] SqlElementConvert(List<Model.SqlElement> lst)
        {
            // SqlElement[] newLst = new SqlElement[2]{};

            List<SqlElement> newLst = new List<SqlElement>();


            foreach (Model.SqlElement obj in lst)
            {
                SqlElement newobj = new SqlElement();
                newobj.Name = obj.Name;
                newobj.Value = obj.Value;
                newobj.IsStr = obj.IsStr;
                newobj.IsFuzzy = obj.IsFuzzy;
                newLst.Add(newobj);

            }

            return newLst.ToArray();


        }


        public string BatchInDB(DataTable dt, string strappend)
        {
            return mWS.BatchInDB(dt, strappend);

        }


        public bool UpdateStaff(Model.Staff obj)
        {
            return mWS.UpdateStaff(ObjectConvert(obj));

        }


        public void DeleteStaff(string staffid)
        {
             mWS.DeleteStaff(staffid);


        }


       public void  UpdateStaffPwd(string staffid,string pwd)
        {
            mWS.UpdateStaffPwd(staffid,pwd);

        }


       public void AddInfo(string txt)
       {
           mWS.AddInfo(txt);
       }

       public DataTable GetLatestInfos()
       {
           return mWS.GetLatestInfos();
       }



    
    }
}
