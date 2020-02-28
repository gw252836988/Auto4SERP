using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace Bll.Task
{
   public  class GFinanceTask :DataTask
   {

        public GFinanceTask()
       {
           m_handler = "FIIntegrate.ashx";
       }
    
        protected override void CreateTableHead()
        {

            dtCreate.Columns.Add("机构");
            dtCreate.Columns.Add("销售订金");
            dtCreate.Columns.Add("销售收款");
            dtCreate.Columns.Add("销售装潢");
            dtCreate.Columns.Add("售后");



        }

        protected override void CaculateAmount()
        {



        }

        protected override void CreateTableItem(object o, string organame)
        {
            DataTable dtValue = (DataTable)o;
            DataRow dr1 = dtCreate.NewRow();
            dr1[0] = organame;

            dr1[1] = dtValue.Rows[0][0];
            dr1[2] = dtValue.Rows[0][1];
            dr1[3] = dtValue.Rows[0][2];
            dr1[4] = dtValue.Rows[0][3];

            dtCreate.Rows.Add(dr1);

        }

        protected override object CreateDataObjects(string strval)
        {
            DataTable dt = CreateFIDataTable(strval);

            return dt;

        }
        private  DataTable CreateFIDataTable(string strval)
        {
            JArray ja = (JArray)JsonConvert.DeserializeObject(strval);
            DataTable dt = new DataTable();
            dt.Columns.Add("order");
            dt.Columns.Add("sale");
            dt.Columns.Add("decorate");
            dt.Columns.Add("repair");

            DataRow dr;
            dr = dt.NewRow();
            for (int i = 0; i < ja.Count; i++)
            {
                string flag = ja[i]["flag"].ToString();
                int iflag = Convert.ToInt16(flag);
                dr[iflag] = ja[i]["hjje"].ToString();

            }
            dt.Rows.Add(dr);
            return dt;
        }


    }
}
