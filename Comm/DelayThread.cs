using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Comm
{
    public class DelayThread
    {
        // private Thread m_thread;

        public DelayThread()
        {

        }

        public void DoWork(ThreadStart thdel)
        {
            if (thdel != null)
            {
                Thread th = new Thread(thdel);
                th.Start();
            }

        }

        public void DoWorkWithPara(ParameterizedThreadStart thdel, object para)
        {
            if (thdel != null)
            {
                Thread th = new Thread(thdel);
                th.Start(para);
            }


        }

    }
}
