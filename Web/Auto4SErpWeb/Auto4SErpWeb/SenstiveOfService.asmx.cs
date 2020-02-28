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
    /// SenstiveOfService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class SenstiveOfService : System.Web.Services.WebService
    {

        [WebMethod]
        public string[] GetPowerList(string formname)
        {

            SenstiveBll bll = new SenstiveBll();
            return bll.GetPowerList(formname);

        }

        [WebMethod]
        public DataTable GetPowerTexts()
        {
            SenstiveBll bll = new SenstiveBll();
            return bll.GetPowerTexts();
        }
    }
}
