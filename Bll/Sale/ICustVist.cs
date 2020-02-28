using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
namespace Bll.Sale
{
    public interface ICustVist
    {

       void  AddCustVist(CustVist obj);
       DataTable GetCustIns(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount);
       CustVist GetCustIn(int id);
       void UpdateCustVist(CustVist obj);
    }
}
