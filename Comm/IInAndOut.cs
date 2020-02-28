using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Comm
{
    public interface IInAndOut
    {

        DataTable InDataToDT();
        void DTOutTo(DataTable dt);
      

    }
}
