using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using Excel;
using Model;
namespace Comm
{
    public class ExcelInAndOut
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


        public void DTOutTo(System.Data.DataTable dt, System.Windows.Forms.DataGridView drv)
        {
          //  StringBuilder str = new StringBuilder();
           // SaveFileDialog dialog = new SaveFileDialog();

            //dialog.Filter = "Excel 文件(*.xls)|*.xls|Excel 文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            ////以文件“*.xls”导出
            //if (dialog.ShowDialog() != DialogResult.OK)
            //{
            //    return;
            //}
            if (drv != null)
            {
                for (int k = 0; k < drv.Columns.Count; k++)
                {
                    //if (drv.Visible)
                    //    str.Append(drv.Columns[k].HeaderText.ToString() + "\t");
                    if (drv.Visible)
                        dt.Columns[k].ColumnName = drv.Columns[k].HeaderText.ToString();
                }
            }

            GridToExcelByNPOI(dt,"结果");
            //str.Append(Environment.NewLine);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        if (j == 0)
            //            str.Append("'");
            //        str.Append(dt.Rows[i][j].ToString() + "\t");
            //    }
            //    str.Append(Environment.NewLine);
            //}
            //StreamWriter sw = new StreamWriter(dialog.FileName, false, Encoding.GetEncoding("gb2312"));
            //sw.Write(str.ToString());
            //sw.Flush();
            //sw.Close();







        }


