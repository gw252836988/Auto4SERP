using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
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


        private MainWindowState()
        {
          //  mlstFormName = new List<string>();
            m_lstSelOrgan = new List<Organ>();
            
        }

       // public void AddFormName()
        private List<Organ> m_lstSelOrgan;

        public List<Organ> SelOrgan
        {
            get { return m_lstSelOrgan; }
            set
            {

                if (value.Count < 0) return;
                m_lstSelOrgan.Clear();
                m_lstSelOrgan.AddRange(value);
                // m_lstSelOrgan = value; 

                m_lstSelOrgan = m_lstSelOrgan.OrderBy(o => o.Region).ToList();

                //m_lstSelOrgan.Sort(delegate(Organ t1, Organ t2)
                //{
                //    int res = 0;
                //    if ((t1 == null) && (t2 == null))
                //    {
                //        return 0;
                //    }
                //    else if ((t1 != null) && (t2 == null))
                //    {
                //        return 1;
                //    }
                //    else if ((t1 == null) && (t2 != null))
                //    {
                //        return -1;
                //    }

                //    if (t1.Region > t2.Region)
                //    {
                //        res = 1;
                //    }
                //    else if (t1.Region < t2.Region)
                //    {
                //        res = -1;
                //    }
                //    return res;
                //}
                //);
            }
        }

        public IWindowsState WayOfState
        {
            get;
            set;
        }


        private bool isVipConnected;

        public bool IsVipConnected
        {
            get { return isVipConnected; }
            set { isVipConnected = value; }
        }
        private bool isPersonConneted;

        public bool IsPersonConneted
        {
            get { return isPersonConneted; }
            set { isPersonConneted = value; }
        }

    }
}
