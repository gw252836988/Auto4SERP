using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Bll.Personnel
{
    public class PositionBllWS : IPosition
    {
        private Bll.positionws.PositionOfService  mWS;
        public PositionBllWS()
        {
           // ServiceReference1.Service1SoapClient aa = new ServiceReference1.Service1SoapClient();

            mWS = new Bll.positionws.PositionOfService();
        }

        public DataTable GetPositions()
        {
            return mWS.GetPositions();

        }


        public DataTable GetPositionsByDepartmentID(string did)
        {

            return mWS.GetPositionsByDepartmentID(did);
        }

        public DataTable GetPositionByID(string id)
        {
            return mWS.GetPositionByID(id);
        }

        public bool AddPosition(string departmentid, string positionname)
        {
            return mWS.AddPosition(departmentid,positionname);
        }

        public bool UpdateDepartment(string departmentid, string positionname, string id)
        {
            return mWS.UpdateDepartment(departmentid, positionname,id);
        }

        public string GetPositionidByName(string name)
        {
            return mWS.GetPositionidByName(name);

        }
        public bool ExistsId(string positionname)
        {
            return mWS.ExistsId(positionname);

        }


        public bool DelDepartmentByID(string id)
        {
            return mWS.DelDepartmentByID(id);

        }
    }
}
