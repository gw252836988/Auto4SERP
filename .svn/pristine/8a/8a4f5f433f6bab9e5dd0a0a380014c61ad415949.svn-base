using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
namespace Comm
{
    public class ExcelInAndOut:IInAndOut
    {
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private int iIndex=0;

        public int IIndex
        {
            get { return iIndex; }
            set { iIndex = value; }
        }


        public ExcelInAndOut(string path)
        {
            filePath = path;

        }
        public void DTOutTo(System.Data.DataTable  drv)
        {


        }

        public void DTOutTo(System.Windows.Forms.DataGridView drv)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Excel 文件(*.xls)|*.xls|Excel 文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            //以文件“*.xls”导出
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }


            StringBuilder str = new StringBuilder();

            for (int k = 0; k < drv.Columns.Count; k++)
            {
                str.Append(drv.Columns[k].HeaderText.ToString() + "\t");

            }
            str.Append(Environment.NewLine);
            for (int i = 0; i < drv.Rows.Count; i++)
            {
                for (int j = 0; j < drv.Columns.Count; j++)
                {
                    str.Append(drv.Rows[i].Cells[j].Value.ToString() + "\t");
                }
                str.Append(Environment.NewLine);
            }
            StreamWriter sw = new StreamWriter(dialog.FileName, false, Encoding.GetEncoding("gb2312"));
            sw.Write(str.ToString());
            sw.Flush();
            sw.Close();
 
        }


        public System.Data.DataTable InDataToDT()
        {
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=False;IMEX=1'";

            DataSet ds = new DataSet();
            using (OleDbConnection OleConn = new OleDbConnection(strConn))
            {
                OleConn.Open(); String sql = "SELECT * FROM [Sheet1$]"; 
                OleDbDataAdapter OleDaExcel = new OleDbDataAdapter(sql, OleConn);
                OleDaExcel.Fill(ds);
                OleConn.Close();

            }
            return ds.Tables[0];
        }

    }
}
