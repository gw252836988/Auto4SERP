using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Personnel
{
    public interface IDepartment
    {

        DataTable GetDepartments();
         DataTable GetDepartmentByID(string id);
        bool AddDepartment(Department depart);
        bool UpdateDepartment(Department depart, string id);
        bool ExistsId(Department depart);

        bool DelDepartmentByID(string id);
        string AddIDString(string parentid);
    }
}
