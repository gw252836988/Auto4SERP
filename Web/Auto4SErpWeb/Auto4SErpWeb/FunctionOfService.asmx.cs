﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using Bll.Personnel;
using Model;
using System.Data;
namespace Auto4SErpWeb
{
    /// <summary>
    /// FunctionOfService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class FunctionOfService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable GetMenus()
        {

            FunctionBll bll = new FunctionBll();
            return bll.GetMenus();

        }


        [WebMethod]
        public void EnableFunction(int positionId, string nodeId)
        {
            FunctionBll bll = new FunctionBll();
            bll.EnableFunction(positionId, nodeId);

        }
        [WebMethod]
        public void EnableFunctions(int positionId, string nodePrex)
        {
            FunctionBll bll = new FunctionBll();
            bll.EnableFunctions(positionId, nodePrex);

        }

        [WebMethod]
        public void CancelFunction(int positionId, string nodeId)
        {
            FunctionBll bll = new FunctionBll();
            bll.CancelFunction(positionId, nodeId);

        }
        [WebMethod]
        public void CancelFunctions(int positionId, string nodePrex)
        {
            FunctionBll bll = new FunctionBll();
            bll.CancelFunctions(positionId, nodePrex);

        }

        [WebMethod]
        public List<string> GetFunctionsOfPosition(int positionId)
        {

            FunctionBll bll = new FunctionBll();
            return bll.GetFunctionsOfPosition(positionId); 
        }

        [WebMethod]
        public DataTable GetAwards()
        {

            FunctionBll bll = new FunctionBll();
            return bll.GetAwards(); 

        }
    }
}
