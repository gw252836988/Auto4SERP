using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comm
{
    public class MainWindowState
    {
        private static MainWindowState m_instance = null;

        public static MainWindowState getInstance()
        {
            if (m_instance == null)
            {
                m_instance = new MainWindowState();

           
            }
            return m_instance;
        }

        public IWindowsState WayOfState
        {
            get;
            set;
        }


    }
}
