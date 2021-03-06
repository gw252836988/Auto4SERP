﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtil;
using Comm;
using System.Data;
using Model;
namespace Bll.Repair
{
   public  class RepairItemBll : Bll.Repair.IRepairItem , Bll.IBatchIn
    {

        private DBHelper mDB;
      
        public RepairItemBll()
        {
            mDB = DBHelperShare.getInstance();
        }

        public DataTable GetRepairTypes()
        {
            string organid=Comm.LoginInfoShare.getInstance().OrganId;
            string sql ;
            if (organid == "258" || organid == "608")
                sql = "select * from repairtype";
            else
                sql = "SELECT *   from repairtype WHERE     (TypeCode LIKE 'JD%') OR  (TypeCode LIKE 'BJ%') OR (TypeCode LIKE 'YQ%') OR  (TypeCode LIKE 'ZH%') OR    (TypeCode LIKE 'MR%')";
            DataTable dt = mDB.ExecuteDataTable(sql);

            return dt;

        }
       
        public DataTable GetRepairTypeByCode(string code)
        {
            string sql = string.Format("select * from repairtype where typecode ='" + code +"'");
            DataTable dt = mDB.ExecuteDataTable(sql);
            return dt;

        }


        public void UpdateRepairType(string code,string typename)
        {
            string sql = string.Format("update repairtype set typename='{0}' where typecode='{1}'",typename,code);
            mDB.ExecuteNonQuery(sql);
        }

       public bool AddRootType(string typecode ,string typename)
       {
           string sql=string.Format("select * from repairtype where typecode ='" + typecode + "'");

           if (mDB.IsExists(sql))
           {
               return false;

           }
           else
           {
               sql = string.Format("insert into repairtype (typecode,typename) values('{0}','{1}')", typecode, typename);
               mDB.ExecuteNonQuery(sql);
               return true;
           }
       }

       public void AddChildType(string ptypecode,string typename)
       {
           string sql = string.Format("select Max(rtrim(typecode)) from repairtype  WHERE typecode  like '{0}%'", ptypecode);
           DataTable dt =mDB.ExecuteDataTable(sql);
           if (dt.Rows[0][0].ToString().Equals(ptypecode))
           {
               sql = string.Format("insert into repairtype (typecode,typename,parentcode) values('{0}','{1}','{2}')", ptypecode + "01", typename, ptypecode);
           }
           else
           {
               sql = string.Format("insert into repairtype (typecode,typename,parentcode) values(dbo.CreateRepariTypeCode('{0}'),'{1}','{0}')", ptypecode, typename);
           }
               mDB.ExecuteNonQuery(sql);
       }

       public void DelType(string typecode)
       {
           string sql = string.Format("delete from repairtype where typecode like '{0}%'", typecode);
           mDB.ExecuteNonQuery(sql);

       }

       public DataTable GetRepairItemsByCode(string typecode)
       {
           string sql = string.Format("select ltrim(ItemCode) as ItemCode,ItemName,ItemType,TypeOfWork,SpellCode from repairitem where itemtype like '" + typecode + "%'");
           DataTable dt;
           dt = mDB.ExecuteDataTable(sql);
           return dt;

       }

       public DataTable GetRepairItemsByQuery(string itemcode,string itemname)
       {
           string sql =string.Format( "select top 30  ltrim(ItemCode) as ItemCode,ItemName,ItemType,TypeOfWork,SpellCode from repairitem where ItemCode like '%{0}%' and itemname like '%{1}%'",itemcode,itemname);
           DataTable dt;
           dt = mDB.ExecuteDataTable(sql);
           return dt;
       }

       public void AddRepariItem(RepairItem obj)
       {
           string sql = string.Format("select * from repairitem WHERE itemcode  like '{0}%'", obj.ItemType);
           if(!mDB.IsExists(sql))
           {
               sql = string.Format("insert into repairitem(itemcode,itemname,itemtype,spellcode) values('{0}' ,'{1}','{2}','{3}')", obj.ItemType + "001", obj.ItemName, obj.ItemType,obj.SpellCode);
           
           }
           else
               sql = string.Format("insert into repairitem(itemcode,itemname,itemtype,spellcode) values(dbo.CreateRepariItemCode('{0}') ,'{1}','{0}','{2}')", obj.ItemType, obj.ItemName, obj.SpellCode);
           mDB.ExecuteNonQuery(sql);
       }

       public void UpdateRepairItem(RepairItem obj)
       {

           string sql = string.Format("update repairitem set itemname='{0}',spellcode='{2}' where itemcode ='{1}'",obj.ItemName,obj.ItemCode,obj.SpellCode);
           mDB.ExecuteNonQuery(sql);
       }

       public void DeleteRepairItem(string itemcode)
       {
           string sql = string.Format("Delete from repairitem  where itemcode ='{0}'", itemcode);
           mDB.ExecuteNonQuery(sql);

       }

       public DataTable GetRepariItemBySpell(string spell)
       {
           if (string.IsNullOrEmpty(spell)) return null;
           DataTable dt;
           string sql =string.Format("select top 20 itemcode,itemname,priceid from v_repairitem  where spellcode like '%{0}%'  and carlevel=0",spell);
           dt = mDB.ExecuteDataTable(sql);
           return dt;
       }

       public DataTable GetRepairItemAndPrice(string id)
       {
           string sql = string.Format("select * from v_repairitem where priceid={0}",id);
           return mDB.ExecuteDataTable(sql);

       }

       public DataTable GetRepairItemByCode(string itemcode)
       {

           string sql = string.Format("select * from repairitem where rtrim(itemcode)='{0}'",itemcode.Trim()) ;
           return mDB.ExecuteDataTable(sql);
       }

       public DataTable GetRepairPriceByID(string id)
       {
           DataTable dt = null;
           string sql = string.Format("select * from repitemprice where id={0}", id);

           dt = mDB.ExecuteDataTable(sql);
        
           return dt;

       }
        
       public string BatchInDB(DataTable dt,string append)
       {
           try
           {
               string sql = "";
               DelTempRecord();
               mDB.BatchInsert("tmp_repairitem", dt);

               sql = "insert into repairitem([ItemCode],[ItemName],[ItemType],[TypeOfWork],[SpellCode]) select * from tmp_repairitem";
               mDB.ExecuteNonQuery(sql);
           }
           catch (Exception e)
           {
               DelTempRecord();

               return e.Message.ToString();

           }
           return "";

       }

       private void DelTempRecord()
       {

           mDB.ExecuteNonQuery("delete from tmp_repairitem");

       }

    }
}
