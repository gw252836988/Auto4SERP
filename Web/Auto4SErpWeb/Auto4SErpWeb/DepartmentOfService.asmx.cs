using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;
using Bll.Personnel;
using Model;
namespace Auto4SErpWeb
{
    /// <summary>
    /// DepartmentOfService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class DepartmentOfService : System.Web.Services.WebService
    {
        public DepartmentOfService()
        {
           


        }

         [WebMethod]
        public DataTable GetDepartments()
        {
            DepartmentBll bll = new DepartmentBll();
            return bll.GetDepartments();
        }

        [WebMethod]
         public DataTable GetDepartmentByID(string id)
         {


             DepartmentBll bll = new DepartmentBll();
           
             return bll.GetDepartmentByID(id);

         }

        [WebMethod]
         public bool AddDepartment(Department depart)
         {
             DepartmentBll bll = new DepartmentBll();
             return bll.AddDepartment(depart);

         }

        [WebMethod]
         public bool UpdateDepartment(Department depart, string id)
         {
             DepartmentBll bll = new DepartmentBll();
             return bll.UpdateDepartment(depart,id);
         }

        [WebMethod]
         public bool ExistsId(Department depart)
         {
             DepartmentBll bll = new DepartmentBll();
             return bll.ExistsId(depart);
         }

        [WebMethod]
         public bool DelDepartmentByID(string id)
         {
             DepartmentBll bll = new DepartmentBll();
             return bll.DelDepartmentByID(id);
         }

         [WebMethod]
        public string AddIDString(string parentid)
        {
            DepartmentBll bll = new DepartmentBll();
            return bll.AddIDString(parentid);
        }
    }
}
