using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
namespace Bll.Personnel
{
    public interface IStaff
    {

        bool AddStaff(Model.Staff obj);
        DataTable GetStaffsByQuery(List<Model.SqlElement> lst, string organid, int PageIndex, int PageSize, out int RecordCount, out int PageCount);
        Model.Staff GetStaff(string staffid);
        bool ValidateLogin(string staffid, string pwd);
        bool UpdateStaff(Staff obj);
        void DeleteStaff(string staffid);
        DataTable GetStaffNameOfOrgan(string organid);
        void UpdateStaffPwd(string staffid,string pwd);
        void AddInfo(string txt);
        DataTable GetLatestInfos();
        DataTable GetSalersOfOrgan(string organid);
    }
}
