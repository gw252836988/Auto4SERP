using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Data;
namespace Comm
{
    public class JsonSerialize
    {


        public string  serializeDataTable(DataTable dt)
        {

            DataTable dtclone = dt.Copy();
            string tablestr = JsonConvert.SerializeObject(dtclone);
            return tablestr;
        }


        public DataTable  deserializeDataTable(string tablestr)
        {
            DataTable dt = (DataTable)JsonConvert.DeserializeObject<DataTable>(tablestr);
            return dt;
        }


        public string serializeList(IEnumerable<string> list)
        {


            string strlist = JsonConvert.SerializeObject(list);
            return strlist;
        }
          
        public IEnumerable<string> deserializeList(string str)
        {
            IEnumerable<string> list = (IEnumerable<string>)JsonConvert.DeserializeObject<IEnumerable<string>>(str);
            return list;
        }
    }
}
