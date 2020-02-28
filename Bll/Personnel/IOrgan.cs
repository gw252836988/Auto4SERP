using System;
using Model;
using System.Collections.Generic;
namespace Bll.Personnel
{
    public  interface IOrgan
    {
        System.Data.DataTable GetOrgans();
        System.Data.DataTable GetRegions();
        void AssginToConnString();
        string GetOrganName(string organid);
        Organ GetOrganObject(string organid);
        void SetNewOrgan(string neworganid);
        List<Organ> GetSelOrganByLst(List<string> lststr);
        Organ GetOrganObjectByName(string name);
        List<Organ> GetAllOrgans();
        List<Region> GetListRegion();
    }
}
