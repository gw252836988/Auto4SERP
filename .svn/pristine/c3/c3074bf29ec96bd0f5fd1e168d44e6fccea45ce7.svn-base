using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtil;
using Comm;
using System.Data;
namespace Bll
{
    public class FunctionBll:IFucntion
    {
        private DBHelper mDB;
        public FunctionBll()
        {
            mDB = DBHelperShare.getPInstance();
        }


        public DataTable GetMenus()
        {
            string sql = "select * from menufunction";
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }


        public void EnableFunction(int positionId,string nodeId)
        {
            string sql = string.Format("delete from positionfunction where positionid={0} and nodeid='{1}';  insert positionfunction(positionid,nodeid) values({0},'{1}')", positionId, nodeId);
            mDB.ExecuteNonQuery(sql);


        }

        public void EnableFunctions(int positionId, string nodePrex)
        {
            string sql = string.Format("delete from positionfunction where positionid={0} and nodeid like '{1}%';  insert positionfunction(positionid,nodeid) select {0},nodeId from menufunction where nodeid like '{1}%'", positionId, nodePrex);
            mDB.ExecuteNonQuery(sql);


        }


        public void CancelFunction(int positionId, string nodeId)
        {
            string sql = string.Format("delete from positionfunction where positionid={0} and nodeid='{1}' ", positionId, nodeId);
            mDB.ExecuteNonQuery(sql);


        }

        public void CancelFunctions(int positionId, string nodePrex)
        {
            string sql = string.Format("delete from positionfunction where positionid={0} and nodeid like '{1}%'", positionId, nodePrex);
            mDB.ExecuteNonQuery(sql);


        }


        public List<string> GetFunctionsOfPosition(int positionId)
        {
            string sql =string.Format( "select nodeid from positionfunction where positionid={0}",positionId);
            DataTable dt = mDB.ExecuteDataTable(sql);
            List<string> lst = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Add(dt.Rows[i][0].ToString().Trim());

            }
            return lst;
        }
        
    }
}
