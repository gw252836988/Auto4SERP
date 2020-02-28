using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
namespace Bll.Repair
{
    public interface IRepItemPrice
    {

        DataTable GerRepPriceByItemCode(string itemcode);
        DataTable GetRepPriceByID(string id);
        void AddRepPrice(List<SqlElement> lst);
        void UpdateRepPrice(List<SqlElement> lst, string id);
        void DelRepPrice(string id);
       
    }
}
