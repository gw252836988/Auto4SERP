using System;
namespace Bll.Repair
{
    public interface IAccessoryMatchBll
    {
        System.Data.DataTable GetAccsByList(System.Collections.Generic.List<string> lst,int days);
        void SetDBByOrgan(string organid);

    }
}
