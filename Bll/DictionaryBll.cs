using Comm;
using DBUtil;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public class DictionaryBll:IDiction
    {
         private DBHelper mDB;
         public DictionaryBll()
        {
            mDB = DBHelperShare.getInstance();
        }
       public DataTable GetDictionaryByTypeId(int typeid)
       {
           string sql =string.Format( "select id,typeid,fieldname,fieldtext from dictionary where typeid={0} order by id asc",typeid);
           DataTable dt = mDB.ExecuteDataTable(sql);
           return dt;
       }
    }
}
