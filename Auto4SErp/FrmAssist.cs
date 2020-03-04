using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bll;
using System.Collections;
using System.Reflection;
using DevComponents.DotNetBar.Controls;

using Comm;
using System.Windows.Forms;
using Model;

//change test
namespace Auto4SErp
{
    public delegate void ErrorInfoDelegate(string controlname, string infotext);
    public delegate void ErrorRemoveDelegate(string controlname);
    public class FrmAssist
    {



        public event ErrorInfoDelegate EErrorInfo;
        public event ErrorRemoveDelegate EErrorRemove;
        //更新DataTable列头名
        public static void UpdateColumns(ref DataTable dtDic, DataTable dtDest, int typeId)
        {

            if (dtDic == null)
            {
                IDiction iDictoinary = BllFactory.GetDictionaryBll();
                dtDic = iDictoinary.GetDictionaryByTypeId(typeId);
            }

            //形成哈希表
            Hashtable htTemp = new Hashtable();
            foreach (DataRow dr in dtDic.Rows)
            {
                htTemp.Add(dr[2].ToString(), dr[3].ToString());

            }




            foreach (DataColumn column in dtDest.Columns)
            {

                if (htTemp[column.ColumnName] != null)
                {
                    column.ColumnName = htTemp[column.ColumnName].ToString();
                }


            }




        }


        public bool ValidIn(List<Pair> lstPairs)
        {

            foreach (Pair p in lstPairs)
            {
                //  Console.WriteLine(objDE.Key.ToString());
                // Console.WriteLine(objDE.Value.ToString());

                string[] strtmpl = p.Value.ToString().Split('_');
                if (strtmpl[1].Substring(0, 1) == "N")
                {
                    if (strtmpl[0] == "")
                    {
                        if (EErrorInfo != null)
                            EErrorInfo(p.Key.ToString(), "不能为空");
                        // ShowMessage(FindTextByControlName(objDE.Key.ToString(), controls) + "不能为空");
                        return true;
                    }
                    else
                    {
                        EErrorRemove(p.Key.ToString());
                    }

                }
                else
                {

                    if (strtmpl[0] == "")
                    {
                        EErrorRemove(p.Key.ToString());
                        continue;
                    }

                }
                if (strtmpl[1].Length > 1)
                {
                    string validResult = RegexComm.CompositeValid(strtmpl[1].Substring(1), strtmpl[0]);
                    if (validResult != "")
                    {

                        if (EErrorInfo != null)
                            EErrorInfo(p.Key.ToString(), validResult);
                        //ShowMessage(FindTextByControlName(objDE.Key.ToString(), controls) + "格式不对");
                        return true;
                    }
                    else
                        EErrorRemove(p.Key.ToString());

                }

            }
            return false;
        }


        //public bool ValidControl(Control c)
        //{
        //    string strTag=c.Tag.ToString();
        //    string strValueOfValid="";
        //    if (strTag.Length > 1)
        //    {
        //        if (c.Name.Substring(0, 3) == "txt")
        //        {
        //            TextBox txt = c as TextBox;
        //            if (txt != null) strValueOfValid = txt.Text;
        //            if (RegexComm.CompositeValid(strTag.Substring(1), strValueOfValid))
        //            {
        //                return true;
        //            }

        //        }


        //    }
        //    return false;
        //}


        protected void ShowMessage(string msg)
        {

            MessageBox.Show(msg);
        }

        //放到窗体中


        //private string FindTextByControlName(string strName,Control.ControlCollection controls)
        //{

        //    foreach (Control c in controls)
        //    {
        //        LabelX cTB = c as LabelX;
        //        if (cTB != null)
        //        {
        //            if (cTB.Name.Substring(3) == strName)
        //                return cTB.Text;

        //        }
        //    }

        //    return "";
        //}
        public static T PopulateEntityFromCollection<T>(T entity, List<Pair> lstPairs) where T : new()
        {
            //初始化 如果为null
            if (entity == null)
            {
                entity = new T();
            }
            //得到类型
            Type type = typeof(T);
            //取得属性集合
            PropertyInfo[] pi = type.GetProperties();
            foreach (PropertyInfo item in pi)
            {
                //给属性赋值,需先分解附带的验证信息

                string strValue = FindValueByName(item.Name, lstPairs);
                if (strValue != "")
                {
                    string[] strlst = strValue.Split('_');

                    item.SetValue(entity, Convert.ChangeType(strlst[0], item.PropertyType), null);
                }
            }
            return entity;
        }

        private static string FindValueByName(string keyname, List<Pair> lstPairs)
        {
            //Organ o = (from os in m_listorgan
            //           where os.OrganName==oname
            //           select os).First();

            var v = (from o in lstPairs where o.Key == keyname select o);
            if (v.Count() > 0)
            {
                return v.First().Value;

            }
            // Pair obj = (from o in lstPairs where o.Key == keyname select o).First();
            //if (obj != null)
            //{
            //    return obj.Value;
            //}
            return "";
        }

    }
}