        public void DTOutTo(System.Data.DataTable dt)
        {
            StringBuilder str = new StringBuilder();
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Excel 文件(*.xls)|*.xls|Excel 文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            //以文件“*.xls”导出
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

          
            str.Append(Environment.NewLine);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    str.Append(dt.Rows[i][j].ToString() + "\t");
                }
                str.Append(Environment.NewLine);
            }
            StreamWriter sw = new StreamWriter(dialog.FileName, false, Encoding.GetEncoding("gb2312"));
            sw.Write(str.ToString());
            sw.Flush();
            sw.Close();
        }


        public void NewDTOutTo(System.Windows.Forms.DataGridView drv)
        {
            ExportToExcel(drv, "结果");



        }
        public void DTOutTo(System.Windows.Forms.DataGridView drv)
        {
          //  ExportToExcel(drv,"结果");
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
                if (drv.Visible)
                    str.Append(drv.Columns[k].HeaderText.ToString() + "\t");

            }
            str.Append(Environment.NewLine);
            string cellvalue;
            for (int i = 0; i < drv.Rows.Count; i++)
            {
                for (int j = 0; j < drv.Columns.Count; j++)
                {
                    if (drv.Rows[i].Cells[j].Value != null)
                        cellvalue = drv.Rows[i].Cells[j].Value.ToString().Trim();
                    else
                        cellvalue = " ";
                    str.Append(cellvalue + "\t");

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
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'";

            DataSet ds = new DataSet();
            using (OleDbConnection OleConn = new OleDbConnection(strConn))
            {
                String sql = "SELECT * FROM [Sheet1$]"; 
                OleConn.Open(); 
            
                OleDbDataAdapter OleDaExcel = new OleDbDataAdapter(sql, OleConn);
                OleDaExcel.Fill(ds);
                OleConn.Close();

            }
            return ds.Tables[0];
        }


        //private void CheckHeader()
        //{
        //    switch (dtSource.Columns[oldColumnNames[i]].DataType.ToString())
        //    {
        //        case "System.String"://字符串类型   
        //            newCell.SetCellValue(drValue);
        //            break;
        //        case "System.DateTime"://日期类型   
        //            DateTime dateV;
        //            DateTime.TryParse(drValue, out dateV);
        //            newCell.SetCellValue(dateV);

        //            newCell.CellStyle = dateStyle;//格式化显示   
        //            break;
        //        case "System.Boolean"://布尔型   
        //            bool boolV = false;
        //            bool.TryParse(drValue, out boolV);
        //            newCell.SetCellValue(boolV);
        //            break;
        //        case "System.Int16"://整型   
        //        case "System.Int32":
        //        case "System.Int64":
        //        case "System.Byte":
        //            int intV = 0;
        //            int.TryParse(drValue, out intV);
        //            newCell.SetCellValue(intV);
        //            break;
        //        case "System.Decimal"://浮点型   
        //        case "System.Double":
        //            double doubV = 0;
        //            double.TryParse(drValue, out doubV);
        //            newCell.SetCellValue(doubV);
        //            break;
        //        case "System.DBNull"://空值处理   
        //            newCell.SetCellValue("");
        //            break;
        //        default:
        //            newCell.SetCellValue("");
        //            break;
        //    }
        //}

        private void GridToExcelByNPOI(System.Data.DataTable dt, string strExcelFileName)
        {


            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Excel|*.xls";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }


        //    FileStream fs = new FileStream(strExcelFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
          
                HSSFWorkbook workbook = new HSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Sheet1");

                ICellStyle HeadercellStyle = workbook.CreateCellStyle();
                HeadercellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                //字体
                NPOI.SS.UserModel.IFont headerfont = workbook.CreateFont();
                headerfont.Boldweight = (short)FontBoldWeight.Bold;
                HeadercellStyle.SetFont(headerfont);


                //用column name 作为列名
                int icolIndex = 0;
                IRow headerRow = sheet.CreateRow(0);
                foreach (DataColumn item in dt.Columns)
                {
                    ICell cell = headerRow.CreateCell(icolIndex);
                    cell.SetCellValue(item.ColumnName);
                    cell.CellStyle = HeadercellStyle;
                    icolIndex++;
                }

                ICellStyle cellStyle = workbook.CreateCellStyle();

                //为避免日期格式被Excel自动替换，所以设定 format 为 『@』 表示一率当成text來看
                cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("@");
                cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;


                NPOI.SS.UserModel.IFont cellfont = workbook.CreateFont();
                cellfont.Boldweight = (short)FontBoldWeight.Normal;
                cellStyle.SetFont(cellfont);

                //建立内容行
                int iRowIndex = 1;
                int iCellIndex = 0;
                foreach (DataRow Rowitem in dt.Rows)
                {
                    IRow DataRow = sheet.CreateRow(iRowIndex);
                    foreach (DataColumn Colitem in dt.Columns)
                    {

                        ICell newCell = DataRow.CreateCell(iCellIndex);
                      //  cell.SetCellValue(Rowitem[Colitem].ToString());
                        newCell.CellStyle = cellStyle;
                        string drValue = Rowitem[Colitem].ToString();
                        switch (Colitem.DataType.ToString())
                        {
                            case "System.String"://字符串类型   
                                newCell.SetCellValue(drValue);
                                break;
                            case "System.DateTime"://日期类型   
                                //DateTime dateV;
                                //DateTime.TryParse(drValue, out dateV);
                                newCell.SetCellValue(drValue);

                               // newCell.CellStyle = dateStyle;//格式化显示   
                                break;
                            case "System.Boolean"://布尔型   
                                bool boolV = false;
                                bool.TryParse(drValue, out boolV);
                                newCell.SetCellValue(boolV);
                                break;
                            case "System.Int16"://整型   
                            case "System.Int32":
                            case "System.Int64":
                            case "System.Byte":
                                int intV = 0;
                                int.TryParse(drValue, out intV);
                                newCell.SetCellValue(intV);
                                break;
                            case "System.Decimal"://浮点型   
                            case "System.Double":
                                double doubV = 0;
                                double.TryParse(drValue, out doubV);
                                newCell.SetCellValue(doubV);
                                break;
                            case "System.DBNull"://空值处理   
                                newCell.SetCellValue("");
                                break;
                            default:
                                newCell.SetCellValue("");
                                break;
                        }


                     
                        iCellIndex++;
                    }
                    iCellIndex = 0;
                    iRowIndex++;
                }

                //自适应列宽度
                for (int i = 0; i < icolIndex; i++)
                {
                    sheet.AutoSizeColumn(i);
                }

                //SaveFileDialog saveDialog = new SaveFileDialog();
                //saveDialog.DefaultExt = "xls";
                //saveDialog.Filter = "Excel文件|*.xls";
                //saveDialog.FileName = strExcelFileName;
                //saveDialog.ShowDialog();
                //strExcelFileName = saveDialog.FileName;
                //if (strExcelFileName.IndexOf(":") < 0) return; //被点了取消 


                if (strExcelFileName != "")
                {
                    using (FileStream stream = File.OpenWrite(fileDialog.FileName))
                    {
                        workbook.Write(stream);
                        stream.Close();
                    }
                    MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GC.Collect();
                    //try
                    //{
                    //    fs = File.OpenWrite(saveDialog.FileName);
                    //    workbook.Write(fs);
                    //    fs.Flush();
                    //    fs.Close();
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                    //}


                }

                //写Excel
                //FileStream file = new FileStream(strExcelFileName, FileMode.OpenOrCreate);
                //workbook.Write(file);
                //file.Flush();
                //file.Close();

              //  MessageBox.Show("Export_to_excel_successfully");
            //}
            //catch (Exception ex)
            //{


            //    MessageBox.Show("导出失败");
            //}
            //finally
            //{
            //    if (fs != null)
            //        fs.Close();
            //    //GC.SuppressFinalize(this);
            //}

        }


        public  void ExportToExcel(DataGridView dataGridView1, string sheetName)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Excel|*.xls";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            //不允许dataGridView显示添加行，负责导出时会报最后一行未实例化错误
            dataGridView1.AllowUserToAddRows = false;
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet(sheetName);
            IRow rowHead = sheet.CreateRow(0);

            //填写表头
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                rowHead.CreateCell(i, CellType.String).SetCellValue(dataGridView1.Columns[i].HeaderText.ToString());
            }
            //填写内容
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    //if (IsNum(dataGridView1.datasColumns[j].HeaderText))
                    //{
                     
                    //    row.CreateCell(j, CellType.Numeric).SetCellValue(double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString()));

                    //}
                    //else
                    //    row.CreateCell(j, CellType.String).SetCellValue(dataGridView1.Rows[i].Cells[j].Value.ToString());

                    ICell newCell = row.CreateCell(j);
                    //  cell.SetCellValue(Rowitem[Colitem].ToString());
                  //  newCell.CellStyle = cellStyle;
                    string drValue = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    switch (dataGridView1.Columns[j].ValueType.ToString())
                    {
                        case "System.String"://字符串类型   
                            newCell.SetCellValue(drValue);
                            break;
                        case "System.DateTime"://日期类型   
                            //DateTime dateV;
                            //DateTime.TryParse(drValue, out dateV);
                            newCell.SetCellValue(drValue);

                          //  newCell.CellStyle = dateStyle;//格式化显示   
                            break;
                        case "System.Boolean"://布尔型   
                            bool boolV = false;
                            bool.TryParse(drValue, out boolV);
                            newCell.SetCellValue(boolV);
                            break;
                        case "System.Int16"://整型   
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":
                            int intV = 0;
                            int.TryParse(drValue, out intV);
                            newCell.SetCellValue(intV);
                            break;
                        case "System.Decimal"://浮点型   
                        case "System.Double":
                            double doubV = 0;
                            double.TryParse(drValue, out doubV);
                            newCell.SetCellValue(doubV);
                            break;
                        case "System.DBNull"://空值处理   
                            newCell.SetCellValue("");
                            break;
                        default:
                            newCell.SetCellValue("");
                            break;
                    }
                
                }
            }

            using (FileStream stream = File.OpenWrite(fileDialog.FileName))
            {
                workbook.Write(stream);
                stream.Close();
            }
            MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GC.Collect();
        }


        private bool IsNum(string colname)
        {
            //bool result=false ;
            string[] strlst ={"价","金额","数量"};
            foreach (string str in strlst)
            {
                if (colname.Contains(str))
                {
                    return true;

                }

            }
            return false ;

        }

        

       
    }
}
