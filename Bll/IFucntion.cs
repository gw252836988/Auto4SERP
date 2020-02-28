﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Bll
{
    public interface IFucntion
    {

        DataTable GetMenus();
        void EnableFunction(int positionId, string nodeId);
        void EnableFunctions(int positionId, string nodePrex);
        string[] GetFunctionsOfPosition(int positionId);
        void CancelFunction(int positionId, string nodeId);
        void CancelFunctions(int positionId, string nodePrex);
        DataTable GetAwards();
    }
}
