using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using Bll.Personnel;
using Model;
using System.Data;
namespace Auto4SErpWeb
{
    /// <summary>
    /// PositionOfService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class PositionOfService : System.Web.Services.WebService
    {

        

        //Position
        [WebMethod]
        public DataTable GetPositions()
        {
            PositionBll bll = new PositionBll();
            return bll.GetPositions();

        }

        [WebMethod]
        public DataTable GetPositionsByDepartmentID(string did)
        {
            PositionBll bll = new PositionBll();
            return bll.GetPositionsByDepartmentID(did);

        }

        [WebMethod]
        public DataTable GetPositionByID(string id)
        {
            PositionBll bll = new PositionBll();
            return bll.GetPositionByID(id);
        }

        [WebMethod]
        public bool AddPosition(string departmentid, string positionname)
        {
            PositionBll bll = new PositionBll();
            return bll.AddPosition(departmentid, positionname);
        }

        [WebMethod]
        public bool UpdateDepartment(string departmentid, string positionname, string id)
        {
            PositionBll bll = new PositionBll();
            return bll.UpdateDepartment(departmentid, positionname, id);
        }

        [WebMethod]
        public bool ExistsId(string positionname)
        {
            PositionBll bll = new PositionBll();
            return bll.ExistsId(positionname);
        }

        [WebMethod]
        public bool DelDepartmentByID(string id)
        {
            PositionBll bll = new PositionBll();
            return bll.DelDepartmentByID(id);
        }

        [WebMethod]
         public string GetPositionidByName(string name)
        {
            PositionBll bll = new PositionBll();
            return bll.GetPositionidByName(name);
        }
    }
}
