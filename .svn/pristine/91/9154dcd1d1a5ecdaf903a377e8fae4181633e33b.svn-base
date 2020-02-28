using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;

namespace Bll.Task
{
    public class GVisitYearTask : DataTask
    {
       public GVisitYearTask()
       {
           m_handler = "VSYear.ashx";
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

       protected override object CreateDataObjects(string strval)
       {
           List<SLSumInfo> lst = SLSumInfo.CreateObjects(strval);
           m_Columns = lst.Count;
           return lst;

       }

       protected override void CreateTableItem(object o, string organame)
       {
           List<SLSumInfo> lst = (List<SLSumInfo>)o;
           DataRow dr1 = dtCreate.NewRow();


           dr1[0] = organame;

           dr1[1] = "来访数";


           int i = 0;
           int gJsNum = 0;

           foreach (SLSumInfo info in lst)
           {
               dr1[i + 3] = info.Num.ToString();
               gJsNum += info.Num;

               i++;

           }
           dr1[2] = Convert.ToString(gJsNum);

           dtCreate.Rows.Add(dr1);

       }

       protected override void CaculateAmount()
       {
           DataRow dr1 = dtCreate.NewRow();


           dr1[0] = "合计";


           dr1[1] = "来访数";

           int gJsNum = 0;

           for (int i = 0; i < (m_Columns + 1); i++)
           {
               for (int j = 0; j < dtCreate.Rows.Count; j++)
               {

                   gJsNum += Convert.ToInt16(dtCreate.Rows[j][i + 2].ToString());


               }
               dr1[i + 2] = gJsNum;

               gJsNum = 0;

           }

           dtCreate.Rows.Add(dr1);

       }

    }
}
