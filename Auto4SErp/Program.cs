using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Auto4SErp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

#if !DEBUG
            if (args.Length == 0)
            {
                Process.Start("AutoUpdate.exe");
                Application.Exit();
                return;
            }
            if (!args[0].StartsWith("ok"))
            {
                Application.Exit();
                return;
            }
#endif


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());

            frmLogin loginfrm = new frmLogin();
            loginfrm.ShowDialog();
            if (DialogResult.OK == loginfrm.DialogResult)
            {
                Application.Run(new frmMainDocking());
            }
        }
    }
}
