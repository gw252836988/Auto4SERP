using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bll.departmentws;
using System.Reflection;
namespace Bll.Personnel
{
    public class DepartmentBllWS:IDepartment
    {
        private DepartmentOfService mWS;

        public DepartmentBllWS()
        {
            mWS = new DepartmentOfService();
        }

        public DataTable GetDepartments()
        {
           return mWS.GetDepartments();

        }

        public DataTable GetDepartmentByID(string id)
        {
            return mWS.GetDepartmentByID(id);
        }

        public bool AddDepartment(Model.Department depart)
        {


            return mWS.AddDepartment(ObjectConvert(depart));
        }

        public bool UpdateDepartment(Model.Department depart, string id)
        {
            return mWS.UpdateDepartment(ObjectConvert(depart), id);
        }

        public bool ExistsId(Model.Department depart)
        {
            return mWS.ExistsId(ObjectConvert(depart));

        }



        private Department ObjectConvert(Model.Department obj)
        {
            Department newobj = new Department();

            Type type = typeof(Department);
            //取得属性集合
            PropertyInfo[] pi = type.GetProperties();
            foreach (PropertyInfo item in pi)
            {
                PropertyInfo pi1 = typeof(Model.Department).GetProperty(item.Name);
                object value = pi1.GetValue(obj,null);

                item.SetValue(newobj, Convert.ChangeType(value, item.PropertyType), null);
            }
            return newobj;
        }


        public bool DelDepartmentByID(string id)
        {
            return mWS.DelDepartmentByID(id);
        }

        public string AddIDString(string parentid)
        {
            return mWS.AddIDString(parentid);

        }

    }
}
