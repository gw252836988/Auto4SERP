using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.organws;
using System.Data;
using DBUtil;
using Model;
using Comm;
namespace Bll.Personnel
{
    public class OrganBllWS  :IOrgan
    {
        private OrganOfService mWS;



        public OrganBllWS()
        {
            mWS = new OrganOfService();

        }


        public DataTable GetRegions()
        {
            return mWS.GetRegions();
        }

        public DataTable GetOrgans()
        {
            return mWS.GetOrgans();
        }


        public List<Organ> GetAllOrgans()
        {
            ConnectionStringFactory cf = ConnectionStringFactory.getInstance();
            List<Organ> lstOrgan = cf.GetAllOrgans();
            return lstOrgan;

        }

        public void AssginToConnString()
        {
            DataTable dtOrgans = GetOrgans();
            ConnectionStringFactory cf = ConnectionStringFactory.getInstance();
            List<Organ> lstOrgan = cf.GetAllOrgans();
            if (lstOrgan.Count > 0) return;
            lstOrgan.Clear();
            for (int i = 0; i < dtOrgans.Rows.Count; i++)
            {
                //lstOrgan.Add(new Organ(dtOrgans.Rows[i]["organname"].ToString(), , "永兴别克", "USER-20141029VC", "sa", "123", "", 0));
                lstOrgan.Add(new Organ(dtOrgans.Rows[i]["organid"].ToString().Trim(), dtOrgans.Rows[i]["organname"].ToString().Trim(), dtOrgans.Rows[i]["IP"].ToString().Trim(), "sa", dtOrgans.Rows[i]["PassWord"].ToString(), Comm.ElseUtil.ReturnZero(dtOrgans.Rows[i]["Url"].ToString()), int.Parse(dtOrgans.Rows[i]["RegionID"].ToString())));

            }

        }


        public string GetOrganName(string organid)
        {
            ConnectionStringFactory cf = ConnectionStringFactory.getInstance();
            Organ obj = cf.ReturnOrganById(organid);
            if (obj != null)
                return obj.OrganName;
            else
                return "";
        }


        public List<Region> GetListRegion()
        {
            ConnectionStringFactory cf = ConnectionStringFactory.getInstance();
            return cf.ReturnListRegion();


        }


        public Organ GetOrganObject(string organid)
        {
            ConnectionStringFactory cf = ConnectionStringFactory.getInstance();
            Organ obj = cf.ReturnOrganById(organid);
            if (obj != null)
                return obj;
            else
                return null;


        }

        public Organ GetOrganObjectByName(string name)
        {
            ConnectionStringFactory cf = ConnectionStringFactory.getInstance();
            Organ obj = cf.ReturnOrganByName(name);
            if (obj != null)
                return obj;
            else
                return null;
        }


        public void SetNewOrgan(string neworganid)
        {
            DBHelperShare.SetNewOrgan(neworganid);
            
        }


        public  List<Organ> GetSelOrganByLst(List<string> lststr)
        {
            List<Organ> lstOrgan = new List<Organ>();
            foreach (string str in lststr)
            {
                Organ o = GetOrganObject(str);
                if(o!=null)
                    lstOrgan.Add(o);

            }
            return lstOrgan;

        }

    }
}
