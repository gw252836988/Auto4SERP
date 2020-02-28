using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Comm
{
    public class RegexComm
    {
         //private const string REG_DATE   = @"^(\d{2}|\d{4})[\-\/]((0?[1-9])|(1[0-2]))[\-\/]((0?[1-9])|((1|2)[0-9])|30|31)$"; 
        private const string REG_DATE = @"^(\d{2}|\d{4})((0[1-9])|(1[0-2]))((0[1-9])|((1|2)[0-9])|30|31)$";
        private const string REG_PHONE = @"^((0[0-9]{2,3}){0,1}([0-9]{7,8}))$";
        //  private const string REG_EMAIL = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        private const string REG_EMAIL = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        private const string REG_MOBILE = @"(^0{0,1}1[0-9][0-9]{9}$)";
        private const string REG_IDCARD = @"^([0-9]{14}|[0-9]{17})(X|x|[0-9]){1}$";
        // private const string REG_TIME = @"^((([0-1]?[0-9])|(2[0-3]))([\:])([0-5][0-9]))$";


        // private const string REG_TIME = @"^(?:(?!0000)[0-9]{4}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1[0-9]|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26])|(?:0[48]|[2468][048]|[13579][26])00)-02-29)$";
        private const string REG_TIME = @"((^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(10|12|0?[13578])([-\/\._])(3[01]|[12][0-9]|0?[1-9])$)|(^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(11|0?[469])([-\/\._])(30|[12][0-9]|0?[1-9])$)|(^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(0?2)([-\/\._])(2[0-8]|1[0-9]|0?[1-9])$)|(^([2468][048]00)([-\/\._])(0?2)([-\/\._])(29)$)|(^([3579][26]00)([-\/\._])(0?2)([-\/\._])(29)$)|(^([1][89][0][48])([-\/\._])(0?2)([-\/\._])(29)$)|(^([2-9][0-9][0][48])([-\/\._])(0?2)([-\/\._])(29)$)|(^([1][89][2468][048])([-\/\._])(0?2)([-\/\._])(29)$)|(^([2-9][0-9][2468][048])([-\/\._])(0?2)([-\/\._])(29)$)|(^([1][89][13579][26])([-\/\._])(0?2)([-\/\._])(29)$)|(^([2-9][0-9][13579][26])([-\/\._])(0?2)([-\/\._])(29)$))";




        #region 半角验证
        /// <summary>
        /// 半角验证
        /// </summary>
        /// <param name="str">验证的字符串</param>
        /// <returns></returns>
        public static bool IsDBC(string str)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            int byteCount = encoding.GetByteCount(str);
            int strLen = str.Length;

            if (strLen == byteCount)
            {
                return true;
            }

            return false;
        }
        #endregion

        #region 全角验证
        /// <summary>
        /// 全角验证
        /// </summary>
        /// <param name="str">验证的字符串</param>
        /// <returns></returns>
        public static bool IsSBC(string str)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            int byteCount = encoding.GetByteCount(str);
            int strLen = str.Length;

            if (byteCount == strLen * 3)
            {
                return true;
            }

            return false;
        }
        #endregion

        #region 日期字符串有效性验证
        /// <summary>
        /// 日期字符串有效性验证
        /// </summary>
        /// <param name="date">日期字符串</param>
        /// <returns>有效:true,否则:false</returns>
        public static bool IsValidDate(string date)
        {
            return Regex.IsMatch(date, RegexComm.REG_DATE);
        }
        #endregion

        #region Email有效性验证
        /// <summary>
        /// Email有效性验证
        /// </summary>
        /// <param name="email">Email字符串</param>
        /// <returns>有效:true,否则:false</returns>
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, RegexComm.REG_EMAIL);
        }
        #endregion



        #region 电话号码有效性验证
        /// <summary>
        /// 电话号码有效性验证
        /// </summary>
        /// <param name="phone">电话号码字符串</param>
        /// <returns>有效:true,否则:false</returns>
        public static bool IsVaildPhone(string phone)
        {
            return Regex.IsMatch(phone, RegexComm.REG_PHONE);
        }
        #endregion

        #region 手机号码有效性验证
        /// <summary>
        /// 手机号码有效性验证
        /// </summary>
        /// <param name="mobile">手机号码字符串</param>
        /// <returns>有效:true,否则:false</returns>
        public static bool IsValidMobile(string mobile)
        {
            return Regex.IsMatch(mobile, REG_MOBILE);
        }
        #endregion

        #region 身份证号有效性验证
        /// <summary>
        /// 身份证号有效性验证
        /// </summary>
        /// <param name="idCard">身份证号字符串</param>
        /// <returns>有效:true,否则:false</returns>
        public static bool IsValidIdCard(string idCard)
        {
            return Regex.IsMatch(idCard, RegexComm.REG_IDCARD);
        }
        #endregion

        #region 日期字符串转换成日期对象
        /// <summary>
        /// 日期字符串转换成日期对象
        /// </summary>
        /// <param name="date">日期字符串</param>
        /// <returns>日期对象</returns>
        public static DateTime CastDateTime(string date)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(date.Substring(0, 4));
            builder.Append("-");
            builder.Append(date.Substring(4, 2));
            builder.Append("-");
            builder.Append(date.Substring(6, 2));

            return Convert.ToDateTime(builder.ToString());
        }
        #endregion

        #region 日期对象转化成日期字符串
        /// <summary>
        /// 日期对象转化成日期字符串
        /// </summary>
        /// <param name="date">日期对象</param>
        /// <returns>日期字符串</returns>
        public static string CastDateTime(DateTime date)
        {
            string strDate = date.ToString("yyyy-MM-dd");
            strDate = strDate.Replace("-", "");
            return strDate;
        }
        #endregion

        #region 时间格式验证
        /// <summary>
        /// 时间格式验证
        /// </summary>
        /// <param name="time">时间字符串</param>
        /// <returns>正确:true,错误:false</returns>
        public static bool IsValidTime(string time)
        {
            return Regex.IsMatch(time, REG_TIME);
        }
        #endregion






        #region IsInt32 验证字符串是否整数
        /// <summary>
        /// 验证字符串是否整数
        /// </summary>
        /// <param name="input">要验证的字符串</param>
        /// <returns>正确:true,错误:false</returns>
        public static bool IsInt32(string input)
        {
            string regexString = @"^\d+$";

            return Regex.IsMatch(input, regexString);
        }
        #endregion

        #region IsDouble 验证字符串是否浮点数字
        /// <summary>
        /// 验证字符串是否浮点数字
        /// </summary>
        /// <param name="input">要验证的字符串</param>
        /// <returns>正确:true,错误:false</returns>
        public static bool IsDouble(string input)
        {
            string regexString = @"^(\d+)(\.|\.\d+)?$";

            // return Regex.IsMatch(input, regexString);
            if (Regex.IsMatch(input, regexString))
            {
                double k = Convert.ToDouble(input);
                if (k >= 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        #endregion
        #region  验证是否为空
        /// <summary>
        /// 验证是否为空
        /// </summary>
        /// <param name="input">要验证的字符串</param>
        /// <returns>正确:true,错误:false</returns>
        public static bool IsValid(string input)
        {
            if (input.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 验证最大长度
        /// <summary>
        /// 验证最大长度
        /// </summary>
        /// <param name="k">最大的长度</param>
        /// <param name="input">要验证的字符串</param>
        /// <returns>正确:true,错误:false</returns>
        public static bool IsMaxlength(int k, string input)
        {
            if (input.Length > k)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region 验证最小长度
        /// <summary>
        /// 验证最小长度
        /// </summary>
        /// <param name="k">最小的长度</param>
        /// <param name="input">要验证的字符串</param>
        /// <returns>正确:true,错误:false</returns>
        public static bool IsMinlength(int k, string input)
        {
            if (input.Length < k)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion


        #region 验证最小，最大长度
        /// <summary>
        /// 验证最小，最大长度
        /// </summary>
        /// <param name="i">最小的长度</param>
        /// <param name="k">最大的长度</param>
        /// <param name="input">要验证的字符串</param>
        /// <returns>正确:true,错误:false</returns>
        public static bool IsMinMaxlength(int i, int k, string input)
        {
            if (input.Length > k)
            {
                return false;
            }
            else if (input.Length < i)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion


        public static string  CompositeValid(string validType,string validValue)
        {
            string  result="";
            switch (validType)
            {
                case "Mobile" :
                    if (!IsValidMobile(validValue)) result = "请输入正确手机格式";
                    
                break;

                case "Phone":
                    if (!IsVaildPhone(validValue)) result = "电话正确格式如:86721888";
                break;

                case "Identity":
                   if (!IsValidIdCard(validValue)) result = "请输入正确身份证格式";
                     break;
            

                case "Double":
                     if (!IsDouble(validValue)) result = "请输入小数格式";
                     break;

                default:
                break;



            }

            return result;

        }



    }




    
}
