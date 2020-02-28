using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
namespace Bll
{
    public class FunctionBllWS:IFucntion
    {
        private Bll.functionws.FunctionOfService mWS;

        public FunctionBllWS()
        {
           // ServiceReference1.Service1SoapClient aa = new ServiceReference1.Service1SoapClient();

            mWS = new Bll.functionws.FunctionOfService();
        }

        public DataTable GetMenus()
        {
            return mWS.GetMenus();
        }

        public void EnableFunction(int positionId, string nodeId)
        {
            mWS.EnableFunction(positionId ,nodeId); 
        }



        public void EnableFunctions(int positionId, string nodePrex)
        {
            mWS.EnableFunctions(positionId,nodePrex);
        }

        public string[] GetFunctionsOfPosition(int positionId)
        {
            return mWS.GetFunctionsOfPosition(positionId);

        }

        public void CancelFunction(int positionId, string nodeId)
        {
              mWS.CancelFunction(positionId,nodeId);

        }
        public void CancelFunctions(int positionId, string nodePrex)
        {
            mWS.CancelFunctions(positionId,nodePrex);

        }

        public  DataTable GetAwards()
        {

             return  mWS.GetAwards();

        }

    }
}
