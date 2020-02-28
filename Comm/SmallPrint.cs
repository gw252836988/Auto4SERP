using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace Comm
{
    public class SmallPrint
    {

        public string PrintContent
        {
            get;
            set;

        }

        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)//设置打印机开始打印的事件处理函数  
        {
            System.Drawing.Font printFont = new System.Drawing.Font
            ("宋体", 9, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(PrintContent, printFont, System.Drawing.Brushes.Black, e.MarginBounds.X, e.MarginBounds.Y);
        }


        public void Print()
        {
            PrintDocument pd = new PrintDocument();

            pd.PrinterSettings.Copies = 1;

            Margins margin = new Margins(5, 5, 5, 5);
            pd.DefaultPageSettings.Margins = margin;

            ////纸张设置默认
            PaperSize pageSize = new PaperSize("First custom size", getYc(25), 1000);
            pd.DefaultPageSettings.PaperSize = pageSize;

            //打印事件设置      

            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);



            PrintDialog dialog = new PrintDialog();
            dialog.Document = pd;
           //dialog.PrinterSettings.PrinterName = printname;


            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                  pd.Print();
                 
               // PrintPreview(pd);
            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pd.PrintController.OnEndPrint(pd, new PrintEventArgs());
                // return;
                Console.WriteLine(ex.Message);
            }
            //}
        }


        private void PrintPreview(PrintDocument pd)
        {
            PrintPreviewDialog dlg = new PrintPreviewDialog();

            dlg.Document = pd;

            dlg.ShowDialog(); 

        }

        private int getYc(double cm)
        {
            return (int)(cm / 25.4) * 100;
        }

    }
}
