using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public interface IPosition
    {
       DataTable GetPositions();
       DataTable GetPositionByID(string id);
       bool AddPosition(string departmentid, string positionname);
       bool UpdateDepartment(string departmentid, string positionname, string id);
       bool ExistsId(string positionname);
       bool DelDepartmentByID(string id);
    }
}
