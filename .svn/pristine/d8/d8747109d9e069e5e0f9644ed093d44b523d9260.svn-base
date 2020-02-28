using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace Comm
{
    public class CreateSqlUtil
    {
        public static string CreateInsertSql(List<SqlElement> lst,string tableName)
        {

            StringBuilder strHead = new StringBuilder();
            StringBuilder strEnd = new StringBuilder();

            strHead.Append("insert into " +tableName + "(");
            strEnd.Append(" values(");
            foreach(SqlElement e in lst)
            {
                strHead.Append(e.Name + ",");
                if (e.IsStr == true)
                    strEnd.Append("'" + e.Value + "',");
                else
                    strEnd.Append(e.Value + ",");

            }
            strHead.Remove(strHead.Length-1,1);
            strEnd.Remove(strEnd.Length - 1, 1);

            strHead.Append(")");
            strEnd.Append(")");
           
            return strHead.ToString() + strEnd.ToString();

        }


        public static string CreateUpdateSql(List<SqlElement> lst, string tableName)
        {
            StringBuilder strCom = new StringBuilder();
            strCom.Append("update " + tableName + " set ");

            foreach (SqlElement e in lst)
            {
                strCom.Append(e.Name + "=");
                if (e.IsStr == true)
                    strCom.Append("'" + e.Value + "'");
                else
                    strCom.Append(e.Value);
                strCom.Append(",");

            }
            strCom.Remove(strCom.Length-1,1);
            return strCom.ToString();
        }

        public static string CreateIsExistInsertStringSql(string columnName, string tableName,string insertString)
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("select count({0}) from {1} where {0}='{2}'", columnName, tableName, insertString);
            return str.ToString();
        }

        public static string CreateDelSql(string columnName, string tableName,int  id)
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("delete  from {1} where {0}={2}", columnName, tableName, id);
            return str.ToString();
        }

        public static string CreateQuerySqlOfCondition(List<SqlElement> lst,bool isAnd)
        {
            StringBuilder strCom = new StringBuilder();
            foreach (SqlElement e in lst)
            {
                strCom.Append( "" + e.Name);
                if (e.IsFuzzy == true)
                {
                    strCom.Append(" like '%" + e.Value + "%'");
                }
                else
                {
                    if(e.IsStr)
                        strCom.Append(" = '" + e.Value + "'");
                    else
                        strCom.Append(" = " + e.Value);
                }
                if (isAnd)
                {
                    strCom.Append(" and ");
                }
                else
                    strCom.Append(" or ");
                

            }
            strCom.Remove(strCom.Length - 4, 4);
            return strCom.ToString();

        }

    }
}
