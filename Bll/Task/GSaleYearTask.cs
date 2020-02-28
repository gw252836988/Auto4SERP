using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
namespace Bll.Task
{
    public class GSaleYearTask : DataTask 
    {


        public GSaleYearTask()
       {
           m_handler = "SLYear.ashx";
       }

       protected override void CreateTableHead()
       {
           string year = htPara["year"].ToString();
           dtCreate.Columns.Add("机构");
           dtCreate.Columns.Add(year + "年");
           dtCreate.Columns.Add("合计");

           for (int i = 0; i < m_Columns; i++)
           {
               dtCreate.Columns.Add((i + 1) + "月");

           }

       }

       protected override void CreateTableItem(object o, string organame)
       {
           List<SLSumInfo> lst = (List<SLSumInfo>)o;
           DataRow dr1 = dtCreate.NewRow();
           DataRow dr2 = dtCreate.NewRow();

           dr1[0] = organame;
           dr2[0] = organame;

           dr1[1] = "销售台次";
           dr2[1] = "销售金额";

           int i = 0;
           int gJsNum = 0;
           double gHjje = 0;
           foreach (SLSumInfo info in lst)
           {

               dr1[i + 3] = ZeroToNull(info.Num.ToString());

               gJsNum += info.Num;
               dr2[i + 3] = ZeroToNull(info.Je);
               gHjje += info.Je;
               i++;

           }
           dr1[2] = ZeroToNull(gJsNum);
           dr2[2] = ZeroToNull(gHjje);
           dtCreate.Rows.Add(dr1);
           dtCreate.Rows.Add(dr2);
       }


       protected override void CaculateAmount()
       {
           DataRow dr1 = dtCreate.NewRow();
           DataRow dr2 = dtCreate.NewRow();

           dr1[0] = "合计";
           dr2[0] = "合计";

           dr1[1] = "销售台次";
           dr2[1] = "销售金额";
           int gJsNum = 0;
           double gHjje = 0;
           string tmp = "";
           for (int i = 0; i < (m_Columns + 1); i++)
           {
               for (int j = 0; j < dtCreate.Rows.Count; j++)
               {
                   tmp = dtCreate.Rows[j][i + 2].ToString();
                   if (string.IsNullOrEmpty(tmp)) tmp = "0";
                   if (j % 2 == 0)
                       gJsNum += Convert.ToInt16(tmp);
                   else
                       gHjje += Convert.ToDouble(tmp);

               }
               dr1[i + 2] = ZeroToNull(gJsNum);
               dr2[i + 2] = ZeroToNull(gHjje);
               gJsNum = 0;
               gHjje = 0;
           }

           dtCreate.Rows.Add(dr1);
           dtCreate.Rows.Add(dr2);
       }


       protected override object CreateDataObjects(string strval)
       {
           List<SLSumInfo> lst = SLSumInfo.CreateObjects(strval);
           m_Columns = lst.Count;
           return lst;

       }

    }
}
