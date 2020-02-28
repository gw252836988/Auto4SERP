using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Bll
{
   public interface IExtend
    {
       bool AddExtendtype(string extendname);
       bool UpdateExtendtype(string extendname, int id);
        bool DelExtendtype(int id);
        DataTable GetExtendtypes();
        DataTable GetExtendtype(int id);

        bool AddExtendcontent(string content,int extendtype_id);
        bool UpdateExtendcontent(string content, int extendtype_id, int id);
        bool DelExtendcontent(int id);
        DataTable GetExtendcontents();
        DataTable GetExtendcontent(int id);
        DataTable GetExtendcontentByExtendtypeName(string  extendtype_name);

        DataTable GetSupplyUnits(string unittype);
        DataTable GetSupplyUnitsByQuery(List<SqlElement> list);

        void AddSupplyUnit(SupplyUnit obj);
        void UpdateSuppyUnit(SupplyUnit obj);
        SupplyUnit GetSuppyUnitByID(int id);

        void DelSupplyUnit(int id);
        string ExecuteSql(string sql);
        void AddKeyLog(string op, string context);
    }
}
