using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Bll.P2P
{
    public interface IP2P
    {
        DataTable GetQuansOfCustomer(string mobile);
        string GetIDOfQuan(string type, double money, string mobile);
        string ConductQuan(List<string> lst);
    }
}
