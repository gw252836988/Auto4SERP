using System;
using Model;
using System.Collections.Generic;
namespace Bll.Personnel
{
   public interface IOperateMan
    {
        bool AddOperateMan(string staffid);
        System.Data.DataTable GetOperateMans(System.Collections.Generic.List<Model.SqlElement> lst);
        bool ValidateLogin(string staffid, string pwd);
        Staff GetOperateMan(string staffid);
        void EnableFunction(string staffid, string nodeId);
        void CancelFunction(string staffid, string nodeId);
        List<string> GetFunctionsOfStaff(string staffid);
        void DeleteFunctionsOfStaff(string staffid);
        SystemInfo GetSystemInfo();
        void DelOperateMan(string staffid);
        bool AddOpreateManByCustom(Staff obj);
        void UpdateOperatePwd(string staffid, string pwd);
        bool ValidateStaffID(string staffid);
    }
}
