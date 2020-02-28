using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;
using Bll.Personnel;
namespace Auto4SErpWeb
{
    /// <summary>
    /// OrganOfService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class OrganOfService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable GetRegions()
        {
            OrganBll bll = new OrganBll();
            return bll.GetRegions();
        }

        [WebMethod]
        public DataTable GetOrgans()
        {
            OrganBll bll = new OrganBll();
            return bll.GetOrgans();
        }

   
    }
}
