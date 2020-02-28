using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;

namespace Comm
{
    public class JsonUtil
    {
        public static string Data2Json(DataTable dt)
        {
            StringBuilder sbjson = new StringBuilder();
            sbjson.Append("[");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i > 0)
                    {
                        sbjson.Append(",");
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                    else
                    {
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                }
            }
            sbjson.Append("]");
            return sbjson.ToString();
        }


        ///<summary>
        /// 返回easyui/extjs中datagrid使用的json格式
        ///</summary>
        ///<param name="dt">datatable数据</param>
        ///<param name="count">总的条数</param>
        ///<returns></returns>
        public static string DataToJson(DataTable dt, int count)
        {
            StringBuilder sbjson = new StringBuilder();
            sbjson.Append("{");
            sbjson.Append("\"total\":" + count + ",\"rows\":[");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i > 0)
                    {
                        sbjson.Append(",");
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                    else
                    {
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                }
            }
            sbjson.Append("]}");
            return sbjson.ToString();
        }



        ///<summary>
        /// 返回接口使用的json格式
        ///</summary>
        ///<param name="dt">datatable数据</param>
        ///<param name="status">状态0 正常 ,1失败</param>
        ///<param name="msg">提示错误信息</param>
        ///<param name="data">返回数据</param>
        ///<returns></returns>
        public static string DataToJson_create(DataTable dt, int status, string msg)
        {
            StringBuilder sbjson = new StringBuilder();
            sbjson.Append("{");
            sbjson.Append("\"status\":\"" + status + "\",\"msg\":\"" + msg + "\",\"data\":");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i > 0)
                    {
                        sbjson.Append(",");
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                    else
                    {
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                }
            }
            else
            {
                sbjson.Append("{");
                sbjson.Append("}");
            }
            sbjson.Append("}");
            return sbjson.ToString();
        }
        ///<summary>
        /// 返回接口使用的json格式
        ///</summary>
        ///<param name="dt">datatable数据</param>
        ///<param name="status">状态0 正常 ,1失败</param>
        ///<param name="msg">提示错误信息</param>
        /// <param name="totalnum">所有数据的总条数</param>
        /// <param name="totalpage">所有数据的总页数</param>
        /// <param name="currentpage">当前处在的页数索引</param>
        /// <param name="info">当前页的数据</param>
        ///<param name="data">返回数据</param>
        ///<returns></returns>
        public static string DataToJson_retrieve(DataTable dt, int status, string msg, int totalnum, int totalpage, int currentpage)
        {
            StringBuilder sbjson = new StringBuilder();
            sbjson.Append("{");
            sbjson.Append("\"status\":\"" + status + "\",\"msg\":\"" + msg + "\",\"data\":{");

            sbjson.Append("\"totalnum\":\"" + totalnum + "\",\"totalpage\":\"" + totalpage + "\",\"currentpage\":\"" + currentpage + "\",\"info\":[");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i > 0)
                    {
                        sbjson.Append(",");
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                    else
                    {
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                }
            }
            sbjson.Append("]");
            sbjson.Append("}}");
            return sbjson.ToString();
        }


        public static string DataToJson_NoPage(DataTable dt, int status, string msg)
        {
            StringBuilder sbjson = new StringBuilder();
            sbjson.Append("{");
            sbjson.Append("\"status\":\"" + status + "\",\"msg\":\"" + msg + "\",\"data\":{");

            sbjson.Append("\"totalnum\":\"" + 0 + "\",\"totalpage\":\"" + 0 + "\",\"currentpage\":\"" + 0 + "\",\"info\":[");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i > 0)
                    {
                        sbjson.Append(",");
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                    else
                    {
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");
                            }
                        }
                        sbjson.Append("}");
                    }
                }
            }
            sbjson.Append("]");
            sbjson.Append("}}");
            return sbjson.ToString();
        }

        public static DataTable JsonToDataTable(string strJson)
        {
            //转换json格式
            strJson = strJson.Replace(",\"", "*\"").Replace("\":", "\"#").ToString();
            //取出表名   
            var rg = new Regex(@"(?<={)[^:]+(?=:\[)", RegexOptions.IgnoreCase);
            string strName = rg.Match(strJson).Value;
            DataTable tb = null;
            //去除表名   
            strJson = strJson.Substring(strJson.IndexOf("[") + 1);
            strJson = strJson.Substring(0, strJson.IndexOf("]"));

            //获取数据   
            rg = new Regex(@"(?<={)[^}]+(?=})");
            MatchCollection mc = rg.Matches(strJson);
            for (int i = 0; i < mc.Count; i++)
            {
                string strRow = mc[i].Value;
                string[] strRows = strRow.Split('*');

                //创建表   
                if (tb == null)
                {
                    tb = new DataTable();
                    tb.TableName = strName;
                    foreach (string str in strRows)
                    {
                        var dc = new DataColumn();
                        string[] strCell = str.Split('#');

                        if (strCell[0].Substring(0, 1) == "\"")
                        {
                            int a = strCell[0].Length;
                            dc.ColumnName = strCell[0].Substring(1, a - 2);
                        }
                        else
                        {
                            dc.ColumnName = strCell[0];
                        }
                        tb.Columns.Add(dc);
                    }
                    tb.AcceptChanges();
                }

                //增加内容   
                DataRow dr = tb.NewRow();
                for (int r = 0; r < strRows.Length; r++)
                {
                    dr[r] = strRows[r].Split('#')[1].Trim().Replace("，", ",").Replace("：", ":").Replace("\"", "");
                }
                tb.Rows.Add(dr);
                tb.AcceptChanges();
            }

            return tb;
        }

    }
}
