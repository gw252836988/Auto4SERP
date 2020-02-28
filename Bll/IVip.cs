using System;
using System.Data;
namespace Bll
{
    public interface IVip
    {
        Model.VipInfo GetVipInfoByCardID(string cardID);
        bool VipAccept(string cardid, double  je, string category, string remark, string Operater, string Organ, string DH);
        bool IsBalanceEnough(double vipJE, string cardNo);
        bool IsValidateByPwd(string cardid, string pwd);
        DataTable GetDepositRecord(string cardno);
        
    }
}
