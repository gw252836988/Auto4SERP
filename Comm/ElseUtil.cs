using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comm
{
    public class ElseUtil
    {
        public static string ReturnZero(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "0";
            else
                return str;


        }

        public static string RO(object o)
        {
            if (o != null)
                return o.ToString();
            else
                return "";


        }
        public static string GetCarAutoNumberPre()
        {
            string pre1 = "";
            string organname = Comm.LoginInfoShare.getInstance().OrganName;
            if (organname.Contains("别克"))
            {
                pre1 ="BKX";
            }
            else if (organname.Contains("雪佛兰"))
            {
                pre1="XFL";
            }
            else if (organname.Contains("荣威"))
            {
                pre1= "RWX";
            }
            else if (organname.Contains("奔驰"))
            {
                pre1= "BCX";
            }
            else if (organname.Contains("宝马"))
            {
                pre1= "BMW";
            }
            else if (organname.Contains("广汽本田"))
            {
                pre1= "GBX";
            }
            else if (organname.Contains("一汽丰田"))
            {
                pre1 = "YFT";
            }
            else if (organname.Contains("广汽丰田"))
            {
                pre1 = "GFT";
            }
            else if (organname.Contains("现代"))
            {
                pre1 = "XDX";
            }
            else if (organname.Contains("大众"))
            {
                pre1 = "DZX";
            }
            else
            {
                pre1= "XXX";
            }

            return pre1 + Comm.LoginInfoShare.getInstance().OrganId.Trim();
        }

    }
}
