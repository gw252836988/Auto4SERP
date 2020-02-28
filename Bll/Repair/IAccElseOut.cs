using System;
using System.Data;
using Model;
using System.Collections.Generic;
namespace Bll.Repair
{
    public interface IAccElseOut
    {
        string GetDHOfAddAccElseOut(System.Collections.Generic.List<Model.SqlElement> lst);

        void SetCompleteOfStatus(string dh);

        DataTable GetElseOutBills(string strBegin, string strEnd, List<SqlElement> list, int PageIndex, int PageSize, out int RecordCount, out int PageCount);

        DataTable GetElseOutBill(string dh);

        bool DelElseOutBill(string dh);
        void SetOperateOfStatus(string dh);

        void UpdateAccElseOut(List<SqlElement> lst, string dh);
    }
}
